using System;
using System.ComponentModel.DataAnnotations;

namespace sportex.common.user
{
    public class User
    {
        #region PROPERTIES
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        string MailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PicturePath { get; set; }
        public UserStatus Status { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime LastUpdate { get; set; }
        public DateTime LastAccess { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IRole Role { get; set; }
                
        #endregion

        #region CONSTRUCTORS
        public User(string uname, string pass, DateTime created, DateTime updated, DateTime access, IRole role)
        {
            this.Username = uname;
            this.Password = pass;
            this.Status = UserStatus.Active;
            this.CreatedOn = created;
            this.LastUpdate = updated;
            this.LastAccess = access;
            this.Role = role;
        }
        public User()
        {
            this.Username = "undefined";
            this.Password = "";
            this.Status = UserStatus.Active;
            this.CreatedOn = DateTime.Now;
            this.LastUpdate = DateTime.Now;
            this.LastAccess = DateTime.Now;
            this.Role = new NormalRole();
        }
        public User(string uname, string pass)
        {
            this.Username = uname;
            this.Password = pass;
            this.Status = UserStatus.Active;
            this.CreatedOn = DateTime.Now;
            this.LastUpdate = DateTime.Now;
            this.LastAccess = DateTime.Now;
            this.Role = new NormalRole();
        }
        #endregion
    }
}
