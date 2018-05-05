namespace DrosteBot
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusText = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.hstimer = new System.Windows.Forms.Timer(this.components);
            this.goingTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxPenDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxPenUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxLt45 = new System.Windows.Forms.PictureBox();
            this.pictureBoxRt45 = new System.Windows.Forms.PictureBox();
            this.pictureBoxConnect = new System.Windows.Forms.PictureBox();
            this.pictureBoxClear = new System.Windows.Forms.PictureBox();
            this.pictureBoxDelete = new System.Windows.Forms.PictureBox();
            this.pictureBoxGo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxFront = new System.Windows.Forms.PictureBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPenDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPenUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLt45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRt45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.port_DataReceived_1);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(559, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TabStop = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 211);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // statusText
            // 
            this.statusText.BackColor = System.Drawing.Color.White;
            this.statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusText.Location = new System.Drawing.Point(12, 21);
            this.statusText.Multiline = true;
            this.statusText.Name = "statusText";
            this.statusText.ReadOnly = true;
            this.statusText.Size = new System.Drawing.Size(523, 28);
            this.statusText.TabIndex = 67;
            this.statusText.TabStop = false;
            this.statusText.Text = "Escolha uma porta e estabeleça a ligação...";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-scroll-up-48.png");
            this.imageList1.Images.SetKeyName(1, "icons8-forward-button-48.png");
            this.imageList1.Images.SetKeyName(2, "icons8-scroll-down-48.png");
            this.imageList1.Images.SetKeyName(3, "icons8-back-arrow-48.png");
            this.imageList1.Images.SetKeyName(4, "icons8-scroll-penup-48.png");
            this.imageList1.Images.SetKeyName(5, "icons8-scroll-pendown-48.png");
            this.imageList1.Images.SetKeyName(6, "icons8-scroll-rt45-48.png");
            this.imageList1.Images.SetKeyName(7, "icons8-scroll-lt45-48.png");
            // 
            // hstimer
            // 
            this.hstimer.Interval = 10000;
            this.hstimer.Tick += new System.EventHandler(this.hstimer_Tick);
            // 
            // goingTimer
            // 
            this.goingTimer.Interval = 10000;
            this.goingTimer.Tick += new System.EventHandler(this.goingTimer_Tick);
            // 
            // pictureBoxPenDown
            // 
            this.pictureBoxPenDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPenDown.Enabled = false;
            this.pictureBoxPenDown.Image = global::DrosteBot.Properties.Resources.pen_down;
            this.pictureBoxPenDown.Location = new System.Drawing.Point(332, 567);
            this.pictureBoxPenDown.Name = "pictureBoxPenDown";
            this.pictureBoxPenDown.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxPenDown.TabIndex = 71;
            this.pictureBoxPenDown.TabStop = false;
            this.pictureBoxPenDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPenDown_MouseDown);
            this.pictureBoxPenDown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPenDown_MouseUp);
            // 
            // pictureBoxPenUp
            // 
            this.pictureBoxPenUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPenUp.Enabled = false;
            this.pictureBoxPenUp.Image = global::DrosteBot.Properties.Resources.pen;
            this.pictureBoxPenUp.Location = new System.Drawing.Point(61, 567);
            this.pictureBoxPenUp.Name = "pictureBoxPenUp";
            this.pictureBoxPenUp.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxPenUp.TabIndex = 70;
            this.pictureBoxPenUp.TabStop = false;
            this.pictureBoxPenUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPenUp_MouseDown);
            this.pictureBoxPenUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPenUp_MouseUp);
            // 
            // pictureBoxLt45
            // 
            this.pictureBoxLt45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLt45.Enabled = false;
            this.pictureBoxLt45.Image = global::DrosteBot.Properties.Resources.if_direction_lf45;
            this.pictureBoxLt45.Location = new System.Drawing.Point(60, 297);
            this.pictureBoxLt45.Name = "pictureBoxLt45";
            this.pictureBoxLt45.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxLt45.TabIndex = 69;
            this.pictureBoxLt45.TabStop = false;
            this.pictureBoxLt45.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLt45_MouseDown);
            this.pictureBoxLt45.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLt45_MouseUp);
            // 
            // pictureBoxRt45
            // 
            this.pictureBoxRt45.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRt45.Enabled = false;
            this.pictureBoxRt45.Image = global::DrosteBot.Properties.Resources.if_direction_rt45;
            this.pictureBoxRt45.Location = new System.Drawing.Point(332, 297);
            this.pictureBoxRt45.Name = "pictureBoxRt45";
            this.pictureBoxRt45.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxRt45.TabIndex = 68;
            this.pictureBoxRt45.TabStop = false;
            this.pictureBoxRt45.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRt45_MouseDown);
            this.pictureBoxRt45.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRt45_MouseUp);
            // 
            // pictureBoxConnect
            // 
            this.pictureBoxConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxConnect.Enabled = false;
            this.pictureBoxConnect.Image = global::DrosteBot.Properties.Resources.icons8_disconnected_48;
            this.pictureBoxConnect.Location = new System.Drawing.Point(668, 21);
            this.pictureBoxConnect.Name = "pictureBoxConnect";
            this.pictureBoxConnect.Size = new System.Drawing.Size(27, 28);
            this.pictureBoxConnect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxConnect.TabIndex = 66;
            this.pictureBoxConnect.TabStop = false;
            this.pictureBoxConnect.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxConnect_MouseDown);
            this.pictureBoxConnect.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxConnect_MouseUp);
            // 
            // pictureBoxClear
            // 
            this.pictureBoxClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClear.Enabled = false;
            this.pictureBoxClear.Image = global::DrosteBot.Properties.Resources.if_notification_error_48785;
            this.pictureBoxClear.Location = new System.Drawing.Point(519, 523);
            this.pictureBoxClear.Name = "pictureBoxClear";
            this.pictureBoxClear.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxClear.TabIndex = 65;
            this.pictureBoxClear.TabStop = false;
            this.pictureBoxClear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClear_MouseDown);
            this.pictureBoxClear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxClear_MouseUp);
            // 
            // pictureBoxDelete
            // 
            this.pictureBoxDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDelete.Enabled = false;
            this.pictureBoxDelete.Image = global::DrosteBot.Properties.Resources.if_notification_remove_48786;
            this.pictureBoxDelete.Location = new System.Drawing.Point(519, 345);
            this.pictureBoxDelete.Name = "pictureBoxDelete";
            this.pictureBoxDelete.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxDelete.TabIndex = 64;
            this.pictureBoxDelete.TabStop = false;
            this.pictureBoxDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDelete_MouseDown);
            this.pictureBoxDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxDelete_MouseUp);
            // 
            // pictureBoxGo
            // 
            this.pictureBoxGo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxGo.Enabled = false;
            this.pictureBoxGo.Image = global::DrosteBot.Properties.Resources.if_notification_done_48784;
            this.pictureBoxGo.Location = new System.Drawing.Point(195, 432);
            this.pictureBoxGo.Name = "pictureBoxGo";
            this.pictureBoxGo.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxGo.TabIndex = 63;
            this.pictureBoxGo.TabStop = false;
            this.pictureBoxGo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGo_MouseDown);
            this.pictureBoxGo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxGo_MouseUp);
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLeft.Enabled = false;
            this.pictureBoxLeft.Image = global::DrosteBot.Properties.Resources.if_direction_left_48749;
            this.pictureBoxLeft.Location = new System.Drawing.Point(61, 432);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxLeft.TabIndex = 5;
            this.pictureBoxLeft.TabStop = false;
            this.pictureBoxLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLeft_MouseDown);
            this.pictureBoxLeft.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLeft_MouseUp);
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxBack.Enabled = false;
            this.pictureBoxBack.Image = global::DrosteBot.Properties.Resources.if_direction_down_48748;
            this.pictureBoxBack.Location = new System.Drawing.Point(196, 567);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxBack.TabIndex = 4;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBack_MouseDown);
            this.pictureBoxBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBack_MouseUp);
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRight.Enabled = false;
            this.pictureBoxRight.Image = global::DrosteBot.Properties.Resources.if_direction_right_48750;
            this.pictureBoxRight.Location = new System.Drawing.Point(331, 432);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxRight.TabIndex = 3;
            this.pictureBoxRight.TabStop = false;
            this.pictureBoxRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRight_MouseDown);
            this.pictureBoxRight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxRight_MouseUp);
            // 
            // pictureBoxFront
            // 
            this.pictureBoxFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFront.Enabled = false;
            this.pictureBoxFront.Image = global::DrosteBot.Properties.Resources.if_direction_up_48751;
            this.pictureBoxFront.Location = new System.Drawing.Point(196, 297);
            this.pictureBoxFront.Name = "pictureBoxFront";
            this.pictureBoxFront.Size = new System.Drawing.Size(130, 129);
            this.pictureBoxFront.TabIndex = 2;
            this.pictureBoxFront.TabStop = false;
            this.pictureBoxFront.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxFront.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(626, 272);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(69, 26);
            this.numericUpDown1.TabIndex = 72;
            this.numericUpDown1.TabStop = false;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDown1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(541, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "Distância:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(709, 717);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pictureBoxPenDown);
            this.Controls.Add(this.pictureBoxPenUp);
            this.Controls.Add(this.pictureBoxLt45);
            this.Controls.Add(this.pictureBoxRt45);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.pictureBoxConnect);
            this.Controls.Add(this.pictureBoxClear);
            this.Controls.Add(this.pictureBoxDelete);
            this.Controls.Add(this.pictureBoxGo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxLeft);
            this.Controls.Add(this.pictureBoxBack);
            this.Controls.Add(this.pictureBoxRight);
            this.Controls.Add(this.pictureBoxFront);
            this.Controls.Add(this.comboBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "DrosteBot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPenDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPenUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLt45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRt45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.PictureBox pictureBoxFront;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxBack;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxGo;
        private System.Windows.Forms.PictureBox pictureBoxDelete;
        private System.Windows.Forms.PictureBox pictureBoxClear;
        private System.Windows.Forms.PictureBox pictureBoxConnect;
        private System.Windows.Forms.TextBox statusText;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer hstimer;
        private System.Windows.Forms.Timer goingTimer;
        private System.Windows.Forms.PictureBox pictureBoxRt45;
        private System.Windows.Forms.PictureBox pictureBoxLt45;
        private System.Windows.Forms.PictureBox pictureBoxPenUp;
        private System.Windows.Forms.PictureBox pictureBoxPenDown;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

