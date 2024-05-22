using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProcedimentoPaciente
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Paciente")]
        public int IdPaciente { get; set; }
        public Paciente Paciente { get; set; }
        public string Diagnostico { get; set; }
        public string ProcedimentoTerapeutico { get; set; }
        public int VolumeExtracorporeoProcessado { get; set; }
        public string TipoComponente { get; set; }
        public int VolumeComponente { get; set; }
        public int TipoLiquido { get; set; }
        public int VolumeLiquido { get; set; }
    }
}
