using Microsoft.AspNetCore.Mvc;
using MyBackend.DAL;
using my_backend.Models;
using Microsoft.AspNetCore.Cors;
using MyBackend.Data;

namespace my_backend.Controllers;

[ApiController]
[Route("[controller]")]
public class User2Controller : ControllerBase
{
    private UserContext _userDbContext;  

    public User2Controller(UserContext userDbContext)  
    {  
        _userDbContext = userDbContext;  
    }  

    // [HttpGet]  
    // [EnableCors("MyPolicy")]
    // public IList<User> Get()  
    // {  
    //     var list = this._userDbContext.Users.ToList();
    //     return list;  
    // }

    // [HttpPost]
    // public void Create(User user)  
    // {  
    //     using(UnitOfWork uow = new UnitOfWork(_userDbContext))
    //     {
    //         uow.
    //     }
    //     this._userDbContext.Users.Add(user);
    // }

    // [HttpPut]
    // public void Update(User user)  
    // {  
    //     var u = this._userDbContext.Users.FirstOrDefault(x=>x.ID == user.ID);
    //     if(null != u)
    //     {
    //         this._userDbContext.Users.Update(user);
    //     }
    // }
}