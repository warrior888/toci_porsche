using System.Collections.Generic;

namespace ConsoleApp1.Sharding
{
    public abstract class ShardingStrategyBase : IShardingStrategy
    {
        public abstract int NumberOfClusters { get; set; }
        public abstract List<ICluster> Clusters { get; set; }
        public abstract ICluster ChooseCluster(long dataId);
    }
}