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
        int y = 0;
        int a = 0;

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
            panelKeys.Enabled = false;
            btnSOS.Visible = false;
            imgUnlock.Visible = false;
            panelSOS.Visible = false;
            imgWaterOn.Visible = false;
            imgFireOn.Visible = false;
            btnExp.Enabled = false;
            imgPir1On.Visible = false;
            imgPir2On.Visible = false;


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

                /* Tratar dos dados recebidos */
                string[] dados = valor.Split('#');

                if (valor.IndexOf("LED#") != -1)
                {
                    string[] divide = dados[1].Split(',');
                    int led = int.Parse(divide[0]);
                    int ledV = int.Parse(divide[1]);

                    if (led == 1)
                    {
                        if (ledV == 0)
                        {
                            btnLuz1.Image = AmbienteGrafico_SETR_v2.Properties.Resources.light_bulb__2_;
                            x = 0;
                        }
                        else if (ledV == 1)
                        {
                            btnLuz1.Image = AmbienteGrafico_SETR_v2.Properties.Resources.light_bulb__3_;
                            x = 1;
                        }
                    }
                    else if (led == 2)
                    {
                        if (ledV == 0)
                        {
                            btnLuz2.Image = AmbienteGrafico_SETR_v2.Properties.Resources.light_bulb__2_;
                            y = 0;
                        }
                        else if (ledV == 1)
                        {
                            btnLuz2.Image = AmbienteGrafico_SETR_v2.Properties.Resources.light_bulb__3_;
                            y = 1;
                        }
                    }
                }
                else if (valor.IndexOf("WATER#") != -1)
                {
                    int water = int.Parse(dados[1]);

                    if (water == 0)
                    {
                        imgWaterOff.Visible = true;
                        imgWaterOn.Visible = false;
                    }
                    else if (water == 1)
                    {
                        imgWaterOff.Visible = false;
                        imgWaterOn.Visible = true;
                    }
                }
                else if (valor.IndexOf("ALARM#") != -1)
                {
                    int alarm = int.Parse(dados[1]);

                    if (alarm == 0)
                    {
                        imgLock.Visible = true;
                        imgUnlock.Visible = false;
                        btnExp.Enabled = true;
                    }
                    else if (alarm == 1)
                    {
                        imgLock.Visible = false;
                        imgUnlock.Visible = true;
                        btnExp.Enabled = false;
                    }
                }
                else if (valor.IndexOf("FIRE#") != -1)
                {
                    int fire = int.Parse(dados[1]);

                    if (fire == 0)
                    {
                        imgFireOff.Visible = true;
                        imgFireOn.Visible = false;
                    }
                    else if (fire == 1)
                    {
                        imgFireOff.Visible = false;
                        imgFireOn.Visible = true;
                    }
                }
                else if (valor.IndexOf("PIR#") != -1)
                {
                    string[] divide = dados[1].Split(',');
                    int pir = int.Parse(divide[0]);
                    int pirV = int.Parse(divide[1]);

                    if (pir == 1)
                    {
                        if (pirV == 0)
                        {
                            imgPir1Off.Visible = true;
                            imgPir1On.Visible = false;
                        }
                        else if (pirV == 1)
                        {
                            imgPir1Off.Visible = false;
                            imgPir1On.Visible = true;
                        }
                    }
                    else if (pir == 2)
                    {
                        if (pirV == 0)
                        {
                            imgPir2Off.Visible = true;
                            imgPir2On.Visible = false;
                        }
                        else if (pirV == 1)
                        {
                            imgPir2Off.Visible = false;
                            imgPir2On.Visible = true;
                        }
                    }
                }
                else if (valor.IndexOf("WINDOW#") != -1)
                {
                    string[] divide = dados[1].Split(',');
                    int wA = int.Parse(divide[0]);
                    int wB = int.Parse(divide[1]);

                    if (wA == 1 && wB == 0)
                    {

                    }
                    else if (wA == 0 && wB == 1)
                    {

                    }
                    else if (wA == 1 && wB == 1)
                    {

                    }
                    else if (wA == 0 && wB == 0)
                    {

                    }
                }

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
                    panelKeys.Enabled = true;

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
                    panelKeys.Enabled = false;

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
                    btnLuz1.Image = AmbienteGrafico_SETR_v2.Properties.Resources.light_bulb__3_;
                    x++;
                }

                else
                {
                    conectorSerial.WriteLine("CMD#1,0");
                    btnLuz1.Image = AmbienteGrafico_SETR_v2.Properties.Resources.light_bulb__2_;
                    x--;
                }
            }
        }

        private void btnLuz2_Click(object sender, EventArgs e)
        {
            if (conectorSerial.IsOpen)
            {
                if (y == 0)
                {
                    conectorSerial.WriteLine("CMD#2,1");
                    btnLuz2.Image = AmbienteGrafico_SETR_v2.Properties.Resources.light_bulb__3_;
                    y++;

                }
                else
                {
                    conectorSerial.WriteLine("CMD#2,0");
                    btnLuz2.Image = AmbienteGrafico_SETR_v2.Properties.Resources.light_bulb__2_;
                    y--;
                }
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            panelSOS.Visible = false;
            btnSOS.Visible = false;
            a = 0;
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            if (a == 0)
            {
                btnSOS.Visible = true;
                a = 1;
            }
            else
            {
                btnSOS.Visible = false;
                a = 0;
            }

        }

        private void btnSOS_Click(object sender, EventArgs e)
        {
            panelSOS.Visible = true;
            btnSOS.Visible = false;
            a = 0;

        }
    }
}
