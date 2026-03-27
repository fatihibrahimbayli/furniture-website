using FurnitureApp.Models;

namespace FurnitureApp.Services.Interfaces
{
    public interface ISliderService
    {
        Task<List<Slider>> GetAllAsync();
         Task<Slider> GetByIdAsync(int id);
         Task CreateAsync(Slider slider);
         Task UpdateAsync(Slider slider);
         Task DeleteAsync(int id);
    }
}
