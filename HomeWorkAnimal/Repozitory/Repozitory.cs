using HomeWorkAnimal.Model;
using HomeWorkAnimal.Repozitory.Interface;

namespace HomeWorkAnimal.Repozitory
{
    public class Repozitory : IRepozitory
    {
        private readonly IEnumerable<Animal> _animals;

       private List<string> listName { get; set; }
       private List<string> listSound { get; set; }

        public Repozitory( IEnumerable<Animal> animals)
        {
         
            //_animals = new List<Animal>() { new Cat(),new Dog()};
            _animals = animals;
        }

        public List<string> GetName()
        {
            listName = new List<string>();
            foreach (var name in _animals)
            {
                listName.Add(name.Name);
            }
            return listName;
        }

        public List<string> GetSound()
        {
            listSound = new List<string>();
            foreach (var name in _animals)
            {
                listSound.Add(name.Sound);
            }
            return listSound;
        }
    }
}
