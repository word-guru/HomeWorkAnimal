using HomeWorkAnimal.Model;
using HomeWorkAnimal.Repozitory.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HomeWorkAnimal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRepozitory _repozitory;
        public Dictionary<List<string>, List<string>> animals;

        public IndexModel(IRepozitory repozitory)
        {
            _repozitory = repozitory;
            animals = new Dictionary<List<string>, List<string>>();
        }

        public void OnGet()
        {
            animals.Add(_repozitory.GetName(), _repozitory.GetSound());
        }
    }
}