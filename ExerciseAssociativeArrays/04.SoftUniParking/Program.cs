
 internal class Program
 {
    class User
    {
        public User(string username, string licensePlate)
        {
            UserName = username;
            LicensePlateNumber = licensePlate;
        }

        public object UserName { get; set; }
        public object LicensePlateNumber { get; set; }
        public override string ToString()
        {
            return $"{UserName} => {LicensePlateNumber}";
        }

    }
    static void Main()
     {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, User> users = new Dictionary<string, User>();

        for(int i = 0; i < n; i++)
        {
            string[] args = Console.ReadLine().Split();

            string command = args[0];
            string username = args[1];

            switch(command)
            {
                case "register":
                    string licensePlate = args[2];
                    if (!users.ContainsKey(username))
                    {
                        User newUser = new User(username,licensePlate);
                       
                        users.Add(username, newUser);
                        Console.WriteLine($"{newUser.UserName} registered {newUser.LicensePlateNumber} successfully");
                    }
                    else
                    {
                        User foundUser = users[username];
                        Console.WriteLine($"ERROR: already registered with plate number {foundUser.LicensePlateNumber}");
                    }
                    break;
                case "unregister":
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");

                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    break;
            }
        }
        foreach (KeyValuePair<string, User> pair in users)
        {
            Console.WriteLine(pair.Value);
        }
    }
 }

