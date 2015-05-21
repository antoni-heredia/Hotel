/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 07/05/2015
 * Hora: 20:39
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
	/// Description of frmEliminarHabitacion.
	/// </summary>
	public partial class frmEliminarHabitacion : Form
	{
		public frmEliminarHabitacion()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void CargarListado(){
			listView1.Clear();
			XmlDocument doc = new XmlDocument();
			XmlNode nodo;
			doc.Load(this.Tag.ToString());
			nodo=doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
			XmlAttributeCollection atrs ;
			ColumnHeader encabezado1 = new ColumnHeader();
			encabezado1.Text = "Numero de Habitacion";
			listView1.Columns.Add(encabezado1);
			ColumnHeader encabezado2 = new ColumnHeader();
			encabezado2.Text = "Ocupada";
			listView1.Columns.Add(encabezado2);
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
            	listView1.Items.Add(elementoListView);
			}	
			encabezado1.Width = -2;
			encabezado2.Width = -2;			
		
		}
		void FrmEliminarHabitacionLoad(object sender, EventArgs e)
		{
			CargarListado();
		}
		void LblEliminarClick(object sender, EventArgs e)
		{
			try{
			string strocupado = listView1.SelectedItems[0].SubItems[1].Text;
				if ( strocupado == "No" ){
					DialogResult dialogResult = MessageBox.Show("¿Esta seguro que quiere borras esta habit" +
				                                            "acion?", "Comfirmación", MessageBoxButtons.YesNo);
					if(dialogResult == DialogResult.Yes)
					{
						XmlDocument doc = new XmlDocument();
						doc.Load(this.Tag.ToString());
						XmlNode nodo;
						nodo=doc.DocumentElement.SelectSingleNode("/hotel/habitaciones");
						XmlAttributeCollection atrs;
						foreach ( XmlNode habitacion in nodo) {
							atrs=habitacion.Attributes;
							string strNumero=atrs["Numero"].Value;
							if( strNumero ==  listView1.SelectedItems[0].SubItems[0].Text){
								nodo.RemoveChild(habitacion);
								XmlTextWriter escriba = new XmlTextWriter(this.Tag.ToString(), null);
								escriba.Formatting = Formatting.Indented;
								doc.Save(escriba);
								escriba.Close();
								MessageBox.Show("Se ha modificado correctamente");
								CargarListado();
							}
							
						}
					}
					else if (dialogResult == DialogResult.No)
					{
						MessageBox.Show("La habitacion no se ha borrado");
					}
				}else{
					MessageBox.Show("No se puede eliminar una  habitacion ocupada");
				}
			}catch{
				MessageBox.Show("No se ha seleciondo nada");
			}
		}
	}
}
