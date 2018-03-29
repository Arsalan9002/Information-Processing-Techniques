using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3SecureBackup
{
    class MemoryTask : BackupInterface
    {
        public string _taskname;
        public string _tasktype;
        public string _taskstarttime;
        public string _taskrepeattime;
        public string _taskendtime;
        public string _tasksrcpath;
        public string _taskdestpath;


        public string taskname
        {
            get { return _taskname; }
            set { _taskname = value; }
        }

        public string tasktype
        {
            get { return _tasktype; }
            set { _tasktype = value; }
        }

        public string taskstarttime
        {
            get { return _taskstarttime; }
            set { _taskstarttime = value; }
        }

        public string taskrepeattime
        {
            get { return _taskrepeattime; }
            set { _taskrepeattime = value; }
        }

        public string taskendtime
        {
            get { return _taskendtime; }
            set { _taskendtime = value; }
        }

        public string tasksource
        {
            get { return _tasksrcpath; }
            set { _tasksrcpath = value; }
        }

        public string taskdest
        {
            get { return _taskdestpath; }
            set { _taskdestpath = value; }
        }


        static EventLog eventLog = new EventLog();

        private string pathInput =
            @"C:\Users\dell\Documents\Visual Studio 2015\Projects\Assignment3SecureBackup\Assignment3SecureBackup\bin\Debug\memory.txt";
        public void TaskExecute()
        {

            Process[] processes = Process.GetProcesses();
            List<string> myList = new List<string>();
            using (var stream = File.Open(pathInput, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                foreach (Process theprocess in processes)
                {
                    string processname = theprocess.ProcessName;
                    /*myList.Add(theprocess.Id.ToString());
                    myList.Add(theprocess.Id.ToString());
                    myList.Add(theprocess.TotalProcessorTime.TotalMilliseconds.ToString());
                    myList.Add(theprocess.VirtualMemorySize64.ToString());*/

                    File.AppendAllText(pathInput, string.Join(Environment.NewLine, processname));

                    //eventLog.WriteEntry("CPU : {0}", theprocess.TotalProcessorTime.TotalMilliseconds);

                }
            }


        }
    }
}
