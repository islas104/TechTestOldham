public class UserRepository
{
    private readonly IDbConnection _dbConnection;

    public UserRepository(IDbConnection dbConnection)
    {
        _dbConnection = dbConnection;
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _dbConnection.Query<User>("SELECT * FROM Users");
    }
}
