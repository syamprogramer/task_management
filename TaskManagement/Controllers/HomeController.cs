using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TaskManagement.Core.Services;
using TaskManagement.Models;
using TaskManagement.ViewModels;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace TaskManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ITaskService _taskService;
        public HomeController(ILogger<HomeController> logger, ITaskService taskService)
        {
            _logger = logger;
            _taskService = taskService;

        }

        public IActionResult Index()
        {
            TasksVM vm = new TasksVM();
            return View("Index", vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //Generate action to saveTask with parameter TasksVM


        [HttpPost]
        public async Task<IActionResult> SaveTask(TasksVM model)
        {
            //Check if model is valid
            TempData["Message"] = "Saving Task Failed";
            if (ModelState.IsValid)
            {
                //Create new object task with properties Title, Description, Status, Priority
                var task = new Core.Entities.Task
                {
                    Title = model.Title,
                    Description = model.Description,
                    Status = model.Status,
                    Priority = model.Priority
                };
                if (model.Id != 0)
                {
                    task.Id = model.Id;
                    await _taskService.Update(task);

                }
                else
                    await _taskService.Add(task);


                TempData["Message"] = "Task saved successfully";
               

            }
            else
            {
                string messages = string.Join("; ", ModelState.Values
                                            .SelectMany(x => x.Errors)
                                            .Select(x => x.ErrorMessage));
                TempData["Message"] = messages;
                TempData["IsError"] = "true";
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> GetAllTasks()
        {
            TaskListVM taskListVM = new TaskListVM();
            IEnumerable<Core.Entities.Task> lstresult = await _taskService.GetAll();
            taskListVM.Tasks = lstresult.ToList();

            return View("TaskList", taskListVM);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {

            Core.Entities.Task task = await _taskService.GetById(id);
            TasksVM objVm = new TasksVM();
            //map task to objVm
            objVm.Id = task.Id;
            objVm.Title = task.Title;

            objVm.Description = task.Description;
            objVm.Status = task.Status;
            objVm.Priority = task.Priority;
            return View("Index", objVm);


        }

        [HttpGet]
        public async Task<IActionResult> MarkAscomplete(int id)
        {

            Core.Entities.Task task = await _taskService.GetById(id);
            task.Status = 1;
            await _taskService.Update(task);
            return RedirectToAction("GetAllTasks");
        }

        //Delete task by id
        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            Core.Entities.Task task = await _taskService.GetById(id);
            await _taskService.Delete(task);
            return RedirectToAction("GetAllTasks");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}