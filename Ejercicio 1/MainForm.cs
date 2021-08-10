using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Ejercicio_1
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void Btn_saludarClick(object sender, EventArgs e)
		{
			txt_saludo.Text= "Hola "+txt_nombre.Text;
		}

	}
}
