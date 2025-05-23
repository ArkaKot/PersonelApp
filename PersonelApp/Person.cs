using System;

namespace PersonelApp
{
    public class Person
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate {  get; set; }

        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public string Comments { get; set; }

        public decimal Salary { get; set; }

        public int ContractId { get; set; }

        public string ContractName { get; set; }

        public int EmploymentStatusId { get; set; }

        public string EmploymentStatusName { get; set; }

        public bool Student { get; set; }
    }
}