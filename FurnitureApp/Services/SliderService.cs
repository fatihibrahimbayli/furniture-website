using FurnitureApp.Data;
using FurnitureApp.Models;
using FurnitureApp.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FurnitureApp.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _dbContext;
        public SliderService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateAsync(Slider slider)
        {
            await _dbContext.Sliders.AddAsync(slider);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var slider= await _dbContext.Sliders.FindAsync(id);
           if(slider is null)
            {
                throw new Exception("Slider not found");
            }
             _dbContext.Sliders.Remove(slider);
            await _dbContext.SaveChangesAsync();


        }

        public async Task<List<Slider>> GetAllAsync()
        {
           return await _dbContext.Sliders.ToListAsync();
        }

        public Task<Slider> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Slider slider)
        {
            throw new NotImplementedException();
        }
    }
}
