using System;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Windows.Forms;

namespace S_FV_.Client_PC
{
    class Conection
    {
        private byte[] message;
        private byte[] recived;
        private TcpClient tcpclnt = null;
        private string clave_privada_client = "";
        private string clave_publica_client = "";
        private string clave_publica_server = "";
        private Stream stm;

        public void createKeys()
        {

        }

        public Conection()
        {

            this.createKeys();

            try
            {
                tcpclnt = new TcpClient();
                tcpclnt.Connect("127.0.0.1", 8101);
                stm = tcpclnt.GetStream();
                ASCIIEncoding asen = new ASCIIEncoding();


                //solicitar clave y establacer clave
                String str = "00 - Establish connection";
                message = asen.GetBytes(str);
                stm.Write(message, 0, message.Length);

                //recivir clave publica server
                recived = new byte[100];//tamaño correcto?
                int k = stm.Read(recived, 0, 100);
                for (int i = 0; i < k; i++)
                    clave_publica_server= clave_publica_server+(Convert.ToChar(recived[i]));

                //mandar clave publica client
                message = asen.GetBytes(this.clave_publica_client);
                stm.Write(message, 0, message.Length);

                //confirmation
                recived = new byte[100];
                k = stm.Read(recived, 0, 100);
                string respuesta = "";
                for (int i = 0; i < k; i++)
                    respuesta = respuesta + (Convert.ToChar(recived[i]));
                if (!respuesta.Equals("01 - Connection establish"))
                    MessageBox.Show("Error en la conexión", "Critical Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                else
                    ;




            }

            catch (Exception e)
            {
                //Console.WriteLine("Error conecting" + e.StackTrace);
                MessageBox.Show("Error en la conexión: "+ e.StackTrace, "Critical Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            }

        }
        public byte[] SendMessage(String texto, String envio)
        {
            try
            { 
                ASCIIEncoding asen = new ASCIIEncoding();
                message = asen.GetBytes(texto);
                stm.Write(message, 0, message.Length);

                //send initial message
                recived = new byte[100];
                int k = stm.Read(recived, 0, 100);

                //get servers answer
                string respuesta = "";
                for (int i = 0; i < k; i++)
                    respuesta = respuesta + Convert.ToChar(recived[i]);


                if(!respuesta.Equals("03 - Recived. Continue"))
                {
                    //error
                    MessageBox.Show("Error en la comunicacion", "Critical Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else
                    if(envio!=null)
                    {
                        //enviar objeto (probablemente a guardar)
                        message = asen.GetBytes(envio); 
                        stm.Write(message, 0, message.Length);

                        //recivir confirmacion
                        respuesta = "";
                        for (int i = 0; i < k; i++)
                            respuesta = respuesta + Convert.ToChar(recived[i]);
                        
                        if (!respuesta.Equals("04 - Confirmed."))
                        {
                            //error
                            MessageBox.Show("Error en la comunicacion", "Critical Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                        }
                    }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error en la comunicacion: " + e.StackTrace, "Critical Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            return recived;
        }

        public void finishConection()
        {
            //end connection
            tcpclnt.Close();
        }

        public static void Main()
        {

           
        }

    }

}
