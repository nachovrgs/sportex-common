using System.ComponentModel.DataAnnotations;

namespace sportex.common.user
{
    public interface IRole
    {
        [Key]
        int ID { get; set; }
        string Name { get; set; }
        string Description { get; set; }
    }
}
