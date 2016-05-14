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
using System.Text.RegularExpressions;

namespace openBraille
{
    public partial class Form_Main : Form
    {
        const int MAXBRAILLE = 3;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void LoadPorts()
        {
            comboBox_Ports.Items.Clear();
            foreach (String portName in SerialPort.GetPortNames())
            {
                comboBox_Ports.Items.Add(portName);
            }
            if (comboBox_Ports.Items.Count > 0)
            {
                comboBox_Ports.SelectedIndex = 0;
            }
        }

        private void MoveOctagon(bool up, bool aMotor, int octagon)
        {
            this.Enabled = false;
            if (comboBox_Ports.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un puerto.", "¡Advertencia! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Enabled = true;
                return;
            }
            SerialPort arduinoPort = new SerialPort(comboBox_Ports.Text, 9600);
            if (!arduinoPort.IsOpen)
            {
                arduinoPort.Open();
            }
            string message = "#";
            if (up)
            {
                message += "f";
            }
            else
            {
                message += "b";
            }
            if (aMotor)
            {
                message += "a";
            }
            else
            {
                message += "b";
            }
            message += octagon.ToString();
            arduinoPort.WriteLine(message);
            arduinoPort.Close();
            this.Enabled = true;
        }

        private string CleanText(string rawText)
        {
            rawText = rawText.Replace('á', 'a');
            rawText = rawText.Replace('é', 'e');
            rawText = rawText.Replace('í', 'i');
            rawText = rawText.Replace('ó', 'o');
            rawText = rawText.Replace('ú', 'u');
            Regex rgx = new Regex("[^a-zA-Z -]");
            rawText = rgx.Replace(rawText, "");
            return rawText.ToLower();
        }

        private void WriteText(string writeText)
        {
            this.Enabled = false;
            if (comboBox_Ports.Text == "")
            {
                MessageBox.Show("No se ha seleccionado un puerto.", "¡Advertencia! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Enabled = true;
                return;
            }
            writeText = CleanText(writeText);
            SerialPort arduinoPort = new SerialPort(comboBox_Ports.Text, 9600);
            if (!arduinoPort.IsOpen)
            {
                arduinoPort.Open();
            }
            label_Progress.Text = "Mostrando: 0/" + writeText.Length.ToString();
            label_Progress.Visible = true;
            for (int i = 0; i < writeText.Length; i += MAXBRAILLE)
            {
                if (i + MAXBRAILLE >= writeText.Length)
                {
                    arduinoPort.WriteLine(writeText.Substring(i, writeText.Length - i));
                    label_Progress.Text = "Mostrando: " + writeText.Length.ToString() + "/" + writeText.Length.ToString();
                }
                else
                {
                    arduinoPort.WriteLine(writeText.Substring(i, MAXBRAILLE));
                    label_Progress.Text = "Mostrando: " + (i + MAXBRAILLE) + "/" + writeText.Length.ToString();
                }
                Application.DoEvents();
                Thread.Sleep(8000 + (1000 * (int)numericUpDown_Delay.Value));
            }
            arduinoPort.WriteLine("");
            arduinoPort.Close();
            label_Progress.Visible = false;
            this.Enabled = true;
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            LoadPorts();
        }

        private void radioButton_File_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_File.Checked)
            {
                groupBox_FileWrite.Enabled = true;
                groupBox_TextWrite.Enabled = false;
            }
        }

        private void radioButton_Text_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Text.Checked)
            {
                groupBox_FileWrite.Enabled = false;
                groupBox_TextWrite.Enabled = true;
            }
        }

        private void button_File_Click(object sender, EventArgs e)
        {
            if (openFileDialog_ReadFile.ShowDialog() == DialogResult.OK)
            {
                label_FileName.Text = openFileDialog_ReadFile.FileName;
                label_FileName.Visible = true;
            }
        }

        private void button_Write_Click(object sender, EventArgs e)
        {
            if (radioButton_Text.Checked)
            {
                WriteText(richTextBox_InputText.Text);
            }
            else
            {
                if (label_FileName.Text == "label_FileName")
                {
                    MessageBox.Show("No se ha seleccionado un archivo.", "¡Advertencia! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                WriteText(File.ReadAllText(label_FileName.Text));
            }
        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            LoadPorts();
        }

        private void button_A0U_Click(object sender, EventArgs e)
        {
            MoveOctagon(true, true, 0);
        }

        private void button_A0D_Click(object sender, EventArgs e)
        {
            MoveOctagon(false, true, 0);
        }

        private void button_B0U_Click(object sender, EventArgs e)
        {
            MoveOctagon(true, false, 0);
        }

        private void button_B0D_Click(object sender, EventArgs e)
        {
            MoveOctagon(false, false, 0);
        }

        private void button_A1U_Click(object sender, EventArgs e)
        {
            MoveOctagon(true, true, 1);
        }

        private void button_A1D_Click(object sender, EventArgs e)
        {
            MoveOctagon(false, true, 1);
        }

        private void button_B1U_Click(object sender, EventArgs e)
        {
            MoveOctagon(true, false, 1);
        }

        private void button_B1D_Click(object sender, EventArgs e)
        {
            MoveOctagon(false, false, 1);
        }

        private void button_A2U_Click(object sender, EventArgs e)
        {
            MoveOctagon(true, true, 2);
        }

        private void button_A2D_Click(object sender, EventArgs e)
        {
            MoveOctagon(false, true, 2);
        }

        private void button_B2U_Click(object sender, EventArgs e)
        {
            MoveOctagon(true, false, 2);
        }

        private void button_B2D_Click(object sender, EventArgs e)
        {
            MoveOctagon(false, false, 2);
        }
    }
}
