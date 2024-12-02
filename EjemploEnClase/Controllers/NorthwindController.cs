using EjemploEnClase.ConDY;
using EjemploEnClase.Model;
using EjemploEnClase.QueryResponse;
using EjemploEnClase.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploEnClase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NorthwindController : ControllerBase
    {
        private INorthwindRepository _northwindRepository;

        public NorthwindController(INorthwindRepository northwindRepository)
        {
            _northwindRepository = northwindRepository;
        }

        [HttpGet]
        [Route("api/getAll")]
        public async Task<List<Employees>> GetAllEmployees()
        {
            return await _northwindRepository.GetAllEmployees();
        }

        [HttpGet]
        [Route("api/count")]
        public async Task<int> CountEmployees()
        {
            return await _northwindRepository.CountEmployees();
        }

        [HttpGet]
        [Route("api/getById")]
        public async Task<Employees> GetEmployeeById([FromQuery] int id)
        {
            return await _northwindRepository.GetEmployeeById(id);
        }

        [HttpGet]
        [Route("api/getByName")]
        public async Task<Employees> GetEmployeeByName([FromQuery] string name)
        {
            return await _northwindRepository.GetEmployeeByName(name);
        }

        [HttpGet]
        [Route("api/getIdByTitle")]
        public async Task<int> GetIdByTitle([FromQuery] string title)
        {
            return await _northwindRepository.GetIdByTitle(title);
        }

        [HttpGet]
        [Route("api/getByCountry")]
        public async Task<Employees> GetEmployeeByCountry([FromQuery] string country)
        {
            return await _northwindRepository.GetEmployeeByCountry(country);
        }

        [HttpGet]
        [Route("api/getAllByCountry")]
        public async Task<List<Employees>> GetAllEmployeesByCountry([FromQuery] string country)
        {
            return await _northwindRepository.GetAllEmployeesByCountry(country);
        }

        [HttpGet]
        [Route("api/getOlder")]
        public async Task<Employees> GetOlderEmployee()
        {
            return await _northwindRepository.GetOlderEmployee();
        }

        [HttpGet]
        [Route("api/getQtyByTitle")]
        public async Task<List<EmployeeByTitle>> GetQtyEmployeeByTitle()
        {
            return await _northwindRepository.GetQtyEmployeeByTitle();
        }

        [HttpGet]
        [Route("api/getProductWithCategory")]
        public async Task<List<ProductWithCategory>> GetProductWithCategory()
        {
            return await _northwindRepository.GetProductWithCategory();
        }

        [HttpGet]
        [Route("api/getProductsLike")]
        public async Task<List<Products>> GetProductsLike([FromQuery] string name)
        {
            return await _northwindRepository.GetProductsLike(name);
        }

        [HttpDelete]
        [Route("api/deleteOrderById")]
        public async Task<bool> DeleteOrderById([FromQuery] int orderId)
        {
            return await _northwindRepository.DeleteOrderById(orderId);
        }

        [HttpPut]
        [Route("api/modifyEmployeeName")]
        public async Task<bool> ModifyEmployeeName([FromQuery] int id, [FromQuery] string name)
        {
            return await _northwindRepository.ModifyEmployeeName(id, name);
        }

        [HttpPost]
        [Route("api/newEmployee")]
        public async Task<bool> NewEmployee()
        {
            return await _northwindRepository.NewEmployee();
        }
    }
}

