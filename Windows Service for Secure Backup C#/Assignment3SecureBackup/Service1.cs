using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;
namespace Assignment3SecureBackup
{
    public partial class Service1 : ServiceBase
    {

        private static Timer aTimer;
        
        public Service1()
        {
            InitializeComponent();
        }
       
        protected override void OnStart(string[] args)
        {
            
            
            Thread Mainthread = new Thread(MainThreadEntryFunction);
            Mainthread.Start();
        }

        protected override void OnStop()
        {
        }


        public void MainThreadEntryFunction()
        {
            XMLReader obj = new XMLReader();
            List<BackupInterface> scheduledTaskList = obj.ReadBytesXml();
            //Console.WriteLine("count is ");
            //Console.WriteLine(scheduledTaskList.Count);

            foreach (var task in scheduledTaskList)
            {
                BackupInterface task1 = task;


                Thread myThread = new Thread(new ParameterizedThreadStart(scheduling));

                myThread.Start(task1);
            }
        }

        //int time = ConvertMinutesToMilliseconds(task.taskrepeattime);
        public static int ConvertMinutesToMilliseconds(int minutes)
        {
            return (int)TimeSpan.FromMinutes(minutes).TotalMilliseconds;
        }

        public static int RepeatInterval(string repeattime)
        {

            int str = Convert.ToInt32(repeattime.Substring(0, repeattime.Length - 1));
            int time = 0;
            if (repeattime.Contains("m"))
            {
                time = ConvertMinutesToMilliseconds(str);
                //Console.WriteLine("i got the interval man");
            }/*else if (repeattime.Contains("s"))
            {
                time = ConvertMinutesToMilliseconds(str);
            }else if (repeattime.Contains("h"))
            {
                time = ConvertMinutesToMilliseconds(str);
            }else if(repeattime.Contains("h"))
            {
                time = ConvertMinutesToMilliseconds(str);
            }*/
            else
            {

            }


            return time;
        }
        private static void scheduling(object task)
        {
            //typecasting
            BackupInterface backup = (BackupInterface)task;


            //thread sleep    current -repeat
            Timer aTimer = new Timer();

            aTimer.Elapsed += (sender, e) => OnTimedEvent(sender, e, backup);
           // Console.WriteLine(backup.taskrepeattime);
            aTimer.Interval = RepeatInterval(backup.taskrepeattime);
           // Console.WriteLine(aTimer.Interval);
            aTimer.Start();

            backup.TaskExecute();
            //end time== current time
            string Currenttime = DateTime.Now.ToString("yyyyMMdd hh:mm");
            string taskendtime = (backup.taskendtime);

           // Console.WriteLine(taskendtime);
            //Console.WriteLine(Currenttime);

            while (Currenttime != taskendtime)
            {
                //Console.WriteLine("i am in while loop");
                Currenttime = DateTime.Now.ToString("yyyyMMdd hh:mm");
                //Console.WriteLine(taskendtime);
                //Console.WriteLine(Currenttime);
                //Console.WriteLine("inside while loop");
            }
            //Console.WriteLine("outside while loop");
            aTimer.Enabled = false;
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e, BackupInterface b)
        {
            //Console.WriteLine("i amd repeating");
            b.TaskExecute();
        }

    }
}
