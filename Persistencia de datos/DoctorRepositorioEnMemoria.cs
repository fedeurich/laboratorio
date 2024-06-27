using _03_Dominio.Entidades;
using _03_Dominio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Persistencia_de_datos
{
    public class DcotorRepositorioEnMemoria
    {

        public class UsuarioRepositorioEnMemoria : DoctorRepositorio
        {
            private List<Doctor> doctores = new List<Doctor>();

            public List<Doctor> listar()
            {
                return this.doctores;
            }
            public void grabar(Doctor doctor)
            {
                this.doctores.Add(doctor);
            }



            public void editar(Doctor doctor,Guid id)
            {
                int posicionObjeto = 0;
                for (int i = 0; i < doctores.Count; i++)
                {
                    if (doctores[i].Id().Equals(id))
                    {
                        posicionObjeto = i;
                    }
                }


                //modificar para que tome datos por consola
                string nombre = "";
                string apellido = "";
                DateTime fechaIngreso = DateTime.Now;

                doctores[posicionObjeto].ActualizarNombre(nombre);
                doctores[posicionObjeto].ActualizarApellido(apellido);
                doctores[posicionObjeto].ActualizarFechaIngreso(fechaIngreso);


            }

            public void eliminar(Guid id, Doctor d)
            {
                int posicionObjeto=0;
                for(int i=0;i<doctores.Count;i++) {
                    if (doctores[i].Id().Equals(id))
                    {
                        posicionObjeto = i;
                    }
                }
                
                doctores.RemoveAt(posicionObjeto);
            
           
            
            }


        }
    }

}
