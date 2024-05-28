using Microsoft.AspNetCore.Mvc;
using WebApiByKrisha.Models;
using WebApiByKrisha.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApiByKrisha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        // ****** Dependency Injection of ProductRepo using Interface(IRepository) ******
        private readonly IRepository<College> _collegerepo = null;
        public CollegeController(IRepository<College> collegerepo)
        {
            _collegerepo = collegerepo;
        }
        // GET: api/<CollegeController>
        [HttpGet]
        //public IEnumerable<string> Get()
        public List<College> GetRecords()
        {
            return _collegerepo.GetAllRecords();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<CollegeController>/5
        [HttpGet("{id}")]
        //public string Get(int id)
        public College GetOneRecord(int id)
        {
            return _collegerepo.GetSingleRecord(id);
            //return "value";
        }

        // POST api/<CollegeController>
        // ************ Modify the pre-built method name ***********
        // public void Post([FromBody] string value)
        [HttpPost]
        public void InsertRecord(College clz)
        {
            _collegerepo.AddRecord(clz);
        }

        // PUT api/<CollegeController>/5
        [HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        public void EditRecord(College clz)
        {
            _collegerepo.UpdateRecord(clz);
        }

        // DELETE api/<CollegeController>/5
        [HttpDelete("{id}")]
        //public void Delete(int id)
        public void RemoveRecord(int id)
        {
            College clz = GetOneRecord(id);
            _collegerepo.DeleteRecord(clz);
        }
    }
}
