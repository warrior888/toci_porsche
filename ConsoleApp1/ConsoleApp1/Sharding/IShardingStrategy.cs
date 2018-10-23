using System.Collections.Generic;

namespace ConsoleApp1.Sharding
{
    public interface IShardingStrategy
    {
        int NumberOfClusters { get; set; }

        List<ICluster> Clusters { get; set; }

        ICluster ChooseCluster(long dataId);
    }
}