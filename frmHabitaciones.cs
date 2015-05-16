/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 05/05/2015
 * Hora: 10:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;
namespace Hotel
{
	/// <summary>
	/// Description of frmHabitaciones.
	/// </summary>
	public partial class frmHabitaciones : Form
	{



		public frmHabitaciones()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

		}
		public void CargarListado(string ruta){
				lvHabitaciones.View = View.Details;
				XmlDocument doc = new XmlDocument();
				XmlNode nodo;
				doc.Load(ruta);
				nodo=doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
				XmlAttributeCollection atrs ;
				lvHabitaciones.Columns.Add("Numero de Habitacion");
				lvHabitaciones.Columns.Add("Ocupado");
				foreach (XmlNode  habitaciones in nodo) {
					atrs=habitaciones.Attributes;
					string strNumero=atrs["Numero"].Value;
					string[] elementosFila = new string[2];
		           	ListViewItem elementoListView; 
		           	elementosFila[0]=strNumero;
		           	string strOcupada=atrs["ocupada"].Value;
		        	elementosFila[1]=strOcupada;
		       		elementoListView = new ListViewItem(elementosFila);
					elementoListView.Tag=strNumero;
		           	lvHabitaciones.Items.Add(elementoListView);
				}
		}
		
		void FrmHabitacionesLoad(object sender, EventArgs e)
		{
			try{
				this.CargarListado(this.Tag.ToString());
			}catch{
				MessageBox.Show("No se ha selecionando nada");
			}	
		}
		
		void BtnDatosClick(object sender, EventArgs e)
		{
			try{
				frmDatos DatosHabitacion = new frmDatos();
				DatosHabitacion.Tag = lvHabitaciones.SelectedItems[0].Tag+"|"+this.Tag.ToString(); 
				DatosHabitacion.Show();
			}catch{
		    	MessageBox.Show("No se ha selecionando nada");
		    }
		}
		void LblAñadirClick(object sender, EventArgs e)
		{
			try{
	      		string ocupado = lvHabitaciones.SelectedItems[0].SubItems[1].Text;
				if ( ocupado == "No" ){
					frmAñadir Añadir = new frmAñadir();
					Añadir.Tag = lvHabitaciones.SelectedItems[0].Tag+"|"+this.Tag.ToString();
					Añadir.Show();
				}else{
					MessageBox.Show("No se puede usar una habitacion ocupada");
				}
    		}
		    catch{
		    	MessageBox.Show("No se ha selecionando nada");
		    }
			
			
		}
		
		void LblSalidaClick(object sender, EventArgs e)
		{
			try{
				string ocupado = lvHabitaciones.SelectedItems[0].SubItems[1].Text;
				if ( ocupado == "Si" ){
					frmSalidaUsuario Salida = new frmSalidaUsuario();
					Salida.Tag=lvHabitaciones.SelectedItems[0].Tag+"|"+this.Tag.ToString();
					Salida.Show();
				}else{
					MessageBox.Show("No hay nadie en esa habitación");
				}
			}catch{
		    	MessageBox.Show("No se ha selecionando nada");			
			}
		}
	}
}
