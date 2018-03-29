using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3SecureBackup
{
    class GetObjectFactory
    {
        public BackupInterface getBackup(string tasktype)
        {

            if (tasktype == "SecureBackup")
            {
                return new FileBackup();
            }
            else if (tasktype == "RestoreBackup")
            {
                return new FileRestore();

            }
            else if (tasktype == "memoryfootprint")
            {
                return new MemoryTask();
            }
            else
            {
                return null;
            }
        }
    }
}
