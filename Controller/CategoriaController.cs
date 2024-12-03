using MySql.Data.MySqlClient;
using Projeto_Agenda_Angelical.Data;
using Projeto_Agenda_Angelical.GlobalVariable;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Angelical.Controller
{
    internal class CategoriaController
    {
        // ===================================== CRIA A CATEGORIA E COLOCA NA TABELA =======================================
        public bool CreateCategoria(string categoria)
        {
            MySqlConnection conexao = ConexaoDB.Connection(UserSession.Usuario, UserSession.Senha);

            conexao.Open();
            try
            {
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO tb_categorias (categoria) VALUES (@nome_categoria);", conexao);

                command.Parameters.AddWithValue("@nome_categoria", categoria);

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

        // ===================================== DELETA A CATEGORIA DA TABELA =======================================
        public bool DeleteCategoria(int idCategoria)
        {
            MySqlConnection conexao = ConexaoDB.Connection(UserSession.Usuario, UserSession.Senha);

            conexao.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(
                    "DELETE FROM tb_categorias WHERE tb_categorias.id_categoria = @id_categoria;", conexao);

                command.Parameters.AddWithValue("@id_categoria", idCategoria);

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

        // ===================================== DANDO UPDATE NO NOME DA CATEGORIA =======================================
        public bool RenameCategoria(int idCategoria, string novoNome)
        {
            MySqlConnection conexao = ConexaoDB.Connection(UserSession.Usuario, UserSession.Senha);

            conexao.Open();

            try
            {
                MySqlCommand command = new MySqlCommand(
                    "UPDATE tb_categorias SET categoria = @novo_nome WHERE id_categoria = @id_categoria",conexao);

                command.Parameters.AddWithValue("@novo_nome", novoNome);

                command.Parameters.AddWithValue("@id_categoria", idCategoria);

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

        // ===================================== TABELA CATEGORIA =======================================
        public DataTable GetCategorias()
        {

            MySqlConnection conexao = ConexaoDB.Connection(UserSession.Usuario, UserSession.Senha);

            conexao.Open();

            try
            {

                // Ponte entre a aplicação e a database, permite trabalhar com dados em memória (MySqlDataAdapter)
                MySqlDataAdapter adpGetCategorias = new MySqlDataAdapter(
                    "SELECT id_categoria AS 'ID', categoria AS 'Categoria' FROM tb_categorias WHERE tb_categorias.usuario = SUBSTRING_INDEX(USER(), '@', 1);",
                    conexao
                );

                // Cria uma tabela vazia
                DataTable tabela = new DataTable();

                // Preenche a tabela anteriormente criada
                adpGetCategorias.Fill(tabela);

                return tabela;

            }

            // Evitando Crash
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
