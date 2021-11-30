using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PLC_Config;

namespace TrainingSCADA
{
    static class Program
    {

        public static SCADA Root;
        public static Form1 TestData;

        [STAThread]
         static void Main()
        {
            
            Root = new SCADA();
            TestData = new Form1(Root);
            PLC plc = new PLC(S7.Net.CpuType.S71500, "192.168.0.10", 0, 1, 500);
            Root.AddPLC(plc);
            TASK Task_1 = new TASK("Task_1", 250);

            TAG Motor_1_1_Mode = new TAG("Motor_1_1_Mode", "Motor_1_1.Mode");
            TAG Motor_1_1_RunFeedBack = new TAG("Motor_1_1_RunFeedBack", "Motor_1_1.RunFeedBack");
            TAG Motor_1_1_Fault = new TAG("Motor_1_1_Fault", "Motor_1_1.Fault");

            TAG Motor_1_2_Mode = new TAG("Motor_1_2_Mode", "Motor_1_2.Mode");
            TAG Motor_1_2_RunFeedBack = new TAG("Motor_1_2_RunFeedBack", "Motor_1_2.RunFeedBack");
            TAG Motor_1_2_Fault = new TAG("Motor_1_2_Fault", "Motor_1_2.Fault");

            TAG Motor_2_1_Mode = new TAG("Motor_2_1_Mode", "Motor_2_1.Mode");
            TAG Motor_2_1_RunFeedBack = new TAG("Motor_2_1_RunFeedBack", "Motor_2_1.RunFeedBack");
            TAG Motor_2_1_Fault = new TAG("Motor_2_1_Fault", "Motor_2_1.Fault");

            TAG Motor_2_2_Mode = new TAG("Motor_2_2_Mode", "Motor_2_2.Mode");
            TAG Motor_2_2_RunFeedBack = new TAG("Motor_2_2_RunFeedBack", "Motor_2_2.RunFeedBack");
            TAG Motor_2_2_Fault = new TAG("Motor_2_2_Fault", "Motor_2_2.Fault");

            TAG Mixer_1_Mode = new TAG("Mixer_1_Mode", "Mixer_1.Mode");
            TAG Mixer_1_RunFeedBack = new TAG("Mixer_1_RunFeedBack", "Mixer_1.RunFeedBack");
            TAG Mixer_1_Fault = new TAG("Mixer_1_Fault", "Mixer_1.Fault");

            TAG Valve_3_1_Mode = new TAG("Valve_3_1_Mode", "Valve_3_1.Mode");
            TAG Valve_3_1_RunFeedBack = new TAG("Valve_3_1_RunFeedBack", "Valve_3_1.RunFeedBack");
            TAG Valve_3_1_Fault = new TAG("Valve_3_1_Fault", "Valve_3_1.Fault");

            TAG Valve_3_2_Mode = new TAG("Valve_3_2_Mode", "Valve_3_2.Mode");
            TAG Valve_3_2_RunFeedBack = new TAG("Valve_3_2_RunFeedBack", "Valve_3_2.RunFeedBack");
            TAG Valve_3_2_Fault = new TAG("Valve_3_2_Fault", "Valve_3_2.Fault");

            TAG Level = new TAG("Level", "Level.0");
            TAG Level1 = new TAG("Level1", "Level.1");

            TAG HI = new TAG("HI", "CtrlPanel.HI");
            TAG LO = new TAG("LO", "CtrlPanel.LO");
            TAG HI1 = new TAG("HI1", "CtrlPanel.HI1");
            TAG LO1 = new TAG("LO1", "CtrlPanel.LO1");


            MOTOR Motor_1_1 = new MOTOR("Motor_1_1");
            MOTOR Motor_1_2 = new MOTOR("Motor_1_2");
            MOTOR Motor_2_1 = new MOTOR("Motor_2_1");
            MOTOR Motor_2_2 = new MOTOR("Motor_2_2");
            MOTOR Mixer_1 = new MOTOR("Mixer_1");
            MOTOR Valve_3_1 = new MOTOR("Valve_3_1");
            MOTOR Valve_3_2 = new MOTOR("Valve_3_2");


            MOTOR_FACEPLATE faceplate1 = new MOTOR_FACEPLATE(Motor_1_1);
            MOTOR_FACEPLATE faceplate2 = new MOTOR_FACEPLATE(Motor_1_2);
            MOTOR_FACEPLATE faceplate3 = new MOTOR_FACEPLATE(Motor_2_1);
            MOTOR_FACEPLATE faceplate4 = new MOTOR_FACEPLATE(Motor_2_2);
            MOTOR_FACEPLATE faceplate5 = new MOTOR_FACEPLATE(Mixer_1);
            MOTOR_FACEPLATE faceplate6 = new MOTOR_FACEPLATE(Valve_3_1);
            MOTOR_FACEPLATE faceplate7 = new MOTOR_FACEPLATE(Valve_3_2);

            Root.AddMotor(Motor_1_1);
            Root.AddMotor(Motor_1_2);
            Root.AddMotor(Motor_2_1);
            Root.AddMotor(Motor_2_2);
            Root.AddMotor(Mixer_1);
            Root.AddMotor(Valve_3_1);
            Root.AddMotor(Valve_3_2);

            Root.AddMotorFacePlate(faceplate1);
            Root.AddMotorFacePlate(faceplate2);
            Root.AddMotorFacePlate(faceplate3);
            Root.AddMotorFacePlate(faceplate4);
            Root.AddMotorFacePlate(faceplate5);
            Root.AddMotorFacePlate(faceplate6);
            Root.AddMotorFacePlate(faceplate7);

            Root.RunMotor("Motor_1_1");
            Root.RunMotor("Motor_1_2");
            Root.RunMotor("Motor_2_1");
            Root.RunMotor("Motor_2_2");
            Root.RunMotor("Mixer_1");
            Root.RunMotor("Valve_3_1");
            Root.RunMotor("Valve_3_2");

            Task_1.AddTag(Level);
            Task_1.AddTag(Level1);

            Task_1.AddTag(HI);
            Task_1.AddTag(HI1);
            Task_1.AddTag(LO);
            Task_1.AddTag(LO1);

            Task_1.AddTag(Motor_1_1_Mode);
            Task_1.AddTag(Motor_1_1_RunFeedBack);
            Task_1.AddTag(Motor_1_1_Fault);

            Task_1.AddTag(Motor_1_2_Mode);
            Task_1.AddTag(Motor_1_2_RunFeedBack);
            Task_1.AddTag(Motor_1_2_Fault);

            Task_1.AddTag(Motor_2_1_Mode);
            Task_1.AddTag(Motor_2_1_RunFeedBack);
            Task_1.AddTag(Motor_2_1_Fault);

            Task_1.AddTag(Motor_2_2_Mode);
            Task_1.AddTag(Motor_2_2_RunFeedBack);
            Task_1.AddTag(Motor_2_2_Fault);

            Task_1.AddTag(Mixer_1_Mode);
            Task_1.AddTag(Mixer_1_RunFeedBack);
            Task_1.AddTag(Mixer_1_Fault);

            Task_1.AddTag(Valve_3_1_Mode);
            Task_1.AddTag(Valve_3_1_RunFeedBack);
            Task_1.AddTag(Valve_3_1_Fault);

            Task_1.AddTag(Valve_3_2_Mode);
            Task_1.AddTag(Valve_3_2_RunFeedBack);
            Task_1.AddTag(Valve_3_2_Fault);

            Root.AddTask(Task_1);
            Root.RunTask("Task_1");

            Application.EnableVisualStyles();
            Application.Run(TestData);
        }
    }
}
