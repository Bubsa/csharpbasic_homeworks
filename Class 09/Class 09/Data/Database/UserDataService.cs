using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Database
{
    public class UserDataService: InMemoryDatabase
    {
        public User GetUserByCardNumber(int cardNumber)
        {
            return Users.FirstOrDefault(user => user.CardNumber == cardNumber);
        }
        public List<int> GetAllCardNumbers()
        {
            return Users.Select(user => user.CardNumber).ToList();
        }
        public void InsertNewUser(User user)
        {
            Users.Add(user);
        }
    }
}
