using EjemploEnClase.Model;

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
    }
}
