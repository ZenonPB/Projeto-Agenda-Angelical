using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Agenda_Angelical.GlobalVariable
{
    static public class UserSession
    {
        static private string _nome = null;
        static private string _senha = null;
        static private string _usuario = null;

        static public string Usuario
        {

            get
            {
                return _usuario;
            }

            set
            {
                _usuario = value.ToUpper();
            }

        }

        static public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                value = value.ToLower();
                _nome = value;
            }
        }

        static public string Senha
        {
            get
            {
                return _senha;
            }
            set
            {
                _senha = value;
            }
        }

        static private MySqlConnection _conexao = null;

        static public MySqlConnection Conexao
        {

            get
            {
                return _conexao;
            }

            set
            {
                _conexao = value;
            }

        }
    }
}

