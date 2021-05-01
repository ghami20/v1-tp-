using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Proveedor
    {

        private Direccion _direccion;
        private string _razonSocial;
        private string _dni;

        public string DNI
        {
            get { return _dni; }
            set { _dni = value; }
        }


        public Direccion Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }

        

        public string MyProperty
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

    }
}
