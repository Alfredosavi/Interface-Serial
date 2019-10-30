using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Interface_Serial
{
    public partial class Form1 : Form
    {
        string Rx_Global;
        public Form1()
        {
            InitializeComponent();
            timerPCOM.Enabled = true;
        }

        private void AtualizaPortasCOM()
        {
            int i = 0;
            bool atualiza = false;

            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string a in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(a) == false)
                    {
                        atualiza = true;
                    }
                }
            }
            else
            {
                atualiza = true;
            }

            if (atualiza == false)
            {
                return;
            }

            comboBox1.Items.Clear(); // limpar o role
            foreach (string a in SerialPort.GetPortNames()) // adicionando as portas COM novas
            {
                comboBox1.Items.Add(a);
            }
            comboBox1.SelectedIndex = 0; //selecionar a primeira porta que aparecer na lista
        }

        private void TimerPCOM_Tick(object sender, EventArgs e)
        {
            AtualizaPortasCOM();
        }

        private void Bt_conectar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                    serialPort1.Open();
                }
                catch
                {
                    return;
                }

                if(serialPort1.IsOpen)
                {
                    bt_conectar.Text = "Desconectar";
                    bt_conectar.BackColor = Color.Red;
                    comboBox1.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    bt_conectar.Text = "Conectar";
                    bt_conectar.BackColor = Color.Green;
                    comboBox1.Enabled = true;
                }
                catch
                {
                    return;
                }
            }
        }

        private void Bt_enviar_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write(textBox_Enviar.Text);
                textBox_Enviar.Clear();
                // quando apertar botao enviar o cursor do mouse precisa voltar para o textbox novamente --'
            }

            else
            {
                MessageBox.Show("Você precisa estar Conectado em uma COM !!!", "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Rx_Global = serialPort1.ReadExisting();
            Invoke(new EventHandler(Recebido));
        }

        private void Recebido(object sender, EventArgs e)
        {
            textBox_Recebido.AppendText(Rx_Global);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }
        // Quando voce fecha o programa sem desconectar ele fica aberto a COM ainda, se usar outro programa pra ouvir COM não vai conseguir

        private void Limpar_Click(object sender, EventArgs e)
        {
            textBox_Recebido.Clear();
        }
    }
}