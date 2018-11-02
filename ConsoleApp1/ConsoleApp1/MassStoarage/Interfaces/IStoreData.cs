namespace ConsoleApp1.MassStoarage.Interfaces
{
    public interface IStoreData<in TSharding, in TData>
    {
        bool Store(TSharding sharding, TData data);
    }
}