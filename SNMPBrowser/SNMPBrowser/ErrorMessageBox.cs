using System.Windows.Forms;

namespace SNMPBrowser {
    public static class ErrorMessageBox {
        public static void Show(string message) {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
