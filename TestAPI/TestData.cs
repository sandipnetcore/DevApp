using System.Data;
using System.Text.Json.Serialization;

namespace TestAPI
{
    public class TestEmployeeData
    {
        public string EmployeeId { get; set; }
        public string EmployeeName { get; set; }

        public string EmployeePhone { get; set; }

        public string EmployeeStatus { get; set; }

        public string EmployeeAge { get; set; }
        public static List<TestEmployeeData> AllEmployees()
        {
            var list = new List<TestEmployeeData>();
            var e = new TestEmployeeData();
            e.EmployeeId = "1";
            e.EmployeeName = "Dilip Kumar";
            e.EmployeePhone = "+91-98 98 98 98 98";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "2";
            e.EmployeeName = "Prakash Kumar";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "3";
            e.EmployeeName = "Vikas Kumar";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "4";
            e.EmployeeName = "Sanjeev Kumar";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "5";
            e.EmployeeName = "Ashok Kumar";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "6";
            e.EmployeeName = "Kishore Kumar";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "7";
            e.EmployeeName = "Prakash Menon";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "8";
            e.EmployeeName = "Prakash Jha";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "9";
            e.EmployeeName = "Prakash Menon";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            e = new TestEmployeeData();
            e.EmployeeId = "10";
            e.EmployeeName = "JJ Menon";
            e.EmployeePhone = "+91-98 98 98 98 97";
            e.EmployeeStatus = "1";
            e.EmployeeAge = "30";
            list.Add(e);

            return list;
        }

       
    }

    public class TestAddress
    {
        public string EmployeeId { get; set; }
        public string AddressType { get; set; }
        public string AddressLine { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }


        public static List<TestAddress> GetAllAddresses()
        {
            var list = new List<TestAddress>();

            var e = new TestAddress();
            e.EmployeeId = "1";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "1";
            e.AddressType = "2";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "2";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "3";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "3";
            e.AddressType = "2";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "3";
            e.AddressType = "3";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "4";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "5";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "6";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "7";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "8";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "9";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            e = new TestAddress();
            e.EmployeeId = "10";
            e.AddressType = "1";
            e.AddressLine =  "Address Line 1";
            e.City =   "Bangalore";
            e.Region =   "South";
            e.PostalCode =   "560064";
            e.Country =   "India";
            e.Phone =   "+91-98 98 98 98 98";
            list.Add(e);

            return list;
        }

    }

    public class EmployeeData
    {
        public List<TestEmployeeData> EmployeeDetails { get; set; }

        public List<TestAddress> EmployeeAddress { get; set; }

        public static EmployeeData GetEmployeeById(int employeeId)
        {
            List<EmployeeData> employeeDatas = new List<EmployeeData>();

            var allEmployeeData = TestEmployeeData.AllEmployees();
            var allEmployeeAdress = TestAddress.GetAllAddresses();

            var employeeData = allEmployeeData.Where(d=> d.EmployeeId.Equals(employeeId.ToString())).ToList();
            var employeeAddress = allEmployeeAdress.Where(a => a.EmployeeId.Equals(employeeId.ToString())).ToList();

            EmployeeData data = new EmployeeData()
            {
                EmployeeDetails = employeeData,
                EmployeeAddress = employeeAddress,
            };
            

            return data;
        }
    }
}
