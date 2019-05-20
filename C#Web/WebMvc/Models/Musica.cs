namespace WebMvc.Models
{
    public class Musica
    {
        public string Titulo{get;set;}
        public string Compositor{get;set;}
        public string Estilo{get;set;}

        public Musica(string titulo, string compositor, string estilo){
            Titulo = titulo;
            Compositor = compositor;
            Estilo = estilo;
        }
    }
}