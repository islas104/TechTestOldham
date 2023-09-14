using System;
using System.Timers;
using Topshelf;

public class UserService : ServiceControl
{
    private Timer _timer;
    private readonly IAuditService _auditService;
    private readonly IUserService _userService;
    private readonly Random _random;

    public UserService(IAuditService auditService, IUserService userService)
    {
        _auditService = auditService;
        _userService = userService;
        _random = new Random();
    }

    public bool Start(HostControl hostControl)
    {
        _timer = new Timer(120000); // 2 minutes interval
        _timer.Elapsed += OnTimerElapsed;
        _timer.Start();
        return true;
    }

    public bool Stop(HostControl hostControl)
    {
        _timer?.Stop();
        _timer?.Dispose();
        return true;
    }

    private void OnTimerElapsed(object sender, ElapsedEventArgs e)
    {
        // Generate a pseudo-random user
        var firstName = GetRandomFirstName();
        var lastName = GetRandomLastName();
        var email = $"{firstName}.{lastName}@example.com";
        
        // Create the user in the database
        var user = new User
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email
        };
        _userService.CreateUser(user);
        
        // Log the user creation event to audits
        _auditService.LogCommandExecution($"User created: {firstName} {lastName}");
    }

    private string GetRandomFirstName()
    {
        // Implement logic to get a pseudo-random first name
        // You can use a list of predefined first names and select one randomly
        var firstNames = new[] { "John", "Jane", "Alice", "Bob", /* Add more names */ };
        return firstNames[_random.Next(0, firstNames.Length)];
    }

    private string GetRandomLastName()
    {
        // Implement logic to get a pseudo-random last name
        // You can use a list of predefined last names and select one randomly
        var lastNames = new[] { "Doe", "Smith", "Johnson", "Brown", /* Add more names */ };
        return lastNames[_random.Next(0, lastNames.Length)];
    }
}
