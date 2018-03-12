using System.ComponentModel.DataAnnotations;

namespace sportex.common.user
{
    public class AdminRole : IRole
    {
        #region PROPERTIES
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region CONSTRUCTOR
        public AdminRole()
        {
            this.Name = "Admin";
            this.Description = "This is an advanced role. Full permits";
        }
        #endregion
    }
}
