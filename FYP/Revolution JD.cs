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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string fly = string.Empty;
        public string getup = string.Empty;
        public string gorilla = string.Empty;
        public string grab = string.Empty;
        public string handsdance = string.Empty;
        public string headbobfeet = string.Empty;
        public string headstand = string.Empty;
        public string jumpingjack = string.Empty;
        public string kick = string.Empty;
        public string lungesinging = string.Empty;
        public string passthemic = string.Empty;
        public string predance = string.Empty;
        public string pushups = string.Empty;
        public string singing = string.Empty;
        public string sitdown = string.Empty;
        public string sitwave = string.Empty;
        public string situps = string.Empty;
        public string split = string.Empty;
        public string standfromsit = string.Empty;
        public string thinking = string.Empty;
        public string bodybuilderpose = string.Empty;
        public string squats = string.Empty;
        public string sprinklethewater = string.Empty;
        public string pourjug = string.Empty;
        public string throwthemic = string.Empty;
        public string wave = string.Empty;
        public string stop = string.Empty;
        public string forward = string.Empty;
        public string reverse = string.Empty;
        public string left = string.Empty;
        public string right = string.Empty;
        public string moonwalk = string.Empty;

        private void Form2_Load(object sender, EventArgs e)
        {
            // Assign the EZB instance to a variable so the code looks cleaner
            EZB ezb = ucezB_Connect1.EZB;

            // These are events from the auto positions
            ezb.AutoPosition.OnComplete += AutoPosition_OnComplete;
            ezb.AutoPosition.OnStartAction += AutoPosition_OnStartAction;
            ezb.AutoPosition.OnStartFrame += AutoPosition_OnStartFrame;

            // First we define the servos
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D0); // 0
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D1); // 1
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D2); // 2
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D3); // 3
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D4); // 4
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D5); // 5
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D6); // 6
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D7); // 7
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D8); // 8
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D9); // 9
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D12);// 10
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D13);// 11
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D14);// 12
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D16);// 13
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D17);// 14
            ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D18);// 15

            //Fly Frames
            string fly1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 1, 180, 90, 90, 90, 90, 90, 90, 90, 90, 45, 90, 90, 70 });
            string fly2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 75, 70, 1, 180, 90, 90, 90, 90, 90, 90, 180, 35, 90, 105, 90, 66 });
            string fly3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 125, 70, 55, 125, 90, 90, 90, 90, 90, 90, 180, 90, 85, 160, 60, 65 });
            string fly4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 70, 75, 60, 120, 90, 90, 90, 90, 90, 90, 125, 90, 80, 180, 55, 65 });
            string fly5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 65, 120, 60, 120, 50, 90, 90, 130, 90, 90, 125, 90, 86, 180, 55, 65 });
            string fly6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 65, 75, 60, 120, 95, 90, 90, 85, 90, 90, 125, 90, 86, 180, 62, 65 });
            string fly7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Fly Action
            fly = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Fly", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(fly1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(fly2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly6, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly6, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly6, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fly7, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Get Up Frames
            string getup1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 86, 62, 47, 121, 111, 153, 90, 68, 13, 90, 83, 85, 94, 93, 87, 96 });
            string getup2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 141, 65, 94, 78, 93, 156, 98, 91, 18, 111, 111, 1, 94, 65, 180, 96 });
            string getup3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 26, 66, 89, 88, 125, 152, 90, 25, 52, 90, 76, 38, 97, 107, 135, 96 });
            string getup4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Get Up Action
            getup = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Get Up", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(getup1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(getup2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(getup3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(getup4, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Gorilla Frames
            string gorilla1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 80, 71, 90, 90, 180, 180, 90, 23, 1, 90, 84, 82, 100, 98, 87, 85 });
            string gorilla2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 100, 72, 90, 86, 154, 180, 90, 1, 1, 90, 84, 82, 100, 98, 87, 85 });
            string gorilla3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Gorilla Action
            gorilla = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Gorilla", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(gorilla1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(gorilla2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(gorilla1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(gorilla2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(gorilla1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(gorilla2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(gorilla3, 25, 3, 1),
          
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Grab Frames
            string grab1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 86, 85, 28, 109, 153, 104, 48, 18, 90, 90, 29, 127, 94, 139, 56, 96 });
            string grab2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 86, 85, 28, 109, 153, 104, 83, 18, 90, 90, 29, 127, 94, 139, 56, 96 });
            string grab3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 86, 85, 28, 54, 153, 104, 83, 18, 19, 90, 93, 86, 94, 86, 89, 96 });
            string grab4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 86, 85, 28, 121, 153, 104, 83, 18, 19, 90, 93, 86, 94, 86, 89, 96 });
            string grab5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Grab Action
            grab = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Grab", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(grab1, 75, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(grab2, 75, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab2, 75, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab1, 75, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(grab5, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Hands Dance Frames
            string handsdance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 147, 68, 1, 180, 5, 175, 90, 5, 175, 90, 90, 90, 104, 90, 90, 125 });
            string handsdance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 39, 120, 1, 180, 175, 5, 90, 175, 5, 90, 100, 90, 55, 80, 90, 73 });
            string handsdance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 165, 90, 180, 1, 5, 175, 90, 5, 175, 90, 90, 82, 100, 90, 85, 85 });
            string handsdance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 16, 89, 180, 1, 175, 5, 90, 175, 5, 90, 90, 82, 100, 90, 85, 85 });

            //Hands Dance Action
            handsdance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Hands Dance", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(handsdance1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(handsdance2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(handsdance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(handsdance4, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Head Bob Feet Frames
            string headbobfeet1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 66, 1, 180, 147, 132, 90, 32, 46, 90, 90, 90, 98, 90, 90, 98 });
            string headbobfeet2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 91, 1, 180, 147, 132, 90, 32, 46, 90, 90, 90, 82, 90, 90, 86 });

            //Head Bob Feet Action
            headbobfeet = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Head Bob Feet", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(headbobfeet1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(headbobfeet2, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Head Stand Frames
            string headstand1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 26, 66, 89, 88, 125, 152, 90, 25, 52, 90, 76, 38, 97, 107, 135, 96 });
            string headstand2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 141, 65, 94, 78, 93, 156, 98, 91, 18, 111, 111, 1, 94, 65, 180, 96 });
            string headstand3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 86, 62, 47, 121, 111, 153, 90, 68, 13, 90, 83, 85, 94, 93, 87, 96 });
            string headstand4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 86, 62, 81, 82, 118, 144, 90, 52, 48, 90, 62, 41, 117, 13, 56, 63 });
            string headstand5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 86, 62, 92, 82, 125, 146, 90, 37, 44, 90, 139, 141, 59, 113, 125, 134 });
            string headstand6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Headstand Action
            headstand = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Head Stand", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(headstand1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand3, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand5, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand5, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand2, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstand6, 25, 3, 1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Jumping Jack Frames
            string jumpjack1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 52, 93, 180, 180, 160, 128, 90, 12, 53, 90, 90, 90, 92, 90, 90, 98 });
            string jumpjack2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 79, 115, 164, 180, 150, 115, 70, 9, 53, 100, 90, 90, 79, 90, 90, 87 });

            //Jumping Jack Action
            jumpingjack = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Jumping Jack", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(jumpjack1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(jumpjack2, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Kick Frames
            string kick1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 135, 90, 1, 180, 100, 90, 90, 60, 60, 20, 90, 90, 45, 90, 90, 50  });
            string kick2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 75, 65, 1, 180, 100, 90, 90, 59, 58, 22, 150, 90, 90, 90, 90, 50 });
            string kick3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 114, 105, 1, 180, 125, 90, 90, 59, 58, 22, 1, 160, 89, 90, 90, 50 });
            string kick4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Kick Action
            kick = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Kick", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(kick1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(kick2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(kick3, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(kick4, 25, 3, 1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Lunge Singing Frames
            string lungesinging1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 132, 107, 45, 82, 166, 90, 1, 1, 90, 1, 180, 90, 1, 180, 90 });
            string lungesinging2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 78, 78, 135, 90, 62, 118, 90, 1, 1, 90, 1, 180, 90, 1, 180, 90 });
            string lungesinging3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 86, 146, 96, 60, 62, 156, 90, 1, 1, 90, 1, 180, 90, 1, 180, 90 });
            string lungesinging4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 86, 146, 96, 85, 164, 180, 99, 1, 1, 90, 1, 180, 90, 1, 180, 90 });
            string lungesinging5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 78, 78, 135, 47, 162, 180, 90, 1, 1, 90, 1, 180, 90, 1, 180, 90 });
           
            //Lunge Singing Action
            lungesinging = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Lunge Singing", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging4, 15, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging3, 95, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging3, 25, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(lungesinging1, 65, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Pass the Mic Frames
            string passthemic1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 70, 77, 120, 180, 145, 123, 90, 30, 58, 62, 90, 90, 92, 90, 90, 98 });
            string passthemic2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 79, 115, 164, 180, 150, 115, 70, 9, 53, 100, 90, 90, 79, 90, 90, 87 });

            //Pass the Mic Action
            passthemic = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Pass The Mic", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(passthemic1, 25, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(passthemic2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(passthemic1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(passthemic2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(passthemic1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(passthemic2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(passthemic2, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Pre Dance Frames
            string predance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 46, 73, 1, 180, 133, 176, 90, 38, 92, 101, 90, 90, 78, 90, 90, 80 });
            string predance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 35, 97, 1, 178, 127, 180, 90, 63, 42, 89, 90, 90, 90, 90, 90, 90 });
            string predance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 158, 72, 1, 178, 149, 90, 90, 38, 3, 90, 90, 90, 99, 90, 90, 105 });
            string predance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 148, 102, 1, 178, 128, 142, 63, 47, 1, 90, 90, 90, 90, 90, 90, 90 });

            //Pre Dance Action
            predance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Pre Dance", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(predance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance2, 25, 7, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance2, 25, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance2, 25, 7, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance2, 25, 8, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance3, 25, 9, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance4, 25, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance4, 25, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance4, 25, 7, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(predance4, 25, 6, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Push Up Frames
            string pushup1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 26, 66, 89, 88, 125, 152, 90, 25, 52, 90, 76, 38, 97, 107, 135, 96 });
            string pushup2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 141, 65, 94, 78, 93, 156, 98, 91, 18, 101, 111, 1, 94, 65, 180, 96 });
            string pushup3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 86, 62, 47, 121, 111, 153, 90, 68, 13, 90, 83, 85, 94, 93, 87, 96 });
            string pushup4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 35, 105, 74, 96, 131, 136, 90, 40, 41, 90, 93, 88, 94, 86, 89, 96 });
            string pushup5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 115, 62, 79, 92, 97, 180, 90, 66, 1, 90, 93, 94, 94, 86, 88, 96 });
            string pushup6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });
            string pushup7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 86, 99, 59, 111, 147, 104, 90, 20, 75, 90, 93, 114, 94, 86, 59, 96 });

            //Push Up Action
            pushups = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Push Ups", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(pushup1, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup4, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup4, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup4, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup4, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup4, 25, 3, 1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup7, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup6, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Singing Frames
            string singing1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 121, 108, 162, 144, 111, 90, 1, 3, 90, 84, 82, 98, 98, 87, 85 });
            string singing2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 64, 132, 104, 162, 161, 124, 74, 1, 1, 90, 84, 82, 98, 98, 87, 85 });
            string singing3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 104, 132, 105, 162, 161, 124, 74, 1, 1, 103, 84, 82, 100, 98, 87, 85 });
            string singing4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 104, 99, 124, 149, 132, 124, 74, 1, 1, 100, 84, 82, 100, 98, 87, 85 });
            string singing5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 77, 106, 119, 149, 132, 124, 74, 1, 1, 100, 84, 82, 100, 98, 87, 85 });
            string singing6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 85, 115, 114, 169, 132, 124, 74, 1, 1, 100, 84, 82, 99, 98, 87, 85 });
            string singing7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 90, 121, 108, 76, 166, 180, 90, 1, 3, 90, 90, 90, 97, 102, 90, 85 });
            string singing8 = ezb.AutoPosition.Config.AddFrame("Frame #8", new int[] { 90, 97, 124, 59, 166, 180, 90, 1, 3, 90, 90, 90, 97, 102, 90, 89 });
            string singing9 = ezb.AutoPosition.Config.AddFrame("Frame #9", new int[] { 67, 97, 124, 59, 165, 180, 90, 7, 1, 90, 90, 90, 100, 102, 90, 85 });
            string singing10 = ezb.AutoPosition.Config.AddFrame("Frame #10", new int[] { 67, 131, 102, 84, 165, 180, 90, 1, 1, 90, 136, 60, 95, 46, 122, 85 });
            string singing11 = ezb.AutoPosition.Config.AddFrame("Frame #11", new int[] { 90, 121, 115, 26, 111, 129, 90, 1, 3, 90, 88, 90, 100, 92, 90, 82 });
            string singing12 = ezb.AutoPosition.Config.AddFrame("Frame #12", new int[] { 90, 144, 98, 40, 109, 127, 90, 1, 3, 90, 88, 90, 99, 95, 90, 85 });
            string singing13 = ezb.AutoPosition.Config.AddFrame("Frame #13", new int[] { 74, 122, 111, 75, 45, 127, 90, 1, 1, 90, 92, 90, 100, 90, 90, 84 });


            //Singing Action
            singing = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Singing", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(singing1, 25, 15, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing2, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing1, 25, 2, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing4, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing4, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing4, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing4, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing6, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing7, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing8, 25, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing9, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing10, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing9, 25, 1, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing10, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing8, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing9, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing7, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing11, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing12, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing13, 25, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing11, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing13, 25, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing12, 95, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing11, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(singing13, 25, 6, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Sit Down Frames
            string sitdown1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 86, 128, 42, 133, 153, 104, 90, 18, 73, 90, 43, 120, 94, 127, 57, 96 });
            string sitdown2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 86, 66, 180, 1, 18, 59, 90, 150, 132, 90, 8, 145, 97, 172, 32, 100 });
            string sitdown3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 34, 140, 148, 41, 18, 68, 90, 158, 108, 90, 18, 165, 95, 167, 10, 96 });
            string sitdown4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 114, 121, 113, 61, 35, 47, 90, 141, 111, 90, 2, 70, 94, 178, 105, 96 });
            string sitdown5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 86, 78, 71, 125, 139, 130, 90, 34, 57, 90, 1, 74, 90, 180, 104, 90 });

            //Sit Down Action
            sitdown = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Sit Down", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(sitdown1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitdown2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitdown3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitdown4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitdown5, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Sit Wave Frames
            string sitwave1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 109, 79, 71, 1, 153, 138, 90, 34, 57, 90, 1, 74, 90, 180, 104, 90 });
            string sitwave2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 93, 84, 56, 1, 155, 113, 90, 34, 45, 90, 1, 74, 90, 180, 104, 90 });
            string sitwave3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 86, 78, 71, 125, 139, 130, 90, 34, 57, 90, 1, 74, 90, 180, 104, 90 });

            //Sit Wave Action
            sitwave = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Sit Wave", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(sitwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitwave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitwave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitwave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sitwave3, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Sit Ups Frames
            string situp1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 86, 128, 42, 133, 153, 104, 90, 18, 73, 90, 43, 120, 94, 127, 57, 96 });
            string situp2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 86, 66, 180, 1, 18, 59, 90, 150, 132, 90, 8, 145, 97, 172, 32, 100 });
            string situp3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 34, 140, 148, 41, 18, 68, 90, 158, 108, 90, 18, 165, 95, 167, 10, 96 });
            string situp4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 114, 121, 113, 61, 35, 47, 90, 141, 111, 90, 2, 70, 94, 178, 105, 96 });
            string situp5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 86, 78, 71, 125, 139, 130, 90, 34, 57, 90, 1, 74, 90, 180, 104, 90 });
            string situp6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 86, 103, 180, 1, 159, 150, 90, 21, 30, 90, 1, 90, 91, 180, 90, 91 });
            string situp7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 86, 144, 118, 74, 155, 150, 90, 21, 30, 90, 14, 90, 90, 164, 90, 90 });
            string situp8 = ezb.AutoPosition.Config.AddFrame("Frame #8", new int[] { 86, 148, 71, 109, 133, 141, 90, 29, 57, 90, 1, 63, 90, 178, 105, 90 });
            string situp9 = ezb.AutoPosition.Config.AddFrame("Frame #9", new int[] { 85, 80, 80, 100, 5, 90, 90, 175, 90, 90, 1, 80, 90, 180, 100, 90 });
            string situp10 = ezb.AutoPosition.Config.AddFrame("Frame #10", new int[] { 85, 80, 70, 135, 1, 70, 90, 80, 180, 90, 180, 100, 70, 25, 35, 80 });
            string situp11 = ezb.AutoPosition.Config.AddFrame("Frame #11", new int[] { 85, 80, 35, 108, 1, 70, 80, 160, 61, 80, 180, 85, 65, 85, 15, 65 });
            string situp12 = ezb.AutoPosition.Config.AddFrame("Frame #12", new int[] { 85, 80, 110, 110, 170, 70, 90, 90, 160, 90, 180, 36, 60, 170, 1, 60 });
            string situp13 = ezb.AutoPosition.Config.AddFrame("Frame #13", new int[] { 85, 80, 160, 110, 170, 75, 90, 100, 165, 90, 180, 1, 100, 180, 1, 80 });
            string situp14 = ezb.AutoPosition.Config.AddFrame("Frame #14", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Sit Ups Action
            situps = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Sit Ups", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(situp1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp6, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp7, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp8, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp6, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp7, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp8, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp6, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp7, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp8, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp6, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp7, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp8, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp6, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp7, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp8, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp6, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp7, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp9, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp10, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp11, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp12, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp13, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(situp14, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Split Frames
            string split1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 84, 80, 166, 90, 90, 17, 90, 90, 39, 90, 90, 150, 90, 90 });
            string split2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 113, 48, 166, 90, 90, 26, 90, 90, 28, 88, 90, 68, 176, 90 });
            string split3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 113, 57, 165, 90, 90, 26, 90, 90, 28, 88, 90, 118, 29, 90 });
            string split4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 116, 76, 127, 111, 90, 26, 71, 90, 1, 44, 90, 60, 29, 90 });
            string split5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 90, 82, 1, 112, 129, 90, 26, 71, 90, 1, 86, 90, 17, 29, 90 });
            string split6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Split Action
            split = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Split", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(split1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(split2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(split3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(split4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(split5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(split4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(split3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(split2, 25, 3, -1), 
          new EZ_B.Classes.AutoPositionActionFrame(split1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(split6, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Stand From Sit Frames
            string standfromsit1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 85, 80, 80, 100, 5, 90, 90, 175, 90, 90, 1, 80, 90, 180, 100, 90 });
            string standfromsit2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 85, 80, 70, 135, 1, 70, 90, 80, 180, 90, 180, 100, 70, 25, 35, 80 });
            string standfromsit3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 85, 80, 35, 108, 1, 70, 80, 160, 61, 80, 180, 85, 65, 85, 15, 65 });
            string standfromsit4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 85, 80, 110, 110, 170, 70, 90, 90, 160, 90, 180, 36, 60, 170, 1, 60 });
            string standfromsit5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 85, 80, 160, 110, 170, 75, 90, 100, 165, 90, 180, 1, 100, 180, 1, 80 });
            string standfromsit6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Stand From Sit Action
            standfromsit = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Stand From Sit", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(standfromsit1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(standfromsit2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(standfromsit3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(standfromsit4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(standfromsit5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(standfromsit6, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Thinking Frames
            string thinking1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 180, 180, 153, 102, 90, 37, 4, 96, 91, 88, 94, 86, 89, 96 });
            string thinking2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 180, 180, 153, 102, 90, 26, 20, 98, 91, 88, 94, 86, 89, 96 });
            string thinking3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Thinking Action
            thinking = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Fly", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(thinking1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(thinking2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(thinking1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(thinking2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(thinking1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(thinking2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(thinking3, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Body Builder Pose Frames
            string bodybuilderpose1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 31, 111, 1, 1, 138, 180, 90, 127, 90, 90, 84, 82, 100, 98, 87, 85 });
            string bodybuilderpose2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 112, 65, 115, 170, 160, 89, 30, 20, 89, 50, 115, 100, 130, 65, 88 });
            string bodybuilderpose3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 112, 66, 127, 180, 170, 89, 1, 10, 89, 50, 115, 96, 130, 65, 87 });
            string bodybuilderpose4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 31, 65, 180, 1, 130, 175, 89, 50, 5, 89, 84, 82, 96, 98, 87, 85 });
            string bodybuilderpose5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 152, 71, 180, 1, 130, 175, 89, 50, 5, 89, 84, 90, 95, 98, 90, 85 });
            string bodybuilderpose6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 180, 1, 130, 175, 89, 50, 5, 89, 84, 82, 95, 98, 987, 85 });
            string bodybuilderpose7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Body Builder Pose Action
            bodybuilderpose = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Fly", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose7, 25, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose3, 35, 2, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose2, 25, 2, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose3, 25, 2, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose6, 25, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose4, 25, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose5, 25, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bodybuilderpose6, 25, 4, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Squats Frames
            string squat1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 119, 90, 91, 180, 90, 90, 1, 90, 90, 90, 90, 98, 90, 90, 85 });
            string squat2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 62, 115, 60, 180, 90, 90, 1, 90, 90, 1, 160, 98, 180, 20, 85 });
            string squat3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Squat Action
            squats = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Squats", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(squat1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(squat3, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Sprinkle the Water Frames
            string sprinklethewater1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 32, 90, 90, 1, 139, 170, 90, 107, 90, 90, 90, 90, 95, 90, 90, 85 });
            string sprinklethewater2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 46, 82, 90, 1, 139, 170, 90, 67, 90, 90, 90, 90, 96, 90, 90, 85 });
            string sprinklethewater3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 70, 82, 90, 1, 139, 170, 90, 45, 90, 90, 90, 90, 95, 90, 90, 85 });
            string sprinklethewater4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 112, 82, 90, 1, 139, 170, 90, 1, 90, 90, 90, 90, 96, 90, 90, 85 });
            string sprinklethewater5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Sprinkle the Water Action
            sprinklethewater = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Sprinkle the Water", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(sprinklethewater5, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Pour Jug Frames
            string pourjug1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 1, 1, 90, 180, 90, 27, 58, 90, 105, 89, 90, 75, 90, 90 });
            string pourjug2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 1, 30, 80, 180, 90, 27, 58, 90, 105, 89, 90, 75, 90, 90 });
            string pourjug3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 1, 66, 80, 180, 90, 27, 58, 90, 105, 89, 90, 75, 90, 90 });

            //Pour Jug Action
            pourjug = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Pour Jug", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(pourjug1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pourjug2, 25, 3, 2),
          new EZ_B.Classes.AutoPositionActionFrame(pourjug3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pourjug1, 25, 3, 1),
            },
                EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Throw Mic Frames
            string throwmic1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 1, 180, 145, 123, 90, 90, 90, 90, 90, 90, 98, 90, 90, 85 });
            string throwmic2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 1, 180, 145, 123, 90, 90, 34, 90, 90, 90, 98, 90, 90, 85 });
            string throwmic3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 1, 180, 145, 123, 90, 90, 34, 70, 90, 90, 98, 90, 90, 85 });

            //Throw Mic Action
            throwthemic = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Throw Mic", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(throwmic1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(throwmic2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(throwmic3, 25, 9, -1),
            },
                EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Wave Frames
            string wave1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 97, 65, 2, 13, 161, 119, 101, 27, 58, 90, 91, 87, 98, 80, 93, 86 });
            string wave2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 82, 73, 11, 13, 153, 75, 53, 35, 51, 90, 91, 88, 98, 86, 89, 86 });
            string wave3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Wave Action
            wave = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Wave", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(wave1, 5, 7, 0),
          new EZ_B.Classes.AutoPositionActionFrame(wave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wave2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wave3, 25, 3, -1),
            },
                EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Stop Frame
            string stop1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 1, 180, 165, 90, 90, 15, 90, 90, 90, 84, 98, 90, 90, 85 });

            //Stop Action
            stop = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Stop", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(stop1, 25, 3, 1),
            },
                EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Forward Frames
            string forward1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 27, 180, 145, 120, 90, 8, 50, 90, 90, 80, 70, 80, 100, 75 });
            string forward2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 26, 180, 145, 120, 90, 9, 50, 90, 90, 80, 85, 80, 100, 70 });
            string forward3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 31, 152, 145, 120, 90, 11, 50, 90, 70, 100, 80, 75, 100, 80 });
            string forward4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 21, 158, 154, 120, 90, 16, 50, 90, 70, 110, 90, 60, 120, 90 });
            string forward5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 90, 1, 147, 170, 120, 90, 30, 50, 90, 80, 100, 105, 60, 120, 110 });
            string forward6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 1, 144, 168, 120, 90, 30, 50, 90, 100, 80, 105, 90, 100, 110 });
            string forward7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 90, 90, 1, 136, 172, 120, 90, 30, 50, 90, 100, 80, 110, 90, 100, 100 });
            string forward8 = ezb.AutoPosition.Config.AddFrame("Frame #8", new int[] { 90, 90, 1, 153, 170, 120, 90, 30, 50, 90, 105, 75, 105, 110, 70, 110 });
            string forward9 = ezb.AutoPosition.Config.AddFrame("Frame #9", new int[] { 90, 90, 1, 180, 145, 120, 90, 30, 50, 90, 120, 60, 90, 110, 70, 90 });
            string forward10 = ezb.AutoPosition.Config.AddFrame("Frame #10", new int[] { 90, 90, 25, 180, 145, 120, 90, 12, 50, 90, 120, 60, 60, 100, 80, 75 });
            string forward11 = ezb.AutoPosition.Config.AddFrame("Frame #11", new int[] { 90, 90, 27, 180, 145, 120, 90, 6, 50, 90, 120, 60, 80, 105, 80, 70 });

            //Forward Action
            forward = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Forward", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(forward1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward6, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward7, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward8, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward9, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward10, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward11, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Reverse Frames
            string reverse1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 27, 180, 145, 120, 90, 6, 50, 90, 120, 60, 80, 105, 80, 70 });
            string reverse2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 25, 180, 145, 120, 90, 12, 50, 90, 120, 60, 60, 100, 80, 75 });
            string reverse3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 1, 180, 145, 120, 90, 30, 50, 90, 120, 60, 90, 110, 70, 90 });
            string reverse4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 1, 153, 170, 120, 90, 30, 50, 90, 105, 75, 105, 110, 70, 110 });
            string reverse5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 90, 1, 136, 172, 120, 90, 30, 50, 90, 100, 80, 110, 90, 100, 100 });
            string reverse6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 1, 144, 168, 120, 90, 30, 50, 90, 100, 80, 105, 90, 100, 110 });
            string reverse7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 90, 90, 1, 147, 170, 120, 90, 30, 50, 90, 80, 100, 105, 60, 120, 110 });
            string reverse8 = ezb.AutoPosition.Config.AddFrame("Frame #8", new int[] { 90, 90, 21, 158, 154, 120, 90, 16, 50, 90, 70, 110, 90, 60, 120, 90 });
            string reverse9 = ezb.AutoPosition.Config.AddFrame("Frame #9", new int[] { 90, 90, 31, 152, 145, 120, 90, 11, 50, 90, 70, 100, 80, 75, 100, 80 });
            string reverse10 = ezb.AutoPosition.Config.AddFrame("Frame #10", new int[] { 90, 90, 26, 180, 145, 120, 90, 9, 50, 90, 90, 80, 85, 80, 100, 70 });
            string reverse11 = ezb.AutoPosition.Config.AddFrame("Frame #11", new int[] { 90, 90, 27, 180, 145, 120, 90, 8, 50, 90, 90, 80, 70, 80, 100, 75 });
              
            //Reverse Action
            reverse = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Reverse", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(reverse1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse6, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse7, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse8, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse9, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse10, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse11, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Left Frames
            string left1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 1, 144, 168, 120, 90, 30, 50, 90, 100, 80, 105, 90, 100, 110 });
            string left2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 1, 136, 172, 120, 90, 30, 50, 90, 100, 80, 110, 90, 100, 100 });
            string left3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 1, 153, 170, 120, 90, 30, 50, 90, 105, 75, 105, 110, 70, 110 });
            string left4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 1, 180, 145, 120, 90, 30, 50, 90, 120, 60, 90, 110, 70, 90 });

            //Left Action
            left = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Left", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(left1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(left2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(left3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(left4, 25, 3, -1),
        },
              EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

            //Right Frames
            string right1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 27, 180, 145, 120, 90, 8, 50, 90, 90, 80, 70, 80, 100, 75 });
            string right2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 26, 180, 145, 120, 90, 9, 50, 90, 90, 80, 85, 80, 100, 70 });
            string right3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 31, 152, 145, 120, 90, 11, 50, 90, 70, 100, 80, 75, 100, 80 });
            string right4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 21, 158, 154, 120, 90, 16, 50, 90, 70, 110, 90, 60, 120, 90 });

            //Right Action
            right = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Right", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(right1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(right2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(right3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(right4, 25, 3, -1),
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

        private void btnFly_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(fly);
        }

        private void btnGetUp_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(getup);
        }

        private void btnGorilla_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(gorilla);
        }

        private void btnGrab_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(grab);
        }

        private void btnHandsDance_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(handsdance);
        }

        private void btnHeadBobFeet_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(headbobfeet);
        }

        private void btnHeadStand_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(headstand);
        }

        private void btnJumpJack_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(jumpingjack);
        }

        private void btnKick_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(kick);
        }

        private void btnLungeDance_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(lungesinging);
        }

        private void btnPassTheMic_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(passthemic);
        }

        private void btnPreDance_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(predance);
        }

        private void btnPushUp_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(pushups);
        }

        private void btnSinging_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(singing);
        }

        private void btnSitDown_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(sitdown);
        }

        private void btnSitWave_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(sitwave);
        }

        private void btnSitUps_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(situps);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(split);
        }

        private void btnStandFromSit_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(standfromsit);
        }

        private void btnThinking_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(thinking);
        }

        private void btnBodyBuilderPose_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(bodybuilderpose);
        }

        private void btnSquats_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(squats);
        }

        private void btnSprinkler_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(sprinklethewater);
        }

        private void btnPourJug_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(pourjug);
        }

        private void btnThrowTheMic_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(throwthemic);
        }

        private void btnWave_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(wave);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(stop);
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(forward);
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(left);
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(right);
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(reverse);
        }

        private void btnMoonwalk_Click(object sender, EventArgs e)
        {
            ucezB_Connect1.EZB.AutoPosition.ExecAction(moonwalk);
        }

    }
}
