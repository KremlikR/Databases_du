namespace package
{
    public class SupplierDAO
    {
        private YourDbContext context;

        public SupplierDAO()
        {
            context = new YourDbContext();
        }

        public void AddSupplier(Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            context.SaveChanges();
        }

        public Supplier GetSupplierById(int supplierId)
        {
            return context.Suppliers.Find(supplierId);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            context.Entry(supplier).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteSupplier(int supplierId)
        {
            var supplier = context.Suppliers.Find(supplierId);
            if (supplier != null)
            {
                context.Suppliers.Remove(supplier);
                context.SaveChanges();
            }
        }
    }
}