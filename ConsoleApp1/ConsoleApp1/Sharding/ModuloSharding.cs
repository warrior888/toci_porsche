using System;
using System.Collections.Generic;

namespace ConsoleApp1.Sharding
{
    public class ModuloSharding : ShardingStrategyBase
    {
        public override int NumberOfClusters { get; set; } // 8  - 16
        public override List<ICluster> Clusters { get; set; }

        public override ICluster ChooseCluster(Int64 dataId)// 1 678568578956  8 % 9 8  1   8 % 16  0 
        {
            return Clusters[(int)dataId % NumberOfClusters]; // 0 - ?7
        }
    }
}