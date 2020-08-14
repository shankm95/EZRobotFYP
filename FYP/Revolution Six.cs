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

namespace FYP {

  public partial class Form1 : Form {


    public Form1() {

      InitializeComponent();
    }

    public string legsdance = string.Empty;
    public string legsupdown = string.Empty;
    public string attack = string.Empty;
    public string bouncedance = string.Empty;
    public string byewave = string.Empty;
    public string circledance = string.Empty;
    public string curldance = string.Empty;
    public string fastforward = string.Empty;
    public string fastleft = string.Empty;
    public string fastright = string.Empty;
    public string fastreverse = string.Empty;
    public string happydance = string.Empty;
    public string headstanddance = string.Empty;
    public string hiwave = string.Empty;
    public string legsupdance = string.Empty;
    public string marchonspot = string.Empty;
    public string morninggreeting = string.Empty;
    public string pushup = string.Empty;
    public string rockbackandforth = string.Empty;
    public string rotateleft = string.Empty;
    public string rotatelegsdance = string.Empty;
    public string rotateright = string.Empty;
    public string shutdown = string.Empty;
    public string strafeleft = string.Empty;
    public string straferight = string.Empty;
    public string swim = string.Empty;
    public string wave = string.Empty;
    public string wavedance = string.Empty;
    public string forward = string.Empty;
    public string left = string.Empty;
    public string right = string.Empty;
    public string reverse = string.Empty;

    private void Form1_Load(object sender, EventArgs e) {

      // Assign the EZB instance to a variable so the code looks cleaner
      EZB ezb = ucezB_Connect1.EZB;

      // These are events from the auto positions
      ezb.AutoPosition.OnComplete += AutoPosition_OnComplete;
      ezb.AutoPosition.OnStartAction += AutoPosition_OnStartAction;
      ezb.AutoPosition.OnStartFrame += AutoPosition_OnStartFrame;

      // First we define the servos
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D0); // 0
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D1); // 1
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D3); // 2
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D4); // 3
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D6); // 4
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D7); // 5
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D9); // 6
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D10);// 7
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D12);// 8
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D13);// 9
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D22);// 10
      ezb.AutoPosition.Config.AddServo(Servo.ServoPortEnum.D23);// 11

      //3 Legs Dance Frames
      string legsdance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 1, 90, 120, 90, 1, 90, 120, 90, 2, 90, 120 });
      string legsdance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 130, 1, 90, 70, 130, 1, 90, 70, 130, 2, 90, 70 });
      string legsdance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 1, 90, 120, 90, 1, 90, 120, 90, 2, 90, 120 });
      string legsdance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 50, 1, 90, 70, 50, 1, 90, 70, 50, 2, 90, 70 });

      //3 Legs Dance Action
      legsdance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("3 Legs Dance",true,false,new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(legsdance1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(legsdance2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsdance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsdance4, 25, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //3 Legs Up Down Frames
      string legsupdown1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 17, 90, 50, 90, 50, 90, 50, 90, 50, 90, 50 });
      string legsupdown2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 50, 90, 120, 90, 50, 90, 120, 90, 50, 90, 120 });
      string legsupdown3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 120, 90, 50, 90, 119, 90, 50, 90, 120, 90, 50 });
      string legsupdown4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //3 Legs Up Down Action
      legsupdown = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("3 Legs Up Down", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown2, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown3, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown2, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown3, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown2, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown3, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown2, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown3, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown2, 20, 5, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdown4, 20, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Attack Frames
      string attack1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 70, 20, 110, 20, 135, 110, 90, 45, 90, 45, 45, 110 });
      string attack2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 60, 100, 120, 100, 75, 110, 90, 100, 90, 100, 105, 110 });
      string attack3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Attack Action
      attack = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Attack", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(attack1, 20, 2, 0),
          new EZ_B.Classes.AutoPositionActionFrame(attack2, 20, 39, -1),
          new EZ_B.Classes.AutoPositionActionFrame(attack3, 25, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Bounce Dance Frames
      string bouncedance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 50, 90, 50, 60, 1, 90, 50, 90, 50, 60, 1 });
      string bouncedance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 130, 90, 130, 120, 50, 90, 130, 90, 130, 120, 50 });
      string bouncedance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 130, 90, 130, 90, 1, 90, 130, 90, 130, 90, 1 });
      string bouncedance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 130, 90, 130, 90, 1, 90, 130, 90, 130, 90, 60 });
      string bouncedance5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 130, 90, 130, 90, 60, 90, 130, 90, 130, 90, 1 });
      string bouncedance6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 60, 90, 60, 90, 40, 90, 60, 90, 60, 90, 40 });
      string bouncedance7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Bounce Dance Action
      bouncedance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Bounce Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance1, 15, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance4, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance5, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance6, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance6, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(bouncedance7, 25, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Bye Wave Frames
      string byewave1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 90, 1, 90, 90, 90, 90, 90, 90, 90, 90 });
      string byewave2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 140, 1, 90, 90, 90, 90, 90, 90, 90, 90 });
      string byewave3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 50, 1, 90, 90, 90, 90, 90, 90, 90, 90 });
      string byewave4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Bye Wave Action
      byewave = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Bye Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(byewave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(byewave2, 5, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(byewave3, 5, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(byewave2, 5, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(byewave3, 5, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(byewave4, 145, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Circle Dance Frames
      string circledance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 90, 90, 90, 45, 90, 30, 90, 30, 90, 90 });
      string circledance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 90, 90, 45, 90, 30, 90, 30, 90, 90, 90, 90 });
      string circledance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 45, 90, 30, 90, 30, 90, 90, 90, 90, 90, 90 });
      string circledance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 30, 90, 30, 90, 90, 90, 90, 90, 90, 90, 45 });
      string circledance5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 30, 90, 90, 90, 90, 90, 90, 90, 45, 90, 30 });
      string circledance6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 90, 90, 90, 90, 90, 45, 90, 30, 90, 30 });

      //Circle Dance Action
      circledance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Circle Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(circledance1, 15, 4, 2),
          new EZ_B.Classes.AutoPositionActionFrame(circledance2, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance3, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance4, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance5, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance6, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance1, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance2, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance3, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance4, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance5, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance6, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance1, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance2, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance3, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance4, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance5, 15, 4, -1),
          new EZ_B.Classes.AutoPositionActionFrame(circledance6, 15, 4, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Curl Dance Frames
      string curldance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 20, 50, 20, 50, 20, 50, 20, 50, 20, 50, 20, 50 });
      string curldance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 20, 70, 20, 70, 20, 50, 20, 50, 20, 50, 20, 70 });
      string curldance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 20, 70, 20, 50, 20, 50, 20, 50, 20, 70, 20, 70 });
      string curldance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 20, 50, 20, 50, 20, 50, 20, 70, 20, 70, 20, 70 });
      string curldance5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 20, 50, 20, 50, 20, 70, 20, 70, 20, 70, 20, 50 });
      string curldance6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 20, 50, 20, 70, 20, 70, 20, 70, 20, 50, 20, 50 });
      string curldance7 = ezb.AutoPosition.Config.AddFrame("Frame #7", new int[] { 20, 70, 20, 70, 20, 70, 20, 50, 20, 50, 20, 50 });

      //Curl Dance Action
      curldance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Curl Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(curldance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance2, 20, 3, 3),
          new EZ_B.Classes.AutoPositionActionFrame(curldance3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance4, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance5, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance6, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance7, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance2, 20, 3, 3),
          new EZ_B.Classes.AutoPositionActionFrame(curldance3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance4, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance5, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance6, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance7, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance2, 20, 3, 3),
          new EZ_B.Classes.AutoPositionActionFrame(curldance3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance4, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance5, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance6, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(curldance7, 20, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Fast Forward Frames
      string fastforward1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 120, 120, 120, 90, 90, 120, 160, 90, 90, 120, 40, 90 });
      string fastforward2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 120, 90, 120, 120, 90, 90, 160, 120, 90, 90, 40, 120 });
      string fastforward3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 60, 90, 60, 120, 140, 90, 90, 120, 20, 90, 90, 120 });
      string fastforward4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 120, 60, 90, 140, 120, 90, 90, 20, 120, 90, 90 });

      //Fast Forward Action
      fastforward = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Fast Forward", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(fastforward1, 15, 10, 0),
          new EZ_B.Classes.AutoPositionActionFrame(fastforward2, 15, 10, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fastforward3, 15, 10, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fastforward4, 15, 10, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Fast Left Frames
      string fastleft1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 100, 120, 80, 80, 100, 120, 80, 80, 100, 120, 80, 80 });
      string fastleft2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 100, 80, 80, 120, 100, 80, 80, 120, 100, 80, 80, 120 });
      string fastleft3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 80, 80, 100, 120, 80, 80, 100, 120, 80, 80, 100, 120 });
      string fastleft4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 80, 120, 100, 80, 80, 120, 100, 80, 80, 120, 100, 80 });

      //Fast Left Action
      fastleft = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Fast Left", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(fastleft1, 15, 6, 0),
          new EZ_B.Classes.AutoPositionActionFrame(fastleft2, 15, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fastleft3, 15, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fastleft4, 15, 6, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Fast Right Frames
      string fastright1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 80, 120, 100, 80, 80, 120, 100, 80, 80, 120, 100, 80 });
      string fastright2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 80, 80, 100, 120, 80, 80, 100, 120, 80, 80, 100, 120 });
      string fastright3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 100, 80, 80, 120, 100, 80, 80, 120, 100, 80, 80, 120 });
      string fastright4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 100, 120, 80, 80, 100, 120, 80, 80, 100, 120, 80, 80 });

      //Fast Right Action
      fastright = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Fast Right", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(fastright1, 15, 6, 0),
          new EZ_B.Classes.AutoPositionActionFrame(fastright2, 15, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fastright3, 15, 6, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fastright4, 15, 6, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Fast Reverse Frames
      string fastreverse1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 60, 120, 60, 90, 140, 120, 90, 90, 20, 120, 90, 90 });
      string fastreverse2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 60, 90, 60, 120, 140, 90, 90, 120, 20, 90, 90, 120 });
      string fastreverse3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 120, 90, 120, 120, 90, 90, 160, 120, 90, 90, 40, 120 });
      string fastreverse4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 120, 120, 120, 90, 90, 120, 160, 90, 90, 120, 40, 90 });

      //Fast Reverse Action
      fastreverse = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Fast Reverse", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(fastreverse1, 15, 10, 0),
          new EZ_B.Classes.AutoPositionActionFrame(fastreverse2, 15, 10, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fastreverse3, 15, 10, -1),
          new EZ_B.Classes.AutoPositionActionFrame(fastreverse4, 15, 10, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Happy Dance Frames
      string happydance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
      string happydance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 1, 90, 1, 90, 1, 90, 1, 90, 1, 90, 1 });

      //Happy Dance Action
      happydance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Happy Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(happydance1, 15, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(happydance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(happydance1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(happydance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(happydance1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(happydance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(happydance1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(happydance2, 15, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Head Stand Dance Frames
      string headstanddance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 30, 90, 30, 90, 90, 90, 1, 90, 180, 90, 90 });
      string headstanddance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 30, 90, 30, 90, 90, 90, 180, 90, 1, 90, 90 });
      string headstanddance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Head Stand Dance Action
      headstanddance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Head Stand Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance1, 15, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(headstanddance3, 25, 3, -1)

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Hi Wave Frames
      string hiwave1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 1, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
      string hiwave2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 40, 1, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
      string hiwave3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 110, 1, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
      string hiwave4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Hi Wave Action
      hiwave = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Hi Wave", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(hiwave1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(hiwave2, 5, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(hiwave3, 5, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(hiwave2, 5, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(hiwave3, 5, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(hiwave4, 145, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Legs Up Dance Frames
      string legsupdance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 40, 90, 40, 90, 40, 90, 40, 90, 40, 90, 40 });
      string legsupdance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 40, 90, 1, 90, 40, 90, 1, 90, 40, 90, 1 });
      string legsupdance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 110, 1, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
      string legsupdance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
      string legsupdance5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
      string legsupdance6 = ezb.AutoPosition.Config.AddFrame("Frame #6", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Legs Up Dance Action
      legsupdance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Legs Up Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance4, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance5, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(legsupdance6, 25, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //March On Spot Frames
      string marchonspot1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 145, 90, 30, 60, 100, 90, 145, 60, 30, 90, 100, 90 });
      string marchonspot2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 145, 60, 30, 90, 80, 90, 145, 90, 30, 60, 80, 90 });
      string marchonspot3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //March On Spot Action
      marchonspot = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("March On Spot", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(marchonspot3, 5, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(marchonspot1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(marchonspot2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(marchonspot1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(marchonspot2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(marchonspot1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(marchonspot2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(marchonspot3, 25, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Morning Greeting Frames
      string morninggreeting1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 90, 90, 110, 90, 90, 60, 90, 60, 73, 90 });
      string morninggreeting2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 60, 90, 60, 90, 50, 90, 110, 90, 110, 120, 90 });
      string morninggretting3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Morning Greeting Action
      morninggreeting = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Morning Greeting", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(morninggretting3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(morninggreeting1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(morninggreeting2, 145, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(morninggretting3, 165, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Push Up Frames
      string pushup1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });
      string pushup2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 30, 90, 30, 90, 50, 90, 50, 90, 90, 90, 90 });

      //Push Up Action
      pushup = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Push Up", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(pushup1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(pushup1, 25, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Rock Back & Forth Frames
      string rockbackandforth1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 60, 110, 120, 110, 90, 130, 60, 50, 120, 50, 120, 50 });
      string rockbackandforth2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 60, 50, 120, 50, 90, 130, 60, 30, 120, 30, 90, 130 });
      string rockbackandforth3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 60, 50, 120, 50, 90, 130, 60, 110, 120, 110, 90, 130 });
      string rockbackandforth4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 60, 30, 120, 30, 90, 130, 60, 50, 120, 50, 90, 130 });

      //Rock Back & Forth Action
      rockbackandforth = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Rock Back & Forth", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth1, 15, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth4, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth4, 15, 3, -1), 
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth1, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rockbackandforth4, 15, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Rotate left Frames
      string rotateleft1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 1, 90, 1, 90, 1, 90, 1, 90, 1, 90, 1 });
      string rotateleft2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 10, 1, 10, 1, 10, 1, 10, 1, 10, 1, 10, 1 });
      string rotateleft3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 10, 90, 10, 90, 10, 90, 10, 90, 10, 90, 10, 90 });
      string rotateleft4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Rotate Left Action
      rotateleft = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Rotate Left", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(rotateleft1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(rotateleft2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rotateleft3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rotateleft4, 25, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Rotate Legs Dance Frames
      string rotatelegsdance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 1, 90, 1, 90, 1, 90, 1, 90, 1, 90, 1 });
      string rotatelegsdance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 165, 1, 165, 1, 165, 1, 165, 1, 165, 1, 165, 1 });
      string rotatelegsdance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 10, 1, 10, 1, 10, 1, 10, 1, 10, 1, 10, 1 });
      string rotatelegsdance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Rotate Legs Dance Action
      rotateleft = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Rotate Legs Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(rotatelegsdance4, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(rotatelegsdance1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(rotatelegsdance2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rotatelegsdance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rotatelegsdance2, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(rotatelegsdance3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rotatelegsdance1, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rotatelegsdance4, 25, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));


      //Rotate Right
      string rotaterigt1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 1, 90, 1, 90, 1, 90, 1, 90, 1, 90, 1 });
      string rotateright2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 165, 1, 165, 1, 165, 1, 165, 1, 165, 1, 165, 1 });
      string rotateright3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 165, 90, 165, 90, 165, 90, 165, 90, 165, 90, 165, 90 });
      string rotateright4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Rotate Right Action
      rotateright = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Rotate Right", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(rotaterigt1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(rotateright2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rotateright3, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(rotateright4, 25, 3, -1),
       

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));



      //Shutdown Frames
      string shutdown = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 1, 180, 1, 180, 1, 180, 1, 180, 1, 180, 1, 180 });
     

      //Shutdown Action
      shutdown = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Shutdown", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(shutdown, 25, 3, 1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Strafe Left Frames
      string strafeleft1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 120, 90, 120, 90, 90, 45, 60, 90, 60, 90, 90, 45 });
      string strafeleft2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 60, 90, 60, 90, 90, 45, 120, 90, 120, 90, 90, 45 });
      string strafeleft3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 60, 1, 60, 1, 90, 45, 120, 2, 120, 2, 90, 45 });
      string strafeleft4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 120, 1, 120, 1, 90, 45, 60, 1, 60, 1, 90, 45 });

      //Strafe Left Action
      strafeleft = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Strafe Left", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(strafeleft4, 20, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(strafeleft3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(strafeleft2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(strafeleft1, 20, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));


      //Strafe Right Frames
      string straferight1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 120, 90, 120, 90, 90, 45, 60, 90, 60, 90, 90, 45 });
      string straferight2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 60, 90, 60, 90, 90, 45, 120, 90, 120, 90, 90, 45 });
      string straferight3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 60, 1, 60, 1, 90, 45, 120, 2, 120, 2, 90, 45 });
      string straferight4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 120, 1, 120, 1, 90, 45, 60, 1, 60, 1, 90, 45 });

      //Strafe Right Action
      straferight = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Strafe Right", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(straferight1, 20, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(straferight2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(straferight3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(straferight4, 20, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Swim Frames
      string swim1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 60, 1, 120, 1, 140, 1, 60, 1, 120, 40, 40, 1 });
      string swim2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 30, 90, 30, 140, 60, 90, 40, 90, 1, 40, 60 });
      string swim3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 60, 1, 120, 1, 40, 60, 60, 1, 120, 40, 140, 60 });
      string swim4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 90, 30, 90, 30, 40, 1, 90, 40, 90, 1, 140, 1 });

      //Swim Action
      swim = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Swim", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(swim1, 20, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(swim2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim4, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim1, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim4, 20, 3, -1),          
          new EZ_B.Classes.AutoPositionActionFrame(swim1, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(swim4, 20, 3, -1),
        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Wave Frames
      string wave1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 10, 90, 10, 120, 90, 90, 30, 90, 30, 60, 90 });
      string wave2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 60, 90, 60, 120, 90, 90, 30, 90, 30, 60, 60 });
      string wave3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });


      //Wave Action
      wave = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Wave", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(wave1, 20, 4, 0),
          new EZ_B.Classes.AutoPositionActionFrame(wave2, 20, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(wave1, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wave2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wave1, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wave3, 25, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Wave Dance Frames
      string wavedance1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 90, 86, 90, 87, 88, 90, 90, 35, 90, 35, 82, 90 });
      string wavedance2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 90, 1, 90, 1, 90, 90, 90, 35, 90, 35, 90, 90 });
      string wavedance3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 20, 1, 60, 1, 90, 90, 90, 35, 90, 35, 90, 90 });
      string wavedance4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 120, 1, 160, 1, 90, 90, 90, 35, 90, 35, 90, 90 });
      string wavedance5 = ezb.AutoPosition.Config.AddFrame("Frame #5", new int[] { 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90, 90 });

      //Wave Dance Action
      wavedance = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Wave Dance", true, false, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(wavedance1, 25, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(wavedance2, 25, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wavedance3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wavedance4, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wavedance3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wavedance4, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wavedance3, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wavedance2, 15, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(wavedance5, 25, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Forward Frames
      string forward1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 120, 120, 120, 70, 90, 120, 160, 70, 90, 120, 40, 70 });
      string forward2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 120, 70, 120, 120, 90, 70, 160, 120, 90, 70, 40, 120 });
      string forward3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 60, 70, 60, 120, 140, 70, 90, 120, 20, 70, 90, 120 });
      string forward4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 60, 120, 60, 70, 140, 120, 90, 70, 20, 120, 90, 70 });

      //Forward Action
      forward = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Forward", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(forward1, 20, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(forward2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(forward4, 20, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Left Frames
      string left1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 100, 120, 80, 80, 100, 120, 80, 80, 100, 120, 80, 80 });
      string left2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 100, 80, 80, 120, 100, 80, 80, 120, 100, 80, 80, 120 });
      string left3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 80, 80, 100, 120, 80, 80, 100, 120, 80, 80, 100, 120 });
      string left4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 80, 120, 100, 80, 80, 120, 100, 80, 80, 120, 100, 80 });

      //Left Action
      left = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Left", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(left1, 20, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(left2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(left3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(left4, 20, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Right Frames
      string right1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 80, 120, 100, 80, 80, 120, 100, 80, 80, 120, 100, 80 });
      string right2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 80, 80, 100, 120, 80, 80, 100, 120, 80, 80, 100, 120 });
      string right3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 100, 80, 80, 120, 100, 80, 80, 120, 100, 80, 80, 120 });
      string right4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 100, 120, 80, 80, 100, 120, 80, 80, 100, 120, 80, 80 });

      //Right Action
      right = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Right", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(right1, 20, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(right2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(right3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(right4, 20, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

      //Reverse Frames
      string reverse1 = ezb.AutoPosition.Config.AddFrame("Frame #1", new int[] { 60, 120, 60, 90, 140, 120, 90, 90, 20, 120, 90, 90 });
      string reverse2 = ezb.AutoPosition.Config.AddFrame("Frame #2", new int[] { 60, 90, 60, 120, 140, 90, 90, 120, 20, 90, 90, 120 });
      string reverse3 = ezb.AutoPosition.Config.AddFrame("Frame #3", new int[] { 120, 90, 120, 120, 90, 90, 160, 120, 90, 90, 40, 120 });
      string reverse4 = ezb.AutoPosition.Config.AddFrame("Frame #4", new int[] { 120, 120, 120, 90, 90, 120, 160, 90, 90, 120, 40, 90 });

      //Reverse Action
      reverse = ezb.AutoPosition.Config.AddAction(new EZ_B.Classes.AutoPositionAction("Reverse", true, true, new EZ_B.Classes.AutoPositionActionFrame[] {
          new EZ_B.Classes.AutoPositionActionFrame(reverse1, 20, 3, 0),
          new EZ_B.Classes.AutoPositionActionFrame(reverse2, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse3, 20, 3, -1),
          new EZ_B.Classes.AutoPositionActionFrame(reverse4, 20, 3, -1),

        },
        EZ_B.Classes.AutoPositionAction.ActionTypeEnum.NA));

    }

    void AutoPosition_OnStartFrame(AutoPosition sender, EZ_B.Classes.AutoPositionFrame frame, EZ_B.Classes.AutoPositionActionFrame actionFrame) {

      Invokers.SetAppendText(textBox1, true, "Frame {0}  (Steps: {1}, Speed: {2}, Delay: {3})", frame.Title, actionFrame.Steps, actionFrame.ServoSpeed, actionFrame.Delay);
    }

    void AutoPosition_OnStartAction(AutoPosition sender, EZ_B.Classes.AutoPositionAction action) {

      Invokers.SetAppendText(textBox1, true, "Action Started: {0}", action.Title);
    }

    void AutoPosition_OnComplete(AutoPosition sender) {

      Invokers.SetAppendText(textBox1, true, "Action Stopped");
    }

    private void btnStart_Click(object sender, EventArgs e) {

      ucezB_Connect1.EZB.AutoPosition.ExecAction(legsdance);
    }

    private void btnStop_Click(object sender, EventArgs e) {

      ucezB_Connect1.EZB.AutoPosition.Stop();
    }

    private void btnLegsUpDown_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(legsupdown);
    }

    private void btnAttack_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(attack);
    }

    private void btnBounceDance_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(bouncedance);
    }

    private void btnByeWave_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(byewave);
    }

    private void btnCircleDance_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(circledance);
    }

    private void btnCurlDance_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(curldance);
    }

    private void btnHappyDance_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(happydance);
    }

    private void btnHeadStandDance_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(headstanddance);
    }

    private void btnHiWave_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(hiwave);
    }

    private void btnLegsUpDance_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(legsupdance);
    }

    private void btnMarchOnSpot_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(marchonspot);
    }

    private void btnMorningGreeting_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(morninggreeting);
    }

    private void btnPushUp_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(pushup);
    }

    private void btnRockBackAndForth_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(rockbackandforth);
    }

    private void btnRotateLegsDance_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(rotatelegsdance);
    }

    private void btnShutdown_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(shutdown);
    }

    private void btnSwim_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(swim);
    }

    private void btnWave_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(wave);
    }

    private void btnWaveDance_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(wavedance);
    }

    private void btnFastForward_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(fastforward);
    }

    private void btnFastRight_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(fastright);
    }

    private void btnFastReverse_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(fastreverse);
    }

    private void btnFastLeft_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(fastleft);
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

    private void btnRotateLeft_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(rotateleft);
    }

    private void btnRotateRight_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(rotateright);
    }

    private void btnStrafeLeft_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(strafeleft);
    }

    private void btnStrafeRight_Click(object sender, EventArgs e)
    {
        ucezB_Connect1.EZB.AutoPosition.ExecAction(straferight);
    }
  }
}
