using _03_Dominio.ValueObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _04_Persistencia_de_datos.POCO
{
    public class DoctorPOCO
    {

        Identificador id;
        Nombre nombre;
        Apellido apellido;
        FechaIngreso fechaIngreso;




        public DoctorPOCO(Guid id, string nombre, string apellido, DateTime fechaIngreso)
        {




            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.fechaIngreso = new FechaIngreso(fechaIngreso);

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




    }
}
