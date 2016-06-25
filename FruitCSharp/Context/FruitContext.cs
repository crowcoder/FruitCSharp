using System.Collections.Generic;
using System.Data.Entity;

namespace FruitCSharp.Context
{
    public class FruitContext : DbContext        
    {
        public FruitContext()
            : base("Fruit")
        {
            Database.SetInitializer(new FruitDbInitializer());
        }

        public DbSet<Models.GrowsOn> GrowsOnDbSet { get; set; }
        public DbSet<Models.Fruit> FruitDbSet { get; set; }
    }

    public class FruitDbInitializer : CreateDatabaseIfNotExists<FruitContext>
    {
        protected override void Seed(FruitContext context)
        {
            context.GrowsOnDbSet.AddRange(new List<Models.GrowsOn> {
                new Models.GrowsOn { GrowsOnName = "Tree" },
                new Models.GrowsOn { GrowsOnName = "Vine" },
                new Models.GrowsOn { GrowsOnName = "Bush" }
            });

            context.FruitDbSet.AddRange(new List<Models.Fruit>
            {
                new Models.Fruit { FruitName = "Banana", FruitColor = "Yellow", FruitGrowsOn = 1, FruitIsYummy = true },
                new Models.Fruit { FruitName = "Grape", FruitColor = "Purple", FruitGrowsOn = 2, FruitIsYummy = true },
                new Models.Fruit { FruitName = "BlueBerry", FruitColor = "Blue", FruitGrowsOn = 3, FruitIsYummy = true }
            });

            base.Seed(context);
        }
    }
}
