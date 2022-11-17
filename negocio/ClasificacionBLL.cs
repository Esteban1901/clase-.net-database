using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datos;
namespace BLL
{

    public class TareasBLL {
        TareasPendientesEntities Bd = new TareasPendientesEntities();

        public void Add(string Titulo, string Detalle, DateTime FechaVencimiento)
        {
            Tarea nuevas = new Tarea();
            nuevas.Titulo = Titulo;
            nuevas.Detalle = Detalle;
            nuevas.FechaVencimiento = FechaVencimiento;

            Bd.Tarea.Add(nuevas);
            Bd.SaveChanges();
        }
        public List<Tarea> GetAll()
        {
            return Bd.Tarea.ToList();
        }
    }
    public class ClasificacionBLL
    {
        TareasPendientesEntities bd = new TareasPendientesEntities();

        public void Add(string nombre)
        {
            Clasificacion nueva = new Clasificacion();
            nueva.Nombre = nombre;

            bd.Clasificacion.Add(nueva);
            bd.SaveChanges();
        }

        public List<Clasificacion> GetAll()
        {
            return bd.Clasificacion.ToList();
        }
    }
}
