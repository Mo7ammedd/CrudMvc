using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
       builder.Property(E => E.Salary).HasColumnType("decimal(18,2)"); 
       
       
        }
        
    }
}
