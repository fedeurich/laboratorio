using _03_Dominio.ValueObject;
using System;


namespace _03_Dominio.Entidades
{
    public class Doctor
    {

        private Identificador id;
        private Nombre nombre;
        private Apellido apellido;
        private FechaIngreso fechaIngreso;
        private Estado estado; // Nuevo campo para marcar si el doctor está eliminado




        public Doctor(Guid id, string nombre, string apellido, DateTime fechaIngreso, string estado)
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

        //Ejemplo
        public void ActualizarEstado(Estado nuevoEstado)
        {
            // Aquí podrías agregar validaciones si necesitas asegurar que el estado sea válido
            this.estado = nuevoEstado;
        }

        // Métodos adicionales para actualizar valores, etc.

        // Método para marcar el doctor como inactivo
        public void Borrar()
        {
            this.estado = new Estado("inactivo");
        }
    }


}
}
