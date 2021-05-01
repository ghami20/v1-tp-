using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Orden_compra : Orden
    {
        private DateTime _fechaAprobacion;
        private Proveedor _proveedor;
        private Usuario _usuarioAprovador;


        public bool EstaAprobada(Usuario UsuarioAprovador)///el gerente deberia habilitar la orden de compra 
        {
            return true; 
        }
        public DateTime FechaAprobacion
        {
            get { return this._fechaAprobacion; }
        }
        public Proveedor Proveedor
        {
            get { return this._proveedor; }
        } 

        public Usuario UsuarioAprobador
        {
            get { return this._usuarioAprovador;  }
        }
    }
}
