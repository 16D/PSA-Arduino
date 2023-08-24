using System;

namespace PSA_CVM2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxSeed = new System.Windows.Forms.TextBox();
            this.buttonAlgo = new System.Windows.Forms.Button();
            this.buttonSearchCOM = new System.Windows.Forms.Button();
            this.textBoxVin = new System.Windows.Forms.TextBox();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.buttonIdentifyVIN = new System.Windows.Forms.Button();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonWriteCodingBSI = new System.Windows.Forms.Button();
            this.buttonReadCodingBSI = new System.Windows.Forms.Button();
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2373Coding = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2326Coding = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxHWBSI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSWBSI = new System.Windows.Forms.TextBox();
            this.textBoxTypBSI = new System.Windows.Forms.TextBox();
            this.buttonIdentifyBSI = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonWriteCodingCVM = new System.Windows.Forms.Button();
            this.textBoxCVMCoding = new System.Windows.Forms.TextBox();
            this.buttonReadCodingCVM = new System.Windows.Forms.Button();
            this.textBoxHWCVM = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSWCVM = new System.Windows.Forms.TextBox();
            this.textBoxTypCVM = new System.Windows.Forms.TextBox();
            this.buttonIdentifyCVM = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonWriteCodingDAE = new System.Windows.Forms.Button();
            this.textBoxDAECoding = new System.Windows.Forms.TextBox();
            this.buttonReadCodingDAE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSWDAE = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.buttonIdentifyDAE = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonWriteCodingAAS = new System.Windows.Forms.Button();
            this.buttonReadCodingAAS = new System.Windows.Forms.Button();
            this.textBoxCodingAAS = new System.Windows.Forms.TextBox();
            this.textBoxHWAAS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxSWAAS = new System.Windows.Forms.TextBox();
            this.textBoxTypAAS = new System.Windows.Forms.TextBox();
            this.buttonIdentifyAAS = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonWriteCodingARTIV = new System.Windows.Forms.Button();
            this.textBoxHWARTIV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxSWARTIV = new System.Windows.Forms.TextBox();
            this.textBoxTypARTIV = new System.Windows.Forms.TextBox();
            this.buttonReadCodingARTIV = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonIdentifyARTIV = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.textBoxHWCOMBINE = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxSWCOMBINE = new System.Windows.Forms.TextBox();
            this.textBoxTypCOMBINE = new System.Windows.Forms.TextBox();
            this.buttonIdentifyCOMBINE = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.textBoxHWTELEMAT = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxSWTELEMAT = new System.Windows.Forms.TextBox();
            this.textBoxTypTELEMAT = new System.Windows.Forms.TextBox();
            this.buttonIdentifyTELEMAT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveLog);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.textBoxKey);
            this.panel1.Controls.Add(this.textBoxSeed);
            this.panel1.Controls.Add(this.buttonAlgo);
            this.panel1.Controls.Add(this.buttonSearchCOM);
            this.panel1.Controls.Add(this.textBoxVin);
            this.panel1.Controls.Add(this.richTextBoxLog);
            this.panel1.Controls.Add(this.buttonIdentifyVIN);
            this.panel1.Controls.Add(this.buttonClearLog);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxCOM);
            this.panel1.Controls.Add(this.buttonStop);
            this.panel1.Controls.Add(this.buttonStart);
            this.panel1.Location = new System.Drawing.Point(4, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 466);
            this.panel1.TabIndex = 0;
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.Location = new System.Drawing.Point(262, 438);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(250, 23);
            this.buttonSaveLog.TabIndex = 16;
            this.buttonSaveLog.Text = "Save Log";
            this.buttonSaveLog.UseVisualStyleBackColor = true;
            this.buttonSaveLog.Click += new System.EventHandler(this.buttonSaveLog_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(349, 70);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(154, 16);
            this.label29.TabIndex = 15;
            this.label29.Text = "odpowiedź = 7DDC57DF";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(278, 70);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 16);
            this.label28.TabIndex = 14;
            this.label28.Text = "KEY";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(161, 71);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 16);
            this.label27.TabIndex = 13;
            this.label27.Text = "SEED";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(254, 89);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(100, 22);
            this.textBoxKey.TabIndex = 12;
            this.textBoxKey.Text = "FAFA";
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(131, 89);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(100, 22);
            this.textBoxSeed.TabIndex = 11;
            this.textBoxSeed.Text = "F0F07A5B";
            // 
            // buttonAlgo
            // 
            this.buttonAlgo.Location = new System.Drawing.Point(5, 68);
            this.buttonAlgo.Name = "buttonAlgo";
            this.buttonAlgo.Size = new System.Drawing.Size(104, 23);
            this.buttonAlgo.TabIndex = 10;
            this.buttonAlgo.Text = "Test algo";
            this.buttonAlgo.UseVisualStyleBackColor = true;
            this.buttonAlgo.Click += new System.EventHandler(this.ButtonAlgo_Click);
            // 
            // buttonSearchCOM
            // 
            this.buttonSearchCOM.Location = new System.Drawing.Point(221, 6);
            this.buttonSearchCOM.Name = "buttonSearchCOM";
            this.buttonSearchCOM.Size = new System.Drawing.Size(90, 24);
            this.buttonSearchCOM.TabIndex = 9;
            this.buttonSearchCOM.Text = "Search";
            this.buttonSearchCOM.UseVisualStyleBackColor = true;
            this.buttonSearchCOM.Click += new System.EventHandler(this.ButtonSearchCOM_Click);
            // 
            // textBoxVin
            // 
            this.textBoxVin.Location = new System.Drawing.Point(131, 38);
            this.textBoxVin.Name = "textBoxVin";
            this.textBoxVin.Size = new System.Drawing.Size(201, 22);
            this.textBoxVin.TabIndex = 5;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 117);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(513, 315);
            this.richTextBoxLog.TabIndex = 8;
            this.richTextBoxLog.Text = "";
            // 
            // buttonIdentifyVIN
            // 
            this.buttonIdentifyVIN.Enabled = false;
            this.buttonIdentifyVIN.Location = new System.Drawing.Point(3, 37);
            this.buttonIdentifyVIN.Name = "buttonIdentifyVIN";
            this.buttonIdentifyVIN.Size = new System.Drawing.Size(110, 24);
            this.buttonIdentifyVIN.TabIndex = 4;
            this.buttonIdentifyVIN.Text = "Read VIN";
            this.buttonIdentifyVIN.UseVisualStyleBackColor = true;
            this.buttonIdentifyVIN.Click += new System.EventHandler(this.ButtonIdentifyVIN_Click);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(6, 438);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(250, 23);
            this.buttonClearLog.TabIndex = 7;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.ButtonClearLog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select COM port:";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(131, 6);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(84, 24);
            this.comboBoxCOM.TabIndex = 4;
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(413, 6);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(90, 24);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(317, 6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 24);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // buttonWriteCodingBSI
            // 
            this.buttonWriteCodingBSI.Enabled = false;
            this.buttonWriteCodingBSI.Location = new System.Drawing.Point(6, 121);
            this.buttonWriteCodingBSI.Name = "buttonWriteCodingBSI";
            this.buttonWriteCodingBSI.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteCodingBSI.TabIndex = 3;
            this.buttonWriteCodingBSI.Text = "Write Coding";
            this.buttonWriteCodingBSI.UseVisualStyleBackColor = true;
            // 
            // buttonReadCodingBSI
            // 
            this.buttonReadCodingBSI.Enabled = false;
            this.buttonReadCodingBSI.Location = new System.Drawing.Point(6, 92);
            this.buttonReadCodingBSI.Name = "buttonReadCodingBSI";
            this.buttonReadCodingBSI.Size = new System.Drawing.Size(108, 23);
            this.buttonReadCodingBSI.TabIndex = 2;
            this.buttonReadCodingBSI.Text = "Read Coding";
            this.buttonReadCodingBSI.UseVisualStyleBackColor = true;
            this.buttonReadCodingBSI.Click += new System.EventHandler(this.ButtonReadCodingBSI_Click);
            // 
            // spArduino
            // 
            this.spArduino.BaudRate = 115200;
            this.spArduino.PortName = "COM5";
            this.spArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SpArduino_DataReceived);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(4, 12);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(784, 22);
            this.textBoxInfo.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(523, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(431, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.textBox2373Coding);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBox2326Coding);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxHWBSI);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxSWBSI);
            this.tabPage1.Controls.Add(this.textBoxTypBSI);
            this.tabPage1.Controls.Add(this.buttonIdentifyBSI);
            this.tabPage1.Controls.Add(this.buttonReadCodingBSI);
            this.tabPage1.Controls.Add(this.buttonWriteCodingBSI);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(423, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BSI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(261, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 16);
            this.label14.TabIndex = 18;
            this.label14.Text = "02=alarm/ 0A=lane assist";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(262, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(115, 16);
            this.label13.TabIndex = 17;
            this.label13.Text = "00=without/01=with";
            // 
            // textBox2373Coding
            // 
            this.textBox2373Coding.Location = new System.Drawing.Point(155, 184);
            this.textBox2373Coding.Name = "textBox2373Coding";
            this.textBox2373Coding.Size = new System.Drawing.Size(100, 22);
            this.textBox2373Coding.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "2373 Lane Assist";
            // 
            // textBox2326Coding
            // 
            this.textBox2326Coding.Location = new System.Drawing.Point(155, 150);
            this.textBox2326Coding.Name = "textBox2326Coding";
            this.textBox2326Coding.Size = new System.Drawing.Size(100, 22);
            this.textBox2326Coding.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "2326 High Beam Assist";
            // 
            // textBoxHWBSI
            // 
            this.textBoxHWBSI.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWBSI.Name = "textBoxHWBSI";
            this.textBoxHWBSI.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWBSI.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "HW Reference:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "SW Reference:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "BSI type:";
            // 
            // textBoxSWBSI
            // 
            this.textBoxSWBSI.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWBSI.Name = "textBoxSWBSI";
            this.textBoxSWBSI.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWBSI.TabIndex = 8;
            // 
            // textBoxTypBSI
            // 
            this.textBoxTypBSI.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypBSI.Name = "textBoxTypBSI";
            this.textBoxTypBSI.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypBSI.TabIndex = 7;
            // 
            // buttonIdentifyBSI
            // 
            this.buttonIdentifyBSI.Enabled = false;
            this.buttonIdentifyBSI.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyBSI.Name = "buttonIdentifyBSI";
            this.buttonIdentifyBSI.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyBSI.TabIndex = 19;
            this.buttonIdentifyBSI.Text = "Identify";
            this.buttonIdentifyBSI.Click += new System.EventHandler(this.ButtonIdentifyBSI_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonWriteCodingCVM);
            this.tabPage2.Controls.Add(this.textBoxCVMCoding);
            this.tabPage2.Controls.Add(this.buttonReadCodingCVM);
            this.tabPage2.Controls.Add(this.textBoxHWCVM);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.textBoxSWCVM);
            this.tabPage2.Controls.Add(this.textBoxTypCVM);
            this.tabPage2.Controls.Add(this.buttonIdentifyCVM);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(423, 437);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "CVM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonWriteCodingCVM
            // 
            this.buttonWriteCodingCVM.Enabled = false;
            this.buttonWriteCodingCVM.Location = new System.Drawing.Point(6, 121);
            this.buttonWriteCodingCVM.Name = "buttonWriteCodingCVM";
            this.buttonWriteCodingCVM.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteCodingCVM.TabIndex = 21;
            this.buttonWriteCodingCVM.Text = "Write Coding";
            this.buttonWriteCodingCVM.UseVisualStyleBackColor = true;
            // 
            // textBoxCVMCoding
            // 
            this.textBoxCVMCoding.Location = new System.Drawing.Point(136, 92);
            this.textBoxCVMCoding.Name = "textBoxCVMCoding";
            this.textBoxCVMCoding.Size = new System.Drawing.Size(263, 22);
            this.textBoxCVMCoding.TabIndex = 20;
            // 
            // buttonReadCodingCVM
            // 
            this.buttonReadCodingCVM.Enabled = false;
            this.buttonReadCodingCVM.Location = new System.Drawing.Point(6, 92);
            this.buttonReadCodingCVM.Name = "buttonReadCodingCVM";
            this.buttonReadCodingCVM.Size = new System.Drawing.Size(108, 23);
            this.buttonReadCodingCVM.TabIndex = 19;
            this.buttonReadCodingCVM.Text = "Read Coding";
            this.buttonReadCodingCVM.UseVisualStyleBackColor = true;
            this.buttonReadCodingCVM.Click += new System.EventHandler(this.ButtonReadCodingCVM_Click);
            // 
            // textBoxHWCVM
            // 
            this.textBoxHWCVM.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWCVM.Name = "textBoxHWCVM";
            this.textBoxHWCVM.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWCVM.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(133, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "HW Reference:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "SW Reference:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "CVM type:";
            // 
            // textBoxSWCVM
            // 
            this.textBoxSWCVM.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWCVM.Name = "textBoxSWCVM";
            this.textBoxSWCVM.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWCVM.TabIndex = 14;
            // 
            // textBoxTypCVM
            // 
            this.textBoxTypCVM.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypCVM.Name = "textBoxTypCVM";
            this.textBoxTypCVM.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypCVM.TabIndex = 13;
            // 
            // buttonIdentifyCVM
            // 
            this.buttonIdentifyCVM.Enabled = false;
            this.buttonIdentifyCVM.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyCVM.Name = "buttonIdentifyCVM";
            this.buttonIdentifyCVM.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyCVM.TabIndex = 5;
            this.buttonIdentifyCVM.Text = "Identify";
            this.buttonIdentifyCVM.UseVisualStyleBackColor = true;
            this.buttonIdentifyCVM.Click += new System.EventHandler(this.ButtonIdentifyCVM_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonWriteCodingDAE);
            this.tabPage3.Controls.Add(this.textBoxDAECoding);
            this.tabPage3.Controls.Add(this.buttonReadCodingDAE);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textBoxSWDAE);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.buttonIdentifyDAE);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(423, 437);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "DAE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonWriteCodingDAE
            // 
            this.buttonWriteCodingDAE.Enabled = false;
            this.buttonWriteCodingDAE.Location = new System.Drawing.Point(6, 121);
            this.buttonWriteCodingDAE.Name = "buttonWriteCodingDAE";
            this.buttonWriteCodingDAE.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteCodingDAE.TabIndex = 27;
            this.buttonWriteCodingDAE.Text = "Write Coding";
            this.buttonWriteCodingDAE.UseVisualStyleBackColor = true;
            // 
            // textBoxDAECoding
            // 
            this.textBoxDAECoding.Location = new System.Drawing.Point(136, 92);
            this.textBoxDAECoding.Name = "textBoxDAECoding";
            this.textBoxDAECoding.Size = new System.Drawing.Size(263, 22);
            this.textBoxDAECoding.TabIndex = 26;
            // 
            // buttonReadCodingDAE
            // 
            this.buttonReadCodingDAE.Enabled = false;
            this.buttonReadCodingDAE.Location = new System.Drawing.Point(6, 92);
            this.buttonReadCodingDAE.Name = "buttonReadCodingDAE";
            this.buttonReadCodingDAE.Size = new System.Drawing.Size(108, 23);
            this.buttonReadCodingDAE.TabIndex = 25;
            this.buttonReadCodingDAE.Text = "Read Coding";
            this.buttonReadCodingDAE.UseVisualStyleBackColor = true;
            this.buttonReadCodingDAE.Click += new System.EventHandler(this.ButtonReadCodingDAE_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(250, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(133, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "HW Reference:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 16);
            this.label11.TabIndex = 22;
            this.label11.Text = "SW Reference:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(133, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "DAE type:";
            // 
            // textBoxSWDAE
            // 
            this.textBoxSWDAE.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWDAE.Name = "textBoxSWDAE";
            this.textBoxSWDAE.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWDAE.TabIndex = 20;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(250, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 22);
            this.textBox3.TabIndex = 19;
            // 
            // buttonIdentifyDAE
            // 
            this.buttonIdentifyDAE.Enabled = false;
            this.buttonIdentifyDAE.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyDAE.Name = "buttonIdentifyDAE";
            this.buttonIdentifyDAE.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyDAE.TabIndex = 6;
            this.buttonIdentifyDAE.Text = "Identify";
            this.buttonIdentifyDAE.UseVisualStyleBackColor = true;
            this.buttonIdentifyDAE.Click += new System.EventHandler(this.ButtonIdentifyDAE_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonWriteCodingAAS);
            this.tabPage4.Controls.Add(this.buttonReadCodingAAS);
            this.tabPage4.Controls.Add(this.textBoxCodingAAS);
            this.tabPage4.Controls.Add(this.textBoxHWAAS);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.textBoxSWAAS);
            this.tabPage4.Controls.Add(this.textBoxTypAAS);
            this.tabPage4.Controls.Add(this.buttonIdentifyAAS);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(423, 437);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "AAS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonWriteCodingAAS
            // 
            this.buttonWriteCodingAAS.Enabled = false;
            this.buttonWriteCodingAAS.Location = new System.Drawing.Point(6, 121);
            this.buttonWriteCodingAAS.Name = "buttonWriteCodingAAS";
            this.buttonWriteCodingAAS.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteCodingAAS.TabIndex = 35;
            this.buttonWriteCodingAAS.Text = "Write Coding";
            this.buttonWriteCodingAAS.UseVisualStyleBackColor = true;
            // 
            // buttonReadCodingAAS
            // 
            this.buttonReadCodingAAS.Enabled = false;
            this.buttonReadCodingAAS.Location = new System.Drawing.Point(6, 92);
            this.buttonReadCodingAAS.Name = "buttonReadCodingAAS";
            this.buttonReadCodingAAS.Size = new System.Drawing.Size(108, 23);
            this.buttonReadCodingAAS.TabIndex = 34;
            this.buttonReadCodingAAS.Text = "Read Coding";
            this.buttonReadCodingAAS.UseVisualStyleBackColor = true;
            this.buttonReadCodingAAS.Click += new System.EventHandler(this.ButtonReadCodingAAS_Click);
            // 
            // textBoxCodingAAS
            // 
            this.textBoxCodingAAS.Location = new System.Drawing.Point(136, 92);
            this.textBoxCodingAAS.Name = "textBoxCodingAAS";
            this.textBoxCodingAAS.Size = new System.Drawing.Size(262, 22);
            this.textBoxCodingAAS.TabIndex = 33;
            // 
            // textBoxHWAAS
            // 
            this.textBoxHWAAS.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWAAS.Name = "textBoxHWAAS";
            this.textBoxHWAAS.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWAAS.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(133, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(99, 16);
            this.label15.TabIndex = 31;
            this.label15.Text = "HW Reference:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(133, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(98, 16);
            this.label16.TabIndex = 30;
            this.label16.Text = "SW Reference:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(133, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 16);
            this.label17.TabIndex = 29;
            this.label17.Text = "AAS type:";
            // 
            // textBoxSWAAS
            // 
            this.textBoxSWAAS.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWAAS.Name = "textBoxSWAAS";
            this.textBoxSWAAS.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWAAS.TabIndex = 28;
            // 
            // textBoxTypAAS
            // 
            this.textBoxTypAAS.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypAAS.Name = "textBoxTypAAS";
            this.textBoxTypAAS.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypAAS.TabIndex = 27;
            // 
            // buttonIdentifyAAS
            // 
            this.buttonIdentifyAAS.Enabled = false;
            this.buttonIdentifyAAS.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyAAS.Name = "buttonIdentifyAAS";
            this.buttonIdentifyAAS.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyAAS.TabIndex = 6;
            this.buttonIdentifyAAS.Text = "Identify";
            this.buttonIdentifyAAS.UseVisualStyleBackColor = true;
            this.buttonIdentifyAAS.Click += new System.EventHandler(this.ButtonIdentifyAAS_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.buttonWriteCodingARTIV);
            this.tabPage5.Controls.Add(this.textBoxHWARTIV);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.textBoxSWARTIV);
            this.tabPage5.Controls.Add(this.textBoxTypARTIV);
            this.tabPage5.Controls.Add(this.buttonReadCodingARTIV);
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.buttonIdentifyARTIV);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(423, 437);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "ARTIV";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // buttonWriteCodingARTIV
            // 
            this.buttonWriteCodingARTIV.Enabled = false;
            this.buttonWriteCodingARTIV.Location = new System.Drawing.Point(6, 121);
            this.buttonWriteCodingARTIV.Name = "buttonWriteCodingARTIV";
            this.buttonWriteCodingARTIV.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteCodingARTIV.TabIndex = 43;
            this.buttonWriteCodingARTIV.Text = "Write Coding";
            this.buttonWriteCodingARTIV.UseVisualStyleBackColor = true;
            // 
            // textBoxHWARTIV
            // 
            this.textBoxHWARTIV.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWARTIV.Name = "textBoxHWARTIV";
            this.textBoxHWARTIV.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWARTIV.TabIndex = 42;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(133, 60);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 16);
            this.label18.TabIndex = 41;
            this.label18.Text = "HW Reference:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(133, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(98, 16);
            this.label19.TabIndex = 40;
            this.label19.Text = "SW Reference:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(133, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 16);
            this.label20.TabIndex = 39;
            this.label20.Text = "ARTIV type:";
            // 
            // textBoxSWARTIV
            // 
            this.textBoxSWARTIV.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWARTIV.Name = "textBoxSWARTIV";
            this.textBoxSWARTIV.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWARTIV.TabIndex = 38;
            // 
            // textBoxTypARTIV
            // 
            this.textBoxTypARTIV.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypARTIV.Name = "textBoxTypARTIV";
            this.textBoxTypARTIV.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypARTIV.TabIndex = 37;
            // 
            // buttonReadCodingARTIV
            // 
            this.buttonReadCodingARTIV.Enabled = false;
            this.buttonReadCodingARTIV.Location = new System.Drawing.Point(6, 92);
            this.buttonReadCodingARTIV.Name = "buttonReadCodingARTIV";
            this.buttonReadCodingARTIV.Size = new System.Drawing.Size(108, 23);
            this.buttonReadCodingARTIV.TabIndex = 36;
            this.buttonReadCodingARTIV.Text = "Read Coding";
            this.buttonReadCodingARTIV.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(136, 92);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(262, 22);
            this.textBox7.TabIndex = 35;
            // 
            // buttonIdentifyARTIV
            // 
            this.buttonIdentifyARTIV.Enabled = false;
            this.buttonIdentifyARTIV.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyARTIV.Name = "buttonIdentifyARTIV";
            this.buttonIdentifyARTIV.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyARTIV.TabIndex = 7;
            this.buttonIdentifyARTIV.Text = "Identify";
            this.buttonIdentifyARTIV.UseVisualStyleBackColor = true;
            this.buttonIdentifyARTIV.Click += new System.EventHandler(this.ButtonIdentifyARTIV_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.textBoxHWCOMBINE);
            this.tabPage6.Controls.Add(this.label21);
            this.tabPage6.Controls.Add(this.label22);
            this.tabPage6.Controls.Add(this.label23);
            this.tabPage6.Controls.Add(this.textBoxSWCOMBINE);
            this.tabPage6.Controls.Add(this.textBoxTypCOMBINE);
            this.tabPage6.Controls.Add(this.buttonIdentifyCOMBINE);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(423, 437);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "COMBINE";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // textBoxHWCOMBINE
            // 
            this.textBoxHWCOMBINE.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWCOMBINE.Name = "textBoxHWCOMBINE";
            this.textBoxHWCOMBINE.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWCOMBINE.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(133, 60);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(99, 16);
            this.label21.TabIndex = 51;
            this.label21.Text = "HW Reference:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(133, 36);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(98, 16);
            this.label22.TabIndex = 50;
            this.label22.Text = "SW Reference:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(133, 12);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 16);
            this.label23.TabIndex = 49;
            this.label23.Text = "COMBINE type:";
            // 
            // textBoxSWCOMBINE
            // 
            this.textBoxSWCOMBINE.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWCOMBINE.Name = "textBoxSWCOMBINE";
            this.textBoxSWCOMBINE.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWCOMBINE.TabIndex = 48;
            // 
            // textBoxTypCOMBINE
            // 
            this.textBoxTypCOMBINE.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypCOMBINE.Name = "textBoxTypCOMBINE";
            this.textBoxTypCOMBINE.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypCOMBINE.TabIndex = 47;
            // 
            // buttonIdentifyCOMBINE
            // 
            this.buttonIdentifyCOMBINE.Enabled = false;
            this.buttonIdentifyCOMBINE.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyCOMBINE.Name = "buttonIdentifyCOMBINE";
            this.buttonIdentifyCOMBINE.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyCOMBINE.TabIndex = 44;
            this.buttonIdentifyCOMBINE.Text = "Identify";
            this.buttonIdentifyCOMBINE.UseVisualStyleBackColor = true;
            this.buttonIdentifyCOMBINE.Click += new System.EventHandler(this.ButtonIdentifyCOMBINE_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.textBoxHWTELEMAT);
            this.tabPage7.Controls.Add(this.label24);
            this.tabPage7.Controls.Add(this.label25);
            this.tabPage7.Controls.Add(this.label26);
            this.tabPage7.Controls.Add(this.textBoxSWTELEMAT);
            this.tabPage7.Controls.Add(this.textBoxTypTELEMAT);
            this.tabPage7.Controls.Add(this.buttonIdentifyTELEMAT);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(423, 437);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "TELEMAT";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // textBoxHWTELEMAT
            // 
            this.textBoxHWTELEMAT.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWTELEMAT.Name = "textBoxHWTELEMAT";
            this.textBoxHWTELEMAT.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWTELEMAT.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(133, 60);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(99, 16);
            this.label24.TabIndex = 51;
            this.label24.Text = "HW Reference:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(133, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(98, 16);
            this.label25.TabIndex = 50;
            this.label25.Text = "SW Reference:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(133, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(102, 16);
            this.label26.TabIndex = 49;
            this.label26.Text = "TELEMAT type:";
            // 
            // textBoxSWTELEMAT
            // 
            this.textBoxSWTELEMAT.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWTELEMAT.Name = "textBoxSWTELEMAT";
            this.textBoxSWTELEMAT.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWTELEMAT.TabIndex = 48;
            // 
            // textBoxTypTELEMAT
            // 
            this.textBoxTypTELEMAT.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypTELEMAT.Name = "textBoxTypTELEMAT";
            this.textBoxTypTELEMAT.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypTELEMAT.TabIndex = 47;
            // 
            // buttonIdentifyTELEMAT
            // 
            this.buttonIdentifyTELEMAT.Enabled = false;
            this.buttonIdentifyTELEMAT.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyTELEMAT.Name = "buttonIdentifyTELEMAT";
            this.buttonIdentifyTELEMAT.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyTELEMAT.TabIndex = 44;
            this.buttonIdentifyTELEMAT.Text = "Identify";
            this.buttonIdentifyTELEMAT.UseVisualStyleBackColor = true;
            this.buttonIdentifyTELEMAT.Click += new System.EventHandler(this.ButtonIdentifyTELEMAT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "PSA Arduino 0.1v";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonWriteCodingBSI;
        private System.Windows.Forms.Button buttonReadCodingBSI;
        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonIdentifyVIN;
        private System.Windows.Forms.Button buttonIdentifyCVM;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.TextBox textBoxVin;
        private System.Windows.Forms.Button buttonIdentifyBSI;
        private System.Windows.Forms.Button buttonIdentifyDAE;
        private System.Windows.Forms.Button buttonIdentifyAAS;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonIdentifyARTIV;
        private System.Windows.Forms.TextBox textBoxTypBSI;
        private System.Windows.Forms.TextBox textBoxSWBSI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxHWBSI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2326Coding;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2373Coding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHWCVM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSWCVM;
        private System.Windows.Forms.TextBox textBoxTypCVM;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxSWDAE;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonReadCodingCVM;
        private System.Windows.Forms.Button buttonReadCodingDAE;
        private System.Windows.Forms.TextBox textBoxCVMCoding;
        private System.Windows.Forms.TextBox textBoxDAECoding;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button buttonReadCodingAAS;
        private System.Windows.Forms.TextBox textBoxCodingAAS;
        private System.Windows.Forms.TextBox textBoxHWAAS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxSWAAS;
        private System.Windows.Forms.TextBox textBoxTypAAS;
        private System.Windows.Forms.Button buttonSearchCOM;
        private System.Windows.Forms.Button buttonReadCodingARTIV;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBoxHWARTIV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxSWARTIV;
        private System.Windows.Forms.TextBox textBoxTypARTIV;
        private System.Windows.Forms.Button buttonWriteCodingCVM;
        private System.Windows.Forms.Button buttonWriteCodingDAE;
        private System.Windows.Forms.Button buttonWriteCodingAAS;
        private System.Windows.Forms.Button buttonWriteCodingARTIV;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBoxHWCOMBINE;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBoxSWCOMBINE;
        private System.Windows.Forms.TextBox textBoxTypCOMBINE;
        private System.Windows.Forms.Button buttonIdentifyCOMBINE;
        private System.Windows.Forms.TextBox textBoxHWTELEMAT;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textBoxSWTELEMAT;
        private System.Windows.Forms.TextBox textBoxTypTELEMAT;
        private System.Windows.Forms.Button buttonIdentifyTELEMAT;
        private System.Windows.Forms.Button buttonAlgo;
        private System.Windows.Forms.TextBox textBoxSeed;
        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
    }
}

