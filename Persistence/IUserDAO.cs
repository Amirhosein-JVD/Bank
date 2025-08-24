interface IUserDAO{

    void GetAllUsers();
    void GetUser(int id);
    void AddUser(User user);
    void UpdateUser(int id, string? firstName = null, string? lastName = null, string? email = null,
        string? address = null, int? age = null, string? password = null);
    void DeleteUser(int id);

    
}