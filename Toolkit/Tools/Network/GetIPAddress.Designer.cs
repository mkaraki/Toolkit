namespace Toolkit.Tools.Network
{
    partial class GetIPAddress
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
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("This PC");
            this.tview = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // tview
            // 
            this.tview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tview.Location = new System.Drawing.Point(0, 0);
            this.tview.Name = "tview";
            treeNode2.Name = "thispc";
            treeNode2.Text = "This PC";
            this.tview.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.tview.Size = new System.Drawing.Size(800, 450);
            this.tview.TabIndex = 0;
            // 
            // GetIPAddress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tview);
            this.Name = "GetIPAddress";
            this.Text = "Machine IP Addresses";
            this.Load += new System.EventHandler(this.GetIPAddress_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tview;
    }
}