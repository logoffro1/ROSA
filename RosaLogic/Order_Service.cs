﻿using System;
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

                return orderDAO.Db_Get_AllOrder();

            }
            catch (Exception)
            {

                ErrorHandler error = new ErrorHandler("Couldn't read from the Database!");
                return null;

            }

        }
        public Order GetLatestOrder()
        {

            return orderDAO.GetLatestOrder();
        }
        public void AddOrder(int tableID)
        {
            orderDAO.CreateNewOrder(tableID);
            //try
            //{
                
            //    orderDAO.CreateNewOrder(tableID,employeeID);
                
            //}
            //catch (Exception)
            //{

            //    ErrorDAO error = new ErrorDAO("Couldn't write to the Database!");

            //}

        }
        public void CreateOrderItem(int orderID, int menuitemID)
        {
            orderDAO.CreateOrderItem(orderID, menuitemID);  
        }
        public void DeleteOrderItem(int orderitemID)
        {
            orderDAO.DeleteOrderItem(orderitemID);
        }
        public List<OrderItem> GetByID(int orderID)
        {
            return orderDAO.GetByID(orderID);
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
        public void IncreaseAmount(int orderitemID)
        {
            orderDAO.IncreaseAmount(orderitemID);
        }
        public void IncreaseAmount2(int menuitemID)
        {
            orderDAO.IncreaseAmount2(menuitemID);
        }
        public void DecreaseAmount(int orderitemID)
        {
            orderDAO.DecreaseAmount(orderitemID);
        }
        public void AdjustStock(int menuitemID,int amount,string oprtr)
        {
            orderDAO.AdjustStock(menuitemID, amount, oprtr);
        }
        public List<MenuItem> GetMenuItems(int catID)
        {
            return orderDAO.GetMenuItems(catID);
        }
        public int CheckStock(int menuitemID)
        {
            return orderDAO.CheckStockbyID(menuitemID);
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

                ErrorHandler error = new ErrorHandler("Couldn't read from the Database!");
                return null;

            }
        }


    }
}
