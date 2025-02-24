using Microsoft.EntityFrameworkCore;

namespace spellstoringitem.Models
{
    public class spellstoringitemContext : DbContext
    {
        public spellstoringitemContext(DbContextOptions<spellstoringitemContext> options)
            : base(options)
        { }

        public DbSet<NewSpell> NewSpells { get; set; }

    }        
}
