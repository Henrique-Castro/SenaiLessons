using Senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Filmes.WebApi.Repositories
{
    public class GeneroRepository
    {
        List<GeneroDomain> ListaDeGeneros = new List<GeneroDomain>();
        private string StringConexao = "Data Source=.\\SqlExpress;Initial Catalog=RoteiroFilmes;User Id=sa;Pwd=132;";

        public IEnumerable<GeneroDomain> Listar()
        {
            ListaDeGeneros.Clear();

            using (SqlConnection con = new SqlConnection(StringConexao))
            {
                string query = "SELECT IdGenero,Nome FROM Generos";
                con.Open();
                SqlDataReader sdr;

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
               
                    sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        GeneroDomain estilo = new GeneroDomain
                        {
                            IdGenero = Convert.ToInt32(sdr["IdGenero"]),
                            Nome = sdr["Nome"].ToString()
                        };
                        ListaDeGeneros.Add(estilo);
                    }
                }
                //con.Close();
            }
            return ListaDeGeneros;
        }
    }
}
