using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public abstract class persona
    {
       
        
        private Direccion _direccion;
        private int _dni;
        private string _apellido;
        private string _nombre;
        public persona()
        {
            Console.Write("\n crea una persona ");
        }

        public  string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public  string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }



        public Direccion Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        public int DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }

    }
}
