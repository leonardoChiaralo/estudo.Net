﻿using AppFilmes.Modelos;

namespace AppFilmes.Menus;

internal class MenuExibirFilmes : Menu
{
    public void Executar(Dictionary<string, Filme> filmes)
    {
        Console.Clear();
        ExibirTitulo("Listagem de filmes");
        if (filmes.Count > 0)
        {
            foreach (Filme filme in filmes.Values)
            {
                Console.WriteLine($"Título: {filme.Titulo};");
            }
        }
        else
        {
            Console.WriteLine("Nenhum filme foi registrado!");
        }
        Console.Write("\nPressione qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        Console.Clear();
    }
}