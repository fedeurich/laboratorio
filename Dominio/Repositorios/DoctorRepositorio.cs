using _03_Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.Repositorios
{
    public interface DoctorRepositorio
    {
        public List<Doctor> listar();


        public void editar(Doctor doctor,Guid id);

        public void eliminar(Guid id,Doctor doctor);
        public void grabar(Doctor doctor);
    }
}
