using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_and_vegetable_shop.Data
{
    public class VegansContext:DbContext
    {
        public VegansContext() : base("VegansContext")
        {

        }

        public DbSet<VeganType> VeganTypes { get; set; }
        public DbSet<Vegan> Vegans { get; set; }
    }
}
