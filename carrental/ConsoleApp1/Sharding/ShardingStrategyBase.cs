using System.Collections.Generic;

namespace ConsoleApp1.Sharding
{
    public abstract class ShardingStrategyBase<TClusterId> : IShardingStrategy<TClusterId>
    {
        public abstract int NumberOfClusters { get; set; }
        public abstract List<ICluster<TClusterId>> Clusters { get; set; }
        public abstract ICluster<TClusterId> ChooseCluster(long dataId);
    }
}