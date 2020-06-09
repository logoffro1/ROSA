using System;
using System.Collections.Generic;
using RosaDAL;
using RosaModel;
namespace RosaLogic
{ 
    /// <summary>
  ///   Table Service class
  ///   Made by Cosmin Ilie
  ///   Student number: 645976
  /// </summary>
    public class Table_Service
    {
        TableDAO tableDAO = new TableDAO();
        OrderItemDAO orderItemDAO = new OrderItemDAO();

        public List<Table> GetAllTables()
        {
            List<Table> tables = null;
            try
            {
                tables= tableDAO.Db_Get_AllTables();
                foreach(Table t in tables)
                {
                    if(t.order!= null)
                    t.order.ListOrderItems = orderItemDAO.GetOrderItemsById(t.order.OrderID);
                }
            }
            catch
            {
                new ErrorHandler("Couldn't read the Tables from the Database!");
            }
            return tables;
        }
        public void UpdateTable(Table table, bool isAvailable, bool isReserved)
        {
            try
            {
                tableDAO.UpdateTable(table, isAvailable, isReserved);
            }
            catch
            {
               new ErrorHandler("Couldn't update Table to the database");
            }         
        }
    }
}
