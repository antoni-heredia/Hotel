/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 04/05/2015
 * Hora: 17:56
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btNuevaHabitacion = new System.Windows.Forms.Button();
			this.btOcupadas = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// btNuevaHabitacion
			// 
			this.btNuevaHabitacion.Location = new System.Drawing.Point(683, 12);
			this.btNuevaHabitacion.Name = "btNuevaHabitacion";
			this.btNuevaHabitacion.Size = new System.Drawing.Size(89, 69);
			this.btNuevaHabitacion.TabIndex = 0;
			this.btNuevaHabitacion.Text = "Administración de Habitaciónes";
			this.btNuevaHabitacion.UseVisualStyleBackColor = true;
			this.btNuevaHabitacion.Click += new System.EventHandler(this.BtNuevaHabitacionClick);
			// 
			// btOcupadas
			// 
			this.btOcupadas.Location = new System.Drawing.Point(360, 280);
			this.btOcupadas.Name = "btOcupadas";
			this.btOcupadas.Size = new System.Drawing.Size(80, 69);
			this.btOcupadas.TabIndex = 1;
			this.btOcupadas.Text = "Habitaciones";
			this.btOcupadas.UseVisualStyleBackColor = true;
			this.btOcupadas.Click += new System.EventHandler(this.BtOcupadasClick);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(784, 361);
			this.Controls.Add(this.btOcupadas);
			this.Controls.Add(this.btNuevaHabitacion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Hotel";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btOcupadas;
		private System.Windows.Forms.Button btNuevaHabitacion;
	}
}
