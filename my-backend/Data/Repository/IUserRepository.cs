using my_backend.Data.Repository.Base;
using my_backend.Models;

namespace my_backend.Data.Repository;

public interface IUserRepository:IRepository<User>
{
    User NewUser(string fn, string ln, DateTime bd);
}