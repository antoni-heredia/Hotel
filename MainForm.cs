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
using System.Xml;

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
			//Nos muestra un cuadro de dialogo, con Si o No.
			DialogResult dialogResult = MessageBox.Show("¿Quiere crear un nuevo " +
			                                            "documento para el hotel?" ,
			                                            "Nuevo Documento", MessageBoxButtons.YesNo);
			if(dialogResult == DialogResult.Yes){		//Resultado de la eleccion del usuario
				string sXML;							//Si es que si, creara un nuevo fichero con el
				sXML=									//Nombre y ubicacion que quermos.
					"<?xml version=\"1.0\"?>\n" +
					"<hotel>\n" +
					"<habitaciones></habitaciones>\n" +
					"<Clientes></Clientes> \n" +
					"</hotel>\n";
					
				XmlDocument doc = new XmlDocument();
				doc.LoadXml(sXML);
				using(SaveFileDialog saveFileDialog1 = new SaveFileDialog()){
					saveFileDialog1.DefaultExt = "xml";
			        saveFileDialog1.Filter = "Documento Xml (*.xml)|*.xml|Documento txt (*.txt)|*.txt|" +
			        	"Todos los demas (*.*)|*.*)";
			        saveFileDialog1.AddExtension = true;
					if (saveFileDialog1.ShowDialog() == DialogResult.OK)
					{
						XmlTextWriter escriba = new XmlTextWriter(saveFileDialog1.FileName, null);
						escriba.Formatting = Formatting.Indented;
						doc.Save(escriba);
						escriba.Close();
					}
				}
			}		
			openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
			openFileDialog1.FilterIndex = 0;
			openFileDialog1.DefaultExt = "xml";
			openFileDialog1.FileName="";
			if (openFileDialog1.ShowDialog() == DialogResult.OK){
			}
		}
		void BtnClienteClick(object sender, EventArgs e)
		{
			frmClientesDatos Clientes  = new frmClientesDatos();
			Clientes.Tag = openFileDialog1.FileName;
			Clientes.Show();
		}
	}
}
