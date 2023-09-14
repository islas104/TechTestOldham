public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, IEnumerable<User>>
{
    private readonly UserRepository _userRepository;

    public GetAllUsersQueryHandler(UserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public IEnumerable<User> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return _userRepository.GetAllUsers();
    }
}
