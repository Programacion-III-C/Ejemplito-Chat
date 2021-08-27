using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CapaDeDatos;


namespace CapaLogica
{
    public class MensajeController{

        public static void Guardar(string autor,string destinatario,string contenido){
            try
            {
                MensajeModelo mensaje = new MensajeModelo();
                mensaje.autor = autor;
                mensaje.destinatario = destinatario;
                mensaje.contenido = contenido;
                mensaje.Guardar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        public static MySqlDataReader ObtenerMensajesSinLeer(string autor,string destinatario){
            MensajeModelo mensaje = new MensajeModelo();
            mensaje.autor = destinatario;
            mensaje.destinatario = autor;
            return mensaje.ObtenerMensjaesSinLeer();
            
        }

        public static void MarcarMensajesComoLeidos(string autor, string destinatario)
        {
            MensajeModelo mensaje = new MensajeModelo();
            mensaje.autor = destinatario;
            mensaje.destinatario = autor;
            mensaje.MarcarMensajesComoLeidos();

        }
    }
}
