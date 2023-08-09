using DataExtraction.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace DataExtraction
{
    public class AccessDataBase
    {
        private SqlConnection CreateNewConection()
        {
            return new SqlConnection(Settings.Default.ConectionDatabase);
        }

        public DataTable ExecSqlCommand(string query)
        {
            try
            {
                using (SqlConnection sqlconnection = CreateNewConection())
                {
                    sqlconnection.Open();

                    using (SqlCommand command = sqlconnection.CreateCommand())
                    {                
                        command.CommandText = query;
                        command.CommandTimeout = 7200;

                        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        sqlDataAdapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<List<object>>> ExtractData(string query)
        {
            try
            {
                var rows = new List<List<object>>();

                using (SqlConnection sqlconnection = CreateNewConection())
                {
                    sqlconnection.Open();

                    using (SqlCommand command = sqlconnection.CreateCommand())
                    {
                        command.CommandText = query;
                        command.CommandTimeout = 7200;

                        using (SqlDataReader dataReader = await command.ExecuteReaderAsync())
                        {
                            while (await dataReader.ReadAsync())
                            {
                                var values = new List<object>();
                                for (int i = 0; i < dataReader.FieldCount; i++)
                                {
                                    object value = dataReader.IsDBNull(i) ? null : dataReader.GetValue(i);
                                    values.Add(value);
                                }
                                rows.Add(values);
                            }
                        }
                    }
                }

                return rows;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
