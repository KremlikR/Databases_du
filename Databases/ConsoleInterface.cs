namespace package
{
	public class ConsoleInterface
	{
		private CustomerDAO customerDAO;
		private ProductDAO productDAO;
		private OrderDAO orderDAO;
		private OrderItemDAO orderItemDAO;
		private SupplierDAO supplierDAO;

		public ConsoleInterface()
		{
			customerDAO = new CustomerDAO();
			productDAO = new ProductDAO();
			orderDAO = new OrderDAO();
			orderItemDAO = new OrderItemDAO();
			supplierDAO = new SupplierDAO();
		}

		public void Run()
		{
			Console.WriteLine("Welcome to the Database Console Interface!");
			while (true)
			{
				Console.WriteLine("\nChoose an option:");
				Console.WriteLine("1. Add Customer");
				Console.WriteLine("2. Add Product");
				Console.WriteLine("3. Add Order");
				Console.WriteLine("4. Add Order Item");
				Console.WriteLine("5. Add Supplier");
				Console.WriteLine("6. Export Customers to XML");
				Console.WriteLine("7. Import Customers from XML");
				Console.WriteLine("8. Exit");

				string choice = Console.ReadLine();

				switch (choice)
				{
					case "1":
						AddCustomer();
						break;
					case "2":
						AddProduct();
						break;
					case "3":
						AddOrder();
						break;
					case "4":
						AddOrderItem();
						break;
					case "5":
						AddSupplier();
						break;
					case "6":
						ExportCustomersToXml();
						break;
					case "7":
						ImportCustomersFromXml();
						break;
					case "8":
						Console.WriteLine("Goodbye!");
						return;
					default:
						Console.WriteLine("Invalid choice. Please try again.");
						break;
				}
			}
		}

		private void AddCustomer()
		{
			Console.WriteLine("Enter Customer Name:");
			string customerName = Console.ReadLine();
			Customer newCustomer = new Customer { CustomerName = customerName };
			customerDAO.AddCustomer(newCustomer);
			Console.WriteLine("Customer added successfully!");
		}

		private void AddProduct()
		{
			// Similar implementation for adding a product
		}

		private void AddOrder()
		{
			// Similar implementation for adding an order
		}

		private void AddOrderItem()
		{
			// Similar implementation for adding an order item
		}

		private void AddSupplier()
		{
			// Similar implementation for adding a supplier
		}

		private void ExportCustomersToXml()
		{
			Console.WriteLine("Enter the file path to export customers:");
			string filePath = Console.ReadLine();
			customerDAO.ExportToXml(filePath);
			Console.WriteLine("Customers exported to XML successfully!");
		}

		private void ImportCustomersFromXml()
		{
			Console.WriteLine("Enter the file path to import customers:");
			string filePath = Console.ReadLine();
			var importedCustomers = customerDAO.ImportFromXml(filePath);
			if (importedCustomers != null)
			{
				Console.WriteLine("Customers imported from XML successfully!");
				foreach (var customer in importedCustomers)
				{
					Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.CustomerName}");
				}
			}
			else
			{
				Console.WriteLine("Error importing customers from XML.");
			}
		}
	}
}