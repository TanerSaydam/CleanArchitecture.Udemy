using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities;

public sealed class User : IdentityUser<string>
{
    public User()
    {
        Id = Guid.NewGuid().ToString();
    }

    public string NameLastName { get; set; }
}
