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

namespace SNMPTrapAgent {
    public partial class MainForm : Form {
        TrapAgent agent = new TrapAgent();

        // Variable Binding collection to send with the trap
        public VbCollection col = new VbCollection();

        public MainForm() {
            InitializeComponent();
        }

        private void addCollection() {
            col.Add(new Oid("1.3.6.1.2.1.1.1.0"), new OctetString("Test string"));
            col.Add(new Oid("1.3.6.1.2.1.1.2.0"), new Oid("1.3.6.1.9.1.1.0"));
            col.Add(new Oid("1.3.6.1.2.1.1.3.0"), new TimeTicks(2324));
            col.Add(new Oid("1.3.6.1.2.1.1.4.0"), new OctetString("Milan"));
        }

        private void notifyButton_Click(object sender, EventArgs e) {
            addCollection();
            //col.Add(new Oid(textBoxOID.Text), new OctetString(textBoxValue.Text));
            agent.SendV2Trap(new IpAddress(textBoxIpAddress.Text), Int32.Parse(textBoxPort.Text), textBoxCommunity.Text, 13433,
                 new Oid(textBoxOID.Text), col);
            col.Clear();
        }
    }
}
