using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Assignment3SecureBackup
{
    class FileBackup : BackupInterface
    {
        byte[] readBytesEven;
        byte[] readBytesOdd;

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

        public void TaskExecute()
        {
            string pathEven =
                @"C:\Users\dell\Documents\Visual Studio 2015\Projects\Assignment3SecureBackup\Assignment3SecureBackup\bin\Debug\Even.txt";
            string pathOdd =
                @"C:\Users\dell\Documents\Visual Studio 2015\Projects\Assignment3SecureBackup\Assignment3SecureBackup\bin\Debug\Odd.txt";
            string pathInput =
                @"C:\Users\dell\Documents\Visual Studio 2015\Projects\Assignment3SecureBackup\Assignment3SecureBackup\bin\Debug\newtest.txt";



            using (var stream = File.Open(pathInput, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                byte[] readFile = File.ReadAllBytes(pathInput);
                int lengthFile = readFile.Length;

                readBytesEven = new byte[lengthFile];
                readBytesOdd = new byte[lengthFile];

                for (int i = 0; i < lengthFile; i++)
                {
                    if (i % 2 == 0)
                    {
                        //read even bytes from a file in a bytes array
                        readBytesEven[i] = (byte)stream.ReadByte();
                    }
                    else
                        //read odd bytes from a file in a bytes array
                        readBytesOdd[i] = (byte)stream.ReadByte();
                }
            }
            //Console.WriteLine(Encoding.Default.GetString(readBytesEven));
            //Console.WriteLine(Encoding.Default.GetString(readBytesOdd));




            //writing even bytes to a file
            using (var streamEven = File.Open(pathEven, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                File.WriteAllBytes(pathEven, readBytesEven);
               // Console.WriteLine("done with even backup");

            }


            //writing odd bytes to a file
            using (var streamOdd = File.Open(pathOdd, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                File.WriteAllBytes(pathOdd, readBytesOdd);
               // Console.WriteLine("done with odd backup");

            }



            //Console.ReadLine();
        }
    }
}
