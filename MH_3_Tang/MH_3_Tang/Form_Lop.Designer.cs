﻿namespace MH_3_Tang
{
    partial class Form_Lop
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tenLop = new System.Windows.Forms.TextBox();
            this.txt_maLop = new System.Windows.Forms.TextBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Lớp:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Lớp";
            // 
            // txt_tenLop
            // 
            this.txt_tenLop.Location = new System.Drawing.Point(168, 52);
            this.txt_tenLop.Name = "txt_tenLop";
            this.txt_tenLop.Size = new System.Drawing.Size(100, 22);
            this.txt_tenLop.TabIndex = 2;
            // 
            // txt_maLop
            // 
            this.txt_maLop.Location = new System.Drawing.Point(168, 122);
            this.txt_maLop.Name = "txt_maLop";
            this.txt_maLop.Size = new System.Drawing.Size(100, 22);
            this.txt_maLop.TabIndex = 3;
            // 
            // btn_View
            // 
            this.btn_View.Location = new System.Drawing.Point(24, 195);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(75, 23);
            this.btn_View.TabIndex = 4;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(168, 195);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 5;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(514, 298);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form_Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.txt_maLop);
            this.Controls.Add(this.txt_tenLop);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_Lop";
            this.Text = "Form_Lop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tenLop;
        private System.Windows.Forms.TextBox txt_maLop;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}