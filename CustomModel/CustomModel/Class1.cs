using boot;
using boot.Tools;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CustomModel
{
    public class Class1 : BaseModel
    {
        private string snippetPath {get;set;}
        public string GetSnippetPath()
        {
            string path = "C:/Users";
            string sub = "/AppData/Roaming/Code/User/snippets";

            DirectoryInfo userPath = new DirectoryInfo(path);
            var dis = userPath.GetDirectories();
            for (int i = 0; i < dis.Length; i++)
            {
                string snptPath = dis[i].FullName+sub;                
                if (new DirectoryInfo(snptPath).Exists)
                {
                    snippetPath = snptPath;
                    return snptPath;
                }
            }            
            return "";
        }
        public string GetFiles(string path)
        {
            List<file> fileList = new List<file>();
            DirectoryInfo snptPath = new DirectoryInfo(path);
            FileInfo[] files = snptPath.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo f = files[i];
                string content = File.ReadAllText(f.FullName);
                fileList.Add(new file(f.Name, f.Extension, content));
            }
            return Json.GetJsonString(fileList);
        }

        public bool SaveFile(string path,string content)
        {
            try
            {
                File.WriteAllText(path, content);
            }catch(Exception e)
            {
                return false;
            }
            return true;
        }

        public string Backup(string path,string content)
        {
            if(snippetPath == null)
            {
                return "Snippet path error!";
            }
            HttpClient hc = new HttpClient();
            List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
            param.Add(new KeyValuePair<string, string>("path", path));
            param.Add(new KeyValuePair<string, string>("data", content));
            HttpContent hcon = new FormUrlEncodedContent(param);
            Task<HttpResponseMessage> responseMessage = hc.PostAsync("http://www.cggsquash.com/alan/snpts1/php/saveFile.php",hcon);
            responseMessage.Wait();
            Task<string> reString = responseMessage.Result.Content.ReadAsStringAsync();
            return "OK";            
        }
        public string Restore(string path)
        {
            HttpClient hc = new HttpClient();
            List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
            param.Add(new KeyValuePair<string, string>("path", path));
            HttpContent hcon = new FormUrlEncodedContent(param);
            Task<HttpResponseMessage> responseMessage = hc.PostAsync("http://www.cggsquash.com/alan/snpts1/php/getFiles.php", hcon);
            responseMessage.Wait();
            Task<string> reString = responseMessage.Result.Content.ReadAsStringAsync();
            return reString.Result;
        }
    }
}
