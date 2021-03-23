using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Entidades
{
    [Table("CadastroEvento")]
    public class CadastroEvento
    {   [Display(Description = "Código")]
        public int Id { get; set; }

        [Display(Description = "Nome do Evento")]
        public string NomeUsuario { get; set; }

        [Display(Description = "Data Inicio Evento")]
        public DateTime DataInicioEvento { get; set; }

        [Display(Description = "Data Fim Evento")]
        public DateTime DataFimEvento { get; set; }

        [Display(Description = "Palestrante")]
        public string Palestrante { get; set; }

        [Display(Description = "Tipo de Palestra")]
        public int Tipo { get; set; }
    }
}

