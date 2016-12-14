using EventLogProject;

namespace SNMPBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.goButton = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.requestTabPage = new System.Windows.Forms.TabPage();
            this.requestTableDataGridView = new System.Windows.Forms.DataGridView();
            this.oidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorTabPage = new System.Windows.Forms.TabPage();
            this.trapListenerTabPage = new System.Windows.Forms.TabPage();
            this.clearButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.oidTextBox = new EventLogProject.FilteredTextBox();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trapListenerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.requestTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestTableDataGridView)).BeginInit();
            this.monitorTabPage.SuspendLayout();
            this.trapListenerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trapListenerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Location = new System.Drawing.Point(300, 14);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(146, 21);
            this.operationComboBox.TabIndex = 2;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(238, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operation:";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(452, 12);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.requestTabPage);
            this.tabControl.Controls.Add(this.monitorTabPage);
            this.tabControl.Controls.Add(this.trapListenerTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(600, 388);
            this.tabControl.TabIndex = 1;
            // 
            // requestTabPage
            // 
            this.requestTabPage.Controls.Add(this.requestTableDataGridView);
            this.requestTabPage.Location = new System.Drawing.Point(4, 22);
            this.requestTabPage.Name = "requestTabPage";
            this.requestTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.requestTabPage.Size = new System.Drawing.Size(592, 362);
            this.requestTabPage.TabIndex = 0;
            this.requestTabPage.Text = "Request Table";
            this.requestTabPage.UseVisualStyleBackColor = true;
            // 
            // requestTableDataGridView
            // 
            this.requestTableDataGridView.AllowUserToAddRows = false;
            this.requestTableDataGridView.AllowUserToDeleteRows = false;
            this.requestTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requestTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.oidColumn,
            this.valueColumn,
            this.typeColumn,
            this.timeColumn});
            this.requestTableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.requestTableDataGridView.Name = "requestTableDataGridView";
            this.requestTableDataGridView.ReadOnly = true;
            this.requestTableDataGridView.Size = new System.Drawing.Size(592, 362);
            this.requestTableDataGridView.TabIndex = 1;
            // 
            // oidColumn
            // 
            this.oidColumn.HeaderText = "OID";
            this.oidColumn.Name = "oidColumn";
            this.oidColumn.ReadOnly = true;
            // 
            // valueColumn
            // 
            this.valueColumn.HeaderText = "Value";
            this.valueColumn.Name = "valueColumn";
            this.valueColumn.ReadOnly = true;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.ReadOnly = true;
            // 
            // monitorTabPage
            // 
            this.monitorTabPage.Controls.Add(this.monitorDataGridView);
            this.monitorTabPage.Location = new System.Drawing.Point(4, 22);
            this.monitorTabPage.Name = "monitorTabPage";
            this.monitorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.monitorTabPage.Size = new System.Drawing.Size(592, 362);
            this.monitorTabPage.TabIndex = 2;
            this.monitorTabPage.Text = "Monitor";
            this.monitorTabPage.UseVisualStyleBackColor = true;
            // 
            // trapListenerTabPage
            // 
            this.trapListenerTabPage.Controls.Add(this.trapListenerDataGridView);
            this.trapListenerTabPage.Location = new System.Drawing.Point(4, 22);
            this.trapListenerTabPage.Name = "trapListenerTabPage";
            this.trapListenerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.trapListenerTabPage.Size = new System.Drawing.Size(592, 362);
            this.trapListenerTabPage.TabIndex = 3;
            this.trapListenerTabPage.Text = "Trap Listener";
            this.trapListenerTabPage.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(533, 12);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "OID:";
            // 
            // oidTextBox
            // 
            this.oidTextBox.Location = new System.Drawing.Point(48, 14);
            this.oidTextBox.Name = "oidTextBox";
            this.oidTextBox.Size = new System.Drawing.Size(184, 20);
            this.oidTextBox.TabIndex = 6;
            // 
            // timeColumn
            // 
            this.timeColumn.HeaderText = "Time";
            this.timeColumn.Name = "timeColumn";
            this.timeColumn.ReadOnly = true;
            // 
            // monitorDataGridView
            // 
            this.monitorDataGridView.AllowUserToAddRows = false;
            this.monitorDataGridView.AllowUserToDeleteRows = false;
            this.monitorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monitorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.monitorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.monitorDataGridView.Name = "monitorDataGridView";
            this.monitorDataGridView.ReadOnly = true;
            this.monitorDataGridView.Size = new System.Drawing.Size(592, 362);
            this.monitorDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "OID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Time";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // trapListenerDataGridView
            // 
            this.trapListenerDataGridView.AllowUserToAddRows = false;
            this.trapListenerDataGridView.AllowUserToDeleteRows = false;
            this.trapListenerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trapListenerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.versionColumn});
            this.trapListenerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.trapListenerDataGridView.Name = "trapListenerDataGridView";
            this.trapListenerDataGridView.ReadOnly = true;
            this.trapListenerDataGridView.Size = new System.Drawing.Size(592, 362);
            this.trapListenerDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "OID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Value";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Type";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Time";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // versionColumn
            // 
            this.versionColumn.HeaderText = "SNMP Version";
            this.versionColumn.Name = "versionColumn";
            this.versionColumn.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oidTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "SNMP Browser";
            this.tabControl.ResumeLayout(false);
            this.requestTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestTableDataGridView)).EndInit();
            this.monitorTabPage.ResumeLayout(false);
            this.trapListenerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trapListenerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button clearButton;
        private FilteredTextBox oidTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage requestTabPage;
        private System.Windows.Forms.TabPage monitorTabPage;
        private System.Windows.Forms.TabPage trapListenerTabPage;
        private System.Windows.Forms.DataGridView requestTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn oidColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridView monitorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridView trapListenerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionColumn;
    }
}

