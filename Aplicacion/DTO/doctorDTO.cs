using _03_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _02_Aplicacion.DTOs
{
    public class DoctorDTO
    {

      private  Identificador id;
      private Nombre nombre;
      private  Apellido apellido;
      private  FechaIngreso fechaIngreso;
        private Estado estado;




        public DoctorDTO(Guid id, string nombre, string apellido, DateTime fechaIngreso, string estado)
        {




            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.fechaIngreso = new FechaIngreso(fechaIngreso);
            this.estado = new Estado(estado);

        }






        public Guid Id()
        {
            return this.id.GetValor();
        }
        public string Nombre()
        {
            return this.nombre.GetValor();
        }
        public string Apellido()
        {
            return this.apellido.GetValor();
        }

        public DateTime FechaIngreso()
        {
            return this.fechaIngreso.GetValor();

        }
        public Estado GetEstado()
        {
            return this.estado;
        }
        public void ActualizarEstado(Estado nuevoEstado)
        {
            this.estado = nuevoEstado;
        }







    }
}