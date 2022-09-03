using System;
using System.Data;
using DTO;
using DbaCon;

namespace BLL
{
    public class UsuariosNegocios
    {
        //Conexão Banco de Dados

        DataConexao dataConexao = new DataConexao();
        
        //Início Login Usuários

        public string ManterUsuarios(Usuarios usuarios)
        {
            try
            {
                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Acao", usuarios.Acao);
                dataConexao.AdicionarParametros("@Id_Usuario", usuarios.Id_Usuario);
                dataConexao.AdicionarParametros("@Nome_Usuario", usuarios.Nome_Usuario);
                dataConexao.AdicionarParametros("@Login", usuarios.Login);
                dataConexao.AdicionarParametros("@Senha", usuarios.Senha);
                dataConexao.AdicionarParametros("@Tipo", usuarios.TipoUsuario.Id_Tipo);
                
                string idUsuarios = dataConexao.ExecutarManipulacao(CommandType.StoredProcedure, "uspManterUsuario").ToString();

                return idUsuarios;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public UsuariosColecao ConsultarUsuariosPorNome(string usuario)
        {
            try
            {

                UsuariosColecao usuariosColecao = new UsuariosColecao();

                dataConexao.LimparParametros();
                dataConexao.AdicionarParametros("@Nome_Usuario", usuario);
                DataTable datatableUsuarios = dataConexao.ExecutarConsulta(CommandType.StoredProcedure, "uspConsultarUsuarioPorNome");

                foreach (DataRow linha in datatableUsuarios.Rows)
                {

                    Usuarios usuarios = new Usuarios();

                    usuarios.Id_Usuario = Convert.ToInt32(linha["Id_Usuario"]);
                    usuarios.Nome_Usuario = Convert.ToString(linha["Nome_Usuario"]);
                    usuarios.Login = Convert.ToString(linha["Login"]);
                    usuarios.Senha = Convert.ToString(linha["Senha"]);
                    
                    usuarios.TipoUsuario = new Tipo();

                    usuarios.TipoUsuario.Nome_Tipo = Convert.ToString(linha["Tipo"]);

                    usuariosColecao.Add(usuarios);

                }
                return usuariosColecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não Foi Possível Executar A Consulta. Detalhes: " + ex.Message);
            }
        }
        // Final Usuarios
        
    }
}
