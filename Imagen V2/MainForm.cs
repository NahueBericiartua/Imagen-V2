/*
 * Created by SharpDevelop.
 * User: Nahue
 * Date: 8/10/2021
 * Time: 18:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Imagen_V2
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] direccion;
		string dir;
		Random n;
		int i;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			n = new Random();
			i = new int();
			direccion = new string[5];
			dir = "C:\\Users\\Nahue\\Documents\\SharpDevelop Projects\\Imagen V2\\Imagenes\\";
			direccion[0]=dir+"1.png";
			direccion[1]=dir+"2.png";
			direccion[2]=dir+"3.png";
			direccion[3]=dir+"4.png";
			direccion[4]=dir+"5.png";
		}
		void Btn_generarClick(object sender, EventArgs e)
		{
			i=Convert.ToInt32(n.Next(0,5));
			pic_imagen.Image = Image.FromFile(direccion[i]);
		}
	}
}
