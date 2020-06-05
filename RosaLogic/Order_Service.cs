using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RosaDAL;
using RosaModel;

namespace RosaLogic
{
    public class Order_Service
    {
        OrderDAO orderDAO = new OrderDAO();
        public List<Order> GetOrders()
        {

            try
            {

                return orderDAO.Db_Get_AllOrders();

            }
            catch (Exception)
            {

                ErrorDAO error = new ErrorDAO("Couldn't read from the Database!");
                return null;

            }

        }
        public void AddOrder(int tableID,int employeeID)
        {
            orderDAO.CreateNewOrder(tableID, employeeID);
            //try
            //{
                
            //    orderDAO.CreateNewOrder(tableID,employeeID);
                
            //}
            //catch (Exception)
            //{

            //    ErrorDAO error = new ErrorDAO("Couldn't write to the Database!");

            //}

        }
        public void RemoveOrder(int orderID)
        { 
            orderDAO.RemoveOrder(orderID);
            //try
            //{

            //    orderDAO.RemoveOrder(orderID);

            //}
            //catch (Exception)
            //{

            //    ErrorDAO error = new ErrorDAO("Couldn't write to the Database!");

            //}

        }

        //Dewi
        public Order GetOrderById(int orderID)
        {
            try
            {
                PaymentDAO paymentDAO = new PaymentDAO();

                Order order = paymentDAO.GetOrderById(orderID);
                order.Table = paymentDAO.GetTableByOrderID(order.Table.tableId);

                return order;

            }
            catch (Exception)
            {

                ErrorDAO error = new ErrorDAO("Couldn't read from the Database!");
                return null;

            }
        }


    }
}
