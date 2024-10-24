using DesafioEstagio1.Models;

namespace DesafioEstagio1.Services
{
    public class InverterStringService
    {
        public void Inverter(InverterStringModel model)
        {
            if (!string.IsNullOrEmpty(model.txt))
            {
                // Cria um array de caracteres com o mesmo tamanho da string de entrada
                char[] textInvertido = new char[model.txt.Length];

                // Preenche o array com os caracteres na ordem inversa
                for (int i = 0; i < model.txt.Length; i++)
                {
                    textInvertido[i] = model.txt[model.txt.Length - 1 - i]; // Corrige o índice do array
                }

                // Converte o array de caracteres de volta para uma string
                model.resposta = new string(textInvertido);
            }
            else
            {
                model.resposta = "Entrada inválida";
            }
        }
    }
}
