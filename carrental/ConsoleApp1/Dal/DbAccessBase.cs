using System.Collections.Generic;
//using ConsoleApp1.Dal.PostgreSql;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Dal
{
    public abstract class DbAccessBase : IDbAccess
    {
        protected abstract bool Connect(string connectionString);

        protected abstract bool Disconnect();

        public abstract bool Delete(IEntity entity);
        public abstract List<IEntity> Select();
        public abstract bool Update(IEntity entity);
        public abstract long Insert(IEntity entity);

        // abstract virtual override
        public virtual void Dispose()
        {
            Disconnect();
        }
    }
}