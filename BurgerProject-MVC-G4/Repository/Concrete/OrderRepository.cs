using BurgerProject_MVC_G4.Data;
using BurgerProject_MVC_G4.Models.Entites;
using BurgerProject_MVC_G4.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using Uygulama2106.Repository.Concrete;

namespace BurgerProject_MVC_G4.Repository.Concrete
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        private readonly ApplicationDbContext dbContext;
        public OrderRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public ICollection<Order> GetUserOrders(int id)
        {
            return dbContext.Orders.Include(s => s.Address).Include(s => s.Carts).ThenInclude(s => s.Menu).Include(s => s.Carts).ThenInclude(s => s.UserMenu).ThenInclude(s => s.Products).ThenInclude(s=>s.Product).Include(s => s.Carts).ThenInclude(s => s.Products).Where(s => s.Carts.Any(p => p.AppUserID == id && p.Active == false)).ToList();
        }

        public ICollection<Order> GetAllOrders()
        {
            return dbContext.Orders.Include(s => s.Address).Include(s => s.Carts).ThenInclude(s => s.AppUser).Include(s => s.Carts).ThenInclude(s => s.Menu).Include(s => s.Carts).ThenInclude(s => s.UserMenu).ThenInclude(s => s.Products).ThenInclude(s => s.Product).Include(s => s.Carts).ThenInclude(s => s.Products).Where(s => s.Carts.Any(p=>p.Active == false)).ToList();
        }

    }
}
