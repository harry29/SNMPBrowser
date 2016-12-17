using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SNMPBrowser {
    public partial class MonitoredObjectsForm : Form {
        private readonly Dictionary<string, Timer> _monitoredObjects;
        public MonitoredObjectsForm(ref Dictionary<string, Timer> monitoredObjects) {
            InitializeComponent();
            _monitoredObjects = monitoredObjects;
            monitoredObjectsListView_Populate(monitoredObjects);
        }

        private void monitoredObjectsListView_Populate(Dictionary<string, Timer> monitoredObjects) {
            foreach (var oid in monitoredObjects.Keys) {
                monitoredObjectsListView.Items.Add(oid);
            }
        }

        private void stopButton_Click(object sender, EventArgs e) {
            foreach (ListViewItem item in monitoredObjectsListView.SelectedItems) {
                RemoveFromMonitoredObjects(item);
            }
        }

        private void RemoveFromMonitoredObjects(ListViewItem monitoredObjectListViewItem) {
            var oid = monitoredObjectListViewItem.Text;

            _monitoredObjects[oid].Stop();
            _monitoredObjects.Remove(oid);
            monitoredObjectsListView.Items.Remove(monitoredObjectListViewItem);
        }

        private void closeButton_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
