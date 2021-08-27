using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace CapaVisual
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            MySqlDataReader mensajes = CapaLogica.MensajeController.ObtenerMensajesSinLeer(txtAutor.Text, txtDestinatario.Text);
            while (mensajes.Read())
            {
                // Mostrar mensajes en Rich Textbox
                rtxtChat.Text += 
                    Environment.NewLine + 
                    mensajes[1].ToString() + 
                    " -- " + 
                    mensajes[3].ToString() +
                    ":" + 
                    Environment.NewLine + 
                    mensajes[4].ToString() +
                    Environment.NewLine + 
                    Environment.NewLine;

                // Mostrar mensajes en Web Browser
                webBrowser.DocumentText +=
                    "<br />" +
                    "<b>" + 
                    mensajes[1].ToString() +
                    " -- " +
                    mensajes[3].ToString() +
                    ":" +
                    "</b>" +
                    "<br />" +
                    mensajes[4].ToString() +
                    "<br />" +
                    "<br />";

            
            }
            CapaLogica.MensajeController.MarcarMensajesComoLeidos(txtAutor.Text,txtDestinatario.Text);
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            CapaLogica.MensajeController.Guardar(txtAutor.Text, txtDestinatario.Text, txtMensaje.Text);
            rtxtChat.Text +=
                    Environment.NewLine +
                    txtAutor.Text +
                    " -- " + DateTime.Now.ToString() + ":" +
                    Environment.NewLine +
                    txtMensaje.Text + 
                    Environment.NewLine +
                    Environment.NewLine;
            webBrowser.DocumentText +=
                    "<br />" +
                    txtAutor.Text + 
                    " -- " + DateTime.Now.ToString() + ":" +
                    "<br />" +
                    txtMensaje.Text +
                    "<br />" +
                    "<br />";

            txtMensaje.Clear();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            txtMensaje.Enabled = true;
            btnEnviar.Enabled = true;
            timer1.Start();
        }
    }
}
