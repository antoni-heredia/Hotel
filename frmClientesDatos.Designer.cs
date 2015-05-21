/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 20/05/2015
 * Hora: 10:49
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmClientesDatos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btnModificar;
		private System.Windows.Forms.Button btnPDF;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientesDatos));
			this.listView1 = new System.Windows.Forms.ListView();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.btnModificar = new System.Windows.Forms.Button();
			this.btnPDF = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(12, 13);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(471, 236);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// btnModificar
			// 
			this.btnModificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar.BackgroundImage")));
			this.btnModificar.Location = new System.Drawing.Point(489, 180);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(80, 69);
			this.btnModificar.TabIndex = 1;
			this.btnModificar.Text = "Modificar datos";
			this.btnModificar.UseVisualStyleBackColor = true;
			this.btnModificar.Click += new System.EventHandler(this.BtnModificarClick);
			// 
			// btnPDF
			// 
			this.btnPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPDF.BackgroundImage")));
			this.btnPDF.Location = new System.Drawing.Point(489, 102);
			this.btnPDF.Name = "btnPDF";
			this.btnPDF.Size = new System.Drawing.Size(80, 69);
			this.btnPDF.TabIndex = 2;
			this.btnPDF.Text = "Exportar datos a PDF";
			this.btnPDF.UseVisualStyleBackColor = true;
			this.btnPDF.Click += new System.EventHandler(this.BtnPDFClick);
			// 
			// frmClientesDatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(584, 261);
			this.Controls.Add(this.btnPDF);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.listView1);
			this.Name = "frmClientesDatos";
			this.Text = "frmClientesDatos";
			this.Load += new System.EventHandler(this.FrmClientesDatosLoad);
			this.ResumeLayout(false);

		}
	}
}
