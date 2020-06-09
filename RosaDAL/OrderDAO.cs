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
    public class OrderDAO : Base
    {
        public List<Order> Db_Get_AllOrders()
        {
            //read orders from database
            string query = "select order_id,table_id,isPaid,notes from [order]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public List<Order> ReadTables(DataTable dataTable)
        {

            List<Order> Orders = new List<Order>();
            foreach (DataRow dr in dataTable.Rows)
            {
                Order order = new Order()
                {
                    OrderID = (int)dr["order_id"]
                    //isPaid = (Boolean)dr["isPaid"],
                    //notes = (string)dr["notes"],
                };

                order.Table.tableId = (int)dr["table_id"];

                Orders.Add(order);
            }
            return Orders;
        }

        public void CreateNewOrder(int tableID)
        {
            // DateTime datetime = DateTime.Now;
            // string comment = "note";

            //string query = $"INSERT INTO [order](orderDate, table_id, employee_id, notes) VALUES ({datetime},{tableID},{employeeID},{comment}";
            string query = $"INSERT INTO [order](table_id) VALUES ({tableID})";


            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);

        }
        public void RemoveOrder(int OrderID)
        {
            string query = $"DELETE FROM [order]  WHERE order_id = ({OrderID})";


            SqlParameter[] sqlParameters = new SqlParameter[0];

            ExecuteEditQuery(query, sqlParameters);

        }
        public void CreateOrderItem(int orderID, int menuitemID)
        {
            string query = $"Insert into [orderItems](order_id,menuItem_id,amount,status) VALUES ({orderID},{menuitemID},1,1)";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DeleteOrderItem(int orderitemID)
        {
            string query = $"Delete from [orderItems] where orderItems_id = ({orderitemID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        //Gets full orderItem through the orderID
        //By Dewi
        public Order GetOrderByID(int orderID)
        {
            SqlCommand cmd = new SqlCommand(
                "select table_id, orderDate " +
                "from [order]" +
                "where order_id = @Id; ", conn);

            cmd.Parameters.AddWithValue("@order_id", orderID);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                return ReadRecord(reader);
            }

            throw new Exception("Could not read order!");
        }

        private Order ReadRecord(SqlDataReader reader)
        {
            Order order = new Order
            {
                DateTime = (DateTime)reader["orderDate"]
            };

            order.Table.tableId = (int)reader["table_id"];

            return order;
        }
        public List<OrderItem> GetByID(int orderID)
        {
            string query = $"select * from [orderItems] join [menuItem] on orderItems.menuItem_id=menuItem.menuItem_id where order_id = ({orderID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return Read(ExecuteSelectQuery(query, sqlParameters));
            
        }
        public List<OrderItem> Read(DataTable dataTable)
        {
            List<OrderItem> OrderItems = new List<OrderItem>();
            foreach (DataRow dr in dataTable.Rows)
            {
                OrderItem orderItem = new OrderItem()
                {
                    orderID = (int)dr["order_id"],
                    orderItems_id = (int)dr["orderItems_id"],
                    menuItemID = (int)dr["menuItem_id"],
                    status = (StatusEnum)dr["status"],
                    amount = (int)dr["amount"],
                    menuItemName = (string)dr["itemName"]
                };
                OrderItems.Add(orderItem);
            }
            return OrderItems;
        }
        public void IncreaseAmount(int orderitemID)
        {
            string query = $"update [orderItems] set amount = amount+1 where orderItems_id=({orderitemID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void IncreaseAmount2(int menuitemID)
        {
            string query = $"update [orderItems] set amount = amount+1 where menuItem_id=({menuitemID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DecreaseAmount(int orderitemID)
        {
            string query = $"update [orderItems] set amount = amount-1 where orderItems_id=({orderitemID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public void DecreaseStock(int menuitemID, int amount)
        {
            string query = $"update[menuItem] set stock = stock-{amount} where menuItem_id = ({menuitemID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters); 
        }
        public void CheckStock(int menuitemID)
        {
            string query = $"select [stock] from menuItem where ({menuitemID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);
        }
        public List<MenuItem> GetMenuItems(int catID)
        {
            string query = $"Select * from [menuItem] where menuCategory_id=({catID})";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadMenuItems(ExecuteSelectQuery(query, sqlParameters));
        }
        public List<MenuItem> ReadMenuItems(DataTable dataTable)
        {
            List<MenuItem> menuItems = new List<MenuItem>();

            foreach (DataRow dr in dataTable.Rows)
            {
                MenuItem menuItem = new MenuItem()
                {
                    Name = (string)dr["itemName"],
                    Price = (decimal)dr["price"],
                    ID = (int)dr["menuItem_id"]
                };
                menuItems.Add(menuItem);

            }
            return menuItems;
        }
    }
}
