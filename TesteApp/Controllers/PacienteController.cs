using AutoMapper;
using Domain.Models;
using Domain.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using TesteApp.Models;

namespace TesteApp.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteService _service;

        public PacienteController(IPacienteService service, IMapper mapper)
        {
            _service = service;
        }
        // GET: PacienteController
        [HttpGet]
        [Route("")]
        public async Task<ActionResult> Index()
        {
            try
            {
                var pacientes = await _service.GetAsync();
                return View("Index",pacientes);
            }
            catch (Exception e)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        // GET: PacienteController/Details/5
        [HttpGet]
        [Route("Details/{id}")]
        public ActionResult Details(string id)
        {

            try
            {
                var paciente = _service.GetById(id);
                return View(paciente);
            }
            catch (Exception e)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        // GET: PacienteController/Create
        [HttpGet]
        [Route("Create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: PacienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Create")]
        public ActionResult Create([FromForm] PacienteViewModel paciente)
        {
            try
            {
                _service.AddOrUpdate(paciente);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PacienteController/Edit/5
        [HttpGet]
        [Route("Edit/{id}")]
        public ActionResult Edit(string id)
        {
            try
            {
                var paciente = _service.GetById(id);
                return View(paciente);
            }
            catch (Exception e)
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        // POST: PacienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("Edit/{id}")]
        public ActionResult Edit(string id, [FromForm] PacienteViewModel paciente)
        {
            try
            {
                _service.AddOrUpdate(paciente);
                return RedirectToAction("Details", new { id = paciente.Id });
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }

        // POST: PacienteController/Delete/5
        [HttpDelete]
        [ValidateAntiForgeryToken]
        [Route("Edit/{id}")]
        public ActionResult Delete(string id)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }
}
