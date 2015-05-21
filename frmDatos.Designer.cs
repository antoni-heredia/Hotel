/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 06/05/2015
 * Hora: 10:08
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmDatos
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
			this.lblPlanta = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblOcupada = new System.Windows.Forms.Label();
			this.lblAforo = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.lvExtras = new System.Windows.Forms.ListView();
			this.lblPrecioPorExtra = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblPlanta
			// 
			this.lblPlanta.BackColor = System.Drawing.Color.Transparent;
			this.lblPlanta.Location = new System.Drawing.Point(12, 69);
			this.lblPlanta.Name = "lblPlanta";
			this.lblPlanta.Size = new System.Drawing.Size(100, 22);
			this.lblPlanta.TabIndex = 0;
			this.lblPlanta.Text = "Planta: ";
			// 
			// lblNumero
			// 
			this.lblNumero.BackColor = System.Drawing.Color.Transparent;
			this.lblNumero.Location = new System.Drawing.Point(13, 23);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(100, 23);
			this.lblNumero.TabIndex = 1;
			this.lblNumero.Text = "Numero: ";
			// 
			// lblOcupada
			// 
			this.lblOcupada.BackColor = System.Drawing.Color.Transparent;
			this.lblOcupada.Location = new System.Drawing.Point(12, 46);
			this.lblOcupada.Name = "lblOcupada";
			this.lblOcupada.Size = new System.Drawing.Size(100, 23);
			this.lblOcupada.TabIndex = 2;
			this.lblOcupada.Text = "Ocupada: ";
			// 
			// lblAforo
			// 
			this.lblAforo.BackColor = System.Drawing.Color.Transparent;
			this.lblAforo.Location = new System.Drawing.Point(140, 23);
			this.lblAforo.Name = "lblAforo";
			this.lblAforo.Size = new System.Drawing.Size(100, 23);
			this.lblAforo.TabIndex = 4;
			this.lblAforo.Text = "Aforo: ";
			// 
			// lblPrecio
			// 
			this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
			this.lblPrecio.Location = new System.Drawing.Point(140, 46);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(100, 23);
			this.lblPrecio.TabIndex = 5;
			this.lblPrecio.Text = "Precio: ";
			// 
			// lvExtras
			// 
			this.lvExtras.Location = new System.Drawing.Point(12, 94);
			this.lvExtras.Name = "lvExtras";
			this.lvExtras.Size = new System.Drawing.Size(271, 155);
			this.lvExtras.TabIndex = 6;
			this.lvExtras.UseCompatibleStateImageBehavior = false;
			this.lvExtras.View = System.Windows.Forms.View.Details;
			// 
			// lblPrecioPorExtra
			// 
			this.lblPrecioPorExtra.BackColor = System.Drawing.Color.Transparent;
			this.lblPrecioPorExtra.Location = new System.Drawing.Point(140, 69);
			this.lblPrecioPorExtra.Name = "lblPrecioPorExtra";
			this.lblPrecioPorExtra.Size = new System.Drawing.Size(143, 22);
			this.lblPrecioPorExtra.TabIndex = 7;
			this.lblPrecioPorExtra.Text = "Precio por Extra: ";
			// 
			// frmDatos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(295, 261);
			this.Controls.Add(this.lblPrecioPorExtra);
			this.Controls.Add(this.lvExtras);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblAforo);
			this.Controls.Add(this.lblOcupada);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.lblPlanta);
			this.Name = "frmDatos";
			this.Text = "Datos";
			this.Load += new System.EventHandler(this.FrmDatosLoad);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.ListView lvExtras;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblAforo;
		private System.Windows.Forms.Label lblOcupada;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblPlanta;
		private System.Windows.Forms.Label lblPrecioPorExtra;
	}
}
