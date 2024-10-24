namespace DesafioEstagio1.Services
{
    public class PercentualService
    {
        public string CalculoPercentual()
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;
            double faturamentoTotal = sp + rj + mg + es + outros;

            double percentualSp = (sp / faturamentoTotal) * 100;
            double percentualRj = (rj / faturamentoTotal) * 100;
            double percentualMg = (mg / faturamentoTotal) * 100;
            double percentualEs = (es / faturamentoTotal) * 100;
            double percentualOutros = (outros / faturamentoTotal) * 100;

            return $"SP: {percentualSp:F2}%\n" +
                    $"RJ: {percentualRj:F2}%\n" +
                    $"MG: {percentualMg:F2}%\n" +
                    $"ES: {percentualEs:F2}%\n" +
                    $"Outros: {percentualOutros:F2}%";

        }
    }
}
