using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
//using System.Net.Http;

namespace ObjectDEstruction
{
    class FileDataAccess : IDisposable
    {
        private StreamReader reader;
        public FileDataAccess()
        {
          
        }

        //Finalizer (called by CLR, by using separate thread)
        //this is called at the end of the entire application
        ~FileDataAccess()
        {
            //reader.Close();
            //reader = null;
            Console.WriteLine("destructor called...");
            Console.WriteLine($"Destructor Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            //GC.ReRegisterForFinalize(this);
            reader.Close();
            reader = null;
            Console.WriteLine("dispose called...");
            Console.WriteLine($"Dispose Thread Id: {Thread.CurrentThread.ManagedThreadId}");
        }

        public string GetData()
        {
            StringBuilder stringBuilder = null;

            try
            {
                using (reader = new StreamReader(@"E:\training\bosch-repo\codes\day-5\ObjectDEstruction\data.txt"))
                {
                    stringBuilder = new StringBuilder();
                    while (!reader.EndOfStream)
                    {
                        string data = null;
                        if ((data = reader.ReadLine()) != string.Empty)
                        {
                            stringBuilder.Append(data + Environment.NewLine);
                        }
                    }
                }
                return stringBuilder.ToString();
            }
            catch (IOException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
