using AutomacaoDal;
using AutomacaoModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutomacaoBll
{
    public class ExeLimiDescBll
    {
        IExeLimiDescDal exeLimiDescBll = new ExeLimiDescDal();
        public ExeLimiDesc read(int id)
        {
            return exeLimiDescBll.read().Where(x => x.formularioId == id).FirstOrDefault();
        }

        public List<ExeLimiDesc> list(int id)
        {
            return exeLimiDescBll.read().Where(x => x.formularioId == id).ToList();
        }
        public void save(ExeLimiDesc e)
        {
            try
            {
                IImagemDal imagemDal = new ImagemDal();
                if (e.questao_1 != null)
                    if (imagemDal.read(e.formularioId, 1, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_1));

                if (e.questao_2 != null)
                    if (imagemDal.read(e.formularioId, 2, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_2));

                if (e.questao_3 != null)
                    if (imagemDal.read(e.formularioId, 3, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_3));

                if (e.questao_4 != null)
                    if (imagemDal.read(e.formularioId, 4, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_4));

                if (e.questao_5 != null)
                    if (imagemDal.read(e.formularioId, 5, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_5));

                if (e.questao_6 != null)
                    if (imagemDal.read(e.formularioId, 6, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_6));

                if (e.questao_7 != null)
                    if (imagemDal.read(e.formularioId, 7, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_7));

                if (e.questao_8 != null)
                    if (imagemDal.read(e.formularioId, 8, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_8));

                if (e.questao_9 != null)
                    if (imagemDal.read(e.formularioId, 9, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_9));

                if (e.questao_10 != null)
                    if (imagemDal.read(e.formularioId, 10, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_10));

                if (e.questao_11 != null)
                    if (imagemDal.read(e.formularioId, 11, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_11));

                if (e.questao_12 != null)
                    if (imagemDal.read(e.formularioId, 12, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_12));

                if (e.questao_13 != null)
                    if (imagemDal.read(e.formularioId, 13, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_13));

                if (e.questao_14 != null)
                    if (imagemDal.read(e.formularioId, 14, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_14));

                if (e.questao_15 != null)
                    if (imagemDal.read(e.formularioId, 15, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_15));

                if (e.questao_16 != null)
                    if (imagemDal.read(e.formularioId, 16, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_16));

                if (e.questao_17 != null)
                    if (imagemDal.read(e.formularioId, 17, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_17));

                if (e.questao_18 != null)
                    if (imagemDal.read(e.formularioId, 18, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_18));

                if (e.questao_19 != null)
                    if (imagemDal.read(e.formularioId, 19, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_19));

                if (e.questao_20 != null)
                    if (imagemDal.read(e.formularioId, 20, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_20));

                if (e.questao_21 != null)
                    if (imagemDal.read(e.formularioId, 21, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_21));

                if (e.questao_22 != null)
                    if (imagemDal.read(e.formularioId, 22, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_22));

                if (e.questao_23 != null)
                    if (imagemDal.read(e.formularioId, 23, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_23));

                if (e.questao_24 != null)
                    if (imagemDal.read(e.formularioId, 24, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_24));

                if (e.questao_25 != null)
                    if (imagemDal.read(e.formularioId, 25, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_25));

                if (e.questao_26 != null)
                    if (imagemDal.read(e.formularioId, 26, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_26));

                if (e.questao_27 != null)
                    if (imagemDal.read(e.formularioId, 27, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_27));

                if (e.questao_28 != null)
                    if (imagemDal.read(e.formularioId, 28, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_28));

                if (e.questao_29 != null)
                    if (imagemDal.read(e.formularioId, 29, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_29));

                if (e.questao_30 != null)
                    if (imagemDal.read(e.formularioId, 30, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_30));

                if (e.questao_31 != null)
                    if (imagemDal.read(e.formularioId, 31, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_31));

                if (e.questao_32 != null)
                    if (imagemDal.read(e.formularioId, 32, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_32));

                if (e.questao_33 != null)
                    if (imagemDal.read(e.formularioId, 33, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_33));

                if (e.questao_34 != null)
                    if (imagemDal.read(e.formularioId, 34, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_34));

                if (e.questao_35 != null)
                    if (imagemDal.read(e.formularioId, 35, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_35));

                if (e.questao_36 != null)
                    if (imagemDal.read(e.formularioId, 36, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_36));

                if (e.questao_37 != null)
                    if (imagemDal.read(e.formularioId, 37, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_37));

                if (e.questao_38 != null)
                    if (imagemDal.read(e.formularioId, 38, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_38));

                if (e.questao_39 != null)
                    if (imagemDal.read(e.formularioId, 39, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_39));

                if (e.questao_40 != null)
                    if (imagemDal.read(e.formularioId, 40, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_40));

                if (e.questao_41 != null)
                    if (imagemDal.read(e.formularioId, 41, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_41));

                if (e.questao_42 != null)
                    if (imagemDal.read(e.formularioId, 42, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_42));

                if (e.questao_43 != null)
                    if (imagemDal.read(e.formularioId, 43, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_43));

                if (e.questao_44 != null)
                    if (imagemDal.read(e.formularioId, 44, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_44));

                if (e.questao_45 != null)
                    if (imagemDal.read(e.formularioId, 45, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_45));

                if (e.questao_46 != null)
                    if (imagemDal.read(e.formularioId, 46, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_46));

                if (e.questao_47 != null)
                    if (imagemDal.read(e.formularioId, 47, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_47));

                if (e.questao_48 != null)
                    if (imagemDal.read(e.formularioId, 48, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_48));

                if (e.questao_49 != null)
                    if (imagemDal.read(e.formularioId, 49, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_49));

                if (e.questao_50 != null)
                    if (imagemDal.read(e.formularioId, 50, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_50));

                if (e.questao_51 != null)
                    if (imagemDal.read(e.formularioId, 51, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_51));

                if (e.questao_52 != null)
                    if (imagemDal.read(e.formularioId, 52, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_52));

                if (e.questao_53 != null)
                    if (imagemDal.read(e.formularioId, 53, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_53));

                if (e.questao_54 != null)
                    if (imagemDal.read(e.formularioId, 54, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_54));

                if (e.questao_55 != null)
                    if (imagemDal.read(e.formularioId, 55, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_55));

                if (e.questao_56 != null)
                    if (imagemDal.read(e.formularioId, 56, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_56));

                if (e.questao_57 != null)
                    if (imagemDal.read(e.formularioId, 57, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_57));

                if (e.questao_58 != null)
                    if (imagemDal.read(e.formularioId, 58, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_58));

                if (e.questao_59 != null)
                    if (imagemDal.read(e.formularioId, 59, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_59));

                if (e.questao_60 != null)
                    if (imagemDal.read(e.formularioId, 60, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_60));

                if (e.questao_61 != null)
                    if (imagemDal.read(e.formularioId, 61, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_61));

                if (e.questao_62 != null)
                    if (imagemDal.read(e.formularioId, 62, null).Count() == 0)
                        throw new Exception(string.Concat("Favor inserir pelo menos 1 print para o item ", e.questao_62));




                if (e.id == 0)
                    exeLimiDescBll.create(e);
                else
                    exeLimiDescBll.update(e);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
    }
}
