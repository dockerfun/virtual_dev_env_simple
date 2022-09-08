using Microsoft.AspNetCore.Mvc;
using MyBackend.DAL;
using my_backend.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.EntityFrameworkCore;

namespace my_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private UserContext _db;  

    public UserController(UserContext context)  
    {  
        _db = context;  
    }  

    [HttpGet]  
    [EnableCors("_myAllowSpecificOrigins")]
    public IList<User> Get()  
    {  
        var list = this._db.Users.ToList();
        return list;  
    }

    [HttpPost]
    [EnableCors("_myAllowSpecificOrigins")]
    public void Create(User user)  
    {  
        try
        {
            this._db.Users.Add(user); 
            this._db.SaveChanges();
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    [HttpPut]
    [EnableCors("_myAllowSpecificOrigins")]
    public void Update(int id, User user)  
    {  
        var u = this._db.Users.FirstOrDefault(x=>x.ID == id);
        if(null != u)
        {
            u.FirstName = user.FirstName;
            u.LastName = user.LastName;
            u.DateOfBirth = user.DateOfBirth;
            this._db.SaveChanges();
        }
    }

    [HttpDelete]
    [EnableCors("_myAllowSpecificOrigins")]
    public void Delete(int id)  
    {  
        var u = this._db.Users.FirstOrDefault(x=>x.ID == id);
        if(null != u)
        {
            this._db.Users.Remove(u);
            this._db.SaveChanges();
        }
    }

}