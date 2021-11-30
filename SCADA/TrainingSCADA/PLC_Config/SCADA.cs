using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Config
{
    public class SCADA
    {
        List<TASK> TASKS = new List<TASK>();
        List<MOTOR> MOTORS = new List<MOTOR>();
        public List<MOTOR_FACEPLATE> MOTOR_FACEPLATES = new List<MOTOR_FACEPLATE>();
        public PLC S7500;
        public void AddMotorFacePlate(MOTOR_FACEPLATE faceplate)
        {
            MOTOR_FACEPLATES.Add(faceplate);
        }
        public void AddMotor(MOTOR motor)
        {
            motor.Parent = this;
            MOTORS.Add(motor);
        }
        public void RunMotor(string name)
        {
            MOTOR motor = null;
            for(int i = 0; i < MOTORS.Count; i++)
            {
                motor = MOTORS[i];
                if (motor.Name == name)
                {
                    motor.Engine();
                }
            }
        }
        public void AddTask(TASK task)
        {
            task.Parent = this;
            TASKS.Add(task);
        }
        public TASK FindTask(string name)
        {
            TASK task = null;
            for(int i=0; i< TASKS.Count; i++)
            {
                task = TASKS[i];
                if(task.Name == name)
                {
                    return task;
                }
            }
            return null;
        }

        public void RunTask(string name)
        {
            TASK task = null;
            for(int i=0; i<TASKS.Count; i++)
            {
                task = TASKS[i];
                if(task.Name == name)
                {
                    task.Engine();
                }
            }
        }

        public void AddPLC(PLC plc)
        {
            plc.Parent = this;
            S7500 = plc;
        }

    }
}
