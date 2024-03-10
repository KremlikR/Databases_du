namespace package
{
    public class CustomerDAO
    {
        private YourDbContext context;

        public CustomerDAO()
        {
            context = new YourDbContext();
        }

        public void AddCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public Customer GetCustomerById(int customerId)
        {
            return context.Customers.Find(customerId);
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Entry(customer).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = context.Customers.Find(customerId);
            if (customer != null)
            {
                context.Customers.Remove(customer);
                context.SaveChanges();
            }
        }
		public void ExportToXml(string filePath)
		{
			var customers = context.Customers.ToList();
			var serializer = new XmlSerializer(typeof(List<Customer>));
			using (var writer = new System.IO.StreamWriter(filePath))
			{
				serializer.Serialize(writer, customers);
			}
		}

		public List<Customer> ImportFromXml(string filePath)
		{
			var serializer = new XmlSerializer(typeof(List<Customer>));
			using (var reader = new System.IO.StreamReader(filePath))
			{
				return (List<Customer>)serializer.Deserialize(reader);
			}
		}
	}

}
}