using System.Collections.Generic;
using WebMvc.Models;

namespace WebMvc.Repositorios
{
    public class MusicaRepositorio
    {
        public static List<Musica> Musicas = new List<Musica>(){
            new Musica("Juntos e Shallow Now","Paula Fernanda e Luan Santano", "Pop"),
            new Musica("Baby Shark", "Desconhecido", "Infantil"),
            new Musica("People = Shit", "Slipknot", "Hardcore rock"),
            new Musica("Stay Alive", "José Gonzales", "Indie")
        };

    }
}