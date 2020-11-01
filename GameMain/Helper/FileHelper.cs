using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMain.Helper
{
    public static class FileHelper
    {
        private static string basePath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        private static string dataPath = Path.Combine(basePath, "data");

        private static string saveFile = Path.Combine(basePath, "user.json");

        //private static 

        public static string LoadData()
        {
            string saveData = "";

            if (Directory.Exists(dataPath) && File.Exists(saveFile))
            {
                StreamReader sr = new StreamReader(saveFile, Encoding.UTF8);
                StringBuilder sb = new StringBuilder();
                while (sr.EndOfStream == false)
                {
                    sb.Append(sr.ReadLine());
                }

                saveData = sb.ToString();
            }

            return saveData;
        }

        public static string SaveData(string saveData)
        {
            string msg = "";

            try
            {
                if (!Directory.Exists(dataPath))
                {
                    Directory.CreateDirectory(dataPath);
                }

                //如果存在則刪除
                if (File.Exists(saveFile))
                {
                    File.Delete(saveFile);
                }

                //再新增
                using (FileStream fs = new FileStream(saveFile, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs, Encoding.Default))
                    {
                        sw.Write(saveData);//将当前控件文本值写入缓冲流                       
                        sw.Flush();//将缓冲流写入正式的文件基础流      
                        sw.Close();
                    }
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }

            return msg;
        }



    }
}
