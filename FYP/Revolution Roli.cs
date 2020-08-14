using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZ_B;

namespace FYP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string bow = string.Empty;
        public string pickupobject = string.Empty;
        public string gorilla = string.Empty;
        public string salute = string.Empty;
        public string waveleft = string.Empty;
        public string waveright = string.Empty;

        private void Form3_Load(object sender, EventArgs e)
        {
            // Assign the EZB instance to a variable so the code looks cleaner
            EZB ezb = ucezB_Connect1.EZB;

            // These are events from the auto positions
            ezb.AutoPosition.OnComplete += AutoPosition_OnComplete;
            ezb.AutoPosition.OnStartAction += AutoPosition_OnStartAction;
            ezb.AutoPosition.OnStartFrame += AutoPosition_OnStartFrame;

            // First we define the servos
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D9); //  0
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D10); // 1
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D12); // 2
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D13); // 3
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D14); // 4
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D15); // 5
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D20); // 6
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D21); // 7
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D22); // 8
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D23); // 9

            //Define & configure Roli Wheels
            ucezB_Connect1.EZB.Movement.MovementType = EZ_B.Movement.MovementTypeEnum.HBridge;
            ucezB_Connect1.EZB.Movement.HBridgeLeftWheelTriggerA = EZ_B.Digital.DigitalPortEnum.D1;
            ucezB_Connect1.EZB.Movement.HBridgeLeftWheelTriggerB = EZ_B.Digital.DigitalPortEnum.D2;
            ucezB_Connect1.EZB.Movement.HBridgeRightWheelTriggerA = EZ_B.Digital.DigitalPortEnum.D3;
            ucezB_Connect1.EZB.Movement.HBridgeRightWheelTriggerB = EZ_B.Digital.DigitalPortEnum.D4;

            // If PWM is configured, uncomment the line below to configure the speed
            ucezB_Connect1.EZB.PWM.SetPWM(EZ_B.Digital.DigitalPortEnum.D0, EZ_B.PWM.PWM_MAX);
            ucezB_Connect1.EZB.PWM.SetPWM(EZ_B.Digital.DigitalPortEnum.D5, EZ_B.PWM.PWM_MAX);

            //ezMovement1.SetEZB = ucezB_Connect1.EZB; 

            //Bow Frames
            string bow1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 70, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
            string bow2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 39, 90, 90, 90, 90, 90, 84, 1, 60, 90 });

            //Bow Action
            bow = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Get Up", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(bow1, 15, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(bow2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bow1, 65, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Pick Up Object Frames
            string pickupobject1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 90, 93, 180, 82, 90, 16, 79, 90 });
            string pickupobject2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 40, 90, 90, 93, 180, 82, 90, 16, 79, 90 });
            string pickupobject3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 40, 90, 90, 93, 180, 82, 88, 25, 145, 90 });
            string pickupobject4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 40, 90, 90, 93, 180, 82, 75, 25, 145, 74 });
            string pickupobject5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 40, 90, 90, 93, 180, 82, 75, 25, 145, 98 });
            string pickupobject6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 40, 90, 90, 93, 180, 82, 105, 25, 99, 74 });
            string pickupobject7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 90, 90, 90, 93, 180, 82, 105, 25, 99, 98 });

            //Pick Up Object Action
            pickupobject = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Pick Up Object", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(pickupobject1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pickupobject2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pickupobject3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pickupobject4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pickupobject5, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pickupobject6, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pickupobject7, 25, 5, -1),
          
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Salute Frames
            string salute1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 97, 95, 180, 90, 90, 15, 83, 95 });
            string salute2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 97, 95, 180, 90, 161, 13, 41, 95 });

            //Salute Action
            salute = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Salute", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(bow1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(bow2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bow1, 105, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Left Wave Frames
            string leftwave1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 83, 100, 58, 81, 180, 7, 180, 90, 90, 90 });
            string leftwave2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 77, 79, 58, 81, 159, 7, 180, 92, 90, 90 });
            string leftwave3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 85, 90, 90, 57, 103, 79, 87, 81, 108, 90 });

            //Left Wave Action
            waveleft = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Left Wave", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(leftwave3, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(leftwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(leftwave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(leftwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(leftwave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(leftwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(leftwave3, 25, 3, 2),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Right Wave Frames
            string rightwave1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 78, 80, 90, 79, 95, 1, 170, 2, 87, 75 });
            string rightwave2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 78, 80, 87, 81, 94, 1, 170, 20, 87, 66 });
            string rightwave3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 85, 90, 90, 57, 103, 79, 87, 81, 108, 90 });

            //Right Wave Action
            waveright = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Right Wave", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(rightwave3, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(rightwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rightwave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rightwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rightwave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rightwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rightwave3, 25, 3, 2),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));
        }


        void AutoPosition_OnStartFrame(AutoPosition sender, EZ_B.Classes.AutoPositionFrame frame, EZ_B.Classes.AutoPositionActionFrame actionFrame)
        {
            Invokers.SetAppendText(textBox1, true, "Frame {0}  (Steps: {1}, Speed: {2}, Delay: {3})", frame.Title, actionFrame.Steps, actionFrame.ServoSpeed, actionFrame.Delay);
        }

        void AutoPosition_OnStartAction(AutoPosition sender, EZ_B.Classes.AutoPositionAction action)
        {
            Invokers.SetAppendText(textBox1, true, "Action Started: {0}", action.Title);
        }

        void AutoPosition_OnComplete(AutoPosition sender)
        {
            Invokers.SetAppendText(textBox1, true, "Action Stopped");
        }

        private void btnBow_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(bow);
        }

        private void btnPickUp_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(pickupobject);
        }

        private void btnSalute_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(salute);
        }

        private void btnWaveLeft_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(waveleft);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(waveright);
        }

        private void btnGorilla_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(gorilla);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.Movement.GoForward();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.Movement.GoReverse();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.Movement.GoLeft();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.Movement.GoRight();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.Movement.GoStop();
        }
    }
}
