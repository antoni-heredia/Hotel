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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdministracionHabitaciones));
			this.btnAñadir = new System.Windows.Forms.Button();
			this.lblEliminar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnAñadir
			// 
			this.btnAñadir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAñadir.BackgroundImage")));
			this.btnAñadir.Location = new System.Drawing.Point(78, 20);
			this.btnAñadir.Name = "btnAñadir";
			this.btnAñadir.Size = new System.Drawing.Size(80, 69);
			this.btnAñadir.TabIndex = 0;
			this.btnAñadir.Text = "Añadir Habitación";
			this.btnAñadir.UseVisualStyleBackColor = true;
			this.btnAñadir.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblEliminar
			// 
			this.lblEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lblEliminar.BackgroundImage")));
			this.lblEliminar.Location = new System.Drawing.Point(247, 20);
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
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(384, 101);
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
