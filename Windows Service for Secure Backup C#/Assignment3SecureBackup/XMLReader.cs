using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Assignment3SecureBackup
{
    class XMLReader
    {
        public List<BackupInterface> ReadBytesXml()
        {
            List<BackupInterface> ScheduledTaskList = new List<BackupInterface>();
            List<string> param = new List<string>();
            XElement xelement = XElement.Load(@"C:\Users\dell\Documents\Visual Studio 2015\Projects\xmlReadOperation\xmlReadOperation\bin\Debug\test.xml");
            var elementInXml = from taskexecute in xelement.Elements("Task")
                               select taskexecute;
            //FileBackup schedulerObj = new FileBackup();
            GetObjectFactory factory = new GetObjectFactory();
            int i = 1;
            foreach (var task in elementInXml)
            {
                param.Add(task.Attribute("name").Value);
                param.Add(task.Attribute("type").Value);
                param.Add(task.Element("Occurrence").Attribute("starttime").Value);
                param.Add(task.Element("Occurrence").Attribute("repeat").Value);
                param.Add(task.Element("Occurrence").Attribute("endtime").Value);
                param.Add(task.Element("SecureBackup").Attribute("src").Value);
                param.Add(task.Element("SecureBackup").Attribute("dest").Value);

                if (i == 1)
                {
                    BackupInterface tasks = factory.getBackup(param[1]);
                    tasks.taskname = param[0];
                    tasks.taskrepeattime = param[3];
                    tasks.taskstarttime = param[2];
                    tasks.taskendtime = param[4];
                    tasks.tasktype = param[1];
                    tasks.tasksource = param[5];
                    tasks.taskdest = param[6];

                    ScheduledTaskList.Add(tasks);
                    i++;
                }
                else if (i == 2)
                {
                    BackupInterface tasks = factory.getBackup(param[8]);
                    tasks.taskname = param[7];
                    tasks.taskrepeattime = param[10];
                    tasks.taskstarttime = param[9];
                    tasks.taskendtime = param[11];
                    tasks.tasktype = param[8];
                    tasks.tasksource = param[12];
                    tasks.taskdest = param[13];

                    ScheduledTaskList.Add(tasks);
                    i++;
                }
                else if (i == 3 && param[1] != "SecureBackup")
                {
                    BackupInterface tasks = factory.getBackup(param[15]);
                    tasks.taskname = param[14];
                    tasks.taskrepeattime = param[17];
                    tasks.taskstarttime = param[16];
                    tasks.taskendtime = param[18];
                    tasks.tasktype = param[15];
                    tasks.tasksource = param[19];
                    tasks.taskdest = param[20];

                    ScheduledTaskList.Add(tasks);
                    i++;
                }
                else
                {

                }
            }

            return ScheduledTaskList;
        }
    }
}
