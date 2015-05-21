/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 07/05/2015
 * Hora: 18:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Net.Mime;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.html;

namespace Hotel
{
	/// <summary>
	/// Description of frmSalidaUsuario.
	/// </summary>
	public partial class frmSalidaUsuario : Form
	{
		public frmSalidaUsuario()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			// 
		}
		
		void FrmSalidaUsuarioLoad(object sender, EventArgs e)
		{
			char caracterlimitador='|';
			string text = this.Tag.ToString();
			string[] word = text.Split(caracterlimitador);
			XmlDocument	doc = new XmlDocument();
			XmlNode nodo;
			doc.Load(word[1]);

			XmlAttributeCollection atrs;
			nodo = doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
			foreach( XmlNode habitacion in nodo){
				atrs=habitacion.Attributes;
				string strNumero=atrs["Numero"].Value;
				string strOcupada=atrs["ocupada"].Value;
				if( strNumero == word[0]){
					NumeroHabitacion.Text=strNumero;
					lblPrecioHabitacion.Text=habitacion["Precio"].InnerText;
					lblPrecioExtra.Text =habitacion["PrecioPorExtra"].InnerText;
					foreach (XmlNode element in habitacion["Extras"]) {
       					lvExtras.Items.Add(element.InnerText);
					}
				}
			}
			nodo=doc.DocumentElement.SelectSingleNode("/hotel/Clientes");
			foreach (XmlNode cliente in nodo) {
				atrs=cliente.Attributes;
				string strNumero=atrs["Numero"].Value;
				if ( strNumero == word[0]){
					string strFechaEntrada=cliente["DiaEntrada"].InnerText;
					char caracterlimitado2='/';
					string texto = strFechaEntrada;
					string[] word2 = texto.Split(caracterlimitado2);
					dtpEntrada.Value = new DateTime(int.Parse(word2[2]),int.Parse(word2[1]),
					                                int.Parse(word2[0]));
					Nombre.Text += cliente["Nombre"].InnerText;
					Apellido.Text += cliente["Apellido"].InnerText;
					Dni.Text += atrs["DNI"].Value;
				}
			}
			
		}
		
		void BtnCalculadarClick(object sender, EventArgs e)
		{
			TimeSpan ts = dtpSalida.Value - dtpEntrada.Value;
			int differenceInDays = ts.Days;
			float fltPrecioHabitacion= float.Parse(lblPrecioHabitacion.Text);
			float fltPrecioExtra = float.Parse(lblPrecioExtra.Text);
			float fltTotal = differenceInDays*fltPrecioHabitacion+fltPrecioExtra*lvExtras.Items.Count;
			lblTotalAPagar.Text = fltTotal.ToString();
		}
		void BtnConfirmarClick(object sender, EventArgs e)
		{
			char caracterlimitador='|';
			string text = this.Tag.ToString();
			string[] word = text.Split(caracterlimitador);
			XmlDocument	doc = new XmlDocument();
			XmlNode nodo;
			doc.Load(word[1]);
			string strNumero;
			XmlAttributeCollection atrs;
			nodo = doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
			foreach( XmlNode habitacion in nodo){
				atrs=habitacion.Attributes;
				strNumero=atrs["Numero"].Value;
				if( strNumero == word[0]){
					atrs["ocupada"].Value="No";
				}
			}
			nodo = doc.DocumentElement.SelectSingleNode("/hotel/Clientes");
			foreach ( XmlNode cliente in nodo) {
				atrs=cliente.Attributes;
				strNumero=atrs["Numero"].Value;
				if( strNumero == word[0]){
					nodo.RemoveChild(cliente);;
				}
			}
			XmlTextWriter escriba = new XmlTextWriter(word[1], null);
			escriba.Formatting = Formatting.Indented;
			doc.Save(escriba);
			escriba.Close();
			MessageBox.Show("Se ha modificado correctamente");
		}
		void LblFacturaClick(object sender, EventArgs e)
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
						doc2.AddTitle("Factura del usuario: "+Nombre.Text+" "+Apellido.Text);
						doc2.AddCreator("Hotel");
						 
						// Abrimos el archivo
						doc2.Open();
						// Creamos el tipo de Font que vamos utilizar
						iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
						 
						// Escribimos el encabezamiento en el documento
						doc2.Add(new Paragraph("Factura del usuario: "+Nombre.Text+" "+Apellido.Text));
						doc2.Add(Chunk.NEWLINE);
						 
						// Creamos una tabla que contendrá el nombre, apellido y país
						// de nuestros visitante.
						PdfPTable tblPrueba = new PdfPTable(6);
						tblPrueba.WidthPercentage = 100;
						 
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
						
						PdfPCell clSalida = new PdfPCell(new Phrase("Fecha de Salida", _standardFont));
						clSalida.BorderWidth = 0;
						clSalida.BorderWidthBottom = 0.75f;
						
						 
						// Añadimos las celdas a la tabla
						tblPrueba.AddCell(clNombre);
						tblPrueba.AddCell(clApellido);
						tblPrueba.AddCell(clDni);
						tblPrueba.AddCell(clNumeroHabitacion);
						tblPrueba.AddCell(clEntrada);
						tblPrueba.AddCell(clSalida);
						 
						// Llenamos la tabla con información
						clNombre = new PdfPCell(new Phrase(Nombre.Text, _standardFont));
						clNombre.BorderWidth = 0;
						 
						clApellido = new PdfPCell(new Phrase(Apellido.Text, _standardFont));
						clApellido.BorderWidth = 0;
						 
						clDni = new PdfPCell(new Phrase(Dni.Text, _standardFont));
						clDni.BorderWidth = 0;
						
						clNumeroHabitacion = new PdfPCell(new Phrase(NumeroHabitacion.Text, _standardFont));
						clNumeroHabitacion.BorderWidth = 0;
						
						clEntrada = new PdfPCell(new Phrase(dtpEntrada.Value.ToString("dd/MM/yyyy"), _standardFont));
						clEntrada.BorderWidth = 0;
						
						clSalida = new PdfPCell(new Phrase(dtpSalida.Value.ToString("dd/MM/yyyy"), _standardFont));
						clSalida.BorderWidth = 0;
						 
						// Añadimos las celdas a la tabla
						tblPrueba.AddCell(clNombre);
						tblPrueba.AddCell(clApellido);
						tblPrueba.AddCell(clDni);						
						tblPrueba.AddCell(clNumeroHabitacion);
						tblPrueba.AddCell(clEntrada);
						tblPrueba.AddCell(clSalida);
						doc2.Add(tblPrueba);
						//Ponemos los extras que habia en la habitacion
						PdfPTable tblExtras = new PdfPTable(3);
						tblExtras.WidthPercentage = 100;
						PdfPCell clExtra = new PdfPCell(new Phrase("Producto", _standardFont));
						clExtra.BorderWidth = 0;
						clExtra.BorderWidthBottom = 0.75f;
						
						PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", _standardFont));
						clPrecio.BorderWidth = 0;
						clPrecio.BorderWidthBottom = 0.75f;

						PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _standardFont));
						clCantidad.BorderWidth = 0;
						clCantidad.BorderWidthBottom = 0.75f;
						
						tblExtras.AddCell(clExtra);
						tblExtras.AddCell(clPrecio);
						tblExtras.AddCell(clCantidad);
						clExtra = new PdfPCell(new Phrase("Habitacion", _standardFont));
						clExtra.BorderWidth = 0;
						clPrecio = new PdfPCell(new Phrase(lblPrecioHabitacion.Text+"€/Dia", _standardFont));
						clPrecio.BorderWidth = 0;
						TimeSpan ts = dtpSalida.Value - dtpEntrada.Value;
						int differenceInDays = ts.Days;
						clCantidad = new PdfPCell(new Phrase(differenceInDays.ToString()+" Dias", _standardFont));
						clCantidad.BorderWidth = 0;
						tblExtras.AddCell(clExtra);
						tblExtras.AddCell(clPrecio);
						tblExtras.AddCell(clCantidad);
						foreach (object Item  in lvExtras.Items) {
							char caracterlimitadorExtras='{';
							string TextoExtras = Item.ToString();
							string[] ItemExtra = TextoExtras.Split(caracterlimitadorExtras);
							clExtra = new PdfPCell(new Phrase(ItemExtra[1].Remove(ItemExtra[1].Length-1), _standardFont));
							clExtra.BorderWidth = 0;
							clPrecio = new PdfPCell(new Phrase(lblPrecioExtra.Text+"€", _standardFont));
							clPrecio.BorderWidth = 0;
							clCantidad = new PdfPCell(new Phrase("1", _standardFont));
							clCantidad.BorderWidth = 0;
												
							tblExtras.AddCell(clExtra);
							tblExtras.AddCell(clPrecio);
							tblExtras.AddCell(clCantidad);
						}
						doc2.Add(Chunk.NEWLINE);
						doc2.Add(tblExtras);
						doc2.Add(Chunk.NEWLINE);
						doc2.Add(new Paragraph("Total a pagar: "+lblTotalAPagar.Text));
						doc2.Add(Chunk.NEWLINE);
						
						PdfPTable tblFirma = new PdfPTable(2);
						tblFirma.WidthPercentage = 100;
						 
						PdfPCell clFirma = new PdfPCell(new Phrase("Firma Usuario", _standardFont));
						clFirma.BorderWidth = 0;

						 
						PdfPCell clSello = new PdfPCell(new Phrase("Sello de la empresa", _standardFont));
						clSello.BorderWidth = 0;

						
						tblFirma.AddCell(clFirma);
						tblFirma.AddCell(clSello);
						doc2.Add(tblFirma);
						
						doc2.Close();
						writer.Close();
						this.Close();
					}
				}

		}

	
	}
}
