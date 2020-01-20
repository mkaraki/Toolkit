namespace Toolkit.Tools.Config
{
    partial class WindowsJump
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
            this.lview = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.exe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lview
            // 
            this.lview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.exe,
            this.description});
            this.lview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lview.HideSelection = false;
            this.lview.Location = new System.Drawing.Point(0, 0);
            this.lview.Name = "lview";
            this.lview.Size = new System.Drawing.Size(732, 436);
            this.lview.TabIndex = 0;
            this.lview.UseCompatibleStateImageBehavior = false;
            this.lview.View = System.Windows.Forms.View.Details;
            this.lview.DoubleClick += new System.EventHandler(this.lview_DoubleClick);
            // 
            // name
            // 
            this.name.Text = "Name";
            this.name.Width = 138;
            // 
            // description
            // 
            this.description.Text = "Description";
            this.description.Width = 406;
            // 
            // exe
            // 
            this.exe.Text = "exe";
            this.exe.Width = 130;
            // 
            // WindowsJump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 436);
            this.Controls.Add(this.lview);
            this.Name = "WindowsJump";
            this.Text = "WindowsJump";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lview;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader exe;
        private System.Windows.Forms.ColumnHeader description;
    }
}