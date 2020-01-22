namespace Toolkit.Tools.FileUtil
{
    partial class CSVViewer
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_parse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbox_sep = new System.Windows.Forms.ComboBox();
            this.btn_sep_custom = new System.Windows.Forms.Button();
            this.cbox_header = new System.Windows.Forms.CheckBox();
            this.rbtn_file = new System.Windows.Forms.RadioButton();
            this.tbox_file = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.dataSet = new System.Data.DataSet();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 538;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(538, 450);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.btn_parse, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbox_sep, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_sep_custom, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.cbox_header, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.rbtn_file, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbox_file, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_browse, 2, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(258, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_parse
            // 
            this.btn_parse.Location = new System.Drawing.Point(73, 423);
            this.btn_parse.Name = "btn_parse";
            this.btn_parse.Size = new System.Drawing.Size(75, 23);
            this.btn_parse.TabIndex = 0;
            this.btn_parse.Text = "Parse";
            this.btn_parse.UseVisualStyleBackColor = true;
            this.btn_parse.Click += new System.EventHandler(this.btn_parse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Separate";
            // 
            // cbox_sep
            // 
            this.cbox_sep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_sep.FormattingEnabled = true;
            this.cbox_sep.Items.AddRange(new object[] {
            "Comma (csv)",
            "Tab (tsv)",
            "Custom"});
            this.cbox_sep.Location = new System.Drawing.Point(73, 3);
            this.cbox_sep.Name = "cbox_sep";
            this.cbox_sep.Size = new System.Drawing.Size(112, 21);
            this.cbox_sep.TabIndex = 2;
            this.cbox_sep.Text = "Comma (csv)";
            this.cbox_sep.SelectedIndexChanged += new System.EventHandler(this.cbox_sep_SelectedIndexChanged);
            // 
            // btn_sep_custom
            // 
            this.btn_sep_custom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_sep_custom.Enabled = false;
            this.btn_sep_custom.Location = new System.Drawing.Point(191, 3);
            this.btn_sep_custom.Name = "btn_sep_custom";
            this.btn_sep_custom.Size = new System.Drawing.Size(64, 24);
            this.btn_sep_custom.TabIndex = 3;
            this.btn_sep_custom.Text = "Custom";
            this.btn_sep_custom.UseVisualStyleBackColor = true;
            this.btn_sep_custom.Click += new System.EventHandler(this.btn_sep_custom_Click);
            // 
            // cbox_header
            // 
            this.cbox_header.AutoSize = true;
            this.cbox_header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_header.Location = new System.Drawing.Point(70, 30);
            this.cbox_header.Margin = new System.Windows.Forms.Padding(0);
            this.cbox_header.Name = "cbox_header";
            this.cbox_header.Size = new System.Drawing.Size(118, 30);
            this.cbox_header.TabIndex = 4;
            this.cbox_header.Text = "Make first row header";
            this.cbox_header.UseVisualStyleBackColor = true;
            // 
            // rbtn_file
            // 
            this.rbtn_file.AutoSize = true;
            this.rbtn_file.Checked = true;
            this.rbtn_file.Location = new System.Drawing.Point(3, 73);
            this.rbtn_file.Name = "rbtn_file";
            this.rbtn_file.Size = new System.Drawing.Size(41, 17);
            this.rbtn_file.TabIndex = 5;
            this.rbtn_file.TabStop = true;
            this.rbtn_file.Text = "File";
            this.rbtn_file.UseVisualStyleBackColor = true;
            this.rbtn_file.CheckedChanged += new System.EventHandler(this.rbtn_file_CheckedChanged);
            // 
            // tbox_file
            // 
            this.tbox_file.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_file.Location = new System.Drawing.Point(73, 73);
            this.tbox_file.Name = "tbox_file";
            this.tbox_file.Size = new System.Drawing.Size(112, 20);
            this.tbox_file.TabIndex = 6;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(191, 73);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(64, 23);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "CsvDataSet";
            // 
            // CSVViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CSVViewer";
            this.Text = "CSVViewer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Data.DataSet dataSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_parse;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_sep;
        private System.Windows.Forms.Button btn_sep_custom;
        private System.Windows.Forms.CheckBox cbox_header;
        private System.Windows.Forms.RadioButton rbtn_file;
        private System.Windows.Forms.TextBox tbox_file;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.OpenFileDialog ofd;
    }
}