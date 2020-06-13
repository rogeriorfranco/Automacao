using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutomacaoModel
{
    [Serializable]
    [Table("TbExeLimiDesc")]
    public class ExeLimiDesc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public int formularioId { get; set; }
        [ForeignKey("formularioId")]
        public virtual Formulario Formulario { get; set; }

        public string justificativa { get; set; }
        public string informacaoComplementar { get; set; }
        public string motivoCumprimento { get; set; }
        public string descricao { get; set; }
        public string orgao { get; set; }
        public string detalhe_questao_0 { get; set; }
        [MaxLength(150)] public string questao_1 { get; set; }
        public string obs_questao_1 { get; set; }
        [MaxLength(150)] public string questao_2 { get; set; }
        public string obs_questao_2 { get; set; }
        [MaxLength(150)] public string questao_3 { get; set; }
        public string obs_questao_3 { get; set; }
        [MaxLength(150)] public string questao_4 { get; set; }
        public string obs_questao_4 { get; set; }
        [MaxLength(150)] public string questao_5 { get; set; }
        public string obs_questao_5 { get; set; }
        [MaxLength(150)] public string questao_6 { get; set; }
        public string obs_questao_6 { get; set; }
        [MaxLength(150)] public string questao_7 { get; set; }
        public string obs_questao_7 { get; set; }
        [MaxLength(150)] public string questao_8 { get; set; }
        public string obs_questao_8 { get; set; }
        [MaxLength(150)] public string questao_9 { get; set; }
        public string obs_questao_9 { get; set; }
        [MaxLength(150)] public string questao_10 { get; set; }
        public string obs_questao_10 { get; set; }
        [MaxLength(150)] public string questao_11 { get; set; }
        public string obs_questao_11 { get; set; }
        [MaxLength(150)] public string questao_12 { get; set; }
        public string obs_questao_12 { get; set; }
        [MaxLength(150)] public string questao_13 { get; set; }
        public string obs_questao_13 { get; set; }
        [MaxLength(150)] public string questao_14 { get; set; }
        public string obs_questao_14 { get; set; }
        [MaxLength(150)] public string questao_15 { get; set; }
        public string obs_questao_15 { get; set; }
        [MaxLength(150)] public string questao_16 { get; set; }
        public string obs_questao_16 { get; set; }
        [MaxLength(150)] public string questao_17 { get; set; }
        public string obs_questao_17 { get; set; }
        [MaxLength(150)] public string questao_18 { get; set; }
        public string obs_questao_18 { get; set; }
        [MaxLength(150)] public string questao_19 { get; set; }
        public string obs_questao_19 { get; set; }
        [MaxLength(150)] public string questao_20 { get; set; }
        public string obs_questao_20 { get; set; }
        [MaxLength(150)] public string questao_21 { get; set; }
        public string obs_questao_21 { get; set; }
        [MaxLength(150)] public string questao_22 { get; set; }
        public string obs_questao_22 { get; set; }
        [MaxLength(150)] public string questao_23 { get; set; }
        public string obs_questao_23 { get; set; }
        [MaxLength(150)] public string questao_24 { get; set; }
        public string obs_questao_24 { get; set; }
        [MaxLength(150)] public string questao_25 { get; set; }
        public string obs_questao_25 { get; set; }
        [MaxLength(150)] public string questao_26 { get; set; }
        public string obs_questao_26 { get; set; }
        [MaxLength(150)] public string questao_27 { get; set; }
        public string obs_questao_27 { get; set; }
        [MaxLength(150)] public string questao_28 { get; set; }
        public string obs_questao_28 { get; set; }
        [MaxLength(150)] public string questao_29 { get; set; }
        public string obs_questao_29 { get; set; }
        [MaxLength(150)] public string questao_30 { get; set; }
        public string obs_questao_30 { get; set; }
        [MaxLength(150)] public string questao_31 { get; set; }
        public string obs_questao_31 { get; set; }
        [MaxLength(150)] public string questao_32 { get; set; }
        public string obs_questao_32 { get; set; }
        [MaxLength(150)] public string questao_33 { get; set; }
        public string obs_questao_33 { get; set; }
        [MaxLength(150)] public string questao_34 { get; set; }
        public string obs_questao_34 { get; set; }
        [MaxLength(150)] public string questao_35 { get; set; }
        public string obs_questao_35 { get; set; }
        [MaxLength(150)] public string questao_36 { get; set; }
        public string obs_questao_36 { get; set; }
        [MaxLength(150)] public string questao_37 { get; set; }
        public string obs_questao_37 { get; set; }
        [MaxLength(150)] public string questao_38 { get; set; }
        public string obs_questao_38 { get; set; }
        [MaxLength(150)] public string questao_39 { get; set; }
        public string obs_questao_39 { get; set; }
        [MaxLength(150)] public string questao_40 { get; set; }
        public string obs_questao_40 { get; set; }
        [MaxLength(150)] public string questao_41 { get; set; }
        public string obs_questao_41 { get; set; }
        [MaxLength(150)] public string questao_42 { get; set; }
        public string obs_questao_42 { get; set; }
        [MaxLength(150)] public string questao_43 { get; set; }
        public string obs_questao_43 { get; set; }
        [MaxLength(150)] public string questao_44 { get; set; }
        public string obs_questao_44 { get; set; }
        [MaxLength(150)] public string questao_45 { get; set; }
        public string obs_questao_45 { get; set; }
        [MaxLength(150)] public string questao_46 { get; set; }
        public string obs_questao_46 { get; set; }
        [MaxLength(150)] public string questao_47 { get; set; }
        public string obs_questao_47 { get; set; }
        [MaxLength(150)] public string questao_48 { get; set; }
        public string obs_questao_48 { get; set; }
        [MaxLength(150)] public string questao_49 { get; set; }
        public string obs_questao_49 { get; set; }
        [MaxLength(150)] public string questao_50 { get; set; }
        public string obs_questao_50 { get; set; }
        [MaxLength(150)] public string questao_51 { get; set; }
        public string obs_questao_51 { get; set; }
        [MaxLength(150)] public string questao_52 { get; set; }
        public string obs_questao_52 { get; set; }
        [MaxLength(150)] public string questao_53 { get; set; }
        public string obs_questao_53 { get; set; }
        [MaxLength(150)] public string questao_54 { get; set; }
        public string obs_questao_54 { get; set; }
        [MaxLength(150)] public string questao_55 { get; set; }
        public string obs_questao_55 { get; set; }
        [MaxLength(150)] public string questao_56 { get; set; }
        public string obs_questao_56 { get; set; }
        [MaxLength(150)] public string questao_57 { get; set; }
        public string obs_questao_57 { get; set; }
        [MaxLength(150)] public string questao_58 { get; set; }
        public string obs_questao_58 { get; set; }
        [MaxLength(150)] public string questao_59 { get; set; }
        public string obs_questao_59 { get; set; }
        [MaxLength(150)] public string questao_60 { get; set; }
        public string obs_questao_60 { get; set; }
        [MaxLength(150)] public string questao_61 { get; set; }
        public string obs_questao_61 { get; set; }
        [MaxLength(150)] public string questao_62 { get; set; }
        public string obs_questao_62 { get; set; }
        public string consideracao { get; set; }
        public bool preenchimentoCompleto { get; set; }
    }
}
