﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Table("TbAcidente")]
    public class Acidente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }
        [MaxLength(15)] public string questao_1 { get; set; }
        public string obs_questao_1 { get; set; }
        [MaxLength(15)] public string questao_2 { get; set; }
        public string obs_questao_2 { get; set; }       
        [MaxLength(50)] public string questao_3 { get; set; }
        public string obs_questao_3 { get; set; }
        [MaxLength(50)] public string questao_4 { get; set; }
        public string obs_questao_4 { get; set; }
        [MaxLength(50)] public string questao_5 { get; set; }
        public string obs_questao_5 { get; set; }
        [MaxLength(50)] public string questao_6 { get; set; }
        public string obs_questao_6 { get; set; }
        [MaxLength(50)] public string questao_7 { get; set; }
        public string obs_questao_7 { get; set; }
        [MaxLength(50)] public string questao_8 { get; set; }
        public string obs_questao_8 { get; set; }
        [MaxLength(50)] public string questao_9 { get; set; }
        public string obs_questao_9 { get; set; }
        [MaxLength(50)] public string questao_10 { get; set; }       
        public string obs_questao_10 { get; set; }
        [MaxLength(50)] public string questao_11 { get; set; }
        public string obs_questao_11 { get; set; }
        [MaxLength(15)] public string questao_12 { get; set; }
        public string obs_questao_12 { get; set; }
        [MaxLength(15)] public string questao_13 { get; set; }
        public string obs_questao_13 { get; set; }
        [MaxLength(15)] public string questao_14 { get; set; }
        public string obs_questao_14 { get; set; }
        [MaxLength(15)] public string questao_15 { get; set; }
        public string obs_questao_15 { get; set; }
        [MaxLength(15)] public string questao_16 { get; set; }
        public string obs_questao_16 { get; set; }
        [MaxLength(15)] public string questao_17 { get; set; }
        public string obs_questao_17 { get; set; }
        [MaxLength(15)] public string questao_18 { get; set; }
        public string obs_questao_18 { get; set; }
        [MaxLength(15)] public string questao_19 { get; set; }
        public string obs_questao_19 { get; set; }
        [MaxLength(15)] public string questao_20 { get; set; }
        public string obs_questao_20 { get; set; }       
        public string consideracao { get; set; }
        public string obs_questao_22 { get; set; }
        public bool preenchimentoCompleto { get; set; }

    }
}
