using System;
namespace DisposingDemo
{

    public class Connection
    {
        public string ConnectionString { get; set; }
        public string Query { get; set; }
        public void ExecuteQuery() { }
        public void ExecuteStoredProcedure() { }
        public void PerformTransaction() { }
        public void AcquireResourcesForExecution() { }
        public void ReleaseAllResources() { }
        public void Close() { }
    }
    public class ConnectionManager:IDisposable
    {
        private Connection con = null;
        public ConnectionManager()
        {
            //code to initialize resources
            //     to allocate resources for future work
           con = new Connection();
           con.AcquireResourcesForExecution();
        }

        public  void OpenConnection() {
            con.ConnectionString = "MySQL, username, password";

        }
        public void ExecuteQuery()
        {
            con.Query = "SELECT * FROM Employees";
            con.ExecuteQuery();
        }

        public void PerformTransaction()
        {

        }
        public void CloseConnection() {
            con.Close();
        }

        public void Dispose()
        {
            int threaID = System.Threading.Thread.CurrentThread.ManagedThreadId;
            //code to DeInitialize resources
            //     to Release resources
            con.ReleaseAllResources();
        }

        ~ConnectionManager()
        {
            int threaID = System.Threading.Thread.CurrentThread.ManagedThreadId;
           
            //code to DeInitialize resources
            //     to Release resources
            con.ReleaseAllResources();
            con = null;
        }
    }


    class Test {
        public static void Main() {

           int primaryThreaID= System.Threading.Thread.CurrentThread.ManagedThreadId;

            using (ConnectionManager mgr = new ConnectionManager())
            {
                mgr.OpenConnection();
                mgr.ExecuteQuery();
                mgr.CloseConnection();
            }
               
         



        }

    }
}