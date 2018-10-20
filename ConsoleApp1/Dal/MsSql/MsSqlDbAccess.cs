using System.Collections.Generic;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Dal.MsSql
{
    public class MsSqlDbAccess : DbAccessBase
    {
        protected override bool Connect(string connectionString)
        {
            throw new System.NotImplementedException();
        }

        protected override bool Disconnect()
        {
            throw new System.NotImplementedException();
        }

        public override bool Delete(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public override List<IEntity> Select()
        {
            throw new System.NotImplementedException();
        }

        public override bool Update(IEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public override long Insert(IEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}