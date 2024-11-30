using EjemploEnClase.DataContextFd;
using EjemploEnClase.Model;
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
            var result =  from emp in _dataContext.Employees where emp.Title == title select emp.EmployeeID;
            return await result.FirstAsync();
        }

        public async Task<Employees> GetEmployeeByCountry(string country)
        {
            var result = from emp in _dataContext.Employees where emp.Country == country
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
    }
}
