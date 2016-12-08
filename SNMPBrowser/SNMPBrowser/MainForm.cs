using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SnmpSharpNet;

namespace SNMPBrowser {
    public partial class MainForm : Form {
        private DataGridView dataGridView;

        private SNMPClient clientSNMP = new SNMPClient();
        private string selectedOperation;

        private const string GET_REQUEST = "GetRequest";
        private const string GET_NEXT_REQUEST = "GetNextRequest";
        private const string OBSERVE = "Observe";

        public MainForm() {
            InitializeComponent();
            createDataGrid();
        }

        private void createDataGrid() {
            dataGridView = new DataGridView();
            dataGridView.Columns.Add("oidColumn", "OID");
            dataGridView.Columns.Add("valueColumn", "Value");
            dataGridView.Columns.Add("typeColumn", "Type");
            dataGridView.Size = tabControl.SelectedTab.Size;
            tabPage1.Controls.Add(dataGridView);
        }

        private void MainForm_Load(object sender, EventArgs e) {
            operationComboBox_Initialize();
        }

        private void operationComboBox_Initialize() {
            operationComboBox.Items.Add(GET_REQUEST);
            operationComboBox.Items.Add(GET_NEXT_REQUEST);
            operationComboBox.Items.Add(OBSERVE);

            operationComboBox.SelectedItem = GET_REQUEST;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectedOperation = operationComboBox.SelectedItem.ToString();
        }

        private void showResult(Dictionary<Oid, AsnType> result) {
            foreach (KeyValuePair<Oid, AsnType> entry in result) {
                if (entry.Value.ToString().Equals("Null")) {
                    MessageBox.Show("Request failed.", "SNMP Browser Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    dataGridView.Rows.Add(entry.Key.ToString(), entry.Value.ToString(), SnmpConstants.GetTypeName(entry.Value.Type));
                }
            }
        }

        private void goButton_Click(object sender, EventArgs e) {
            switch (selectedOperation) {
                case GET_REQUEST:
                    Dictionary<Oid, AsnType> result = clientSNMP.getRequest(oidTextBox.Text);

                    if (result == null) {
                        MessageBox.Show("Request failed.");
                    }
                    else {
                        showResult(result);
                    }                   

                    break;
                case GET_NEXT_REQUEST:
                    clientSNMP.getNextRequest(oidTextBox.Text);
                    break;
                case OBSERVE:
                    TabPage observeTabPage = new TabPage("Observe");
                    tabControl.TabPages.Add(observeTabPage);

                    clientSNMP.observe(oidTextBox.Text);

                    break;
            }
        }

        private void removeTabButton_Click(object sender, EventArgs e) {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }
    }
}