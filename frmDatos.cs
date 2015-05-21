/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 06/05/2015
 * Hora: 10:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
namespace Hotel
{
	/// <summary>
	/// Description of frmDatos.
	/// </summary>
	public partial class frmDatos : Form
	{
		public frmDatos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void FrmDatosLoad(object sender, EventArgs e)
		{
			char caracterlimitador='|';
			string text = this.Tag.ToString();
			string[] word = text.Split(caracterlimitador);
			XmlDocument	doc = new XmlDocument();
			doc.Load(word[1]);
			XmlNode nodo;
			nodo = doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
			XmlAttributeCollection atrs ;
			ColumnHeader encabezado = new ColumnHeader();
			encabezado.Text = "Extras";
			lvExtras.Columns.Add(encabezado);
			foreach( XmlNode habitacion in nodo){
				atrs=habitacion.Attributes;
				string strNumero=atrs["Numero"].Value;
				string strOcupada=atrs["ocupada"].Value;
				if( strNumero == word[0]){
					lblNumero.Text += strNumero;
					lblOcupada.Text += strOcupada;
					lblPlanta.Text += habitacion["planta"].InnerText;
					lblPrecio.Text += habitacion["Precio"].InnerText;
					lblAforo.Text += habitacion["Aforo"].InnerText;
					lblPrecioPorExtra.Text += habitacion["PrecioPorExtra"].InnerText;
					foreach (XmlNode element in habitacion["Extras"]) {
       					lvExtras.Items.Add(element.InnerText);
					}
				}
				encabezado.Width = -2;
			}
		}
		
		
	}
}
