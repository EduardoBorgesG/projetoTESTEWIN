using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoTESTEWIN
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TelaInicial());
        }
        //DECLARAÇÃO DE VARIAVEL GLOBAL PARA GERAÇÃO DO RELATÓRIO

        public static string DataInicial;
        public static string DataFinal;

        //DECLARAÇÃO DE VARIAVEIS GLOBAIS PARA GERAÇÃO DO XML DE NASCIMENTO

        public static int idN;
        public static string nomeN;
        public static string dataN;
        public static string nomeP;
        public static string dataNP;
        public static string cpfP;
        public static string nomeM;
        public static string dataNM;
        public static string cpfM;
        public static string dataR;
    }
}
