namespace CapaVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblDestinatario = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.rtxtChat = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(12, 9);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(21, 13);
            this.lblAutor.TabIndex = 0;
            this.lblAutor.Text = "De";
            // 
            // lblDestinatario
            // 
            this.lblDestinatario.AutoSize = true;
            this.lblDestinatario.Location = new System.Drawing.Point(12, 33);
            this.lblDestinatario.Name = "lblDestinatario";
            this.lblDestinatario.Size = new System.Drawing.Size(29, 13);
            this.lblDestinatario.TabIndex = 1;
            this.lblDestinatario.Text = "Para";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(39, 6);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 2;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(39, 33);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(100, 20);
            this.txtDestinatario.TabIndex = 3;
            // 
            // txtMensaje
            // 
            this.txtMensaje.Enabled = false;
            this.txtMensaje.Location = new System.Drawing.Point(164, 375);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(238, 59);
            this.txtMensaje.TabIndex = 4;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Enabled = false;
            this.btnEnviar.Location = new System.Drawing.Point(409, 375);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(58, 59);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "ENVIAR";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // rtxtChat
            // 
            this.rtxtChat.Location = new System.Drawing.Point(164, 6);
            this.rtxtChat.Name = "rtxtChat";
            this.rtxtChat.Size = new System.Drawing.Size(238, 363);
            this.rtxtChat.TabIndex = 6;
            this.rtxtChat.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(13, 69);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(126, 23);
            this.btnIniciar.TabIndex = 7;
            this.btnIniciar.Text = "Iniciar Chat";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(436, 6);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(287, 363);
            this.webBrowser.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 450);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.rtxtChat);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblDestinatario);
            this.Controls.Add(this.lblAutor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblDestinatario;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.TextBox txtMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox rtxtChat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

