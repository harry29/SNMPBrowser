using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNMPBrowser {
    public partial class MainForm : Form {
        private SNMPClient clientSNMP = new SNMPClient();
        private string selectedOperation;

        private const string GET_REQUEST = "GetRequest";
        private const string GET_NEXT_REQUEST = "GetNextRequest";
        private const string OBSERVE = "Observe";

        public MainForm() {
            InitializeComponent();
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

        private void goButton_Click(object sender, EventArgs e) {
            switch (selectedOperation) {
                case GET_REQUEST:

                    break;
                case GET_NEXT_REQUEST:

                    break;
                case OBSERVE:

                    break;
            }
        }

        private void removeTabButton_Click(object sender, EventArgs e) {
            tabControl.TabPages.Remove(tabControl.SelectedTab);
        }
    }
}