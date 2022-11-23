using IBGE_Estatistics.Models;
using System.Runtime.CompilerServices;

List<Cidade> cidades = new List<Cidade>
{
    new Cidade
    {
        NomeCidade = "Abatia",
        CodCidade = 001,
        TotalVeiculos = 4493,
        TotalAcidentes = 8

    },

    new Cidade
    {
        NomeCidade = "ADRIANOPOLIS",
        CodCidade = 002,
        TotalVeiculos = 3361,
        TotalAcidentes = 5

    },

    new Cidade
    {
        NomeCidade = "AGUDOS DO SUL",
        CodCidade = 003,
        TotalVeiculos = 7163,
        TotalAcidentes = 21

    },

    new Cidade
    {
        NomeCidade = "ALMIRANTE TAMANDARE",
        CodCidade = 004,
        TotalVeiculos = 65907,
        TotalAcidentes = 72

    },

    new Cidade
    {
        NomeCidade = "ALTAMIRA DO PARANA",
        CodCidade = 005,
        TotalVeiculos = 2205,
        TotalAcidentes = 1

    }

    

};

cidades = cidades.OrderBy(x => x.TotalAcidentes).ToList(); //ordenando do primeiro ao ultimo com base no total de acidentes

Cidade menorIndice = cidades.First(); 
Cidade maiorIndice = cidades.Last();

Console.WriteLine("o menor indice é da cidade: " + menorIndice.NomeCidade + ", "
    + menorIndice.TotalAcidentes +  ", e o maior é o da ciadade: " + maiorIndice.NomeCidade + ", "
    + maiorIndice.TotalAcidentes);

Console.WriteLine();

double media = cidades.Average(x => x.TotalVeiculos);

Console.WriteLine($"A média de veiculos é de: {media} veiculos");

double mediaAcidentesMenos4000Veiculos = MediaAcidentesComMenosDe4000Veiculos(cidades);

Console.WriteLine();

Console.WriteLine($"A média de veiculos nas cidades com menos de 4500 veiculos de passeio é: {mediaAcidentesMenos4000Veiculos}.");


double MediaAcidentesComMenosDe4000Veiculos(List<Cidade> veiculos)
{
    List<Cidade> resultado = new List<Cidade>();
    int totalElementos = veiculos.Count;
    double mediaAcidentes = 0;

    for (int i = 0; i < totalElementos; i++)
    {
        if (veiculos[i].TotalVeiculos < 4500)
        {
            resultado.Add(veiculos[i]);
        }
    }

    mediaAcidentes = resultado.Average(x => x.TotalAcidentes);
    return mediaAcidentes;
}