using GameApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Entities
{
    public class Gamer: IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string GamerNickName { get; set; }
        public string GamerEmail { get; set; }
        public string GamerPassword { get; set; }
    }
}
