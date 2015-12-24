using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_FV_.Structures
{
    class Movimiento
    {
        String asunto;
        Persona quien;
        Double cantidad;
        DateTime date;

        #region Encapsulated fields
        public string IdMovimiento
        {
            get
            {
                return idMovimiento;
            }

            set
            {
                idMovimiento = value;
            }
        }

        public string Asunto
        {
            get
            {
                return asunto;
            }

            set
            {
                asunto = value;
            }
        }

        internal String Quien
        {
            get
            {
                return idquien;
            }

            set
            {
                idquien = value;
            }
        }

        public double Cantidad
        {
            get
            {
                return cantidad;
            }

            set
            {
                cantidad = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }
        #endregion

        public Movimiento()
        {
            this.asunto=null;
            this.quien=null;
            this.cantidad=0;
            this.date= new DateTime();
        }

        public Movimiento(String asunto, Persona quien, Double cantidad, DateTime date)
        {
           
            this.asunto=asunto;
            this.quien=quien;
            this.cantidad=cantidad;
            this.date=date;
        }
    }
}
