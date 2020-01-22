namespace Toolkit.Tools.Geo
{
    partial class OpenMap
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num_zoom = new System.Windows.Forms.NumericUpDown();
            this.tbox_lon = new System.Windows.Forms.TextBox();
            this.tbox_lat = new System.Windows.Forms.TextBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbox_dsource = new System.Windows.Forms.ComboBox();
            this.cbox_openby = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_zoom)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.num_zoom, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbox_lon, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbox_lat, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_open, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbox_dsource, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbox_openby, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(292, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Zoom";
            // 
            // num_zoom
            // 
            this.num_zoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.num_zoom.Location = new System.Drawing.Point(123, 63);
            this.num_zoom.Maximum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.num_zoom.Name = "num_zoom";
            this.num_zoom.Size = new System.Drawing.Size(166, 20);
            this.num_zoom.TabIndex = 3;
            this.num_zoom.Value = new decimal(new int[] {
            17,
            0,
            0,
            0});
            // 
            // tbox_lon
            // 
            this.tbox_lon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_lon.Location = new System.Drawing.Point(123, 3);
            this.tbox_lon.Name = "tbox_lon";
            this.tbox_lon.Size = new System.Drawing.Size(166, 20);
            this.tbox_lon.TabIndex = 4;
            // 
            // tbox_lat
            // 
            this.tbox_lat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_lat.Location = new System.Drawing.Point(123, 33);
            this.tbox_lat.Name = "tbox_lat";
            this.tbox_lat.Size = new System.Drawing.Size(166, 20);
            this.tbox_lat.TabIndex = 5;
            // 
            // btn_open
            // 
            this.btn_open.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_open.Location = new System.Drawing.Point(123, 179);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(166, 24);
            this.btn_open.TabIndex = 6;
            this.btn_open.Text = "Open";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data Source";
            // 
            // cbox_dsource
            // 
            this.cbox_dsource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_dsource.FormattingEnabled = true;
            this.cbox_dsource.Items.AddRange(new object[] {
            "OpenStreetMap"});
            this.cbox_dsource.Location = new System.Drawing.Point(123, 93);
            this.cbox_dsource.Name = "cbox_dsource";
            this.cbox_dsource.Size = new System.Drawing.Size(166, 21);
            this.cbox_dsource.TabIndex = 8;
            this.cbox_dsource.Text = "OpenStreetMap";
            // 
            // cbox_openby
            // 
            this.cbox_openby.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbox_openby.FormattingEnabled = true;
            this.cbox_openby.Items.AddRange(new object[] {
            "Default Browser"});
            this.cbox_openby.Location = new System.Drawing.Point(3, 179);
            this.cbox_openby.Name = "cbox_openby";
            this.cbox_openby.Size = new System.Drawing.Size(114, 21);
            this.cbox_openby.TabIndex = 9;
            this.cbox_openby.Text = "Default Browser";
            // 
            // OpenMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 206);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "OpenMap";
            this.Text = "OpenMap";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_zoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_zoom;
        private System.Windows.Forms.TextBox tbox_lon;
        private System.Windows.Forms.TextBox tbox_lat;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbox_dsource;
        private System.Windows.Forms.ComboBox cbox_openby;
    }
}