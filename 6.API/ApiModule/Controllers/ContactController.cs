using ApiModule.Context;
using ApiModule.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace ApiModule.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ContactbookContext _context;
        public ContactController(ContactbookContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Add(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new { id = contact.Id }, contact);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            return Ok(contact);
        }

        [HttpGet("GetByName")]
        public IActionResult GetAll(string name)
        {
            var contacts = _context.Contacts.Where(x => x.Name.Contains(name));

            if (contacts == null)
                return NotFound();

            return Ok(contacts);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            var contactDB = _context.Contacts.Find(id);

            if (contactDB == null)
                return NotFound();

            contactDB.Name = contact.Name;
            contactDB.Telephone = contact.Telephone;
            contactDB.Active = contact.Active;

            _context.Contacts.Update(contactDB);
            _context.SaveChanges();

            return Ok(contactDB);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
                return NotFound();

            _context.Contacts.Remove(contact);
            _context.SaveChanges();

            return NoContent();
        }
    }
}