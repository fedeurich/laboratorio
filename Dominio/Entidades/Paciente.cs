using _03_Dominio.ValueObject;

namespace _03_Dominio.Entidades
{
    public class Paciente
    {
       private Identificador id;
       private Nombre nombre;
       private Apellido apellido;
       private FechaNacimiento fechaNacimiento;

        public Paciente(Guid id, string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.id = new Identificador(id);
            this.nombre = new Nombre(nombre);
            this.apellido = new Apellido(apellido);
            this.fechaNacimiento = new FechaNacimiento(fechaNacimiento);

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

    }
}

}
