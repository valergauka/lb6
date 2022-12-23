﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using lb6.Data;

namespace lb6.Context
{
    public class ConversationContext : DbContext
    {
        public ConversationContext(DbContextOptions<ConversationContext> options) : base(options)
        {

        }
        public DbSet<Abonent> Abonents { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Conversation> Conversations { get; set; }
    }
}
