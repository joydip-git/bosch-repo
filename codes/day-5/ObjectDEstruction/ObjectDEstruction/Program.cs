using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ObjectDEstruction
{
    class Program
    {
        static void Main()
        {
            //GC.GetTotalMemory();

            Console.WriteLine($"Main Thread Id: {Thread.CurrentThread.ManagedThreadId}");
            //FileDataAccess dataAccess = null;
            try
            {
               FetchFileData();
                Console.WriteLine("some other job continues....");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.WriteLine("Main method continues....");
        }

        private static void FetchFileData()
        {
            FileDataAccess dataAccess = null;
            using (dataAccess = new FileDataAccess())
            {
                Console.WriteLine(dataAccess.GetData());

                WeakReference<FileDataAccess> weakReference = new WeakReference<FileDataAccess>(dataAccess);

                Console.WriteLine("doing some operations...");

                Console.WriteLine(dataAccess.GetData());
                //dataAccess.Dispose();               
            }
            //dataAccess = null;
        }
    }
}
