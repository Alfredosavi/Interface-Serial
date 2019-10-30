namespace Interface_Serial
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bt_conectar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_enviar = new System.Windows.Forms.Button();
            this.textBox_Enviar = new System.Windows.Forms.TextBox();
            this.textBox_Recebido = new System.Windows.Forms.TextBox();
            this.timerPCOM = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_conectar
            // 
            resources.ApplyResources(this.bt_conectar, "bt_conectar");
            this.bt_conectar.BackColor = System.Drawing.Color.Green;
            this.bt_conectar.Name = "bt_conectar";
            this.bt_conectar.UseVisualStyleBackColor = false;
            this.bt_conectar.Click += new System.EventHandler(this.Bt_conectar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.Name = "comboBox1";
            // 
            // bt_enviar
            // 
            resources.ApplyResources(this.bt_enviar, "bt_enviar");
            this.bt_enviar.Name = "bt_enviar";
            this.bt_enviar.UseVisualStyleBackColor = true;
            this.bt_enviar.Click += new System.EventHandler(this.Bt_enviar_Click);
            // 
            // textBox_Enviar
            // 
            resources.ApplyResources(this.textBox_Enviar, "textBox_Enviar");
            this.textBox_Enviar.Name = "textBox_Enviar";
            // 
            // textBox_Recebido
            // 
            resources.ApplyResources(this.textBox_Recebido, "textBox_Recebido");
            this.textBox_Recebido.Name = "textBox_Recebido";
            // 
            // timerPCOM
            // 
            this.timerPCOM.Interval = 900;
            this.timerPCOM.Tick += new System.EventHandler(this.TimerPCOM_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // limpar
            // 
            resources.ApplyResources(this.limpar, "limpar");
            this.limpar.Name = "limpar";
            this.limpar.UseVisualStyleBackColor = true;
            this.limpar.Click += new System.EventHandler(this.Limpar_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.textBox_Recebido);
            this.Controls.Add(this.textBox_Enviar);
            this.Controls.Add(this.bt_enviar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_conectar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_conectar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_enviar;
        private System.Windows.Forms.TextBox textBox_Enviar;
        private System.Windows.Forms.TextBox textBox_Recebido;
        private System.Windows.Forms.Timer timerPCOM;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button limpar;
    }
}

