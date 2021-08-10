/*
 * Created by SharpDevelop.
 * User: IPPESSI
 * Date: 09/08/2021
 * Time: 19:56
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ejercicio_1
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_saludar;
		private System.Windows.Forms.TextBox txt_nombre;
		private System.Windows.Forms.Label lbl_nombre;
		private System.Windows.Forms.TextBox txt_saludo;
		
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
			this.btn_saludar = new System.Windows.Forms.Button();
			this.txt_nombre = new System.Windows.Forms.TextBox();
			this.lbl_nombre = new System.Windows.Forms.Label();
			this.txt_saludo = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_saludar
			// 
			this.btn_saludar.Location = new System.Drawing.Point(98, 91);
			this.btn_saludar.Name = "btn_saludar";
			this.btn_saludar.Size = new System.Drawing.Size(75, 23);
			this.btn_saludar.TabIndex = 0;
			this.btn_saludar.Text = "SALUDAR";
			this.btn_saludar.UseVisualStyleBackColor = true;
			this.btn_saludar.Click += new System.EventHandler(this.Btn_saludarClick);
			// 
			// txt_nombre
			// 
			this.txt_nombre.BackColor = System.Drawing.SystemColors.Window;
			this.txt_nombre.Location = new System.Drawing.Point(68, 12);
			this.txt_nombre.Name = "txt_nombre";
			this.txt_nombre.Size = new System.Drawing.Size(141, 20);
			this.txt_nombre.TabIndex = 1;
			// 
			// lbl_nombre
			// 
			this.lbl_nombre.Location = new System.Drawing.Point(12, 15);
			this.lbl_nombre.Name = "lbl_nombre";
			this.lbl_nombre.Size = new System.Drawing.Size(50, 17);
			this.lbl_nombre.TabIndex = 2;
			this.lbl_nombre.Text = "Nombre:";
			// 
			// txt_saludo
			// 
			this.txt_saludo.BackColor = System.Drawing.SystemColors.Window;
			this.txt_saludo.Enabled = false;
			this.txt_saludo.Location = new System.Drawing.Point(68, 156);
			this.txt_saludo.Name = "txt_saludo";
			this.txt_saludo.Size = new System.Drawing.Size(141, 20);
			this.txt_saludo.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gainsboro;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.txt_saludo);
			this.Controls.Add(this.lbl_nombre);
			this.Controls.Add(this.txt_nombre);
			this.Controls.Add(this.btn_saludar);
			this.Name = "MainForm";
			this.Text = "Ejercicio 1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
