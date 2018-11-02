using ConsoleApp1.Gallery.Interfaces;
using ConsoleApp1.Sharding;

namespace ConsoleApp1.MassStoarage
{
    public class FileStoreData : StoreDataBase<ModuloSharding<int>, IFile>
    {
        public override bool Store(ModuloSharding<int> sharding, IFile data)
        {
            ICluster<int> cluster =  sharding.ChooseCluster(data.Id);
            
            return true;
        }
    }
}