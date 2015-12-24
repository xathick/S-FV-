using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_FV_.Structures
{
    class Grupo
    {
        #region Parametros
        Parroquia parroquia;
        Persona[] monitores;
        Persona[] chavales;
        #endregion

        #region encapsulated Fields
        

        public Parroquia Parroquia
        {
            get
            {
                return parroquia;
            }

            set
            {
                parroquia = value;
            }
        }

        internal Persona[] Monitores
        {
            get
            {
                return monitores;
            }

            set
            {
                monitores = value;
            }
        }

        internal Persona[] Chavales
        {
            get
            {
                return chavales;
            }

            set
            {
                chavales = value;
            }
        }
        #endregion

        public Grupo()
        {
            this.parroquia = null;
            this.monitores = null;
            this.chavales = null;
        }

        public Grupo(String idParroquia, Persona[] monitores, Persona[] chavales)
        {
            this.parroquia = null;
            this.monitores = null;
            this.chavales = null;
        }

    }
}
