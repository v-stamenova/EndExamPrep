﻿
namespace Problem_5_Products
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
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(35, 50);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(216, 304);
			this.listBox1.TabIndex = 0;
			// 
			// listBox2
			// 
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 20;
			this.listBox2.Location = new System.Drawing.Point(314, 50);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(216, 304);
			this.listBox2.TabIndex = 1;
			// 
			// listBox3
			// 
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 20;
			this.listBox3.Location = new System.Drawing.Point(592, 50);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(216, 304);
			this.listBox3.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(31, 386);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "label1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Profit";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(310, 27);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(116, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Customer price";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(588, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 20);
			this.label4.TabIndex = 6;
			this.label4.Text = "Tax price";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 485);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
	}
}

