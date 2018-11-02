using System.Collections.Generic;

namespace ConsoleApp1.Sharding
{
    public interface IShardingStrategy<TClusterId>
    {
        int NumberOfClusters { get; set; }

        List<ICluster<TClusterId>> Clusters { get; set; }

        ICluster<TClusterId> ChooseCluster(long dataId);
    }
}