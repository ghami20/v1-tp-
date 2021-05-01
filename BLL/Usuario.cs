using System;

namespace BLL
{
    public class Usuario : persona
    {

        private int _legajo;
        private Rol _rol;
        
        public Usuario ()
        {
            Console.Write("\n se crea un usuario");
        }
        
        public int Legajo
        {
            get { return _legajo;  }
            set { _legajo = value; }
        }
        

        public  Rol Rol
        {
            get { return _rol; }
            set { _rol = value; }
        }


        public void Crea () /// :base(Nombre)
        {
            ///varios usuarios van a poder usar esto 
            ///persiste en la base de datos 
            ///en principio lo hardcodeariamos ahora 
            ///alter-add
        }
        public void Modifica() ///:base(id) se incluye en el caso de uso de busqueda 
        {
            ///varios usuarios van a poder usar esto 
            ///persiste en la base de datos 
            ///alter modify
            
        }
        public void Elimina() ///:base(id) se incluye en el caso de uso de busqueda 
        {
            ///varios usuarios van a poder usar esto 
            ///persiste en la base de datos
            ///en principio lo hardcodeariamos ahora 
            ///alter delete
        }
        public void Busca()///:base(id) 
        {
            ///varios usuarios van a poder usar esto 
            ///en principio lo hardcodeariamos ahora 

        }


    }
}
