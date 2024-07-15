namespace task_10_2;

public class User 
{ 
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }

    public User(string firstName, string middleName, string lastName) 
    {
        FirstName = firstName;
        MiddleName = middleName;
        LastName = lastName;
    }

    public string GetUserName()
    {

        if(string.IsNullOrEmpty(MiddleName))
        {
            Console.WriteLine($"User info: {FirstName} {LastName}");
        }
        else
        {
            Console.WriteLine($"User info: {FirstName} {MiddleName} {LastName}");
        }

        return LastName;
    }
    
    public static List<User> SortByLastNames(List<User> users)
    {
        users.Sort((user1, user2) =>
        {
            
            string lastName1 = user1.LastName.Split(' ').Last();
            string lastName2 = user2.LastName.Split(' ').Last();
            return lastName2.CompareTo(lastName1); 
            
        });
        return users;
    }
}
