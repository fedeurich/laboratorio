using _03_Dominio.ValueObject;
using System;
//using _03_Dominio.ValueObject;

namespace _03_Dominio.Entidades
{
    public class Doctor
    {

        private Identificador id;
        private Nombre nombre;
        private Apellido apellido;
        private FechaIngreso fechaIngreso;




        public Doctor(Guid id, string nombre, string apellido, DateTime fechaIngreso)
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

        //Metodos para actualizar valores

        public void ActualizarNombre(string nombre){
        
            this.nombre=new Nombre(nombre);
        }

        public void ActualizarApellido(string apellido) { 
            
            this.apellido=new Apellido(apellido);
        }

        public void ActualizarFechaIngreso(DateTime fecha) { 
        
            this.fechaIngreso=new FechaIngreso(fecha);
        }


    }
}
