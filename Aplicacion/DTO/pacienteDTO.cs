using _03_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Aplicacion.DTOs
{
    public class PacienteDTO
    {
        private   Identificador id;
        private Nombre nombre;
        private Apellido apellido;
        private FechaNacimiento fechaNacimiento;

        public PacienteDTO(Guid id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido =new  Apellido(apellido);
            this.fechaNacimiento = new FechaNacimiento(fechaNacimiento);

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

        public DateTime FechaNacimiento()
        {
            return this.fechaNacimiento.GetValor();
        }

    }
}

}
