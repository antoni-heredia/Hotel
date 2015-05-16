/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 04/05/2015
 * Hora: 17:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		
		void BtOcupadasClick(object sender, EventArgs e)
		{
			frmHabitaciones Habitaciones = new frmHabitaciones();
			Habitaciones.Tag= openFileDialog1.FileName;
			Habitaciones.Show();
		}
		
		void BtNuevaHabitacionClick(object sender, EventArgs e)
		{
			frmAdministracionHabitaciones Administracion = new frmAdministracionHabitaciones();
			Administracion.Tag=openFileDialog1.FileName;
			Administracion.Show();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.DefaultExt = "xml";
			openFileDialog1.FileName="";
			if (openFileDialog1.ShowDialog() == DialogResult.OK){
			}			
		}
	}
}
