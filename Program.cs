using CursoCSharp;
using CursoCSharp.Fundamentos;

namespace CursoCSharp { 
    class Program {
        private const string V = "v";

        static void Main(string[] args)
        {
            var Central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos" , PrimeiroPrograma.Executar },
                {"Comentários - Fundamentos", Comentarios.Executar}
                {"Váriaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
            });
        }
    }
}