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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveLog = new System.Windows.Forms.Button();
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
            this.buttonWriteZoneBSI = new System.Windows.Forms.Button();
            this.buttonReadZoneBSI = new System.Windows.Forms.Button();
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxZoneBSI = new System.Windows.Forms.TextBox();
            this.textBoxZoneNewValueBSI = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueBSI = new System.Windows.Forms.TextBox();
            this.textBoxHWBSI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSWBSI = new System.Windows.Forms.TextBox();
            this.textBoxTypBSI = new System.Windows.Forms.TextBox();
            this.buttonIdentifyBSI = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label48 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.textBoxZoneCVM = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueCVM = new System.Windows.Forms.TextBox();
            this.buttonReadZoneCVM = new System.Windows.Forms.Button();
            this.textBoxCVMNewCoding = new System.Windows.Forms.TextBox();
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
            this.label51 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBoxNewCodingDAE = new System.Windows.Forms.TextBox();
            this.buttonWriteCodingDAE = new System.Windows.Forms.Button();
            this.textBoxDAECoding = new System.Windows.Forms.TextBox();
            this.buttonReadCodingDAE = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSWDAE = new System.Windows.Forms.TextBox();
            this.textBoxTypDAE = new System.Windows.Forms.TextBox();
            this.buttonIdentifyDAE = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.buttonWriteCodingAAS = new System.Windows.Forms.Button();
            this.textBoxCodingAAS = new System.Windows.Forms.TextBox();
            this.buttonReadCodingAAS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxZoneAAS = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueAAS = new System.Windows.Forms.TextBox();
            this.buttonReadZoneAAS = new System.Windows.Forms.Button();
            this.textBoxHWAAS = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBoxSWAAS = new System.Windows.Forms.TextBox();
            this.textBoxTypAAS = new System.Windows.Forms.TextBox();
            this.buttonIdentifyAAS = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label50 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.buttonWriteCodingARTIV = new System.Windows.Forms.Button();
            this.textBoxCodingARTIV = new System.Windows.Forms.TextBox();
            this.buttonReadCodingARTIV = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxZoneARTIV = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueARTIV = new System.Windows.Forms.TextBox();
            this.buttonReadZoneARTIV = new System.Windows.Forms.Button();
            this.textBoxHWARTIV = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxSWARTIV = new System.Windows.Forms.TextBox();
            this.textBoxTypARTIV = new System.Windows.Forms.TextBox();
            this.buttonIdentifyARTIV = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.textBoxZoneCOMBINE = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueCOMBINE = new System.Windows.Forms.TextBox();
            this.buttonReadZoneCOMBINE = new System.Windows.Forms.Button();
            this.textBoxHWCOMBINE = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBoxSWCOMBINE = new System.Windows.Forms.TextBox();
            this.textBoxTypCOMBINE = new System.Windows.Forms.TextBox();
            this.buttonIdentifyCOMBINE = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxZoneTELEMAT = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueTELEMAT = new System.Windows.Forms.TextBox();
            this.buttonReadZoneTELEMAT = new System.Windows.Forms.Button();
            this.textBoxHWTELEMAT = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxSWTELEMAT = new System.Windows.Forms.TextBox();
            this.textBoxTypTELEMAT = new System.Windows.Forms.TextBox();
            this.buttonIdentifyTELEMAT = new System.Windows.Forms.Button();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.label47 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.textBoxZoneINJ = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueINJ = new System.Windows.Forms.TextBox();
            this.buttonReadZoneINJ = new System.Windows.Forms.Button();
            this.textBoxHWINJ = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.textBoxSWINJ = new System.Windows.Forms.TextBox();
            this.textBoxTypINJ = new System.Windows.Forms.TextBox();
            this.buttonIdentifyINJ = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveLog);
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
            this.buttonSaveLog.Click += new System.EventHandler(this.ButtonSaveLog_Click);
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
            this.richTextBoxLog.HideSelection = false;
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 117);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(513, 315);
            this.richTextBoxLog.TabIndex = 8;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.WordWrap = false;
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
            // buttonWriteZoneBSI
            // 
            this.buttonWriteZoneBSI.Enabled = false;
            this.buttonWriteZoneBSI.Location = new System.Drawing.Point(292, 148);
            this.buttonWriteZoneBSI.Name = "buttonWriteZoneBSI";
            this.buttonWriteZoneBSI.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteZoneBSI.TabIndex = 3;
            this.buttonWriteZoneBSI.Text = "Write";
            this.buttonWriteZoneBSI.UseVisualStyleBackColor = true;
            this.buttonWriteZoneBSI.Click += new System.EventHandler(this.ButtonWriteZoneBSI_Click);
            // 
            // buttonReadZoneBSI
            // 
            this.buttonReadZoneBSI.Enabled = false;
            this.buttonReadZoneBSI.Location = new System.Drawing.Point(297, 91);
            this.buttonReadZoneBSI.Name = "buttonReadZoneBSI";
            this.buttonReadZoneBSI.Size = new System.Drawing.Size(103, 23);
            this.buttonReadZoneBSI.TabIndex = 2;
            this.buttonReadZoneBSI.Text = "Read Zone";
            this.buttonReadZoneBSI.UseVisualStyleBackColor = true;
            this.buttonReadZoneBSI.Click += new System.EventHandler(this.ButtonReadZoneBSI_Click);
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
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Location = new System.Drawing.Point(523, 40);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 466);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.textBoxZoneBSI);
            this.tabPage1.Controls.Add(this.textBoxZoneNewValueBSI);
            this.tabPage1.Controls.Add(this.textBoxZoneValueBSI);
            this.tabPage1.Controls.Add(this.textBoxHWBSI);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxSWBSI);
            this.tabPage1.Controls.Add(this.textBoxTypBSI);
            this.tabPage1.Controls.Add(this.buttonIdentifyBSI);
            this.tabPage1.Controls.Add(this.buttonReadZoneBSI);
            this.tabPage1.Controls.Add(this.buttonWriteZoneBSI);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BSI";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 198);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(379, 208);
            this.label29.TabIndex = 24;
            this.label29.Text = resources.GetString("label29.Text");
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(41, 151);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(73, 16);
            this.label32.TabIndex = 23;
            this.label32.Text = "New value:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(74, 120);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(45, 16);
            this.label31.TabIndex = 22;
            this.label31.Text = "Value:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(77, 95);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 16);
            this.label30.TabIndex = 21;
            this.label30.Text = "Zone:";
            // 
            // textBoxZoneBSI
            // 
            this.textBoxZoneBSI.Location = new System.Drawing.Point(136, 92);
            this.textBoxZoneBSI.Name = "textBoxZoneBSI";
            this.textBoxZoneBSI.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneBSI.TabIndex = 20;
            // 
            // textBoxZoneNewValueBSI
            // 
            this.textBoxZoneNewValueBSI.Location = new System.Drawing.Point(136, 148);
            this.textBoxZoneNewValueBSI.Name = "textBoxZoneNewValueBSI";
            this.textBoxZoneNewValueBSI.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxZoneNewValueBSI.Size = new System.Drawing.Size(145, 22);
            this.textBoxZoneNewValueBSI.TabIndex = 16;
            // 
            // textBoxZoneValueBSI
            // 
            this.textBoxZoneValueBSI.Location = new System.Drawing.Point(136, 120);
            this.textBoxZoneValueBSI.Name = "textBoxZoneValueBSI";
            this.textBoxZoneValueBSI.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueBSI.TabIndex = 14;
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
            this.tabPage2.Controls.Add(this.label48);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.textBoxZoneCVM);
            this.tabPage2.Controls.Add(this.textBoxZoneValueCVM);
            this.tabPage2.Controls.Add(this.buttonReadZoneCVM);
            this.tabPage2.Controls.Add(this.textBoxCVMNewCoding);
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
            this.tabPage2.Size = new System.Drawing.Size(534, 437);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "CVM";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(41, 218);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 16);
            this.label48.TabIndex = 63;
            this.label48.Text = "New value:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(136, 215);
            this.textBox6.Name = "textBox6";
            this.textBox6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox6.Size = new System.Drawing.Size(145, 22);
            this.textBox6.TabIndex = 62;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(292, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 61;
            this.button4.Text = "Write";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(73, 190);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(45, 16);
            this.label35.TabIndex = 27;
            this.label35.Text = "Value:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(77, 162);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 16);
            this.label36.TabIndex = 26;
            this.label36.Text = "Zone:";
            // 
            // textBoxZoneCVM
            // 
            this.textBoxZoneCVM.Location = new System.Drawing.Point(136, 159);
            this.textBoxZoneCVM.Name = "textBoxZoneCVM";
            this.textBoxZoneCVM.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneCVM.TabIndex = 25;
            // 
            // textBoxZoneValueCVM
            // 
            this.textBoxZoneValueCVM.Location = new System.Drawing.Point(136, 187);
            this.textBoxZoneValueCVM.Name = "textBoxZoneValueCVM";
            this.textBoxZoneValueCVM.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueCVM.TabIndex = 24;
            // 
            // buttonReadZoneCVM
            // 
            this.buttonReadZoneCVM.Enabled = false;
            this.buttonReadZoneCVM.Location = new System.Drawing.Point(292, 159);
            this.buttonReadZoneCVM.Name = "buttonReadZoneCVM";
            this.buttonReadZoneCVM.Size = new System.Drawing.Size(108, 23);
            this.buttonReadZoneCVM.TabIndex = 23;
            this.buttonReadZoneCVM.Text = "Read Zone";
            this.buttonReadZoneCVM.UseVisualStyleBackColor = true;
            this.buttonReadZoneCVM.Click += new System.EventHandler(this.ButtonReadZoneCVM_Click);
            // 
            // textBoxCVMNewCoding
            // 
            this.textBoxCVMNewCoding.Location = new System.Drawing.Point(136, 121);
            this.textBoxCVMNewCoding.Name = "textBoxCVMNewCoding";
            this.textBoxCVMNewCoding.Size = new System.Drawing.Size(264, 22);
            this.textBoxCVMNewCoding.TabIndex = 22;
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
            this.buttonWriteCodingCVM.Click += new System.EventHandler(this.ButtonWriteCodingCVM_Click);
            // 
            // textBoxCVMCoding
            // 
            this.textBoxCVMCoding.Location = new System.Drawing.Point(136, 92);
            this.textBoxCVMCoding.Name = "textBoxCVMCoding";
            this.textBoxCVMCoding.Size = new System.Drawing.Size(264, 22);
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
            this.tabPage3.Controls.Add(this.label51);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label52);
            this.tabPage3.Controls.Add(this.label53);
            this.tabPage3.Controls.Add(this.textBox12);
            this.tabPage3.Controls.Add(this.textBox13);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.textBoxNewCodingDAE);
            this.tabPage3.Controls.Add(this.buttonWriteCodingDAE);
            this.tabPage3.Controls.Add(this.textBoxDAECoding);
            this.tabPage3.Controls.Add(this.buttonReadCodingDAE);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.textBoxSWDAE);
            this.tabPage3.Controls.Add(this.textBoxTypDAE);
            this.tabPage3.Controls.Add(this.buttonIdentifyDAE);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(534, 437);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "DAE";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(41, 218);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(73, 16);
            this.label51.TabIndex = 71;
            this.label51.Text = "New value:";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(136, 215);
            this.textBox10.Name = "textBox10";
            this.textBox10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox10.Size = new System.Drawing.Size(145, 22);
            this.textBox10.TabIndex = 70;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(292, 215);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 23);
            this.button7.TabIndex = 69;
            this.button7.Text = "Write";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(73, 190);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(45, 16);
            this.label52.TabIndex = 68;
            this.label52.Text = "Value:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(77, 162);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(41, 16);
            this.label53.TabIndex = 67;
            this.label53.Text = "Zone:";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(136, 159);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 66;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(136, 187);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(264, 22);
            this.textBox13.TabIndex = 65;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(292, 159);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(108, 23);
            this.button8.TabIndex = 64;
            this.button8.Text = "Read Zone";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // textBoxNewCodingDAE
            // 
            this.textBoxNewCodingDAE.Location = new System.Drawing.Point(136, 121);
            this.textBoxNewCodingDAE.Name = "textBoxNewCodingDAE";
            this.textBoxNewCodingDAE.Size = new System.Drawing.Size(264, 22);
            this.textBoxNewCodingDAE.TabIndex = 28;
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
            this.buttonWriteCodingDAE.Click += new System.EventHandler(this.ButtonWriteCodingDAE_Click);
            // 
            // textBoxDAECoding
            // 
            this.textBoxDAECoding.Location = new System.Drawing.Point(136, 92);
            this.textBoxDAECoding.Name = "textBoxDAECoding";
            this.textBoxDAECoding.Size = new System.Drawing.Size(264, 22);
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
            // textBoxTypDAE
            // 
            this.textBoxTypDAE.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypDAE.Name = "textBoxTypDAE";
            this.textBoxTypDAE.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypDAE.TabIndex = 19;
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
            this.tabPage4.Controls.Add(this.label49);
            this.tabPage4.Controls.Add(this.textBox7);
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.textBox9);
            this.tabPage4.Controls.Add(this.buttonWriteCodingAAS);
            this.tabPage4.Controls.Add(this.textBoxCodingAAS);
            this.tabPage4.Controls.Add(this.buttonReadCodingAAS);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.textBoxZoneAAS);
            this.tabPage4.Controls.Add(this.textBoxZoneValueAAS);
            this.tabPage4.Controls.Add(this.buttonReadZoneAAS);
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
            this.tabPage4.Size = new System.Drawing.Size(534, 437);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "AAS";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(41, 218);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(73, 16);
            this.label49.TabIndex = 63;
            this.label49.Text = "New value:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(136, 215);
            this.textBox7.Name = "textBox7";
            this.textBox7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox7.Size = new System.Drawing.Size(145, 22);
            this.textBox7.TabIndex = 62;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(292, 215);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 61;
            this.button5.Text = "Write";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(136, 121);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(264, 22);
            this.textBox9.TabIndex = 42;
            // 
            // buttonWriteCodingAAS
            // 
            this.buttonWriteCodingAAS.Enabled = false;
            this.buttonWriteCodingAAS.Location = new System.Drawing.Point(6, 121);
            this.buttonWriteCodingAAS.Name = "buttonWriteCodingAAS";
            this.buttonWriteCodingAAS.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteCodingAAS.TabIndex = 41;
            this.buttonWriteCodingAAS.Text = "Write Coding";
            this.buttonWriteCodingAAS.UseVisualStyleBackColor = true;
            // 
            // textBoxCodingAAS
            // 
            this.textBoxCodingAAS.Location = new System.Drawing.Point(136, 92);
            this.textBoxCodingAAS.Name = "textBoxCodingAAS";
            this.textBoxCodingAAS.Size = new System.Drawing.Size(264, 22);
            this.textBoxCodingAAS.TabIndex = 40;
            // 
            // buttonReadCodingAAS
            // 
            this.buttonReadCodingAAS.Enabled = false;
            this.buttonReadCodingAAS.Location = new System.Drawing.Point(6, 92);
            this.buttonReadCodingAAS.Name = "buttonReadCodingAAS";
            this.buttonReadCodingAAS.Size = new System.Drawing.Size(108, 23);
            this.buttonReadCodingAAS.TabIndex = 39;
            this.buttonReadCodingAAS.Text = "Read Coding";
            this.buttonReadCodingAAS.UseVisualStyleBackColor = true;
            this.buttonReadCodingAAS.Click += new System.EventHandler(this.ButtonReadCodingAAS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Value:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Zone:";
            // 
            // textBoxZoneAAS
            // 
            this.textBoxZoneAAS.Location = new System.Drawing.Point(136, 159);
            this.textBoxZoneAAS.Name = "textBoxZoneAAS";
            this.textBoxZoneAAS.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneAAS.TabIndex = 35;
            // 
            // textBoxZoneValueAAS
            // 
            this.textBoxZoneValueAAS.Location = new System.Drawing.Point(136, 187);
            this.textBoxZoneValueAAS.Name = "textBoxZoneValueAAS";
            this.textBoxZoneValueAAS.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueAAS.TabIndex = 34;
            // 
            // buttonReadZoneAAS
            // 
            this.buttonReadZoneAAS.Enabled = false;
            this.buttonReadZoneAAS.Location = new System.Drawing.Point(292, 159);
            this.buttonReadZoneAAS.Name = "buttonReadZoneAAS";
            this.buttonReadZoneAAS.Size = new System.Drawing.Size(108, 23);
            this.buttonReadZoneAAS.TabIndex = 33;
            this.buttonReadZoneAAS.Text = "Read Zone";
            this.buttonReadZoneAAS.UseVisualStyleBackColor = true;
            this.buttonReadZoneAAS.Click += new System.EventHandler(this.ButtonReadZoneAAS_Click);
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
            this.tabPage5.Controls.Add(this.label50);
            this.tabPage5.Controls.Add(this.textBox8);
            this.tabPage5.Controls.Add(this.button6);
            this.tabPage5.Controls.Add(this.textBox11);
            this.tabPage5.Controls.Add(this.buttonWriteCodingARTIV);
            this.tabPage5.Controls.Add(this.textBoxCodingARTIV);
            this.tabPage5.Controls.Add(this.buttonReadCodingARTIV);
            this.tabPage5.Controls.Add(this.label34);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.textBoxZoneARTIV);
            this.tabPage5.Controls.Add(this.textBoxZoneValueARTIV);
            this.tabPage5.Controls.Add(this.buttonReadZoneARTIV);
            this.tabPage5.Controls.Add(this.textBoxHWARTIV);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.label20);
            this.tabPage5.Controls.Add(this.textBoxSWARTIV);
            this.tabPage5.Controls.Add(this.textBoxTypARTIV);
            this.tabPage5.Controls.Add(this.buttonIdentifyARTIV);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(534, 437);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "ARTIV";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(41, 218);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(73, 16);
            this.label50.TabIndex = 63;
            this.label50.Text = "New value:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(136, 215);
            this.textBox8.Name = "textBox8";
            this.textBox8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox8.Size = new System.Drawing.Size(145, 22);
            this.textBox8.TabIndex = 62;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(292, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 23);
            this.button6.TabIndex = 61;
            this.button6.Text = "Write";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(136, 121);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(264, 22);
            this.textBox11.TabIndex = 52;
            // 
            // buttonWriteCodingARTIV
            // 
            this.buttonWriteCodingARTIV.Enabled = false;
            this.buttonWriteCodingARTIV.Location = new System.Drawing.Point(6, 121);
            this.buttonWriteCodingARTIV.Name = "buttonWriteCodingARTIV";
            this.buttonWriteCodingARTIV.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteCodingARTIV.TabIndex = 51;
            this.buttonWriteCodingARTIV.Text = "Write Coding";
            this.buttonWriteCodingARTIV.UseVisualStyleBackColor = true;
            // 
            // textBoxCodingARTIV
            // 
            this.textBoxCodingARTIV.Location = new System.Drawing.Point(136, 92);
            this.textBoxCodingARTIV.Name = "textBoxCodingARTIV";
            this.textBoxCodingARTIV.Size = new System.Drawing.Size(264, 22);
            this.textBoxCodingARTIV.TabIndex = 50;
            // 
            // buttonReadCodingARTIV
            // 
            this.buttonReadCodingARTIV.Enabled = false;
            this.buttonReadCodingARTIV.Location = new System.Drawing.Point(6, 92);
            this.buttonReadCodingARTIV.Name = "buttonReadCodingARTIV";
            this.buttonReadCodingARTIV.Size = new System.Drawing.Size(108, 23);
            this.buttonReadCodingARTIV.TabIndex = 49;
            this.buttonReadCodingARTIV.Text = "Read Coding";
            this.buttonReadCodingARTIV.UseVisualStyleBackColor = true;
            this.buttonReadCodingARTIV.Click += new System.EventHandler(this.ButtonReadCodingARTIV_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(9, 284);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(105, 80);
            this.label34.TabIndex = 48;
            this.label34.Text = "ARTIV_UDS\r\n2100-coś\r\n2101-kodowanie\r\n\r\nRADAR_AV_4";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(73, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Value:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(77, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 46;
            this.label14.Text = "Zone:";
            // 
            // textBoxZoneARTIV
            // 
            this.textBoxZoneARTIV.Location = new System.Drawing.Point(136, 159);
            this.textBoxZoneARTIV.Name = "textBoxZoneARTIV";
            this.textBoxZoneARTIV.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneARTIV.TabIndex = 45;
            // 
            // textBoxZoneValueARTIV
            // 
            this.textBoxZoneValueARTIV.Location = new System.Drawing.Point(136, 187);
            this.textBoxZoneValueARTIV.Name = "textBoxZoneValueARTIV";
            this.textBoxZoneValueARTIV.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueARTIV.TabIndex = 44;
            // 
            // buttonReadZoneARTIV
            // 
            this.buttonReadZoneARTIV.Enabled = false;
            this.buttonReadZoneARTIV.Location = new System.Drawing.Point(292, 159);
            this.buttonReadZoneARTIV.Name = "buttonReadZoneARTIV";
            this.buttonReadZoneARTIV.Size = new System.Drawing.Size(108, 23);
            this.buttonReadZoneARTIV.TabIndex = 43;
            this.buttonReadZoneARTIV.Text = "Read Zone";
            this.buttonReadZoneARTIV.UseVisualStyleBackColor = true;
            this.buttonReadZoneARTIV.Click += new System.EventHandler(this.ButtonReadZoneARTIV_Click);
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
            this.tabPage6.Controls.Add(this.label33);
            this.tabPage6.Controls.Add(this.textBox3);
            this.tabPage6.Controls.Add(this.button1);
            this.tabPage6.Controls.Add(this.label37);
            this.tabPage6.Controls.Add(this.label38);
            this.tabPage6.Controls.Add(this.textBoxZoneCOMBINE);
            this.tabPage6.Controls.Add(this.textBoxZoneValueCOMBINE);
            this.tabPage6.Controls.Add(this.buttonReadZoneCOMBINE);
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
            this.tabPage6.Size = new System.Drawing.Size(534, 437);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "COMBINE";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(41, 151);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(73, 16);
            this.label33.TabIndex = 60;
            this.label33.Text = "New value:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(136, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox3.Size = new System.Drawing.Size(145, 22);
            this.textBox3.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(292, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 58;
            this.button1.Text = "Write";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(74, 120);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(45, 16);
            this.label37.TabIndex = 57;
            this.label37.Text = "Value:";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(77, 95);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(41, 16);
            this.label38.TabIndex = 56;
            this.label38.Text = "Zone:";
            // 
            // textBoxZoneCOMBINE
            // 
            this.textBoxZoneCOMBINE.Location = new System.Drawing.Point(136, 92);
            this.textBoxZoneCOMBINE.Name = "textBoxZoneCOMBINE";
            this.textBoxZoneCOMBINE.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneCOMBINE.TabIndex = 55;
            // 
            // textBoxZoneValueCOMBINE
            // 
            this.textBoxZoneValueCOMBINE.Location = new System.Drawing.Point(136, 120);
            this.textBoxZoneValueCOMBINE.Name = "textBoxZoneValueCOMBINE";
            this.textBoxZoneValueCOMBINE.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueCOMBINE.TabIndex = 54;
            // 
            // buttonReadZoneCOMBINE
            // 
            this.buttonReadZoneCOMBINE.Enabled = false;
            this.buttonReadZoneCOMBINE.Location = new System.Drawing.Point(297, 91);
            this.buttonReadZoneCOMBINE.Name = "buttonReadZoneCOMBINE";
            this.buttonReadZoneCOMBINE.Size = new System.Drawing.Size(103, 23);
            this.buttonReadZoneCOMBINE.TabIndex = 53;
            this.buttonReadZoneCOMBINE.Text = "Read Zone";
            this.buttonReadZoneCOMBINE.UseVisualStyleBackColor = true;
            this.buttonReadZoneCOMBINE.Click += new System.EventHandler(this.ButtonReadZoneCOMBINE_Click);
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
            this.tabPage7.Controls.Add(this.label46);
            this.tabPage7.Controls.Add(this.textBox4);
            this.tabPage7.Controls.Add(this.button2);
            this.tabPage7.Controls.Add(this.label39);
            this.tabPage7.Controls.Add(this.label40);
            this.tabPage7.Controls.Add(this.textBoxZoneTELEMAT);
            this.tabPage7.Controls.Add(this.textBoxZoneValueTELEMAT);
            this.tabPage7.Controls.Add(this.buttonReadZoneTELEMAT);
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
            this.tabPage7.Size = new System.Drawing.Size(534, 437);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "TELEMAT";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(41, 151);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(73, 16);
            this.label46.TabIndex = 60;
            this.label46.Text = "New value:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(136, 148);
            this.textBox4.Name = "textBox4";
            this.textBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox4.Size = new System.Drawing.Size(145, 22);
            this.textBox4.TabIndex = 59;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(292, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 58;
            this.button2.Text = "Write";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(74, 120);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(45, 16);
            this.label39.TabIndex = 57;
            this.label39.Text = "Value:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(77, 95);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(41, 16);
            this.label40.TabIndex = 56;
            this.label40.Text = "Zone:";
            // 
            // textBoxZoneTELEMAT
            // 
            this.textBoxZoneTELEMAT.Location = new System.Drawing.Point(136, 92);
            this.textBoxZoneTELEMAT.Name = "textBoxZoneTELEMAT";
            this.textBoxZoneTELEMAT.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneTELEMAT.TabIndex = 55;
            // 
            // textBoxZoneValueTELEMAT
            // 
            this.textBoxZoneValueTELEMAT.Location = new System.Drawing.Point(136, 120);
            this.textBoxZoneValueTELEMAT.Name = "textBoxZoneValueTELEMAT";
            this.textBoxZoneValueTELEMAT.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueTELEMAT.TabIndex = 54;
            // 
            // buttonReadZoneTELEMAT
            // 
            this.buttonReadZoneTELEMAT.Enabled = false;
            this.buttonReadZoneTELEMAT.Location = new System.Drawing.Point(297, 91);
            this.buttonReadZoneTELEMAT.Name = "buttonReadZoneTELEMAT";
            this.buttonReadZoneTELEMAT.Size = new System.Drawing.Size(103, 23);
            this.buttonReadZoneTELEMAT.TabIndex = 53;
            this.buttonReadZoneTELEMAT.Text = "Read Zone";
            this.buttonReadZoneTELEMAT.UseVisualStyleBackColor = true;
            this.buttonReadZoneTELEMAT.Click += new System.EventHandler(this.ButtonReadZoneTELEMAT_Click);
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
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.label47);
            this.tabPage8.Controls.Add(this.textBox5);
            this.tabPage8.Controls.Add(this.button3);
            this.tabPage8.Controls.Add(this.label41);
            this.tabPage8.Controls.Add(this.label42);
            this.tabPage8.Controls.Add(this.textBoxZoneINJ);
            this.tabPage8.Controls.Add(this.textBoxZoneValueINJ);
            this.tabPage8.Controls.Add(this.buttonReadZoneINJ);
            this.tabPage8.Controls.Add(this.textBoxHWINJ);
            this.tabPage8.Controls.Add(this.label43);
            this.tabPage8.Controls.Add(this.label44);
            this.tabPage8.Controls.Add(this.label45);
            this.tabPage8.Controls.Add(this.textBoxSWINJ);
            this.tabPage8.Controls.Add(this.textBoxTypINJ);
            this.tabPage8.Controls.Add(this.buttonIdentifyINJ);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(534, 437);
            this.tabPage8.TabIndex = 8;
            this.tabPage8.Text = "INJ";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(41, 151);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(73, 16);
            this.label47.TabIndex = 72;
            this.label47.Text = "New value:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(136, 148);
            this.textBox5.Name = "textBox5";
            this.textBox5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox5.Size = new System.Drawing.Size(145, 22);
            this.textBox5.TabIndex = 71;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(292, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 70;
            this.button3.Text = "Write";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(74, 120);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(45, 16);
            this.label41.TabIndex = 69;
            this.label41.Text = "Value:";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(77, 95);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(41, 16);
            this.label42.TabIndex = 68;
            this.label42.Text = "Zone:";
            // 
            // textBoxZoneINJ
            // 
            this.textBoxZoneINJ.Location = new System.Drawing.Point(136, 92);
            this.textBoxZoneINJ.Name = "textBoxZoneINJ";
            this.textBoxZoneINJ.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneINJ.TabIndex = 67;
            // 
            // textBoxZoneValueINJ
            // 
            this.textBoxZoneValueINJ.Location = new System.Drawing.Point(136, 120);
            this.textBoxZoneValueINJ.Name = "textBoxZoneValueINJ";
            this.textBoxZoneValueINJ.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueINJ.TabIndex = 66;
            // 
            // buttonReadZoneINJ
            // 
            this.buttonReadZoneINJ.Enabled = false;
            this.buttonReadZoneINJ.Location = new System.Drawing.Point(297, 91);
            this.buttonReadZoneINJ.Name = "buttonReadZoneINJ";
            this.buttonReadZoneINJ.Size = new System.Drawing.Size(103, 23);
            this.buttonReadZoneINJ.TabIndex = 65;
            this.buttonReadZoneINJ.Text = "Read Zone";
            this.buttonReadZoneINJ.UseVisualStyleBackColor = true;
            this.buttonReadZoneINJ.Click += new System.EventHandler(this.ButtonReadZoneINJ_Click);
            // 
            // textBoxHWINJ
            // 
            this.textBoxHWINJ.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWINJ.Name = "textBoxHWINJ";
            this.textBoxHWINJ.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWINJ.TabIndex = 64;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(133, 60);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(99, 16);
            this.label43.TabIndex = 63;
            this.label43.Text = "HW Reference:";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(133, 36);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(98, 16);
            this.label44.TabIndex = 62;
            this.label44.Text = "SW Reference:";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(133, 12);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(59, 16);
            this.label45.TabIndex = 61;
            this.label45.Text = "INJ type:";
            // 
            // textBoxSWINJ
            // 
            this.textBoxSWINJ.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWINJ.Name = "textBoxSWINJ";
            this.textBoxSWINJ.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWINJ.TabIndex = 60;
            // 
            // textBoxTypINJ
            // 
            this.textBoxTypINJ.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypINJ.Name = "textBoxTypINJ";
            this.textBoxTypINJ.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypINJ.TabIndex = 59;
            // 
            // buttonIdentifyINJ
            // 
            this.buttonIdentifyINJ.Enabled = false;
            this.buttonIdentifyINJ.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyINJ.Name = "buttonIdentifyINJ";
            this.buttonIdentifyINJ.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyINJ.TabIndex = 58;
            this.buttonIdentifyINJ.Text = "Identify";
            this.buttonIdentifyINJ.UseVisualStyleBackColor = true;
            this.buttonIdentifyINJ.Click += new System.EventHandler(this.ButtonIdentifyINJ_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 518);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "PSA Arduino 22.09.23";
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
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonWriteZoneBSI;
        private System.Windows.Forms.Button buttonReadZoneBSI;
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
        private System.Windows.Forms.TextBox textBoxZoneValueBSI;
        private System.Windows.Forms.TextBox textBoxZoneNewValueBSI;
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
        private System.Windows.Forms.TextBox textBoxTypDAE;
        private System.Windows.Forms.Button buttonReadCodingCVM;
        private System.Windows.Forms.Button buttonReadCodingDAE;
        private System.Windows.Forms.TextBox textBoxCVMCoding;
        private System.Windows.Forms.TextBox textBoxDAECoding;
        private System.Windows.Forms.TextBox textBoxHWAAS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBoxSWAAS;
        private System.Windows.Forms.TextBox textBoxTypAAS;
        private System.Windows.Forms.Button buttonSearchCOM;
        private System.Windows.Forms.TextBox textBoxHWARTIV;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxSWARTIV;
        private System.Windows.Forms.TextBox textBoxTypARTIV;
        private System.Windows.Forms.Button buttonWriteCodingCVM;
        private System.Windows.Forms.Button buttonWriteCodingDAE;
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
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBoxZoneBSI;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxZoneAAS;
        private System.Windows.Forms.TextBox textBoxZoneValueAAS;
        private System.Windows.Forms.Button buttonReadZoneAAS;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxZoneARTIV;
        private System.Windows.Forms.TextBox textBoxZoneValueARTIV;
        private System.Windows.Forms.Button buttonReadZoneARTIV;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox textBoxNewCodingDAE;
        private System.Windows.Forms.TextBox textBoxCVMNewCoding;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBoxZoneCVM;
        private System.Windows.Forms.TextBox textBoxZoneValueCVM;
        private System.Windows.Forms.Button buttonReadZoneCVM;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button buttonWriteCodingAAS;
        private System.Windows.Forms.TextBox textBoxCodingAAS;
        private System.Windows.Forms.Button buttonReadCodingAAS;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBoxZoneCOMBINE;
        private System.Windows.Forms.TextBox textBoxZoneValueCOMBINE;
        private System.Windows.Forms.Button buttonReadZoneCOMBINE;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBoxZoneTELEMAT;
        private System.Windows.Forms.TextBox textBoxZoneValueTELEMAT;
        private System.Windows.Forms.Button buttonReadZoneTELEMAT;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button buttonWriteCodingARTIV;
        private System.Windows.Forms.TextBox textBoxCodingARTIV;
        private System.Windows.Forms.Button buttonReadCodingARTIV;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox textBoxZoneINJ;
        private System.Windows.Forms.TextBox textBoxZoneValueINJ;
        private System.Windows.Forms.Button buttonReadZoneINJ;
        private System.Windows.Forms.TextBox textBoxHWINJ;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox textBoxSWINJ;
        private System.Windows.Forms.TextBox textBoxTypINJ;
        private System.Windows.Forms.Button buttonIdentifyINJ;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button8;
    }
}

