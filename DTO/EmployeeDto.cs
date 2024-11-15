namespace EmployeePortal.DTO
{
    public class EmployeeDto
    {
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public decimal Salary { get; set; }
    }
}
