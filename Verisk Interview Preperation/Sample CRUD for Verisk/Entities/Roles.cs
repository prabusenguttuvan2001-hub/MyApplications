using System.ComponentModel.DataAnnotations;

namespace Sample_CRUD_for_Verisk.Entities
{
    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
