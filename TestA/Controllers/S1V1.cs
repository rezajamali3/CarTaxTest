using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics.Contracts;

namespace TestA.Controllers
{


    [Route("/emp")]
    [ApiController]
    public class TestEMPController : ControllerBase
    {

        
        private readonly IOptions<Employ> _employ;
        private readonly Employ _em;


        public TestEMPController(IOptionsFactory<Employ> em) 
            => _employ = (IOptions<Employ>?)em.Create("Entity1");



        [Route("CreateEMP")]
        [HttpPost]
        public ActionResult Post([FromBody] emp em)
        {

            var valid =
                 em.id  != 0  &&
                 string.IsNullOrWhiteSpace(em.name) &&
                 string.IsNullOrWhiteSpace(em.lastname);


            if (valid == true)
                throw new ArgumentException( "CVB" );


            _em.Employs.Add(em) ;


            return Ok();


        }

        [Route("AllList")]
        [HttpGet]
        public ActionResult<List<emp>> Get()
         => _em.Employs.ToList();


        [Route("getEMP")]
        [HttpGet]
        public ActionResult<emp> Get( int id )
        => _em.Employs.Where( a => a.id ==id ).Single();


        [Route("UpdateEmp")]
        [HttpPut]
        public ActionResult<emp> Put(int id)
        {

            var find = _em.Employs.Where(a => a.id == id).Single();

            if (find is null)
                throw new ArgumentException($"not find id{id}");

            _em.Employs.Remove(find);

            //find.name = "XCV";
            //find.lastname = "XCV";

            _em.Employs.Add(find);
            return Ok();

        }


        [Route("EmpActive")]
        [HttpPatch]
        public ActionResult<emp> Pach(int id)
        {

            var find = _em.Employs.Where(a => a.id == id).Single();

            if (find is null)
                throw new ArgumentException($"not find id{id}");

            _em.Employs.Remove(find);

            return Ok();

        }


        [Route("EMPDelete")]
        [HttpDelete]
        public ActionResult<emp> Delete(int id)
        {

            var find = _em.Employs.Where(a => a.id == id).Single();

            if (find is null)
                throw new ArgumentException($"not find id{id}");

            _em.Employs.Remove(find);

            return Ok();

        }


    }



    public class Employ
    {

        public List<emp> Employs;

        public Employ()
        {
           

            Employs = new()
            {
                new emp(1,"Na1","Ls1"),
                new emp(2,"Na2","Ls2"),
                new emp(3,"Na3","Ls3"),
                new emp(4,"Na4","Ls4"),
                new emp(5,"Na5","Ls5"),
                new emp(6,"Na6","Ls6"),
                new emp(7,"Na7","Ls7")
            };


        }


    }
         


    public record emp(int id,string name,string lastname);
   

}
