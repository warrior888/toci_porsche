using System;
using System.Collections.Generic;
using ConsoleApp1.Interfaces;
using Npgsql;

namespace ConsoleApp1.Dal.PostgreSql
{
    public class PostgreSqlDbAccess : DbAccessBase
    {
        protected NpgsqlConnection connection;

        public PostgreSqlDbAccess(string connectionString)
        {
            //Connect(connectionString);// vmc #1
        }

        protected override bool Disconnect()
        {
            try
            {
                connection.Close();
            }
            catch (NpgsqlException ex)
            {
                // TODO log error

                return false;
            }

            return true;
        }

        protected override bool Connect(string connectionString)
        {
            connection = new NpgsqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (NpgsqlException ex)
            {
                // TODO log error
                return false;
            }

            return true;
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
            string query = "insert into {0} ({1}) values ({2});";

            /// refleksja
            
            List<string> columns = new List<string>(entity.GetType().GetProperties().Length); 
            List<string> values = new List<string>(entity.GetType().GetProperties().Length); 
            
            foreach (var item in entity.GetType().GetProperties())
            {
                columns.Add(item.Name);
                //values.Add(item.GetValue(item).ToString());
            }

            values.Add("1");
            values.Add("Andrzej");

            query = string.Format(query, entity.GetType().Name, string.Join(", ", columns), "\"" + string.Join("\", \"", values) + "\"");

            return 1;
        }
    }
}