namespace labs;

class Program
{
    static void Main(string[] args)
    {
        // Declaração de variáveis
        int golsAtletico, golsCruzeiro;
        int partidas=0, vitoriasAtletico=0, vitoriasCruzeiro=0, empates=0;
        int novoDuelo=1;
        string vencedor;
        // Loop duelo
        while(true) {
            // Interação com o usuário
            Console.WriteLine("Insira o número de gols marcados pelo Atlético: ");
            golsAtletico = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Insira o número de gols marcados pelo Cruzeiro: ");
            golsCruzeiro = int.Parse(Console.ReadLine()!);
            // Processamento duelos
            if(golsAtletico > golsCruzeiro) {
                Console.WriteLine("Atlético vence o duelo");
                vitoriasAtletico++;
            }
            else if(golsAtletico < golsCruzeiro){
                Console.WriteLine("Cruzeiro vence o duelo");
                vitoriasCruzeiro++;
            }
            else {
                Console.WriteLine("EMPATE");
                empates++;
            }
            // Interação com o usuário (Deseja continuar?)
            while(true) {
                Console.WriteLine("Novo DUELO (1.Sim 2.Não)?");
                novoDuelo = int.Parse(Console.ReadLine()!);
                if(novoDuelo != 1 && novoDuelo !=2)
                    Console.WriteLine("Opção inválida.");
                else
                    break;
            }
            if(novoDuelo == 2) {
                break;
            }
        }
        // Processamento vencedor
        partidas = vitoriasAtletico + vitoriasCruzeiro + empates;
        if(vitoriasAtletico > vitoriasCruzeiro)
            vencedor = "Atlético";
        else if(vitoriasCruzeiro > vitoriasAtletico)
            vencedor = "Cruzeiro";
        else {
            vencedor = "empate";
        }
        // Impressão das estatísticas
        Console.WriteLine($"Número de partidas: {partidas}");
        Console.WriteLine($"Número de vitórias do Atlético: {vitoriasAtletico}");
        Console.WriteLine($"Número de vítorias do Cruzeiro: {vitoriasCruzeiro}");
        Console.WriteLine($"Número de empates: {empates}");
        // Verificação empate e impressão do vencedor
        if(vencedor != "empate")
            Console.WriteLine($"{vencedor} venceu o maior número de duelos");
        else
            Console.WriteLine("Não houve vencedor (empate)");

    }
}
