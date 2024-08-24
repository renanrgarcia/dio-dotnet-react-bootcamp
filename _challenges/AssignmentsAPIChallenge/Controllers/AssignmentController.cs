using AssignmentsAPIChallenge.Context;
using AssignmentsAPIChallenge.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsAPIChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssignmentController : ControllerBase
    {
        private readonly AssignmentContext _context;

        public AssignmentController(AssignmentContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public IActionResult GetAssignmentById(int id)
        {
            var assignment = _context.Assignments.Find(id);

            if (assignment == null)
                return NotFound();

            return Ok(assignment);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAssignment(int id, Assignment assignment)
        {
            var assignmentDB = _context.Assignments.Find(id);

            if (assignmentDB == null)
                return NotFound();

            assignmentDB.Title = assignment.Title;
            assignmentDB.Description = assignment.Description;
            assignmentDB.Date = assignment.Date;
            assignmentDB.Status = assignment.Status;

            _context.Update(assignmentDB);
            _context.SaveChanges();

            return Ok(assignmentDB);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAssignment(int id)
        {
            var assignment = _context.Assignments.Find(id);

            if (assignment == null)
                return NotFound();

            _context.Remove(assignment);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet]
        public IActionResult GetAllAssignments()
        {
            // var assignments = _context.
            return Ok();
        }


        [HttpGet("GetByTitle")]
        public IActionResult GetAssignmentByTitle(string title)
        {
            var assignments = _context.Assignments.Where(assignment => assignment.Title.Contains(title));

            if (assignments == null)
                return NotFound();

            return Ok(assignments);
        }

        [HttpGet("GetByDate")]
        public IActionResult GetAssignmentByDate(DateTime date)
        {
            var assignments = _context.Assignments.Where(assignment => assignment.Date.Date == date.Date);

            if (assignments == null)
                return NotFound();

            return Ok(assignments);
        }

        [HttpGet("GetByStatus")]
        public IActionResult GetAssignmentByStatus(EnumAssignmentStatus status)
        {
            var assignments = _context.Assignments.Where(assignment => assignment.Status == status);

            if (assignments == null)
                return NotFound();

            return Ok(assignments);
        }

        [HttpPost]
        public IActionResult CreateAssignment(Assignment assignment)
        {
            _context.Add(assignment);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetAssignmentById), new { id = assignment.Id }, assignment);
        }
    }
}