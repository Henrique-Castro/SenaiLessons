using Senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Filmes.WebApi.Repositories
{
    public class FilmeRepository
    {
        List<FilmeDomain> ListaDeFilmes = new List<FilmeDomain>();
        private string StringConexao = "Data Source=localhost;Initial Catalog=RoteiroFilmes;User Id=sa;Pwd=132;";

        public IEnumerable<FilmeDomain> Listar()
        {
            ListaDeFilmes.Clear();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string query = "SELECT IdFilme,Titulo,IdGenero FROM Filmes";
                con.Open();
                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        FilmeDomain filme = new FilmeDomain
                        {
                            IdFilme = Convert.ToInt32(sdr["IdFilme"]),
                            Titulo = sdr["Titulo"].ToString(),
                            IdGenero = Convert.ToInt32(sdr["IdGenero"])
                        };
                        ListaDeFilmes.Add(filme);
                    }
                }
                //con.Close();
            }
            return ListaDeFilmes;
        }
    }
}
