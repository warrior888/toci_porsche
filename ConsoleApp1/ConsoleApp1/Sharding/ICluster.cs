namespace ConsoleApp1.Sharding
{
    public interface ICluster<out TClusterId>
    {
        TClusterId GetClusterId();
    }
}