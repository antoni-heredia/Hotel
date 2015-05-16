/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 06/05/2015
 * Hora: 20:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using System.Xml;

namespace Hotel
{
	/// <summary>
	/// Description of frmAñadir.
	/// </summary>
	public partial class frmAñadir : Form
	{
		public frmAñadir()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		public	void BtnGuardarClick(object sender, EventArgs e)
		{	
			
			string sXML=
					"<Nombre></Nombre>"+
					"<Apellido></Apellido>"+
					"<DiaEntrada></DiaEntrada>";
				XmlDocument	doc = new XmlDocument();
				char caracterlimitador='|';
				string text = this.Tag.ToString();
				string[] word = text.Split(caracterlimitador);
				doc.Load(word[1]);
				XmlNode nodo;
				nodo=doc.DocumentElement.SelectSingleNode("/hotel/Clientes");
				string strNumero = lblNum.Text;
				XmlElement cliente = doc.CreateElement("Cliente");
				XmlAttribute atributo;
				atributo=doc.CreateAttribute("Numero");
				atributo.Value=strNumero;
				cliente.SetAttributeNode(atributo);
				atributo=doc.CreateAttribute("DNI");
				atributo.Value=txtDni.Text;
				cliente.SetAttributeNode(atributo);
				cliente.InnerXml=sXML;
				cliente["Nombre"].InnerText= txtNombre.Text;
				cliente["Apellido"].InnerText=txtApellido.Text;
				cliente["DiaEntrada"].InnerText=dateTimePicker1.Value.ToString("dd/MM/yyyy");
				doc.SelectSingleNode("/hotel/Clientes").AppendChild(cliente);
				//Cambiamos el atributo ocupada de la habitacion a si
				nodo=doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
				XmlAttributeCollection atrs2 ;
				foreach (XmlNode habitacion in nodo) {
					atrs2 = habitacion.Attributes;
					if ( atrs2["Numero"].Value == strNumero){
						atrs2["ocupada"].Value = "Si";
					}
				}
				label1.Text=doc.InnerXml;
				XmlTextWriter escriba = new XmlTextWriter(word[1], null);
				escriba.Formatting = Formatting.Indented;
				doc.Save(escriba);
				escriba.Close();
				MessageBox.Show("Se ha modificado correctamente");
				
		}
		void FrmAñadirLoad(object sender, EventArgs e)
		{
			
			XmlDocument	doc = new XmlDocument();
			char caracterlimitador='|';
			string text = this.Tag.ToString();
			string[] word = text.Split(caracterlimitador);
			doc.Load(word[1]);	
			lblNum.Text=word[0];
		}
		
	}
}
