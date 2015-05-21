/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 04/05/2015
 * Hora: 19:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace Hotel
{
	/// <summary>
	/// Description of frmNuevaHabitacion.
	/// </summary>
	public partial class frmNuevaHabitacion : Form
	{
		public frmNuevaHabitacion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void FrmNuevaHabitacionLoad(object sender, EventArgs e)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(this.Tag.ToString());
			XmlNode nodo;
			nodo=doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
			int iContador=1;
			bool  control=true;
			if( nodo.InnerXml == ""){	
					lblHabitacion.Text="1";
					control = false;
				}
			if (control){
				XmlNode UltimoNodo;
				UltimoNodo=nodo.LastChild;
				XmlAttributeCollection atrsUltimo ;
				atrsUltimo=UltimoNodo.Attributes;
				string UltimoNumero=atrsUltimo["Numero"].Value;
				foreach ( XmlNode habitacion in nodo) {
		
					XmlAttributeCollection atrs ;
					atrs=habitacion.Attributes;
					string strNumero=atrs["Numero"].Value;
					int iNumero=int.Parse(strNumero);
					if( iNumero !=  iContador){
						lblHabitacion.Text=iContador.ToString();
						break;
					}
					if( strNumero == UltimoNumero){
						iContador++;
						lblHabitacion.Text=iContador.ToString();
						break;
					}
					iContador++;
				}
			}

			
			
		}
		void BtnGuardarClick(object sender, EventArgs e)
		{
			int iContador=1;
			string sXML2="";
			foreach(object itemChecked in checkedListBox1.CheckedItems){
				sXML2=sXML2+"<Extra Numero="+"\"" +iContador+"\""+">"+itemChecked.ToString()+"</Extra>";
				iContador++;
			}
			string strNumero=lblHabitacion.Text;
			string strPlanta=txtPlanta.Text;
			string strCamas=txtCamas.Text;
			string strAforo=txtAforo.Text;
			string strPrecio=txtPrecio.Text;
			if ( strNumero.Length == 0 || strPlanta.Length == 0 || strCamas.Length == 0 || strAforo.Length == 0
			    || strPrecio.Length == 0){
				MessageBox.Show("Hay campos vacios");
			}else{
				string sXML=
					"<planta></planta>"+
					"<NumeroCamas></NumeroCamas>"+
					"<Aforo></Aforo>"+
					"<Extras></Extras>"+
					"<PrecioPorExtra></PrecioPorExtra>"+
					"<Precio></Precio>";
				XmlDocument doc = new XmlDocument();
				doc.Load(this.Tag.ToString());
				XmlNode nodo;
				nodo=doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
				//XmlAttributeCollection atrs ;
			//	atrs=nodo.LastChild.Attributes;
			//	string strUltimoNumero=atrs["Numero"].Value;
			
				XmlElement habitacion = doc.CreateElement("habitacion");
				XmlAttribute atributo;
				atributo=doc.CreateAttribute("Numero");
				atributo.Value=strNumero;
				habitacion.SetAttributeNode(atributo);
				atributo=doc.CreateAttribute("ocupada");
				atributo.Value="No";
				habitacion.SetAttributeNode(atributo);
				habitacion.InnerXml=sXML;
				habitacion["planta"].InnerText= strPlanta;
				habitacion["NumeroCamas"].InnerText=strCamas;
				habitacion["Aforo"].InnerText=strAforo;
				habitacion["Precio"].InnerText=strPrecio;
				habitacion["PrecioPorExtra"].InnerText=txtPrecioPorExtra.Text;;
				habitacion["Extras"].InnerXml=sXML2;

				if (!nodo.HasChildNodes){
						doc.SelectSingleNode("/hotel/habitaciones").AppendChild(habitacion);
						XmlTextWriter escriba = new XmlTextWriter(this.Tag.ToString(), null);
						escriba.Formatting = Formatting.Indented;
						doc.Save(escriba);
						escriba.Close();
						MessageBox.Show("Se ha modificado correctamente");
						this.Close();
				}else{
					foreach (XmlNode habitacion2 in nodo) {
						XmlAttributeCollection atrs2 ;
						atrs2=habitacion2.Attributes;
						string strNumero2=atrs2["Numero"].Value;
						int iNumero2=int.Parse(strNumero2);
						int iNumero=int.Parse(strNumero);
						if( iNumero == 1){
							doc.SelectSingleNode("/hotel/habitaciones").InsertBefore(
								habitacion,nodo.FirstChild);
							break;
						}
						if( iNumero2+1 ==  iNumero){
							doc.SelectSingleNode("/hotel/habitaciones").InsertAfter(
								habitacion,habitacion2);
							break;
						}
					}

					XmlTextWriter escriba = new XmlTextWriter(this.Tag.ToString(), null);
					escriba.Formatting = Formatting.Indented;
					doc.Save(escriba);
					escriba.Close();
					MessageBox.Show("Se ha modificado correctamente");
					this.Close();
				}
			}
		}
		
	}
}
