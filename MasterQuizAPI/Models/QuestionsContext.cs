using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace MasterQuizAPI.Models
{
    public class QuestionsContext : DbContext
    {
        public QuestionsContext(DbContextOptions<QuestionsContext> options)
            : base(options)
        {
        }

        public DbSet<Question> QuestionItens { get; set; } = null!;
    }
}