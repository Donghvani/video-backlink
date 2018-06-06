﻿namespace YoutubeBackLinker
{
    partial class FormMain
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
            this.tabControlUpload = new System.Windows.Forms.TabControl();
            this.tabPageDonwload = new System.Windows.Forms.TabPage();
            this.tabPageUpload = new System.Windows.Forms.TabPage();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSearchCriteria = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.numericUpDownMaxResults = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.tabControlUpload.SuspendLayout();
            this.tabPageDonwload.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxResults)).BeginInit();
            this.groupBoxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlUpload
            // 
            this.tabControlUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlUpload.Controls.Add(this.tabPageDonwload);
            this.tabControlUpload.Controls.Add(this.tabPageUpload);
            this.tabControlUpload.Controls.Add(this.tabPageAccount);
            this.tabControlUpload.Location = new System.Drawing.Point(12, 27);
            this.tabControlUpload.Name = "tabControlUpload";
            this.tabControlUpload.SelectedIndex = 0;
            this.tabControlUpload.Size = new System.Drawing.Size(1191, 696);
            this.tabControlUpload.TabIndex = 0;
            // 
            // tabPageDonwload
            // 
            this.tabPageDonwload.Controls.Add(this.groupBoxResults);
            this.tabPageDonwload.Controls.Add(this.statusStrip1);
            this.tabPageDonwload.Controls.Add(this.groupBoxSearch);
            this.tabPageDonwload.Location = new System.Drawing.Point(4, 22);
            this.tabPageDonwload.Name = "tabPageDonwload";
            this.tabPageDonwload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDonwload.Size = new System.Drawing.Size(1183, 670);
            this.tabPageDonwload.TabIndex = 0;
            this.tabPageDonwload.Text = "Download";
            this.tabPageDonwload.UseVisualStyleBackColor = true;
            // 
            // tabPageUpload
            // 
            this.tabPageUpload.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpload.Name = "tabPageUpload";
            this.tabPageUpload.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpload.Size = new System.Drawing.Size(1183, 670);
            this.tabPageUpload.TabIndex = 1;
            this.tabPageUpload.Text = "Upload";
            this.tabPageUpload.UseVisualStyleBackColor = true;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Size = new System.Drawing.Size(1183, 670);
            this.tabPageAccount.TabIndex = 2;
            this.tabPageAccount.Text = "Account";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1215, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.label2);
            this.groupBoxSearch.Controls.Add(this.numericUpDownMaxResults);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.textBoxSearchCriteria);
            this.groupBoxSearch.Location = new System.Drawing.Point(6, 15);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(1171, 126);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // textBoxSearchCriteria
            // 
            this.textBoxSearchCriteria.Location = new System.Drawing.Point(82, 29);
            this.textBoxSearchCriteria.Name = "textBoxSearchCriteria";
            this.textBoxSearchCriteria.Size = new System.Drawing.Size(324, 20);
            this.textBoxSearchCriteria.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criteria:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(861, 29);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1165, 476);
            this.dataGridView1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 645);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1177, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // numericUpDownMaxResults
            // 
            this.numericUpDownMaxResults.Location = new System.Drawing.Point(568, 29);
            this.numericUpDownMaxResults.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownMaxResults.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMaxResults.Name = "numericUpDownMaxResults";
            this.numericUpDownMaxResults.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownMaxResults.TabIndex = 3;
            this.numericUpDownMaxResults.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max results:";
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResults.Controls.Add(this.dataGridView1);
            this.groupBoxResults.Location = new System.Drawing.Point(6, 147);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Size = new System.Drawing.Size(1171, 495);
            this.groupBoxResults.TabIndex = 3;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 735);
            this.Controls.Add(this.tabControlUpload);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoutubeBackLinker";
            this.tabControlUpload.ResumeLayout(false);
            this.tabPageDonwload.ResumeLayout(false);
            this.tabPageDonwload.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxResults)).EndInit();
            this.groupBoxResults.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlUpload;
        private System.Windows.Forms.TabPage tabPageDonwload;
        private System.Windows.Forms.TabPage tabPageUpload;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchCriteria;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxResults;
        private System.Windows.Forms.GroupBox groupBoxResults;
    }
}
