/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 05/05/2015
 * Hora: 9:50
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmAdministracionHabitaciones
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
			this.btnAñadir = new System.Windows.Forms.Button();
			this.lblEliminar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAñadir
			// 
			this.btnAñadir.Location = new System.Drawing.Point(72, 12);
			this.btnAñadir.Name = "btnAñadir";
			this.btnAñadir.Size = new System.Drawing.Size(80, 69);
			this.btnAñadir.TabIndex = 0;
			this.btnAñadir.Text = "Añadir Habitación";
			this.btnAñadir.UseVisualStyleBackColor = true;
			this.btnAñadir.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblEliminar
			// 
			this.lblEliminar.Location = new System.Drawing.Point(236, 12);
			this.lblEliminar.Name = "lblEliminar";
			this.lblEliminar.Size = new System.Drawing.Size(80, 69);
			this.lblEliminar.TabIndex = 1;
			this.lblEliminar.Text = "Eliminar Habitacion";
			this.lblEliminar.UseVisualStyleBackColor = true;
			this.lblEliminar.Click += new System.EventHandler(this.LblEliminarClick);
			// 
			// frmAdministracionHabitaciones
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 93);
			this.Controls.Add(this.lblEliminar);
			this.Controls.Add(this.btnAñadir);
			this.Name = "frmAdministracionHabitaciones";
			this.Text = "Administracion de Habitaciones";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button lblEliminar;
		private System.Windows.Forms.Button btnAñadir;
	}
}
