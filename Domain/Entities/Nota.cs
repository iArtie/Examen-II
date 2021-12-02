using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Nota
    {
        public Estudiante Estudiante { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
        public int Sistematico { get; set; }
        public int PrimerParcial { get; set; }
        public int SegundoParcial { get; set; }
        public int Tarea { get; set; }
        public int NotaFinal => Sistematico + PrimerParcial + SegundoParcial + Tarea;
        public Asignatura Asig { get; set; }
}
}
