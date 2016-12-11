using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using SnmpSharpNet;
using SNMPBrowser.Properties;

namespace SNMPBrowser {
    public partial class MainForm : Form {
        private DataGridView _dataGridView;
        private DataGridView _trapGridView;

        readonly TabPage _trapTabPage = new TabPage("Trap Receiver");

        private SnmpClient _snmpClient;
        private string _selectedOperation;

        private const string GetRequest = "GetRequest";
        private const string GetNextRequest = "GetNextRequest";
        private const string GetTable = "GetTable";
        private const string Monitor = "Monitor";
        private const string Listen = "Listen";

        public MainForm() {
            InitializeComponent();
            CreateDataGrid();
            CreateTrapGridView();
            CreateSnmpClient();
        }

        private void CreateDataGrid() {
            _dataGridView = new DataGridView();
            _dataGridView.Columns.Add("oidColumn", "OID");
            _dataGridView.Columns.Add("valueColumn", "Value");
            _dataGridView.Columns.Add("typeColumn", "Type");
            _dataGridView.Size = tabControl.SelectedTab.Size;
            tableTabPage.Controls.Add(_dataGridView);
            _dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void CreateTrapGridView() {
            _trapGridView = new DataGridView();
            _trapGridView.Columns.Add("versionColumn", "SNMP Version");
            _trapGridView.Columns.Add("oidColumn", "OID");
            _trapGridView.Columns.Add("valueColumn", "Value");
            _trapGridView.Columns.Add("typeColumn", "Type");
            _trapGridView.Columns.Add("timeColumn", "Time");
            _trapGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

        }

        private void CreateSnmpClient() {
            _snmpClient = new SnmpClient();
            _snmpClient.OnTrapRecieved += (sender, snmpPacket) => BeginInvoke(new Action(() => ReceiveTrap(sender, snmpPacket)));
        }

        private void ReceiveTrap(object sender, SnmpPacket snmpPacket) {
            foreach (var vb in snmpPacket.Pdu.VbList) {
                _trapGridView.Rows.Add(snmpPacket.Version, vb.Oid.ToString(), vb.Value.ToString(), SnmpConstants.GetTypeName(vb.Value.Type),
                    DateTime.Now.ToString("G"));
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            operationComboBox_Initialize();
        }

        private void operationComboBox_Initialize() {
            operationComboBox.Items.Add(GetRequest);
            operationComboBox.Items.Add(GetNextRequest);
            operationComboBox.Items.Add(GetTable);
            operationComboBox.Items.Add(Listen);
            operationComboBox.Items.Add(Monitor);
            
            operationComboBox.SelectedItem = GetRequest;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedOperation = operationComboBox.SelectedItem.ToString();
        }

        private void ShowResult(Dictionary<Oid, AsnType> result) {
            if (result == null) {
                ErrorMessageBox.Show("Request failed.");
            }
            else {
                foreach (KeyValuePair<Oid, AsnType> entry in result) {
                    if (entry.Value.ToString().Equals("Null")) {
                        ErrorMessageBox.Show("Request failed.");
                    }
                    else {
                        _dataGridView.Rows.Add(entry.Key.ToString(), entry.Value.ToString(),
                            SnmpConstants.GetTypeName(entry.Value.Type));
                    }
                }
            }
        }

        private void goButton_Click(object sender, EventArgs e) {
            switch (_selectedOperation) {
                case GetRequest:
                    ShowResult(_snmpClient.GetRequest(oidTextBox.Text));
                    break;
                case GetNextRequest:
                    ShowResult(_snmpClient.GetNextRequest(oidTextBox.Text));
                    break;
                case GetTable:
                    ShowResult(_snmpClient.GetTable(oidTextBox.Text));
                    break;
                case Monitor:
                    MonitorObject(oidTextBox.Text);
                    break;
                case Listen:
                    _snmpClient.Listen();

                    tabControl.TabPages.Add(_trapTabPage);
                    _trapTabPage.Controls.Add(_trapGridView);
                    _trapGridView.Size = _trapTabPage.Size;
                    _trapTabPage.Controls.Add(_trapGridView);

                    tabControl.SelectedTab = _trapTabPage;
                    break;
            }
        }

        private void MonitorObject(string oid) {
            var timer = new Timer {Interval = Settings.Default.MonitorInterval};
            timer.Tick += (sender, eventArgs) => OnTick(sender, eventArgs, oid);
            timer.Start();
            //TODO List of running tasks so user could stop them. Maybe binding TabPanel with actions?
        }

        private void OnTick(object sender, EventArgs e, string oid) {
            ShowResult(_snmpClient.GetRequest(oid));
        }

        private void removeButton_Click(object sender, EventArgs e) {
            var selectedTab = tabControl.SelectedTab;

            if (selectedTab.Equals(tableTabPage)) {
                selectedTab.Controls.Remove(_dataGridView);
                CreateDataGrid();
            }
            else {
                tabControl.TabPages.Remove(selectedTab);
            }
        }
    }
}