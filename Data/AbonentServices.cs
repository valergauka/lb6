using lb6.Context;
using Microsoft.EntityFrameworkCore;

namespace lb6.Data
{
    public class AbonentServices
    {
        protected readonly ConversationContext _context;
        public AbonentServices(ConversationContext context)
        {
            _context = context;
        }

        public async Task<List<Abonent>> GetAbonents()
        {

            return await _context.Abonents.ToListAsync(); ;
        }

        public async Task<Abonent> GetAbonent(int id)
        {
            return await _context.Abonents.FirstAsync(p => p.Id == id);
        }

        public async Task Create(Abonent abonent)
        {
            await _context.Abonents.AddAsync(abonent);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Abonent abonent)
        {
            _context.Abonents.Update(abonent);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Abonent abonent)
        {
            _context.Abonents.Remove(abonent);
            await _context.SaveChangesAsync();
        }
    }
}
