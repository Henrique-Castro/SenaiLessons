using System;
namespace desafioPizzaria {
    public class Usuario {
        //Modificador "STATIC" faz com que o objeto possa ser acessado de qualquer lugar sem instanciar
        public int Id { get; set; }
        public static int Contador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCriacao { get; set; }
        static Usuario[] arrayUsuarios = new Usuario[1000];

        public static void Inserir () {
            string nome, email, senha;
            Usuario usuario = new Usuario ();
            System.Console.Write ("Nome de usuário: ");
            nome = Console.ReadLine ();

            do {
                System.Console.Write ("Digite o Email: ");
                email = Console.ReadLine ();
                if (!email.Contains ("@") || !email.Contains (".")) {
                    System.Console.WriteLine ("Email inválido");
                }
            } while (!email.Contains ("@") || !email.Contains ("."));

            do {
                System.Console.Write ("Digite a senha: ");
                senha = Console.ReadLine ();
                if (senha.Length < 6) {
                    System.Console.WriteLine ("A senha deve conter mais de 6 caracteres");
                }
            } while (senha.Length < 6);

            usuario.Id = Contador + 1;
            usuario.Nome = nome;
            usuario.Email = email;
            usuario.Senha = senha;
            usuario.DataCriacao = DateTime.Now;

            arrayUsuarios[Contador] = usuario;
            Contador++;

        }
        public static void EfetuarLogin () {
            System.Console.WriteLine ("Digite seu email:");
            string email = Console.ReadLine ();
            System.Console.WriteLine ("Digite a senha: ");
            string senha = Console.ReadLine ();

            foreach (var usuario in arrayUsuarios) {
                if (usuario.Email.Equals (email) && usuario.Senha.Equals (senha)) {
                    System.Console.WriteLine ("Login efetuado com sucesso");
                    return;
                } else {
                    System.Console.WriteLine ("Usuário ou senha não encontrados");
                }

            }
        }

        public static void Listar () {

            foreach (var usuario in arrayUsuarios) {
                if (usuario != null) {
                    System.Console.WriteLine ("------------------------");
                    System.Console.WriteLine ($"Usuario {usuario.Id}");
                    System.Console.WriteLine ($"Nome {usuario.Nome}");
                    System.Console.WriteLine ($"Email: {usuario.Email}");
                    System.Console.WriteLine ("------------------------");
                }
            }
        }
    }
}