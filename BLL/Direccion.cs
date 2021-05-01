using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Direccion
    {
        private string _altura;
        private string _calle;
        private string _codigoPostal;
        private string _localidad;
        private string _provincia;

        public Direccion()
        {

        }
        public string Altura
        {
            get { return this._altura; }
        }

        public string Calle
        {
            get { return this._calle; }
        }

        public string CodigoPostal
        {
            get { return this._codigoPostal; }
        }
        public string Localidad
        {
            get { return this._localidad; }
        }

        public string Provincia
        {
            get { return this._provincia; }     
        }
    }




}
