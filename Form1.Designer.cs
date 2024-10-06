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
            this.buttonClearFaults = new System.Windows.Forms.Button();
            this.buttonReadFaults = new System.Windows.Forms.Button();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.textBoxmileage = new System.Windows.Forms.TextBox();
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
            this.buttonStartCodingBSI = new System.Windows.Forms.Button();
            this.buttonReadZoneBSI = new System.Windows.Forms.Button();
            this.spArduino = new System.IO.Ports.SerialPort(this.components);
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.tabTELEMAT = new System.Windows.Forms.TabControl();
            this.tabBSI = new System.Windows.Forms.TabPage();
            this.buttonWriteZoneBSI = new System.Windows.Forms.Button();
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
            this.tabCVM = new System.Windows.Forms.TabPage();
            this.label48 = new System.Windows.Forms.Label();
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
            this.tabDAE = new System.Windows.Forms.TabPage();
            this.label51 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.textBoxZoneDAE = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueDAE = new System.Windows.Forms.TextBox();
            this.buttonReadZoneDAE = new System.Windows.Forms.Button();
            this.textBoxNewCodingDAE = new System.Windows.Forms.TextBox();
            this.buttonWriteCodingDAE = new System.Windows.Forms.Button();
            this.textBoxDAECoding = new System.Windows.Forms.TextBox();
            this.buttonReadCodingDAE = new System.Windows.Forms.Button();
            this.textBoxHWDAE = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxSWDAE = new System.Windows.Forms.TextBox();
            this.textBoxTypDAE = new System.Windows.Forms.TextBox();
            this.buttonIdentifyDAE = new System.Windows.Forms.Button();
            this.tabAAS = new System.Windows.Forms.TabPage();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBoxAASNewCoding = new System.Windows.Forms.TextBox();
            this.buttonWriteCodingAAS = new System.Windows.Forms.Button();
            this.textBoxAASCoding = new System.Windows.Forms.TextBox();
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
            this.tabARTIV = new System.Windows.Forms.TabPage();
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
            this.tabCOMBINE = new System.Windows.Forms.TabPage();
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
            this.label62 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
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
            this.tabINJ = new System.Windows.Forms.TabPage();
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
            this.tabBVA = new System.Windows.Forms.TabPage();
            this.label54 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.textBoxZoneBVA = new System.Windows.Forms.TextBox();
            this.textBoxZoneValueBVA = new System.Windows.Forms.TextBox();
            this.buttonReadZoneBVA = new System.Windows.Forms.Button();
            this.textBoxHWBVA = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.textBoxSWBVA = new System.Windows.Forms.TextBox();
            this.textBoxTypBVA = new System.Windows.Forms.TextBox();
            this.buttonIdentifyBVA = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabTELEMAT.SuspendLayout();
            this.tabBSI.SuspendLayout();
            this.tabCVM.SuspendLayout();
            this.tabDAE.SuspendLayout();
            this.tabAAS.SuspendLayout();
            this.tabARTIV.SuspendLayout();
            this.tabCOMBINE.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabINJ.SuspendLayout();
            this.tabBVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonClearFaults);
            this.panel1.Controls.Add(this.buttonReadFaults);
            this.panel1.Controls.Add(this.label61);
            this.panel1.Controls.Add(this.label60);
            this.panel1.Controls.Add(this.textBoxmileage);
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
            // buttonClearFaults
            // 
            this.buttonClearFaults.Enabled = false;
            this.buttonClearFaults.Location = new System.Drawing.Point(395, 89);
            this.buttonClearFaults.Name = "buttonClearFaults";
            this.buttonClearFaults.Size = new System.Drawing.Size(108, 23);
            this.buttonClearFaults.TabIndex = 27;
            this.buttonClearFaults.Text = "Clear faults";
            this.buttonClearFaults.Click += new System.EventHandler(this.ButtonClearFaults_Click);
            // 
            // buttonReadFaults
            // 
            this.buttonReadFaults.Enabled = false;
            this.buttonReadFaults.Location = new System.Drawing.Point(281, 89);
            this.buttonReadFaults.Name = "buttonReadFaults";
            this.buttonReadFaults.Size = new System.Drawing.Size(108, 23);
            this.buttonReadFaults.TabIndex = 26;
            this.buttonReadFaults.Text = "Read faults";
            this.buttonReadFaults.Click += new System.EventHandler(this.ButtonReadFaults_Click);
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(93, 41);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(32, 16);
            this.label61.TabIndex = 19;
            this.label61.Text = "VIN:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(338, 41);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(59, 16);
            this.label60.TabIndex = 18;
            this.label60.Text = "Mileage:";
            // 
            // textBoxmileage
            // 
            this.textBoxmileage.Location = new System.Drawing.Point(403, 38);
            this.textBoxmileage.Name = "textBoxmileage";
            this.textBoxmileage.Size = new System.Drawing.Size(100, 22);
            this.textBoxmileage.TabIndex = 17;
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
            this.label28.Location = new System.Drawing.Point(186, 70);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 16);
            this.label28.TabIndex = 14;
            this.label28.Text = "KEY";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(93, 70);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(44, 16);
            this.label27.TabIndex = 13;
            this.label27.Text = "SEED";
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(162, 89);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(80, 22);
            this.textBoxKey.TabIndex = 12;
            this.textBoxKey.Text = "FAFA";
            // 
            // textBoxSeed
            // 
            this.textBoxSeed.Location = new System.Drawing.Point(76, 89);
            this.textBoxSeed.Name = "textBoxSeed";
            this.textBoxSeed.Size = new System.Drawing.Size(80, 22);
            this.textBoxSeed.TabIndex = 11;
            this.textBoxSeed.Text = "F0F07A5B";
            // 
            // buttonAlgo
            // 
            this.buttonAlgo.Location = new System.Drawing.Point(5, 68);
            this.buttonAlgo.Name = "buttonAlgo";
            this.buttonAlgo.Size = new System.Drawing.Size(65, 43);
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
            this.buttonIdentifyVIN.Size = new System.Drawing.Size(86, 24);
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
            // buttonStartCodingBSI
            // 
            this.buttonStartCodingBSI.Enabled = false;
            this.buttonStartCodingBSI.Location = new System.Drawing.Point(406, 180);
            this.buttonStartCodingBSI.Name = "buttonStartCodingBSI";
            this.buttonStartCodingBSI.Size = new System.Drawing.Size(108, 23);
            this.buttonStartCodingBSI.TabIndex = 3;
            this.buttonStartCodingBSI.Text = "Start Coding";
            this.buttonStartCodingBSI.UseVisualStyleBackColor = true;
            this.buttonStartCodingBSI.Click += new System.EventHandler(this.ButtonStartCodingBSI_Click);
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
            this.spArduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceivedHandler);
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(4, 12);
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.Size = new System.Drawing.Size(513, 22);
            this.textBoxInfo.TabIndex = 6;
            // 
            // tabTELEMAT
            // 
            this.tabTELEMAT.Controls.Add(this.tabBSI);
            this.tabTELEMAT.Controls.Add(this.tabCVM);
            this.tabTELEMAT.Controls.Add(this.tabDAE);
            this.tabTELEMAT.Controls.Add(this.tabAAS);
            this.tabTELEMAT.Controls.Add(this.tabARTIV);
            this.tabTELEMAT.Controls.Add(this.tabCOMBINE);
            this.tabTELEMAT.Controls.Add(this.tabPage7);
            this.tabTELEMAT.Controls.Add(this.tabINJ);
            this.tabTELEMAT.Controls.Add(this.tabBVA);
            this.tabTELEMAT.Location = new System.Drawing.Point(523, 12);
            this.tabTELEMAT.Name = "tabTELEMAT";
            this.tabTELEMAT.SelectedIndex = 0;
            this.tabTELEMAT.Size = new System.Drawing.Size(542, 494);
            this.tabTELEMAT.TabIndex = 0;
            // 
            // tabBSI
            // 
            this.tabBSI.Controls.Add(this.buttonWriteZoneBSI);
            this.tabBSI.Controls.Add(this.label29);
            this.tabBSI.Controls.Add(this.label32);
            this.tabBSI.Controls.Add(this.label31);
            this.tabBSI.Controls.Add(this.label30);
            this.tabBSI.Controls.Add(this.textBoxZoneBSI);
            this.tabBSI.Controls.Add(this.textBoxZoneNewValueBSI);
            this.tabBSI.Controls.Add(this.textBoxZoneValueBSI);
            this.tabBSI.Controls.Add(this.textBoxHWBSI);
            this.tabBSI.Controls.Add(this.label4);
            this.tabBSI.Controls.Add(this.label3);
            this.tabBSI.Controls.Add(this.label2);
            this.tabBSI.Controls.Add(this.textBoxSWBSI);
            this.tabBSI.Controls.Add(this.textBoxTypBSI);
            this.tabBSI.Controls.Add(this.buttonIdentifyBSI);
            this.tabBSI.Controls.Add(this.buttonReadZoneBSI);
            this.tabBSI.Controls.Add(this.buttonStartCodingBSI);
            this.tabBSI.Location = new System.Drawing.Point(4, 25);
            this.tabBSI.Name = "tabBSI";
            this.tabBSI.Padding = new System.Windows.Forms.Padding(3);
            this.tabBSI.Size = new System.Drawing.Size(534, 465);
            this.tabBSI.TabIndex = 0;
            this.tabBSI.Text = "BSI";
            this.tabBSI.UseVisualStyleBackColor = true;
            // 
            // buttonWriteZoneBSI
            // 
            this.buttonWriteZoneBSI.Enabled = false;
            this.buttonWriteZoneBSI.Location = new System.Drawing.Point(297, 180);
            this.buttonWriteZoneBSI.Name = "buttonWriteZoneBSI";
            this.buttonWriteZoneBSI.Size = new System.Drawing.Size(103, 23);
            this.buttonWriteZoneBSI.TabIndex = 25;
            this.buttonWriteZoneBSI.Text = "Write Zone";
            this.buttonWriteZoneBSI.UseVisualStyleBackColor = true;
            this.buttonWriteZoneBSI.Click += new System.EventHandler(this.ButtonWriteZoneBSI_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(6, 226);
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
            this.textBoxZoneNewValueBSI.Size = new System.Drawing.Size(378, 22);
            this.textBoxZoneNewValueBSI.TabIndex = 16;
            // 
            // textBoxZoneValueBSI
            // 
            this.textBoxZoneValueBSI.Location = new System.Drawing.Point(136, 120);
            this.textBoxZoneValueBSI.Name = "textBoxZoneValueBSI";
            this.textBoxZoneValueBSI.Size = new System.Drawing.Size(378, 22);
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
            // tabCVM
            // 
            this.tabCVM.Controls.Add(this.label63);
            this.tabCVM.Controls.Add(this.label48);
            this.tabCVM.Controls.Add(this.label35);
            this.tabCVM.Controls.Add(this.label36);
            this.tabCVM.Controls.Add(this.textBoxZoneCVM);
            this.tabCVM.Controls.Add(this.textBoxZoneValueCVM);
            this.tabCVM.Controls.Add(this.buttonReadZoneCVM);
            this.tabCVM.Controls.Add(this.textBoxCVMNewCoding);
            this.tabCVM.Controls.Add(this.buttonWriteCodingCVM);
            this.tabCVM.Controls.Add(this.textBoxCVMCoding);
            this.tabCVM.Controls.Add(this.buttonReadCodingCVM);
            this.tabCVM.Controls.Add(this.textBoxHWCVM);
            this.tabCVM.Controls.Add(this.label7);
            this.tabCVM.Controls.Add(this.label8);
            this.tabCVM.Controls.Add(this.label9);
            this.tabCVM.Controls.Add(this.textBoxSWCVM);
            this.tabCVM.Controls.Add(this.textBoxTypCVM);
            this.tabCVM.Controls.Add(this.buttonIdentifyCVM);
            this.tabCVM.Location = new System.Drawing.Point(4, 25);
            this.tabCVM.Name = "tabCVM";
            this.tabCVM.Padding = new System.Windows.Forms.Padding(3);
            this.tabCVM.Size = new System.Drawing.Size(534, 465);
            this.tabCVM.TabIndex = 2;
            this.tabCVM.Text = "CVM";
            this.tabCVM.UseVisualStyleBackColor = true;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(41, 169);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(73, 16);
            this.label48.TabIndex = 63;
            this.label48.Text = "New value:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(73, 357);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(45, 16);
            this.label35.TabIndex = 27;
            this.label35.Text = "Value:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(77, 329);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(41, 16);
            this.label36.TabIndex = 26;
            this.label36.Text = "Zone:";
            // 
            // textBoxZoneCVM
            // 
            this.textBoxZoneCVM.Location = new System.Drawing.Point(136, 326);
            this.textBoxZoneCVM.Name = "textBoxZoneCVM";
            this.textBoxZoneCVM.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneCVM.TabIndex = 25;
            // 
            // textBoxZoneValueCVM
            // 
            this.textBoxZoneValueCVM.Location = new System.Drawing.Point(136, 354);
            this.textBoxZoneValueCVM.Name = "textBoxZoneValueCVM";
            this.textBoxZoneValueCVM.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueCVM.TabIndex = 24;
            // 
            // buttonReadZoneCVM
            // 
            this.buttonReadZoneCVM.Enabled = false;
            this.buttonReadZoneCVM.Location = new System.Drawing.Point(292, 326);
            this.buttonReadZoneCVM.Name = "buttonReadZoneCVM";
            this.buttonReadZoneCVM.Size = new System.Drawing.Size(108, 23);
            this.buttonReadZoneCVM.TabIndex = 23;
            this.buttonReadZoneCVM.Text = "Read Zone";
            this.buttonReadZoneCVM.UseVisualStyleBackColor = true;
            this.buttonReadZoneCVM.Click += new System.EventHandler(this.ButtonReadZoneCVM_Click);
            // 
            // textBoxCVMNewCoding
            // 
            this.textBoxCVMNewCoding.Location = new System.Drawing.Point(136, 166);
            this.textBoxCVMNewCoding.Name = "textBoxCVMNewCoding";
            this.textBoxCVMNewCoding.Size = new System.Drawing.Size(264, 22);
            this.textBoxCVMNewCoding.TabIndex = 22;
            // 
            // buttonWriteCodingCVM
            // 
            this.buttonWriteCodingCVM.Enabled = false;
            this.buttonWriteCodingCVM.Location = new System.Drawing.Point(6, 202);
            this.buttonWriteCodingCVM.Name = "buttonWriteCodingCVM";
            this.buttonWriteCodingCVM.Size = new System.Drawing.Size(108, 23);
            this.buttonWriteCodingCVM.TabIndex = 21;
            this.buttonWriteCodingCVM.Text = "Start Coding";
            this.buttonWriteCodingCVM.UseVisualStyleBackColor = true;
            this.buttonWriteCodingCVM.Click += new System.EventHandler(this.ButtonWriteCodingCVM_Click);
            // 
            // textBoxCVMCoding
            // 
            this.textBoxCVMCoding.Location = new System.Drawing.Point(136, 129);
            this.textBoxCVMCoding.Name = "textBoxCVMCoding";
            this.textBoxCVMCoding.Size = new System.Drawing.Size(264, 22);
            this.textBoxCVMCoding.TabIndex = 20;
            // 
            // buttonReadCodingCVM
            // 
            this.buttonReadCodingCVM.Enabled = false;
            this.buttonReadCodingCVM.Location = new System.Drawing.Point(6, 91);
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
            // tabDAE
            // 
            this.tabDAE.Controls.Add(this.label51);
            this.tabDAE.Controls.Add(this.textBox10);
            this.tabDAE.Controls.Add(this.button7);
            this.tabDAE.Controls.Add(this.label52);
            this.tabDAE.Controls.Add(this.label53);
            this.tabDAE.Controls.Add(this.textBoxZoneDAE);
            this.tabDAE.Controls.Add(this.textBoxZoneValueDAE);
            this.tabDAE.Controls.Add(this.buttonReadZoneDAE);
            this.tabDAE.Controls.Add(this.textBoxNewCodingDAE);
            this.tabDAE.Controls.Add(this.buttonWriteCodingDAE);
            this.tabDAE.Controls.Add(this.textBoxDAECoding);
            this.tabDAE.Controls.Add(this.buttonReadCodingDAE);
            this.tabDAE.Controls.Add(this.textBoxHWDAE);
            this.tabDAE.Controls.Add(this.label10);
            this.tabDAE.Controls.Add(this.label11);
            this.tabDAE.Controls.Add(this.label12);
            this.tabDAE.Controls.Add(this.textBoxSWDAE);
            this.tabDAE.Controls.Add(this.textBoxTypDAE);
            this.tabDAE.Controls.Add(this.buttonIdentifyDAE);
            this.tabDAE.Location = new System.Drawing.Point(4, 25);
            this.tabDAE.Name = "tabDAE";
            this.tabDAE.Padding = new System.Windows.Forms.Padding(3);
            this.tabDAE.Size = new System.Drawing.Size(534, 465);
            this.tabDAE.TabIndex = 3;
            this.tabDAE.Text = "DAE";
            this.tabDAE.UseVisualStyleBackColor = true;
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
            // textBoxZoneDAE
            // 
            this.textBoxZoneDAE.Location = new System.Drawing.Point(136, 159);
            this.textBoxZoneDAE.Name = "textBoxZoneDAE";
            this.textBoxZoneDAE.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneDAE.TabIndex = 66;
            // 
            // textBoxZoneValueDAE
            // 
            this.textBoxZoneValueDAE.Location = new System.Drawing.Point(136, 187);
            this.textBoxZoneValueDAE.Name = "textBoxZoneValueDAE";
            this.textBoxZoneValueDAE.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueDAE.TabIndex = 65;
            // 
            // buttonReadZoneDAE
            // 
            this.buttonReadZoneDAE.Enabled = false;
            this.buttonReadZoneDAE.Location = new System.Drawing.Point(292, 159);
            this.buttonReadZoneDAE.Name = "buttonReadZoneDAE";
            this.buttonReadZoneDAE.Size = new System.Drawing.Size(108, 23);
            this.buttonReadZoneDAE.TabIndex = 64;
            this.buttonReadZoneDAE.Text = "Read Zone";
            this.buttonReadZoneDAE.UseVisualStyleBackColor = true;
            this.buttonReadZoneDAE.Click += new System.EventHandler(this.ButtonReadZoneDAE_Click);
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
            // textBoxHWDAE
            // 
            this.textBoxHWDAE.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWDAE.Name = "textBoxHWDAE";
            this.textBoxHWDAE.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWDAE.TabIndex = 24;
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
            // tabAAS
            // 
            this.tabAAS.Controls.Add(this.label49);
            this.tabAAS.Controls.Add(this.textBox7);
            this.tabAAS.Controls.Add(this.button5);
            this.tabAAS.Controls.Add(this.textBoxAASNewCoding);
            this.tabAAS.Controls.Add(this.buttonWriteCodingAAS);
            this.tabAAS.Controls.Add(this.textBoxAASCoding);
            this.tabAAS.Controls.Add(this.buttonReadCodingAAS);
            this.tabAAS.Controls.Add(this.label5);
            this.tabAAS.Controls.Add(this.label6);
            this.tabAAS.Controls.Add(this.textBoxZoneAAS);
            this.tabAAS.Controls.Add(this.textBoxZoneValueAAS);
            this.tabAAS.Controls.Add(this.buttonReadZoneAAS);
            this.tabAAS.Controls.Add(this.textBoxHWAAS);
            this.tabAAS.Controls.Add(this.label15);
            this.tabAAS.Controls.Add(this.label16);
            this.tabAAS.Controls.Add(this.label17);
            this.tabAAS.Controls.Add(this.textBoxSWAAS);
            this.tabAAS.Controls.Add(this.textBoxTypAAS);
            this.tabAAS.Controls.Add(this.buttonIdentifyAAS);
            this.tabAAS.Location = new System.Drawing.Point(4, 25);
            this.tabAAS.Name = "tabAAS";
            this.tabAAS.Padding = new System.Windows.Forms.Padding(3);
            this.tabAAS.Size = new System.Drawing.Size(534, 465);
            this.tabAAS.TabIndex = 4;
            this.tabAAS.Text = "AAS";
            this.tabAAS.UseVisualStyleBackColor = true;
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
            // textBoxAASNewCoding
            // 
            this.textBoxAASNewCoding.Location = new System.Drawing.Point(136, 121);
            this.textBoxAASNewCoding.Name = "textBoxAASNewCoding";
            this.textBoxAASNewCoding.Size = new System.Drawing.Size(264, 22);
            this.textBoxAASNewCoding.TabIndex = 42;
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
            this.buttonWriteCodingAAS.Click += new System.EventHandler(this.ButtonWriteCodingAAS_Click);
            // 
            // textBoxAASCoding
            // 
            this.textBoxAASCoding.Location = new System.Drawing.Point(136, 92);
            this.textBoxAASCoding.Name = "textBoxAASCoding";
            this.textBoxAASCoding.Size = new System.Drawing.Size(264, 22);
            this.textBoxAASCoding.TabIndex = 40;
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
            // tabARTIV
            // 
            this.tabARTIV.Controls.Add(this.label50);
            this.tabARTIV.Controls.Add(this.textBox8);
            this.tabARTIV.Controls.Add(this.button6);
            this.tabARTIV.Controls.Add(this.textBox11);
            this.tabARTIV.Controls.Add(this.buttonWriteCodingARTIV);
            this.tabARTIV.Controls.Add(this.textBoxCodingARTIV);
            this.tabARTIV.Controls.Add(this.buttonReadCodingARTIV);
            this.tabARTIV.Controls.Add(this.label34);
            this.tabARTIV.Controls.Add(this.label13);
            this.tabARTIV.Controls.Add(this.label14);
            this.tabARTIV.Controls.Add(this.textBoxZoneARTIV);
            this.tabARTIV.Controls.Add(this.textBoxZoneValueARTIV);
            this.tabARTIV.Controls.Add(this.buttonReadZoneARTIV);
            this.tabARTIV.Controls.Add(this.textBoxHWARTIV);
            this.tabARTIV.Controls.Add(this.label18);
            this.tabARTIV.Controls.Add(this.label19);
            this.tabARTIV.Controls.Add(this.label20);
            this.tabARTIV.Controls.Add(this.textBoxSWARTIV);
            this.tabARTIV.Controls.Add(this.textBoxTypARTIV);
            this.tabARTIV.Controls.Add(this.buttonIdentifyARTIV);
            this.tabARTIV.Location = new System.Drawing.Point(4, 25);
            this.tabARTIV.Name = "tabARTIV";
            this.tabARTIV.Padding = new System.Windows.Forms.Padding(3);
            this.tabARTIV.Size = new System.Drawing.Size(534, 465);
            this.tabARTIV.TabIndex = 5;
            this.tabARTIV.Text = "ARTIV";
            this.tabARTIV.UseVisualStyleBackColor = true;
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
            this.label34.Size = new System.Drawing.Size(136, 112);
            this.label34.TabIndex = 48;
            this.label34.Text = "ARTIV_UDS\r\n2100-coding posibility\r\n2101-coding\r\n\r\nRADAR_AV_4\r\n2100-coding posibil" +
    "ity\r\n2101-coding\r\n";
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
            // tabCOMBINE
            // 
            this.tabCOMBINE.Controls.Add(this.label33);
            this.tabCOMBINE.Controls.Add(this.textBox3);
            this.tabCOMBINE.Controls.Add(this.button1);
            this.tabCOMBINE.Controls.Add(this.label37);
            this.tabCOMBINE.Controls.Add(this.label38);
            this.tabCOMBINE.Controls.Add(this.textBoxZoneCOMBINE);
            this.tabCOMBINE.Controls.Add(this.textBoxZoneValueCOMBINE);
            this.tabCOMBINE.Controls.Add(this.buttonReadZoneCOMBINE);
            this.tabCOMBINE.Controls.Add(this.textBoxHWCOMBINE);
            this.tabCOMBINE.Controls.Add(this.label21);
            this.tabCOMBINE.Controls.Add(this.label22);
            this.tabCOMBINE.Controls.Add(this.label23);
            this.tabCOMBINE.Controls.Add(this.textBoxSWCOMBINE);
            this.tabCOMBINE.Controls.Add(this.textBoxTypCOMBINE);
            this.tabCOMBINE.Controls.Add(this.buttonIdentifyCOMBINE);
            this.tabCOMBINE.Location = new System.Drawing.Point(4, 25);
            this.tabCOMBINE.Name = "tabCOMBINE";
            this.tabCOMBINE.Padding = new System.Windows.Forms.Padding(3);
            this.tabCOMBINE.Size = new System.Drawing.Size(534, 465);
            this.tabCOMBINE.TabIndex = 6;
            this.tabCOMBINE.Text = "COMBINE";
            this.tabCOMBINE.UseVisualStyleBackColor = true;
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
            this.tabPage7.Controls.Add(this.label62);
            this.tabPage7.Controls.Add(this.panel2);
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
            this.tabPage7.Size = new System.Drawing.Size(534, 465);
            this.tabPage7.TabIndex = 7;
            this.tabPage7.Text = "TELEMAT";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(7, 235);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(76, 16);
            this.label62.TabIndex = 62;
            this.label62.Text = "Output tests";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button11);
            this.panel2.Controls.Add(this.button10);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Location = new System.Drawing.Point(3, 257);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(528, 202);
            this.panel2.TabIndex = 61;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(4, 62);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(287, 23);
            this.button11.TabIndex = 2;
            this.button11.Text = "180° Camera display control - Lateral view";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(4, 33);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(287, 23);
            this.button10.TabIndex = 1;
            this.button10.Text = "180° Camera display control - Zoom view";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(4, 4);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(287, 23);
            this.button8.TabIndex = 0;
            this.button8.Text = "180° Camera display control - Standard view";
            this.button8.UseVisualStyleBackColor = true;
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
            // tabINJ
            // 
            this.tabINJ.Controls.Add(this.label47);
            this.tabINJ.Controls.Add(this.textBox5);
            this.tabINJ.Controls.Add(this.button3);
            this.tabINJ.Controls.Add(this.label41);
            this.tabINJ.Controls.Add(this.label42);
            this.tabINJ.Controls.Add(this.textBoxZoneINJ);
            this.tabINJ.Controls.Add(this.textBoxZoneValueINJ);
            this.tabINJ.Controls.Add(this.buttonReadZoneINJ);
            this.tabINJ.Controls.Add(this.textBoxHWINJ);
            this.tabINJ.Controls.Add(this.label43);
            this.tabINJ.Controls.Add(this.label44);
            this.tabINJ.Controls.Add(this.label45);
            this.tabINJ.Controls.Add(this.textBoxSWINJ);
            this.tabINJ.Controls.Add(this.textBoxTypINJ);
            this.tabINJ.Controls.Add(this.buttonIdentifyINJ);
            this.tabINJ.Location = new System.Drawing.Point(4, 25);
            this.tabINJ.Name = "tabINJ";
            this.tabINJ.Padding = new System.Windows.Forms.Padding(3);
            this.tabINJ.Size = new System.Drawing.Size(534, 465);
            this.tabINJ.TabIndex = 8;
            this.tabINJ.Text = "INJ";
            this.tabINJ.UseVisualStyleBackColor = true;
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
            // tabBVA
            // 
            this.tabBVA.Controls.Add(this.label54);
            this.tabBVA.Controls.Add(this.textBox2);
            this.tabBVA.Controls.Add(this.button9);
            this.tabBVA.Controls.Add(this.label55);
            this.tabBVA.Controls.Add(this.label56);
            this.tabBVA.Controls.Add(this.textBoxZoneBVA);
            this.tabBVA.Controls.Add(this.textBoxZoneValueBVA);
            this.tabBVA.Controls.Add(this.buttonReadZoneBVA);
            this.tabBVA.Controls.Add(this.textBoxHWBVA);
            this.tabBVA.Controls.Add(this.label57);
            this.tabBVA.Controls.Add(this.label58);
            this.tabBVA.Controls.Add(this.label59);
            this.tabBVA.Controls.Add(this.textBoxSWBVA);
            this.tabBVA.Controls.Add(this.textBoxTypBVA);
            this.tabBVA.Controls.Add(this.buttonIdentifyBVA);
            this.tabBVA.Location = new System.Drawing.Point(4, 25);
            this.tabBVA.Name = "tabBVA";
            this.tabBVA.Padding = new System.Windows.Forms.Padding(3);
            this.tabBVA.Size = new System.Drawing.Size(534, 465);
            this.tabBVA.TabIndex = 9;
            this.tabBVA.Text = "BVA";
            this.tabBVA.UseVisualStyleBackColor = true;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(41, 151);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(73, 16);
            this.label54.TabIndex = 87;
            this.label54.Text = "New value:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(136, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(145, 22);
            this.textBox2.TabIndex = 86;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(292, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(108, 23);
            this.button9.TabIndex = 85;
            this.button9.Text = "Write";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(74, 120);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(45, 16);
            this.label55.TabIndex = 84;
            this.label55.Text = "Value:";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(77, 95);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(41, 16);
            this.label56.TabIndex = 83;
            this.label56.Text = "Zone:";
            // 
            // textBoxZoneBVA
            // 
            this.textBoxZoneBVA.Location = new System.Drawing.Point(136, 92);
            this.textBoxZoneBVA.Name = "textBoxZoneBVA";
            this.textBoxZoneBVA.Size = new System.Drawing.Size(100, 22);
            this.textBoxZoneBVA.TabIndex = 82;
            // 
            // textBoxZoneValueBVA
            // 
            this.textBoxZoneValueBVA.Location = new System.Drawing.Point(136, 120);
            this.textBoxZoneValueBVA.Name = "textBoxZoneValueBVA";
            this.textBoxZoneValueBVA.Size = new System.Drawing.Size(264, 22);
            this.textBoxZoneValueBVA.TabIndex = 81;
            // 
            // buttonReadZoneBVA
            // 
            this.buttonReadZoneBVA.Enabled = false;
            this.buttonReadZoneBVA.Location = new System.Drawing.Point(297, 91);
            this.buttonReadZoneBVA.Name = "buttonReadZoneBVA";
            this.buttonReadZoneBVA.Size = new System.Drawing.Size(103, 23);
            this.buttonReadZoneBVA.TabIndex = 80;
            this.buttonReadZoneBVA.Text = "Read Zone";
            this.buttonReadZoneBVA.UseVisualStyleBackColor = true;
            this.buttonReadZoneBVA.Click += new System.EventHandler(this.ButtonReadZoneBVA_Click);
            // 
            // textBoxHWBVA
            // 
            this.textBoxHWBVA.Location = new System.Drawing.Point(250, 57);
            this.textBoxHWBVA.Name = "textBoxHWBVA";
            this.textBoxHWBVA.Size = new System.Drawing.Size(150, 22);
            this.textBoxHWBVA.TabIndex = 79;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(133, 60);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(99, 16);
            this.label57.TabIndex = 78;
            this.label57.Text = "HW Reference:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(133, 36);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(98, 16);
            this.label58.TabIndex = 77;
            this.label58.Text = "SW Reference:";
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(133, 12);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(66, 16);
            this.label59.TabIndex = 76;
            this.label59.Text = "BVA type:";
            // 
            // textBoxSWBVA
            // 
            this.textBoxSWBVA.Location = new System.Drawing.Point(250, 33);
            this.textBoxSWBVA.Name = "textBoxSWBVA";
            this.textBoxSWBVA.Size = new System.Drawing.Size(150, 22);
            this.textBoxSWBVA.TabIndex = 75;
            // 
            // textBoxTypBVA
            // 
            this.textBoxTypBVA.Location = new System.Drawing.Point(250, 9);
            this.textBoxTypBVA.Name = "textBoxTypBVA";
            this.textBoxTypBVA.Size = new System.Drawing.Size(150, 22);
            this.textBoxTypBVA.TabIndex = 74;
            // 
            // buttonIdentifyBVA
            // 
            this.buttonIdentifyBVA.Enabled = false;
            this.buttonIdentifyBVA.Location = new System.Drawing.Point(6, 6);
            this.buttonIdentifyBVA.Name = "buttonIdentifyBVA";
            this.buttonIdentifyBVA.Size = new System.Drawing.Size(108, 23);
            this.buttonIdentifyBVA.TabIndex = 73;
            this.buttonIdentifyBVA.Text = "Identify";
            this.buttonIdentifyBVA.UseVisualStyleBackColor = true;
            this.buttonIdentifyBVA.Click += new System.EventHandler(this.ButtonIdentifyBVA_Click);
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(31, 132);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(83, 16);
            this.label63.TabIndex = 64;
            this.label63.Text = "Actual value:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 518);
            this.Controls.Add(this.tabTELEMAT);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "PSA Arduino 06.10.2024";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabTELEMAT.ResumeLayout(false);
            this.tabBSI.ResumeLayout(false);
            this.tabBSI.PerformLayout();
            this.tabCVM.ResumeLayout(false);
            this.tabCVM.PerformLayout();
            this.tabDAE.ResumeLayout(false);
            this.tabDAE.PerformLayout();
            this.tabAAS.ResumeLayout(false);
            this.tabAAS.PerformLayout();
            this.tabARTIV.ResumeLayout(false);
            this.tabARTIV.PerformLayout();
            this.tabCOMBINE.ResumeLayout(false);
            this.tabCOMBINE.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabINJ.ResumeLayout(false);
            this.tabINJ.PerformLayout();
            this.tabBVA.ResumeLayout(false);
            this.tabBVA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStartCodingBSI;
        private System.Windows.Forms.Button buttonReadZoneBSI;
        private System.IO.Ports.SerialPort spArduino;
        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.TabControl tabTELEMAT;
        private System.Windows.Forms.TabPage tabBSI;
        private System.Windows.Forms.TabPage tabCVM;
        private System.Windows.Forms.TabPage tabDAE;
        private System.Windows.Forms.TabPage tabAAS;
        private System.Windows.Forms.Button buttonIdentifyVIN;
        private System.Windows.Forms.Button buttonIdentifyCVM;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.TextBox textBoxVin;
        private System.Windows.Forms.Button buttonIdentifyBSI;
        private System.Windows.Forms.Button buttonIdentifyDAE;
        private System.Windows.Forms.Button buttonIdentifyAAS;
        private System.Windows.Forms.TabPage tabARTIV;
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
        private System.Windows.Forms.TextBox textBoxHWDAE;
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
        private System.Windows.Forms.TabPage tabCOMBINE;
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
        private System.Windows.Forms.TextBox textBoxAASNewCoding;
        private System.Windows.Forms.Button buttonWriteCodingAAS;
        private System.Windows.Forms.TextBox textBoxAASCoding;
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
        private System.Windows.Forms.TabPage tabINJ;
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
        private System.Windows.Forms.TextBox textBoxZoneDAE;
        private System.Windows.Forms.TextBox textBoxZoneValueDAE;
        private System.Windows.Forms.Button buttonReadZoneDAE;
        private System.Windows.Forms.Button buttonWriteZoneBSI;
        private System.Windows.Forms.TabPage tabBVA;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox textBoxZoneBVA;
        private System.Windows.Forms.TextBox textBoxZoneValueBVA;
        private System.Windows.Forms.Button buttonReadZoneBVA;
        private System.Windows.Forms.TextBox textBoxHWBVA;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox textBoxSWBVA;
        private System.Windows.Forms.TextBox textBoxTypBVA;
        private System.Windows.Forms.Button buttonIdentifyBVA;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox textBoxmileage;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Button buttonClearFaults;
        private System.Windows.Forms.Button buttonReadFaults;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label63;
    }
}

