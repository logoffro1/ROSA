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
            //read tables from database
            string query = "select [table].table_id, capacity, isAvailable, isReserved,[order].[orderDate], [order].[status] FROM [table] LEFT JOIN [order] ON [order].table_id=[table].table_id ORDER BY table_id,orderDate DESC;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Table GetById(int id)
        {
            SqlCommand cmd = new SqlCommand("select TOP 1 [table].table_id, capacity, isAvailable, isReserved, [order].[status], orderDate FROM [table] LEFT JOIN[order] ON [order].table_id =[table].table_id WHERE[table].table_id = @table_id ORDER BY  orderDate DESC; ", conn);
            cmd.Parameters.AddWithValue("@table_id", id);
            SqlDataReader reader = cmd.ExecuteReader();
            Table table = null;
            if (reader.Read())
            {
                table = ReadTable(reader);
            }
            return table;
        }
        public void UpdateTable(Table table, bool isAvailable, bool isReserved)
        {
            SqlCommand cmd = new SqlCommand("update [table] set isAvailable = @isAvailable, isReserved = @isReserved where table_id = @Id; ", conn);
            cmd.Parameters.AddWithValue("@isAvailable", Convert.ToInt32(isAvailable));
            cmd.Parameters.AddWithValue("@isReserved", Convert.ToInt32(isReserved));
            cmd.Parameters.AddWithValue("@Id", table.tableId);

            cmd.ExecuteReader();
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
            //check if the column with the index 5(status) is null and set table.status accordingly
            if (reader.IsDBNull(5))
                table.status = 0;
            else
                table.status = (int)reader["status"];

            if (!reader.IsDBNull(4))
                table.orderdate = (DateTime)reader["orderDate"];
            return table;

        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            List<Table> tablesTemp = new List<Table>();
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
                if (dr.IsNull("status")) //check if the status is null and set table.status accordingly
                    table.status = 0;
                else
                    table.status = (int)dr["status"];

                if (!dr.IsNull("orderDate"))
                    table.orderdate = (DateTime)dr["orderDate"];
                tablesTemp.Add(table);
            }

      
            List<int> tableId = new List<int>();
            foreach (Table t in tablesTemp)
            {
                if (tableId.Contains(t.tableId))
                    continue;
                tableId.Add(t.tableId);
                tables.Add(t);
            }
            return tables;
        }
    }
}
