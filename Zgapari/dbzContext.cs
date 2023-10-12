using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zgapari
{
    public class dbzContext : DbContext
    {
        public DbSet<Zgapari> Zgaprebi { get; set; }


        public dbzContext(DbContextOptions<dbzContext> options)
            : base(options)
        {
        }

    }


   
    public class Zgapari
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZgapariId { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(2000)")]
        public string Content { get; set; }

    }


    /*
     *public class Blog
{
    public int BlogId { get; set; }

    [Column(TypeName = "varchar(200)")]
    public string Url { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Rating { get; set; }
} 
     * 
     * 
     * 
     * 
     * 
     * [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     * 
     * 
    */

}
