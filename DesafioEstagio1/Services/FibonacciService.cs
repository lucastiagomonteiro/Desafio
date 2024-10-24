using DesafioEstagio1.Models;

namespace DesafioEstagio1.Services
{
    public class FibonacciService
    {
        public string CalcularFibonacci(FibonacciModel model)
        {
            // Lista para armazenar a sequência de Fibonacci
            List<int> fibonacci = new List<int> { 0, 1 };
            bool pertence = false;
            string resposta;

            // Calcula a sequência de Fibonacci até o número informado
            while (fibonacci[fibonacci.Count - 1] < model.numeroInformado)
            {
                int novoValor = fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2];
                fibonacci.Add(novoValor);

                // Verifica se o número informado pertence à sequência
                if (novoValor == model.numeroInformado)
                {
                    pertence = true;
                    break;
                }
            }

            // Converte a sequência em string
            resposta = "Sequência de Fibonacci: " + string.Join(", ", fibonacci);

            // Adiciona a mensagem de verificação
            if (pertence)
            {
                resposta += $"\nO número {model.numeroInformado} pertence à sequência de Fibonacci.";
            }
            else
            {
                resposta += $"\nO número {model.numeroInformado} não pertence à sequência de Fibonacci.";
            }

            return resposta;
        }
    }
}
