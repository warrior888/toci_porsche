namespace ConsoleApp1.Sharding
{
    public class Cluster  : ICluster<int>
    {
        protected int ClusterId;

        public Cluster(int clusterId)
        {
            ClusterId = clusterId;
        }

        public int GetClusterId()
        {
            return ClusterId;
        }
    }
}