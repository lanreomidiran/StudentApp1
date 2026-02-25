using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentApp1.Data;
using StudentApp1.Models;
using StudentApp1.Models.Entities;

namespace StudentApp1.Controllers;


public class StudentsController : Controller
{
    private readonly ApplicationDbContext _dbContext;
    public StudentsController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext; 
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddStudentViewModel viewModel);
    [HttpGet]
    public async Task<IActionResult> List()
    {
        var students = await _dbContext.Students.ToListAsync();

        return View(students);
    }
       
 }



