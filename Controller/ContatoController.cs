using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto_Agenda_Angelical;
using Projeto_Agenda_Angelical.Data;
using Projeto_Agenda_Angelical.GlobalVariable;

namespace Projeto_Agenda_Angelical.Controller
{
    internal class ContatoController
    {
        // ===================================== CRIA O CONTATO E COLOCA NA TABELA =======================================
        public bool CreateContato(string nome_contato, string telefone, int id_categoria)
        {
            MySqlConnection conexao = ConexaoDB.Connection(UserSession.Usuario, UserSession.Senha);

            conexao.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO tb_contatos (nome, telefone, categoria) VALUES (@nome_contato, @telefone, @id_categoria);", conexao);

                command.Parameters.AddWithValue("@nome_contato", nome_contato);
                command.Parameters.AddWithValue("@telefone", telefone);
                command.Parameters.AddWithValue("@id_categoria", id_categoria);

                int rowsAffected = 0;

                rowsAffected = command.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    return true;
                }
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

        // ===================================== DELETA O CONTATO DA TABELA =======================================
        public bool DeleteContato(int idContato)
        {
            MySqlConnection conexao = ConexaoDB.Connection(UserSession.Usuario, UserSession.Senha);

            conexao.Open();

            try
            {
                MySqlCommand cmdDelete = new MySqlCommand(
                    "DELETE FROM tb_contatos WHERE tb_contatos.id_contato = @id_contato;", conexao
                );

                cmdDelete.Parameters.AddWithValue("@id_contato", idContato);

                int rowsAffected = 0;
                rowsAffected = cmdDelete.ExecuteNonQuery();


                if (rowsAffected > 0)
                {
                    return true;
                }

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

        // ===================================== DANDO UPDATE NO NOME DO CONTATO =======================================
        public bool RenameContato(int idContato, string novoNome)
        {
            MySqlConnection conexao = ConexaoDB.Connection(UserSession.Usuario, UserSession.Senha);

            conexao.Open();

            try
            {
                MySqlCommand cmdUpdateNome = new MySqlCommand(
                    "UPDATE tb_contatos SET nome = @novo_nome WHERE id_contato = @id_contato", conexao);

                cmdUpdateNome.Parameters.AddWithValue("@novo_nome", novoNome);

                cmdUpdateNome.Parameters.AddWithValue("@id_contato", idContato);

                int rowsAffected = 0;

                rowsAffected = cmdUpdateNome.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }

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

        // ===================================== TABELA CONTATO =======================================
        public DataTable GetContatos()
        {

            MySqlConnection conexao = ConexaoDB.Connection(UserSession.Usuario, UserSession.Senha);

            conexao.Open();

            try
            {

                MySqlDataAdapter adpGetContatos = new MySqlDataAdapter(
                    "SELECT id_contato AS 'ID', nome AS 'Nome', telefone AS 'Telefone' FROM tb_contatos WHERE tb_contatos.usuario = SUBSTRING_INDEX(USER(), '@', 1);", conexao);

                // cria uma tabela vazia
                DataTable tabela = new DataTable();

                // preenche ela
                adpGetContatos.Fill(tabela);

                return tabela;

            }

            catch (Exception)
            {
                return new DataTable();
            }

            finally
            {
                conexao.Close();
            }

        }
    }
}
