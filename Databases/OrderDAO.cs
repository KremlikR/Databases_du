namespace package{ 
public class OrderDAO
{
	private YourDbContext context;

	public OrderDAO()
	{
		context = new YourDbContext();
	}

	public void AddOrder(Order order)
	{
		context.Orders.Add(order);
		context.SaveChanges();
	}

	public Order GetOrderById(int orderId)
	{
		return context.Orders.Find(orderId);
	}

	public void UpdateOrder(Order order)
	{
		context.Entry(order).State = EntityState.Modified;
		context.SaveChanges();
	}

	public void DeleteOrder(int orderId)
	{
		var order = context.Orders.Find(orderId);
		if (order != null)
		{
			context.Orders.Remove(order);
			context.SaveChanges();
		}
	}
}
}