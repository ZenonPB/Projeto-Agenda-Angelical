using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto_Agenda_Angelical.Data;
using Projeto_Agenda_Angelical.GlobalVariable;

namespace Projeto_Agenda_Angelical.Controller
{
    internal class UserController
    {
        // ===================================== CRIAR USUARIO NA DATABASE =======================================
        private bool CreateUserDB(string usuario, string senha)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
                conexao.Open();

                MySqlCommand cmdCreateUser = new MySqlCommand(
                   $@"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';
                      GRANT SELECT ON db_agenda.tb_categorias TO '{usuario}'@'%';",
                   conexao
                );

                cmdCreateUser.ExecuteNonQuery();

                // deu certo oba
                return true;
            }

            // nao da crash no programa
            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        // ===================================== CRIAR USUARIO NA TABELA DA DB =======================================
        public bool CreateUser(string anjo, string usuario, string senha, string telefone)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
                conexao.Open();

                MySqlCommand cmdInsertInto = new MySqlCommand(
                    "INSERT INTO tb_usuarios VALUES (@anjo, @usuario, @telefone, @senha);",
                    conexao
                );

                cmdInsertInto.Parameters.AddWithValue("@anjo", anjo);

                cmdInsertInto.Parameters.AddWithValue("@usuario", usuario);

                cmdInsertInto.Parameters.AddWithValue("@telefone", telefone);

                cmdInsertInto.Parameters.AddWithValue("@senha", senha);

                int rowsAffected = 0;

                // armazena quantas linhas foi afetada 
                rowsAffected = cmdInsertInto.ExecuteNonQuery();

                
                if (rowsAffected > 0)
                {
                    // cria o usuario
                    if (this.CreateUserDB(usuario, senha))
                    {
                        return true;
                    }

                    else
                    {
                        // deleta o usuario que deu errado, pra n ficar um "fantasma"
                        this.DeleteUser(usuario);

                        return false;
                    }
                }

                // Erro
                else
                {
                    return false;
                }
            }

            // Evitando Crash
            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        // ===================================== DELETA O USUARIO NA DB =======================================
        private bool DeleteUserDB(string usuario)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
                conexao.Open();

                // o comando pra deletar o usuario, seguido do padrão de usuario: USUARIO@xxxx;
                MySqlCommand cmdDeleteUserDB = new MySqlCommand(
                    $"DROP USER '{usuario}'@'%';",
                    conexao
                );

                cmdDeleteUserDB.ExecuteNonQuery();

                // deu tudo certo amem
                return true;
            }

            // Evitando Crash
            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        // ===================================== DELETA O USUARIO NA TABELA DA DB =======================================
        public bool DeleteUser(string usuario)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
                conexao.Open();

                MySqlCommand cmdDeleteUser = new MySqlCommand(
                    "DELETE FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario;",
                    conexao
                );

                cmdDeleteUser.Parameters.AddWithValue("@usuario", usuario);

                if (this.DeleteUserDB(usuario))
                {
                    cmdDeleteUser.ExecuteNonQuery();

                    return true;
                }

                else
                {
                    return false;
                }
            }

            // Evitando Crash
            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        // ===================================== ALTERA A SENHA DO USUARIO NA DATABASE =======================================
        private bool ModifySenhaDB(string usuario, string novaSenha)
        {
            MySqlConnection conexao = UserSession.Conexao;

            try
            {
                conexao.Open();

                MySqlCommand cmdModifySenhaDB = new MySqlCommand(
                    $"ALTER USER '{usuario}'@'%' IDENTIFIED BY '{novaSenha}'",
                    conexao
                );

                cmdModifySenhaDB.ExecuteNonQuery();

                return true;
            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        // ===================================== ALTERA A SENHA NA TABELA =======================================
        public bool ModifySenha(string usuario, string novaSenha)
        {
            MySqlConnection conexao = UserSession.Conexao;

            try
            {
                conexao.Open();

                MySqlCommand cmdModifySenha = new MySqlCommand(
                    "UPDATE tb_usuarios SET tb_usuarios.senha = @nova_senha WHERE tb_usuarios.usuario = @usuario",
                    conexao
                );

                cmdModifySenha.Parameters.AddWithValue("@usuario", usuario);

                cmdModifySenha.Parameters.AddWithValue("@nova_senha", novaSenha);

                int rowsAffected = 0;

                rowsAffected = cmdModifySenha.ExecuteNonQuery();

                // Sucesso, senha alterada
                if (rowsAffected > 0)
                {
                    this.ModifySenhaDB(usuario, novaSenha);

                    return true;
                }

                // Erro
                else
                {
                    return false;
                }
            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

        // ===================================== FAZ POSSÍVEL SER LOGAR =======================================
        public bool UserExists(string usuario, string senha)
        {
            MySqlConnection conexao = ConexaoDB.Connection();

            try
            {
                conexao.Open();

                MySqlCommand cmdVerificacao = new MySqlCommand(
                    "SELECT * FROM tb_usuarios WHERE tb_usuarios.usuario = @usuario AND BINARY tb_usuarios.senha = @senha;",
                    conexao
                );

                cmdVerificacao.Parameters.AddWithValue("@usuario", usuario);

                cmdVerificacao.Parameters.AddWithValue("@senha", senha);
                
                MySqlDataReader resultado = cmdVerificacao.ExecuteReader();

                if (resultado.Read())
                {
                    // preencher a user session com as infos do usuario
                    UserSession.Usuario = resultado.GetString("usuario");
                    UserSession.Nome = resultado.GetString("nome");
                    UserSession.Senha = resultado.GetString("senha");
                    UserSession.Telefone = resultado.GetString("telefone");
                    UserSession.AnjoGuarda = resultado.GetString("nome_anjo");

                    conexao.Close();
                    return true;
                }
                else
                {
                    conexao.Close();
                    return false;
                }

            }

            catch (Exception)
            {
                return false;
            }

            finally
            {
                conexao.Close();
            }
        }

    }
}
