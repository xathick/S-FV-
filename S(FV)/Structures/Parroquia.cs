using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_FV_.Structures
{
    class Parroquia
    {
        #region Parametros
        String idParroquia;
        String nombre;
        #endregion

        #region Encapsulated Fields
        public string IdParroquia
        {
            get
            {
                return idParroquia;
            }

            set
            {
                idParroquia = value;
            }
        }

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
            this.idParroquia = null;
            this.nombre = null;
        }

        /// <summary>
        /// Genera un objeto Parroquia inicializado con los parametros especificados
        /// </summary>
        /// <param name="idParroquia">id</param>
        /// <param name="nombre"></param>
        public Parroquia(String idParroquia, String nombre)
        {
            this.nombre = nombre;
            this.idParroquia = nombre;
        }
    }
}
