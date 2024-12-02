using EjemploEnClase.DataContextFd;
using EjemploEnClase.Model;
using EjemploEnClase.QueryResponse;
using Microsoft.EntityFrameworkCore;

namespace EjemploEnClase.Repository
{
    public class NorthwindRepository : INorthwindRepository
    {
        private readonly DataContext _dataContext;

        public NorthwindRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<List<Employees>> GetAllEmployees()
        {
            var result = await _dataContext.Employees.ToListAsync();
            return result;
        }

        public async Task<int> CountEmployees()
        {
            var result = await _dataContext.Employees.CountAsync();
            return result;
        }

        public async Task<Employees> GetEmployeeById(int id)
        {
            var result = await _dataContext.Employees.Where(x => x.EmployeeID == id).FirstAsync();
            return result;
        }

        public async Task<Employees> GetEmployeeByName(string name)
        {
            var result = await _dataContext.Employees.FirstAsync(x => x.FirstName == name);
            return result;
        }

        public async Task<int> GetIdByTitle(string title)
        {
            var result = from emp in _dataContext.Employees where emp.Title == title select emp.EmployeeID;
            return await result.FirstAsync();
        }

        public async Task<Employees> GetEmployeeByCountry(string country)
        {
            var result = from emp in _dataContext.Employees
                         where emp.Country == country
                         select new Employees
                         {
                             FirstName = emp.FirstName,
                             Title = emp.Title
                         };
            return await result.FirstAsync();
        }

        public async Task<List<Employees>> GetAllEmployeesByCountry(string country)
        {
            var result = from emp in _dataContext.Employees
                         where emp.Country == country
                         orderby emp.FirstName
                         select new Employees
                         {
                             FirstName = emp.FirstName,
                             Title = emp.Title
                         };
            return await result.ToListAsync();
        }

        public async Task<Employees> GetOlderEmployee()
        {
            var result = from emp in _dataContext.Employees
                         orderby emp.BirthDate
                         select new Employees
                         {
                             FirstName = emp.FirstName,
                             BirthDate = emp.BirthDate,
                             LastName = emp.LastName
                         };
            return await result.FirstAsync();
        }

        public async Task<List<EmployeeByTitle>> GetQtyEmployeeByTitle()
        {
            var result = from emp in _dataContext.Employees
                         group emp by emp.Title into g
                         select new EmployeeByTitle
                         {
                             QtyEmployees = g.Count(),
                             Title = g.Key
                         };
            return await result.ToListAsync();
        }

        public async Task<List<ProductWithCategory>> GetProductWithCategory()
        {
            var result = from prod in _dataContext.Products
                         join cat in _dataContext.Categories on prod.CategoryId equals cat.CategoryId
                         select new ProductWithCategory
                         {
                             ProductName = prod.ProductName,
                             CategoryName = cat.CategoryName
                         };

            return await result.ToListAsync();
        }

        public async Task<List<Products>> GetProductsLike(string name)
        {
            var result = from prod in _dataContext.Products
                         where prod.ProductName.Contains(name)
                         select prod;
            return await result.ToListAsync();
        }

        public async Task<bool> DeleteOrderById(int orderId)
        {
            Orders? order = await _dataContext.Orders.Where(x => x.OrderId == orderId).FirstOrDefaultAsync();
            OrderDetails? ordenDetail = await _dataContext.OrderDetails.Where(x => x.OrderId == orderId).FirstOrDefaultAsync();
            if (order == null || ordenDetail == null)
            {
                return false;
            }
            else 
            {
                _dataContext.OrderDetails.Remove(ordenDetail);
                _dataContext.Orders.Remove(order);

                var resulta = _dataContext.SaveChanges();
                return true;
            }
        }

        public async Task<bool> ModifyEmployeeName(int id, string name)
        {
            Employees? employee = await _dataContext.Employees.Where(x => x.EmployeeID == id).FirstOrDefaultAsync();
            if (employee == null)
            {
                return false;
            }
            else
            {
                employee.FirstName = name;
                var result = _dataContext.SaveChanges();
                return true;
            }
        }

        public async Task<bool> NewEmployee()
        {
            Employees employee = new Employees
            {
                FirstName = "Juan",
                LastName = "Perez",
                Title = "CEO",
                Country = "Mexico",
                BirthDate = new DateTime(1980, 1, 1)
            };
            _dataContext.Employees.Add(employee);
            var result = _dataContext.SaveChanges();
            return true;
        }
    }
}
