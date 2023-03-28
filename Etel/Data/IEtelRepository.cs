using Etel.Models;

namespace Etel.Data
{
    public interface IEtelRepository
    {
        void Create(EtelClass etel);
        void Delete(string name);
        IEnumerable<EtelClass> Read();
        EtelClass? Read(string name);
        EtelClass? ReadFromId(string id);
        void Update(EtelClass etel);
    }
}