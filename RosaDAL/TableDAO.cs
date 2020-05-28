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
            string query = "select [table].table_id,[order].order_id, capacity, isAvailable, isReserved,[order].[orderDate] FROM [table] LEFT JOIN [order] ON [order].table_id=[table].table_id ORDER BY table_id,orderDate DESC;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public Table GetById(int id)
        {
            SqlCommand cmd = new SqlCommand("select TOP 1 [table].table_id,[order].order_id, capacity, isAvailable, isReserved,isWaiting, orderDate FROM [table] LEFT JOIN[order] ON [order].table_id =[table].table_id WHERE[table].table_id = @table_id ORDER BY  orderDate DESC; ", conn);
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
        public Order GetOrderByTable(int table_id)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand("select TOP 1 order_id, table_id, orderDate, notes, isPaid FROM [order] WHERE table_id = @table_id ORDER BY orderDate DESC; ", conn);
            cmd.Parameters.AddWithValue("@table_id", table_id);
            SqlDataReader reader = cmd.ExecuteReader();
            Order order = null;
            if (reader.Read())
            {
                order = ReadOrder(reader);
            }
            return order;          
        }
        private Order ReadOrder(SqlDataReader reader)
        {
            OpenConnection();

            Order order = null;
            if (!reader.IsDBNull(0))
            {
                order = new Order()
                {
                    orderID = (int)reader["order_id"],
                    // notes = (string)reader["notes"], 
                    dateTime = (DateTime)reader["orderDate"],
                    table = (int)reader["table_id"]
                };
                if (!reader.IsDBNull(4))
                    order.isPaid = (bool)reader["isPaid"];
                else
                    order.isPaid = false;
            }
            

            return order;
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
            Order order = null;
            order = GetOrderByTable(table.tableId);
            return table;

        }
        private List<Table> ReadTables(DataTable dataTable)
        {
            OpenConnection();
            List<Table> tablesTemp = new List<Table>();
            List<Table> tables = new List<Table>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItemDAO orderItemDAO = new OrderItemDAO();
                Table table = new Table()
                {
                    tableId = (int)dr["table_id"],
                    capacity = (int)dr["capacity"],
                    isAvailable = (bool)dr["isAvailable"],
                    isReserved = (bool)dr["isReserved"]                
                };
                Order order = null;
                  order = GetOrderByTable(table.tableId);

                if (order != null)
                {
                    if (!order.isPaid)
                        table.order = order;

                    order.listOrderItems = orderItemDAO.GetOrderItemsById(order.orderID);
                }
                else
                    table.order = null;


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
