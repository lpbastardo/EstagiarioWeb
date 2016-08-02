using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EstagiarioWeb.Models
{
    public class Computer
    {
        public int Id { get; set; }
        [Display(Name = "Marca da placa Mãe: ")]
        public string Marcaplacamae { get; set; }
        [Display(Name = "Marca da placa Mãe: ")]
        public string modeloplacamae { get; set; }

        [Display(Name = "Marca de Ram: ")]
        public string capacidaderam { get; set; }
        [Display(Name = "Quantidade de Ram: ")]
        public int quantidaderam { get; set; }

        [Display(Name = "Capacidade do Hd: ")]
        public string capacidadehd { get; set; }
        [Display(Name = "Quantindade de Hd: ")]
        public string quantidadehd { get; set; }

        [Display(Name = "Modelo de fone: ")]
        public string modelofone { get; set; }
        [Display(Name = "Marca do Fone: ")]
        public string marcafone { get; set; }

        [Display(Name = "Marca do processador: ")]
        public string marcaprocessador { get; set; }
        [Display(Name = "Velocidade do processador: ")]
        public string velocidadeprocessador { get; set; }

    }
}