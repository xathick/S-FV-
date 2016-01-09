using System;
using System.Security.Cryptography;
using System.Text;

namespace S_FV_.Structures
{
    class User
    {
        #region Parametros
        String nombre;
        byte[] pass;
        Parroquia parroquia;
        Persona persona;
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

        public byte[] Pass
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
                return persona;
            }

            set
            {
                persona = value;
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
            this.persona = null;
        }

        /// <summary>
        /// Constructor que inicializa con los parametros facilitados todos los elemnetos, generando un objeto User con parámetros
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="pass">Contraseña del usuario</param>
        /// <param name="idPersona">Vinculo con el objeto Persona correspondiente</param>
        public User(String nombre, byte[] pass, Persona idPersona)
        {
            this.nombre = nombre;
            this.pass = pass;
            this.persona = idPersona;
        }

        public String StringValidation()
        {
            return this.nombre+":"+this.pass;
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
