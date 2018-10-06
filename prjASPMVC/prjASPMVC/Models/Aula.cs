using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace prjEscola.Models
{
    public class Aula
    {
        [Key]
        public int idAula { get; set; }

        [Required]
        [Display(Name = "Nome do curso")]
        public string nmCurso { get; set; }

        [Required]
        [Display(Name = "Nome da turma")]
        public string nomeTurma  { get; set; }

        #region Aula1
        [Required]

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Inicio")]
        public DateTime HoraAulaInicio  { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Fim")]
        public DateTime HoraAulaFim { get; set; }

        [Display(Name = "Dia da Semana")]
        public string nmDiaSemana { get; set; }
        #endregion

        #region Aula2
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Inicio")]
        public DateTime HoraAulaInicio2 { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Fim")]
        public DateTime HoraAulaFim2 { get; set; }

        [Display(Name = "Dia da semana")]
        public string nmDiaSemana2 { get; set; }
        #endregion

        #region Atendimento1

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Inicio")]
        public DateTime HoraAtendimentoInicio { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Fim")]
        public DateTime HoraAtendimentoFim { get; set; }

        [Display(Name = "Dia da semana")]
        public string nmDiaSemanaAtendimento { get; set; }
        #endregion

        #region Atendimento 2

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Inicio")]
        public DateTime HoraAtendimentoInicio2 { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:H:mm}")]
        [Display(Name = "Fim")]
        public DateTime HoraAtendimentoFim2 { get; set; }

        [Display(Name = "Dia da Semana")]
        public string nmDiaSemanaAtendimento2 { get; set; }
        #endregion

        public string Hora()
        {
            return this.HoraAulaFim.ToString("%h");
        }
    }
}