namespace Toolkit.Tools.FileUtil
{
    partial class JsonViewer
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.rtbox_dynamic_str = new System.Windows.Forms.RichTextBox();
            this.jsonView = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_proc = new System.Windows.Forms.Button();
            this.tbox_jsonpath = new System.Windows.Forms.TextBox();
            this.btn_json_browse = new System.Windows.Forms.Button();
            this.rbtn_file = new System.Windows.Forms.RadioButton();
            this.rbtn_area = new System.Windows.Forms.RadioButton();
            this.rtbox_json = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 336;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.rtbox_dynamic_str);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.jsonView);
            this.splitContainer2.Size = new System.Drawing.Size(336, 450);
            this.splitContainer2.SplitterDistance = 139;
            this.splitContainer2.TabIndex = 1;
            // 
            // rtbox_dynamic_str
            // 
            this.rtbox_dynamic_str.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbox_dynamic_str.Location = new System.Drawing.Point(0, 0);
            this.rtbox_dynamic_str.Name = "rtbox_dynamic_str";
            this.rtbox_dynamic_str.Size = new System.Drawing.Size(336, 139);
            this.rtbox_dynamic_str.TabIndex = 0;
            this.rtbox_dynamic_str.Text = "";
            // 
            // jsonView
            // 
            this.jsonView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonView.Location = new System.Drawing.Point(0, 0);
            this.jsonView.Name = "jsonView";
            this.jsonView.Size = new System.Drawing.Size(336, 307);
            this.jsonView.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.btn_proc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbox_jsonpath, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_json_browse, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtn_file, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rbtn_area, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rtbox_json, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_proc
            // 
            this.btn_proc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_proc.Location = new System.Drawing.Point(83, 423);
            this.btn_proc.Name = "btn_proc";
            this.btn_proc.Size = new System.Drawing.Size(294, 24);
            this.btn_proc.TabIndex = 1;
            this.btn_proc.Text = "Analyze";
            this.btn_proc.UseVisualStyleBackColor = true;
            this.btn_proc.Click += new System.EventHandler(this.btn_proc_Click);
            // 
            // tbox_jsonpath
            // 
            this.tbox_jsonpath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_jsonpath.Location = new System.Drawing.Point(83, 3);
            this.tbox_jsonpath.Name = "tbox_jsonpath";
            this.tbox_jsonpath.Size = new System.Drawing.Size(294, 20);
            this.tbox_jsonpath.TabIndex = 2;
            // 
            // btn_json_browse
            // 
            this.btn_json_browse.Location = new System.Drawing.Point(383, 3);
            this.btn_json_browse.Name = "btn_json_browse";
            this.btn_json_browse.Size = new System.Drawing.Size(74, 23);
            this.btn_json_browse.TabIndex = 3;
            this.btn_json_browse.Text = "Browse";
            this.btn_json_browse.UseVisualStyleBackColor = true;
            // 
            // rbtn_file
            // 
            this.rbtn_file.AutoSize = true;
            this.rbtn_file.Checked = true;
            this.rbtn_file.Location = new System.Drawing.Point(3, 3);
            this.rbtn_file.Name = "rbtn_file";
            this.rbtn_file.Size = new System.Drawing.Size(67, 17);
            this.rbtn_file.TabIndex = 4;
            this.rbtn_file.TabStop = true;
            this.rbtn_file.Text = "From File";
            this.rbtn_file.UseVisualStyleBackColor = true;
            this.rbtn_file.CheckedChanged += new System.EventHandler(this.rbtn_file_CheckedChanged);
            // 
            // rbtn_area
            // 
            this.rbtn_area.AutoSize = true;
            this.rbtn_area.Location = new System.Drawing.Point(3, 33);
            this.rbtn_area.Name = "rbtn_area";
            this.rbtn_area.Size = new System.Drawing.Size(69, 17);
            this.rbtn_area.TabIndex = 5;
            this.rbtn_area.TabStop = true;
            this.rbtn_area.Text = "From Box";
            this.rbtn_area.UseVisualStyleBackColor = true;
            this.rbtn_area.CheckedChanged += new System.EventHandler(this.rbtn_area_CheckedChanged);
            // 
            // rtbox_json
            // 
            this.rtbox_json.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbox_json.Location = new System.Drawing.Point(83, 33);
            this.rtbox_json.Name = "rtbox_json";
            this.rtbox_json.Size = new System.Drawing.Size(294, 384);
            this.rtbox_json.TabIndex = 6;
            this.rtbox_json.Text = "";
            // 
            // JsonViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "JsonViewer";
            this.Text = "JsonViewer";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView jsonView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_proc;
        private System.Windows.Forms.TextBox tbox_jsonpath;
        private System.Windows.Forms.Button btn_json_browse;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtbox_dynamic_str;
        private System.Windows.Forms.RadioButton rbtn_file;
        private System.Windows.Forms.RadioButton rbtn_area;
        private System.Windows.Forms.RichTextBox rtbox_json;
    }
}