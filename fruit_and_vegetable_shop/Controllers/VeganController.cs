using fruit_and_vegetable_shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_and_vegetable_shop.Controllers
{
    public class VeganController
    {
        private VegansContext vegansDbContext = new VegansContext();

        public Vegan Get(int id)
        {
            Vegan findedVegan = vegansDbContext.Vegans.Find(id);
            {
                if (findedVegan == null)
                {
                    vegansDbContext.Entry(findedVegan).Reference(x => x.VeganTypes).Load();
                }
                return findedVegan;
            }
        }
        public List<Vegan> GetAll()
        {
            return vegansDbContext.Vegans.Include("Vegans").ToList();
        }
        public void Create(Vegan vegan)
        {
            vegansDbContext.Vegans.Add(vegan);
            vegansDbContext.SaveChanges();
            
        }
        public void Update(int id, Vegan vegan)
        {
            Vegan findedVegan = vegansDbContext.Vegans.Find(id);
            if(findedVegan == null)
            {
                return;
            }
            findedVegan.Name= vegan.Name;
            findedVegan.Description= vegan.Description;
            findedVegan.Price= vegan.Price;
            findedVegan.VeganTypeId= vegan.VeganTypeId;
            findedVegan.VeganTypeId= vegan.VeganTypeId;
            vegansDbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            Vegan findedVegan = vegansDbContext.Vegans.Find(id);
            vegansDbContext.Vegans.Remove(findedVegan);
            vegansDbContext.SaveChanges();
        }


    } 
}
    
   
