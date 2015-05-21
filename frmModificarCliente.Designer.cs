/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 19/05/2015
 * Hora: 14:28
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmModificarCliente
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label lbNombre;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblApellidos;
		private System.Windows.Forms.TextBox txtApellidos;
		private System.Windows.Forms.Label lblDni;
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker dtpEntrada;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblNumeroHabitacion;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarCliente));
			this.lbNombre = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.lblApellidos = new System.Windows.Forms.Label();
			this.txtApellidos = new System.Windows.Forms.TextBox();
			this.lblDni = new System.Windows.Forms.Label();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpEntrada = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lblNumeroHabitacion = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbNombre
			// 
			this.lbNombre.BackColor = System.Drawing.Color.Transparent;
			this.lbNombre.Location = new System.Drawing.Point(13, 13);
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Size = new System.Drawing.Size(56, 17);
			this.lbNombre.TabIndex = 0;
			this.lbNombre.Text = "Nombre: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(118, 10);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 1;
			// 
			// lblApellidos
			// 
			this.lblApellidos.BackColor = System.Drawing.Color.Transparent;
			this.lblApellidos.Location = new System.Drawing.Point(13, 39);
			this.lblApellidos.Name = "lblApellidos";
			this.lblApellidos.Size = new System.Drawing.Size(56, 17);
			this.lblApellidos.TabIndex = 2;
			this.lblApellidos.Text = "Apellidos: ";
			// 
			// txtApellidos
			// 
			this.txtApellidos.Location = new System.Drawing.Point(118, 36);
			this.txtApellidos.Name = "txtApellidos";
			this.txtApellidos.Size = new System.Drawing.Size(100, 20);
			this.txtApellidos.TabIndex = 3;
			// 
			// lblDni
			// 
			this.lblDni.BackColor = System.Drawing.Color.Transparent;
			this.lblDni.Location = new System.Drawing.Point(12, 68);
			this.lblDni.Name = "lblDni";
			this.lblDni.Size = new System.Drawing.Size(56, 14);
			this.lblDni.TabIndex = 4;
			this.lblDni.Text = "Dni: ";
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(118, 62);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(100, 20);
			this.txtDni.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(12, 92);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Fecha entrada:";
			// 
			// dtpEntrada
			// 
			this.dtpEntrada.Location = new System.Drawing.Point(118, 88);
			this.dtpEntrada.Name = "dtpEntrada";
			this.dtpEntrada.Size = new System.Drawing.Size(200, 20);
			this.dtpEntrada.TabIndex = 7;
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Location = new System.Drawing.Point(12, 119);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 69);
			this.button1.TabIndex = 8;
			this.button1.Text = "Modificar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Location = new System.Drawing.Point(246, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 17);
			this.label2.TabIndex = 9;
			this.label2.Text = "Numero Habitacion:";
			// 
			// lblNumeroHabitacion
			// 
			this.lblNumeroHabitacion.BackColor = System.Drawing.Color.Transparent;
			this.lblNumeroHabitacion.Location = new System.Drawing.Point(356, 13);
			this.lblNumeroHabitacion.Name = "lblNumeroHabitacion";
			this.lblNumeroHabitacion.Size = new System.Drawing.Size(69, 17);
			this.lblNumeroHabitacion.TabIndex = 10;
			// 
			// frmModificarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(434, 201);
			this.Controls.Add(this.lblNumeroHabitacion);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dtpEntrada);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.lblDni);
			this.Controls.Add(this.txtApellidos);
			this.Controls.Add(this.lblApellidos);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lbNombre);
			this.Name = "frmModificarCliente";
			this.Text = "frmModificarCliente";
			this.Load += new System.EventHandler(this.FrmModificarClienteLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
