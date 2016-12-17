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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.requestTabPage = new System.Windows.Forms.TabPage();
            this.requestTableDataGridView = new System.Windows.Forms.DataGridView();
            this.oidColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monitorTabPage = new System.Windows.Forms.TabPage();
            this.monitorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trapListenerTabPage = new System.Windows.Forms.TabPage();
            this.trapListenerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableViewTabPage = new System.Windows.Forms.TabPage();
            this.tableViewDataGridView = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.oidTextBox = new EventLogProject.FilteredTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoredObjectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.requestTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requestTableDataGridView)).BeginInit();
            this.monitorTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataGridView)).BeginInit();
            this.trapListenerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trapListenerDataGridView)).BeginInit();
            this.tableViewTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableViewDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Location = new System.Drawing.Point(466, 27);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(146, 21);
            this.operationComboBox.TabIndex = 2;
            this.operationComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(404, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operation:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.requestTabPage);
            this.tabControl.Controls.Add(this.monitorTabPage);
            this.tabControl.Controls.Add(this.trapListenerTabPage);
            this.tabControl.Controls.Add(this.tableViewTabPage);
            this.tabControl.Location = new System.Drawing.Point(12, 53);
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
            // timeColumn
            // 
            this.timeColumn.HeaderText = "Time";
            this.timeColumn.Name = "timeColumn";
            this.timeColumn.ReadOnly = true;
            // 
            // monitorTabPage
            // 
            this.monitorTabPage.Controls.Add(this.monitorDataGridView);
            this.monitorTabPage.Location = new System.Drawing.Point(4, 22);
            this.monitorTabPage.Name = "monitorTabPage";
            this.monitorTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.monitorTabPage.Size = new System.Drawing.Size(592, 362);
            this.monitorTabPage.TabIndex = 2;
            this.monitorTabPage.Text = "Monitored Objects";
            this.monitorTabPage.UseVisualStyleBackColor = true;
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
            // tableViewTabPage
            // 
            this.tableViewTabPage.Controls.Add(this.tableViewDataGridView);
            this.tableViewTabPage.Location = new System.Drawing.Point(4, 22);
            this.tableViewTabPage.Name = "tableViewTabPage";
            this.tableViewTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.tableViewTabPage.Size = new System.Drawing.Size(592, 362);
            this.tableViewTabPage.TabIndex = 4;
            this.tableViewTabPage.Text = "Table View";
            this.tableViewTabPage.UseVisualStyleBackColor = true;
            // 
            // tableViewDataGridView
            // 
            this.tableViewDataGridView.AllowUserToAddRows = false;
            this.tableViewDataGridView.AllowUserToDeleteRows = false;
            this.tableViewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableViewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.tableViewDataGridView.Location = new System.Drawing.Point(0, 0);
            this.tableViewDataGridView.Name = "tableViewDataGridView";
            this.tableViewDataGridView.ReadOnly = true;
            this.tableViewDataGridView.Size = new System.Drawing.Size(592, 362);
            this.tableViewDataGridView.TabIndex = 3;
            // 
            // column1
            // 
            this.column1.HeaderText = "OID";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Type";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Time";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "OID:";
            // 
            // oidTextBox
            // 
            this.oidTextBox.Location = new System.Drawing.Point(52, 27);
            this.oidTextBox.Name = "oidTextBox";
            this.oidTextBox.Size = new System.Drawing.Size(346, 20);
            this.oidTextBox.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToolStripMenuItem,
            this.monitoredObjectsToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToolStripMenuItem
            // 
            this.goToolStripMenuItem.Name = "goToolStripMenuItem";
            this.goToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.goToolStripMenuItem.Text = "Go";
            this.goToolStripMenuItem.Click += new System.EventHandler(this.goToolStripMenuItem_Click);
            // 
            // monitoredObjectsToolStripMenuItem
            // 
            this.monitoredObjectsToolStripMenuItem.Name = "monitoredObjectsToolStripMenuItem";
            this.monitoredObjectsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.monitoredObjectsToolStripMenuItem.Text = "Monitored Objects";
            this.monitoredObjectsToolStripMenuItem.Click += new System.EventHandler(this.monitoredObjectsToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oidTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "SNMP Browser";
            this.tabControl.ResumeLayout(false);
            this.requestTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requestTableDataGridView)).EndInit();
            this.monitorTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.monitorDataGridView)).EndInit();
            this.trapListenerTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trapListenerDataGridView)).EndInit();
            this.tableViewTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableViewDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
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
        private System.Windows.Forms.TabPage tableViewTabPage;
        private System.Windows.Forms.DataGridView tableViewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoredObjectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

