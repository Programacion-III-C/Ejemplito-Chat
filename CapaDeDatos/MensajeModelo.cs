using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace CapaDeDatos
{
    public class MensajeModelo : Modelo{
        public int id;
        public string autor;
        public string destinatario;
        public string fechaHora;
        public string contenido;
        public bool leido;

        public void Guardar(){
            PrepararQuery();
            EjecutarQuery();
        }


        private void EjecutarQuery(){
            this.comando.ExecuteNonQuery();
        }
        public void PrepararQuery(){

            this.comando.CommandText = "INSERT INTO mensajes(autor,destinatario,mensaje) values " +
                "(@autor,@destinatario,@contenido)";
            this.comando.Parameters.AddWithValue("@autor", this.autor);
            this.comando.Parameters.AddWithValue("@destinatario", this.destinatario);
            
            this.comando.Parameters.AddWithValue("@contenido", this.contenido);
            this.comando.Prepare();

        }

        public MySqlDataReader ObtenerMensjaesSinLeer(){
            this.comando.CommandText = "SELECT id,autor,destinatario,fecha_hora,mensaje " +
                                        "FROM mensajes WHERE " +
                                        "not leido " +
                                        "AND destinatario = @destinatario "  +
                                        "AND autor = @autor";

            this.comando.Parameters.AddWithValue("@destinatario", this.destinatario);
            this.comando.Parameters.AddWithValue("@autor", this.autor);
            Console.WriteLine("OBTENER: " + this.comando.CommandText);
            this.comando.Prepare();
            
            return this.comando.ExecuteReader();

        }

        public void MarcarMensajesComoLeidos()
        {
            this.comando.CommandText = "UPDATE mensajes SET leido = true" +
                                        " WHERE " +
                                        "not leido " +
                                        "AND destinatario = @destinatario " +
                                        "AND autor = @autor";

            this.comando.Parameters.AddWithValue("@destinatario", this.destinatario);
            this.comando.Parameters.AddWithValue("@autor", this.autor);
            this.comando.Prepare();

            this.comando.ExecuteNonQuery();

        }




    }
}
