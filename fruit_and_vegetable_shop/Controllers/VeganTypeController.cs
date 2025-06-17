using fruit_and_vegetable_shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_and_vegetable_shop.Controllers
{
    public class VeganTypeController
    {
        private VegansContext vegandbcontex = new VegansContext();
        public List<Vegan> GetAllVegans()
        {
            return vegandbcontex.Vegans.ToList();
        }
        public string GetFruitById(int id)
        {
            return vegandbcontex.Vegans.Find(id).Name;
        }
        public List<VeganType> GetAllVeganTypes()
        {
            return vegandbcontex.VeganTypes.ToList();
        }

    }
}
