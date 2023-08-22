using System;
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

namespace PSA_CVM2
{
    public partial class Form1 : Form
    { 
        public string serialData;
        public string BSI = ">752:652";
        public string CVM = ">74A:64A";
        public string DAE = ">6B5:695";
        public string AAS = ">75D:65D";
        public string ARTIV = ">6B6:696";
        public string TELEMAT = ">764:664";
        public string COMBINE = ">75F:65F";
        private string resultCodingCVM;

        public Form1()
        {
            InitializeComponent();

            String[] ports = SerialPort.GetPortNames();                                     //przypisanie aktywnego nr portu COM
            foreach (String x in ports)
            comboBoxCOM.Items.Add(x);
            int val = comboBoxCOM.Items.Count;  
            textBoxInfo.Text = "Found " + val.ToString() + " device(s)";
            richTextBoxLog.Text += DateTime.Now.ToString() + " Found " + val.ToString() + " device(s)" + Environment.NewLine;
            if (val > 0)
            {
                comboBoxCOM.SelectedIndex = 0;
            }
        }
        private void buttonSearchCOM_Click(object sender, EventArgs e)
        {
            comboBoxCOM.Items.Clear();
            String[] ports = SerialPort.GetPortNames();                                     //przypisanie aktywnego nr portu COM
            foreach (String x in ports)
            comboBoxCOM.Items.Add(x);
            int val = comboBoxCOM.Items.Count;
            textBoxInfo.Text = "Found " + val.ToString() + " device(s)";
            richTextBoxLog.Text += DateTime.Now.ToString() + " Found " + val.ToString() + " device(s)" + Environment.NewLine;
            if (val > 0)
            {
                comboBoxCOM.SelectedIndex = 0;
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (comboBoxCOM.Text == string.Empty)
            {
                textBoxInfo.Text = "COM port not selected";
                richTextBoxLog.Text += DateTime.Now.ToString() + " COM port not selected" + Environment.NewLine;
            }
            else if (comboBoxCOM.Text != string.Empty)
            {
                if (comboBoxCOM.Visible == true)
                {
                    spArduino.PortName = comboBoxCOM.Text;                                                           // Potwierdzenie wyszukania odpowiedniego portu COM
                    spArduino.Open();
                }
                buttonStart.Enabled = false;
                buttonStop.Enabled = true;
                buttonIdentifyVIN.Enabled = true;
                textBoxInfo.Text = "Connected to Interface";
                richTextBoxLog.Text += DateTime.Now.ToString() + " Connected to Interface" + Environment.NewLine;
            }
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            spArduino.WriteLine(String.Format("82"));
            richTextBoxLog.Text += String.Format("> 82") + Environment.NewLine; 
            spArduino.WriteLine(String.Format("1001"));
            richTextBoxLog.Text += String.Format("> 1001") + Environment.NewLine;
            spArduino.Close();
            buttonStart.Enabled = true;
            buttonStop.Enabled = false;
            buttonIdentifyVIN.Enabled = false;
            LockIdentification();
            LockCodingBSI();
            LockCodingCVM();
            LockCodingDAE();
            LockCodingAAS();
            LockCodingARTIV();
            textBoxVin.Clear();
            textBoxInfo.Text = "Disconnected";
            richTextBoxLog.Text += DateTime.Now.ToString() + " Disconnected" + Environment.NewLine;
        }
        public void spArduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialData = spArduino.ReadLine();
        }
        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
        }
        private void buttonIdentifyVIN_Click(object sender, EventArgs e)
        {
            textBoxVin.Clear();
            spArduino.WriteLine(String.Format(BSI));
            richTextBoxLog.Text += DateTime.Now.ToString() + " " + String.Format(BSI) + Environment.NewLine;
            Thread.Sleep(10);
            spArduino.WriteLine(String.Format("1003"));
            richTextBoxLog.Text += DateTime.Now.ToString() + String.Format(" > 1003") + Environment.NewLine;
            Thread.Sleep(100);
            string odpowiedz = serialData;
            if (odpowiedz.Length < 5)
            {
                richTextBoxLog.Text += DateTime.Now.ToString() + " Not connected to car" + Environment.NewLine;
                textBoxInfo.Text = "Not connected to car";
                spArduino.WriteLine(String.Format("1001"));
                richTextBoxLog.Text += DateTime.Now.ToString() + String.Format(" > 1001") + Environment.NewLine;
                Thread.Sleep(500);;
            }
            else if (odpowiedz != null)
            {
                richTextBoxLog.Text += DateTime.Now.ToString() + " < " + String.Format(odpowiedz) + Environment.NewLine; 
                Vinbsi();
                Thread.Sleep(1500);
                spArduino.WriteLine(String.Format("1001"));
                richTextBoxLog.Text += DateTime.Now.ToString() + String.Format(" > 1001") + Environment.NewLine;
  
            }
        }
        private void Vinbsi()
        {
            textBoxVin.Clear();
            string zone = "F190";
            spArduino.WriteLine(String.Format("22" + zone));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(500);
            string odebraneVIN = serialData;
            richTextBoxLog.Text += "< " + String.Format(odebraneVIN) + Environment.NewLine;

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
                    UnlockIdentification();
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
        }
        private void UnlockCodingBSI()
        {
            buttonReadCodingBSI.Enabled = true;
            buttonWriteCodingBSI.Enabled = true;
        }
        private void LockCodingBSI()
        {
            buttonReadCodingBSI.Enabled = false;
            buttonWriteCodingBSI.Enabled = false;
        }
        private void UnlockCodingCVM()
        {
            buttonReadCodingCVM.Enabled = true;
            buttonWriteCodingCVM.Enabled = true;
        }
        private void LockCodingCVM()
        {
            buttonReadCodingCVM.Enabled = false;
            buttonWriteCodingCVM.Enabled = false;
        }
        private void UnlockCodingDAE()
        {
            buttonReadCodingDAE.Enabled = true;
            buttonWriteCodingDAE.Enabled = true;
        }
        private void LockCodingDAE()
        {
            buttonReadCodingDAE.Enabled = false;
            buttonWriteCodingDAE.Enabled = false;
        }
        private void UnlockCodingAAS()
        {
            buttonReadCodingAAS.Enabled = true;
            buttonWriteCodingAAS.Enabled = true;
        }
        private void LockCodingAAS()
        {
            buttonReadCodingAAS.Enabled = false;
            buttonWriteCodingAAS.Enabled = false;
        }
        private void UnlockCodingARTIV()
        {
            buttonReadCodingARTIV.Enabled = true;
            buttonWriteCodingARTIV.Enabled = true;
        }
        private void LockCodingARTIV()
        {
            buttonReadCodingARTIV.Enabled = false;
            buttonWriteCodingARTIV.Enabled = false;
        }
        private void ConnectModuleUDS(string type)
        {
            string odpowiedz = string.Empty;
            spArduino.WriteLine(String.Format("1001"));
            richTextBoxLog.Text += DateTime.Now.ToString() + String.Format(" > 1001") + Environment.NewLine;
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format(type));
            richTextBoxLog.Text += DateTime.Now.ToString() + " " + String.Format(type) + Environment.NewLine;
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format("1003"));
            richTextBoxLog.Text += DateTime.Now.ToString() + String.Format(" > 1003") + Environment.NewLine;
            Thread.Sleep(500);
            odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + String.Format(odpowiedz) + Environment.NewLine;
        }
        public void ReadZone(string zone,string odpowiedz)
        {
            spArduino.WriteLine("22" + zone);
            Thread.Sleep(1500);
            odpowiedz = serialData;
        }
        private void buttonIdentifyBSI_Click(object sender, EventArgs e)
        {
            ConnectModuleUDS(BSI);
            spArduino.WriteLine(String.Format("22F0FE"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneBSIZI = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneBSIZI + Environment.NewLine;
            spArduino.WriteLine(String.Format("22F080"));
            Thread.Sleep(1500);
            string odebraneBSIZA = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneBSIZA + Environment.NewLine;
            string Ref = odebraneBSIZI.Substring(48, 6);
            textBoxSWBSI.Text = "96" + Ref + "80";
            textBoxHWBSI.Text = odebraneBSIZA.Substring(20, 10);
            string typbsi = odebraneBSIZI.Substring(14, 4);// wydobycie z ciągu sekcji 4 bajtów typu modułu z odebranych danych
            textBoxTypBSI.Text = typbsi;
            if (typbsi == "13B3")
                {                                              // warunek przypisania typu modułu do kodu Bajtowego
                    textBoxTypBSI.Text = "DELPHI";
                    string CodingKeyBSI = "B4E0";
                    UnlockCodingBSI();
                }
            else if (typbsi == "06B3")
                {
                    textBoxTypBSI.Text = "VALEO NOx";
                    UnlockCodingBSI();
                }
            else if (typbsi == "0DB3")
                {
                    textBoxTypBSI.Text = "2010";
                    UnlockCodingBSI();
                }
            else
                {
                    textBoxTypBSI.Text = "Unknown " + typbsi;
                }
        }
        private void buttonReadCodingBSI_Click(object sender, EventArgs e)
        {
            spArduino.WriteLine(String.Format("1003"));                                    // Otwarcie sesji diagnostycznej
            richTextBoxLog.Text += String.Format("> 1003") + Environment.NewLine; 
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format("222326"));                    // Odczyt kodowania zony 2326
            richTextBoxLog.Text += String.Format("> 222326") + Environment.NewLine; 
            Thread.Sleep(100);
            string odebrane3 = serialData;                                               // odebranie danych

            string toRemove = "622326";
            string result2 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
            int s = odebrane3.IndexOf(toRemove);                                          // Zapis string.Empty lub string = ""; to to samo
            if (s >= 0)
            {
                result2 = odebrane3.Remove(s, toRemove.Length);
            }
            textBox2326Coding.Text = result2;                                                     // wyświetlenie wartości kodowania w textbox

            spArduino.WriteLine(String.Format("1001"));                                        // reset komunikacji
            Thread.Sleep(100);


            if (textBox2326Coding.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
            {
                textBoxInfo.Text = "KODOWANIE STREFY NIE WYSTEPUJE W TYM BSI";
            }
            spArduino.WriteLine(String.Format("1003"));                     // Otwarcie sesji diagnostycznej
            richTextBoxLog.Text += String.Format("> 1003") + Environment.NewLine;
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format("222373"));                    // Odczyt kodowania zony 2326
            richTextBoxLog.Text += String.Format("> 222373") + Environment.NewLine; Thread.Sleep(100);
            string odebrane4 = serialData;                                               // odebranie danych

            string toRemove2 = "622373";
            string result3 = string.Empty;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
            int s2 = odebrane4.IndexOf(toRemove2);                                          // Zapis string.Empty lub string = ""; to to samo
            if (s2 >= 0)
            {
                result3 = odebrane4.Remove(s2, toRemove2.Length);
            }
            textBox2373Coding.Text = result3;                                                     // wyświetlenie wartości kodowania w textbox

            spArduino.WriteLine(String.Format("1001"));                                        // reset komunikacji
            richTextBoxLog.Text += String.Format("> 1001") + Environment.NewLine; Thread.Sleep(100);


            if (textBox2373Coding.Text == "")                                                     // sposób wyświetlnia w polu INFO warunki wystapienia zdarzeń
            {
                textBoxInfo.Text = "KODOWANIE STREFY NIE WYSTEPUJE W TYM BSI";
            }
        }
        public void buttonIdentifyCVM_Click(object sender, EventArgs e)
        {
            ConnectModuleUDS(CVM);
            spArduino.WriteLine(String.Format("22F0FE"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneCVMZI = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneCVMZI + Environment.NewLine;
            spArduino.WriteLine(String.Format("22F080"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneCVMZA = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneCVMZA + Environment.NewLine;
            string Ref = odebraneCVMZI.Substring(48, 6);
            textBoxSWCVM.Text = "96" + Ref + "80";
            textBoxHWCVM.Text = odebraneCVMZA.Substring(20, 10);
            string typcvm = odebraneCVMZA.Substring(47, 3);                                         // wydobycie z ciągu sekcji 4 bajtów typu BSI z odebranych danych
            textBoxTypCVM.Text = typcvm;

            if (typcvm == "199")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypCVM.Text = "CVM_2";
                string CodingKeyCVM = "E2E5";
                UnlockCodingCVM();
            }
            else if (typcvm == "179")
            {
                textBoxTypCVM.Text = "CVM_3";
                UnlockCodingCVM();
            }
            else
            {
                textBoxTypCVM.Text = "Unknown " + typcvm;
            }
        }
        private void buttonReadCodingCVM_Click(object sender, EventArgs e)
        {
            //string odebraneCodingCVM = serialData;
            if (textBoxTypCVM.Text == "CVM_2")
            {
                spArduino.WriteLine(String.Format("222100"));  //  wysyłamy polecenie CAN do odczytu strefy               
                Thread.Sleep(1500);
                string odebraneCodingCVM = serialData;
                richTextBoxLog.Text += odebraneCodingCVM + Environment.NewLine;
                string toRemove3 = String.Format("622100");
                string resultCodingCVM;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s2 = odebraneCodingCVM.IndexOf(toRemove3);
                resultCodingCVM = odebraneCodingCVM.Remove(s2, toRemove3.Length);
            }
            if (textBoxTypCVM.Text == "CVM_3")
            {
                spArduino.WriteLine(String.Format("222101"));  //  wysyłamy polecenie CAN do odczytu strefy               
                Thread.Sleep(1500);
                string odebraneCodingCVM = serialData;
                richTextBoxLog.Text += odebraneCodingCVM + Environment.NewLine;
                string toRemove3 = String.Format("622101");
                string resultCodingCVM;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
                int s2 = odebraneCodingCVM.IndexOf(toRemove3);
                resultCodingCVM = odebraneCodingCVM.Remove(s2, toRemove3.Length);
            }
            textBoxCVMCoding.Text = resultCodingCVM;                                                     // wyświetlenie wartości kodowania w textbox
            spArduino.WriteLine(String.Format("1001"));                                        // reset komunikacji
            Thread.Sleep(100);
        }
        private void buttonIdentifyDAE_Click(object sender, EventArgs e)
        {
            string odpowiedz = string.Empty; 
            spArduino.WriteLine(String.Format("1001"));
            Thread.Sleep(10);
            spArduino.WriteLine(String.Format(DAE));
            richTextBoxLog.Text += DateTime.Now.ToString() + " >" + String.Format(DAE) + Environment.NewLine;
            Thread.Sleep(100);
            spArduino.WriteLine(String.Format("81"));
            richTextBoxLog.Text += DateTime.Now.ToString() + " > 81" + Environment.NewLine;
            Thread.Sleep(100);
            odpowiedz = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + String.Format(odpowiedz) + Environment.NewLine;
            spArduino.WriteLine(String.Format("21FE"));
            richTextBoxLog.Text += DateTime.Now.ToString() + String.Format(" > 21FE") + Environment.NewLine;
            Thread.Sleep(100);
            string odebraneDAEZI = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " > " + odebraneDAEZI + Environment.NewLine;
            spArduino.WriteLine(String.Format("2180"));
            richTextBoxLog.Text += DateTime.Now.ToString() + String.Format(" > 2180") + Environment.NewLine;
            Thread.Sleep(100);
            string odebraneDAEZA = serialData;                                
            richTextBoxLog.Text += DateTime.Now.ToString() + " > " + odebraneDAEZA + Environment.NewLine;
            string Ref = odebraneDAEZI.Substring(48, 6);
            textBoxSWDAE.Text = "96" + Ref + "80";
            UnlockCodingDAE();
            //string KeyCodingDAE = 2305;
        }
        private void buttonReadCodingDAE_Click(object sender, EventArgs e)
        {
        
                spArduino.WriteLine(String.Format("1001"));
                Thread.Sleep(100);
                spArduino.WriteLine(String.Format(DAE));
                richTextBoxLog.Text += String.Format(DAE) + Environment.NewLine;
                Thread.Sleep(100);
                spArduino.WriteLine(String.Format("81"));
                richTextBoxLog.Text += String.Format("> 81") + Environment.NewLine;
                Thread.Sleep(100);
                spArduino.WriteLine(String.Format("21A0"));
                Thread.Sleep(500);
                string odebrane8 = serialData;
                richTextBoxLog.Text += odebrane8 + Environment.NewLine;

            string toRemove4 = String.Format("61A0");
            string CodingDAE;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
            int s2 = odebrane8.IndexOf(toRemove4);                                          // Zapis string.Empty lub string = ""; to to samo
            CodingDAE = odebrane8.Remove(s2, toRemove4.Length);
            textBoxDAECoding.Text = CodingDAE;
        }
        private void buttonIdentifyAAS_Click(object sender, EventArgs e)
        {
            ConnectModuleUDS(AAS);
            spArduino.WriteLine(String.Format("22F0FE"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneAASZI = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneAASZI + Environment.NewLine;
            spArduino.WriteLine(String.Format("22F080"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneAASZA = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneAASZA + Environment.NewLine;
            string[] Ref = { odebraneAASZI.Substring(48, 6) };
            textBoxSWAAS.Text = "96" + Ref[0] + "80";
            textBoxHWAAS.Text = odebraneAASZA.Substring(20, 10);


            string typAAS = odebraneAASZI.Substring(14, 4);                                           // wydobycie z ciągu sekcji 4 bajtów typu BSI z odebranych danych
            richTextBoxLog.Text += typAAS + Environment.NewLine;
            textBoxTypAAS.Text = typAAS;
            //if (typAAS == "xxxx")
            //{
            //    textBoxTypAAS.Text = "AAS_UDS_G4";
            //    string CodingKeyAAS = "0000";
            //    UnlockCodingAAS();
            //}
            if (typAAS == "03E1")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypAAS.Text = "AAS_UDS_G5";
                string CodingKeyAAS = "D1F5";
                UnlockCodingAAS();
            }
            if (typAAS == "06E0")
            {
                textBoxTypAAS.Text = "AAS_UDS_G6";
                string CodingKeyAAS = "B6F0";
                UnlockCodingAAS();
            }
            else
            {
                textBoxTypAAS.Text = "Unknown " + typAAS;
            }
        }
        private void buttonReadCodingAAS_Click(object sender, EventArgs e)
        {
            spArduino.WriteLine(String.Format("222101"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneCodingAAS = serialData;
            richTextBoxLog.Text += odebraneCodingAAS + Environment.NewLine;
            string toRemove3 = String.Format("622101");
            string resultCodingAAS;                                               // obcięcie polecenia CN do wyświetlenia w textbox - to juz znamy z opisu VIN
            int s2 = odebraneCodingAAS.IndexOf(toRemove3);                                          // Zapis string.Empty lub string = ""; to to samo
            resultCodingAAS = odebraneCodingAAS.Remove(s2, toRemove3.Length);
            textBoxCodingAAS.Text = resultCodingAAS;                                                     // wyświetlenie wartości kodowania w textbox
        }
        private void buttonIdentifyARTIV_Click(object sender, EventArgs e)
        {
            ConnectModuleUDS(ARTIV);
            spArduino.WriteLine(String.Format("22F0FE"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneARTIVZI = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneARTIVZI + Environment.NewLine;
            spArduino.WriteLine(String.Format("22F080"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneARTIVZA = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneARTIVZA + Environment.NewLine;
            string Ref = odebraneARTIVZA.Substring(48, 6);
            textBoxSWARTIV.Text = "96" + Ref + "80";
            textBoxHWARTIV.Text = odebraneARTIVZA.Substring(20, 10);

            string typartiv = odebraneARTIVZI.Substring(47, 3);                                           // wydobycie z ciągu sekcji 4 bajtów typu BSI z odebranych danych
            textBoxTypARTIV.Text = typartiv;
            if (typartiv == "FFF")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypARTIV.Text = "ARTIV_UDS";
                //string CodingKeyARTIV = "xxxx";
                UnlockCodingARTIV();
            }
            if (typartiv == "153")
            {
                textBoxTypARTIV.Text = "RADAR_AV_4";
                UnlockCodingARTIV();
            }
            else
            {
                textBoxTypARTIV.Text = "Unknown " + typartiv;
            }  
        }
        private void buttonIdentifyCOMBINE_Click(object sender, EventArgs e)
        {
            ConnectModuleUDS(COMBINE);
            spArduino.WriteLine(String.Format("22F0FE"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneCOMBINEZI = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneCOMBINEZI + Environment.NewLine;
            spArduino.WriteLine(String.Format("22F080"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneCOMBINEZA = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneCOMBINEZA + Environment.NewLine;
            string Ref = odebraneCOMBINEZI.Substring(48, 6);
            textBoxSWCOMBINE.Text = "96" + Ref + "80";
            textBoxHWCOMBINE.Text = odebraneCOMBINEZA.Substring(20, 10);

            string typcombine = odebraneCOMBINEZI.Substring(14, 4);
            textBoxTypCOMBINE.Text = typcombine;
            if (typcombine == "02FC")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypCOMBINE.Text = "CIROCCO";
            }
            else if (typcombine == "26FC")
            {
                textBoxTypCOMBINE.Text = "COMBINE_UDS_EV";
            }
            else
            {
                textBoxTypCOMBINE.Text = "Unknown " + typcombine;
            }
        }
        private void buttonIdentifyTELEMAT_Click(object sender, EventArgs e)
        {
            ConnectModuleUDS(TELEMAT);
            spArduino.WriteLine(String.Format("22F0FE"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneTELEMATZI = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneTELEMATZI + Environment.NewLine;
            spArduino.WriteLine(String.Format("22F080"));  //  wysyłamy polecenie CAN do odczytu strefy               
            Thread.Sleep(1500);
            string odebraneTELEMATZA = serialData;
            richTextBoxLog.Text += DateTime.Now.ToString() + " < " + odebraneTELEMATZA + Environment.NewLine;
            string Ref = odebraneTELEMATZI.Substring(48, 6);
            textBoxSWTELEMAT.Text = "96" + Ref + "80";
            textBoxHWTELEMAT.Text = odebraneTELEMATZA.Substring(20, 10);

            string typtelemat = odebraneTELEMATZI.Substring(14, 4);
            textBoxTypTELEMAT.Text = typtelemat;
            if (typtelemat == "0DF5")
            {                                                                                       // warunek przypisania typu BSI do kodu Bajtowego
                textBoxTypTELEMAT.Text = "NAC/RCC";
            }
            //else if (typtelemat == "xxxx")
            //{
            //    textBoxTypTELEMAT.Text = "RADAR_AV_4";
            //}
            else
            {
                textBoxTypTELEMAT.Text = "Unknown " + typtelemat;
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
