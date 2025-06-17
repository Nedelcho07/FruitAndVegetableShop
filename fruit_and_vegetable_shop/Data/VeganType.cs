using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_and_vegetable_shop.Data
{
    public class VeganType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Vegan> Vegans { get; set; }//1 към много
    }
}
