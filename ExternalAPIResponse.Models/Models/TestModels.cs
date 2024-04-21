using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExternalAPIResponse.Models.Models
{
    internal class TestModels
    {
    }

    public class EmployeeDetailsModel
    {
        public List<EmployeeModel> EmployeeDetails { get; set; }

        public List<EmployeeAddress> EmployeeAddress { get; set; }
    }

    public class EmployeeAddress()
    {
        public String EmployeeId { get; set; }

        public Int32 AddressType {  get; set; }

        public String AddressLine {  get; set; }

        public String City { get; set; }

        public String Region { get; set; }

        public String PostalCode { get; set; }

        public String Country { get; set; }
        public String Phone { get; set; }
    }

    public class EmployeeModel()
    {
        public String EmployeeId { get; set; }

        public String EmployeeName { get; set; }

        public String EmployeePhone { get; set; }

        public Int32 EmployeeStatus { get; set; }

        public Int32 EmployeeAge { get; set; }
    }
}
