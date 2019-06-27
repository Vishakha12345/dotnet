using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace NativeHostRESTWCFApp
{

    [ServiceContract()]
    public interface IEmployeeService
    {
        [WebGet(UriTemplate = "Employee")]
        [OperationContract]
        List<Employee> GetAllEmployeeDetails();

        [WebGet(UriTemplate = "Employee?id={id}")]
        [OperationContract]
        Employee GetEmployee(int Id);

        [WebInvoke(Method = "POST", UriTemplate = "EmployeePOST")]
        [OperationContract]
        void AddEmployee(Employee newEmp);

        [WebInvoke(Method = "PUT", UriTemplate = "EmployeePUT")]
        [OperationContract]
        void UpdateEmployee(Employee newEmp);

        [WebInvoke(Method = "DELETE", UriTemplate = "Employee/{empId}")]
        [OperationContract]
        void DeleteEmployee(string empId);
    }

    [DataContract]
    public class Employee
    {
        [DataMember]
        public int EmpId { get; set; }
        [DataMember]
        public string Fname { get; set; }
        [DataMember]
        public string Lname { get; set; }
        [DataMember]
        public DateTime JoinDate { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Salary { get; set; }
        [DataMember]
        public string Designation { get; set; }
    }
}
