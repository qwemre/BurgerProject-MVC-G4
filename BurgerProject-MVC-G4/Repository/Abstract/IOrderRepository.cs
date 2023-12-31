﻿using BurgerProject_MVC_G4.Models.Entites;
using Uygulama2106.Repository.Abstract;

namespace BurgerProject_MVC_G4.Repository.Abstract
{
    public interface IOrderRepository : IRepository<Order>
    {
        public ICollection<Order> GetUserOrders(int id);
        public ICollection<Order> GetAllOrders();
    }
}
