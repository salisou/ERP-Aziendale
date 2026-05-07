using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ApsnetCoreMVC.Dtos
{
    public class FatturaDto
    {

        [Required]
        public string Numero { get; set; } = "";


        [Required]
        public string Stato { get; set; } = "";
        public DateTime? DataEmissione { get; set; }
        public DateTime? DataScadenza { get; set; }


        [Required]
        public string Servizio { get; set; } = "";


        [Required, Display(Name = "Prezzo Unitario")]
        public decimal PrezzoUnitario { get; set; }


        [Required, Display(Name = "Quantità")]
        public int Quantita { get; set; }

        [Required, Display(Name = "Nome del Cliente")]
        public string NomeCliente { get; set; } = "";


        [Required, EmailAddress, Display(Name = "Email del Cliente")]
        public string Email { get; set; } = "";


        [Required, Phone, Display(Name = "Telefono del Cliente")]
        public string Telefono { get; set; } = "";
        public string? Indirizzo { get; set; } 
    }
}
