namespace FYP {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ucezB_Connect1 = new EZ_B.UCEZB_Connect();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLegsUpDown = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnBounceDance = new System.Windows.Forms.Button();
            this.btnCircleDance = new System.Windows.Forms.Button();
            this.btnCurlDance = new System.Windows.Forms.Button();
            this.btnHappyDance = new System.Windows.Forms.Button();
            this.btnHeadStandDance = new System.Windows.Forms.Button();
            this.btnLegsUpDance = new System.Windows.Forms.Button();
            this.btnMarchOnSpot = new System.Windows.Forms.Button();
            this.btnPushUp = new System.Windows.Forms.Button();
            this.btnRockBackAndForth = new System.Windows.Forms.Button();
            this.btnRotateLegsDance = new System.Windows.Forms.Button();
            this.btnShutdown = new System.Windows.Forms.Button();
            this.btnSwim = new System.Windows.Forms.Button();
            this.btnWave = new System.Windows.Forms.Button();
            this.btnWaveDance = new System.Windows.Forms.Button();
            this.Actions = new System.Windows.Forms.GroupBox();
            this.btnByeWave = new System.Windows.Forms.Button();
            this.btnMorningGreeting = new System.Windows.Forms.Button();
            this.btnHiWave = new System.Windows.Forms.Button();
            this.Connection = new System.Windows.Forms.GroupBox();
            this.btnFastForward = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnFastReverse = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnFastLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnFastRight = new System.Windows.Forms.Button();
            this.Movement = new System.Windows.Forms.GroupBox();
            this.btnStrafeRight = new System.Windows.Forms.Button();
            this.btnStrafeLeft = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Actions.SuspendLayout();
            this.Connection.SuspendLayout();
            this.Movement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 241);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 168);
            this.textBox1.TabIndex = 3;
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
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.Location = new System.Drawing.Point(147, 141);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(170, 170);
            this.btnStop.TabIndex = 0;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 40);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "3 Legs Dance";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLegsUpDown
            // 
            this.btnLegsUpDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLegsUpDown.Location = new System.Drawing.Point(100, 19);
            this.btnLegsUpDown.Name = "btnLegsUpDown";
            this.btnLegsUpDown.Size = new System.Drawing.Size(88, 40);
            this.btnLegsUpDown.TabIndex = 2;
            this.btnLegsUpDown.Text = "3 Legs Up Down";
            this.btnLegsUpDown.UseVisualStyleBackColor = true;
            this.btnLegsUpDown.Click += new System.EventHandler(this.btnLegsUpDown_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Location = new System.Drawing.Point(194, 19);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(88, 40);
            this.btnAttack.TabIndex = 3;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnBounceDance
            // 
            this.btnBounceDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBounceDance.Location = new System.Drawing.Point(288, 19);
            this.btnBounceDance.Name = "btnBounceDance";
            this.btnBounceDance.Size = new System.Drawing.Size(88, 40);
            this.btnBounceDance.TabIndex = 4;
            this.btnBounceDance.Text = "Bounce Dance";
            this.btnBounceDance.UseVisualStyleBackColor = true;
            this.btnBounceDance.Click += new System.EventHandler(this.btnBounceDance_Click);
            // 
            // btnCircleDance
            // 
            this.btnCircleDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircleDance.Location = new System.Drawing.Point(476, 19);
            this.btnCircleDance.Name = "btnCircleDance";
            this.btnCircleDance.Size = new System.Drawing.Size(88, 40);
            this.btnCircleDance.TabIndex = 6;
            this.btnCircleDance.Text = "Circle Dance";
            this.btnCircleDance.UseVisualStyleBackColor = true;
            this.btnCircleDance.Click += new System.EventHandler(this.btnCircleDance_Click);
            // 
            // btnCurlDance
            // 
            this.btnCurlDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurlDance.Location = new System.Drawing.Point(570, 19);
            this.btnCurlDance.Name = "btnCurlDance";
            this.btnCurlDance.Size = new System.Drawing.Size(88, 40);
            this.btnCurlDance.TabIndex = 7;
            this.btnCurlDance.Text = "Curl Dance";
            this.btnCurlDance.UseVisualStyleBackColor = true;
            this.btnCurlDance.Click += new System.EventHandler(this.btnCurlDance_Click);
            // 
            // btnHappyDance
            // 
            this.btnHappyDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHappyDance.Location = new System.Drawing.Point(664, 19);
            this.btnHappyDance.Name = "btnHappyDance";
            this.btnHappyDance.Size = new System.Drawing.Size(88, 40);
            this.btnHappyDance.TabIndex = 8;
            this.btnHappyDance.Text = "Happy Dance";
            this.btnHappyDance.UseVisualStyleBackColor = true;
            this.btnHappyDance.Click += new System.EventHandler(this.btnHappyDance_Click);
            // 
            // btnHeadStandDance
            // 
            this.btnHeadStandDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHeadStandDance.Location = new System.Drawing.Point(758, 19);
            this.btnHeadStandDance.Name = "btnHeadStandDance";
            this.btnHeadStandDance.Size = new System.Drawing.Size(88, 40);
            this.btnHeadStandDance.TabIndex = 9;
            this.btnHeadStandDance.Text = "Head Stand Dance";
            this.btnHeadStandDance.UseVisualStyleBackColor = true;
            this.btnHeadStandDance.Click += new System.EventHandler(this.btnHeadStandDance_Click);
            // 
            // btnLegsUpDance
            // 
            this.btnLegsUpDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLegsUpDance.Location = new System.Drawing.Point(100, 65);
            this.btnLegsUpDance.Name = "btnLegsUpDance";
            this.btnLegsUpDance.Size = new System.Drawing.Size(88, 40);
            this.btnLegsUpDance.TabIndex = 11;
            this.btnLegsUpDance.Text = "Legs Up Dance";
            this.btnLegsUpDance.UseVisualStyleBackColor = true;
            this.btnLegsUpDance.Click += new System.EventHandler(this.btnLegsUpDance_Click);
            // 
            // btnMarchOnSpot
            // 
            this.btnMarchOnSpot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarchOnSpot.Location = new System.Drawing.Point(195, 65);
            this.btnMarchOnSpot.Name = "btnMarchOnSpot";
            this.btnMarchOnSpot.Size = new System.Drawing.Size(88, 40);
            this.btnMarchOnSpot.TabIndex = 12;
            this.btnMarchOnSpot.Text = "March On Spot";
            this.btnMarchOnSpot.UseVisualStyleBackColor = true;
            this.btnMarchOnSpot.Click += new System.EventHandler(this.btnMarchOnSpot_Click);
            // 
            // btnPushUp
            // 
            this.btnPushUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPushUp.Location = new System.Drawing.Point(382, 65);
            this.btnPushUp.Name = "btnPushUp";
            this.btnPushUp.Size = new System.Drawing.Size(88, 40);
            this.btnPushUp.TabIndex = 14;
            this.btnPushUp.Text = "Push Up";
            this.btnPushUp.UseVisualStyleBackColor = true;
            this.btnPushUp.Click += new System.EventHandler(this.btnPushUp_Click);
            // 
            // btnRockBackAndForth
            // 
            this.btnRockBackAndForth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRockBackAndForth.Location = new System.Drawing.Point(476, 65);
            this.btnRockBackAndForth.Name = "btnRockBackAndForth";
            this.btnRockBackAndForth.Size = new System.Drawing.Size(88, 40);
            this.btnRockBackAndForth.TabIndex = 15;
            this.btnRockBackAndForth.Text = "Rock Back and Forth";
            this.btnRockBackAndForth.UseVisualStyleBackColor = true;
            this.btnRockBackAndForth.Click += new System.EventHandler(this.btnRockBackAndForth_Click);
            // 
            // btnRotateLegsDance
            // 
            this.btnRotateLegsDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateLegsDance.Location = new System.Drawing.Point(570, 65);
            this.btnRotateLegsDance.Name = "btnRotateLegsDance";
            this.btnRotateLegsDance.Size = new System.Drawing.Size(88, 40);
            this.btnRotateLegsDance.TabIndex = 16;
            this.btnRotateLegsDance.Text = "Rotate Legs Dance";
            this.btnRotateLegsDance.UseVisualStyleBackColor = true;
            this.btnRotateLegsDance.Click += new System.EventHandler(this.btnRotateLegsDance_Click);
            // 
            // btnShutdown
            // 
            this.btnShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShutdown.Location = new System.Drawing.Point(664, 65);
            this.btnShutdown.Name = "btnShutdown";
            this.btnShutdown.Size = new System.Drawing.Size(88, 40);
            this.btnShutdown.TabIndex = 17;
            this.btnShutdown.Text = "Shutdown";
            this.btnShutdown.UseVisualStyleBackColor = true;
            this.btnShutdown.Click += new System.EventHandler(this.btnShutdown_Click);
            // 
            // btnSwim
            // 
            this.btnSwim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwim.Location = new System.Drawing.Point(758, 65);
            this.btnSwim.Name = "btnSwim";
            this.btnSwim.Size = new System.Drawing.Size(88, 40);
            this.btnSwim.TabIndex = 18;
            this.btnSwim.Text = "Swim";
            this.btnSwim.UseVisualStyleBackColor = true;
            this.btnSwim.Click += new System.EventHandler(this.btnSwim_Click);
            // 
            // btnWave
            // 
            this.btnWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWave.Location = new System.Drawing.Point(289, 112);
            this.btnWave.Name = "btnWave";
            this.btnWave.Size = new System.Drawing.Size(88, 40);
            this.btnWave.TabIndex = 19;
            this.btnWave.Text = "Wave";
            this.btnWave.UseVisualStyleBackColor = true;
            this.btnWave.Click += new System.EventHandler(this.btnWave_Click);
            // 
            // btnWaveDance
            // 
            this.btnWaveDance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWaveDance.Location = new System.Drawing.Point(477, 111);
            this.btnWaveDance.Name = "btnWaveDance";
            this.btnWaveDance.Size = new System.Drawing.Size(88, 40);
            this.btnWaveDance.TabIndex = 20;
            this.btnWaveDance.Text = "Wave Dance";
            this.btnWaveDance.UseVisualStyleBackColor = true;
            this.btnWaveDance.Click += new System.EventHandler(this.btnWaveDance_Click);
            // 
            // Actions
            // 
            this.Actions.Controls.Add(this.btnStart);
            this.Actions.Controls.Add(this.btnWaveDance);
            this.Actions.Controls.Add(this.btnLegsUpDown);
            this.Actions.Controls.Add(this.btnWave);
            this.Actions.Controls.Add(this.btnAttack);
            this.Actions.Controls.Add(this.btnSwim);
            this.Actions.Controls.Add(this.btnBounceDance);
            this.Actions.Controls.Add(this.btnShutdown);
            this.Actions.Controls.Add(this.btnByeWave);
            this.Actions.Controls.Add(this.btnRotateLegsDance);
            this.Actions.Controls.Add(this.btnCircleDance);
            this.Actions.Controls.Add(this.btnRockBackAndForth);
            this.Actions.Controls.Add(this.btnCurlDance);
            this.Actions.Controls.Add(this.btnPushUp);
            this.Actions.Controls.Add(this.btnHappyDance);
            this.Actions.Controls.Add(this.btnMorningGreeting);
            this.Actions.Controls.Add(this.btnHeadStandDance);
            this.Actions.Controls.Add(this.btnMarchOnSpot);
            this.Actions.Controls.Add(this.btnHiWave);
            this.Actions.Controls.Add(this.btnLegsUpDance);
            this.Actions.Location = new System.Drawing.Point(12, 77);
            this.Actions.Name = "Actions";
            this.Actions.Size = new System.Drawing.Size(860, 158);
            this.Actions.TabIndex = 21;
            this.Actions.TabStop = false;
            this.Actions.Text = "Actions";
            // 
            // btnByeWave
            // 
            this.btnByeWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnByeWave.Location = new System.Drawing.Point(382, 19);
            this.btnByeWave.Name = "btnByeWave";
            this.btnByeWave.Size = new System.Drawing.Size(88, 40);
            this.btnByeWave.TabIndex = 5;
            this.btnByeWave.Text = "Bye Wave";
            this.btnByeWave.UseVisualStyleBackColor = true;
            this.btnByeWave.Click += new System.EventHandler(this.btnByeWave_Click);
            // 
            // btnMorningGreeting
            // 
            this.btnMorningGreeting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMorningGreeting.Location = new System.Drawing.Point(289, 65);
            this.btnMorningGreeting.Name = "btnMorningGreeting";
            this.btnMorningGreeting.Size = new System.Drawing.Size(88, 40);
            this.btnMorningGreeting.TabIndex = 13;
            this.btnMorningGreeting.Text = "Morning Greeting";
            this.btnMorningGreeting.UseVisualStyleBackColor = true;
            this.btnMorningGreeting.Click += new System.EventHandler(this.btnMorningGreeting_Click);
            // 
            // btnHiWave
            // 
            this.btnHiWave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHiWave.Location = new System.Drawing.Point(6, 65);
            this.btnHiWave.Name = "btnHiWave";
            this.btnHiWave.Size = new System.Drawing.Size(88, 40);
            this.btnHiWave.TabIndex = 10;
            this.btnHiWave.Text = "Hi Wave";
            this.btnHiWave.UseVisualStyleBackColor = true;
            this.btnHiWave.Click += new System.EventHandler(this.btnHiWave_Click);
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.ucezB_Connect1);
            this.Connection.Location = new System.Drawing.Point(12, 12);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(311, 59);
            this.Connection.TabIndex = 22;
            this.Connection.TabStop = false;
            this.Connection.Text = "Connection";
            // 
            // btnFastForward
            // 
            this.btnFastForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastForward.Image = ((System.Drawing.Image)(resources.GetObject("btnFastForward.Image")));
            this.btnFastForward.Location = new System.Drawing.Point(199, 19);
            this.btnFastForward.Name = "btnFastForward";
            this.btnFastForward.Size = new System.Drawing.Size(51, 67);
            this.btnFastForward.TabIndex = 23;
            this.btnFastForward.UseVisualStyleBackColor = true;
            this.btnFastForward.Click += new System.EventHandler(this.btnFastForward_Click);
            // 
            // btnForward
            // 
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.Image = ((System.Drawing.Image)(resources.GetObject("btnForward.Image")));
            this.btnForward.Location = new System.Drawing.Point(199, 92);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(51, 43);
            this.btnForward.TabIndex = 24;
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReverse.Image = ((System.Drawing.Image)(resources.GetObject("btnReverse.Image")));
            this.btnReverse.Location = new System.Drawing.Point(199, 317);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(59, 38);
            this.btnReverse.TabIndex = 26;
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnFastReverse
            // 
            this.btnFastReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastReverse.Image = ((System.Drawing.Image)(resources.GetObject("btnFastReverse.Image")));
            this.btnFastReverse.Location = new System.Drawing.Point(199, 361);
            this.btnFastReverse.Name = "btnFastReverse";
            this.btnFastReverse.Size = new System.Drawing.Size(59, 71);
            this.btnFastReverse.TabIndex = 25;
            this.btnFastReverse.UseVisualStyleBackColor = true;
            this.btnFastReverse.Click += new System.EventHandler(this.btnFastReverse_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(97, 199);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(44, 54);
            this.btnLeft.TabIndex = 28;
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnFastLeft
            // 
            this.btnFastLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnFastLeft.Image")));
            this.btnFastLeft.Location = new System.Drawing.Point(25, 199);
            this.btnFastLeft.Name = "btnFastLeft";
            this.btnFastLeft.Size = new System.Drawing.Size(69, 54);
            this.btnFastLeft.TabIndex = 27;
            this.btnFastLeft.UseVisualStyleBackColor = true;
            this.btnFastLeft.Click += new System.EventHandler(this.btnFastLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(323, 197);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(51, 59);
            this.btnRight.TabIndex = 30;
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnFastRight
            // 
            this.btnFastRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFastRight.Image = ((System.Drawing.Image)(resources.GetObject("btnFastRight.Image")));
            this.btnFastRight.Location = new System.Drawing.Point(380, 197);
            this.btnFastRight.Name = "btnFastRight";
            this.btnFastRight.Size = new System.Drawing.Size(74, 59);
            this.btnFastRight.TabIndex = 29;
            this.btnFastRight.UseVisualStyleBackColor = true;
            this.btnFastRight.Click += new System.EventHandler(this.btnFastRight_Click);
            // 
            // Movement
            // 
            this.Movement.Controls.Add(this.btnStrafeRight);
            this.Movement.Controls.Add(this.btnStrafeLeft);
            this.Movement.Controls.Add(this.btnRotateRight);
            this.Movement.Controls.Add(this.btnRotateLeft);
            this.Movement.Controls.Add(this.btnFastForward);
            this.Movement.Controls.Add(this.btnFastReverse);
            this.Movement.Controls.Add(this.btnReverse);
            this.Movement.Controls.Add(this.btnFastLeft);
            this.Movement.Controls.Add(this.btnLeft);
            this.Movement.Controls.Add(this.btnFastRight);
            this.Movement.Controls.Add(this.btnRight);
            this.Movement.Controls.Add(this.btnForward);
            this.Movement.Controls.Add(this.btnStop);
            this.Movement.Location = new System.Drawing.Point(379, 241);
            this.Movement.Name = "Movement";
            this.Movement.Size = new System.Drawing.Size(479, 437);
            this.Movement.TabIndex = 31;
            this.Movement.TabStop = false;
            this.Movement.Text = "Movement";
            // 
            // btnStrafeRight
            // 
            this.btnStrafeRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrafeRight.Image = ((System.Drawing.Image)(resources.GetObject("btnStrafeRight.Image")));
            this.btnStrafeRight.Location = new System.Drawing.Point(323, 317);
            this.btnStrafeRight.Name = "btnStrafeRight";
            this.btnStrafeRight.Size = new System.Drawing.Size(131, 59);
            this.btnStrafeRight.TabIndex = 34;
            this.btnStrafeRight.UseVisualStyleBackColor = true;
            this.btnStrafeRight.Click += new System.EventHandler(this.btnStrafeRight_Click);
            // 
            // btnStrafeLeft
            // 
            this.btnStrafeLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrafeLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnStrafeLeft.Image")));
            this.btnStrafeLeft.Location = new System.Drawing.Point(25, 317);
            this.btnStrafeLeft.Name = "btnStrafeLeft";
            this.btnStrafeLeft.Size = new System.Drawing.Size(116, 59);
            this.btnStrafeLeft.TabIndex = 33;
            this.btnStrafeLeft.UseVisualStyleBackColor = true;
            this.btnStrafeLeft.Click += new System.EventHandler(this.btnStrafeLeft_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateRight.Image")));
            this.btnRotateRight.Location = new System.Drawing.Point(323, 19);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(131, 123);
            this.btnRotateRight.TabIndex = 32;
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnRotateLeft.Image")));
            this.btnRotateLeft.Location = new System.Drawing.Point(25, 19);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(134, 116);
            this.btnRotateLeft.TabIndex = 31;
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 415);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(214, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 570);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 717);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Movement);
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.Actions);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Revolution Six";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Actions.ResumeLayout(false);
            this.Connection.ResumeLayout(false);
            this.Movement.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private EZ_B.UCEZB_Connect ucezB_Connect1;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.Button btnStart;
    private System.Windows.Forms.Button btnLegsUpDown;
    private System.Windows.Forms.Button btnAttack;
    private System.Windows.Forms.Button btnBounceDance;
    private System.Windows.Forms.Button btnCircleDance;
    private System.Windows.Forms.Button btnCurlDance;
    private System.Windows.Forms.Button btnHappyDance;
    private System.Windows.Forms.Button btnHeadStandDance;
    private System.Windows.Forms.Button btnLegsUpDance;
    private System.Windows.Forms.Button btnMarchOnSpot;
    private System.Windows.Forms.Button btnPushUp;
    private System.Windows.Forms.Button btnRockBackAndForth;
    private System.Windows.Forms.Button btnRotateLegsDance;
    private System.Windows.Forms.Button btnShutdown;
    private System.Windows.Forms.Button btnSwim;
    private System.Windows.Forms.Button btnWave;
    private System.Windows.Forms.Button btnWaveDance;
    private System.Windows.Forms.GroupBox Actions;
    private System.Windows.Forms.GroupBox Connection;
    private System.Windows.Forms.Button btnFastForward;
    private System.Windows.Forms.Button btnForward;
    private System.Windows.Forms.Button btnReverse;
    private System.Windows.Forms.Button btnFastReverse;
    private System.Windows.Forms.Button btnLeft;
    private System.Windows.Forms.Button btnFastLeft;
    private System.Windows.Forms.Button btnRight;
    private System.Windows.Forms.Button btnFastRight;
    private System.Windows.Forms.GroupBox Movement;
    private System.Windows.Forms.Button btnStrafeRight;
    private System.Windows.Forms.Button btnStrafeLeft;
    private System.Windows.Forms.Button btnRotateRight;
    private System.Windows.Forms.Button btnRotateLeft;
    private System.Windows.Forms.PictureBox pictureBox2;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Button btnByeWave;
    private System.Windows.Forms.Button btnMorningGreeting;
    private System.Windows.Forms.Button btnHiWave;
  }
}

