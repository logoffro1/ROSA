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
                if (!isAvailable)
                {
                    if (order == null)
                        status = TableStatus.Waiting;
                    else
                        if (!order.isPaid)
                        status = TableStatus.Ordered;
                }
                return status;
            }
        }
    }
}
