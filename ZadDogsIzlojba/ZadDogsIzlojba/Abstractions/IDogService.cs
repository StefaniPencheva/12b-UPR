using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZadDogsIzlojba.Domain;

namespace ZadDogsIzlojba.Abstractions
{
    public interface IDogService
    {
        bool Create(string name, int age, string breed, string picture);

        bool UpdateDog(int dogId, string name, int age, string breed, string picture);


        public List<Dog> GetDogs();

        public Dog GetDogById(int dogId);

        public bool RemoveId(int dogId);

        List<Dog> GetDogs(string searchStringBreed, string searchStringName);
        
    }
}
