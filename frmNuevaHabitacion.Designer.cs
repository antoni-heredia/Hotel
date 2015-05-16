/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 04/05/2015
 * Hora: 19:11
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmNuevaHabitacion
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
			this.lblNumero = new System.Windows.Forms.Label();
			this.lblPlanta = new System.Windows.Forms.Label();
			this.txtPlanta = new System.Windows.Forms.TextBox();
			this.lblCamas = new System.Windows.Forms.Label();
			this.txtCamas = new System.Windows.Forms.TextBox();
			this.txtAforo = new System.Windows.Forms.TextBox();
			this.lblAforo = new System.Windows.Forms.Label();
			this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
			this.lblExtras = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.lblHabitacion = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtPrecioPorExtra = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblNumero
			// 
			this.lblNumero.Location = new System.Drawing.Point(12, 9);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(114, 13);
			this.lblNumero.TabIndex = 0;
			this.lblNumero.Text = "Numero de Habitación:";
			// 
			// lblPlanta
			// 
			this.lblPlanta.Location = new System.Drawing.Point(13, 28);
			this.lblPlanta.Name = "lblPlanta";
			this.lblPlanta.Size = new System.Drawing.Size(113, 17);
			this.lblPlanta.TabIndex = 1;
			this.lblPlanta.Text = "Planta:";
			// 
			// txtPlanta
			// 
			this.txtPlanta.Location = new System.Drawing.Point(132, 25);
			this.txtPlanta.Name = "txtPlanta";
			this.txtPlanta.Size = new System.Drawing.Size(100, 20);
			this.txtPlanta.TabIndex = 2;
			// 
			// lblCamas
			// 
			this.lblCamas.Location = new System.Drawing.Point(12, 51);
			this.lblCamas.Name = "lblCamas";
			this.lblCamas.Size = new System.Drawing.Size(114, 17);
			this.lblCamas.TabIndex = 3;
			this.lblCamas.Text = "Numero de camas: ";
			// 
			// txtCamas
			// 
			this.txtCamas.Location = new System.Drawing.Point(132, 48);
			this.txtCamas.Name = "txtCamas";
			this.txtCamas.Size = new System.Drawing.Size(100, 20);
			this.txtCamas.TabIndex = 4;
			// 
			// txtAforo
			// 
			this.txtAforo.Location = new System.Drawing.Point(132, 71);
			this.txtAforo.Name = "txtAforo";
			this.txtAforo.Size = new System.Drawing.Size(100, 20);
			this.txtAforo.TabIndex = 5;
			// 
			// lblAforo
			// 
			this.lblAforo.Location = new System.Drawing.Point(13, 74);
			this.lblAforo.Name = "lblAforo";
			this.lblAforo.Size = new System.Drawing.Size(113, 17);
			this.lblAforo.TabIndex = 6;
			this.lblAforo.Text = "Aforo:";
			// 
			// checkedListBox1
			// 
			this.checkedListBox1.CheckOnClick = true;
			this.checkedListBox1.FormattingEnabled = true;
			this.checkedListBox1.Items.AddRange(new object[] {
			"Mini-Bar",
			"Television Satelite",
			"Jacussi",
			"Aire Acondicionado",
			"Internet",
			"Decoración Romantica",
			"Servicio privado",
			"Pension Completa",
			"Cama supletoria",
			"Cuna de bebe",
			"Acceso al spa"});
			this.checkedListBox1.Location = new System.Drawing.Point(270, 25);
			this.checkedListBox1.Name = "checkedListBox1";
			this.checkedListBox1.Size = new System.Drawing.Size(196, 169);
			this.checkedListBox1.TabIndex = 7;
			// 
			// lblExtras
			// 
			this.lblExtras.Location = new System.Drawing.Point(270, 6);
			this.lblExtras.Name = "lblExtras";
			this.lblExtras.Size = new System.Drawing.Size(100, 16);
			this.lblExtras.TabIndex = 8;
			this.lblExtras.Text = "Lista de extras:";
			// 
			// btnGuardar
			// 
			this.btnGuardar.Location = new System.Drawing.Point(96, 140);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(80, 69);
			this.btnGuardar.TabIndex = 9;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// lblHabitacion
			// 
			this.lblHabitacion.Location = new System.Drawing.Point(132, 9);
			this.lblHabitacion.Name = "lblHabitacion";
			this.lblHabitacion.Size = new System.Drawing.Size(100, 13);
			this.lblHabitacion.TabIndex = 10;
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(13, 95);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(100, 20);
			this.lblPrecio.TabIndex = 11;
			this.lblPrecio.Text = "Precio: ";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(132, 92);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 20);
			this.txtPrecio.TabIndex = 12;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(13, 119);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 18);
			this.label1.TabIndex = 13;
			this.label1.Text = "Precio por Extra:";
			// 
			// txtPrecioPorExtra
			// 
			this.txtPrecioPorExtra.Location = new System.Drawing.Point(132, 114);
			this.txtPrecioPorExtra.Name = "txtPrecioPorExtra";
			this.txtPrecioPorExtra.Size = new System.Drawing.Size(100, 20);
			this.txtPrecioPorExtra.TabIndex = 14;
			// 
			// frmNuevaHabitacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 221);
			this.Controls.Add(this.txtPrecioPorExtra);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblHabitacion);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblExtras);
			this.Controls.Add(this.checkedListBox1);
			this.Controls.Add(this.lblAforo);
			this.Controls.Add(this.txtAforo);
			this.Controls.Add(this.txtCamas);
			this.Controls.Add(this.lblCamas);
			this.Controls.Add(this.txtPlanta);
			this.Controls.Add(this.lblPlanta);
			this.Controls.Add(this.lblNumero);
			this.Name = "frmNuevaHabitacion";
			this.Text = "Nueva Habitacion";
			this.Load += new System.EventHandler(this.FrmNuevaHabitacionLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblExtras;
		private System.Windows.Forms.CheckedListBox checkedListBox1;
		private System.Windows.Forms.Label lblAforo;
		private System.Windows.Forms.TextBox txtAforo;
		private System.Windows.Forms.TextBox txtCamas;
		private System.Windows.Forms.Label lblCamas;
		private System.Windows.Forms.TextBox txtPlanta;
		private System.Windows.Forms.Label lblPlanta;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblHabitacion;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPrecioPorExtra;
	}
}
