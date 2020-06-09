using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using RosaModel;
namespace RosaDAL
{
    /// <summary>
    ///   Table DAO class
    ///   Made by Cosmin Ilie
    ///   Student number: 645976
    /// </summary>
    public class TableDAO : Base
    {
        public List<Table> Db_Get_AllTables()
        {
            //read tables from database
            String query = "select [table].table_id,[order].order_id, capacity, isAvailable, isReserved,[order].[orderDate] FROM [table] LEFT JOIN [order] ON [order].table_id=[table].table_id ORDER BY table_id,orderDate DESC;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateTable(Table table, bool isAvailable, bool isReserved)
        {
            String query = "update [table] set isAvailable = @isAvailable, isReserved = @isReserved where table_id = @Id; ";

            SqlParameter[] sqlParameters = new SqlParameter[3]
               {
                   new SqlParameter("@isAvailable", Convert.ToInt32(isAvailable)),
                   new SqlParameter("@isReserved", Convert.ToInt32(isReserved)),
                   new SqlParameter("@Id", table.tableId)
               };

            ExecuteEditQuery(query, sqlParameters);
        }
        public Order GetOrderByTable(int table_id)
        {
            OpenConnection();
            Order order = null;

            String query = "SELECT TOP 1 order_id, table_id, orderDate, notes, isPaid FROM [order] WHERE table_id = @table_id ORDER BY orderDate DESC;";
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@table_id", table_id);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null && reader.Read())
                        order = ReadOrder(reader);
                }
            }
            return order;
        }
        private Order ReadOrder(SqlDataReader reader)
        {
            //read the whole order - DO NOT FORGET TO IMPLEMENT
            Order order = new Order()
            {
                OrderID = (int)reader["order_id"],
                DateTime = (DateTime)reader["orderDate"],
                IsPaid = (bool)reader["isPaid"]               
            };

            order.Table.tableId = (int)reader["table_id"];

            return order;
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

                Order order = GetOrderByTable(table.tableId);

                if (order != null)
                    if (!order.IsPaid)
                        table.order = order;

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
