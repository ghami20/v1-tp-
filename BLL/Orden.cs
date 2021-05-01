using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    
    public abstract class Orden
    {
        private HashSet<Detalle_orden> _detalle = new HashSet<Detalle_orden>();
        private DateTime _fecha;
        private Usuario _usuarioCreador; 


        public DateTime Fecha
        {
            get { return this._fecha; }
        }

        public Usuario Usuario
        {
            get { return this._usuarioCreador; }
        }
        public void CreaOrden() /// :base(Nombre)
        {
            ///persiste en la base de datos
            ///en principio lo hardcodeariamos ahora 
            ///alter-add
        }

        public void Modifica() ///:base(id) se incluye en el caso de uso de busqueda 
        { 
            ///persiste en la base de datos 
            ///alter modify

        }
        public void Elimina() ///:base(id) se incluye en el caso de uso de busqueda 
        {
            ///persiste en la base de datos
            ///en principio lo hardcodeariamos ahora 
            ///alter delete
        }
        public void Busca()///:base(id) 
        {
            ///en principio lo hardcodeariamos ahora 

        }
        public void habilita(Usuario _UsuarioHabilitador)///:base(id) se incluye en el caso de uso de busqueda 
        {
            ///habilita orden de compra 
            ///esto puede ser usado por generente unicamente hay que ver como usar la condicion con rol 

        }

    }
}
