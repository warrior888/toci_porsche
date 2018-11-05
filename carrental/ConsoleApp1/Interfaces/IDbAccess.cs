using System;
using System.Collections.Generic;

namespace ConsoleApp1.Interfaces
{
    public interface IDbAccess : IDisposable
    {
        bool Delete(IEntity entity); // delete from developers where id = 5;

        // CRUD
        // create
        // read
        //update
        //delete
        //??

        List<IEntity> Select(/* ??? */);

        bool Update(IEntity entity);

        long Insert(IEntity entity);
    }
}