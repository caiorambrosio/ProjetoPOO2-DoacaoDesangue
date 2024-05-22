using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Hemocentro
    {
        [Key]
        public int Id { get; set; }
        public double CEP { get; set; }
        public string Referencia { get; set; }
        public string NomeHemocentro { get; set; }
        public double Telefone { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
    }
}
