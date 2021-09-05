using System;
using System.Collections.Generic;

namespace SheremetievoRent.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string DocumentId { get; set; }
        public string OGRN { get; set; }
        public IEnumerable<string> BaseDeals { get; set; }
        public string INN { get; set; }

        public string BankName { get; set; }
        public string PaymentAccount { get; set; }
        public string CorrespondentAccount { get; set; }
        public string BIC { get; set; }
        
        public int? PassportNumber { get; set; }
        public string Address { get; set; }
        public string Sex { get; set; }
        public DateTime? BirthDay { get; set; }
        public string BirthPlace { get; set; }
        public string IssuedBy { get; set; }
        public DateTime? IssuedOn { get; set; }
        public string DepartmentCode { get; set; }
        
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}