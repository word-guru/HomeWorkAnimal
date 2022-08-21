using HomeWorkAnimal.Model;
using HomeWorkAnimal.Repozitory.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWorkAnimal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepozitory _repozitory;
        private readonly IFileOperations _fileOperations;
        public Dictionary<List<string>, List<string>> animals;
        public Dictionary<string, string> animals2 = new Dictionary<string, string>();

        public IndexModel(IRepozitory repozitory, IFileOperations fileOperations)
        {
            _repozitory = repozitory;
            animals = new Dictionary<List<string>, List<string>>();
            _fileOperations = fileOperations;   
        }

        public void OnGet()
        {
            animals.Add(_repozitory.GetName(), _repozitory.GetSound());
        }

        public void OnPostSaveFile()
        {
            animals.Add(_repozitory.GetName(), _repozitory.GetSound());
            string res = "";
            foreach(var a in animals)
            {
                for(int i = 0; i < a.Key.Count; i++)
                {
                    res += a.Key[i] + " : " + a.Value[i] + Environment.NewLine;

                }
            }
            _fileOperations.SaveFile(res);
        }

        public void OnPostLoadFile()
        {
            animals2 = _fileOperations.LoadFile();
        }
    }
}