namespace task_10_2;

public delegate string GetUserInfo();
public delegate List<User> SortUsers(List<User> users);

class Program
{
    static void Main()
    {
        List<User> users = new List<User>();
        
        users.Add(new User("Ivan", "Ivanovich", "Ivanov"));
        users.Add(new User("Piotr", "", "Petrov"));
        users.Add(new User("Dmitriy", "Dmitrievich", "Dmitrov"));
        
        foreach (var user in users)
        {
            GetUserInfo del = new GetUserInfo(user.GetUserName);
            del();
        }
        
        SortUsers sortDelegate = new SortUsers(User.SortByLastNames);
        
        List<User> sortedUsers = sortDelegate(users);

        foreach (var user in sortedUsers)
        {
            Console.WriteLine($"User info: {user.FirstName} {user.MiddleName} {user.LastName}");
        }
    }
}



