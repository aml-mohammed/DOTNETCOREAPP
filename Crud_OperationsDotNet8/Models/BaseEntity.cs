using System.ComponentModel.DataAnnotations;

namespace Crud_OperationsDotNet8.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        [MaxLength(length: 200)]
        public string Name { get; set; } = string.Empty;
    }
}
