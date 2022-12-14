using HomeWorkAnimal.Repozitory.Interface;
using System.Text.RegularExpressions;

namespace HomeWorkAnimal.Repozitory
{
    public class FileOperations : IFileOperations
    {
        private readonly IWebHostEnvironment env;

        public FileOperations(IWebHostEnvironment env)
        {
            this.env = env;
        }

        public Dictionary<string,string> LoadFile()
        {
            string path = env.WebRootPath + "/File/TextFile.txt";
            var regex = new Regex(@"[a-zA-Z]+");
            Dictionary<string,string> result = new Dictionary<string,string>();

            foreach (var item in File.ReadLines(path)) 
            {
                if(regex.IsMatch(item))
                {
                    var str = item.Split(':');
                    result[str[0]] = str[1];
                }
            }
            return result;
        }

        public void SaveFile(string text)
        {
            string path = env.WebRootPath + "/File/test.txt";
            File.WriteAllText(path, text);
        }
    }
}
