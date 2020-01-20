namespace Toolkit.Tools.PictureTools
{
    partial class RandomPictureGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.nbox_x = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nbox_y = new System.Windows.Forms.NumericUpDown();
            this.btn_make = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.nbox_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pixel";
            // 
            // nbox_x
            // 
            this.nbox_x.Location = new System.Drawing.Point(47, 15);
            this.nbox_x.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nbox_x.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbox_x.Name = "nbox_x";
            this.nbox_x.Size = new System.Drawing.Size(82, 20);
            this.nbox_x.TabIndex = 1;
            this.nbox_x.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x";
            // 
            // nbox_y
            // 
            this.nbox_y.Location = new System.Drawing.Point(153, 15);
            this.nbox_y.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nbox_y.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbox_y.Name = "nbox_y";
            this.nbox_y.Size = new System.Drawing.Size(82, 20);
            this.nbox_y.TabIndex = 4;
            this.nbox_y.Value = new decimal(new int[] {
            480,
            0,
            0,
            0});
            // 
            // btn_make
            // 
            this.btn_make.Location = new System.Drawing.Point(317, 12);
            this.btn_make.Name = "btn_make";
            this.btn_make.Size = new System.Drawing.Size(75, 23);
            this.btn_make.TabIndex = 5;
            this.btn_make.Text = "Generate";
            this.btn_make.UseVisualStyleBackColor = true;
            this.btn_make.Click += new System.EventHandler(this.btn_make_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(12, 73);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(380, 237);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 6;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result (Click to save png)";
            // 
            // sfd
            // 
            this.sfd.DefaultExt = "png";
            // 
            // RandomPictureGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 322);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btn_make);
            this.Controls.Add(this.nbox_y);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nbox_x);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(420, 361);
            this.MinimumSize = new System.Drawing.Size(420, 361);
            this.Name = "RandomPictureGenerator";
            this.Text = "RandomPictureGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.nbox_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbox_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nbox_x;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nbox_y;
        private System.Windows.Forms.Button btn_make;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog sfd;
    }
}