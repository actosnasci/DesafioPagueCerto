using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace ApiPagueCerto.Models
{
    public class TransactionsContext : DbContext
    {
        //entender Métodos Genéricos -- entender o método que segue 
        public TransactionsContext(DbContextOptions<TransactionsContext> options)
            : base(options)
        { 
        }

        public DbSet<Transaction> Transactions { get; set; } = null!;
    }
}