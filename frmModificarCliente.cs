/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 19/05/2015
 * Hora: 14:28
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
	/// Description of frmModificarCliente.
	/// </summary>
	public partial class frmModificarCliente : Form
	{
		public frmModificarCliente()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void FrmModificarClienteLoad(object sender, EventArgs e)
		{
			char caracterlimitador='|';
			string text = this.Tag.ToString();
			string[] word = text.Split(caracterlimitador);
			XmlDocument	doc = new XmlDocument();
			doc.Load(word[1]);
			XmlNode nodo;
			nodo = doc.DocumentElement.SelectSingleNode("/hotel/Clientes");
			XmlAttributeCollection atrs ;
			foreach( XmlNode cliente in nodo){
				atrs=cliente.Attributes;
				string strNumero=atrs["Numero"].Value;
				string strDni=atrs["DNI"].Value;
				if( strNumero == word[0]){
					txtNombre.Text = cliente["Nombre"].InnerText;
					txtApellidos.Text = cliente["Apellido"].InnerText;
					txtDni.Text = strDni;
					string strFechaEntrada=cliente["DiaEntrada"].InnerText;
					char caracterlimitado2='/';
					string texto = strFechaEntrada;
					string[] word2 = texto.Split(caracterlimitado2);
					dtpEntrada.Value = new DateTime(int.Parse(word2[2]),int.Parse(word2[1]),
					                                int.Parse(word2[0]));
					lblNumeroHabitacion.Text=strNumero;
				}
			}
		}
		void Button1Click(object sender, EventArgs e)
		{
			char caracterlimitador='|';
			string text = this.Tag.ToString();
			string[] word = text.Split(caracterlimitador);
			XmlDocument	doc = new XmlDocument();
			doc.Load(word[1]);
			XmlNode nodo;
			nodo = doc.DocumentElement.SelectSingleNode("/hotel/Clientes");
			XmlAttributeCollection atrs ;
			foreach( XmlNode cliente in nodo){
				atrs=cliente.Attributes;
				string strNumero=atrs["Numero"].Value;
				if( strNumero == word[0]){
					cliente["Nombre"].InnerText = txtNombre.Text;
					cliente["Apellido"].InnerText = txtApellidos.Text;
					atrs["DNI"].Value = txtDni.Text ;
					string strFechaEntrada=cliente["DiaEntrada"].InnerText;
					cliente["DiaEntrada"].InnerText=dtpEntrada.Value.ToString("dd/MM/yyyy");
				}
			}
			XmlTextWriter escriba = 
							new XmlTextWriter(word[1], null);
			escriba.Formatting = Formatting.Indented;
			doc.Save(escriba);
			escriba.Close();
			MessageBox.Show("Se ha modificado correctamente");
			this.Close();
		}
	}
}