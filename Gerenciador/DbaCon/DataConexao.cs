using System;
using System.Data;
using System.IO;
using FirebirdSql.Data.FirebirdClient;
using System.Windows.Forms;


namespace DbaCon
{
    public class DataConexao
    {
        
        public FbConnection CriarConexao()
        {
            if (File.Exists(Directory.GetCurrentDirectory() + @"\gerenciador.ini"))
            {
                
            }
            else
            {
                MessageBox.Show("Arquivo gerenciador.ini Não Encontrado!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            /*if (File.Exists(File.ReadAllText(Directory.GetCurrentDirectory() + @"\gerenciador.ini")))
            {

            }
            else
            {
                MessageBox.Show("Base de Dados Não Encontrada!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            */

                string stringLocal = File.ReadAllText(Directory.GetCurrentDirectory() + @"\gerenciador.ini");
                       
                string stringdeConexao = "User=SYSDBA;" +
                     "Password=masterkey;" +
                     @"Database=" + stringLocal + ";" +
                     "Port=3050;" +
                     "Dialect=3;" +
                     "Charset=ISO8859_1;" +
                     "Role=;" +
                     "Connection lifetime=15;" +
                     "Pooling=false;" +
                     //     "MinPoolSize=0;" +
                     //     "MaxPoolSize=50;" +
                     "Packet Size=8192;" +
                     "ServerType=0";

            
            return new FbConnection(stringdeConexao);
        }

        private FbParameterCollection fbParameterCollection = new FbCommand().Parameters;

        public void LimparParametros()
        {
            fbParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            fbParameterCollection.Add(new FbParameter(nomeParametro, valorParametro));
        }
        public object ExecutarManipulacao(CommandType commandType, string nomeStoredProcedureouComandoTextoFBird)
        {
            try
            {
                FbConnection fbConnection = CriarConexao();
                fbConnection.Open();
                FbCommand fbCommand = fbConnection.CreateCommand();
                fbCommand.CommandType = commandType;
                fbCommand.CommandText = nomeStoredProcedureouComandoTextoFBird;
                fbCommand.CommandTimeout = 7200;

                foreach (FbParameter fbParameter in fbParameterCollection)
                {
                    fbCommand.Parameters.Add(new FbParameter(fbParameter.ParameterName, fbParameter.Value));
                }
                return fbCommand.ExecuteScalar();
                

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FbConnection fbConnection = CriarConexao();
                if (fbConnection != null)
                    ((IDisposable)fbConnection).Dispose();
            }

        }
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureouComandoTextoFBird)
        {
            try
            {
                FbConnection fbConnection = CriarConexao();
                fbConnection.Open();
                FbCommand fbCommand = fbConnection.CreateCommand();
                fbCommand.CommandType = commandType;
                fbCommand.CommandText = nomeStoredProcedureouComandoTextoFBird;
                fbCommand.CommandTimeout = 7200;

                foreach (FbParameter fbParameter in fbParameterCollection)
                {
                    fbCommand.Parameters.Add(new FbParameter(fbParameter.ParameterName, fbParameter.Value));
                }

                FbDataAdapter fbDataAdapter = new FbDataAdapter(fbCommand);
                DataTable dataTable = new DataTable();
                fbDataAdapter.Fill(dataTable);

                return dataTable;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                FbConnection fbConnection = CriarConexao();
                if (fbConnection != null)
                    ((IDisposable)fbConnection).Dispose();
                
            }
        }
    }

}
