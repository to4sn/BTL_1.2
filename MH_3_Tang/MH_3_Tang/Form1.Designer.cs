namespace MH_3_Tang
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhapDuLieuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapBangLopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhapBangMonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapDuLieuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhapDuLieuToolStripMenuItem
            // 
            this.nhapDuLieuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhapBangLopToolStripMenuItem,
            this.nhapBangMonToolStripMenuItem});
            this.nhapDuLieuToolStripMenuItem.Name = "nhapDuLieuToolStripMenuItem";
            this.nhapDuLieuToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.nhapDuLieuToolStripMenuItem.Text = "Nhap du lieu";
            // 
            // nhapBangLopToolStripMenuItem
            // 
            this.nhapBangLopToolStripMenuItem.Name = "nhapBangLopToolStripMenuItem";
            this.nhapBangLopToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhapBangLopToolStripMenuItem.Text = "Nhap bang Lop:";
            this.nhapBangLopToolStripMenuItem.Click += new System.EventHandler(this.nhapBangLopToolStripMenuItem_Click);
            // 
            // nhapBangMonToolStripMenuItem
            // 
            this.nhapBangMonToolStripMenuItem.Name = "nhapBangMonToolStripMenuItem";
            this.nhapBangMonToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhapBangMonToolStripMenuItem.Text = "Nhap bang Mon:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhapDuLieuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapBangLopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhapBangMonToolStripMenuItem;
    }
}

