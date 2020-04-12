using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Lists_and_More_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new List<User>();

            users.Add(new User { Name = "Dave", Password = "hello" });
            users.Add(new User { Name = "Steve", Password = "steve" });
            users.Add(new User { Name = "Lisa", Password = "hello" });

            static bool isHello(User pass)
            {
                if (pass.Password == "hello")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            List<User> passResults = users.FindAll(isHello);
            if (passResults.Count != 0)
            {
                DisplayResults(passResults, "Password is hello:");
            }

            users.RemoveAll(user => user.Password == user.Name.ToLower());

            var match = users.FirstOrDefault(user => user.Password == "hello");
            if (match != null)
            {
                users.Remove(match);
            }

            DisplayResults(users, "Remaining users:");

            static void DisplayResults(List<User> results, string userResults)
            {
                Console.WriteLine();
                Console.WriteLine(userResults);
                foreach (User b in results)
                {

                    Console.Write("\n{0}\t{1}", b.Name,
                        b.Password);
                }
                Console.WriteLine();
            }
        }
    }
}
