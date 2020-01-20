namespace Toolkit.Tools.PictureTools
{
    partial class PictureCompare
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlbl_res = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_pictures = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbox_p1 = new System.Windows.Forms.PictureBox();
            this.pbox_p2 = new System.Windows.Forms.PictureBox();
            this.pbox_diff = new System.Windows.Forms.PictureBox();
            this.lbl_savereport = new System.Windows.Forms.Label();
            this.rtbox_report = new System.Windows.Forms.RichTextBox();
            this.tlp_select = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_select_pic1 = new System.Windows.Forms.Button();
            this.btn_select_pic2 = new System.Windows.Forms.Button();
            this.tbox_pic1 = new System.Windows.Forms.TextBox();
            this.tbox_pic2 = new System.Windows.Forms.TextBox();
            this.cbox_diffc = new System.Windows.Forms.ComboBox();
            this.btn_diff = new System.Windows.Forms.Button();
            this.ofd_p1 = new System.Windows.Forms.OpenFileDialog();
            this.ofd_p2 = new System.Windows.Forms.OpenFileDialog();
            this.sfd_report = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp_pictures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_diff)).BeginInit();
            this.tlp_select.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlbl_res});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlbl_res
            // 
            this.tlbl_res.Name = "tlbl_res";
            this.tlbl_res.Size = new System.Drawing.Size(88, 17);
            this.tlbl_res.Text = "CompareResult";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tlp_pictures, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tlp_select, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 428);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tlp_pictures
            // 
            this.tlp_pictures.ColumnCount = 4;
            this.tlp_pictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_pictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_pictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_pictures.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_pictures.Controls.Add(this.label1, 0, 0);
            this.tlp_pictures.Controls.Add(this.label2, 1, 0);
            this.tlp_pictures.Controls.Add(this.label3, 2, 0);
            this.tlp_pictures.Controls.Add(this.pbox_p1, 0, 1);
            this.tlp_pictures.Controls.Add(this.pbox_p2, 1, 1);
            this.tlp_pictures.Controls.Add(this.pbox_diff, 2, 1);
            this.tlp_pictures.Controls.Add(this.lbl_savereport, 3, 0);
            this.tlp_pictures.Controls.Add(this.rtbox_report, 3, 1);
            this.tlp_pictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_pictures.Location = new System.Drawing.Point(3, 153);
            this.tlp_pictures.Name = "tlp_pictures";
            this.tlp_pictures.RowCount = 2;
            this.tlp_pictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_pictures.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_pictures.Size = new System.Drawing.Size(794, 272);
            this.tlp_pictures.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Picture 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Picture 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Difference";
            // 
            // pbox_p1
            // 
            this.pbox_p1.BackColor = System.Drawing.Color.White;
            this.pbox_p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_p1.Location = new System.Drawing.Point(3, 23);
            this.pbox_p1.Name = "pbox_p1";
            this.pbox_p1.Size = new System.Drawing.Size(192, 246);
            this.pbox_p1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_p1.TabIndex = 3;
            this.pbox_p1.TabStop = false;
            this.pbox_p1.Click += new System.EventHandler(this.pbox_p1_Click);
            // 
            // pbox_p2
            // 
            this.pbox_p2.BackColor = System.Drawing.Color.White;
            this.pbox_p2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_p2.Location = new System.Drawing.Point(201, 23);
            this.pbox_p2.Name = "pbox_p2";
            this.pbox_p2.Size = new System.Drawing.Size(192, 246);
            this.pbox_p2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_p2.TabIndex = 4;
            this.pbox_p2.TabStop = false;
            this.pbox_p2.Click += new System.EventHandler(this.pbox_p2_Click);
            // 
            // pbox_diff
            // 
            this.pbox_diff.BackColor = System.Drawing.Color.White;
            this.pbox_diff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbox_diff.Location = new System.Drawing.Point(399, 23);
            this.pbox_diff.Name = "pbox_diff";
            this.pbox_diff.Size = new System.Drawing.Size(192, 246);
            this.pbox_diff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_diff.TabIndex = 5;
            this.pbox_diff.TabStop = false;
            this.pbox_diff.Click += new System.EventHandler(this.pbox_diff_Click);
            // 
            // lbl_savereport
            // 
            this.lbl_savereport.AutoSize = true;
            this.lbl_savereport.Location = new System.Drawing.Point(597, 0);
            this.lbl_savereport.Name = "lbl_savereport";
            this.lbl_savereport.Size = new System.Drawing.Size(133, 13);
            this.lbl_savereport.TabIndex = 6;
            this.lbl_savereport.Text = "Report (Click here to save)";
            this.lbl_savereport.Click += new System.EventHandler(this.lbl_savereport_Click);
            // 
            // rtbox_report
            // 
            this.rtbox_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbox_report.Location = new System.Drawing.Point(597, 23);
            this.rtbox_report.Name = "rtbox_report";
            this.rtbox_report.Size = new System.Drawing.Size(194, 246);
            this.rtbox_report.TabIndex = 7;
            this.rtbox_report.Text = "";
            // 
            // tlp_select
            // 
            this.tlp_select.ColumnCount = 3;
            this.tlp_select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_select.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp_select.Controls.Add(this.label4, 0, 2);
            this.tlp_select.Controls.Add(this.label5, 0, 1);
            this.tlp_select.Controls.Add(this.label6, 0, 0);
            this.tlp_select.Controls.Add(this.btn_select_pic1, 2, 0);
            this.tlp_select.Controls.Add(this.btn_select_pic2, 2, 1);
            this.tlp_select.Controls.Add(this.tbox_pic1, 1, 0);
            this.tlp_select.Controls.Add(this.tbox_pic2, 1, 1);
            this.tlp_select.Controls.Add(this.cbox_diffc, 1, 2);
            this.tlp_select.Controls.Add(this.btn_diff, 1, 3);
            this.tlp_select.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_select.Location = new System.Drawing.Point(3, 3);
            this.tlp_select.Name = "tlp_select";
            this.tlp_select.RowCount = 4;
            this.tlp_select.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_select.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_select.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp_select.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_select.Size = new System.Drawing.Size(794, 144);
            this.tlp_select.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Diff Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Picture 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Picture 1";
            // 
            // btn_select_pic1
            // 
            this.btn_select_pic1.Location = new System.Drawing.Point(717, 3);
            this.btn_select_pic1.Name = "btn_select_pic1";
            this.btn_select_pic1.Size = new System.Drawing.Size(74, 23);
            this.btn_select_pic1.TabIndex = 3;
            this.btn_select_pic1.Text = "Browse";
            this.btn_select_pic1.UseVisualStyleBackColor = true;
            this.btn_select_pic1.Click += new System.EventHandler(this.btn_select_pic1_Click);
            // 
            // btn_select_pic2
            // 
            this.btn_select_pic2.Location = new System.Drawing.Point(717, 33);
            this.btn_select_pic2.Name = "btn_select_pic2";
            this.btn_select_pic2.Size = new System.Drawing.Size(74, 23);
            this.btn_select_pic2.TabIndex = 4;
            this.btn_select_pic2.Text = "Browse";
            this.btn_select_pic2.UseVisualStyleBackColor = true;
            this.btn_select_pic2.Click += new System.EventHandler(this.btn_select_pic2_Click);
            // 
            // tbox_pic1
            // 
            this.tbox_pic1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_pic1.Location = new System.Drawing.Point(83, 3);
            this.tbox_pic1.Name = "tbox_pic1";
            this.tbox_pic1.Size = new System.Drawing.Size(628, 20);
            this.tbox_pic1.TabIndex = 5;
            this.tbox_pic1.Leave += new System.EventHandler(this.tbox_pic1_Leave);
            // 
            // tbox_pic2
            // 
            this.tbox_pic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_pic2.Location = new System.Drawing.Point(83, 33);
            this.tbox_pic2.Name = "tbox_pic2";
            this.tbox_pic2.Size = new System.Drawing.Size(628, 20);
            this.tbox_pic2.TabIndex = 6;
            this.tbox_pic2.Leave += new System.EventHandler(this.tbox_pic2_Leave);
            // 
            // cbox_diffc
            // 
            this.cbox_diffc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_diffc.FormattingEnabled = true;
            this.cbox_diffc.Items.AddRange(new object[] {
            "Black"});
            this.cbox_diffc.Location = new System.Drawing.Point(83, 63);
            this.cbox_diffc.Name = "cbox_diffc";
            this.cbox_diffc.Size = new System.Drawing.Size(628, 21);
            this.cbox_diffc.TabIndex = 7;
            this.cbox_diffc.Text = "Black";
            // 
            // btn_diff
            // 
            this.btn_diff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_diff.Location = new System.Drawing.Point(83, 93);
            this.btn_diff.Name = "btn_diff";
            this.btn_diff.Size = new System.Drawing.Size(628, 48);
            this.btn_diff.TabIndex = 8;
            this.btn_diff.Text = "Compare";
            this.btn_diff.UseVisualStyleBackColor = true;
            this.btn_diff.Click += new System.EventHandler(this.btn_diff_Click);
            // 
            // ofd_p1
            // 
            this.ofd_p1.FileName = "picture1.jpg";
            // 
            // ofd_p2
            // 
            this.ofd_p2.FileName = "picture2.jpg";
            // 
            // sfd_report
            // 
            this.sfd_report.FileName = "report.txt";
            // 
            // PictureCompare
            // 
            this.AcceptButton = this.btn_diff;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "PictureCompare";
            this.Text = "PictureCompare";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlp_pictures.ResumeLayout(false);
            this.tlp_pictures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_diff)).EndInit();
            this.tlp_select.ResumeLayout(false);
            this.tlp_select.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlbl_res;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlp_pictures;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbox_p1;
        private System.Windows.Forms.PictureBox pbox_p2;
        private System.Windows.Forms.PictureBox pbox_diff;
        private System.Windows.Forms.TableLayoutPanel tlp_select;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_select_pic1;
        private System.Windows.Forms.Button btn_select_pic2;
        private System.Windows.Forms.TextBox tbox_pic1;
        private System.Windows.Forms.TextBox tbox_pic2;
        private System.Windows.Forms.ComboBox cbox_diffc;
        private System.Windows.Forms.Button btn_diff;
        private System.Windows.Forms.OpenFileDialog ofd_p1;
        private System.Windows.Forms.OpenFileDialog ofd_p2;
        private System.Windows.Forms.Label lbl_savereport;
        private System.Windows.Forms.RichTextBox rtbox_report;
        private System.Windows.Forms.SaveFileDialog sfd_report;
    }
}