public class UserRepository : IUserDAO
{

    private List<User> _users;

    public UserRepository()
    {
        _users = ListDataProvider<User>.Instnace().universalDataList;
    }

    public void AddUser(User user)
    {
        if (_users.Any(item => item.id == user.id)) 
        {
            throw new UserAlreadyExistException(user.firstName, user.lastName);
        }
        _users.Add(user);
        user.toString();
        UserRepoMessages.AddLog();
    }

    public void DeleteUser(int id)
    {
        User user = _users.FirstOrDefault(user => user.id == id);
        if (user == null)
        {
            throw new UserNotFoundException(id);
        }
        user.toString();
        _users.Remove(user);
        UserRepoMessages.DeleteLog();
    }

    public void GetAllUsers()
    {
        if (_users.Count() == 0)
        {
            throw new EmptyUsersRepoException();
        }
        _users.ForEach(account => account.toString());
        UserRepoMessages.GetAllLog();
    }

    public void GetUser(int id)
    {
        User user = _users.FirstOrDefault(user => user.id == id);
        if (user == null)
        {
            throw new UserNotFoundException(id);
        }
        user.toString();
        UserRepoMessages.GetLog();
    }

    public void UpdateUser(int id, string? firstName = null, string? lastName = null, string? email = null, string? address = null, int? age = null, string? password = null)
    {
        User user = _users.FirstOrDefault(user => user.id == id);
        if (user == null)
        {
            throw new UserNotFoundException(id);
        }
        User newUser = new User
        {
            firstName = firstName ?? user.firstName,
            lastName = lastName ?? user.lastName,
            Password = password ?? user.Password,
            Email = email ?? user.Email

        };

        _users.Remove(user);
        _users.Add(newUser);

        newUser.toString();
        AccountsRepoMessages.UpdateLog();
    }
}