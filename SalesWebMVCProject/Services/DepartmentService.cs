using Microsoft.EntityFrameworkCore;
using SalesWebMVCProject.Data;
using SalesWebMVCProject.Models;

namespace SalesWebMVCProject.Services;

public class DepartmentService
{
    private readonly SalesWebMVCProjectContext _context;
    public DepartmentService(SalesWebMVCProjectContext context)
    {
        _context = context;
    }
    public async Task<List<Department>> FindAllAsync()
    {
        return await _context.Department.OrderBy(x => x.Name).ToListAsync();
    }
}
