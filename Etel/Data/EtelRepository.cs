using Etel.Models;

namespace Etel.Data
{
    public class EtelRepository : IEtelRepository
    {
        EtelDbContext context;

        public EtelRepository(EtelDbContext context)
        {
            this.context = context;
        }

        public void Create(EtelClass etel)
        {
            var etelSameName = context.Foods.FirstOrDefault(t => t.Nev == etel.Nev);
            if (etelSameName != null)
            {
                throw new ArgumentException("Baka, this food already exists. :3");
            }
            context.Foods.Add(etel);
            context.SaveChanges();
        }

        public IEnumerable<EtelClass> Read()
        {
            System.Threading.Thread.Sleep(2000);
            return context.Foods;
        }

        public EtelClass? Read(string name)
        {
            System.Threading.Thread.Sleep(2000);
            return context.Foods.FirstOrDefault(t => t.Nev == name);
        }

        public EtelClass? ReadFromId(string id)
        {
            return context.Foods.FirstOrDefault(t => t.Id == id);
        }

        public void Delete(string name)
        {
            var etel = Read(name);
            context.Foods.Remove(etel);
            context.SaveChanges();
        }

        public void Update(EtelClass etel)
        {
            var old = Read(etel.Nev);
            old.Tapertek = etel.Tapertek;
            old.Kategoria = etel.Kategoria;
            old.Ar = etel.Ar;
            context.SaveChanges();
        }
    }
}
