using AppCore.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FrmNotas : Form
    {
        int cambio = 0;
        public NotaRepositoryServices Services { get; set; }
        int Id = 0;

        public FrmNotas(int id)
        {
            this.Id = id;
            InitializeComponent();
        }

        private void FrmNotas_Load(object sender, EventArgs e)
        {
            Estudiante estudiante=Services.EstudianteById(Id);
            lblNombre.Text = estudiante.Nombres + " "+estudiante.Apellidos;
            
        }

        private void LblAsignatura_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Nota notas = new Nota()
            {
                PrimerParcial = Convert.ToInt16(textBox1.Text),
                SegundoParcial = Convert.ToInt16(textBox2.Text),
                Sistematico = Convert.ToInt16(textBox3.Text),
                Tarea = Convert.ToInt16(textBox4.Text),
            };
            Services.Create(notas);
            Llenowo();
            MessageBox.Show("Notas registradas");
        }
        private void Llenowo()
        {
            //    owoView.Rows.Clear();
            //    List<Nota> Estudiantes = (List<Nota>)Services.Read();
            //    for (int i = 0; i < Estudiantes.Count; i++)
            //    {
            //        owoView.Rows.Add(Notasowo[i].Estudiante.Nombres, Estudiantes[i].Estudiante.Id, Estudiantes[i].Estudiante.Apellidos, Estudiantes[i].Estudiante.Carnet, Estudiantes[i].Estudiante.Municipio, Estudiantes[i].Estudiante.Departamento);
            //    }
            List<Nota> Nota = (List<Nota>)Services.Read();
            owoView.Rows.Add(comboBox1.DataSource = Enum.GetValues(typeof(Asigowo),textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
            //for (int i = 0; i < Nota.Count; i++)
            //{
            //    owoView.Rows.Add(textBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
            //}


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
