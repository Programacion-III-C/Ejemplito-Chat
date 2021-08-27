using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CapaDeDatos
{
    public class Modelo
    {
        protected string IpDb;
        protected string NombreDb;
        protected string UsuarioDb;
        protected string PasswordDb;
        protected string PortDB;
        protected MySqlConnection conexion;
        protected MySqlCommand comando;
        protected MySqlDataReader lector;


        public Modelo()
        {
            this.incializarConexion();
            conexion = new MySqlConnection(
                "server=" + this.IpDb + ";" +
                "userid=" + this.UsuarioDb + ";" +
                "password=" + this.PasswordDb + ";" +
                "database=" + this.NombreDb + ";" +
                "port=" + this.PortDB + ";"
            );

            conexion.Open();
            this.comando = new MySqlCommand();
            this.comando.Connection = this.conexion;

        }

        protected void incializarConexion()
        {
            this.IpDb = "192.168.5.3";
            this.NombreDb = "chat";
            this.UsuarioDb = "root";
            this.PasswordDb = "1234";
            this.PortDB = "3307";
        }
    }
}