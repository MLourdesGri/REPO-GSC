using EjemploEnClase.Model;
using EjemploEnClase.QueryResponse;

namespace EjemploEnClase.Repository
{
    public interface INorthwindRepository
    {
        Task<List<Employees>> GetAllEmployees();

        Task<int> CountEmployees();

        Task<Employees> GetEmployeeById(int id);

        Task<Employees> GetEmployeeByName(string name);

        Task<int> GetIdByTitle(string title);

        Task<Employees> GetEmployeeByCountry(string country);

        Task<List<Employees>> GetAllEmployeesByCountry(string country);

        Task<Employees> GetOlderEmployee();

        Task<List<EmployeeByTitle>> GetQtyEmployeeByTitle();

        Task<List<ProductWithCategory>> GetProductWithCategory();

        Task<List<Products>> GetProductsLike(string name);

        Task<bool> DeleteOrderById(int orderId);

        Task<bool> ModifyEmployeeName(int id, string name);

        Task<bool> NewEmployee();
    }
}
