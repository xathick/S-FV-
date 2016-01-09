using System;

namespace S_FV_.Structures
{
    class Parroquia
    {
        #region Parametros
        String nombre;
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
        #endregion
       
        /// <summary>
        /// Genera un objeto tipo Parroquia inicializado a NULL
        /// </summary>
        public Parroquia()
        {
            this.nombre = null;
        }

        /// <summary>
        /// Genera un objeto Parroquia inicializado con los parametros especificados
        /// </summary>
        /// <param name="idParroquia">id</param>
        /// <param name="nombre"></param>
        public Parroquia(String nombre)
        {
            this.nombre = nombre;
        }
        public override string ToString()
        {
            return this.Nombre;
        }
     }
}
