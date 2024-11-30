using EjemploEnClase.ConDY;
using EjemploEnClase.Model;
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
        public async Task<Employees> GetEmployeeById([FromQuery]int id)
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
    }
}

