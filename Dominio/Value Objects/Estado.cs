using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Dominio.ValueObject
{
    public class Estado
    {
        private  string estado;

        public Estado(string estado)
        {
            
            if (estado != "activo" && estado != "inactivo")
            {
                throw new ArgumentException("Estado no válido para Doctor.");
            }

            this.estado = estado;
        }

        public string GetEstado()
        {
            return estado;
        }


    }
}