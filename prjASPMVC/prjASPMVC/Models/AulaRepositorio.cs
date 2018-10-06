using prjEscola.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjEscola.Models
{
    public class AulaRepositorio
    {
        private Repositorio repositorio;

        private void Inserir(Aula aula)
        {
            var strQuery = "";
            strQuery += " INSERT INTO Aula (nmCurso, nmTurma, HoraAulaInicio, HoraAulaFim, nmDiaSemana, HoraAulaInicio2, HoraAulaFim2, nmDiaSemana2, HoraAtendimentoInicio, HoraAtendimentoFim, nmDiaSemanaAtendimento, HoraAtendimentoInicio2, HoraAtendimentoFim2, nmDiaSemanaAtendimento2) ";
            strQuery += string.Format(" VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}') ",
                aula.nmCurso,
                aula.nomeTurma,
                aula.HoraAulaInicio.ToLocalTime(),
                aula.HoraAulaFim,
                aula.nmDiaSemana,
                aula.HoraAulaInicio2,
                aula.HoraAulaFim2,
                aula.nmDiaSemana2,
                aula.HoraAtendimentoInicio,
                aula.HoraAtendimentoFim,
                aula.nmDiaSemanaAtendimento,
                aula.HoraAtendimentoInicio2,
                aula.HoraAtendimentoFim2,
                aula.nmDiaSemanaAtendimento2
                );
            using (repositorio = new Repositorio())
            {
                repositorio.ExecutaComando(strQuery);
            }
        }

        public void Salvar(Aula pessoa)
        {
                Inserir(pessoa);
        }
        
        public List<Aula> ListarTodos()
        {
            using (repositorio = new Repositorio())
            {
                var strQuery = string.Format("SELECT * FROM Aula");
                var retornoDataReader = repositorio.ExecutaComandoComRetorno(strQuery);
                return TransformaReaderEmListaDeObjeto(retornoDataReader);
            }
        }

        private List<Aula> TransformaReaderEmListaDeObjeto(SqlDataReader reader)
        {
            var Aulas = new List<Aula>();
            while (reader.Read())
            {
                var temObjeto = new Aula()
                {
                    nmCurso = reader["nmCurso"].ToString(),
                    nomeTurma = reader["nmTurma"].ToString(),
                    HoraAulaInicio = Convert.ToDateTime(reader["HoraAulaInicio"].ToString()),
                    HoraAulaFim = Convert.ToDateTime(reader["HoraAulaFim"].ToString()),
                    nmDiaSemana = reader["nmDiaSemana"].ToString(),

                    HoraAulaInicio2 = Convert.ToDateTime(reader["HoraAulaInicio2"].ToString()),
                    HoraAulaFim2 = Convert.ToDateTime(reader["HoraAulaFim2"].ToString()),
                    nmDiaSemana2 = reader["nmDiaSemana2"].ToString(),

                    HoraAtendimentoInicio = Convert.ToDateTime(reader["HoraAtendimentoInicio"].ToString()),
                    HoraAtendimentoFim = Convert.ToDateTime(reader["HoraAtendimentoFim"].ToString()),
                    nmDiaSemanaAtendimento = reader["nmDiaSemanaAtendimento"].ToString(),

                    HoraAtendimentoInicio2 = Convert.ToDateTime(reader["HoraAtendimentoInicio2"].ToString()),
                    HoraAtendimentoFim2 = Convert.ToDateTime(reader["HoraAtendimentoFim2"].ToString()),
                    nmDiaSemanaAtendimento2 = reader["nmDiaSemanaAtendimento2"].ToString(),
                };
                Aulas.Add(temObjeto);
            }
            reader.Close();
            return Aulas;
        }
    }
}
