namespace task_11_2;

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
        return !string.IsNullOrEmpty(MiddleName)
            ? $"{FirstName} {MiddleName} {LastName}"
            : $"{FirstName} {LastName}";
    }
    
    public static List<User> SortByLastNames(List<User> users)
    {
        return users.OrderByDescending(user => user.LastName).ToList();
    }
}
