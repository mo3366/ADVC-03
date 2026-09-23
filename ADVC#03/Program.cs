namespace ADVC_03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Exercise 1: Student Grade Manager
            //List<int> list01 = new List<int>{85, 92, 78, 95, 88, 70, 100, 65};
            //Console.WriteLine("2- Print the collection, Count, first and last grade");
            //list01.ForEach(p => Console.WriteLine(p));
            //Console.WriteLine(list01.Count());
            //Console.WriteLine(list01.First());
            //Console.WriteLine(list01.Last());
            //Console.WriteLine("========3- Sort the grades ascending, then print======== ");
            //list01.Sort();
            //list01.ForEach(p => Console.WriteLine(p));
            //Console.WriteLine("=======4- Get the first grade above 90 =========");
            //Console.WriteLine(list01.Find(p => p > 90));

            //Console.WriteLine("=======5- Get all grades below 75 (failing grades) =========");
            //List<int> failing = new List<int>();
            //failing = list01.FindAll(p => p < 75);
            //failing.ForEach(p => Console.WriteLine(p));

            //Console.WriteLine("=======6- Remove all failing grades (below 75) =========");
            //list01.RemoveAll(p => p < 75);
            //list01.ForEach(p => Console.WriteLine(p));

            //Console.WriteLine("=======7- Check if any grade equals 100 =========");
            //Console.WriteLine(list01.Any(p => p == 100));
            //Console.WriteLine("=======8- Create a List<string> where each grade becomes -> Grade: X =========");
            //List<string> gradeLabels = list01.ConvertAll(p => $"Grade: {p}");

            #endregion

            #region Exercise 2: Leaderboard
            //SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>();
            ////1- Add: 500="Ahmed", 200="Sara", 800="Ali", 350="Mona"
            //leaderboard.Add(500,"Ahmed");
            //leaderboard.Add(200, "Sara");
            //leaderboard.Add(800, "Ali");
            //leaderboard.Add(350, "Mona");

            ////2- Print all entries (they should be sorted by score automatically)
            //Console.WriteLine("2- Leaderboard:");
            //foreach (var player in leaderboard) 
            //{ 
            //    Console.WriteLine($"{player.Key} = {player.Value}");
            //}

            ////3- Access the first key and first value 
            //Console.WriteLine(leaderboard.First().Key);
            //Console.WriteLine(leaderboard.First().Value);

            ////4- Check if score 500 exists
            //Console.WriteLine(leaderboard.ContainsKey(500));

            ////5- Safely get the player with score 999
            //if (leaderboard.TryGetValue(999, out string value))
            //{
            //    Console.WriteLine($"value = {value}");
            //}
            //else
            //{
            //    Console.WriteLine("player not found");
            //}

            ////6- Remove the player with score 200 and print the updated list
            //if (leaderboard.TryGetValue(200, out string val))
            //{
            //    leaderboard.Remove(200);
            //}
            //Console.WriteLine("the updated list after remove 200");
            //foreach (var player in leaderboard)
            //{
            //    Console.WriteLine($"{player.Key} = {player.Value}");
            //}
            #endregion

            #region Exercise 3: Phone Book

            //// 1- Create a Collection with 4 contacts
            //Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            //phoneBook.Add("Ahmed", "01011111111");
            //phoneBook.Add("Sara", "01022222222");
            //phoneBook.Add("Ali", "01033333333");
            //phoneBook.Add("Mona", "01044444444");


            //// 2- Add a new contact using [] syntax (add or update)
            //phoneBook["Omar"] = "01055555555";


            //// 3- Try adding a duplicate using .Add()
            //try
            //{
            //    phoneBook.Add("Ahmed", "01111111111");
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine($"Error: {ex.Message}");
            //}


            //// 4- Try adding a duplicate using .TryAdd()
            //bool added = phoneBook.TryAdd("Ahmed", "01111111111");

            //Console.WriteLine($"TryAdd succeeded: {added}");


            //// 5- Search for a contact that doesn't exist
            //if (phoneBook.ContainsKey("Youssef"))
            //{
            //    Console.WriteLine(phoneBook["Youssef"]);
            //}
            //else
            //{
            //    Console.WriteLine(" not found");
            //}


            //// 6- Get a contact with a fallback of "Not Found"
            //string phone = phoneBook.GetValueOrDefault("Youssef", "Not Found");

            //Console.WriteLine(phone);


            //// 7- Print all Keys on one line, then all Values on another line
            //Console.WriteLine("Keys:");

            //Console.WriteLine(string.Join(", ", phoneBook.Keys));

            //Console.WriteLine("Values:");

            //Console.WriteLine(string.Join(", ", phoneBook.Values));

            #endregion


        }
    }
}
