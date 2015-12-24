using System;

namespace S_FV_.Structures
{
    class Persona
    {
        #region Parametros
        String nombre;
        String apellido1;
        String apellido2;
        String telefono;
        String email;
        DateTime fechaNacimiento;
        Parroquia parroquia;
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

        public string Apellido1
        {
            get
            {
                return apellido1;
            }

            set
            {
                apellido1 = value;
            }
        }

        public string Apellido2
        {
            get
            {
                return apellido2;
            }

            set
            {
                apellido2 = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }

            set
            {
                fechaNacimiento = value;
            }
        }

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

        
        #endregion

        /// <summary>
        /// Constructor vacio de un objeto Persona, inicializando todos los componentes a NULL
        /// </summary>
        public Persona()
        {
            this.parroquia = null;
            this.nombre = null;
            this.apellido1 = null;
            this.apellido2 = null;
            this.telefono = null;
            this.email = null;
            this.fechaNacimiento = new DateTime();
        }

        /// <summary>
        /// Genera un objeto Persona con parámetros
        /// </summary>
        /// <param name="nombre">Primer apellido de la persona</param>
        /// <param name="apellido2">Segundo apellido de la persona</param>
        /// <param name="telefono">Telefono de la persona</param>
        /// <param name="email">Email de la persona</param>
        /// <param name="fechaNacimiento">Fecha de nacimiento de la persona</param>
        public Persona(String nombre, String apellido1, String apellido2, String telefono, String email, DateTime fechaNacimiento, Parroquia Parroquia)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.telefono = telefono;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.parroquia = Parroquia;
        }

        /// <summary>
        /// Crea un DateTime con los parametros pasados
        /// </summary>
        /// <param name="dia">Día - numérico</param>
        /// <param name="mes">Mes - numérico</param>
        /// <param name="año">Año - numérico</param>
        /// <returns></returns>
        public DateTime CrearFecha(int dia, int mes, int año)
        {
            DateTime fecha = new DateTime(año,mes,dia);
            return fecha;
        }


    }
}
