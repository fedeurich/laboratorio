using _03_Dominio.ValueObject;

namespace _03_Dominio.Entidades
{
    public class Paciente
    {
       private Identificador id;
       private Nombre nombre;
       private Apellido apellido;
       private FechaNacimiento fechaNacimiento;
       private Estado estado; // Nuevo campo para marcar si el doctor está eliminado

        public Paciente(Guid id, string nombre, string apellido, DateTime fechaNacimiento, string estado)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.fechaNacimiento = new FechaNacimiento(fechaNacimiento);
            this.estado = new Estado(estado);

        }
        public Guid IdP()
        {
            return this.id.GetValor();
        }
        public string Nombre()
        {
            return this.nombre.GetValor();
        }
        public string Apellido ()
        {
            return this.apellido.GetValor();
        }

        public DateTime FechaNacimiento()
        {
            return this.fechaNacimiento.GetValor();
        }
        public Estado GetEstado()
        {
            return this.estado;
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
