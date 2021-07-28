using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teleperforme.Models;

namespace Teleperforme.Controllers
{
    [ApiController]
    [Route("api/business")]
    public class BusinessController : ControllerBase
    {


        private readonly AplicationDbContext Db;


        public BusinessController(AplicationDbContext Db)
        {
            this.Db = Db;


        }

        [HttpGet]

        public async Task<ActionResult<List<Business>>> Get()
      {
            return await Db.Business.ToListAsync();


             

        }

        [HttpGet("primero")]

        public ActionResult<Business> GetPrimerAutor()

        {

            return Db.Business.FirstOrDefault();
        }



        [HttpGet("{id}", Name = "Getcompany")]
        public async Task<ActionResult<Business>> GetAction(int id)
        {
            var company = await Db.Business.FirstOrDefaultAsync(x => x.Identification_number == id);

            if (company == null)
            {
                return NotFound();
            }



            return company;

        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Business Business)

        {



            Db.Business.Add(Business);
            await Db.SaveChangesAsync();

            return new CreatedAtRouteResult("Getcompany", new { id = Business.Identification_number, Business });



        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id,  Business Updatecompany)
        {
        

            if (Updatecompany.Identification_number != id)
            {
                return BadRequest("no corresponde el id");
            }




            Db.Update(Updatecompany);
            await Db.SaveChangesAsync();
            return Ok();



        }








        [HttpDelete("{id}")]
        public async Task<ActionResult<Business>> Delete(int id)
        {
            var companyid = await Db.Business.Select(x => x.Identification_number).FirstOrDefaultAsync(x => x == id);


            if (companyid == default(int))
            {
                return BadRequest();
            }
            Db.Business.Remove(new Business { Identification_number = companyid });
            await Db.SaveChangesAsync();
            return NoContent();



        }



    }
}
