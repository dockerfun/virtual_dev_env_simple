using System;
using Microsoft.EntityFrameworkCore;
using my_backend.Models;

namespace my_backend.Data.Repository;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(DbContext context) : base(context)
    {
        
    }

    public User NewUser(string fn, string ln, DateTime bd)
    {
        var user = new User { FirstName = fn, LastName = ln, DateOfBirth = bd };
        this.Create(user);
        return user;
    }
}
