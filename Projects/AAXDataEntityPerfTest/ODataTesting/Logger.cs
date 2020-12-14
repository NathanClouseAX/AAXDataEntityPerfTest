using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Net.Security;
using System.Security.Authentication;
using System.IO;
using System.Timers;

//pulled from https://stackoverflow.com/questions/3507770/write-to-a-file-from-multiple-threads-asynchronously-c-sharp
//https://stackoverflow.com/questions/6195084/thread-safe-logging-class-implementation
// misc others
namespace ODataTesting
{
    public class Logger
    {
        // Queue import: 
        // using System.Collections
        public ConcurrentQueue<string> logs = new ConcurrentQueue<string>();
        public string path = "debug.log";

        private static ReaderWriterLockSlim _readWriteLock = new ReaderWriterLockSlim();

        public Logger(string path)
        {
            this.path = path;
        }

        public void add(string t)
        {
            this.logs.Enqueue(t);
            //Console.WriteLine(t);
        }

        public void addList(List<string> t)
        {
            foreach (string log in t)
            {
                this.logs.Enqueue(log);

                //Console.WriteLine(log);
            }
        }

        public void saveNow()
        {
            while(this.logs.Count > 0) 
            {
                // Get from queue
                //string err = (string)this.logs.Dequeue();
                string err;
                this.logs.TryDequeue(out err);
                // Save to logs
                saveToFile(err, this.path);
            }
        }

        public bool saveToFile(string text, string path)
        {
            _readWriteLock.EnterWriteLock();

            try
            {
                // string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                // text = text + Environment.NewLine;
                
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(text);
                    sw.Close();
                }
                
            }
            //catch (Exception e)
            //{
            //    // return to queue
            //    this.logs.Enqueue(text + "[SAVE_ERR]");
            //    return false;
            //}
            finally
            {
                // Release lock
                _readWriteLock.ExitWriteLock();
            }
            return true;
        }

        public String currTime()
        {
            DateTime d = DateTime.UtcNow.ToLocalTime();
            return d.ToString("yyyy-MM-dd hh:mm:ss");
        }
    }
}
