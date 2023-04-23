using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPatterns.FactoryMethod
{
    public abstract class OrderItem
    {
        public abstract void Prepare();
    }

    public abstract class OrderItemCreator
    {
        public abstract OrderItem CreateOrderItem();
    }

    public class Hamburger : OrderItem
    {
        public override void Prepare()
        {
            Console.WriteLine("Hamburger hazırlanıyor...");
        }
    }

    public class HamburgerCreator : OrderItemCreator
    {
        public override OrderItem CreateOrderItem()
        {
            return new Hamburger();
        }
    }

    public class Pizza : OrderItem
    {
        public override void Prepare()
        {
            Console.WriteLine("Pizza hazırlanıyor...");
        }
    }

    public class PizzaCreator : OrderItemCreator
    {
        public override OrderItem CreateOrderItem()
        {
            return new Pizza();
        }
    }

    public class Order
    {
        private List<OrderItem> _orderItems = new List<OrderItem>();
        public void AddOrderItem(OrderItemCreator creator)
        {
            OrderItem orderItem = creator.CreateOrderItem();
            _orderItems.Add(orderItem);
        }

        public void PrepareOrder()
        {
            foreach (var orderItem in _orderItems)
            {
                orderItem.Prepare();
            }
        }
    }
}
