using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TECNAS.Classes
{
    static class Global
    {
        static public class Diretorios
        {
            public static string myRoot = System.AppDomain.CurrentDomain.BaseDirectory.ToString();
            public static String dicionario = myRoot + "Recursos\\pt_BR.dic";
            public static String interfacesFile = myRoot + "Interfaces.txt";
            public static String interfaceAtiva = System.IO.File.ReadAllLines(interfacesFile)[0];
            public static String activePath = myRoot + interfaceAtiva;
            public static String frasesFile = myRoot + interfaceAtiva + "\\Frases.txt";
            public static String vozes = myRoot + "Vozes";
        }
        static public class Recursos
        {
            public static Locutor VozVirtual = new Locutor();
            public static AutocompleteMenuNS.AutocompleteMenu autoCompleteMenuDicionario = new AutocompleteMenuNS.AutocompleteMenu();
        }
    }
}
