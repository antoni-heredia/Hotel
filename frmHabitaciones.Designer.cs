/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 05/05/2015
 * Hora: 10:02
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmHabitaciones
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
			this.lvHabitaciones = new System.Windows.Forms.ListView();
			this.btnDatos = new System.Windows.Forms.Button();
			this.lblAñadir = new System.Windows.Forms.Button();
			this.lblSalida = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvHabitaciones
			// 
			this.lvHabitaciones.Location = new System.Drawing.Point(12, 12);
			this.lvHabitaciones.Name = "lvHabitaciones";
			this.lvHabitaciones.Size = new System.Drawing.Size(260, 237);
			this.lvHabitaciones.TabIndex = 0;
			this.lvHabitaciones.UseCompatibleStateImageBehavior = false;
			this.lvHabitaciones.View = System.Windows.Forms.View.Details;
			// 
			// btnDatos
			// 
			this.btnDatos.Location = new System.Drawing.Point(278, 18);
			this.btnDatos.Name = "btnDatos";
			this.btnDatos.Size = new System.Drawing.Size(80, 69);
			this.btnDatos.TabIndex = 1;
			this.btnDatos.Text = "Datos";
			this.btnDatos.UseVisualStyleBackColor = true;
			this.btnDatos.Click += new System.EventHandler(this.BtnDatosClick);
			// 
			// lblAñadir
			// 
			this.lblAñadir.Location = new System.Drawing.Point(278, 93);
			this.lblAñadir.Name = "lblAñadir";
			this.lblAñadir.Size = new System.Drawing.Size(80, 69);
			this.lblAñadir.TabIndex = 2;
			this.lblAñadir.Text = "Añadir Cliente";
			this.lblAñadir.UseVisualStyleBackColor = true;
			this.lblAñadir.Click += new System.EventHandler(this.LblAñadirClick);
			// 
			// lblSalida
			// 
			this.lblSalida.Location = new System.Drawing.Point(278, 168);
			this.lblSalida.Name = "lblSalida";
			this.lblSalida.Size = new System.Drawing.Size(80, 69);
			this.lblSalida.TabIndex = 3;
			this.lblSalida.Text = "Salida de cliente";
			this.lblSalida.UseVisualStyleBackColor = true;
			this.lblSalida.Click += new System.EventHandler(this.LblSalidaClick);
			// 
			// frmHabitaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 261);
			this.Controls.Add(this.lblSalida);
			this.Controls.Add(this.lblAñadir);
			this.Controls.Add(this.btnDatos);
			this.Controls.Add(this.lvHabitaciones);
			this.Name = "frmHabitaciones";
			this.Text = "Habitaciones";
			this.Load += new System.EventHandler(this.FrmHabitacionesLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button lblSalida;
		private System.Windows.Forms.Button lblAñadir;
		private System.Windows.Forms.Button btnDatos;
		private System.Windows.Forms.ListView lvHabitaciones;
	}
}
