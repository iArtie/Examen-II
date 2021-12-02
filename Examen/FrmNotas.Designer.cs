namespace Examen
{
    partial class FrmNotas
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblAsignatura = new System.Windows.Forms.Label();
            this.owoView = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ColumnAsn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnsis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1o = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.owoView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(37, 164);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(195, 20);
            this.textBox2.TabIndex = 1;
            // 
            // lblAsignatura
            // 
            this.lblAsignatura.AutoSize = true;
            this.lblAsignatura.Location = new System.Drawing.Point(34, 100);
            this.lblAsignatura.Name = "lblAsignatura";
            this.lblAsignatura.Size = new System.Drawing.Size(0, 13);
            this.lblAsignatura.TabIndex = 2;
            this.lblAsignatura.Click += new System.EventHandler(this.LblAsignatura_Click);
            // 
            // owoView
            // 
            this.owoView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.owoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.owoView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAsn,
            this.Columnsis,
            this.ColumnPP,
            this.ColumnSP,
            this.ColumnT,
            this.Column1o});
            this.owoView.Location = new System.Drawing.Point(355, 65);
            this.owoView.Name = "owoView";
            this.owoView.Size = new System.Drawing.Size(536, 333);
            this.owoView.TabIndex = 3;
            this.owoView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(58, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Contabilidad De Costo",
            "Sociologia",
            "Calculo II",
            "Ingles II",
            "Algebra Lineal",
            "Programacion I"});
            this.comboBox1.Location = new System.Drawing.Point(111, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 211);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(195, 20);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(37, 250);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 20);
            this.textBox4.TabIndex = 9;
            // 
            // ColumnAsn
            // 
            this.ColumnAsn.HeaderText = "Asignatura";
            this.ColumnAsn.Name = "ColumnAsn";
            // 
            // Columnsis
            // 
            this.Columnsis.HeaderText = "Sistematico";
            this.Columnsis.Name = "Columnsis";
            // 
            // ColumnPP
            // 
            this.ColumnPP.HeaderText = "Primer parcial";
            this.ColumnPP.Name = "ColumnPP";
            // 
            // ColumnSP
            // 
            this.ColumnSP.HeaderText = "Segundo parcial";
            this.ColumnSP.Name = "ColumnSP";
            // 
            // ColumnT
            // 
            this.ColumnT.HeaderText = "Tarea";
            this.ColumnT.Name = "ColumnT";
            // 
            // Column1o
            // 
            this.Column1o.HeaderText = "Nota final";
            this.Column1o.Name = "Column1o";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Asignatura:";
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 450);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.owoView);
            this.Controls.Add(this.lblAsignatura);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmNotas";
            this.Text = "FrmNotas";
            this.Load += new System.EventHandler(this.FrmNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.owoView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblAsignatura;
        private System.Windows.Forms.DataGridView owoView;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAsn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1o;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
    }
}