using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCSharp.Context
{
    public class FruitContext : DbContext        
    {
        public FruitContext()
            : base("Fruit")
        {

        }

        public DbSet<Models.GrowsOn> GrowsOnDbSet { get; set; }
        public DbSet<Models.Fruit> FruitDbSet { get; set; }
    }
}
