using AppCore.Interfaces;
using AppCore.Services;
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
	public partial class Form1 : Form
	{
		public NotaRepositoryServices Services;
        List<Asignatura> asignaturas;
        Estudiante estudiante;
        int Seleccionado = 0;
        int Siguiente = 0;

		public Form1(NotaRepositoryServices services)
			
		{
            estudiante = new Estudiante();
            asignaturas = new List<Asignatura>();
			this.Services = services;
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
		
		}

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            
            estudiante = new Estudiante()
            {
                Id = Services.GetLastId() + 1,
                Nombres = txtNombre.Text,
                Apellidos = txtApellido.Text,
                Carnet = txtCArnet.Text,
                Departamento = txtDepartamento.Text,
                Municipio = txtMunicipio.Text
            };
            AgregarAsignaturas();
            Nota Notas = new Nota()
            {
                Estudiante = estudiante,
                Asignaturas = asignaturas,
                
            };
            Services.Create(Notas);
            LlenarDgv();
            Vaciar();
           
            btnSiguiente.Visible = true;
        }
        private void Vaciar()
        {
            txtApellido.Text = "Apellido";
            txtCArnet.Text = "Carnet";
            txtDepartamento.Text = "Departamento";
            txtMunicipio.Text = "Municipio";
            txtNombre.Text = "Nombre";
            
        }
        private void LlenarDgv()
        {
            dataGridView1.Rows.Clear();
            List<Nota> Estudiantes =(List<Nota>) Services.Read();
            for(int i=0; i<Estudiantes.Count; i++)
            {
                dataGridView1.Rows.Add(Estudiantes[i].Estudiante.Nombres, Estudiantes[i].Estudiante.Id, Estudiantes[i].Estudiante.Apellidos, Estudiantes[i].Estudiante.Carnet, Estudiantes[i].Estudiante.Municipio, Estudiantes[i].Estudiante.Departamento);
            }
            
        }
        private void AgregarAsignaturas()
        {
            Asignatura Contabilidad = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Contabilidad"
            };
            asignaturas.Add(Contabilidad);
            Asignatura AlgebraLineal = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "AlgebraLineal"
            };
            asignaturas.Add(AlgebraLineal);
            Asignatura Matematicas2 = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Calculo II"
            };
            asignaturas.Add(Matematicas2);
            Asignatura Ingles2 = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Ingles II"
            };
            asignaturas.Add(Ingles2);

            Asignatura Sociologia = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Sociologia"
            };
            asignaturas.Add(Sociologia);
            Asignatura Programacion1 = new Asignatura()
            {
                Id = Services.GetLastId() + 1,
                Credito = 2,
                Nombre = "Programacion I"
            };
            asignaturas.Add(Programacion1);
        }

        private void CheContabilidad_CheckedChanged(object sender, EventArgs e)
        {

        }
       

        private void TxtMunicipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCArnet_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Seleccionado = e.RowIndex;
                int id = Convert.ToInt32(dataGridView1.Rows[Seleccionado].Cells["ID"].Value);
                FrmNotas frmNotas = new FrmNotas(id);
                frmNotas.Services = Services;
                frmNotas.ShowDialog();

            }
        }

        private void TxtPrimer_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.Rows[Seleccionado].Cells["ID"].Value);
            FrmNotas frmNotas = new FrmNotas(id);
            frmNotas.Services = Services;
            frmNotas.ShowDialog();
            Siguiente++;
            //DataGridView1_CellContentClick(sender, e);
            //if (Siguiente == 6)
            //{
            //    return;
                
            //}
            //MessageBox.Show("Notas registradas");
            //Nota notas = new Nota()
            //{
            //    Estudiante = estudiante,
            //    Asignaturas = asignaturas,
            //    PrimerParcial = Convert.ToInt16(txtPrimer.Text),
            //    SegundoParcial=Convert.ToInt16(txtSegundo.Text),
            //    Sistematico=Convert.ToInt16(txtSistematico.Text),
            //};
            //Services.Create(notas);

        }

        private void DataGridView1_CellContentClick(object sender, EventArgs e)
        {
           
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
