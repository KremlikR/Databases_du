namespace package
{
	public class OrderItemDAO
	{
		private YourDbContext context;

		public OrderItemDAO()
		{
			context = new YourDbContext();
		}

		public void AddOrderItem(OrderItem orderItem)
		{
			context.OrderItems.Add(orderItem);
			context.SaveChanges();
		}

		public OrderItem GetOrderItemById(int orderItemId)
		{
			return context.OrderItems.Find(orderItemId);
		}

		public void UpdateOrderItem(OrderItem orderItem)
		{
			context.Entry(orderItem).State = EntityState.Modified;
			context.SaveChanges();
		}

		public void DeleteOrderItem(int orderItemId)
		{
			var orderItem = context.OrderItems.Find(orderItemId);
			if (orderItem != null)
			{
				context.OrderItems.Remove(orderItem);
				context.SaveChanges();
			}
		}
	}
}