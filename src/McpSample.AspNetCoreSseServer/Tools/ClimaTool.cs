using ModelContextProtocol.Server;
using System.ComponentModel;

namespace McpSample.AspNetCoreSseServer.Tools;

[McpServerToolType]
public class ClimaTool
{
    [McpServerTool, Description("Retorna o clima atual para uma cidade específica")]
    public string ObterClimaPorCidade(string nomeCidade)
    {
        var random = new Random();
        var temperatura = random.Next(-20, 40);
        var condicao = random.Next(0, 2) == 0 ? "Ensolarado" : "Chuvoso";
        var umidade = random.Next(0, 100);
        var velocidadeVento = random.Next(0, 20);

        return $"Clima em {nomeCidade}: {temperatura}°C, {condicao}, Umidade: {umidade}%, Vento: {velocidadeVento} km/h";
    }
}
