﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.IO.Pipes;
using System.Windows.Forms.VisualStyles;
using System.Runtime.InteropServices.ComTypes;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Diagnostics.Eventing.Reader;

namespace PSA_CVM2
{
    public partial class Form1 : Form
    {
        public string serialData;
        public string mileage;
        public string BSI = ">752:652";
        public string CodingKeyBSI;
        public string CVM = ">74A:64A";
        public string CodingKeyCVM;
        public string DAE = ">6B5:695";
        public string CodingKeyDAE;
        public string AAS = ">75D:65D";
        public string CodingKeyAAS;
        public string ARTIV = ">6B6:696";
        public string CodingKeyARTIV;
        public string COMBINE = ">75F:65F";
        public string CodingKeyCOMBINE;
        public string TELEMAT = ">764:664";
        public string CodingKeyTELEMAT;
        public string INJ = ">6A8:688";
        public string CodingKeyINJ;
        public string BVA = ">6A9:689";
        public string CodingKeyBVA;
        public string ABRASR = ">6AD:68D";
        public string CodingKeyABRASR;
        private string zone;
        public Form1()
        {
            InitializeComponent();
            UpdateCOMPortList();
        }
        private void UpdateCOMPortList()
        {
            comboBoxCOM.Items.Clear();
            String[] ports = SerialPort.GetPortNames();                                     //przypisanie aktywnego nr portu COM
            foreach (String x in ports)
                comboBoxCOM.Items.Add(x);
            int val = comboBoxCOM.Items.Count;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " Found " + val.ToString() + " device(s)" + Environment.NewLine;
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            if (val > 0)
            {
                comboBoxCOM.SelectedIndex = 0;
            }
        }
        private void ButtonSearchCOM_Click(object sender, EventArgs e)
        {
            UpdateCOMPortList();
        }
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxCOM.Text == string.Empty)
            {
                textBoxInfo.Text = "COM port not selected";
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " COM port not selected" + Environment.NewLine;
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
            else if (comboBoxCOM.Text != string.Empty)
            {
                if (comboBoxCOM.Visible == true)
                {
                    spArduino.PortName = comboBoxCOM.Text;                                                           // Potwierdzenie wyszukania odpowiedniego portu COM
                    try
                    {
                        spArduino.Open();
                    }
                    catch
                    {
                        textBoxInfo.Text = "COM port is not accesible";
                        richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " COM port is not accesible" + Environment.NewLine;
                        richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                        return;
                    }
                }
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                buttonSearchCOM.Enabled = false;
                buttonIdentifyVIN.Enabled = true;
                textBoxInfo.Text = "Connected to Interface";
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " Connected to Interface" + Environment.NewLine;
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
        }
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            spArduino.WriteLine(String.Format("82"));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 82") + Environment.NewLine;
            spArduino.WriteLine(String.Format("1001"));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1001") + Environment.NewLine;
            spArduino.Close();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonSearchCOM.Enabled = true;
            buttonIdentifyVIN.Enabled = false;
            LockIdentification();
            LockCodingBSI();
            LockCodingCVM();
            LockCodingDAE();
            LockCodingAAS();
            LockCodingARTIV();
            LockCodingCOMBINE();
            LockCodingTELEMAT();
            LockCodingINJ();
            LockCodingBVA();
            textBoxVin.Clear();
            textBoxInfo.Text = "Disconnected";
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " Disconnected" + Environment.NewLine;
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
        }
        public async void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort spArduino = (SerialPort)sender;
            serialData = spArduino.ReadLine();
        }
        private void ButtonClearLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
        }
        public void ButtonIdentifyVIN_Click(object sender, EventArgs e)
        {
            textBoxVin.Clear();
            string odpowiedz = ConnectModuleUDS(BSI);
            if (odpowiedz.Substring(0, 4) == "5003")
            {
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + String.Format(odpowiedz) + Environment.NewLine;
                Vinbsi();
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
            else
            {
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " Not connected to car" + Environment.NewLine;
                textBoxInfo.Text = "Not connected to car";
                MessageBox.Show("Not connected to car");
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
        }
        public void Vinbsi()
        {
            string odebraneVIN = ReadZoneUDS("F190");
            string toRemove = "62F190";                                                                  // procedura usuwania polecania CAN z ciagu danych do wyświetlenia VIN
            string result = string.Empty;
            int s = odebraneVIN.IndexOf(toRemove);
            if (s >= 0)
                {
                    result = odebraneVIN.Remove(s, toRemove.Length);                                           // Wynik obciecia polecenia CAN w formie Ciągu danych
                }
            String byteStr = result;                                                                     // zmiana ciagu danych na tabelę bajtów
            int ileBajtow = byteStr.Length / 2;
            byte[] tab = new byte[ileBajtow];

            for (int j = 0; j < ileBajtow; j++)
                {
                    String wyodrebnione = byteStr.Substring(j * 2, 2);
                    byte b = Convert.ToByte(wyodrebnione, 16);
                    tab[j] = b;

                    string hexValues = Convert.ToString(tab[j]);

                    int value = Convert.ToInt32(hexValues);                                                  // konwertowanie ASCII do TEKSTU VIN

                    string stringValue = Char.ConvertFromUtf32(value);
                    char charValue = (char)value;
                    string VIN1 = charValue.ToString();
                    textBoxVin.AppendText(VIN1);
                    
                if (textBoxVin.TextLength == 17)
                { 
                    string mileage = ReadZoneUDS("DBA2").Substring(6,8);
                    textBoxmileage.Text = Convert.ToInt32(mileage, 16) / 10 + " km";
                    UnlockIdentification();
                    if (!Directory.Exists(@"Logs"))
                    { Directory.CreateDirectory("Logs"); }
                    string path = @"Logs\Log-" + textBoxVin.Text + "-" + textBoxmileage.Text + ".txt";
                    if (!File.Exists(path))
                    {
                        using (StreamWriter sw = File.CreateText(path))
                        {
                            sw.WriteLine("Log");
                        }
                    }
                }
                }
        }
        private void LockIdentification()
        {
            buttonIdentifyVIN.Enabled = false;
            buttonIdentifyBSI.Enabled = false;
            buttonIdentifyCVM.Enabled = false;
            buttonIdentifyDAE.Enabled = false;
            buttonIdentifyAAS.Enabled = false;
            buttonIdentifyARTIV.Enabled = false;
            buttonIdentifyCOMBINE.Enabled = false;
            buttonIdentifyTELEMAT.Enabled = false;
            buttonIdentifyINJ.Enabled = false;
            buttonIdentifyBVA.Enabled = false;
            buttonReadFaults.Enabled = false;
            buttonClearFaults.Enabled = false;
        }
        private void UnlockIdentification()
        {
            buttonIdentifyVIN.Enabled = true;
            buttonIdentifyBSI.Enabled = true;
            buttonIdentifyCVM.Enabled = true;
            buttonIdentifyDAE.Enabled = true;
            buttonIdentifyAAS.Enabled = true;
            buttonIdentifyARTIV.Enabled = true;
            buttonIdentifyCOMBINE.Enabled = true;
            buttonIdentifyTELEMAT.Enabled = true;
            buttonIdentifyINJ.Enabled = true;
            buttonIdentifyBVA.Enabled = true;
            buttonReadFaults.Enabled = true;
            buttonClearFaults.Enabled = true;
        }
        private void UnlockCodingBSI()
        {
            buttonReadZoneBSI.Enabled = true;
            buttonStartCodingBSI.Enabled = true;
            buttonWriteZoneBSI.Enabled = true;
        }
        private void LockCodingBSI()
        {
            buttonReadZoneBSI.Enabled = false;
            buttonStartCodingBSI.Enabled = false;
            buttonWriteZoneBSI.Enabled = false;
        }
        private void UnlockCodingCVM()
        {
            buttonReadCodingCVM.Enabled = true;
            buttonReadZoneCVM.Enabled = true;
            buttonWriteCodingCVM.Enabled = true;
        }
        private void LockCodingCVM()
        {
            buttonReadCodingCVM.Enabled = false;
            buttonReadZoneCVM.Enabled = false;
            buttonWriteCodingCVM.Enabled = false;
        }
        private void UnlockCodingDAE()
        {
            buttonReadCodingDAE.Enabled = true;
            buttonWriteCodingDAE.Enabled = true;
            buttonReadZoneDAE.Enabled = true;
        }
        private void LockCodingDAE()
        {
            buttonReadCodingDAE.Enabled = false;
            buttonWriteCodingDAE.Enabled = false;
            buttonReadZoneDAE.Enabled = false;
        }
        private void UnlockCodingAAS()
        {
            buttonReadZoneAAS.Enabled = true;
            buttonReadCodingAAS.Enabled = true;
            buttonWriteCodingAAS.Enabled = true;
        }
        private void LockCodingAAS()
        {
            buttonReadZoneAAS.Enabled = false;
            buttonReadCodingAAS.Enabled = false;
            buttonWriteCodingAAS.Enabled = false;
        }
        private void UnlockCodingARTIV()
        {
            buttonReadZoneARTIV.Enabled = true;
            buttonReadCodingARTIV.Enabled = true;
            buttonWriteCodingARTIV.Enabled = true;
        }
        private void LockCodingARTIV()
        {
            buttonReadZoneARTIV.Enabled = false;
            buttonReadCodingARTIV.Enabled = false;
            buttonWriteCodingARTIV.Enabled = false;
        }
        private void UnlockCodingCOMBINE()
        {
            buttonReadZoneCOMBINE.Enabled = true;
        }
        private void LockCodingCOMBINE()
        {
            buttonReadZoneCOMBINE.Enabled = false;
        }
        private void UnlockCodingTELEMAT()
        {
            buttonReadZoneTELEMAT.Enabled = true;
            buttonWriteCodingTELEMAT.Enabled = true;
        }
        private void LockCodingTELEMAT()
        {
            buttonReadZoneTELEMAT.Enabled = false;
            buttonWriteCodingTELEMAT.Enabled = false;
        }
        private void UnlockCodingINJ()
        {
            buttonReadZoneINJ.Enabled = true;
        }
        private void LockCodingINJ()
        {
            buttonReadZoneINJ.Enabled = false;
        }
        private void UnlockCodingBVA()
        {
            buttonReadZoneBVA.Enabled = true;
        }
        private void LockCodingBVA()
        {
            buttonReadZoneBVA.Enabled = false;
        }
        private string ConnectModuleUDS(string type)
        {
            textBoxInfo.Clear(); 
            spArduino.WriteLine(String.Format("1001"));
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1001") + Environment.NewLine;
            spArduino.WriteLine(String.Format(type));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " " + String.Format(type) + Environment.NewLine;
            Task.Delay(10).Wait();
            spArduino.WriteLine(String.Format("1003"));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003") + Environment.NewLine;
            Task.Delay(50).Wait();
            spArduino.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            string odpowiedz = serialData;
            return odpowiedz;
        }
        private string ConnectModuleKWPHAB(string type)
        {
            textBoxInfo.Clear();
            spArduino.WriteLine(String.Format("1001"));
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1001") + Environment.NewLine;
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format(type));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " " + String.Format(type) + Environment.NewLine;
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format("10C0"));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 10C0") + Environment.NewLine;
            Thread.Sleep(500);
            string odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + String.Format(odpowiedz) + Environment.NewLine;
            return odpowiedz;
        }
        private string ConnectModuleKWP(string type)
        {
            textBoxInfo.Clear(); 
            spArduino.WriteLine(String.Format("1001"));
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1001") + Environment.NewLine;
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format(type));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " " + String.Format(type) + Environment.NewLine;
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format("81"));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 81") + Environment.NewLine;
            Thread.Sleep(500);
            string odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + String.Format(odpowiedz) + Environment.NewLine;
            return odpowiedz;
        }
        private string ReadZoneUDS(string zone)
        {
            spArduino.WriteLine("22" + zone);
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 22" + zone + Environment.NewLine;
            Thread.Sleep(500);
            string odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odpowiedz + Environment.NewLine;
            return odpowiedz;
        }
        private string WriteZoneUDS(string zone,string value)
        {
            spArduino.WriteLine("2E" + zone + value);
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 2E" + zone + value + Environment.NewLine;
            Thread.Sleep(500);
            string odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odpowiedz + Environment.NewLine;
            return odpowiedz;

        }
        private string ReadZoneKWP(string zone)
        {
            spArduino.WriteLine("21" + zone);
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 21" + zone + Environment.NewLine;
            Thread.Sleep(500);
            string odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odpowiedz + Environment.NewLine;
            return odpowiedz;
        }
        public void ButtonIdentifyBSI_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to BSI" + Environment.NewLine;
            string odpowiedz = ConnectModuleUDS(BSI);
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + String.Format(odpowiedz) + Environment.NewLine;
            string odebraneBSIZA = ReadZoneUDS("F080");
            string odebraneBSIZI = ReadZoneUDS("F0FE");
            string[] RefBSIZI = { odebraneBSIZI.Substring(18, 6), odebraneBSIZI.Substring(26, 2), odebraneBSIZI.Substring(28, 2), odebraneBSIZI.Substring(30, 2), odebraneBSIZI.Substring(32, 6), odebraneBSIZI.Substring(46, 2), odebraneBSIZI.Substring(48, 6) };
            textBoxSWBSI.Text = "96" + RefBSIZI[6] + "80";
            textBoxHWBSI.Text = odebraneBSIZA.Substring(20, 10);
            int TD = Convert.ToInt32(RefBSIZI[4].Substring(0, 2), 16);
            int TM = Convert.ToInt32(RefBSIZI[4].Substring(2, 2), 16);
            int TY = Convert.ToInt32(RefBSIZI[4].Substring(4, 2), 16);
            string TDstring = TD.ToString();
            string TMstring = TM.ToString();
            string TYstring = "20" + TY.ToString(); 
            if (RefBSIZI[4].Substring(0, 2) == "FF")
            {
                TDstring = RefBSIZI[4].Substring(0, 2);
                TMstring = RefBSIZI[4].Substring(2, 2);
                TYstring = RefBSIZI[4].Substring(4, 2);
            }
            string typbsi = odebraneBSIZI.Substring(14, 4);// wydobycie z ciągu sekcji 4 bajtów typu modułu z odebranych danych
            textBoxTypBSI.Text = typbsi;
            if (typbsi == "13B3")
                {                                          // warunek przypisania typu modułu do kodu Bajtowego
                    textBoxTypBSI.Text = "DELPHI BSI2010_EV";
                    richTextBoxLog.Text += Environment.NewLine + "BSI: " + string.Format(textBoxTypBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefBSIZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefBSIZI[2]) +"." + string.Format(RefBSIZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefBSIZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefBSIZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefBSIZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefBSIZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    CodingKeyBSI = "B4E0";
                    UnlockCodingBSI();
                }
            else if (typbsi == "06B3")
                {
                    textBoxTypBSI.Text = "VALEO NOx";
                    richTextBoxLog.Text += Environment.NewLine + "BSI: " + string.Format(textBoxTypBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefBSIZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefBSIZI[2]) + "." + string.Format(RefBSIZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefBSIZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefBSIZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefBSIZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefBSIZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingBSI();
                }
            else if (typbsi == "0DB3")
                {
                    textBoxTypBSI.Text = "CONTINENTAL Q0x";
                    richTextBoxLog.Text += Environment.NewLine + "BSI: " + string.Format(textBoxTypBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefBSIZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefBSIZI[2]) + "." + string.Format(RefBSIZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefBSIZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefBSIZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefBSIZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefBSIZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingBSI();
                }
            else
                {
                    textBoxTypBSI.Text = "Unknown " + typbsi;
                    richTextBoxLog.Text += Environment.NewLine + "BSI: " + string.Format(textBoxTypBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefBSIZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefBSIZI[2]) + "." + string.Format(RefBSIZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefBSIZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWBSI.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefBSIZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefBSIZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefBSIZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingBSI();
                }
        }
        public void ButtonReadZoneBSI_Click(object sender, EventArgs e)
        {
            if (textBoxZoneBSI.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneBSI.Text);
                string toRemove = "62" + textBoxZoneBSI.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueBSI.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueBSI.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
                {
                textBoxInfo.Text = "Please select zone";
                }
        }
        public void ButtonStartCodingBSI_Click(object sender, EventArgs e)
        {
            spArduino.WriteLine(String.Format(":" + String.Format(CodingKeyBSI) + ":03:03"));
            Thread.Sleep(100);
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > :" + String.Format(CodingKeyBSI) + ":03:03");
        }
        private void ButtonWriteZoneBSI_Click(object sender, EventArgs e)
        {
            if (textBoxZoneNewValueBSI.Text == "")
            {
                textBoxInfo.Text = "New coding not written";
            }
            else if (textBoxZoneValueBSI.Text == textBoxZoneNewValueBSI.Text)
            {
                textBoxInfo.Text = "Coding wasn't changed";
            }
            else if (textBoxZoneValueBSI.Text != textBoxZoneNewValueBSI.Text)
            {
                WriteZoneUDS(textBoxZoneBSI.Text, textBoxZoneNewValueBSI.Text);
            }
        }
        public void ButtonIdentifyCVM_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to CVM" + Environment.NewLine;
            string odpowiedz = ConnectModuleUDS(CVM);
            if (odpowiedz.Substring(0, 2) == "OK")
            {
                string message = "Module not installed in car";
                textBoxInfo.Text = message;
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " " + String.Format(message) + Environment.NewLine;
                buttonIdentifyCVM.Enabled = false;
                MessageBox.Show(message);
            }
            else
            {
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + String.Format(odpowiedz) + Environment.NewLine;
                string odebraneCVMZA = ReadZoneUDS("F080");
                string odebraneCVMZI = ReadZoneUDS("F0FE");
                string[] RefCVMZI = { odebraneCVMZI.Substring(18, 6), odebraneCVMZI.Substring(26, 2), odebraneCVMZI.Substring(28, 2), odebraneCVMZI.Substring(30, 2), odebraneCVMZI.Substring(32, 6), odebraneCVMZI.Substring(46, 2), odebraneCVMZI.Substring(48, 6) };
                textBoxSWCVM.Text = "96" + RefCVMZI[6] + "80";
                textBoxHWCVM.Text = odebraneCVMZA.Substring(20, 10);
                int TD = Convert.ToInt32(RefCVMZI[4].Substring(0, 2), 16);
                int TM = Convert.ToInt32(RefCVMZI[4].Substring(2, 2), 16);
                int TY = Convert.ToInt32(RefCVMZI[4].Substring(4, 2), 16);
                string TDstring = TD.ToString();
                string TMstring = TM.ToString();
                string TYstring = "20" + TY.ToString();
                if (RefCVMZI[4].Substring(0, 2) == "FF")
                {
                    TDstring = RefCVMZI[4].Substring(0, 2);
                    TMstring = RefCVMZI[4].Substring(2, 2);
                    TYstring = RefCVMZI[4].Substring(4, 2);
                }
                string typcvm = odebraneCVMZA.Substring(47, 3);                                         // wydobycie z ciągu sekcji 4 bajtów typu BSI z odebranych danych
                textBoxTypCVM.Text = typcvm;

                if (typcvm == "199")
                {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                    textBoxTypCVM.Text = "CVM_2";
                    richTextBoxLog.Text += Environment.NewLine + "CVM: " + string.Format(textBoxTypCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefCVMZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefCVMZI[2]) + "." + string.Format(RefCVMZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefCVMZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefCVMZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefCVMZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefCVMZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    CodingKeyCVM = "E2E5";
                    UnlockCodingCVM();
                }
                else if (typcvm == "179")
                {
                    textBoxTypCVM.Text = "CVM_3";
                    richTextBoxLog.Text += Environment.NewLine + "CVM: " + string.Format(textBoxTypCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefCVMZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefCVMZI[2]) + "." + string.Format(RefCVMZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefCVMZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefCVMZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefCVMZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefCVMZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    CodingKeyCVM = "E2E5";
                    UnlockCodingCVM();
                }
                else
                {
                    textBoxTypCVM.Text = "Unknown " + typcvm;
                    richTextBoxLog.Text += Environment.NewLine + "CVM: " + string.Format(textBoxTypCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefCVMZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefCVMZI[2]) + "." + string.Format(RefCVMZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefCVMZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWCVM.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefCVMZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefCVMZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefCVMZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingCVM();
                }
            }
        }
        private void ButtonReadCodingCVM_Click(object sender, EventArgs e)
        {
            if (textBoxTypCVM.Text == "CVM_2")
            {
                string odebraneCodingCVM = ReadZoneUDS("2100"); 
                string toRemove3 = String.Format("622100");
                int s2 = odebraneCodingCVM.IndexOf(toRemove3);
                string resultCodingCVM = odebraneCodingCVM.Remove(s2, toRemove3.Length);
                textBoxCVMCoding.Text = resultCodingCVM;
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
            else if (textBoxTypCVM.Text == "CVM_3")
            {
                string odebraneCodingCVM = ReadZoneUDS("2101"); 
                string toRemove3 = String.Format("622101");
                int s2 = odebraneCodingCVM.IndexOf(toRemove3);
                string resultCodingCVM = odebraneCodingCVM.Remove(s2, toRemove3.Length);
                textBoxCVMCoding.Text = resultCodingCVM;
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
            spArduino.WriteLine(String.Format("1001"));                                        // reset komunikacji
            Thread.Sleep(100);
        }
        public void ButtonWriteCodingCVM_Click(object sender, EventArgs e)
        {
            if (textBoxCVMNewCoding.Text == "")
            {
                textBoxInfo.Text = "New coding not written";
            }
            else if (textBoxCVMCoding.Text == textBoxCVMNewCoding.Text)
            {
                textBoxInfo.Text = "Coding wasn't changed";
            }
            else if (textBoxCVMCoding.Text != textBoxCVMNewCoding.Text)
            {
                if (textBoxTypCVM.Text == "CVM_2")
                {
                    zone = "2100";
                }
                else if (textBoxTypCVM.Text == "CVM_3")
                {
                    zone = "2101";
                }
                spArduino.WriteLine(":" + CodingKeyCVM + ":03:03");
                Thread.Sleep(100);
                string odebrane = serialData;
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane + Environment.NewLine;
                if (odebrane.Substring(0, 4) == "6704")
                {
                        string command = "2E" + String.Format(zone) + textBoxCVMNewCoding.Text;
                        spArduino.WriteLine(String.Format(command));
                        richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > " + String.Format(command) + Environment.NewLine;
                        Thread.Sleep(100);
                        string odebrane3 = serialData;
                        richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane3 + Environment.NewLine;
                        //wyslac ramke 2E2901FD000000010101 aby nie bylo bledu B1003 zabezpieczonego kodowania
                        Thread.Sleep(200); 
                        spArduino.WriteLine("2E2901FD000000010101");
                        richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 2E290100000000010101" + Environment.NewLine;
                        Thread.Sleep(100);
                        string odebrane4 = serialData;
                        richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane4 + Environment.NewLine;
                }
                else
                {
                    textBoxInfo.Text = "Coding conditions not met";
                }
            }
        }
        private void ButtonReadZoneCVM_Click(object sender, EventArgs e)
        {
            if (textBoxZoneCVM.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneCVM.Text);
                string toRemove = "62" + textBoxZoneCVM.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueCVM.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueCVM.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
            {
                textBoxInfo.Text = "Please select zone";
            }
        }
        public void ButtonIdentifyDAE_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to DAE" + Environment.NewLine;
            string odpowiedz = ConnectModuleKWP(DAE);
            if (odpowiedz.Substring(0, 2) == "C1")
            {
                string odebraneDAEZA = ReadZoneKWP("80");
                string odebraneDAEZI = ReadZoneKWP("FE");
                string[] RefDAEZA = { odebraneDAEZA.Substring(4, 10), odebraneDAEZA.Substring(16, 2), odebraneDAEZA.Substring(18, 10), odebraneDAEZA.Substring(28, 4) };
                string[] RefDAEZI = { odebraneDAEZI.Substring(16, 6), odebraneDAEZI.Substring(24, 2), odebraneDAEZI.Substring(26, 4), odebraneDAEZI.Substring(30, 6), odebraneDAEZI.Substring(44, 2), odebraneDAEZI.Substring(46, 6) };
                textBoxSWDAE.Text = "96" + RefDAEZI[5] + "80";
                textBoxTypDAE.Text = "DAE_BVH2";
                richTextBoxLog.Text += Environment.NewLine + "DAE: " + string.Format(textBoxTypDAE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Software Version: " + RefDAEZA[3].Substring(0, 2) + "." + RefDAEZA[3].Substring(2, 2) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefDAEZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWDAE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefDAEZI[2].Substring(0, 2)) + "." + string.Format(RefDAEZI[2].Substring(2, 2)) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefDAEZI[4]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + Convert.ToInt32(RefDAEZI[3].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[3].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[3].Substring(4, 2), 16) + Environment.NewLine;
                //richTextBoxLog.Text += "HW: " + string.Format(textBoxHWCVM.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefDAEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                CodingKeyDAE = "2305";
                UnlockCodingDAE();
            }
            else
            {
                odpowiedz = ConnectModuleUDS(DAE);
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + String.Format(odpowiedz) + Environment.NewLine;
                string odebraneDAEZA = ReadZoneUDS("F080");
                string odebraneDAEZI = ReadZoneUDS("F0FE");
                string[] RefDAEZI = { odebraneDAEZI.Substring(18, 6), odebraneDAEZI.Substring(26, 2), odebraneDAEZI.Substring(28, 2), odebraneDAEZI.Substring(30, 2), odebraneDAEZI.Substring(32, 6), odebraneDAEZI.Substring(46, 2), odebraneDAEZI.Substring(48, 6) };
                textBoxSWDAE.Text = "96" + RefDAEZI[6] + "80";
                textBoxHWDAE.Text = odebraneDAEZA.Substring(20, 10);
                int TD = Convert.ToInt32(RefDAEZI[4].Substring(0, 2), 16);
                int TM = Convert.ToInt32(RefDAEZI[4].Substring(2, 2), 16);
                int TY = Convert.ToInt32(RefDAEZI[4].Substring(4, 2), 16);
                string TDstring = TD.ToString();
                string TMstring = TM.ToString();
                string TYstring = "20" + TY.ToString();
                if (RefDAEZI[4].Substring(0, 2) == "FF")
                {
                    TDstring = RefDAEZI[4].Substring(0, 2);
                    TMstring = RefDAEZI[4].Substring(2, 2);
                    TYstring = RefDAEZI[4].Substring(4, 2);
                }
                string typdae = odebraneDAEZI.Substring(14, 4);// wydobycie z ciągu sekcji 4 bajtów typu modułu z odebranych danych
                textBoxTypDAE.Text = typdae;
                if (typdae == "796C")
                {
                    textBoxTypDAE.Text = "DAE_UDS";
                    richTextBoxLog.Text += Environment.NewLine + "DAE: " + string.Format(textBoxTypDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefDAEZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefDAEZI[2]) + "." + string.Format(RefDAEZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefDAEZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefDAEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingDAE();
                }
                else if (typdae == "136A")
                {
                    textBoxTypDAE.Text = "?";
                    richTextBoxLog.Text += Environment.NewLine + "DAE: " + string.Format(textBoxTypDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefDAEZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefDAEZI[2]) + "." + string.Format(RefDAEZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefDAEZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefDAEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingDAE();
                }
                else if (typdae == "215B")
                {
                    textBoxTypDAE.Text = "GEP_UDS";
                    richTextBoxLog.Text += Environment.NewLine + "DAE: " + string.Format(textBoxTypDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefDAEZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefDAEZI[2]) + "." + string.Format(RefDAEZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefDAEZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefDAEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingDAE();
                }
                else if (typdae == "215D")
                {
                    textBoxTypDAE.Text = "DAE_UDS";
                    richTextBoxLog.Text += Environment.NewLine + "DAE: " + string.Format(textBoxTypDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefDAEZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefDAEZI[2]) + "." + string.Format(RefDAEZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefDAEZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefDAEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingDAE();
                }
                else
                {
                    textBoxTypDAE.Text = "Unknown " + typdae;
                    richTextBoxLog.Text += Environment.NewLine + "DAE: " + string.Format(textBoxTypDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefDAEZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefDAEZI[2]) + "." + string.Format(RefDAEZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefDAEZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWDAE.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefDAEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingDAE();
                }

            }
        }
        public void ButtonReadCodingDAE_Click(object sender, EventArgs e)
        {
            if (textBoxTypDAE.Text == "DAE_BVH2")
            {
                string odebrane = ReadZoneKWP("A0");
                string toRemove4 = String.Format("61A0");
                int s2 = odebrane.IndexOf(toRemove4);                                          // Zapis string.Empty lub string = ""; to to samo
                string CodingDAE = odebrane.Remove(s2, toRemove4.Length);
                textBoxDAECoding.Text = CodingDAE;
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
            else if (textBoxTypDAE.Text == "DAE_UDS")
            {
                string odebrane = ReadZoneUDS("2101");
                string toRemove4 = String.Format("622101");
                int s2 = odebrane.IndexOf(toRemove4);                                          // Zapis string.Empty lub string = ""; to to samo
                string CodingDAE = odebrane.Remove(s2, toRemove4.Length);
                textBoxDAECoding.Text = CodingDAE;
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
            else
            {
                textBoxInfo.Text = "Select zone";
                richTextBoxLog.Text += Environment.NewLine + "Select zone" + Environment.NewLine;
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
        }
        private void ButtonReadZoneDAE_Click(object sender, EventArgs e)
        {
            if (textBoxZoneDAE.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneDAE.Text);
                string toRemove = "62" + textBoxZoneDAE.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueDAE.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueDAE.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
            {
                textBoxInfo.Text = "Please select zone";
            }
        }
        public void ButtonWriteCodingDAE_Click(object sender, EventArgs e)
        {
            spArduino.WriteLine(String.Format("81"));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 81") + Environment.NewLine;
            Thread.Sleep(500);
            string odebrane = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane + Environment.NewLine;
            spArduino.WriteLine(String.Format(":" + CodingKeyDAE + ":83:C0"));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" >:" + CodingKeyDAE + ":83:C0") + Environment.NewLine;
            Thread.Sleep(500); 
            string odebrane1 = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane1 + Environment.NewLine;
            string str = "34A00000000605" + textBoxNewCodingDAE.Text + "FD000000";
            byte[] BTS = StringToByteArray(str);
            ushort calc_crc = Crc16_x25(BTS, BTS.Length);
            calc_crc = (ushort)ROL(calc_crc, 8);
            richTextBoxLog.Text += $"CRC16-x25 : {calc_crc.ToString("X")}" + Environment.NewLine;
            string CodingMessage = str + calc_crc.ToString("X");
            spArduino.WriteLine(String.Format(CodingMessage));
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > ") + CodingMessage + Environment.NewLine;
            Thread.Sleep(500);
            string odebrane2 = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane2 + Environment.NewLine;

        }
        public void ButtonIdentifyAAS_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to AAS" + Environment.NewLine;
            ConnectModuleUDS(AAS);
            string odebraneAASZA = ReadZoneUDS("F080");
            string odebraneAASZI = ReadZoneUDS("F0FE");
            string[] RefAASZI = { odebraneAASZI.Substring(18, 6), odebraneAASZI.Substring(26, 2), odebraneAASZI.Substring(28, 2), odebraneAASZI.Substring(30, 2), odebraneAASZI.Substring(32, 6), odebraneAASZI.Substring(46, 2), odebraneAASZI.Substring(48, 6) };
            textBoxSWAAS.Text = "96" + RefAASZI[6] + "80";
            textBoxHWAAS.Text = odebraneAASZA.Substring(20, 10);
            int TD = Convert.ToInt32(RefAASZI[4].Substring(0, 2), 16);
            int TM = Convert.ToInt32(RefAASZI[4].Substring(2, 2), 16);
            int TY = Convert.ToInt32(RefAASZI[4].Substring(4, 2), 16);
            string TDstring = TD.ToString();
            string TMstring = TM.ToString();
            string TYstring = "20" + TY.ToString();
            if (RefAASZI[4].Substring(0, 2) == "FF")
            {
                TDstring = RefAASZI[4].Substring(0, 2);
                TMstring = RefAASZI[4].Substring(2, 2);
                TYstring = RefAASZI[4].Substring(4, 2);
            }
            string typAAS = odebraneAASZA.Substring(46, 4);                                          // wydobycie z ciągu sekcji 4 bajtów typu BSI z odebranych danych
            textBoxTypAAS.Text = typAAS;
            if (typAAS == "2199")
            {
                textBoxTypAAS.Text = "AAS_UDS_G5";
                richTextBoxLog.Text += Environment.NewLine + "AAS: " + string.Format(textBoxTypAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefAASZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefAASZI[2]) + "." + string.Format(RefAASZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefAASZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefAASZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefAASZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefAASZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyAAS = "0000";
                UnlockCodingAAS();
            }
            else if (typAAS == "8199")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypAAS.Text = "CPK_UDS_G5";
                richTextBoxLog.Text += Environment.NewLine + "AAS: " + string.Format(textBoxTypAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefAASZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefAASZI[2]) + "." + string.Format(RefAASZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefAASZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefAASZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefAASZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefAASZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                CodingKeyAAS = "D1F5";
                UnlockCodingAAS();
            }
            else if (typAAS == "4599")
            {
                textBoxTypAAS.Text = "AAS_G4";
                richTextBoxLog.Text += Environment.NewLine + "AAS: " + string.Format(textBoxTypAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefAASZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefAASZI[2]) + "." + string.Format(RefAASZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefAASZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefAASZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefAASZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefAASZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //               string CodingKeyAAS = "xxxx";
                UnlockCodingAAS();
            }
            else if (typAAS == "FFFF")
            {
                textBoxTypAAS.Text = "AAS_UDS_G6";
                richTextBoxLog.Text += Environment.NewLine + "AAS: " + string.Format(textBoxTypAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefAASZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefAASZI[2]) + "." + string.Format(RefAASZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefAASZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefAASZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefAASZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefAASZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //               string CodingKeyAAS = "B6F0";
                UnlockCodingAAS();
            }
            else
            {
                textBoxTypAAS.Text = "Unknown " + typAAS;
                richTextBoxLog.Text += Environment.NewLine + "AAS: " + string.Format(textBoxTypAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefAASZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefAASZI[2]) + "." + string.Format(RefAASZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefAASZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWAAS.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefAASZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefAASZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefAASZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                UnlockCodingAAS();
            }
        }
        private void ButtonReadCodingAAS_Click(object sender, EventArgs e)
        {
            if (textBoxTypAAS.Text == "CPK_UDS_G5")
            {
                string odebraneCodingAAS = ReadZoneUDS("2101");
                string toRemove3 = String.Format("622101");
                int s2 = odebraneCodingAAS.IndexOf(toRemove3);
                string resultAASCoding = odebraneCodingAAS.Remove(s2, toRemove3.Length);
                textBoxAASCoding.Text = resultAASCoding;
            }
            else if (textBoxTypAAS.Text == "AAS_UDS_G6")
            {
                string odebraneCodingAAS = ReadZoneUDS("2101");
                string toRemove3 = String.Format("622101");
                int s2 = odebraneCodingAAS.IndexOf(toRemove3);
                string resultAASCoding = odebraneCodingAAS.Remove(s2, toRemove3.Length);
                textBoxAASCoding.Text = resultAASCoding;
            }
            else
            {
                textBoxInfo.Text = "Select zone";
                richTextBoxLog.Text += Environment.NewLine + "Select zone" + Environment.NewLine;
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            }
        }
        private void ButtonWriteCodingAAS_Click(object sender, EventArgs e)
        {
            if (textBoxAASNewCoding.Text == "")
            {
                textBoxInfo.Text = "New coding not written";
            }
            else if (textBoxAASCoding.Text == textBoxAASNewCoding.Text)
            {
                textBoxInfo.Text = "Coding wasn't changed";
            }
            else if (textBoxAASCoding.Text != textBoxAASNewCoding.Text)
            {
                if (textBoxTypAAS.Text == "AAS_UDS_G5")
                {
                    zone = "2100";
                }
                else if (textBoxTypAAS.Text == "CPK_UDS_G5")
                {
                    zone = "2101";
                }
                spArduino.WriteLine(":" + CodingKeyAAS + ":03:03");
                Thread.Sleep(100);
                string odebrane = serialData;
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane + Environment.NewLine;
                if (odebrane.Substring(0, 4) == "6704")
                {
                    string command = "2E" + zone + textBoxAASNewCoding.Text;
                    spArduino.WriteLine(String.Format(command));
                    richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > " + String.Format(command) + Environment.NewLine;
                    Thread.Sleep(100);
                    string odebrane3 = serialData;
                    richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane3 + Environment.NewLine;
                    //wyslac ramke 2E2901FD000000010101 aby nie bylo bledu B1003 zabezpieczonego kodowania
                    spArduino.WriteLine("2E2901FD000000010101");
                    richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 2E290100000000010101" + Environment.NewLine;
                    Thread.Sleep(100);
                    string odebrane4 = serialData;
                    richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane4 + Environment.NewLine;
                }
                else
                {
                    textBoxInfo.Text = "Coding conditions not met";
                }
            }
        }
        private void ButtonReadZoneAAS_Click(object sender, EventArgs e)
        {
            if (textBoxZoneAAS.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneAAS.Text);
                string toRemove = "62" + textBoxZoneAAS.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueAAS.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueAAS.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
            {
                textBoxInfo.Text = "Please select zone";
            }
        }
        private void ButtonIdentifyARTIV_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to ARTIV" + Environment.NewLine;
            string odpowiedz = ConnectModuleUDS(ARTIV);
            if (odpowiedz.Substring(0, 2) == "OK")
            {
                string message = "Module not installed in car";
                textBoxInfo.Text = message;
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " " + String.Format(message) + Environment.NewLine;
                buttonIdentifyARTIV.Enabled = false;
                MessageBox.Show(message);
            }
            else
            {
                string odebraneARTIVZA = ReadZoneUDS("F080");
                string odebraneARTIVZI = ReadZoneUDS("F0FE");
                string[] RefARTIVZI = { odebraneARTIVZI.Substring(18, 6), odebraneARTIVZI.Substring(26, 2), odebraneARTIVZI.Substring(28, 2), odebraneARTIVZI.Substring(30, 2), odebraneARTIVZI.Substring(32, 6), odebraneARTIVZI.Substring(46, 2), odebraneARTIVZI.Substring(48, 6) };
                textBoxSWARTIV.Text = "96" + RefARTIVZI[6] + "80";
                textBoxHWARTIV.Text = odebraneARTIVZA.Substring(20, 10);
                int TD = Convert.ToInt32(RefARTIVZI[4].Substring(0, 2), 16);
                int TM = Convert.ToInt32(RefARTIVZI[4].Substring(2, 2), 16);
                int TY = Convert.ToInt32(RefARTIVZI[4].Substring(4, 2), 16);
                string TDstring = TD.ToString();
                string TMstring = TM.ToString();
                string TYstring = "20" + TY.ToString();
                if (RefARTIVZI[4].Substring(0, 2) == "FF")
                {
                    TDstring = RefARTIVZI[4].Substring(0, 2);
                    TMstring = RefARTIVZI[4].Substring(2, 2);
                    TYstring = RefARTIVZI[4].Substring(4, 2);
                }
                string typartiv = odebraneARTIVZA.Substring(47, 3);                                           // wydobycie z ciągu sekcji 4 bajtów typu BSI z odebranych danych
                textBoxTypARTIV.Text = typartiv;
                if (typartiv == "FFF")
                {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                    textBoxTypARTIV.Text = "ARTIV_UDS";
                    richTextBoxLog.Text += Environment.NewLine + "ARTIV: " + string.Format(textBoxTypARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefARTIVZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefARTIVZI[2]) + "." + string.Format(RefARTIVZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefARTIVZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefARTIVZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefARTIVZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefARTIVZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    //string CodingKeyARTIV = "xxxx";
                    UnlockCodingARTIV();
                }
                else if (typartiv == "153")
                {
                    textBoxTypARTIV.Text = "RADAR_AV_4";
                    richTextBoxLog.Text += Environment.NewLine + "ARTIV: " + string.Format(textBoxTypARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefARTIVZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefARTIVZI[2]) + "." + string.Format(RefARTIVZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefARTIVZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefARTIVZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefARTIVZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefARTIVZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingARTIV();
                }
                else
                {
                    textBoxTypARTIV.Text = "Unknown " + typartiv;
                    richTextBoxLog.Text += Environment.NewLine + "ARTIV: " + string.Format(textBoxTypARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefARTIVZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefARTIVZI[2]) + "." + string.Format(RefARTIVZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefARTIVZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWARTIV.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefARTIVZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefARTIVZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefARTIVZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingARTIV();
                }
            }
        }
        private void ButtonReadCodingARTIV_Click(object sender, EventArgs e)
        {
            if (textBoxTypARTIV.Text == "ARTIV_UDS")
            {
                string odebraneCodingARTIV = ReadZoneUDS("2101");
                string toRemove3 = String.Format("622101");
                int s2 = odebraneCodingARTIV.IndexOf(toRemove3);
                string resultCodingARTIV = odebraneCodingARTIV.Remove(s2, toRemove3.Length);
                textBoxCodingARTIV.Text = resultCodingARTIV;
            }
            else if (textBoxTypARTIV.Text == "RADAR_AV_4")
            {
                string odebraneCodingARTIV = ReadZoneUDS("2101");
                string toRemove3 = String.Format("622101");
                int s2 = odebraneCodingARTIV.IndexOf(toRemove3);
                string resultCodingARTIV = odebraneCodingARTIV.Remove(s2, toRemove3.Length);
                textBoxCodingARTIV.Text = resultCodingARTIV;
            }
            }
        private void ButtonReadZoneARTIV_Click(object sender, EventArgs e)
        {
            if (textBoxZoneARTIV.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneARTIV.Text);
                string toRemove = "62" + textBoxZoneARTIV.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueARTIV.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueARTIV.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
            {
                textBoxInfo.Text = "Please select zone";
            }
        }
        private void ButtonIdentifyCOMBINE_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to COMBINE" + Environment.NewLine;
            ConnectModuleUDS(COMBINE);
            string odebraneCOMBINEZA = ReadZoneUDS("F080");
            string odebraneCOMBINEZI = ReadZoneUDS("F0FE");
            string[] RefCOMBINEZI = { odebraneCOMBINEZI.Substring(18, 6), odebraneCOMBINEZI.Substring(26, 2), odebraneCOMBINEZI.Substring(28, 2), odebraneCOMBINEZI.Substring(30, 2), odebraneCOMBINEZI.Substring(32, 6), odebraneCOMBINEZI.Substring(46, 2), odebraneCOMBINEZI.Substring(48, 6) };
            textBoxSWCOMBINE.Text = "96" + RefCOMBINEZI[6] + "80";
            textBoxHWCOMBINE.Text = odebraneCOMBINEZA.Substring(20, 10);
            int TD = Convert.ToInt32(RefCOMBINEZI[4].Substring(0, 2), 16);
            int TM = Convert.ToInt32(RefCOMBINEZI[4].Substring(2, 2), 16);
            int TY = Convert.ToInt32(RefCOMBINEZI[4].Substring(4, 2), 16);
            string TDstring = TD.ToString();
            string TMstring = TM.ToString();
            string TYstring = "20" + TY.ToString();
            if (RefCOMBINEZI[4].Substring(0, 2) == "FF")
            {
                TDstring = RefCOMBINEZI[4].Substring(0, 2);
                TMstring = RefCOMBINEZI[4].Substring(2, 2);
                TYstring = RefCOMBINEZI[4].Substring(4, 2);
            }
            string typcombine = odebraneCOMBINEZI.Substring(14, 4);
            textBoxTypCOMBINE.Text = typcombine;
            if (typcombine == "02FC")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypCOMBINE.Text = "CIROCCO";
                richTextBoxLog.Text += Environment.NewLine + "COMBINE: " + string.Format(textBoxTypCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefCOMBINEZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefCOMBINEZI[2]) + "." + string.Format(RefCOMBINEZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefCOMBINEZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefCOMBINEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefCOMBINEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefCOMBINEZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                CodingKeyCOMBINE = "FAFA";
                UnlockCodingCOMBINE();
            }
            else if (typcombine == "26FC")
            {
                textBoxTypCOMBINE.Text = "COMBINE_UDS_EV";
                richTextBoxLog.Text += Environment.NewLine + "COMBINE: " + string.Format(textBoxTypCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefCOMBINEZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefCOMBINEZI[2]) + "." + string.Format(RefCOMBINEZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefCOMBINEZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefCOMBINEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefCOMBINEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefCOMBINEZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                UnlockCodingCOMBINE();
            }
            else
            {
                textBoxTypCOMBINE.Text = "Unknown " + typcombine;
                richTextBoxLog.Text += Environment.NewLine + "COMBINE: " + string.Format(textBoxTypCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefCOMBINEZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefCOMBINEZI[2]) + "." + string.Format(RefCOMBINEZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefCOMBINEZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWCOMBINE.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefCOMBINEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefCOMBINEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefCOMBINEZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                UnlockCodingCOMBINE();
            }
        }
        private void ButtonReadZoneCOMBINE_Click(object sender, EventArgs e)
        {
            if (textBoxZoneCOMBINE.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneCOMBINE.Text);
                string toRemove = "62" + textBoxZoneCOMBINE.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueCOMBINE.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueCOMBINE.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
            {
                textBoxInfo.Text = "Please select zone";
            }
        }
        private void ButtonIdentifyTELEMAT_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to TELEMAT" + Environment.NewLine;
            string odpowiedz = ConnectModuleKWPHAB(TELEMAT);
            if (odpowiedz.Substring(0, 4) == "50C0")
            {
                string odebraneTELEMATZA = ReadZoneKWP("80");
                string odebraneTELEMATZI = ReadZoneKWP("FE");
                string[] RefTELEMATZA = { odebraneTELEMATZA.Substring(4, 10), odebraneTELEMATZA.Substring(16, 2), odebraneTELEMATZA.Substring(18, 10), odebraneTELEMATZA.Substring(28, 4) };
                string[] RefTELEMATZI = { odebraneTELEMATZI.Substring(16, 6), odebraneTELEMATZI.Substring(24, 2), odebraneTELEMATZI.Substring(26, 4), odebraneTELEMATZI.Substring(30, 6), odebraneTELEMATZI.Substring(44, 2), odebraneTELEMATZI.Substring(46, 6) };
                textBoxSWTELEMAT.Text = "96" + RefTELEMATZI[5] + "80";
                textBoxTypTELEMAT.Text = "RNEG";
                richTextBoxLog.Text += Environment.NewLine + "TELEMAT: " + string.Format(textBoxTypTELEMAT.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Software Version: " + RefTELEMATZA[3].Substring(0, 2) + "." + RefTELEMATZA[3].Substring(2, 2) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefTELEMATZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWTELEMAT.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefTELEMATZI[2].Substring(0, 2)) + "." + string.Format(RefTELEMATZI[2].Substring(2, 2)) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefTELEMATZI[4]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + Convert.ToInt32(RefTELEMATZI[3].Substring(0, 2), 16) + "." + Convert.ToInt32(RefTELEMATZI[3].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefTELEMATZI[3].Substring(4, 2), 16) + Environment.NewLine;
                //richTextBoxLog.Text += "HW: " + string.Format(textBoxHWCVM.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefTELEMATZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefTELEMATZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefTELEMATZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                CodingKeyTELEMAT = "ADDA";
                UnlockCodingTELEMAT();
            }
            else
            {
                odpowiedz = ConnectModuleUDS(TELEMAT);
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + String.Format(odpowiedz) + Environment.NewLine;
                string odebraneTELEMATZA = ReadZoneUDS("F080");
                string odebraneTELEMATZI = ReadZoneUDS("F0FE");
                string[] RefTELEMATZI = { odebraneTELEMATZI.Substring(18, 6), odebraneTELEMATZI.Substring(26, 2), odebraneTELEMATZI.Substring(28, 2), odebraneTELEMATZI.Substring(30, 2), odebraneTELEMATZI.Substring(32, 6), odebraneTELEMATZI.Substring(46, 2), odebraneTELEMATZI.Substring(48, 6) };
                textBoxSWTELEMAT.Text = "96" + RefTELEMATZI[6] + "80";
                textBoxHWTELEMAT.Text = odebraneTELEMATZA.Substring(20, 10);
                int TD = Convert.ToInt32(RefTELEMATZI[4].Substring(0, 2), 16);
                int TM = Convert.ToInt32(RefTELEMATZI[4].Substring(2, 2), 16);
                int TY = Convert.ToInt32(RefTELEMATZI[4].Substring(4, 2), 16);
                string TDstring = TD.ToString();
                string TMstring = TM.ToString();
                string TYstring = "20" + TY.ToString();
                if (RefTELEMATZI[4].Substring(0, 2) == "FF")
                {
                    TDstring = RefTELEMATZI[4].Substring(0, 2);
                    TMstring = RefTELEMATZI[4].Substring(2, 2);
                    TYstring = RefTELEMATZI[4].Substring(4, 2);
                }
                string typtelemat = odebraneTELEMATZI.Substring(14, 4);
                textBoxTypTELEMAT.Text = typtelemat;
                if (typtelemat == "0DF5")
                {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                    textBoxTypTELEMAT.Text = "NAC";
                    richTextBoxLog.Text += Environment.NewLine + "TELEMAT: " + string.Format(textBoxTypTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefTELEMATZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefTELEMATZI[2]) + "." + string.Format(RefTELEMATZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefTELEMATZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefTELEMATZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefTELEMATZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefTELEMATZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    CodingKeyTELEMAT = "D91C";
                    UnlockCodingTELEMAT();
                }
                else if (typtelemat == "03F5")
                {
                    textBoxTypTELEMAT.Text = "RCC";
                    richTextBoxLog.Text += Environment.NewLine + "TELEMAT: " + string.Format(textBoxTypTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefTELEMATZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefTELEMATZI[2]) + "." + string.Format(RefTELEMATZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefTELEMATZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefTELEMATZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefTELEMATZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefTELEMATZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    CodingKeyTELEMAT = "F107";
                    UnlockCodingTELEMAT();
                }
                else
                {
                    textBoxTypTELEMAT.Text = "Unknown " + typtelemat;
                    richTextBoxLog.Text += Environment.NewLine + "TELEMAT: " + string.Format(textBoxTypTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefTELEMATZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefTELEMATZI[2]) + "." + string.Format(RefTELEMATZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefTELEMATZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWTELEMAT.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefTELEMATZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefTELEMATZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefTELEMATZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingTELEMAT();
                }
            }
        }
        private void ButtonReadZoneTELEMAT_Click(object sender, EventArgs e)
        {
            if (textBoxZoneTELEMAT.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneTELEMAT.Text);
                string toRemove = "62" + textBoxZoneTELEMAT.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueTELEMAT.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueTELEMAT.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
            {
                textBoxInfo.Text = "Please select zone";
            }
        }
        private void buttonWriteCodingTELEMAT_Click(object sender, EventArgs e)
        {
            if (textBoxZoneNewValueTELEMAT.Text == "")
            {
                textBoxInfo.Text = "New coding not written";
            }
            else if (textBoxZoneValueTELEMAT.Text == textBoxZoneNewValueTELEMAT.Text)
            {
                textBoxInfo.Text = "Coding wasn't changed";
            }
            else if (textBoxZoneValueTELEMAT.Text != textBoxZoneNewValueTELEMAT.Text)
            {
                spArduino.WriteLine(":" + CodingKeyTELEMAT + ":03:03");
                Thread.Sleep(100);
                string odebrane = serialData;
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane + Environment.NewLine;
                if (odebrane.Substring(0, 4) == "6704")
                {
                    string command = "2E" + textBoxZoneTELEMAT.Text + textBoxZoneNewValueTELEMAT.Text;
                    spArduino.WriteLine(String.Format(command));
                    richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > " + String.Format(command) + Environment.NewLine;
                    Thread.Sleep(100);
                    string odebrane3 = serialData;
                    richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane3 + Environment.NewLine;
                    //wyslac ramke 2E2901FD000000010101 aby nie bylo bledu B1003 zabezpieczonego kodowania
                    spArduino.WriteLine("2E2901FD000000010101");
                    richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 2E290100000000010101" + Environment.NewLine;
                    Thread.Sleep(100);
                    string odebrane4 = serialData;
                    richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odebrane4 + Environment.NewLine;
                    spArduino.WriteLine("1103");
                    richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 1103" + Environment.NewLine;

                }
                else
                {
                    textBoxInfo.Text = "Coding conditions not met";
                }
            }
        }
        private void ButtonIdentifyINJ_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to INJ" + Environment.NewLine;
            ConnectModuleUDS(INJ);
            string odebraneINJZA = ReadZoneUDS("F080");
            string odebraneINJZI = ReadZoneUDS("F0FE");
            string[] RefINJZI = { odebraneINJZI.Substring(18, 6), odebraneINJZI.Substring(26, 2), odebraneINJZI.Substring(28, 2), odebraneINJZI.Substring(30, 2), odebraneINJZI.Substring(32, 6), odebraneINJZI.Substring(46, 2), odebraneINJZI.Substring(48, 6) };
            textBoxSWINJ.Text = "96" + RefINJZI[6] + "80";
            textBoxHWINJ.Text = odebraneINJZA.Substring(20, 10);
            int TD = Convert.ToInt32(RefINJZI[4].Substring(0, 2), 16);
            int TM = Convert.ToInt32(RefINJZI[4].Substring(2, 2), 16);
            int TY = Convert.ToInt32(RefINJZI[4].Substring(4, 2), 16);
            string TDstring = TD.ToString();
            string TMstring = TM.ToString();
            string TYstring = "20" + TY.ToString();
            if (RefINJZI[4].Substring(0, 2) == "FF")
            {
                TDstring = RefINJZI[4].Substring(0, 2);
                TMstring = RefINJZI[4].Substring(2, 2);
                TYstring = RefINJZI[4].Substring(4, 2);
            }
            string typINJ = odebraneINJZI.Substring(14, 4);                                          // wydobycie z ciągu sekcji 4 bajtów typu BSI z odebranych danych
            textBoxTypINJ.Text = typINJ;
            if (typINJ == "0322")
            {
                textBoxTypINJ.Text = "CMM_MED1744AA";
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyINJ = "0000";
                UnlockCodingINJ();
            }
            else if (typINJ == "0326")
            {
                textBoxTypINJ.Text = "CMM_MG1CS042";
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyINJ = "0000";
                UnlockCodingINJ();
            }
            else if (typINJ == "060F")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypINJ.Text = "CMM_VD46";
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyINJ = "0000";
                UnlockCodingINJ();
            }
            else if (typINJ == "0D13")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypINJ.Text = "CMM_VD56";
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyINJ = "0000";
                UnlockCodingINJ();
            }
            else if (typINJ == "0337")
            {
                textBoxTypINJ.Text = "CMM_MD1CS003_EURO6_3";
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyINJ = "0000";
                UnlockCodingINJ();
            }
            else if (typINJ == "0324")
            {
                textBoxTypINJ.Text = "CMM_MG1CS042_PHEV";
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyINJ = "0000";
                UnlockCodingINJ();
            }
            else if (typINJ == "1310")
            {
                textBoxTypINJ.Text = "CMM_DCM62";
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyINJ = "0000";
                UnlockCodingINJ();
            }
            else if (typINJ == "1330")
            {
                textBoxTypINJ.Text = "CMM_DCM71";
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                //                string CodingKeyINJ = "0000";
                UnlockCodingINJ();
            }
            else
            {
                textBoxTypINJ.Text = "Unknown " + typINJ;
                richTextBoxLog.Text += Environment.NewLine + "INJ: " + string.Format(textBoxTypINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Version: " + RefINJZI[1] + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefINJZI[2]) + "." + string.Format(RefINJZI[3]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefINJZI[5]) + Environment.NewLine;
                richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWINJ.Text) + Environment.NewLine;
                richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefINJZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefINJZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefINJZI[0].Substring(4, 2), 16);
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                UnlockCodingINJ();
            }
        }
        private void ButtonReadZoneINJ_Click(object sender, EventArgs e)
        {
            if (textBoxZoneINJ.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneINJ.Text);
                string toRemove = "62" + textBoxZoneINJ.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueINJ.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueINJ.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
            {
                textBoxInfo.Text = "Please select zone";
            }
        }
        private void ButtonIdentifyBVA_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Text += Environment.NewLine + "Connecting to BVA" + Environment.NewLine;
            string odpowiedz = ConnectModuleUDS(BVA);
            if (odpowiedz.Substring(0, 2) == "OK")
            {
                string message = "Module not installed in car";
                textBoxInfo.Text = message;
                richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " " + String.Format(message) + Environment.NewLine;
                buttonIdentifyBVA.Enabled = false;
                MessageBox.Show(message);
            }
            else
            {
                string odebraneBVAZA = ReadZoneUDS("F080");
                string odebraneBVAZI = ReadZoneUDS("F0FE");
                string[] RefBVAZI = { odebraneBVAZI.Substring(18, 6), odebraneBVAZI.Substring(26, 2), odebraneBVAZI.Substring(28, 2), odebraneBVAZI.Substring(30, 2), odebraneBVAZI.Substring(32, 6), odebraneBVAZI.Substring(46, 2), odebraneBVAZI.Substring(48, 6) };
                textBoxSWBVA.Text = "96" + RefBVAZI[6] + "80";
                textBoxHWBVA.Text = odebraneBVAZA.Substring(20, 10);
                int TD = Convert.ToInt32(RefBVAZI[4].Substring(0, 2), 16);
                int TM = Convert.ToInt32(RefBVAZI[4].Substring(2, 2), 16);
                int TY = Convert.ToInt32(RefBVAZI[4].Substring(4, 2), 16);
                string TDstring = TD.ToString();
                string TMstring = TM.ToString();
                string TYstring = "20" + TY.ToString();
                if (RefBVAZI[4].Substring(0, 2) == "FF")
                {
                    TDstring = RefBVAZI[4].Substring(0, 2);
                    TMstring = RefBVAZI[4].Substring(2, 2);
                    TYstring = RefBVAZI[4].Substring(4, 2);
                }
                string typbva = odebraneBVAZI.Substring(14, 4);
                textBoxTypBVA.Text = typbva;
                if (typbva == "3060")
                {
                    textBoxTypBVA.Text = "BVA AXN8";
                    richTextBoxLog.Text += Environment.NewLine + "BVA: " + string.Format(textBoxTypBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefBVAZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefBVAZI[2]) + "." + string.Format(RefBVAZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefBVAZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefBVAZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefBVAZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefBVAZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingBVA();
                }
                else if (typbva == "3070")
                {
                    textBoxTypBVA.Text = "BVA AXTN8";
                    richTextBoxLog.Text += Environment.NewLine + "BVA: " + string.Format(textBoxTypBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefBVAZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefBVAZI[2]) + "." + string.Format(RefBVAZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefBVAZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefBVAZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefBVAZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefBVAZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingBVA();
                }
                else
                {
                    textBoxTypBVA.Text = "Unknown " + typbva;
                    richTextBoxLog.Text += Environment.NewLine + "BVA: " + string.Format(textBoxTypBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Version: " + RefBVAZI[1] + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefBVAZI[2]) + "." + string.Format(RefBVAZI[3]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefBVAZI[5]) + Environment.NewLine;
                    richTextBoxLog.Text += "Teletransmission date: " + string.Format(TDstring) + "." + string.Format(TMstring) + "." + string.Format(TYstring) + Environment.NewLine;
                    richTextBoxLog.Text += "Hardware Number: " + string.Format(textBoxHWBVA.Text) + Environment.NewLine;
                    richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefBVAZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefBVAZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefBVAZI[0].Substring(4, 2), 16);
                    richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                    UnlockCodingBVA();
                }
            }
        }
        private void ButtonReadZoneBVA_Click(object sender, EventArgs e)
        {
            if (textBoxZoneBVA.Text != "")
            {
                spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
                richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + String.Format(" > 1003");
                Thread.Sleep(100);
                string odebrane3 = ReadZoneUDS(textBoxZoneBVA.Text);
                string toRemove = "62" + textBoxZoneBVA.Text;
                string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
                if (s >= 0)
                {
                    result2 = odebrane3.Remove(s, toRemove.Length);
                }
                textBoxZoneValueBVA.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox
                richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
                if (textBoxZoneValueBVA.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
                {
                    textBoxInfo.Text = "No coding in this zone";
                }
            }
            else
            {
                textBoxInfo.Text = "Please select zone";
            }
        }
        ushort Crc16_x25(byte[] data, int len)
        {
            ushort crc = 0xffff;
            for (ushort i = 0; i < len; i++)
            {
                crc ^= data[i];
                for (ushort k = 0; k < 8; k++)
                    crc = (ushort)((crc & 1) != 0 ? (crc >> 1) ^ 0x8408 : crc >> 1);
            }
            return (ushort)~crc;
        }
        uint ROL(uint val, int rot)
        {
            return (uint)(val << rot) | (val >> (16 - rot));
        }
        public static byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }
        public static string GetKey(string seedTXT, string appKeyTXT)
        {
            string result = "";

            string[] seed = { seedTXT.Substring(0, 2), seedTXT.Substring(2, 2), seedTXT.Substring(4, 2), seedTXT.Substring(6, 2) };
            string[] appKey = { appKeyTXT.Substring(0, 2), appKeyTXT.Substring(2, 2) };

            long x = 0;
            long a = 0;
            long b = 0;
            long c = 0;
            long d = 0;
            long appKeyComputed = 0;
            long val = 0;
            long key = 0;
            long key_ = 0;

            x = int.Parse(appKey[0] + appKey[1], System.Globalization.NumberStyles.HexNumber);
            a = int.Parse(appKey[1] + "00" + appKey[0] + appKey[1], System.Globalization.NumberStyles.HexNumber) * 0xAA;
            if (x > 0x7FFF)
            {
                b = ((0x0B81702E1 * (0xFFFFFFFF0000 | x)) >> 32);
                b = ((0xFFFF0000 | (b & 0xffff)) >> 7) + 0xFE000000;
            }
            else
            {
                b = ((0x0B81702E1 * x) >> 32) >> 7;
            }
            c = ((b + (b >> 0x1F)) & 0xffff) * 0x7673;
            d = a - c;
            if ((d & 0xffff) > 0x7FFF)
            { // Negative
                d += 0x7673;
            }
            appKeyComputed = (d & 0xffff);

            x = int.Parse(seed[0] + seed[3], System.Globalization.NumberStyles.HexNumber);
            a = x * 0xAB;
            if (x > 0x7FFF)
            {
                b = ((0x0B92143FB * (0xFFFFFFFF0000 | x)) >> 32);
                b = ((0xFFFF0000 | (b & 0xffff)) >> 7) + 0xFE000000;
            }
            else
            {
                b = ((0x0B92143FB * x) >> 32) >> 7;
            }
            c = ((b + (b >> 0x1F)) & 0xffff) * 0x763D;
            d = a - c;
            if ((d & 0xffff) > 0x7FFF)
            { // Negative
                d += 0x763D;
            }
            d = (d & 0xffff);
            key = d | appKeyComputed;

            x = int.Parse(seed[1] + seed[2], System.Globalization.NumberStyles.HexNumber);
            a = x * 0xAA;
            if (x > 0x7FFF)
            {
                b = ((0x0B81702E1 * (0xFFFFFFFF0000 | x)) >> 32);
                b = ((0xFFFF0000 | (b & 0xffff)) >> 7) + 0xFE000000;
            }
            else
            {
                b = ((0x0B81702E1 * x) >> 32) >> 7;
            }
            c = ((b + (b >> 0x1F)) & 0xffff) * 0x7673;
            d = a - c;
            if ((d & 0xffff) > 0x7FFF)
            { // Negative
                d += 0x7673;
            }
            d = (d & 0xffff);

            val = d;

            x = (key & 0xffff);
            a = x * 0xAB;
            if (x > 0x7FFF)
            {
                b = ((0x0B92143FB * (0xFFFFFFFF0000 | x)) >> 32);
                b = ((0xFFFF0000 | (b & 0xffff)) >> 7) + 0xFE000000;
            }
            else
            {
                b = ((0x0B92143FB * x) >> 32) >> 7;
            }
            c = ((b + (b >> 0x1F)) & 0xffff) * 0x763D;
            d = a - c;
            if ((d & 0xffff) > 0x7FFF)
            { // Negative
                d += 0x763D;
            }
            d = (d & 0xffff);

            key_ = (val | d);

            result = key.ToString("X4") + key_.ToString("X4");

            return result;
        }
        public void ButtonAlgo_Click(object sender, EventArgs e)
        {
            /*string mileage = "000EFDA2";
            richTextBoxLog.Text += "Input value mileage: " + string.Format(mileage) + Environment.NewLine;
            richTextBoxLog.Text += "Mileage: " + Convert.ToInt32(mileage, 16)/10 + " km" + Environment.NewLine;
            textBoxmileage.Text = Convert.ToInt32(mileage, 16) / 10 + " km";
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;

            string odebraneDAEZA = "6180982707648000219829982180D020FFFF0101FFFFFFFF";
            string odebraneDAEZI = "61FE00000000215C1D06100510FF01000000FE02000001933887";
            string[] RefDAEZA = { odebraneDAEZA.Substring(4, 10), odebraneDAEZA.Substring(16, 2), odebraneDAEZA.Substring(18, 10), odebraneDAEZA.Substring(28, 4) };
            string[] RefDAEZI = { odebraneDAEZI.Substring(16, 6), odebraneDAEZI.Substring(24, 2), odebraneDAEZI.Substring(26, 4), odebraneDAEZI.Substring(30, 6), odebraneDAEZI.Substring(44, 2), odebraneDAEZI.Substring(46, 6) };
            textBoxSWDAE.Text = "96" + RefDAEZI[5] + "80";
            textBoxTypDAE.Text = "DAE_BVH2";
            richTextBoxLog.Text += Environment.NewLine + "DAE: " + string.Format(textBoxTypDAE.Text) + Environment.NewLine;
            richTextBoxLog.Text += "Software Version: " + RefDAEZA[3].Substring(0, 2) + "." + RefDAEZA[3].Substring(2, 2) + Environment.NewLine;
            richTextBoxLog.Text += "Calibration Version: " + RefDAEZI[1] + Environment.NewLine;
            richTextBoxLog.Text += "Calibration Reference: " + string.Format(textBoxSWDAE.Text) + Environment.NewLine;
            richTextBoxLog.Text += "Calibration Edition(Hex): " + string.Format(RefDAEZI[2].Substring(0, 2)) + "." + string.Format(RefDAEZI[2].Substring(2, 2)) + Environment.NewLine;
            richTextBoxLog.Text += "Teletransmission Counter:" + string.Format(RefDAEZI[4]) + Environment.NewLine;
            richTextBoxLog.Text += "Teletransmission date: " + Convert.ToInt32(RefDAEZI[3].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[3].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[3].Substring(4, 2), 16) + Environment.NewLine;
            //richTextBoxLog.Text += "HW: " + string.Format(textBoxHWCVM.Text) + Environment.NewLine;
            richTextBoxLog.Text += "Production date: " + Convert.ToInt32(RefDAEZI[0].Substring(0, 2), 16) + "." + Convert.ToInt32(RefDAEZI[0].Substring(2, 2), 16) + ".20" + Convert.ToInt32(RefDAEZI[0].Substring(4, 2), 16);*/
            //ConnectModuleUDS(BSI);
        string str = "34A00000000605" + textBoxNewCodingDAE.Text + "FD000000";
        byte[] BTS = StringToByteArray(str);
        ushort calc_crc = Crc16_x25(BTS, BTS.Length);

        calc_crc = (ushort)ROL(calc_crc, 8);

        richTextBoxLog.Text += $"CRC16-x25 : {calc_crc.ToString("X")}" + Environment.NewLine;
        string CodingMessage = str + calc_crc.ToString("X");
        richTextBoxLog.Text += CodingMessage + Environment.NewLine;
        //           string Key = textBoxKey.Text;
        //           string Seed = textBoxSeed.Text;
        //           string SeedKey = GetKey(Seed, Key);
        //           richTextBoxLog.Text += DateTime.Now.ToString() +" " + SeedKey + Environment.NewLine;*/
        }
        private void ButtonSaveLog_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(@"Logs"))
            { Directory.CreateDirectory("Logs"); }
            if (textBoxVin.TextLength == 17)
            {
                if (!Directory.Exists(@"Logs"))
                { Directory.CreateDirectory("Logs"); }
                string path = @"Logs\Log-" + textBoxVin.Text + "-" + textBoxmileage.Text + ".txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Log");
                    }
                }
                else if (File.Exists(path))
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        for (int i = 0; i < richTextBoxLog.Lines.Length; i++)
                        {
                            sw.WriteLine(richTextBoxLog.Lines[i]);
                        }
                        sw.Flush();
                        sw.Close();
                        MessageBox.Show("Log saved");
                    }
                }
            }
            else
            {
                string path = @"Logs\Log.txt";
                if (!File.Exists(path))
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        for (int i = 0; i < richTextBoxLog.Lines.Length; i++)
                        {
                            sw.WriteLine(richTextBoxLog.Lines[i]);
                        }
                        sw.Flush();
                        sw.Close();
                    }
                }
                else if (File.Exists(path))
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        for (int i = 0; i < richTextBoxLog.Lines.Length; i++)
                        {
                            sw.WriteLine(richTextBoxLog.Lines[i]);
                        }
                        sw.Flush();
                        sw.Close();
                    }
                }
            }
        }
        private void ButtonReadFaults_Click(object sender, EventArgs e)
        {
            spArduino.WriteLine("190209");
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 120209" + Environment.NewLine;
            Thread.Sleep(500);
            string odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odpowiedz + Environment.NewLine;
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
        }
        private void ButtonClearFaults_Click(object sender, EventArgs e)
        {
            ClearFaults();
        }
        private void ClearFaults()
        {
            spArduino.WriteLine("14FFFFFF");
            richTextBoxLog.Text += Environment.NewLine + DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " > 14FFFFFF" + Environment.NewLine;
            Thread.Sleep(500);
            string odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss.fff") + " < " + odpowiedz + Environment.NewLine;
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;

        }
    }
}
