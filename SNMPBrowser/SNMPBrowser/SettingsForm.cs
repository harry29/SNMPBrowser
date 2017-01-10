using System;
using System.Windows.Forms;

namespace SNMPBrowser
{
    public partial class SettingsForm : Form
    {
        private string _selectedItem;
        private SnmpSharpNet.SnmpVersion version;

        private const string Ver1 = "Ver1";
        private const string Ver2 = "Ver2";
        private const string Ver3 = "Ver3";
        public SettingsForm()
        {
            InitializeComponent();
            comboBox1_Initialize();
            hostTextBox.Text = Properties.Settings.Default.Host.ToString();
            communityTextBox.Text = Properties.Settings.Default.Community.ToString();
            intervalTextBox.Text = Properties.Settings.Default.MonitorInterval.ToString();
        }

        private void comboBox1_Initialize()
        {
            comboBox1.Items.Add(Ver1);
            comboBox1.Items.Add(Ver2);
            comboBox1.Items.Add(Ver3);

            comboBox1.SelectedItem = Ver2;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Host = hostTextBox.Text;
            Properties.Settings.Default.Community = communityTextBox.Text;
            Properties.Settings.Default.SnmpVersion = version;
            Properties.Settings.Default.MonitorInterval = int.Parse(intervalTextBox.Text);
            Properties.Settings.Default.Save();
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedItem = comboBox1.SelectedItem.ToString();
            if (_selectedItem == Ver1)
            {
                version = SnmpSharpNet.SnmpVersion.Ver1;
            }
            else if (_selectedItem == Ver2)
            {
                version = SnmpSharpNet.SnmpVersion.Ver2;
            }
            else
            {
                version = SnmpSharpNet.SnmpVersion.Ver3;
            }

        }
    }
}
