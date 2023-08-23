using Microsoft.EntityFrameworkCore;
public class TarefaContext : DbContext
{
    public DbSet<Tarefa> Tarefas {get;set;} = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Server=JULIO-NOTEG15;Database=tarefasbd;Trusted_Connection=True");
        optionsBuilder.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //muda o tamanho da string no banco de dados de Tamanho máximo para tamanho 30
        modelBuilder.Entity<Tarefa>().Property(t => t.Nome).HasMaxLength(30);
    }
}