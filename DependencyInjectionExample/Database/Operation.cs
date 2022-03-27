using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjectionExample.Database
{
    public class Operation : IOperation
    {
        IConfiguration _configuration;
        public Operation(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public object CallFunction(string functionName, List<object> parameterList)
        {
            throw new NotImplementedException();
        }

        public bool CallProcedure(string procedureName, List<object> parameterList)
        {
            throw new NotImplementedException();
        }

        public DataSet CallProcedureGetData(string procedureName, List<object> parameterList)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string tableName, Dictionary<string, object> whereParameterList)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string tableName, List<string> columnList, List<object> parameterList)
        {
            throw new NotImplementedException();
        }

        public bool Insert(string tableName, Dictionary<string, object> columnAndParameter)
        {
            throw new NotImplementedException();
        }

        public DataSet Select(string query, List<object> parameterList)
        {
            throw new NotImplementedException();
        }

        public bool Update(string tableName, List<string> columnList, List<object> parameterList, Dictionary<string, object> whereParameterList)
        {
            throw new NotImplementedException();
        }

        public bool Update(string tableName, Dictionary<string, object> columnAndParameter, Dictionary<string, object> whereParameterList)
        {
            throw new NotImplementedException();
        }
    }
}
