/*
 * Created by SharpDevelop.
 * User: PCZIN-MONSTRO
 * Date: 08/03/2022
 * Time: 16:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Atividadelistarvalendonota
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.listBox3 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.listBox4 = new System.Windows.Forms.ListBox();
			this.listBox5 = new System.Windows.Forms.ListBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.richTextBox2 = new System.Windows.Forms.RichTextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox1.Location = new System.Drawing.Point(12, 12);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.Size = new System.Drawing.Size(186, 381);
			this.richTextBox1.TabIndex = 0;
			this.richTextBox1.Text = "";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DimGray;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(12, 396);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(186, 62);
			this.button1.TabIndex = 2;
			this.button1.Text = "Listar";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(223, 44);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(71, 349);
			this.listBox1.TabIndex = 3;
			// 
			// listBox2
			// 
			this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.ItemHeight = 15;
			this.listBox2.Location = new System.Drawing.Point(300, 44);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(74, 349);
			this.listBox2.TabIndex = 4;
			// 
			// listBox3
			// 
			this.listBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox3.FormattingEnabled = true;
			this.listBox3.ItemHeight = 15;
			this.listBox3.Location = new System.Drawing.Point(380, 44);
			this.listBox3.Name = "listBox3";
			this.listBox3.Size = new System.Drawing.Size(51, 349);
			this.listBox3.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(240, 400);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(191, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Total :";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(234, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 8;
			this.label2.Text = "Nome";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(300, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 23);
			this.label3.TabIndex = 9;
			this.label3.Text = "Salário";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(380, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 23);
			this.label4.TabIndex = 10;
			this.label4.Text = "Setor";
			// 
			// listBox4
			// 
			this.listBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox4.FormattingEnabled = true;
			this.listBox4.ItemHeight = 18;
			this.listBox4.Location = new System.Drawing.Point(542, 44);
			this.listBox4.Name = "listBox4";
			this.listBox4.Size = new System.Drawing.Size(74, 346);
			this.listBox4.TabIndex = 13;
			// 
			// listBox5
			// 
			this.listBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox5.FormattingEnabled = true;
			this.listBox5.ItemHeight = 18;
			this.listBox5.Location = new System.Drawing.Point(465, 44);
			this.listBox5.Name = "listBox5";
			this.listBox5.Size = new System.Drawing.Size(71, 346);
			this.listBox5.TabIndex = 12;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label5.Location = new System.Drawing.Point(465, 400);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(151, 20);
			this.label5.TabIndex = 14;
			this.label5.Text = "Total do Setor:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBox2
			// 
			this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(492, 423);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(97, 24);
			this.textBox2.TabIndex = 15;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.Location = new System.Drawing.Point(465, 5);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(71, 38);
			this.button2.TabIndex = 16;
			this.button2.Text = "Selecione  Setor";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// textBox3
			// 
			this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(557, 3);
			this.textBox3.MaxLength = 1;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(41, 40);
			this.textBox3.TabIndex = 17;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// richTextBox2
			// 
			this.richTextBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.richTextBox2.Location = new System.Drawing.Point(691, 18);
			this.richTextBox2.Name = "richTextBox2";
			this.richTextBox2.ReadOnly = true;
			this.richTextBox2.Size = new System.Drawing.Size(213, 375);
			this.richTextBox2.TabIndex = 18;
			this.richTextBox2.Text = "";
			// 
			// button3
			// 
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(691, 396);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(213, 58);
			this.button3.TabIndex = 19;
			this.button3.Text = "ORGANIZAR";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(465, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(173, 455);
			this.panel1.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(284, 424);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 21;
			this.label6.Text = "label6";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(691, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 23);
			this.label7.TabIndex = 24;
			this.label7.Text = "Setor";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(825, 3);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 23);
			this.label8.TabIndex = 23;
			this.label8.Text = "Salário";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(759, 3);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(60, 23);
			this.label9.TabIndex = 22;
			this.label9.Text = "Nome";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(923, 463);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.richTextBox2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.listBox4);
			this.Controls.Add(this.listBox5);
			this.Controls.Add(this.listBox3);
			this.Controls.Add(this.listBox2);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label9);
			this.Name = "MainForm";
			this.Text = "Atividadelistarvalendonota";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RichTextBox richTextBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ListBox listBox5;
		private System.Windows.Forms.ListBox listBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox3;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
	}
}
