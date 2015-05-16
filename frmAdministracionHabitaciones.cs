/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 05/05/2015
 * Hora: 9:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Hotel
{
	/// <summary>
	/// Description of frmAdministracionHabitaciones.
	/// </summary>
	public partial class frmAdministracionHabitaciones : Form
	{
		public frmAdministracionHabitaciones()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			frmNuevaHabitacion NuevaHabitacion = new frmNuevaHabitacion();
			NuevaHabitacion.Tag=this.Tag;
			NuevaHabitacion.Show();
		}
		
		void LblEliminarClick(object sender, EventArgs e)
		{
			frmEliminarHabitacion EliminarHabitacion = new frmEliminarHabitacion();
			EliminarHabitacion.Tag=this.Tag;
			EliminarHabitacion.Show();
		}
	}
}
