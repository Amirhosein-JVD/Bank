public class EmptyUsersRepoException : Exception 
{
    public EmptyUsersRepoException() : base("Users repository is empty right now!") { }   
}