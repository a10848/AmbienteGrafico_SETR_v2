
namespace AmbienteGrafico_SETR_v2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialMonitor = new System.Windows.Forms.GroupBox();
            this.chkData = new System.Windows.Forms.CheckBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.chkScroll = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.RichTextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.panelLuz = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuz2 = new System.Windows.Forms.Button();
            this.btnLuz1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.imgOn = new System.Windows.Forms.PictureBox();
            this.imgOff = new System.Windows.Forms.PictureBox();
            this.btnSerial = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.cmbBaud = new System.Windows.Forms.ComboBox();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.serialMonitor.SuspendLayout();
            this.panelLuz.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOff)).BeginInit();
            this.SuspendLayout();
            // 
            // serialMonitor
            // 
            this.serialMonitor.Controls.Add(this.chkData);
            this.serialMonitor.Controls.Add(this.btnLimpar);
            this.serialMonitor.Controls.Add(this.chkScroll);
            this.serialMonitor.Controls.Add(this.btnGuardar);
            this.serialMonitor.Controls.Add(this.txtConsole);
            this.serialMonitor.Controls.Add(this.btnEnviar);
            this.serialMonitor.Controls.Add(this.txtEnviar);
            this.serialMonitor.Location = new System.Drawing.Point(1057, 12);
            this.serialMonitor.Name = "serialMonitor";
            this.serialMonitor.Size = new System.Drawing.Size(215, 657);
            this.serialMonitor.TabIndex = 0;
            this.serialMonitor.TabStop = false;
            this.serialMonitor.Text = "Serial Monitor";
            // 
            // chkData
            // 
            this.chkData.AutoSize = true;
            this.chkData.Location = new System.Drawing.Point(6, 605);
            this.chkData.Name = "chkData";
            this.chkData.Size = new System.Drawing.Size(131, 17);
            this.chkData.TabIndex = 4;
            this.chkData.Text = "Adicionar Data e Hora";
            this.chkData.UseVisualStyleBackColor = true;
            this.chkData.CheckedChanged += new System.EventHandler(this.chkData_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(6, 628);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // chkScroll
            // 
            this.chkScroll.AutoSize = true;
            this.chkScroll.Location = new System.Drawing.Point(6, 582);
            this.chkScroll.Name = "chkScroll";
            this.chkScroll.Size = new System.Drawing.Size(108, 17);
            this.chkScroll.TabIndex = 3;
            this.chkScroll.Text = "Scroll Automático";
            this.chkScroll.UseVisualStyleBackColor = true;
            this.chkScroll.CheckedChanged += new System.EventHandler(this.chkScroll_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(134, 628);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(6, 47);
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.Size = new System.Drawing.Size(203, 529);
            this.txtConsole.TabIndex = 4;
            this.txtConsole.Text = "";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(134, 19);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Location = new System.Drawing.Point(6, 21);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(122, 20);
            this.txtEnviar.TabIndex = 0;
            this.txtEnviar.Tag = "";
            // 
            // panelLuz
            // 
            this.panelLuz.Controls.Add(this.label2);
            this.panelLuz.Controls.Add(this.label1);
            this.panelLuz.Controls.Add(this.btnLuz2);
            this.panelLuz.Controls.Add(this.btnLuz1);
            this.panelLuz.Location = new System.Drawing.Point(136, 16);
            this.panelLuz.Name = "panelLuz";
            this.panelLuz.Size = new System.Drawing.Size(204, 164);
            this.panelLuz.TabIndex = 1;
            this.panelLuz.TabStop = false;
            this.panelLuz.Text = "Ligar e Desligar Luzes";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(108, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Luz F2 (Janela)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Luz F1 (Porta)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnLuz2
            // 
            this.btnLuz2.Image = global::AmbienteGrafico_SETR_v2.Properties.Resources.lightbulb_off_icon;
            this.btnLuz2.Location = new System.Drawing.Point(108, 68);
            this.btnLuz2.Name = "btnLuz2";
            this.btnLuz2.Size = new System.Drawing.Size(90, 90);
            this.btnLuz2.TabIndex = 3;
            this.btnLuz2.UseVisualStyleBackColor = true;
            this.btnLuz2.Click += new System.EventHandler(this.btnLuz2_Click);
            // 
            // btnLuz1
            // 
            this.btnLuz1.Image = global::AmbienteGrafico_SETR_v2.Properties.Resources.lightbulb_off_icon;
            this.btnLuz1.Location = new System.Drawing.Point(6, 68);
            this.btnLuz1.Name = "btnLuz1";
            this.btnLuz1.Size = new System.Drawing.Size(90, 90);
            this.btnLuz1.TabIndex = 3;
            this.btnLuz1.UseVisualStyleBackColor = true;
            this.btnLuz1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.imgOn);
            this.groupBox3.Controls.Add(this.imgOff);
            this.groupBox3.Controls.Add(this.btnSerial);
            this.groupBox3.Controls.Add(this.btnConectar);
            this.groupBox3.Controls.Add(this.cmbBaud);
            this.groupBox3.Controls.Add(this.cmbCom);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 168);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comunicação Serial";
            // 
            // imgOn
            // 
            this.imgOn.Image = global::AmbienteGrafico_SETR_v2.Properties.Resources.switch_on_icon;
            this.imgOn.Location = new System.Drawing.Point(6, 19);
            this.imgOn.Name = "imgOn";
            this.imgOn.Size = new System.Drawing.Size(46, 27);
            this.imgOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgOn.TabIndex = 3;
            this.imgOn.TabStop = false;
            // 
            // imgOff
            // 
            this.imgOff.Image = global::AmbienteGrafico_SETR_v2.Properties.Resources.switch_off_icon;
            this.imgOff.Location = new System.Drawing.Point(6, 19);
            this.imgOff.Name = "imgOff";
            this.imgOff.Size = new System.Drawing.Size(46, 27);
            this.imgOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgOff.TabIndex = 4;
            this.imgOff.TabStop = false;
            // 
            // btnSerial
            // 
            this.btnSerial.Location = new System.Drawing.Point(6, 139);
            this.btnSerial.Name = "btnSerial";
            this.btnSerial.Size = new System.Drawing.Size(106, 23);
            this.btnSerial.TabIndex = 5;
            this.btnSerial.Text = "Abrir Monitor";
            this.btnSerial.UseVisualStyleBackColor = true;
            this.btnSerial.Click += new System.EventHandler(this.btnSerial_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(6, 110);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(106, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cmbBaud
            // 
            this.cmbBaud.FormattingEnabled = true;
            this.cmbBaud.Location = new System.Drawing.Point(6, 83);
            this.cmbBaud.Name = "cmbBaud";
            this.cmbBaud.Size = new System.Drawing.Size(106, 21);
            this.cmbBaud.TabIndex = 1;
            this.cmbBaud.Text = "Baud";
            // 
            // cmbCom
            // 
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(6, 56);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(106, 21);
            this.cmbCom.TabIndex = 0;
            this.cmbCom.Text = "Porta COM";
            this.cmbCom.SelectedIndexChanged += new System.EventHandler(this.cmbCom_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 681);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelLuz);
            this.Controls.Add(this.serialMonitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Central de Alarme SETR";
            this.serialMonitor.ResumeLayout(false);
            this.serialMonitor.PerformLayout();
            this.panelLuz.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox serialMonitor;
        private System.Windows.Forms.GroupBox panelLuz;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbBaud;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.PictureBox imgOn;
        private System.Windows.Forms.PictureBox imgOff;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnSerial;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox chkData;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.CheckBox chkScroll;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.RichTextBox txtConsole;
        private System.Windows.Forms.Button btnLuz1;
        private System.Windows.Forms.Button btnLuz2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

