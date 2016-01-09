using System;

namespace S_FV_.Structures
{
    class User
    {
        #region Parametros
        String nombre;
        String pass;
        Parroquia idParroquia;
        Persona idPersona;
        #endregion

        #region Encapsulated Fields
        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Pass
        {
            get
            {
                return pass;
            }

            set
            {
                pass = value;
            }
        }

        public Persona IdPersona
        {
            get
            {
                return idPersona;
            }

            set
            {
                idPersona = value;
            }
        }
        #endregion

        /// <summary>
        /// Constructor que inicializa a NULL todos los elementos y genera un objeto User
        /// </summary>
        public User()
        {
            this.nombre = null;
            this.pass = null;
            this.idPersona = null;
        }

        /// <summary>
        /// Constructor que inicializa con los parametros facilitados todos los elemnetos, generando un objeto User con parámetros
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="pass">Contraseña del usuario</param>
        /// <param name="idPersona">Vinculo con el objeto Persona correspondiente</param>
        public User(String nombre, String pass, Persona idPersona)
        {
            this.nombre = nombre;
            this.pass = pass;
            this.idPersona = idPersona;
        }
        public String StringValidation()
        {
            return this.nombre + ":" + this.pass;
        }
        public String StringStore()
        {
            return this.nombre + ":" + this.pass.ToString() + ":" + this.persona;
        }
        public byte[] GenerateHash(String texto)
        {
            byte[] HashValue;
            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] MessageBytes = UE.GetBytes(texto);
            SHA1Managed SHhash = new SHA1Managed();
            HashValue = SHhash.ComputeHash(MessageBytes);
            return HashValue;
        }
    }
}
