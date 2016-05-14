namespace openBraille
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Write = new System.Windows.Forms.TabPage();
            this.label_Progress = new System.Windows.Forms.Label();
            this.button_Write = new System.Windows.Forms.Button();
            this.groupBox_FileWrite = new System.Windows.Forms.GroupBox();
            this.label_FileName = new System.Windows.Forms.Label();
            this.button_File = new System.Windows.Forms.Button();
            this.groupBox_TextWrite = new System.Windows.Forms.GroupBox();
            this.richTextBox_InputText = new System.Windows.Forms.RichTextBox();
            this.groupBox_WriteOptions = new System.Windows.Forms.GroupBox();
            this.radioButton_Text = new System.Windows.Forms.RadioButton();
            this.radioButton_File = new System.Windows.Forms.RadioButton();
            this.tabPage_Config = new System.Windows.Forms.TabPage();
            this.button_Reload = new System.Windows.Forms.Button();
            this.groupBox_Calibration = new System.Windows.Forms.GroupBox();
            this.button_B2D = new System.Windows.Forms.Button();
            this.label_Octagon6 = new System.Windows.Forms.Label();
            this.button_B2U = new System.Windows.Forms.Button();
            this.button_A2D = new System.Windows.Forms.Button();
            this.label_Octagon5 = new System.Windows.Forms.Label();
            this.button_A2U = new System.Windows.Forms.Button();
            this.button_B1D = new System.Windows.Forms.Button();
            this.label_Octagon4 = new System.Windows.Forms.Label();
            this.button_B1U = new System.Windows.Forms.Button();
            this.button_A1D = new System.Windows.Forms.Button();
            this.label_Octagon3 = new System.Windows.Forms.Label();
            this.button_A1U = new System.Windows.Forms.Button();
            this.button_B0D = new System.Windows.Forms.Button();
            this.label_Octagon2 = new System.Windows.Forms.Label();
            this.label_Octagon1 = new System.Windows.Forms.Label();
            this.button_A0D = new System.Windows.Forms.Button();
            this.button_B0U = new System.Windows.Forms.Button();
            this.button_A0U = new System.Windows.Forms.Button();
            this.label_Calibrate = new System.Windows.Forms.Label();
            this.label_Seconds = new System.Windows.Forms.Label();
            this.numericUpDown_Delay = new System.Windows.Forms.NumericUpDown();
            this.label_WaitTime = new System.Windows.Forms.Label();
            this.pictureBox_Arduino = new System.Windows.Forms.PictureBox();
            this.label_ArduinoPort = new System.Windows.Forms.Label();
            this.comboBox_Ports = new System.Windows.Forms.ComboBox();
            this.imageList_Icons = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            this.openFileDialog_ReadFile = new System.Windows.Forms.OpenFileDialog();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Write.SuspendLayout();
            this.groupBox_FileWrite.SuspendLayout();
            this.groupBox_TextWrite.SuspendLayout();
            this.groupBox_WriteOptions.SuspendLayout();
            this.tabPage_Config.SuspendLayout();
            this.groupBox_Calibration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Arduino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Write);
            this.tabControl_Main.Controls.Add(this.tabPage_Config);
            this.tabControl_Main.ImageList = this.imageList_Icons;
            this.tabControl_Main.Location = new System.Drawing.Point(12, 143);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(480, 306);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_Write
            // 
            this.tabPage_Write.Controls.Add(this.label_Progress);
            this.tabPage_Write.Controls.Add(this.button_Write);
            this.tabPage_Write.Controls.Add(this.groupBox_FileWrite);
            this.tabPage_Write.Controls.Add(this.groupBox_TextWrite);
            this.tabPage_Write.Controls.Add(this.groupBox_WriteOptions);
            this.tabPage_Write.ImageIndex = 0;
            this.tabPage_Write.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Write.Name = "tabPage_Write";
            this.tabPage_Write.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Write.Size = new System.Drawing.Size(472, 279);
            this.tabPage_Write.TabIndex = 0;
            this.tabPage_Write.Text = "Escribir";
            this.tabPage_Write.UseVisualStyleBackColor = true;
            // 
            // label_Progress
            // 
            this.label_Progress.AutoSize = true;
            this.label_Progress.Location = new System.Drawing.Point(112, 263);
            this.label_Progress.Name = "label_Progress";
            this.label_Progress.Size = new System.Drawing.Size(84, 13);
            this.label_Progress.TabIndex = 4;
            this.label_Progress.Text = "label_Progress ";
            this.label_Progress.Visible = false;
            // 
            // button_Write
            // 
            this.button_Write.Image = global::openBraille.Properties.Resources.ok;
            this.button_Write.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Write.Location = new System.Drawing.Point(6, 246);
            this.button_Write.Name = "button_Write";
            this.button_Write.Size = new System.Drawing.Size(100, 30);
            this.button_Write.TabIndex = 3;
            this.button_Write.Text = "Do it!";
            this.button_Write.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Write.UseVisualStyleBackColor = true;
            this.button_Write.Click += new System.EventHandler(this.button_Write_Click);
            // 
            // groupBox_FileWrite
            // 
            this.groupBox_FileWrite.Controls.Add(this.label_FileName);
            this.groupBox_FileWrite.Controls.Add(this.button_File);
            this.groupBox_FileWrite.Location = new System.Drawing.Point(241, 6);
            this.groupBox_FileWrite.Name = "groupBox_FileWrite";
            this.groupBox_FileWrite.Size = new System.Drawing.Size(225, 70);
            this.groupBox_FileWrite.TabIndex = 1;
            this.groupBox_FileWrite.TabStop = false;
            this.groupBox_FileWrite.Text = "Escritura por archivo";
            // 
            // label_FileName
            // 
            this.label_FileName.Location = new System.Drawing.Point(112, 38);
            this.label_FileName.Name = "label_FileName";
            this.label_FileName.Size = new System.Drawing.Size(107, 13);
            this.label_FileName.TabIndex = 1;
            this.label_FileName.Text = "label_FileName";
            this.label_FileName.Visible = false;
            // 
            // button_File
            // 
            this.button_File.Image = global::openBraille.Properties.Resources.file_open;
            this.button_File.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_File.Location = new System.Drawing.Point(6, 21);
            this.button_File.Name = "button_File";
            this.button_File.Size = new System.Drawing.Size(100, 30);
            this.button_File.TabIndex = 0;
            this.button_File.Text = "Examinar";
            this.button_File.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_File.UseVisualStyleBackColor = true;
            this.button_File.Click += new System.EventHandler(this.button_File_Click);
            // 
            // groupBox_TextWrite
            // 
            this.groupBox_TextWrite.Controls.Add(this.richTextBox_InputText);
            this.groupBox_TextWrite.Enabled = false;
            this.groupBox_TextWrite.Location = new System.Drawing.Point(6, 82);
            this.groupBox_TextWrite.Name = "groupBox_TextWrite";
            this.groupBox_TextWrite.Size = new System.Drawing.Size(460, 139);
            this.groupBox_TextWrite.TabIndex = 2;
            this.groupBox_TextWrite.TabStop = false;
            this.groupBox_TextWrite.Text = "Escritura por texto";
            // 
            // richTextBox_InputText
            // 
            this.richTextBox_InputText.Location = new System.Drawing.Point(6, 21);
            this.richTextBox_InputText.Name = "richTextBox_InputText";
            this.richTextBox_InputText.Size = new System.Drawing.Size(448, 112);
            this.richTextBox_InputText.TabIndex = 0;
            this.richTextBox_InputText.Text = "";
            // 
            // groupBox_WriteOptions
            // 
            this.groupBox_WriteOptions.Controls.Add(this.radioButton_Text);
            this.groupBox_WriteOptions.Controls.Add(this.radioButton_File);
            this.groupBox_WriteOptions.Location = new System.Drawing.Point(6, 6);
            this.groupBox_WriteOptions.Name = "groupBox_WriteOptions";
            this.groupBox_WriteOptions.Size = new System.Drawing.Size(225, 70);
            this.groupBox_WriteOptions.TabIndex = 0;
            this.groupBox_WriteOptions.TabStop = false;
            this.groupBox_WriteOptions.Text = "Opciones de escritura";
            // 
            // radioButton_Text
            // 
            this.radioButton_Text.AutoSize = true;
            this.radioButton_Text.Location = new System.Drawing.Point(6, 44);
            this.radioButton_Text.Name = "radioButton_Text";
            this.radioButton_Text.Size = new System.Drawing.Size(51, 17);
            this.radioButton_Text.TabIndex = 1;
            this.radioButton_Text.Text = "Texto";
            this.radioButton_Text.UseVisualStyleBackColor = true;
            this.radioButton_Text.CheckedChanged += new System.EventHandler(this.radioButton_Text_CheckedChanged);
            // 
            // radioButton_File
            // 
            this.radioButton_File.AutoSize = true;
            this.radioButton_File.Checked = true;
            this.radioButton_File.Location = new System.Drawing.Point(6, 21);
            this.radioButton_File.Name = "radioButton_File";
            this.radioButton_File.Size = new System.Drawing.Size(63, 17);
            this.radioButton_File.TabIndex = 0;
            this.radioButton_File.TabStop = true;
            this.radioButton_File.Text = "Archivo";
            this.radioButton_File.UseVisualStyleBackColor = true;
            this.radioButton_File.CheckedChanged += new System.EventHandler(this.radioButton_File_CheckedChanged);
            // 
            // tabPage_Config
            // 
            this.tabPage_Config.Controls.Add(this.button_Reload);
            this.tabPage_Config.Controls.Add(this.groupBox_Calibration);
            this.tabPage_Config.Controls.Add(this.label_Seconds);
            this.tabPage_Config.Controls.Add(this.numericUpDown_Delay);
            this.tabPage_Config.Controls.Add(this.label_WaitTime);
            this.tabPage_Config.Controls.Add(this.pictureBox_Arduino);
            this.tabPage_Config.Controls.Add(this.label_ArduinoPort);
            this.tabPage_Config.Controls.Add(this.comboBox_Ports);
            this.tabPage_Config.ImageIndex = 1;
            this.tabPage_Config.Location = new System.Drawing.Point(4, 23);
            this.tabPage_Config.Name = "tabPage_Config";
            this.tabPage_Config.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Config.Size = new System.Drawing.Size(472, 279);
            this.tabPage_Config.TabIndex = 1;
            this.tabPage_Config.Text = "Configuración";
            this.tabPage_Config.UseVisualStyleBackColor = true;
            // 
            // button_Reload
            // 
            this.button_Reload.Image = global::openBraille.Properties.Resources.reload;
            this.button_Reload.Location = new System.Drawing.Point(278, 7);
            this.button_Reload.Name = "button_Reload";
            this.button_Reload.Size = new System.Drawing.Size(25, 25);
            this.button_Reload.TabIndex = 1;
            this.button_Reload.UseVisualStyleBackColor = true;
            this.button_Reload.Click += new System.EventHandler(this.button_Reload_Click);
            // 
            // groupBox_Calibration
            // 
            this.groupBox_Calibration.Controls.Add(this.button_B2D);
            this.groupBox_Calibration.Controls.Add(this.label_Octagon6);
            this.groupBox_Calibration.Controls.Add(this.button_B2U);
            this.groupBox_Calibration.Controls.Add(this.button_A2D);
            this.groupBox_Calibration.Controls.Add(this.label_Octagon5);
            this.groupBox_Calibration.Controls.Add(this.button_A2U);
            this.groupBox_Calibration.Controls.Add(this.button_B1D);
            this.groupBox_Calibration.Controls.Add(this.label_Octagon4);
            this.groupBox_Calibration.Controls.Add(this.button_B1U);
            this.groupBox_Calibration.Controls.Add(this.button_A1D);
            this.groupBox_Calibration.Controls.Add(this.label_Octagon3);
            this.groupBox_Calibration.Controls.Add(this.button_A1U);
            this.groupBox_Calibration.Controls.Add(this.button_B0D);
            this.groupBox_Calibration.Controls.Add(this.label_Octagon2);
            this.groupBox_Calibration.Controls.Add(this.label_Octagon1);
            this.groupBox_Calibration.Controls.Add(this.button_A0D);
            this.groupBox_Calibration.Controls.Add(this.button_B0U);
            this.groupBox_Calibration.Controls.Add(this.button_A0U);
            this.groupBox_Calibration.Controls.Add(this.label_Calibrate);
            this.groupBox_Calibration.Location = new System.Drawing.Point(6, 107);
            this.groupBox_Calibration.Name = "groupBox_Calibration";
            this.groupBox_Calibration.Size = new System.Drawing.Size(460, 166);
            this.groupBox_Calibration.TabIndex = 6;
            this.groupBox_Calibration.TabStop = false;
            this.groupBox_Calibration.Text = "Calibración";
            // 
            // button_B2D
            // 
            this.button_B2D.Image = global::openBraille.Properties.Resources.down;
            this.button_B2D.Location = new System.Drawing.Point(396, 130);
            this.button_B2D.Name = "button_B2D";
            this.button_B2D.Size = new System.Drawing.Size(30, 30);
            this.button_B2D.TabIndex = 18;
            this.button_B2D.UseVisualStyleBackColor = true;
            this.button_B2D.Click += new System.EventHandler(this.button_B2D_Click);
            // 
            // label_Octagon6
            // 
            this.label_Octagon6.AutoSize = true;
            this.label_Octagon6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Octagon6.Location = new System.Drawing.Point(366, 133);
            this.label_Octagon6.Name = "label_Octagon6";
            this.label_Octagon6.Size = new System.Drawing.Size(24, 30);
            this.label_Octagon6.TabIndex = 16;
            this.label_Octagon6.Text = "6";
            // 
            // button_B2U
            // 
            this.button_B2U.Image = global::openBraille.Properties.Resources.up;
            this.button_B2U.Location = new System.Drawing.Point(396, 97);
            this.button_B2U.Name = "button_B2U";
            this.button_B2U.Size = new System.Drawing.Size(30, 30);
            this.button_B2U.TabIndex = 17;
            this.button_B2U.UseVisualStyleBackColor = true;
            this.button_B2U.Click += new System.EventHandler(this.button_B2U_Click);
            // 
            // button_A2D
            // 
            this.button_A2D.Image = global::openBraille.Properties.Resources.down;
            this.button_A2D.Location = new System.Drawing.Point(330, 130);
            this.button_A2D.Name = "button_A2D";
            this.button_A2D.Size = new System.Drawing.Size(30, 30);
            this.button_A2D.TabIndex = 15;
            this.button_A2D.UseVisualStyleBackColor = true;
            this.button_A2D.Click += new System.EventHandler(this.button_A2D_Click);
            // 
            // label_Octagon5
            // 
            this.label_Octagon5.AutoSize = true;
            this.label_Octagon5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Octagon5.Location = new System.Drawing.Point(300, 133);
            this.label_Octagon5.Name = "label_Octagon5";
            this.label_Octagon5.Size = new System.Drawing.Size(24, 30);
            this.label_Octagon5.TabIndex = 13;
            this.label_Octagon5.Text = "5";
            // 
            // button_A2U
            // 
            this.button_A2U.Image = global::openBraille.Properties.Resources.up;
            this.button_A2U.Location = new System.Drawing.Point(330, 97);
            this.button_A2U.Name = "button_A2U";
            this.button_A2U.Size = new System.Drawing.Size(30, 30);
            this.button_A2U.TabIndex = 14;
            this.button_A2U.UseVisualStyleBackColor = true;
            this.button_A2U.Click += new System.EventHandler(this.button_A2U_Click);
            // 
            // button_B1D
            // 
            this.button_B1D.Image = global::openBraille.Properties.Resources.down;
            this.button_B1D.Location = new System.Drawing.Point(264, 130);
            this.button_B1D.Name = "button_B1D";
            this.button_B1D.Size = new System.Drawing.Size(30, 30);
            this.button_B1D.TabIndex = 12;
            this.button_B1D.UseVisualStyleBackColor = true;
            this.button_B1D.Click += new System.EventHandler(this.button_B1D_Click);
            // 
            // label_Octagon4
            // 
            this.label_Octagon4.AutoSize = true;
            this.label_Octagon4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Octagon4.Location = new System.Drawing.Point(234, 133);
            this.label_Octagon4.Name = "label_Octagon4";
            this.label_Octagon4.Size = new System.Drawing.Size(24, 30);
            this.label_Octagon4.TabIndex = 10;
            this.label_Octagon4.Text = "4";
            // 
            // button_B1U
            // 
            this.button_B1U.Image = global::openBraille.Properties.Resources.up;
            this.button_B1U.Location = new System.Drawing.Point(264, 97);
            this.button_B1U.Name = "button_B1U";
            this.button_B1U.Size = new System.Drawing.Size(30, 30);
            this.button_B1U.TabIndex = 11;
            this.button_B1U.UseVisualStyleBackColor = true;
            this.button_B1U.Click += new System.EventHandler(this.button_B1U_Click);
            // 
            // button_A1D
            // 
            this.button_A1D.Image = global::openBraille.Properties.Resources.down;
            this.button_A1D.Location = new System.Drawing.Point(198, 130);
            this.button_A1D.Name = "button_A1D";
            this.button_A1D.Size = new System.Drawing.Size(30, 30);
            this.button_A1D.TabIndex = 9;
            this.button_A1D.UseVisualStyleBackColor = true;
            this.button_A1D.Click += new System.EventHandler(this.button_A1D_Click);
            // 
            // label_Octagon3
            // 
            this.label_Octagon3.AutoSize = true;
            this.label_Octagon3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Octagon3.Location = new System.Drawing.Point(168, 133);
            this.label_Octagon3.Name = "label_Octagon3";
            this.label_Octagon3.Size = new System.Drawing.Size(24, 30);
            this.label_Octagon3.TabIndex = 7;
            this.label_Octagon3.Text = "3";
            // 
            // button_A1U
            // 
            this.button_A1U.Image = global::openBraille.Properties.Resources.up;
            this.button_A1U.Location = new System.Drawing.Point(198, 97);
            this.button_A1U.Name = "button_A1U";
            this.button_A1U.Size = new System.Drawing.Size(30, 30);
            this.button_A1U.TabIndex = 8;
            this.button_A1U.UseVisualStyleBackColor = true;
            this.button_A1U.Click += new System.EventHandler(this.button_A1U_Click);
            // 
            // button_B0D
            // 
            this.button_B0D.Image = global::openBraille.Properties.Resources.down;
            this.button_B0D.Location = new System.Drawing.Point(127, 130);
            this.button_B0D.Name = "button_B0D";
            this.button_B0D.Size = new System.Drawing.Size(30, 30);
            this.button_B0D.TabIndex = 6;
            this.button_B0D.UseVisualStyleBackColor = true;
            this.button_B0D.Click += new System.EventHandler(this.button_B0D_Click);
            // 
            // label_Octagon2
            // 
            this.label_Octagon2.AutoSize = true;
            this.label_Octagon2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Octagon2.Location = new System.Drawing.Point(97, 133);
            this.label_Octagon2.Name = "label_Octagon2";
            this.label_Octagon2.Size = new System.Drawing.Size(24, 30);
            this.label_Octagon2.TabIndex = 4;
            this.label_Octagon2.Text = "2";
            // 
            // label_Octagon1
            // 
            this.label_Octagon1.AutoSize = true;
            this.label_Octagon1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Octagon1.Location = new System.Drawing.Point(26, 133);
            this.label_Octagon1.Name = "label_Octagon1";
            this.label_Octagon1.Size = new System.Drawing.Size(24, 30);
            this.label_Octagon1.TabIndex = 1;
            this.label_Octagon1.Text = "1";
            // 
            // button_A0D
            // 
            this.button_A0D.Image = global::openBraille.Properties.Resources.down;
            this.button_A0D.Location = new System.Drawing.Point(56, 130);
            this.button_A0D.Name = "button_A0D";
            this.button_A0D.Size = new System.Drawing.Size(30, 30);
            this.button_A0D.TabIndex = 3;
            this.button_A0D.UseVisualStyleBackColor = true;
            this.button_A0D.Click += new System.EventHandler(this.button_A0D_Click);
            // 
            // button_B0U
            // 
            this.button_B0U.Image = global::openBraille.Properties.Resources.up;
            this.button_B0U.Location = new System.Drawing.Point(127, 97);
            this.button_B0U.Name = "button_B0U";
            this.button_B0U.Size = new System.Drawing.Size(30, 30);
            this.button_B0U.TabIndex = 5;
            this.button_B0U.UseVisualStyleBackColor = true;
            this.button_B0U.Click += new System.EventHandler(this.button_B0U_Click);
            // 
            // button_A0U
            // 
            this.button_A0U.Image = global::openBraille.Properties.Resources.up;
            this.button_A0U.Location = new System.Drawing.Point(56, 97);
            this.button_A0U.Name = "button_A0U";
            this.button_A0U.Size = new System.Drawing.Size(30, 30);
            this.button_A0U.TabIndex = 2;
            this.button_A0U.UseVisualStyleBackColor = true;
            this.button_A0U.Click += new System.EventHandler(this.button_A0U_Click);
            // 
            // label_Calibrate
            // 
            this.label_Calibrate.Location = new System.Drawing.Point(6, 18);
            this.label_Calibrate.Name = "label_Calibrate";
            this.label_Calibrate.Size = new System.Drawing.Size(448, 57);
            this.label_Calibrate.TabIndex = 0;
            this.label_Calibrate.Text = resources.GetString("label_Calibrate.Text");
            // 
            // label_Seconds
            // 
            this.label_Seconds.AutoSize = true;
            this.label_Seconds.Location = new System.Drawing.Point(136, 88);
            this.label_Seconds.Name = "label_Seconds";
            this.label_Seconds.Size = new System.Drawing.Size(58, 13);
            this.label_Seconds.TabIndex = 5;
            this.label_Seconds.Text = "segundos";
            // 
            // numericUpDown_Delay
            // 
            this.numericUpDown_Delay.Location = new System.Drawing.Point(9, 79);
            this.numericUpDown_Delay.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Delay.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown_Delay.Name = "numericUpDown_Delay";
            this.numericUpDown_Delay.Size = new System.Drawing.Size(121, 22);
            this.numericUpDown_Delay.TabIndex = 4;
            this.numericUpDown_Delay.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label_WaitTime
            // 
            this.label_WaitTime.AutoSize = true;
            this.label_WaitTime.Location = new System.Drawing.Point(6, 63);
            this.label_WaitTime.Name = "label_WaitTime";
            this.label_WaitTime.Size = new System.Drawing.Size(333, 13);
            this.label_WaitTime.TabIndex = 3;
            this.label_WaitTime.Text = "¿Cuánto tiempo debe esperarse entre actualizaciones de letras?";
            // 
            // pictureBox_Arduino
            // 
            this.pictureBox_Arduino.Image = global::openBraille.Properties.Resources.arduino;
            this.pictureBox_Arduino.Location = new System.Drawing.Point(353, 0);
            this.pictureBox_Arduino.Name = "pictureBox_Arduino";
            this.pictureBox_Arduino.Size = new System.Drawing.Size(119, 76);
            this.pictureBox_Arduino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Arduino.TabIndex = 4;
            this.pictureBox_Arduino.TabStop = false;
            // 
            // label_ArduinoPort
            // 
            this.label_ArduinoPort.AutoSize = true;
            this.label_ArduinoPort.Location = new System.Drawing.Point(6, 13);
            this.label_ArduinoPort.Name = "label_ArduinoPort";
            this.label_ArduinoPort.Size = new System.Drawing.Size(266, 13);
            this.label_ArduinoPort.TabIndex = 0;
            this.label_ArduinoPort.Text = "¿En qué puerto se encuentra el Arduino/Genuino?";
            // 
            // comboBox_Ports
            // 
            this.comboBox_Ports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Ports.FormattingEnabled = true;
            this.comboBox_Ports.Location = new System.Drawing.Point(9, 29);
            this.comboBox_Ports.Name = "comboBox_Ports";
            this.comboBox_Ports.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Ports.TabIndex = 2;
            // 
            // imageList_Icons
            // 
            this.imageList_Icons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Icons.ImageStream")));
            this.imageList_Icons.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Icons.Images.SetKeyName(0, "write_icon.png");
            this.imageList_Icons.Images.SetKeyName(1, "config_icon.png");
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Image = global::openBraille.Properties.Resources.logo;
            this.pictureBox_Logo.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(480, 125);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Logo.TabIndex = 0;
            this.pictureBox_Logo.TabStop = false;
            // 
            // openFileDialog_ReadFile
            // 
            this.openFileDialog_ReadFile.Filter = "Archivos de texto (*.txt)|*.txt";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 461);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.pictureBox_Logo);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "openBraille";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Write.ResumeLayout(false);
            this.tabPage_Write.PerformLayout();
            this.groupBox_FileWrite.ResumeLayout(false);
            this.groupBox_TextWrite.ResumeLayout(false);
            this.groupBox_WriteOptions.ResumeLayout(false);
            this.groupBox_WriteOptions.PerformLayout();
            this.tabPage_Config.ResumeLayout(false);
            this.tabPage_Config.PerformLayout();
            this.groupBox_Calibration.ResumeLayout(false);
            this.groupBox_Calibration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Delay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Arduino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Logo;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Write;
        private System.Windows.Forms.TabPage tabPage_Config;
        private System.Windows.Forms.ImageList imageList_Icons;
        private System.Windows.Forms.RichTextBox richTextBox_InputText;
        private System.Windows.Forms.GroupBox groupBox_TextWrite;
        private System.Windows.Forms.GroupBox groupBox_WriteOptions;
        private System.Windows.Forms.RadioButton radioButton_Text;
        private System.Windows.Forms.RadioButton radioButton_File;
        private System.Windows.Forms.GroupBox groupBox_FileWrite;
        private System.Windows.Forms.Label label_FileName;
        private System.Windows.Forms.Button button_File;
        private System.Windows.Forms.Button button_Write;
        private System.Windows.Forms.Label label_Progress;
        private System.Windows.Forms.ComboBox comboBox_Ports;
        private System.Windows.Forms.PictureBox pictureBox_Arduino;
        private System.Windows.Forms.Label label_ArduinoPort;
        private System.Windows.Forms.Label label_WaitTime;
        private System.Windows.Forms.Label label_Seconds;
        private System.Windows.Forms.NumericUpDown numericUpDown_Delay;
        private System.Windows.Forms.GroupBox groupBox_Calibration;
        private System.Windows.Forms.Button button_A0U;
        private System.Windows.Forms.Label label_Calibrate;
        private System.Windows.Forms.Button button_B0U;
        private System.Windows.Forms.Button button_A0D;
        private System.Windows.Forms.Label label_Octagon1;
        private System.Windows.Forms.Button button_B0D;
        private System.Windows.Forms.Label label_Octagon2;
        private System.Windows.Forms.Button button_B2D;
        private System.Windows.Forms.Label label_Octagon6;
        private System.Windows.Forms.Button button_B2U;
        private System.Windows.Forms.Button button_A2D;
        private System.Windows.Forms.Label label_Octagon5;
        private System.Windows.Forms.Button button_A2U;
        private System.Windows.Forms.Button button_B1D;
        private System.Windows.Forms.Label label_Octagon4;
        private System.Windows.Forms.Button button_B1U;
        private System.Windows.Forms.Button button_A1D;
        private System.Windows.Forms.Label label_Octagon3;
        private System.Windows.Forms.Button button_A1U;
        private System.Windows.Forms.Button button_Reload;
        private System.Windows.Forms.OpenFileDialog openFileDialog_ReadFile;
    }
}

