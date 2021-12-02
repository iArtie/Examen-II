
namespace Examen
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCArnet = new System.Windows.Forms.TextBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Carnet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNombre.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtNombre.Location = new System.Drawing.Point(12, 109);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(156, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtApellido.Location = new System.Drawing.Point(12, 135);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(156, 20);
            this.txtApellido.TabIndex = 1;
            this.txtApellido.Text = "Apellido";
            // 
            // txtCArnet
            // 
            this.txtCArnet.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCArnet.Location = new System.Drawing.Point(12, 161);
            this.txtCArnet.Name = "txtCArnet";
            this.txtCArnet.Size = new System.Drawing.Size(156, 20);
            this.txtCArnet.TabIndex = 2;
            this.txtCArnet.Text = "Carnet";
            this.txtCArnet.TextChanged += new System.EventHandler(this.TxtCArnet_TextChanged);
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtMunicipio.Location = new System.Drawing.Point(12, 187);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(156, 20);
            this.txtMunicipio.TabIndex = 3;
            this.txtMunicipio.Text = "Municipio";
            this.txtMunicipio.TextChanged += new System.EventHandler(this.TxtMunicipio_TextChanged);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtDepartamento.Location = new System.Drawing.Point(12, 213);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(156, 20);
            this.txtDepartamento.TabIndex = 4;
            this.txtDepartamento.Text = "Departamento";
            this.txtDepartamento.TextChanged += new System.EventHandler(this.TxtDepartamento_TextChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnviar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnEnviar.Location = new System.Drawing.Point(698, 400);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ID,
            this.Apellidos,
            this.Carnet,
            this.Municipio,
            this.Departamento});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(212, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 285);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Carnet
            // 
            this.Carnet.HeaderText = "Carnet";
            this.Carnet.Name = "Carnet";
            // 
            // Municipio
            // 
            this.Municipio.HeaderText = "Municipio";
            this.Municipio.Name = "Municipio";
            // 
            // Departamento
            // 
            this.Departamento.HeaderText = "Departamento";
            this.Departamento.Name = "Departamento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(485, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccionar un estudiante";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSiguiente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSiguiente.Location = new System.Drawing.Point(779, 400);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 17;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Visible = false;
            this.btnSiguiente.Click += new System.EventHandler(this.BtnSiguiente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 429);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.txtCArnet);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCArnet;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Carnet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSiguiente;
    }
}

