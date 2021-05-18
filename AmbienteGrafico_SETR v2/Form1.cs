using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmbienteGrafico_SETR_v2
{
    public partial class Form1 : Form
    {
        private SerialPort conectorSerial;
        private bool dataSerial;
        private bool scrollAutomatico;
        int x = 0;

        public Form1()
        {
            InitializeComponent();

            Size = new Size(1080, 720);
            serialMonitor.Visible = false;

            btnConectar.Enabled = false;
            btnSerial.Enabled = false;
            serialMonitor.Enabled = false;
            imgOn.Visible = false;
            panelLuz.Enabled = false;

            List<int> baudRates = new List<int> { 4800, 9600, 19200, 38400, 57600, 115200, 230400 };

            foreach (int value in baudRates)
            {
                cmbBaud.Items.Add(value);

                if (value == 9600) cmbBaud.SelectedItem = value;
            }

            conectorSerial = new SerialPort();
            conectorSerial.DataReceived += ValorRecebido;

            string[] portas = SerialPort.GetPortNames();

            foreach (string value in portas)
            {
                cmbCom.Items.Add(value);
            }

        }

        public delegate void SerialDelegate(string valor);

        private void ValorRecebido(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string valor = conectorSerial.ReadLine();

                object[] parametros = new object[1];
                parametros[0] = valor;

                SerialDelegate delegar = new SerialDelegate(MostrarDados);
                BeginInvoke(delegar, parametros);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Erro");
            }
        }

        private void MostrarDados(string valor)
        {
            if (dataSerial)
            {
                txtConsole.AppendText(DateTime.Now + " -> " + valor);
            }
            else
            {
                txtConsole.AppendText(valor);
            }

            if (scrollAutomatico)
            {
                txtConsole.SelectionStart = txtConsole.Text.Length;
                txtConsole.ScrollToCaret();
            }
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            if (btnSerial.Text == "Fechar Monitor")
            {
                Size = new Size(1080, 720);
                serialMonitor.Visible = false;

                if (btnConectar.Text == "Conectar")
                {
                    btnSerial.Enabled = false;
                }

                btnSerial.Text = "Abrir Monitor";
            }
            else
            {
                Size = new Size(1300, 720);
                serialMonitor.Visible = true;
                btnSerial.Text = "Fechar Monitor";
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (btnConectar.Text == "Conectar")
            {
                if (!conectorSerial.IsOpen)
                {
                    conectorSerial.PortName = cmbCom.Text;
                    conectorSerial.BaudRate = int.Parse(cmbBaud.Text);

                    conectorSerial.Open();

                    btnSerial.Enabled = true;
                    serialMonitor.Enabled = true;
                    cmbBaud.Enabled = false;
                    cmbCom.Enabled = false;
                    imgOff.Visible = false;
                    imgOn.Visible = true;
                    panelLuz.Enabled = true;

                    btnConectar.Text = "Desconectar";
                }
            }
            else
            {
                if (conectorSerial.IsOpen)
                {
                    conectorSerial.Close();

                    serialMonitor.Enabled = false;
                    cmbBaud.Enabled = true;
                    cmbCom.Enabled = true;
                    imgOff.Visible = true;
                    imgOn.Visible = false;
                    panelLuz.Enabled = false;

                    if (btnSerial.Enabled == true)
                    {
                        btnSerial.Enabled = true;
                    }
                    else
                    {
                        btnSerial.Enabled = false;
                    }

                    btnConectar.Text = "Conectar";
                }
            }
        }

        private void cmbCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCom.Text != "Porta COM")
            {
                btnConectar.Enabled = true;
            }
        }

        private void chkScroll_CheckedChanged(object sender, EventArgs e)
        {
            scrollAutomatico = !scrollAutomatico;
            chkScroll.Checked = scrollAutomatico;
        }

        private void chkData_CheckedChanged(object sender, EventArgs e)
        {
            dataSerial = !dataSerial;
            chkData.Checked = dataSerial;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtConsole.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            SaveFileDialog caixaSalvar = new SaveFileDialog();

            DialogResult resultado = caixaSalvar.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                File.WriteAllText(caixaSalvar.FileName, txtConsole.Text);
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (conectorSerial.IsOpen)
            {
                conectorSerial.WriteLine(txtEnviar.Text);
                txtEnviar.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (conectorSerial.IsOpen)
            {
                if (x == 0)
                {
                    conectorSerial.WriteLine("CMD#1,1");
                    btnLuz1.Image = AmbienteGrafico_SETR_v2.Properties.Resources.lightbulb_icon;
                    x++;
                }

                else
                {
                    conectorSerial.WriteLine("CMD#1,0");
                    btnLuz1.Image = AmbienteGrafico_SETR_v2.Properties.Resources.lightbulb_off_icon;
                    x--;
                }
            }
        }

        private void btnLuz2_Click(object sender, EventArgs e)
        {
            if (conectorSerial.IsOpen)
            {
                if (x == 0)
                {
                    conectorSerial.WriteLine("CMD#2,1");
                    btnLuz2.Image = AmbienteGrafico_SETR_v2.Properties.Resources.lightbulb_icon;
                    x++;

                }
                else
                {
                    conectorSerial.WriteLine("CMD#2,0");
                    btnLuz2.Image = AmbienteGrafico_SETR_v2.Properties.Resources.lightbulb_off_icon;
                    x--;
                }
            }
        }
    }
}
