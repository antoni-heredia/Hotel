/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 07/05/2015
 * Hora: 20:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmEliminarHabitacion
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button lblEliminar;
		
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.lblEliminar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(12, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(295, 236);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// lblEliminar
			// 
			this.lblEliminar.Location = new System.Drawing.Point(312, 94);
			this.lblEliminar.Name = "lblEliminar";
			this.lblEliminar.Size = new System.Drawing.Size(80, 69);
			this.lblEliminar.TabIndex = 1;
			this.lblEliminar.Text = "Eliminar";
			this.lblEliminar.UseVisualStyleBackColor = true;
			this.lblEliminar.Click += new System.EventHandler(this.LblEliminarClick);
			// 
			// frmEliminarHabitacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 261);
			this.Controls.Add(this.lblEliminar);
			this.Controls.Add(this.listView1);
			this.Name = "frmEliminarHabitacion";
			this.Text = "frmEliminarHabitacion";
			this.Load += new System.EventHandler(this.FrmEliminarHabitacionLoad);
			this.ResumeLayout(false);

		}
	}
}
