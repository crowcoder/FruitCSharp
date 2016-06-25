using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitCSharp.Models
{
    public class Fruit
    {
        public int Id { get; set; }
        public string FruitName { get; set; }
        public string FruitColor { get; set; }
        public int FruitGrowsOn { get; set; }
        public bool FruitIsYummy { get; set; }
    }
}
