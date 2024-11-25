using MySql.Data.MySqlClient;
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
            MySqlConnection conexao = UserSession.Conexao;

            conexao.Open();

            try
            {
                MySqlCommand cmdInsertInto = new MySqlCommand(
                    "INSERT INTO tb_categorias (categoria) VALUES (@nome_categoria);",
                    conexao
                );

                cmdInsertInto.Parameters.AddWithValue("@nome_categoria", categoria);

                int rowsAffected = 0;

                // mostra em quantas linhas foi afetada
                rowsAffected = cmdInsertInto.ExecuteNonQuery();

                // ve se deu certo
                if (rowsAffected > 0)
                {
                    return true;
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

        // ===================================== DELETA A CATEGORIA DA TABELA =======================================
        public bool DeleteCategoria(string idCategoria)
        {
            MySqlConnection conexao = UserSession.Conexao;

            conexao.Open();

            try
            {
                MySqlCommand cmdDelete = new MySqlCommand(
                    "DELETE FROM tb_categorias WHERE tb_categorias.id_categoria = @id_categoria;",
                    conexao
                );

                cmdDelete.Parameters.AddWithValue("@id_categoria", idCategoria);

                int rowsAffected = 0;

                rowsAffected = cmdDelete.ExecuteNonQuery();

                // Sucesso, categoria excluida
                if (rowsAffected > 0)
                {
                    return true;
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

        // ===================================== DANDO UPDATE NO NOME DA CATEGORIA =======================================
        public bool RenameCategoria(string idCategoria, string novoNome)
        {
            MySqlConnection conexao = UserSession.Conexao;

            conexao.Open();

            try
            {
                MySqlCommand cmdUpdateNome = new MySqlCommand(
                    "UPDATE tb_categorias.categoria = @novo_nome ON tb_categorias WHERE tb_categorias.id_categoria = @id_categoria",
                    conexao
                );

                cmdUpdateNome.Parameters.AddWithValue("@novo_nome", novoNome);

                cmdUpdateNome.Parameters.AddWithValue("@id_categoria", idCategoria);

                int rowsAffected = 0;

                rowsAffected = cmdUpdateNome.ExecuteNonQuery();

                // Sucesso, nome da categoria alterado
                if (rowsAffected > 0)
                {
                    return true;
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

        // MUDAR DPSSSSSSSSSSSSSSDPSSSSSSSSSSSSSSDPSSSSSSSSSSSSSSDPSSSSSSSSSSSSSSDPSSSSSSSSSSSSSSDPSSSSSSSSSSSSSSDPSSSSSSSSSSSSSSDPSSSSSSSSSSSSSS
        public DataTable GetCategorias()
        {

            MySqlConnection conexao = UserSession.Conexao;

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
