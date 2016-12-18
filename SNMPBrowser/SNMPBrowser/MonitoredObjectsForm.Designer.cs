namespace SNMPBrowser {
    partial class MonitoredObjectsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.monitoredObjectsListView = new System.Windows.Forms.ListView();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monitoredObjectsListView
            // 
            this.monitoredObjectsListView.Location = new System.Drawing.Point(12, 12);
            this.monitoredObjectsListView.Name = "monitoredObjectsListView";
            this.monitoredObjectsListView.Size = new System.Drawing.Size(260, 208);
            this.monitoredObjectsListView.TabIndex = 0;
            this.monitoredObjectsListView.UseCompatibleStateImageBehavior = false;
            this.monitoredObjectsListView.View = System.Windows.Forms.View.List;
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(116, 226);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(197, 226);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // MonitoredObjectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.monitoredObjectsListView);
            this.Name = "MonitoredObjectsForm";
            this.Text = "Monitored Objects";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView monitoredObjectsListView;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
    }
}