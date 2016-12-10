namespace SNMPTrapAgent {
    partial class MainForm {
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
            this.notifyButton = new System.Windows.Forms.Button();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxCommunity = new System.Windows.Forms.TextBox();
            this.textBoxOID = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyButton
            // 
            this.notifyButton.Location = new System.Drawing.Point(197, 142);
            this.notifyButton.Name = "notifyButton";
            this.notifyButton.Size = new System.Drawing.Size(75, 23);
            this.notifyButton.TabIndex = 0;
            this.notifyButton.Text = "Notify";
            this.notifyButton.UseVisualStyleBackColor = true;
            this.notifyButton.Click += new System.EventHandler(this.notifyButton_Click);
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(101, 12);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(171, 20);
            this.textBoxIpAddress.TabIndex = 1;
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(101, 38);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(171, 20);
            this.textBoxPort.TabIndex = 2;
            // 
            // textBoxCommunity
            // 
            this.textBoxCommunity.Location = new System.Drawing.Point(101, 64);
            this.textBoxCommunity.Name = "textBoxCommunity";
            this.textBoxCommunity.Size = new System.Drawing.Size(171, 20);
            this.textBoxCommunity.TabIndex = 3;
            // 
            // textBoxOID
            // 
            this.textBoxOID.Location = new System.Drawing.Point(101, 90);
            this.textBoxOID.Name = "textBoxOID";
            this.textBoxOID.Size = new System.Drawing.Size(171, 20);
            this.textBoxOID.TabIndex = 4;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(101, 116);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(171, 20);
            this.textBoxValue.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Community:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Trap Object ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Value:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 169);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.textBoxOID);
            this.Controls.Add(this.textBoxCommunity);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.textBoxIpAddress);
            this.Controls.Add(this.notifyButton);
            this.Name = "MainForm";
            this.Text = "SMNP Trap Agent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button notifyButton;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxCommunity;
        private System.Windows.Forms.TextBox textBoxOID;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

