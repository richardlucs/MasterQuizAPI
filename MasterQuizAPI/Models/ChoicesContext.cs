using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MasterQuizAPI.Models
{
    public class ChoicesContext : DbContext
    {
        public ChoicesContext(DbContextOptions<ChoicesContext> options)
            : base(options)
        {
        }

        public DbSet<Choice> ChoiceItens { get; set; } = null!;
    }
}