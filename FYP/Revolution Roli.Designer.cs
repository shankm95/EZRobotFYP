namespace FYP
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Movement = new System.Windows.Forms.GroupBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.Connection = new System.Windows.Forms.GroupBox();
            this.ucezB_Connect1 = new EZ_B.UCEZB_Connect();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.btnBow = new System.Windows.Forms.Button();
            this.btnPickUp = new System.Windows.Forms.Button();
            this.btnSalute = new System.Windows.Forms.Button();
            this.btnWaveLeft = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnGorilla = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Movement.SuspendLayout();
            this.Connection.SuspendLayout();
            this.Actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(379, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(232, 160);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(620, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // Movement
            // 
            this.Movement.Controls.Add(this.btnReverse);
            this.Movement.Controls.Add(this.btnLeft);
            this.Movement.Controls.Add(this.btnRight);
            this.Movement.Controls.Add(this.btnForward);
            this.Movement.Controls.Add(this.btnStop);
            this.Movement.Location = new System.Drawing.Point(379, 252);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(309, 292);
            this.Movement.TabIndex = 44;
            this.Movement.TabStop = false;
            this.Movement.Text = "Movement";
            // 
            // btnReverse
            // 
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.Image = ((System.Drawing.Image)(resources.GetObject("btnReverse.Image")));
            this.btnReverse.Location = new System.Drawing.Point(120, 248);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(59, 38);
            this.btnReverse.TabIndex = 26;
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(15, 128);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(44, 54);
            this.btnLeft.TabIndex = 28;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(241, 128);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(51, 59);
            this.btnRight.TabIndex = 30;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnForward
            // 
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(120, 19);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(51, 43);
            this.btnForward.TabIndex = 24;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(65, 68);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(170, 170);
            this.btnStop.TabIndex = 0;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.ucezB_Connect1);
            this.Connection.Location = new System.Drawing.Point(12, 12);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(311, 59);
            this.Connection.TabIndex = 43;
            this.Connection.TabStop = false;
            this.Connection.Text = "Connection";
            // 
            // ucezB_Connect1
            // 
            this.ucezB_Connect1.Location = new System.Drawing.Point(6, 19);
            this.ucezB_Connect1.Name = "ucezB_Connect1";
            this.ucezB_Connect1.Port = "COM3";
            this.ucezB_Connect1.ShowDebugButton = true;
            this.ucezB_Connect1.Size = new System.Drawing.Size(283, 31);
            this.ucezB_Connect1.TabIndex = 0;
            this.ucezB_Connect1.TCPPassword = null;
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.btnBow);
            this.Actions.Controls.Add(this.btnPickUp);
            this.Actions.Controls.Add(this.btnSalute);
            this.Actions.Controls.Add(this.btnWaveLeft);
            this.Actions.Controls.Add(this.btn);
            this.Actions.Controls.Add(this.btnGorilla);
            this.Actions.Location = new System.Drawing.Point(329, 12);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(571, 68);
            this.Actions.TabIndex = 42;
            this.Actions.TabStop = false;
            this.Actions.Text = "Actions";
            // 
            // btnBow
            // 
            this.btnBow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBow.Location = new System.Drawing.Point(6, 19);
            this.btnBow.Name = "btnBow";
            this.btnBow.Size = new System.Drawing.Size(88, 40);
            this.btnBow.TabIndex = 1;
            this.btnBow.Text = "Bow";
            this.btnBow.UseVisualStyleBackColor = true;
            this.btnBow.Click += new System.EventHandler(this.btnBow_Click);
            // 
            // btnPickUp
            // 
            this.btnPickUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPickUp.Location = new System.Drawing.Point(100, 19);
            this.btnPickUp.Name = "btnPickUp";
            this.btnPickUp.Size = new System.Drawing.Size(88, 40);
            this.btnPickUp.TabIndex = 2;
            this.btnPickUp.Text = "Pick Up";
            this.btnPickUp.UseVisualStyleBackColor = true;
            this.btnPickUp.Click += new System.EventHandler(this.btnPickUp_Click);
            // 
            // btnSalute
            // 
            this.btnSalute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalute.Location = new System.Drawing.Point(194, 19);
            this.btnSalute.Name = "btnSalute";
            this.btnSalute.Size = new System.Drawing.Size(88, 40);
            this.btnSalute.TabIndex = 3;
            this.btnSalute.Text = "Salute";
            this.btnSalute.UseVisualStyleBackColor = true;
            this.btnSalute.Click += new System.EventHandler(this.btnSalute_Click);
            // 
            // btnWaveLeft
            // 
            this.btnWaveLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaveLeft.Location = new System.Drawing.Point(288, 19);
            this.btnWaveLeft.Name = "btnWaveLeft";
            this.btnWaveLeft.Size = new System.Drawing.Size(88, 40);
            this.btnWaveLeft.TabIndex = 4;
            this.btnWaveLeft.Text = "Wave Left";
            this.btnWaveLeft.UseVisualStyleBackColor = true;
            this.btnWaveLeft.Click += new System.EventHandler(this.btnWaveLeft_Click);
            // 
            // btn
            // 
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Location = new System.Drawing.Point(382, 19);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(88, 40);
            this.btn.TabIndex = 5;
            this.btn.Text = "Wave Right";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGorilla
            // 
            this.btnGorilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGorilla.Location = new System.Drawing.Point(476, 19);
            this.btnGorilla.Name = "btnGorilla";
            this.btnGorilla.Size = new System.Drawing.Size(88, 40);
            this.btnGorilla.TabIndex = 6;
            this.btnGorilla.Text = "Gorilla";
            this.btnGorilla.UseVisualStyleBackColor = true;
            this.btnGorilla.Click += new System.EventHandler(this.btnGorilla_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 86);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 286);
            this.textBox1.TabIndex = 41;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 556);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Movement);
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.textBox1);
            this.Name = "Form3";
            this.Text = "Revolution Roli";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Movement.ResumeLayout(false);
            this.Connection.ResumeLayout(false);
            this.Actions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox Movement;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox Connection;
        private EZ_B.UCEZB_Connect ucezB_Connect1;
        private System.Windows.Forms.GroupBox Actions;
        private System.Windows.Forms.Button btnBow;
        private System.Windows.Forms.Button btnPickUp;
        private System.Windows.Forms.Button btnSalute;
        private System.Windows.Forms.Button btnWaveLeft;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnGorilla;
        private System.Windows.Forms.TextBox textBox1;
    }
}