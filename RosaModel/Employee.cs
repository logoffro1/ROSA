namespace RosaModel
{
    /// <summary>
    ///   Employee Model class
    ///   Made by Cosmin Ilie
    ///   Student number: 645976
    /// </summary>
    public class Employee
    {
        public int employeeId { get; set; }
        public Roles role { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string username { get; set; } //used for login
        public string password { get; set; } //used for login

        public string[] personalNotes { get; set; }         
    }
}
