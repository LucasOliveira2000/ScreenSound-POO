class Musica
{
    public Musica(Banda artista, string nome) //passando um construtor, onde é obrigado passar ele depois 
    {
        Artista = artista;
        Nome = nome;
    }
    // Abaixo está todos os atributos da class Musica
    public string Nome { get; } //ctrl +r+r renomear em todos os locais
    public Banda Artista { get; } // get = Leitura
    public int Duracao { get; set; } // set = atribuição
    public bool Disponivel { get;set;} // propriedade get e set
    public string DescricaoResumida =>
        $"A música {Nome} pertence à banda {Artista}"; //Propriedade somente leitura => Lambda
   
       
    public void ExibirFichaTecnica() // Agora temos um método que representa um comportamento de qualquer objeto da classe Musica
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        //Condição para verigicar se está disponivel ou não
        if (Disponivel)
        {
            Console.WriteLine("Disponível no Plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+.");
        }


    }



}

