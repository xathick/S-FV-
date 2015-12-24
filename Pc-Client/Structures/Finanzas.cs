using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S_FV_.Structures
{
    class Finanzas
    {
        Parroquia parroquia;
        double balance;
        Movimiento[] movimientos;

        #region encapsulated fields
        internal Parroquia Parroquia
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

        public double Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }

        internal Movimiento[] Movimientos
        {
            get
            {
                return movimientos;
            }

            set
            {
                movimientos = value;
            }
        }
        #endregion

        public Finanzas()
        {
            this.parroquia=null;
            this.balance = 0;
            this.movimientos= null;
        }

        public Finanzas(Parroquia parroquia, double balance,  Movimiento[] movimientos)
        {
            this.parroquia=parroquia;
            this.balance=balance;
            this.movimientos=movimientos;
        }
    }
}
