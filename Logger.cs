using System;
using System.IO;

namespace rht
{
    public class Logger
    {
      public static void WriteLine (string process, string filename, string line){

        string curDir = Directory.GetCurrentDirectory();
        string debugDir = Directory.GetParent(curDir).FullName;
        string binDir = Directory.GetParent(debugDir).FullName;
        string mainDir = Directory.GetParent(binDir).FullName;
        string timeStamp = DateTime.Now.ToString("H_mm");
        string dateStamp = DateTime.Today.ToString("MM_dd_yyyy");

        Console.WriteLine(String.Format(@"Time Stamp: {0}", timeStamp));
        Console.WriteLine(String.Format(@"Date Stamp: {0}", dateStamp));
        Console.WriteLine(String.Format(@"Main Dir: {0}", mainDir));

        DirectoryInfo dirInf = Directory.CreateDirectory(String.Format(@"{0}\process_logs\{1}", curDir, process));

        Console.WriteLine(String.Format(@"Dir Inf: {0}", dirInf));

        // using (StreamWriter sw = new StreamWriter(String.Format(@"{0}\{1}_{2}.txt", dirInf, process, timeStamp), true))
        using (StreamWriter sw = new StreamWriter(String.Format(@"{0}\{1}_{2}.txt", dirInf, process, filename), true))
        {
          sw.Write(String.Format(@"{0}{1}", line, Environment.NewLine));
          sw.Flush();
        }
      }
      public static void WriteStream (string process, FileStream stream){

        string curDir = Directory.GetCurrentDirectory();
        string debugDir = Directory.GetParent(curDir).FullName;
        string binDir = Directory.GetParent(debugDir).FullName;
        string mainDir = Directory.GetParent(binDir).FullName;
        string timeStamp = DateTime.Now.ToString("H_mm");
        string dateStamp = DateTime.Today.ToString("MM_dd_yyyy");

        Console.WriteLine(String.Format(@"Time Stamp: {0}", timeStamp));
        Console.WriteLine(String.Format(@"Date Stamp: {0}", dateStamp));
        Console.WriteLine(String.Format(@"Main Dir: {0}", mainDir));

        DirectoryInfo dirInf = Directory.CreateDirectory(String.Format(@"{0}\process_logs\{1}", curDir, process));

        Console.WriteLine(String.Format(@"Dir Inf: {0}", dirInf));

        using (StreamWriter sw = new StreamWriter(String.Format(@"{0}\{1}_{2}.txt", dirInf, process, timeStamp), true))
        {
          sw.Write(stream);
          sw.Flush();
        }
      }
    }
}