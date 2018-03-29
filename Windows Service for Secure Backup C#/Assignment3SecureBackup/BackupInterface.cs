using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3SecureBackup
{
    interface BackupInterface
    {
        string taskname { get; set; }
        string tasktype { get; set; }
        string taskstarttime { get; set; }
        string taskrepeattime { get; set; }
        string taskendtime { get; set; }
        string tasksource { get; set; }
        string taskdest { get; set; }

        void TaskExecute();


    }
}
