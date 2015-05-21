/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 20/05/2015
 * Hora: 10:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;

namespace Hotel
{
	/// <summary>
	/// Description of frmClientesDatos.
	/// </summary>
	public partial class frmClientesDatos : Form
	{
		public frmClientesDatos()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CargarDatos(){
			listView1.Clear();
			XmlDocument	doc = new XmlDocument();
			doc.Load(this.Tag.ToString());
			XmlNode nodo;
			nodo = doc.DocumentElement.SelectSingleNode("/hotel/Clientes");
			ColumnHeader encabezado = new ColumnHeader();
			encabezado.Text = "Nº habitacion";
			listView1.Columns.Add(encabezado);
			ColumnHeader encabezado1 = new ColumnHeader();
			encabezado1.Text = "Nombre";
			listView1.Columns.Add(encabezado1);
			ColumnHeader encabezado2 = new ColumnHeader();
			encabezado2.Text = "Apellidos";
			listView1.Columns.Add(encabezado2);
			ColumnHeader encabezado3 = new ColumnHeader();
			encabezado3.Text = "DNI";
			listView1.Columns.Add(encabezado3);
			ColumnHeader encabezado4 = new ColumnHeader();
			encabezado4.Text = "Dia de entrada";
			listView1.Columns.Add(encabezado4);
			XmlAttributeCollection atrs ;
			foreach (XmlNode  cliente in nodo) {
				atrs=cliente.Attributes;
				string strNumero=atrs["Numero"].Value;
				string[] elementosFila = new string[5];
            	ListViewItem elementoListView; 
            	elementosFila[0]=strNumero;
            	string strNombre=cliente["Nombre"].InnerText;
            	elementosFila[1]=strNombre;
            	string strApellido=cliente["Apellido"].InnerText;
            	elementosFila[2]=strApellido;
            	string strDni=atrs["DNI"].Value;
           		elementosFila[3]=strDni;
           		string strDiaEntrada=cliente["DiaEntrada"].InnerText;
            	elementosFila[4]=strDiaEntrada;
       			elementoListView = new ListViewItem(elementosFila);
				elementoListView.Tag=strNumero;
            	listView1.Items.Add(elementoListView);
			}	
			encabezado.Width = -2;
			encabezado1.Width = -2;
			encabezado2.Width = -2;
			encabezado3.Width = -2;
			encabezado4.Width = -2;
		
		}
		
		void myForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.CargarDatos();
		}
		void FrmClientesDatosLoad(object sender, EventArgs e)
		{
			this.CargarDatos();
		}
		void BtnModificarClick(object sender, EventArgs e)
		{
			try{
				frmModificarCliente Modificar = new frmModificarCliente();
				Modificar.Tag = listView1.SelectedItems[0].Tag+"|"+this.Tag.ToString();
				Modificar.FormClosing += new FormClosingEventHandler(myForm_FormClosing);
				Modificar.Show();
			}catch{
				MessageBox.Show("No se ha selecionado nada");
			}
			
		}
		void BtnPDFClick(object sender, EventArgs e)
		{
	
			using(SaveFileDialog saveFileDialog1 = new SaveFileDialog()){
					saveFileDialog1.DefaultExt = "pdf";
			        saveFileDialog1.Filter = "Documento pdf (*.pdf)|*.pdf|Todos los demas (*.*)|*.*)";
			        saveFileDialog1.AddExtension = true;
					if (saveFileDialog1.ShowDialog() == DialogResult.OK){
						// Creamos el documento con el tamaño de página tradicional
						Document doc2 = new Document(PageSize.LETTER);
						// Indicamos donde vamos a guardar el documento
						PdfWriter writer = PdfWriter.GetInstance(doc2,
			                            new FileStream(@saveFileDialog1.FileName, FileMode.Create));
						// Le colocamos el título y el autor
						// **Nota: Esto no será visible en el documento
						doc2.AddTitle("Resumen de los usuarios");
						doc2.AddCreator("Hotel");
						 
						// Abrimos el archivo
						doc2.Open();
						// Creamos el tipo de Font que vamos utilizar
						iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
						 
						// Escribimos el encabezamiento en el documento
						doc2.Add(new Paragraph("Resumen de los usuarios"));
						doc2.Add(Chunk.NEWLINE);
						 
						// Creamos una tabla que contendrá el nombre, apellido y país
						// de nuestros visitante.
						PdfPTable tblUsuarios = new PdfPTable(5);
						tblUsuarios.WidthPercentage = 100;
						 
						// Configuramos el título de las columnas de la tabla
						PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
						clNombre.BorderWidth = 0;
						clNombre.BorderWidthBottom = 0.75f;
						 
						PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont));
						clApellido.BorderWidth = 0;
						clApellido.BorderWidthBottom = 0.75f;
						 
						PdfPCell clDni = new PdfPCell(new Phrase("Dni", _standardFont));
						clDni.BorderWidth = 0;
						clDni.BorderWidthBottom = 0.75f;
						
						PdfPCell clNumeroHabitacion = new PdfPCell(new Phrase("Numero habitacion", _standardFont));
						clNumeroHabitacion.BorderWidth = 0;
						clNumeroHabitacion.BorderWidthBottom = 0.75f;
						
						PdfPCell clEntrada = new PdfPCell(new Phrase("Fecha de Entrada", _standardFont));
						clEntrada.BorderWidth = 0;
						clEntrada.BorderWidthBottom = 0.75f;
						
						
						
						 
						// Añadimos las celdas a la tabla
						tblUsuarios.AddCell(clNombre);
						tblUsuarios.AddCell(clApellido);
						tblUsuarios.AddCell(clDni);
						tblUsuarios.AddCell(clNumeroHabitacion);
						tblUsuarios.AddCell(clEntrada);
						 
						// Llenamos la tabla con información
						listView1.Clear();
						XmlDocument	doc = new XmlDocument();
						doc.Load(this.Tag.ToString());
						XmlNode nodo;
						nodo = doc.DocumentElement.SelectSingleNode("/hotel/Clientes");
						XmlAttributeCollection atrs2;
						foreach (XmlNode cliente in nodo) {			            	
			            	string strNombre=cliente["Nombre"].InnerText;
							clNombre = new PdfPCell(new Phrase(strNombre, _standardFont));
							clNombre.BorderWidth = 0;
							
			            	string strApellido=cliente["Apellido"].InnerText;
							clApellido = new PdfPCell(new Phrase(strApellido, _standardFont));
							clApellido.BorderWidth = 0;
							
							atrs2=cliente.Attributes;
			            	string strDni=atrs2["DNI"].Value;
							clDni = new PdfPCell(new Phrase(strDni, _standardFont));
							clDni.BorderWidth = 0;
							
							
							string strNumero=atrs2["Numero"].Value;
							clNumeroHabitacion = new PdfPCell(new Phrase(strNumero, _standardFont));
							clNumeroHabitacion.BorderWidth = 0;
							
			           		string strDiaEntrada=cliente["DiaEntrada"].InnerText;
							clEntrada = new PdfPCell(new Phrase(strDiaEntrada, _standardFont));
							clEntrada.BorderWidth = 0;
							// Añadimos las celdas a la tabla
							tblUsuarios.AddCell(clNombre);
							tblUsuarios.AddCell(clApellido);
							tblUsuarios.AddCell(clDni);						
							tblUsuarios.AddCell(clNumeroHabitacion);
							tblUsuarios.AddCell(clEntrada);
						
						}
						doc2.Add(tblUsuarios);

						doc2.Close();
						writer.Close();
						this.Close();
					}
				}

		}
		
		
	}
}