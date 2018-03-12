using System.ComponentModel.DataAnnotations;

namespace sportex.common.user
{
    public class NormalRole : IRole
    {
        #region PROPERTIES
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        #endregion

        #region CONSTRUCTOR
        public NormalRole()
        {
            this.Name = "Normal";
            this.Description = "This is a normal role.";
        }
        #endregion
    }
}
