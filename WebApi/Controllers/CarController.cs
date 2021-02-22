using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("[controller]")]
    public class CarController : Controller
    {

        [HttpGet("[action]")]
        public async Task<IActionResult> SearchInventory(string color = null, bool? hasSunroof = null, bool? isFourWheelDrive = null, bool? hasLowMiles = null, bool? hasPowerWindows = null, bool? hasNavigation = null, bool? hasHeatedSeats = null)
        {
            List<Car> cars = await LoadCars();

            // query is used to filter out the cars based on the params
            // start with all cars in the inventory then apply filters using where clauses
            var query = from c in cars select c;

            if (!string.IsNullOrWhiteSpace(color))
            {
                query = query.Where(c => c.Color.ToLowerInvariant() == color.ToLowerInvariant());
            }

            if (hasSunroof != null)
            {
                query = query.Where(c => c.HasSunroof == hasSunroof);
            }

            if (isFourWheelDrive != null)
            {
                query = query.Where(c => c.IsFourWheelDrive == isFourWheelDrive);
            }

            if (hasLowMiles != null)
            {
                query = query.Where(c => c.HasLowMiles == hasLowMiles);
            }

            if (hasPowerWindows != null)
            {
                query = query.Where(c => c.HasPowerWindows == hasPowerWindows);
            }

            if (hasNavigation != null)
            {
                query = query.Where(c => c.HasNavigation == hasNavigation);
            }

            if (hasHeatedSeats != null)
            {
                query = query.Where(c => c.HasHeatedSeats == hasHeatedSeats);
            }

            return Ok(query.ToList<Car>());
        }

        private async Task<List<Car>> LoadCars()
        {
            using StreamReader sr = new StreamReader("cars.json");
            string json = await sr.ReadToEndAsync();
            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(json);
            return cars;
        }

    }
}
