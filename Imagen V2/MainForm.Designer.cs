/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 18:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Imagen_V2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_generar;
		private System.Windows.Forms.PictureBox pic_imagen;
		
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
			this.btn_generar = new System.Windows.Forms.Button();
			this.pic_imagen = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_generar
			// 
			this.btn_generar.Location = new System.Drawing.Point(100, 12);
			this.btn_generar.Name = "btn_generar";
			this.btn_generar.Size = new System.Drawing.Size(178, 60);
			this.btn_generar.TabIndex = 0;
			this.btn_generar.Text = "Generar";
			this.btn_generar.UseVisualStyleBackColor = true;
			this.btn_generar.Click += new System.EventHandler(this.Btn_generarClick);
			// 
			// pic_imagen
			// 
			this.pic_imagen.Location = new System.Drawing.Point(12, 78);
			this.pic_imagen.Name = "pic_imagen";
			this.pic_imagen.Size = new System.Drawing.Size(344, 250);
			this.pic_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pic_imagen.TabIndex = 1;
			this.pic_imagen.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(368, 340);
			this.Controls.Add(this.pic_imagen);
			this.Controls.Add(this.btn_generar);
			this.Name = "MainForm";
			this.Text = "Imagen V2";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.pic_imagen)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
