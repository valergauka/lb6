using lb6.Context;
using Microsoft.EntityFrameworkCore;

namespace lb6.Data
{
    public class ConversationServices
    {
        protected readonly ConversationContext _context;
        
        public ConversationServices(ConversationContext context)
        {
            _context = context;
            

        }

        public async Task<List<Conversation>> GetConversations()
        {
            return await _context.Conversations.Include(p => p.Abonent).Include(p => p.City).ToListAsync();
        }

        public async Task<Conversation> GetConversation(int id)
        {
            return await _context.Conversations.FirstAsync(p => p.Id == id);
        }

        public async Task Create(Conversation conversation)
        {
            await _context.Conversations.AddAsync(conversation);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(Conversation conversation)
        {
            _context.Conversations.Remove(conversation);
            await _context.SaveChangesAsync();
        }
    }
}
