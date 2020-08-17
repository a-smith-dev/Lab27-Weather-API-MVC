using Lab27_API_MVC_combo.Models;
using System.Threading.Tasks;

namespace Lab27_API_MVC_combo.Services
{
    public interface IWeatherService
    {
        Task<Weather> GetWeather(string coordinates);
    }
}
