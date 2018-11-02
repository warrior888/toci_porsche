using ConsoleApp1.MassStoarage.Interfaces;

namespace ConsoleApp1.MassStoarage
{
    public abstract class StoreDataBase<TSharding, TData> : IStoreData<TSharding, TData>
    {
        public abstract bool Store(TSharding sharding, TData data);
    }
}