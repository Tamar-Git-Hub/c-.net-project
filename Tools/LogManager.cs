using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Tools
{
    public static class LogManager
    {
        private static string path = "Log";
        public static string GetRountingByMounth()
        {
            return path + "/" + DateTime.Now.Month +"-"+ DateTime.Now.Year;
        }
        public static string GetRountingByDay()
        {
            return GetRountingByMounth()+"/" + DateTime.Now.Day+".txt";
        }
        public static void WriteToLog(string projectName, string funcName,string message) 
        {
            if(!Directory.Exists(GetRountingByMounth()))
            {
                Directory.CreateDirectory(GetRountingByMounth());
            }
            if(!File.Exists(GetRountingByDay()))
            {
                File.Create(GetRountingByDay()).Close();
  
            }
            using(StreamWriter writer=new StreamWriter(GetRountingByDay(),true)) {
                writer.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
            }
          
        }
        public static void DeleteLog()
        { 
            string[] dirs = Directory.GetDirectories(path);
            for (int i = 0; i < dirs.Length; i++)
            {
                    string month = dirs[i].Substring(dirs[i].Length - 7);
                    month=month.Substring(0,2);
                    int monthBefore = DateTime.Now.Month - 1;
                    if (month != DateTime.Now.Month.ToString() && month != monthBefore.ToString())
                        Directory.Delete(dirs[i], true);
            }
        }
    }
}
