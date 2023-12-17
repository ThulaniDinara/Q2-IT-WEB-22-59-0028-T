using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentWebApplication.Data;
using StudentWebApplication.Model;

namespace StudentWebApplication.Pages.CoursInfo
{
    public class IndexModel : PageModel
    {
        private readonly StudentWebApplication.Data.StudentWebApplicationContext _context;

        public IndexModel(StudentWebApplication.Data.StudentWebApplicationContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Course != null)
            {
                Course = await _context.Course.ToListAsync();
            }
        }
    }
}
