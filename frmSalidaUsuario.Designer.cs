/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 07/05/2015
 * Hora: 18:52
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmSalidaUsuario
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
			this.lblConfirmacion = new System.Windows.Forms.Label();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.dtpSalida = new System.Windows.Forms.DateTimePicker();
			this.lblEntrada = new System.Windows.Forms.Label();
			this.lblSalida = new System.Windows.Forms.Label();
			this.lblPrecio = new System.Windows.Forms.Label();
			this.btnCalculadar = new System.Windows.Forms.Button();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblApellidos = new System.Windows.Forms.Label();
			this.lblDni = new System.Windows.Forms.Label();
			this.lblNumero = new System.Windows.Forms.Label();
			this.lvExtras = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.lblTotal = new System.Windows.Forms.Label();
			this.btnConfirmar = new System.Windows.Forms.Button();
			this.lblTotalAPagar = new System.Windows.Forms.Label();
			this.lblPrecioPorExtra = new System.Windows.Forms.Label();
			this.lblPrecioHabitacion = new System.Windows.Forms.Label();
			this.lblPrecioExtra = new System.Windows.Forms.Label();
			this.lblFactura = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.Nombre = new System.Windows.Forms.Label();
			this.Apellido = new System.Windows.Forms.Label();
			this.NumeroHabitacion = new System.Windows.Forms.Label();
			this.Dni = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblConfirmacion
			// 
			this.lblConfirmacion.Font = new System.Drawing.Font("Stencil Std", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmacion.Location = new System.Drawing.Point(12, 9);
			this.lblConfirmacion.Name = "lblConfirmacion";
			this.lblConfirmacion.Size = new System.Drawing.Size(555, 52);
			this.lblConfirmacion.TabIndex = 0;
			this.lblConfirmacion.Text = "Confirmar dia de Salida";
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.Enabled = false;
			this.dtpEntrada.Location = new System.Drawing.Point(12, 77);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(200, 20);
			this.dtpEntrada.TabIndex = 1;
			// 
			// dtpSalida
			// 
			this.dtpSalida.Location = new System.Drawing.Point(12, 117);
			this.dtpSalida.Name = "dtpSalida";
			this.dtpSalida.Size = new System.Drawing.Size(200, 20);
			this.dtpSalida.TabIndex = 2;
			// 
			// lblEntrada
			// 
			this.lblEntrada.Location = new System.Drawing.Point(12, 60);
			this.lblEntrada.Name = "lblEntrada";
			this.lblEntrada.Size = new System.Drawing.Size(100, 14);
			this.lblEntrada.TabIndex = 3;
			this.lblEntrada.Text = "Dia de entrada";
			// 
			// lblSalida
			// 
			this.lblSalida.Location = new System.Drawing.Point(12, 100);
			this.lblSalida.Name = "lblSalida";
			this.lblSalida.Size = new System.Drawing.Size(100, 14);
			this.lblSalida.TabIndex = 4;
			this.lblSalida.Text = "Dia de Salida";
			// 
			// lblPrecio
			// 
			this.lblPrecio.Location = new System.Drawing.Point(12, 143);
			this.lblPrecio.Name = "lblPrecio";
			this.lblPrecio.Size = new System.Drawing.Size(100, 20);
			this.lblPrecio.TabIndex = 5;
			this.lblPrecio.Text = "Precio habitación:";
			// 
			// btnCalculadar
			// 
			this.btnCalculadar.Location = new System.Drawing.Point(12, 191);
			this.btnCalculadar.Name = "btnCalculadar";
			this.btnCalculadar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCalculadar.Size = new System.Drawing.Size(80, 69);
			this.btnCalculadar.TabIndex = 7;
			this.btnCalculadar.Text = "Total a pagar";
			this.btnCalculadar.UseVisualStyleBackColor = true;
			this.btnCalculadar.Click += new System.EventHandler(this.BtnCalculadarClick);
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(288, 69);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(48, 13);
			this.lblNombre.TabIndex = 8;
			this.lblNombre.Text = "Nombre: ";
			// 
			// lblApellidos
			// 
			this.lblApellidos.Location = new System.Drawing.Point(429, 66);
			this.lblApellidos.Name = "lblApellidos";
			this.lblApellidos.Size = new System.Drawing.Size(52, 16);
			this.lblApellidos.TabIndex = 9;
			this.lblApellidos.Text = "Apellidos: ";
			// 
			// lblDni
			// 
			this.lblDni.Location = new System.Drawing.Point(288, 100);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(48, 14);
			this.lblDni.TabIndex = 11;
			this.lblDni.Text = "DNI: ";
			// 
			// lblNumero
			// 
			this.lblNumero.Location = new System.Drawing.Point(429, 100);
			this.lblNumero.Name = "lblNumero";
			this.lblNumero.Size = new System.Drawing.Size(79, 14);
			this.lblNumero.TabIndex = 12;
			this.lblNumero.Text = "Habitación Nº: ";
			// 
			// lvExtras
			// 
			this.lvExtras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnHeader1});
			this.lvExtras.Location = new System.Drawing.Point(288, 138);
			this.lvExtras.Name = "lvExtras";
			this.lvExtras.Size = new System.Drawing.Size(279, 122);
			this.lvExtras.TabIndex = 13;
			this.lvExtras.UseCompatibleStateImageBehavior = false;
			this.lvExtras.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Extras";
			this.columnHeader1.Width = 273;
			// 
			// lblTotal
			// 
			this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotal.Location = new System.Drawing.Point(12, 303);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(125, 41);
			this.lblTotal.TabIndex = 14;
			this.lblTotal.Text = "Total:";
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Location = new System.Drawing.Point(184, 191);
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Size = new System.Drawing.Size(80, 69);
			this.btnConfirmar.TabIndex = 15;
			this.btnConfirmar.Text = "Comfirmar Salida";
			this.btnConfirmar.UseVisualStyleBackColor = true;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmarClick);
			// 
			// lblTotalAPagar
			// 
			this.lblTotalAPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTotalAPagar.Location = new System.Drawing.Point(148, 302);
			this.lblTotalAPagar.Name = "lblTotalAPagar";
			this.lblTotalAPagar.Size = new System.Drawing.Size(419, 40);
			this.lblTotalAPagar.TabIndex = 16;
			this.lblTotalAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblPrecioPorExtra
			// 
			this.lblPrecioPorExtra.Location = new System.Drawing.Point(12, 163);
			this.lblPrecioPorExtra.Name = "lblPrecioPorExtra";
			this.lblPrecioPorExtra.Size = new System.Drawing.Size(100, 25);
			this.lblPrecioPorExtra.TabIndex = 17;
			this.lblPrecioPorExtra.Text = "Precio por extra:";
			// 
			// lblPrecioHabitacion
			// 
			this.lblPrecioHabitacion.Location = new System.Drawing.Point(119, 143);
			this.lblPrecioHabitacion.Name = "lblPrecioHabitacion";
			this.lblPrecioHabitacion.Size = new System.Drawing.Size(163, 20);
			this.lblPrecioHabitacion.TabIndex = 18;
			// 
			// lblPrecioExtra
			// 
			this.lblPrecioExtra.Location = new System.Drawing.Point(119, 163);
			this.lblPrecioExtra.Name = "lblPrecioExtra";
			this.lblPrecioExtra.Size = new System.Drawing.Size(163, 25);
			this.lblPrecioExtra.TabIndex = 19;
			// 
			// lblFactura
			// 
			this.lblFactura.Location = new System.Drawing.Point(98, 191);
			this.lblFactura.Name = "lblFactura";
			this.lblFactura.Size = new System.Drawing.Size(80, 69);
			this.lblFactura.TabIndex = 20;
			this.lblFactura.Text = "Generar factura HTML";
			this.lblFactura.UseVisualStyleBackColor = true;
			this.lblFactura.Click += new System.EventHandler(this.LblFacturaClick);
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(343, 69);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(80, 13);
			this.Nombre.TabIndex = 21;
			// 
			// Apellido
			// 
			this.Apellido.Location = new System.Drawing.Point(487, 66);
			this.Apellido.Name = "Apellido";
			this.Apellido.Size = new System.Drawing.Size(91, 16);
			this.Apellido.TabIndex = 22;
			// 
			// NumeroHabitacion
			// 
			this.NumeroHabitacion.Location = new System.Drawing.Point(514, 100);
			this.NumeroHabitacion.Name = "NumeroHabitacion";
			this.NumeroHabitacion.Size = new System.Drawing.Size(64, 14);
			this.NumeroHabitacion.TabIndex = 23;
			// 
			// Dni
			// 
			this.Dni.Location = new System.Drawing.Point(343, 100);
			this.Dni.Name = "Dni";
			this.Dni.Size = new System.Drawing.Size(80, 14);
			this.Dni.TabIndex = 24;
			// 
			// frmSalidaUsuario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(581, 353);
			this.Controls.Add(this.Dni);
			this.Controls.Add(this.NumeroHabitacion);
			this.Controls.Add(this.Apellido);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.lblFactura);
			this.Controls.Add(this.lblPrecioExtra);
			this.Controls.Add(this.lblPrecioHabitacion);
			this.Controls.Add(this.lblPrecioPorExtra);
			this.Controls.Add(this.lblTotalAPagar);
			this.Controls.Add(this.btnConfirmar);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.lvExtras);
			this.Controls.Add(this.lblNumero);
			this.Controls.Add(this.lblDni);
			this.Controls.Add(this.lblApellidos);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.btnCalculadar);
			this.Controls.Add(this.lblPrecio);
			this.Controls.Add(this.lblSalida);
			this.Controls.Add(this.lblEntrada);
			this.Controls.Add(this.dtpSalida);
			this.Controls.Add(this.dtpEntrada);
			this.Controls.Add(this.lblConfirmacion);
			this.Name = "frmSalidaUsuario";
			this.Text = "frmSalidaUsuario";
			this.Load += new System.EventHandler(this.FrmSalidaUsuarioLoad);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView lvExtras;
		private System.Windows.Forms.Label lblNumero;
		private System.Windows.Forms.Label lblDni;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.Button btnCalculadar;
		private System.Windows.Forms.Label lblPrecio;
		private System.Windows.Forms.Label lblSalida;
		private System.Windows.Forms.Label lblEntrada;
		private System.Windows.Forms.DateTimePicker dtpSalida;
		private System.Windows.Forms.DateTimePicker dtpEntrada;
		private System.Windows.Forms.Label lblConfirmacion;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Label lblTotalAPagar;
		private System.Windows.Forms.Label lblPrecioPorExtra;
		private System.Windows.Forms.Label lblApellidos;
		private System.Windows.Forms.Label lblPrecioHabitacion;
		private System.Windows.Forms.Label lblPrecioExtra;
		private System.Windows.Forms.Button lblFactura;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Label Nombre;
		private System.Windows.Forms.Label Apellido;
		private System.Windows.Forms.Label NumeroHabitacion;
		private System.Windows.Forms.Label Dni;
	}
}
