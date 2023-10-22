using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_EF
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IStore _database;
        public OrderRepository(IStore database)
        {
            _database = database;
        }
        //public void Add(Order order)
        //{
        //    _database.Add(order);
        //}
    }
    public interface IOrderRepository
    {
        //void Add(Order order);
    }
}
