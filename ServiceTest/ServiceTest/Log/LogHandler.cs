using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;

namespace ServiceTest.Log
{
    public class LogHandler: ILogHandler
    {
        public void Write(string folderName, string logMensage, bool NuevoProceso = false)
        {

            if (Convert.ToBoolean(ConfigurationManager.AppSettings["ACTIVARLOG"].ToString()))
            {
                try
                {
                    string path = ConfigurationManager.AppSettings["RUTALOG"].ToString() + "\\LOG\\";
                    //string path = System.AppDomain.CurrentDomain.BaseDirectory + "\\LOG\\";

                    //Folder Year
                    path += "\\" + DateTime.Now.Year.ToString();
                    if (!System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(path);
                    }

                    //Folder Month
                    path += "\\" + DateTime.Now.ToString("MM");
                    if (!System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(path);
                    }

                    //Folder Day
                    path += "\\" + DateTime.Now.ToString("dd");
                    if (!System.IO.Directory.Exists(path))
                    {
                        System.IO.Directory.CreateDirectory(path);
                    }



                    string fileName = "\\Log" + folderName;
                    string fullPath = path + fileName + ".txt";


                    if ((File.Exists(fullPath)))
                    {
                        using (System.IO.StreamWriter sw = File.AppendText(fullPath))
                        {
                            if (NuevoProceso)
                            { sw.WriteLine(logMensage); }
                            else
                            { sw.WriteLine(DateTime.Now + ": " + logMensage); }

                            sw.Close();
                        }


                    }
                    else
                    {
                        using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fullPath))
                        {
                            if (NuevoProceso)
                            { sw.WriteLine(logMensage); }
                            else { sw.WriteLine(DateTime.Now + ": " + logMensage); }

                            sw.Close();
                        }

                    }

                }
                catch (Exception ex)
                {
                    //LogBD("BFCO.ReenvioTxPayu", "LogHandlerByFiles.Write", ex);
                }
            }
        }
    }
}
