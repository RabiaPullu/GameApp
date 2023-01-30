using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Entities
{
    public class Admin : IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string AdminNickName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
    }
}
