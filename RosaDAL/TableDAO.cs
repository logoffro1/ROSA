using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaModel;
namespace RosaDAL
{
    public class TableDAO : Base
    {
        public List<Table> Db_Get_AllTables()
        {
            //read employees from database
            string query = "select table_id, capacity, isAvailable, isReserved from [table]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Table GetById(int id)
        {
            SqlCommand cmd = new SqlCommand("SELECT table_id, capacity, isAvailable, isReserved FROM [table] WHERE table_id = @table_id", conn);
            cmd.Parameters.AddWithValue("@table_id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Table table = null;
            if (reader.Read())
            {
                table = ReadTable(reader);
            }
            return table;
        }
        private Table ReadTable(SqlDataReader reader)
        {
            Table table = new Table()
            {
                tableId = (int)reader["table_id"],
                capacity = (int)reader["capacity"],
                isAvailable = (bool)reader["isAvailable"],
                isReserved = (bool)reader["isReserved"]

            };

            return table;

        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tables = new List<Table>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Table table = new Table()
                {
                    tableId = (int)dr["table_id"],
                    capacity = (int)dr["capacity"],
                    isAvailable = (bool)dr["isAvailable"],
                    isReserved = (bool)dr["isReserved"]
                };

                tables.Add(table);
            }
            return tables;
        }
    }
}
