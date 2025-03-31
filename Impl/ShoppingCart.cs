// ShoppingCart.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace Impl
{
    public class ShoppingCart
    {
        // Кошик зберігає товари як словник {назва товару: ціна}
        private Dictionary<string, decimal> items;

        public ShoppingCart()
        {
            items = new Dictionary<string, decimal>();
        }

        /// <summary>
        /// Додає товар із вказаною ціною до кошика.
        /// </summary>
        /// <param name="item">Назва товару</param>
        /// <param name="price">Ціна товару</param>
        public void AddItem(string item, decimal price)
        {
            if (price < 0)  // Помилка: має бути `price <= 0`
            {
                throw new ArgumentException("Price must be positive");
            }
            items[item] = price;  // Проблема: не перевіряється, чи вже є товар у кошику
        }

        /// <summary>
        /// Видаляє товар із кошика.
        /// </summary>
        /// <param name="item">Назва товару для видалення</param>
        public void RemoveItem(string item)
        {
            // Помилка: не перевіряється, чи товар є у кошику
            items.Remove(item);
        }

        /// <summary>
        /// Повертає загальну вартість товарів у кошику.
        /// </summary>
        /// <returns>Загальна вартість</returns>
        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var price in items.Values)
            {
                total += price;
            }
            return total;
        }

        /// <summary>
        /// Застосовує знижку до всіх товарів у кошику.
        /// </summary>
        /// <param name="discount">Відсоток знижки (0-100)</param>
        public void ApplyDiscount(decimal discount)
        {
            if (discount < 0 || discount > 100)  // Помилка: немає перевірки на тип
            {
                throw new ArgumentException("Discount must be between 0 and 100");
            }
            // Помилка: знижка обчислюється неправильно
            foreach (var item in items.Keys.ToList())
            {
                items[item] -= discount;
            }
        }
    }
}