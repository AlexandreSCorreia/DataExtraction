using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace DataExtraction
{
    public class DatabaseRepository
    {
        private readonly AccessDataBase accessDataBase = new AccessDataBase();

        public async Task<DataTable> GetListAllDataBaseName()
        {
            string query = "SELECT name FROM sys.databases WHERE name NOT IN ('master', 'tempdb', 'model', 'msdb')";
            DataTable data = accessDataBase.ExecSqlCommand(query);

            return data;
        }

        public async Task<DataTable> GetListAllTableOrViewName(string databaseName)
        {
            string query = $"USE {databaseName} SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' OR TABLE_TYPE = 'VIEW' ORDER BY TABLE_TYPE, TABLE_NAME";
            DataTable data = accessDataBase.ExecSqlCommand(query);

            return data;
        }

        public async Task<DataTable> GetListAllColumnsName(string databaseName, string tableOrViewName)
        {
            string query = $"USE {databaseName} SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{tableOrViewName}'";
            DataTable data = accessDataBase.ExecSqlCommand(query);

            return data;
        }

        public DataTable ListAllData(string databaseName, string tableOrViewName, string filter)
        {
            string query = $"USE {databaseName} SELECT * FROM {tableOrViewName}";
            if (!string.IsNullOrEmpty(filter))
            {
                query += $" WHERE {filter}";
            }

            DataTable data = accessDataBase.ExecSqlCommand(query);

            return data;
        }

        public async Task<List<List<object>>> ListAllDataToWrite(string databaseName, string tableOrViewName, string filter)
        {
            string query = $"USE {databaseName} SELECT * FROM {tableOrViewName}";
            if (!string.IsNullOrEmpty(filter))
            {
                query += $" WHERE {filter}";
            }

           return await accessDataBase.ExtractData(query);
        }
    }
}
