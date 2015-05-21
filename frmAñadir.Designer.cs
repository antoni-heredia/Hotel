/*
 * Creado por SharpDevelop.
 * Usuario: antoniojesus
 * Fecha: 06/05/2015
 * Hora: 20:12
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace Hotel
{
	partial class frmAñadir
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAñadir));
			this.lbDni = new System.Windows.Forms.Label();
			this.txtDni = new System.Windows.Forms.TextBox();
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblApellido = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtApellido = new System.Windows.Forms.TextBox();
			this.lblHabitacion = new System.Windows.Forms.Label();
			this.lblNum = new System.Windows.Forms.Label();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lbDni
			// 
			this.lbDni.BackColor = System.Drawing.Color.Transparent;
			this.lbDni.Location = new System.Drawing.Point(12, 44);
			this.lbDni.Name = "lbDni";
			this.lbDni.Size = new System.Drawing.Size(61, 17);
			this.lbDni.TabIndex = 0;
			this.lbDni.Text = "DNI: ";
			// 
			// txtDni
			// 
			this.txtDni.Location = new System.Drawing.Point(118, 41);
			this.txtDni.Name = "txtDni";
			this.txtDni.Size = new System.Drawing.Size(133, 20);
			this.txtDni.TabIndex = 1;
			// 
			// lblNombre
			// 
			this.lblNombre.BackColor = System.Drawing.Color.Transparent;
			this.lblNombre.Location = new System.Drawing.Point(13, 71);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(61, 17);
			this.lblNombre.TabIndex = 2;
			this.lblNombre.Text = "Nombre: ";
			// 
			// lblApellido
			// 
			this.lblApellido.BackColor = System.Drawing.Color.Transparent;
			this.lblApellido.Location = new System.Drawing.Point(12, 98);
			this.lblApellido.Name = "lblApellido";
			this.lblApellido.Size = new System.Drawing.Size(100, 17);
			this.lblApellido.TabIndex = 3;
			this.lblApellido.Text = "Apellido: ";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(118, 68);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(133, 20);
			this.txtNombre.TabIndex = 5;
			// 
			// txtApellido
			// 
			this.txtApellido.Location = new System.Drawing.Point(118, 95);
			this.txtApellido.Name = "txtApellido";
			this.txtApellido.Size = new System.Drawing.Size(133, 20);
			this.txtApellido.TabIndex = 6;
			// 
			// lblHabitacion
			// 
			this.lblHabitacion.BackColor = System.Drawing.Color.Transparent;
			this.lblHabitacion.Location = new System.Drawing.Point(13, 24);
			this.lblHabitacion.Name = "lblHabitacion";
			this.lblHabitacion.Size = new System.Drawing.Size(100, 14);
			this.lblHabitacion.TabIndex = 7;
			this.lblHabitacion.Text = "Habitación: ";
			// 
			// lblNum
			// 
			this.lblNum.BackColor = System.Drawing.Color.Transparent;
			this.lblNum.Location = new System.Drawing.Point(118, 24);
			this.lblNum.Name = "lblNum";
			this.lblNum.Size = new System.Drawing.Size(100, 13);
			this.lblNum.TabIndex = 8;
			this.lblNum.Click += new System.EventHandler(this.LblNumClick);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.BackgroundImage")));
			this.btnGuardar.Location = new System.Drawing.Point(138, 159);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(80, 69);
			this.btnGuardar.TabIndex = 9;
			this.btnGuardar.Text = "Guardar";
			this.btnGuardar.UseVisualStyleBackColor = true;
			this.btnGuardar.Click += new System.EventHandler(this.BtnGuardarClick);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "dd MM yyyy";
			this.dateTimePicker1.Location = new System.Drawing.Point(119, 118);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Location = new System.Drawing.Point(13, 124);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 14);
			this.label1.TabIndex = 11;
			this.label1.Text = "Fecha Entrada";
			// 
			// frmAñadir
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(354, 251);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.lblNum);
			this.Controls.Add(this.lblHabitacion);
			this.Controls.Add(this.txtApellido);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.lblApellido);
			this.Controls.Add(this.lblNombre);
			this.Controls.Add(this.txtDni);
			this.Controls.Add(this.lbDni);
			this.Name = "frmAñadir";
			this.Text = "frmAñadir";
			this.Load += new System.EventHandler(this.FrmAñadirLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Label lblNum;
		private System.Windows.Forms.Label lblHabitacion;
		private System.Windows.Forms.TextBox txtApellido;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label lblApellido;
		private System.Windows.Forms.Label lblNombre;
		private System.Windows.Forms.TextBox txtDni;
		private System.Windows.Forms.Label lbDni;
		private System.Windows.Forms.Label label1;
	}
}
