using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.IO.Ports;

namespace DrosteBot
{
    public partial class Form1 : Form
    {
        volatile int posX;
        volatile int posY;
        volatile bool isConnected = false;
        volatile bool handshakeToDo = false;

        // Robot configs
        public int ticksPerRobot = 20;

        List <PictureBox> vImages = new List<PictureBox>();
        List<Tuple<string, int>> commands = new List<Tuple<string, int>>();

        delegate void SetTextCallback(string text);
        string InputData = String.Empty;

        string[] moveString = new string[] { "F", "R", "B", "L", "U", "D", "R", "L" };

        string serialBufferInput = String.Empty;
        string serialBufferOutput = String.Empty;

        public Form1()
        {
            InitializeComponent();
            posX = 6;
            posY = 15;
            enableButtons(true);
            listPorts();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxFront.Left += 3;
            pictureBoxFront.Top += 3;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxFront.Left -= 3;
            pictureBoxFront.Top -= 3;
            // Add move
            addMove(0, ticksPerRobot);
        }

        private void pictureBoxRight_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRight.Left += 3;
            pictureBoxRight.Top += 3;
        }

        private void pictureBoxRight_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxRight.Left -= 3;
            pictureBoxRight.Top -= 3;
            // Add move
            addMove(1, 90);
        }

        private void pictureBoxBack_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxBack.Left += 3;
            pictureBoxBack.Top += 3;
        }

        private void pictureBoxBack_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxBack.Left -= 3;
            pictureBoxBack.Top -= 3;
            addMove(2, ticksPerRobot);
        }

        private void pictureBoxLeft_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxLeft.Left += 3;
            pictureBoxLeft.Top += 3;
        }

        private void pictureBoxLeft_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxLeft.Left -= 3;
            pictureBoxLeft.Top -= 3;
            addMove(3, 90);
        }

        private void pictureBoxGo_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxGo.Left += 3;
            pictureBoxGo.Top += 3;
        }

        private void pictureBoxGo_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxGo.Left -= 3;
            pictureBoxGo.Top -= 3;
            // Send Moves
            if(!isConnected)
            {
                MessageBox.Show("Não está ligado ao DrosteBot", "Erro de ligação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (commands.Count() > 0)
            {
                // enviar string comandos
                statusText.Text = "A enviar comandos...";
                enableButtons(false);
                goingTimer.Enabled = true;

                serialBufferOutput = String.Empty;

                foreach (Tuple<string,int> t in commands)
                {
                    serialBufferOutput += t.Item1;
                    serialBufferOutput += ":";
                    serialBufferOutput += t.Item2.ToString();
                    serialBufferOutput += "&";
                }

                goingTimer.Start();
                serialPort1.Write("<" + serialBufferOutput + ">");
            }
        }

        private void pictureBoxDelete_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxDelete.Left += 3;
            pictureBoxDelete.Top += 3;
        }

        private void pictureBoxDelete_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxDelete.Left -= 3;
            pictureBoxDelete.Top -= 3;

            // Delete last move
            int NumberOfImages = vImages.Count;

            if (NumberOfImages > 0)
            {
                // recompute positions
                posX -= vImages[NumberOfImages - 1].Width;
                if (posX < 6)
                {
                    posX = (vImages[NumberOfImages - 1].Width * 13) + 6;
                    posY -= vImages[NumberOfImages - 1].Height;
                }

                groupBox1.Controls.Remove(vImages[NumberOfImages - 1]);

                vImages.RemoveAt(NumberOfImages-1);
                commands.RemoveAt(NumberOfImages - 1);

                // if it was the last one, re-enable the distance config
                if(1 == NumberOfImages)
                {
                    numericUpDown1.Enabled = true;
                }
            }
        }

        private void pictureBoxClear_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxClear.Left += 3;
            pictureBoxClear.Top += 3;
        }

        private void pictureBoxClear_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxClear.Left -= 3;
            pictureBoxClear.Top -= 3;

            DialogResult dialogResult = MessageBox.Show("Apagar todos os movimentos?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Clear all moves
                foreach (PictureBox img in vImages)
                {
                    groupBox1.Controls.Remove(img);
                }

                vImages.Clear();
                commands.Clear();
                serialBufferOutput = String.Empty;

                numericUpDown1.Enabled = true;

                posX = 6;
                posY = 15;
            }
        }

        private void enableButtons(bool enabled)
        {
            pictureBoxFront.Enabled = enabled;
            pictureBoxRight.Enabled = enabled;
            pictureBoxBack.Enabled = enabled;
            pictureBoxLeft.Enabled = enabled;
            pictureBoxPenUp.Enabled = enabled;
            pictureBoxPenDown.Enabled = enabled;
            pictureBoxRt45.Enabled = enabled;
            pictureBoxLt45.Enabled = enabled;
            pictureBoxGo.Enabled = enabled;
            pictureBoxDelete.Enabled = enabled;
            pictureBoxClear.Enabled = enabled;            
        }

        private void addMove(int direction, int distance)
        {
            int totalImages = vImages.Count;

            if (totalImages < 56)
            {
                PictureBox img = new PictureBox();
                img.SizeMode   = PictureBoxSizeMode.AutoSize;
                img.Left       = posX;
                img.Top        = posY;
                img.Image = imageList1.Images[direction];
                vImages.Add(img);

                groupBox1.Controls.Add(img);

                posX += img.Width;

                totalImages = vImages.Count;
                if (14 == totalImages ||
                    28 == totalImages ||
                    42 == totalImages)
                {
                    posX = 6;
                    posY += img.Height;
                }

                Tuple<string, int> t = new Tuple<string, int>(moveString[direction], distance);
                commands.Add(t);
            }

            numericUpDown1.Enabled = false;
        }

        private void listPorts()
        {
            List<string> ports = new List<string>();

            statusText.Text = "A pesquisar portas...";

            try
            {
                const string QueryString = "SELECT Caption, PNPDeviceID FROM Win32_PnPEntity "
                                         + "WHERE ConfigManagerErrorCode = 0 AND "
                                         + "Caption LIKE 'Standard Serial over Bluetooth link "
                                         + "(COM%'";

                SelectQuery WMIquery = new SelectQuery(QueryString);

                ManagementObjectSearcher WMIqueryResults = new ManagementObjectSearcher(WMIquery);

                if (WMIqueryResults != null)
                {
                    foreach (object result in WMIqueryResults.Get())
                    {
                        ManagementObject mo = (ManagementObject)result;

                        object captionObject = mo.GetPropertyValue("Caption");

                        // Get the COM port name out of the Caption, requires a little work.
                        string caption = captionObject.ToString();
                        string comPort = caption.Substring(caption.LastIndexOf("(COM")).
                        Replace("(", string.Empty).Replace(")", string.Empty);

                        // Add COM Port to combobox
                        comboBox1.Items.Add(comPort);
                    }

                    statusText.Text = "Escolha uma porta e estabeleça a ligação...";
                }
                else
                {
                    statusText.Text = "Erro a obter portas do sistema!";
                    MessageBox.Show("Erro a obter portas do sistema!");
                }
            }
            catch (Exception err)
            {
                statusText.Text = "Erro a obter portas do sistema!";
                MessageBox.Show("Erro a obter portas do sistema: " + err.Message);
            }
       }

        private void pictureBoxConnect_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxConnect.Left += 1;
            pictureBoxConnect.Top += 1;
        }

        private void pictureBoxConnect_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxConnect.Enabled = false;
            pictureBoxConnect.Left -= 1;
            pictureBoxConnect.Top -= 1;
            // try to open COM
            statusText.Text = "A configurar comunicação...";
            
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBox1.SelectedItem.ToString();
                    comboBox1.Enabled = false;
                    serialPort1.Open();
                    statusText.Text = "Porta aberta...";
                    isConnected = false;
                    handshakeToDo = true;
                    // handshake with robot
                    serialPort1.Write("<BOT>");
                    hstimer.Enabled = true;
                    hstimer.Start();       
                }
                else
                {
                    isConnected = false;
                    handshakeToDo = false;
                    serialPort1.Close();
                    comboBox1.Enabled = true;
                    statusText.Text = "Escolha uma porta e estabeleça a ligação...";
                    pictureBoxConnect.Image = DrosteBot.Properties.Resources.icons8_disconnected_48;
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                comboBox1.Enabled = true;
                handshakeToDo = false;
                MessageBox.Show("Não foi possível estabelecer a ligação", "Erro");
            }
            catch (System.IO.IOException ex)
            {
                comboBox1.Enabled = true;
                handshakeToDo = false;
                MessageBox.Show("Não foi possível estabelecer a ligação", "Erro");
            }
            pictureBoxConnect.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBoxConnect.Enabled = true;
        }

        private void port_DataReceived_1(object sender, SerialDataReceivedEventArgs e)
        {
            InputData = serialPort1.ReadLine();
            if (InputData != String.Empty)
            {
                this.BeginInvoke(new SetTextCallback(SetText), new object[] { InputData });
            }
        }

        private void SetText(string text)
        {
            text = text.Replace("\r\n", "").Replace("\r", "").Replace("\n", "");

            if (handshakeToDo)
            {
                if( text.Equals("BOTOK") )
                {
                    hstimer.Stop();
                    hstimer.Enabled = false;
                    handshakeToDo = false;
                    isConnected = true;
                    pictureBoxConnect.Image = DrosteBot.Properties.Resources.icons8_connected_48;
                    statusText.Text = "DrosteBot encontrado! Pronto para receber comandos...";
                }
            }
            else
            {
                if(isConnected)
                {
                    if (text.Equals("DONE"))
                    {
                        enableButtons(true);
                        statusText.Text = "Pronto para receber comandos...";
                        pictureBoxConnect.Enabled = true;
                    }
                    else if (text.Equals("GO"))
                    {
                        goingTimer.Stop();
                        goingTimer.Enabled = false;
                        pictureBoxConnect.Enabled = false;
                        statusText.Text = "A executar comandos...";
                    }
                }
            }
        }

        private void hstimer_Tick(object sender, EventArgs e)
        {
            hstimer.Stop();
            hstimer.Enabled = false;

            isConnected = false;
            handshakeToDo = false;
            serialPort1.Close();
            comboBox1.Enabled = true;
            statusText.Text = "DrosteBot não encontrado! Escolha uma porta e estabeleça a ligação...";
            pictureBoxConnect.Image = DrosteBot.Properties.Resources.icons8_disconnected_48;
        }

        private void goingTimer_Tick(object sender, EventArgs e)
        {
            goingTimer.Stop();
            goingTimer.Enabled = false;
            statusText.Text = "DrosteBot não recebeu comandos... Tente novamente!";
            enableButtons(true);
        }

        private void pictureBoxRt45_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxRt45.Left += 3;
            pictureBoxRt45.Top += 3;
        }

        private void pictureBoxRt45_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxRt45.Left -= 3;
            pictureBoxRt45.Top -= 3;
            addMove(6, 45);
        }

        private void pictureBoxLt45_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxLt45.Left += 3;
            pictureBoxLt45.Top += 3;
        }

        private void pictureBoxLt45_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxLt45.Left -= 3;
            pictureBoxLt45.Top -= 3;
            addMove(7, 45);
        }

        private void pictureBoxPenUp_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxPenUp.Left += 3;
            pictureBoxPenUp.Top += 3;
        }

        private void pictureBoxPenUp_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxPenUp.Left -= 3;
            pictureBoxPenUp.Top -= 3;
            addMove(4, 0);
        }

        private void pictureBoxPenDown_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBoxPenDown.Left += 3;
            pictureBoxPenDown.Top += 3;
        }

        private void pictureBoxPenDown_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBoxPenDown.Left -= 3;
            pictureBoxPenDown.Top -= 3;
            addMove(5, 0);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ticksPerRobot = (int)numericUpDown1.Value;
        }
    }
}










