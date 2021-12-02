using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Interfaces
{
    public class NotaListRepository : BaseRepository<Nota>, INotaRepository
    {
        public int CalcularNotas(int primer, int segundo)
        {
            throw new NotImplementedException();
        }

        public int CalcularPromedio()
        {
            decimal promedio = datos.Sum(x => x.NotaFinal);
            return Convert.ToInt32(promedio/6);
        }

        public Estudiante EstudianteById(int Id)
        {
            for(int i=0; i < datos.Count; i++)
            {
                if (Id == datos[i].Estudiante.Id)
                {
                    return datos[i].Estudiante;
                }
            }
            return null;
        }

        public ICollection<Asignatura> GetAsignaturas()
        {

            List<Asignatura> asignaturas = new List<Asignatura>();
            asignaturas =(List<Asignatura>) datos.Select(x => x.Asignaturas);
            return asignaturas;
            
        }

        public ICollection<Nota> MejoresEstudiantes()
        {
            List<Nota> MejoresNotas = new List<Nota>();
            datos.OrderBy(x => x.NotaFinal);
            for(int i=0; i<2; i++)
            {
                MejoresNotas.Add(datos[i]);
            }
            return MejoresNotas;
        }

    }
}
