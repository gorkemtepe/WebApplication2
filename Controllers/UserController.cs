using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Entity;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        private readonly DatabaseContext _databaseContext;
        private readonly IMapper _mapper;

        public UserController(DatabaseContext databaseContext, IMapper mapper)
        {
            _databaseContext = databaseContext;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            //List<UserModel> users = _databaseContext.Users.ToList().Select(x => _mapper.Map<UserModel>(x)).ToList();


            List<User> users = _databaseContext.Users.ToList();
            List<UserModel> model = users.Select(x=>_mapper.Map<UserModel>(x)).ToList();

            

            //foreach (User user in users)
            //{
            //    model.Add(new UserModel
            //    {
            //        FullName = user.FullName,                 İLK YÖNTEM
            //        Id = user.Id,
            //    });
            //}

            //_databaseContext.Users.Select(x => new UserModel { Id = x.Id, FullName = x.FullName }).ToList(); İKİNCİ YÖNTEM

            return View(model);
        }
    }
}
