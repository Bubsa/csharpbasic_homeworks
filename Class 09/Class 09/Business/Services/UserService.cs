using Data.Database;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService
    {
        private UserDataService _userDataService;
        public UserService()
        {
            _userDataService = new UserDataService();
        }
        public User Login()
        {
            while (true)
            {
                Console.Write("Enter card number");
                string input = Console.ReadLine();
                bool isValid = int.TryParse(input, out int cardNumber);
                if (!isValid)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                // Tuka ke go zememe korisnikot
                User user = _userDataService.GetUserByCardNumber(cardNumber);
                if (user != null)
                {
                    // Obnovi subscription
                    RenewSubscription(user);
                    Console.WriteLine($"Welcome {user.FullName}");
                    return user;
                }

                List<string> confirm = new List<string>() { "Y", "y", "Yes", "1", "True" };
                List<string> decline = new List<string>() { "N", "n", "No", "0", "False" };
                Console.WriteLine("User card id doesn't exist");
                Console.WriteLine("Do you want to try again?");
                string confirmationInput = Console.ReadLine();
                if (confirm.Contains(confirmationInput))
                {
                    continue;
                } else if (decline.Contains(confirmationInput))
                {
                    return null;
                } else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
        public User SignUp()
        {
            while (true)
            {
                Console.WriteLine("Enter full name:");
                string name = Console.ReadLine();
                Console.WriteLine("Enter your date of birth (day-month-year 12-3-1999)");
                string dob = Console.ReadLine();
                bool isValidDate = DateTime.TryParse(dob, out DateTime dateOfBirth);
                if(!isValidDate)
                {
                    Console.WriteLine("Please enter a valid input");
                    continue;
                }

                int cardNumber = GenerateCardNumber();
                User user = new User()
                {
                    CardNumber = cardNumber,
                    FullName = name,
                    DateOfBirth = dateOfBirth,
                };
                Console.WriteLine(string.Format("Welcome {0}", user.FullName));
                _userDataService.InsertNewUser(user);

                return user;
            }
        }
        private int GenerateCardNumber()
        {
            Random rand = new Random();
            // tuka ke gi izvadime site brojki sho gi imame vo databaza
            List<int> existingCardNumbers = _userDataService.GetAllCardNumbers();
            
            int cardNumber = default;
            do
            {
                cardNumber = rand.Next(100, 999);
            } while (existingCardNumbers.Contains(cardNumber));
            return cardNumber;
        }
        private void RenewSubscription(User user)
        {
            if (user.SubscriptionExpiredTime < DateTime.Now)
            {
                user.IsSubscriptionExpired = true;
            }
            if (user.IsSubscriptionExpired)
            {
                Console.WriteLine("Your subscription is expired. Would you like to renew y/n?");
                string input = Console.ReadLine();
                if (input == "y")
                {
                    user.IsSubscriptionExpired = false;
                    user.SubscriptionExpiredTime = DateTime.Now.AddDays(7);
                    Console.WriteLine($"Your subscription is extended until {user.SubscriptionExpiredTime.ToShortDateString()}");
                }
                else
                {
                    Console.WriteLine("Thank you for using Video rental");
                    Environment.Exit(0);
                }
            }
        }
    }

}