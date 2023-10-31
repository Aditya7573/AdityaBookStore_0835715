using System;
using System.Collections.Generic;
using System.Text;
using Dapper;

namespace AdityaBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        // e.g first coloumn of first row in the result set 
        T Single<T>(string procedurename, DynamicParameters param = null);
        // excecute something to the data bt not retrieeve anything
        void Execute(string procedurename, DynamicParameters param = null);
        // reterive the complete row or record 
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        // get all the rows
        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);
        // Stored Proccedure that reture two tables 
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}

