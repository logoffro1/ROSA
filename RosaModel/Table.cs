namespace RosaModel
{
    /// <summary>
    ///   Table Model class
    ///   Made by Cosmin Ilie
    ///   Student number: 645976
    /// </summary>
    public class Table
    {
        public int tableId { get; set; }
        public int capacity { get; set; }
        public bool isAvailable { get; set; }
        public bool isReserved { get; set; }
        public Order order { get; set; }
        public TableStatus status
        {
            get
            {
                TableStatus status = TableStatus.Empty;
                if (!isAvailable) // if the table is OCCUPIED
                {
                    if (order == null) // if the table is occupied and there is no order, the status is waiting
                        status = TableStatus.Waiting;
                    else
                        if (!order.IsPaid) //if the order is NOT null and the order wasn't paid yet, the status is ordered
                        status = TableStatus.Ordered;
                }
                return status;
            }
        }
    }
}
