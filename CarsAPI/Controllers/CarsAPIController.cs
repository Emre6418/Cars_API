using CarsAPI.Models;
using Microsoft.AspNetCore.Mvc;
 

namespace CarsAPI.Controllers
{
    [ApiController]
    [Route("API/[controller]")]
    public class CarsAPIController : Controller
    {

        public static List<FoCars> foCars = new List<FoCars>() {
            new FoCars { ID = 1, Mark = "Ford", Model = "Focus", Year = 2023, Engine = "1.5L" },
            new FoCars { ID = 2, Mark = "Ford", Model = "Fiesta", Year = 2023, Engine = "1.0L Ecoboost" },
            new FoCars { ID = 3, Mark = "Ford", Model = "Tourneo Connect", Year = 2023, Engine = "2.0L EcoBlue" },
            new FoCars { ID = 4, Mark = "Ford", Model = "Tourneo Courier", Year = 2023, Engine = "1.5L TDCi" },
            new FoCars { ID = 5, Mark = "Ford", Model = "Ranger Raptor", Year = 2023, Engine = "3.0L Twin-Turbo EcoBoost V6" },
            new FoCars { ID = 6, Mark = "Ford", Model = "Kuga", Year = 2023, Engine = "1.5L EcoBoost" },
            new FoCars { ID = 7, Mark = "Ford", Model = "Puma", Year = 2023, Engine = "1.5L" },
            new FoCars { ID = 8, Mark = "Ford", Model = "Puma ST", Year = 2023, Engine = "1.5L EcoBoost" },
            new FoCars { ID = 9, Mark = "Ford", Model = "Mustang Mach E", Year = 2023, Engine = "Electric" },
            new FoCars { ID = 10, Mark = "Ford", Model = "Fiesta ST", Year = 2023, Engine = "3.0L EcoBoost V6 " },
            new FoCars { ID = 11, Mark = "Ford", Model = "Mustang", Year = 2023, Engine = "5.0L - V8" }

            };

        [HttpGet]
        public List<FoCars> Get()
        {
            return foCars;
        }

        [HttpGet("{id}")]
        public FoCars Get(int id)
        {

            return foCars.FirstOrDefault(car => car.ID == id);

        }

        [HttpPost]
        public FoCars Post(FoCars car)
        {
            foCars.Add(car);
            return car;
        }

        [HttpPut]
        public FoCars Put([FromBody] FoCars focars)
        {
            var EditCar = foCars.FirstOrDefault(car => car.ID == car.ID);
            EditCar.Mark = focars.Mark;
            EditCar.Model = focars.Model;
            EditCar.Year = focars.Year;
            EditCar.Engine = focars.Engine;
            return EditCar;
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var DeletedCar = foCars.FirstOrDefault(car => car.ID == id);
            foCars.Remove(DeletedCar);



        }


    }
}
