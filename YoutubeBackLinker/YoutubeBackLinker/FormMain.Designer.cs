namespace YoutubeBackLinker
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
            this.groupBoxResults = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSearchResults = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDownloadSelection = new System.Windows.Forms.Button();
            this.buttonDownloadAll = new System.Windows.Forms.Button();
            this.buttonDeselectAll = new System.Windows.Forms.Button();
            this.buttonSelectAll = new System.Windows.Forms.Button();
            this.buttonSelectTop20 = new System.Windows.Forms.Button();
            this.buttonSelectTop10 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMain = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSelectedCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.numericUpDownMaxResults = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearchTerm = new System.Windows.Forms.TextBox();
            this.tabPageUpload = new System.Windows.Forms.TabPage();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlUpload.SuspendLayout();
            this.tabPageDonwload.SuspendLayout();
            this.groupBoxResults.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxResults)).BeginInit();
            this.menuStripMain.SuspendLayout();
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
            this.tabControlUpload.Location = new System.Drawing.Point(24, 52);
            this.tabControlUpload.Margin = new System.Windows.Forms.Padding(6);
            this.tabControlUpload.Name = "tabControlUpload";
            this.tabControlUpload.SelectedIndex = 0;
            this.tabControlUpload.Size = new System.Drawing.Size(1798, 903);
            this.tabControlUpload.TabIndex = 0;
            // 
            // tabPageDonwload
            // 
            this.tabPageDonwload.Controls.Add(this.groupBoxResults);
            this.tabPageDonwload.Controls.Add(this.statusStrip1);
            this.tabPageDonwload.Controls.Add(this.groupBoxSearch);
            this.tabPageDonwload.Location = new System.Drawing.Point(8, 39);
            this.tabPageDonwload.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageDonwload.Name = "tabPageDonwload";
            this.tabPageDonwload.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageDonwload.Size = new System.Drawing.Size(1782, 856);
            this.tabPageDonwload.TabIndex = 0;
            this.tabPageDonwload.Text = "Download";
            this.tabPageDonwload.UseVisualStyleBackColor = true;
            // 
            // groupBoxResults
            // 
            this.groupBoxResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxResults.Controls.Add(this.groupBox2);
            this.groupBoxResults.Controls.Add(this.groupBox1);
            this.groupBoxResults.Location = new System.Drawing.Point(12, 214);
            this.groupBoxResults.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxResults.Name = "groupBoxResults";
            this.groupBoxResults.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxResults.Size = new System.Drawing.Size(1758, 585);
            this.groupBoxResults.TabIndex = 3;
            this.groupBoxResults.TabStop = false;
            this.groupBoxResults.Text = "Results";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewSearchResults);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(1734, 401);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selection";
            // 
            // dataGridViewSearchResults
            // 
            this.dataGridViewSearchResults.AllowUserToAddRows = false;
            this.dataGridViewSearchResults.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchResults.Location = new System.Drawing.Point(6, 30);
            this.dataGridViewSearchResults.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewSearchResults.Name = "dataGridViewSearchResults";
            this.dataGridViewSearchResults.ReadOnly = true;
            this.dataGridViewSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResults.Size = new System.Drawing.Size(1722, 365);
            this.dataGridViewSearchResults.TabIndex = 2;
            this.dataGridViewSearchResults.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridViewSearchResults_MouseDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonDownloadSelection);
            this.groupBox1.Controls.Add(this.buttonDownloadAll);
            this.groupBox1.Controls.Add(this.buttonDeselectAll);
            this.groupBox1.Controls.Add(this.buttonSelectAll);
            this.groupBox1.Controls.Add(this.buttonSelectTop20);
            this.groupBox1.Controls.Add(this.buttonSelectTop10);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1734, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selection";
            // 
            // buttonDownloadSelection
            // 
            this.buttonDownloadSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadSelection.Enabled = false;
            this.buttonDownloadSelection.Location = new System.Drawing.Point(1432, 37);
            this.buttonDownloadSelection.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDownloadSelection.Name = "buttonDownloadSelection";
            this.buttonDownloadSelection.Size = new System.Drawing.Size(218, 44);
            this.buttonDownloadSelection.TabIndex = 8;
            this.buttonDownloadSelection.Text = "Download Selection";
            this.buttonDownloadSelection.UseVisualStyleBackColor = true;
            this.buttonDownloadSelection.Click += new System.EventHandler(this.ButtonDownloadSelection_Click);
            // 
            // buttonDownloadAll
            // 
            this.buttonDownloadAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDownloadAll.Enabled = false;
            this.buttonDownloadAll.Location = new System.Drawing.Point(1132, 37);
            this.buttonDownloadAll.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDownloadAll.Name = "buttonDownloadAll";
            this.buttonDownloadAll.Size = new System.Drawing.Size(218, 44);
            this.buttonDownloadAll.TabIndex = 7;
            this.buttonDownloadAll.Text = "Download All";
            this.buttonDownloadAll.UseVisualStyleBackColor = true;
            // 
            // buttonDeselectAll
            // 
            this.buttonDeselectAll.Enabled = false;
            this.buttonDeselectAll.Location = new System.Drawing.Point(868, 37);
            this.buttonDeselectAll.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDeselectAll.Name = "buttonDeselectAll";
            this.buttonDeselectAll.Size = new System.Drawing.Size(218, 44);
            this.buttonDeselectAll.TabIndex = 6;
            this.buttonDeselectAll.Text = "Deselect All";
            this.buttonDeselectAll.UseVisualStyleBackColor = true;
            this.buttonDeselectAll.Click += new System.EventHandler(this.ButtonDeselectAll_Click);
            // 
            // buttonSelectAll
            // 
            this.buttonSelectAll.Enabled = false;
            this.buttonSelectAll.Location = new System.Drawing.Point(582, 37);
            this.buttonSelectAll.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectAll.Name = "buttonSelectAll";
            this.buttonSelectAll.Size = new System.Drawing.Size(218, 44);
            this.buttonSelectAll.TabIndex = 5;
            this.buttonSelectAll.Text = "Select All";
            this.buttonSelectAll.UseVisualStyleBackColor = true;
            this.buttonSelectAll.Click += new System.EventHandler(this.ButtonSelectAll_Click);
            // 
            // buttonSelectTop20
            // 
            this.buttonSelectTop20.Enabled = false;
            this.buttonSelectTop20.Location = new System.Drawing.Point(310, 37);
            this.buttonSelectTop20.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectTop20.Name = "buttonSelectTop20";
            this.buttonSelectTop20.Size = new System.Drawing.Size(218, 44);
            this.buttonSelectTop20.TabIndex = 4;
            this.buttonSelectTop20.Text = "Select Top 20";
            this.buttonSelectTop20.UseVisualStyleBackColor = true;
            this.buttonSelectTop20.Click += new System.EventHandler(this.ButtonSelectTop20_Click);
            // 
            // buttonSelectTop10
            // 
            this.buttonSelectTop10.Enabled = false;
            this.buttonSelectTop10.Location = new System.Drawing.Point(40, 37);
            this.buttonSelectTop10.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSelectTop10.Name = "buttonSelectTop10";
            this.buttonSelectTop10.Size = new System.Drawing.Size(218, 44);
            this.buttonSelectTop10.TabIndex = 3;
            this.buttonSelectTop10.Text = "Select Top 10";
            this.buttonSelectTop10.UseVisualStyleBackColor = true;
            this.buttonSelectTop10.Click += new System.EventHandler(this.ButtonSelectTop10_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMain,
            this.toolStripStatusLabelSelectedCount});
            this.statusStrip1.Location = new System.Drawing.Point(6, 813);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1770, 37);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelMain
            // 
            this.toolStripStatusLabelMain.Name = "toolStripStatusLabelMain";
            this.toolStripStatusLabelMain.Size = new System.Drawing.Size(28, 32);
            this.toolStripStatusLabelMain.Text = "0";
            // 
            // toolStripStatusLabelSelectedCount
            // 
            this.toolStripStatusLabelSelectedCount.Name = "toolStripStatusLabelSelectedCount";
            this.toolStripStatusLabelSelectedCount.Size = new System.Drawing.Size(28, 32);
            this.toolStripStatusLabelSelectedCount.Text = "0";
            this.toolStripStatusLabelSelectedCount.Visible = false;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearch.Controls.Add(this.numericUpDownMaxResults);
            this.groupBoxSearch.Controls.Add(this.label2);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.label1);
            this.groupBoxSearch.Controls.Add(this.textBoxSearchTerm);
            this.groupBoxSearch.Location = new System.Drawing.Point(12, 29);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxSearch.Size = new System.Drawing.Size(1758, 158);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // numericUpDownMaxResults
            // 
            this.numericUpDownMaxResults.Location = new System.Drawing.Point(1154, 62);
            this.numericUpDownMaxResults.Margin = new System.Windows.Forms.Padding(6);
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
            this.numericUpDownMaxResults.Size = new System.Drawing.Size(148, 31);
            this.numericUpDownMaxResults.TabIndex = 5;
            this.numericUpDownMaxResults.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(972, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Max results:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(1444, 62);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(6);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(150, 44);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Term:";
            // 
            // textBoxSearchTerm
            // 
            this.textBoxSearchTerm.Location = new System.Drawing.Point(164, 56);
            this.textBoxSearchTerm.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxSearchTerm.Name = "textBoxSearchTerm";
            this.textBoxSearchTerm.Size = new System.Drawing.Size(644, 31);
            this.textBoxSearchTerm.TabIndex = 0;
            this.textBoxSearchTerm.Text = "test";
            this.textBoxSearchTerm.TextChanged += new System.EventHandler(this.TextBoxSearchTerm_TextChanged);
            // 
            // tabPageUpload
            // 
            this.tabPageUpload.Location = new System.Drawing.Point(8, 39);
            this.tabPageUpload.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageUpload.Name = "tabPageUpload";
            this.tabPageUpload.Padding = new System.Windows.Forms.Padding(6);
            this.tabPageUpload.Size = new System.Drawing.Size(1782, 891);
            this.tabPageUpload.TabIndex = 1;
            this.tabPageUpload.Text = "Upload";
            this.tabPageUpload.UseVisualStyleBackColor = true;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Location = new System.Drawing.Point(8, 39);
            this.tabPageAccount.Margin = new System.Windows.Forms.Padding(6);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Size = new System.Drawing.Size(1782, 891);
            this.tabPageAccount.TabIndex = 2;
            this.tabPageAccount.Text = "Account";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(12, 4, 0, 4);
            this.menuStripMain.Size = new System.Drawing.Size(1846, 44);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(172, 38);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1846, 978);
            this.Controls.Add(this.tabControlUpload);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YoutubeBackLinker";
            this.tabControlUpload.ResumeLayout(false);
            this.tabPageDonwload.ResumeLayout(false);
            this.tabPageDonwload.PerformLayout();
            this.groupBoxResults.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxResults)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchTerm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxResults;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxResults;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewSearchResults;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDeselectAll;
        private System.Windows.Forms.Button buttonSelectAll;
        private System.Windows.Forms.Button buttonSelectTop20;
        private System.Windows.Forms.Button buttonSelectTop10;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSelectedCount;
        private System.Windows.Forms.Button buttonDownloadSelection;
        private System.Windows.Forms.Button buttonDownloadAll;
    }
}

