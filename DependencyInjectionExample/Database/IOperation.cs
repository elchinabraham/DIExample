using System.Collections.Generic;
using System.Data;

namespace DependencyInjectionExample.Database
{
    public interface IOperation
    {
        DataSet CallProcedureGetData(string procedureName, List<object> parameterList);
        bool CallProcedure(string procedureName, List<object> parameterList);
        object CallFunction(string functionName, List<object> parameterList);
        DataSet Select(string query, List<object> parameterList);
        bool Insert(string tableName, List<string> columnList, List<object> parameterList);
        bool Insert(string tableName, Dictionary<string, object> columnAndParameter);
        bool Update(string tableName, List<string> columnList, List<object> parameterList, Dictionary<string, object> whereParameterList);
        bool Update(string tableName, Dictionary<string, object> columnAndParameter, Dictionary<string, object> whereParameterList);
        bool Delete(string tableName, Dictionary<string, object> whereParameterList);

    }
}
