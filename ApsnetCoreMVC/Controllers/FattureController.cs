using Models;
using ApsnetCoreMVC.Services;
using Microsoft.AspNetCore.Mvc;
using ApsnetCoreMVC.Dtos;
using AutoMapper;

namespace ApsnetCoreMVC.Controllers
{
    public class FattureController : Controller
    {
        readonly ApplicationDbContext _context;
        readonly IMapper _mapper;
        readonly ILogger<FattureController> _logger;


        public FattureController(ApplicationDbContext context, IMapper mapper, ILogger<FattureController> logger)
        {
            this._context = context;
            this._mapper = mapper;
            this._logger = logger;
        }

        public IActionResult Index()
        {
            List<Fattura> fattura = _context.Fatture.OrderByDescending(classeFattura => classeFattura.FatturaId).ToList();

            _logger.LogInformation("===================== Lista fattura caricata con successo ==================");

            return View(fattura);
        }

        [HttpGet] 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(FatturaDto dto) 
        {
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("=====================  Tentativo di creazione fatture non valido ==================");

                return View(dto);
            }

            //  dto -> Fatt (select .... where client ...= 'id' - '')
            // dto -> controller <- AutoMapper tra modello e dto -> servizio <-  database 

            //Fattura _fattura = new()
            //{
            //    Numero = dto.Numero,
            //    Stato = dto.Stato,
            //    DataEmissione = dto.DataEmissione,
            //    DataScadenza = dto.DataScadenza,
            //    Servizio = dto.Servizio,
            //    PrezzoUnitario = dto.PrezzoUnitario,
            //    Quantita = dto.Quantita,
            //    NomeCliente = dto.NomeCliente,
            //    Email = dto.Email,
            //    Telefono = dto.Telefono,
            //    Indirizzo = dto.Indirizzo!
            //}

            try
            {
                // Mapping DTO -> Entity(Fattura)
                Fattura _fattura = _mapper.Map<Fattura>(dto);

                // Salva nel Database
                await _context.Fatture.AddAsync(_fattura);
                await _context.SaveChangesAsync();

                _logger.LogInformation("===================== Lista fattura è stata creata con successo. Numero: {Numero} ==================", _fattura.Numero);

                TempData["success"] = "Fattura creata con successo";

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, "===================== Errore durante la creazione della fattura ==================");

                TempData["error"] = "Errore durante il salvataggio della fattura";

                return View(dto);
            }
        }
    }
}
