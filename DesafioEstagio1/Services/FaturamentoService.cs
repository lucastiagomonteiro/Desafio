using DesafioEstagio1.Models;
using Newtonsoft.Json;
using System.Reflection;

namespace DesafioEstagio1.Services
{
    public class FaturamentoService
    {
        public void  FuncaoFaturamento(FaturamentoModel model)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Data", "dados.json");
            List<FaturamentoModel> faturamentos = new List<FaturamentoModel> { model };

            try
            {
                string json = System.IO.File.ReadAllText(path);
                faturamentos = JsonConvert.DeserializeObject<List<FaturamentoModel>>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao ler o arquivo JSON: " + ex.Message);
            }

            var diasComFaturamento = faturamentos.Where(f => f.valor > 0).ToList();

            model.MenorFatura = diasComFaturamento.Min(f => f.valor);
            model.MaiorFatura = diasComFaturamento.Max(f => f.valor);
            model.MediaMensal = diasComFaturamento.Average(f => f.valor);
            model.DiasAcimaDaMedia = diasComFaturamento.Count(f => f.valor > model.MediaMensal);

            model.resposta = "Menor Fatura: " + model.MenorFatura +
                ", Maior Fatura: " + model.MaiorFatura +
                ", Média Mensal: " + model.MediaMensal +
                ", Dias Acima da Média: " + model.DiasAcimaDaMedia;
        }
    }
}
