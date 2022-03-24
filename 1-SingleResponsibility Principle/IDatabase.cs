using System;
using System.Collections.Generic;
using System.Data.Common;

namespace Solid.Principles._1_SingleResponsibility_Principle
{
    public class singleResponsibilityPrinciple
    {
        public static void Start()
        {
            //use main here
        }
    }
    public interface IDatabase
    {
        void SetConnectionString();

        void Execute(DbCommand dbCommand);

        DbCommand CreateSPCommand(string spName, List<DbParameter> param = null);
    }

    public class Database : IDatabase
    {
        public DbCommand CreateSPCommand(string spName, List<DbParameter> param = null)
        {
            //Create StoreProcedure 
            throw new NotImplementedException();
        }

        public void Execute(DbCommand dbCommand)
        {
            //Execute the cmd 
            throw new NotImplementedException();
        }

        public void SetConnectionString()
        {
            //Set the connectionString 
            throw new NotImplementedException();
        }
    }
}
