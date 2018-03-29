using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3SecureBackup
{
    class FileRestore  : BackupInterface
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


        string pathEven =
            @"C:\Users\dell\Documents\Visual Studio 2015\Projects\Assignment3SecureBackup\Assignment3SecureBackup\bin\Debug\Even.txt";

        string pathOdd =
            @"C:\Users\dell\Documents\Visual Studio 2015\Projects\Assignment3SecureBackup\Assignment3SecureBackup\bin\Debug\Odd.txt";

        const string pathInput =
            @"C:\Users\dell\Documents\Visual Studio 2015\Projects\Assignment3SecureBackup\Assignment3SecureBackup\bin\Debug\newtest.txt";

        string pathRestore =
           @"C:\Users\dell\Documents\Visual Studio 2015\Projects\Assignment3SecureBackup\Assignment3SecureBackup\bin\Debug\Restore.txt";
        static FileInfo f = new FileInfo(pathInput);
        long len = f.Length;



        public void TaskExecute()
        {
            byte[] restoreBytes = new byte[len * 3];

            Console.WriteLine("testing out");
            using (FileStream fs = new FileStream(pathRestore, FileMode.Create, FileAccess.Write))
            {

                FileStream fsEeven = new FileStream(pathEven, FileMode.Open, FileAccess.Read);
                FileStream fsOdd = new FileStream(pathOdd, FileMode.Open, FileAccess.Read);
                Console.WriteLine("testing");
                //Console.WriteLine(len*2);
                for (int i = 0; i < len; i++)
                {
                    //Console.WriteLine("testing");
                    if (i % 2 == 0)
                    {
                        restoreBytes[i] = (byte)fsEeven.ReadByte();
                       // Console.WriteLine("done with restore even");
                        //Console.WriteLine(restoreBytes[i]);
                    }
                    else
                    {
                        restoreBytes[i] = (byte)fsOdd.ReadByte();
                        //Console.WriteLine("done with restore odd");
                        //Console.WriteLine(restoreBytes[i]);
                    }
                    //Console.WriteLine("inside restore");
                }
                //Console.WriteLine("done with restore");
                fsEeven.Close();
                fsOdd.Close();
            }

            File.WriteAllBytes(pathRestore, restoreBytes);

        }

    }
}
