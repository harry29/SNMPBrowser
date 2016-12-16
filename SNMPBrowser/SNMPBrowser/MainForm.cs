using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SnmpSharpNet;
using SNMPBrowser.Properties;

namespace SNMPBrowser {
    public partial class MainForm : Form {
        private SnmpClient _snmpClient;
        private string _selectedOperation;

        private const string GetRequest = "GetRequest";
        private const string GetNextRequest = "GetNextRequest";
        private const string GetTable = "GetTable";
        private const string Monitor = "Monitor";
        private const string Listen = "Listen";

        public MainForm() {
            InitializeComponent();
            InitializeSnmpClient();
            operationComboBox_Initialize();
        }

        private void InitializeSnmpClient() {
            _snmpClient = new SnmpClient();
            _snmpClient.OnTrapRecieved +=
                (sender, snmpPacket) => BeginInvoke(new Action(() => ReceiveTrap(sender, snmpPacket)));
        }

        private void operationComboBox_Initialize() {
            operationComboBox.Items.Add(GetRequest);
            operationComboBox.Items.Add(GetNextRequest);
            operationComboBox.Items.Add(GetTable);
            operationComboBox.Items.Add(Listen);
            operationComboBox.Items.Add(Monitor);

            operationComboBox.SelectedItem = GetRequest;
        }

        private void ReceiveTrap(object sender, SnmpPacket snmpPacket) {
            foreach (var vb in snmpPacket.GetValues()) {
                trapListenerDataGridView.Rows.Add(vb.Oid.ToString(), vb.Value.ToString(),
                    SnmpConstants.GetTypeName(vb.Value.Type),
                    DateTime.Now.ToString("G"), snmpPacket.Version);
            }
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedOperation = operationComboBox.SelectedItem.ToString();
        }

        private void ShowResult(Dictionary<Oid, AsnType> result, DataGridView target) {
            if (result == null) {
                ErrorMessageBox.Show("Request failed.");
            }
            else {
                foreach (KeyValuePair<Oid, AsnType> entry in result) {
                    if (entry.Value.ToString().Equals("Null")) {
                        ErrorMessageBox.Show("Request failed.");
                    }
                    else {
                         target.Rows.Add(entry.Key.ToString(), entry.Value.ToString(),
                                         SnmpConstants.GetTypeName(entry.Value.Type), DateTime.Now.ToLongTimeString());
                    }
                }
            }
        }

        private void goButton_Click(object sender, EventArgs e) {
            switch (_selectedOperation) {
                case GetRequest:
                    ShowResult(_snmpClient.GetRequest(oidTextBox.Text) , requestTableDataGridView);
                    break;
                case GetNextRequest:
                    ShowResult(_snmpClient.GetNextRequest(oidTextBox.Text), requestTableDataGridView);
                    break;
                case GetTable:
                    ShowResult(_snmpClient.GetTable(oidTextBox.Text), requestTableDataGridView);
                    break;
                case Monitor:
                    MonitorObject(oidTextBox.Text);
                    break;
                case Listen:
                    _snmpClient.Listen();
                    break;
            }
        }

        private void MonitorObject(string oid) {
            var timer = new Timer {Interval = Settings.Default.MonitorInterval};
            timer.Tick += (sender, eventArgs) => OnTick(sender, eventArgs, oid);
            timer.Start();
        }

        private void OnTick(object sender, EventArgs e, string oid) {
            ShowResult(_snmpClient.GetRequest(oid), monitorDataGridView);
        }

        private void removeButton_Click(object sender, EventArgs e) {
            var selectedTab = tabControl.SelectedTab;

            var selectedTabDataGridView = selectedTab.Controls[0] as DataGridView;
            selectedTabDataGridView?.Rows.Clear();
        }
    }
}