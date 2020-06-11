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
        public void UpdateTable(Table table, bool isAvailable, bool isReserved) //update the booleans for the table
        {
            String query = "update [table] set isAvailable = @isAvailable, isReserved = @isReserved where table_id = @Id; ";

            SqlParameter[] sqlParameters = new SqlParameter[3]
               {
                   new SqlParameter("@isAvailable", Convert.ToInt32(isAvailable)), //convert bool to int, pass as parameter
                   new SqlParameter("@isReserved", Convert.ToInt32(isReserved)),
                   new SqlParameter("@Id", table.tableId)
               };

            ExecuteEditQuery(query, sqlParameters);
        }
        public Order GetOrderByTable(int table_id) //get the order for the specified table
        {
            OpenConnection(); //if I remove this, everything breaks so i'm going to leave it here
            Order order = null;

            //return only the LATEST order for that table
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
                    if (!order.IsPaid) //if the table exists and is not paid, set it to the table
                        table.order = order;

                tablesTemp.Add(table); //add all the tables to a temporary list
            }

            List<int> tableId = new List<int>(); //store all the table ids in a list

            //loop through all the table, MAKE SURE the tables added to the list have different table IDs          
            foreach (Table t in tablesTemp)
            {
                if (tableId.Contains(t.tableId))//if that table id already exists, go to the next table
                    continue;
                tableId.Add(t.tableId);
                tables.Add(t);
            }
            return tables;
        }
    }
}
