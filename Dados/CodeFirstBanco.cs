using autenticacaoEfCookie.Models;

namespace autenticacaoEfCookie.Dados
{
    public class CodeFirstBanco
    {
        public static void Inicializar(AutenticacaoContext contexto){
            contexto.Database.EnsureCreated();

            var usuario = new Usuario(){
                Nome = "Alander",
                Email = "alandermm@hotmail.com",
                Senha = "123456"
            };

            contexto.Usuarios.Add(usuario);

            var permissao = new Permissao(){
                Nome = "Financeiro"
            };

            contexto.Permissoes.Add(permissao);

            var usuarioPermissao = new UsuarioPermissao(){
                IdUsuario = usuario.IdUsuario,
                IdPermissao = permissao.IdPermissao
            };

            contexto.UsuarioPermissoes.Add(usuarioPermissao);
            contexto.SaveChanges();
        }
    }
}