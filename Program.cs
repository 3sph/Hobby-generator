namespace hobby_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome friend, are you boring and basic? then the Hobbygenerator is just the thing for you!");
            Console.Write("if name not friend then please state: ");
            string userName = Console.ReadLine();

            string randomHobby = GenerateRandomHobby();
            Console.WriteLine($"Worrie no more, {userName}! Your new hobby is: {randomHobby}");
        }
        static string GenerateRandomHobby()
        {
            //liost of hobbies 
            string[] hobbies =
            {
                "Falconeering",
                "Taxidermy",
                "bullfighting",
                "Discgolf",
                "colecting stamps",
                "figure skating",
                "bowling",
                "Lasertag",
                "Archery",
                "hunting",
                "fishing",
                "World conquest",
                "Necromancy",
                "Chess",
                "Fotball",
                "Cricket",
                "Yu Gi Oh cards",
            };
            
            // random class to pick one at random.
            Random random = new Random();
            int randomIndex = random.Next( hobbies.Length );  
            
            //return hobby 

            return hobbies[randomIndex];
        }
    }
} 