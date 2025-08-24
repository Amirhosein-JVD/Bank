public class EmptyAccountsRepoException : Exception
{
    public EmptyAccountsRepoException() : base("Accounts Repo is Empty right now!") { }
}