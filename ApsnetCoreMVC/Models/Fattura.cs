using Microsoft.EntityFrameworkCore;

namespace ApsnetCoreMVC.Models
{
    public class Fattura
    {
        public int FatturaId { get; set; }

        // Dati fattura
        public string Numero { get; set; } = "";
        public string Stato { get; set; } = "";
        public DateTime? DataEmissione { get; set; }
        public DateTime? DataScadenza { get; set; }
        
        // Detagli servizio 
        public string Servizio { get; set; } = "";

        [Precision(16, 2)]
        public decimal PrezzoUnitario { get; set; }
        public int Quantita { get; set; }

        //// Totale calcolo (non salvato nel Database)
        //public decimal Totale => PrezzoUnitario * Quantita;

        // Dati clienti
        public string NomeCliente { get; set; } = "";
        public string Email  { get; set; } = "";
        public string Telefono { get; set; } = "";
        public string Indirizzo { get; set; } = "";
    }
}
