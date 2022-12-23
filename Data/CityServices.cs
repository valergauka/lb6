using lb6.Context;
using Microsoft.EntityFrameworkCore;

namespace lb6.Data
{
    public class CityServices
    {
        protected readonly ConversationContext _context;
        public CityServices(ConversationContext context)
        {
            _context = context;
        }

        public async Task<List<City>> GetCities()
        {

            return await _context.Cities.ToListAsync(); ;
        }

        public async Task<City> GetCity(int id)
        {
            return await _context.Cities.FirstAsync(p => p.Id == id);
        }

        public async Task Create(City city)
        {
            await _context.Cities.AddAsync(city);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(City city)
        {
            _context.Cities.Update(city);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(City city)
        {
            _context.Cities.Remove(city);
            await _context.SaveChangesAsync();
        }
    }
}
