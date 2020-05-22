using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Windows;
using System.Windows.Documents;

namespace Lorry.Helpers
{
    class SQLGet
    {
        class AddtoSQL
        {
            public static void GetInfo(string fullname)
            {
                string table = string.Empty;

                string mainWindow = MainWindow.TitleProperty.ToString();
                string coupletWindow = CoupletWindow.TitleProperty.ToString();

                if (WDWGet.windowName == coupletWindow)
                {
                    table = "Couplet";
                }

                try
                {
                    // Query.  
                    string query = "SELECT * FROM" + table +
                                   "WHERE(ABS(CAST(BINARY_CHECKSUM(*) *RAND()) as int)) % 100) < 10";

                    // Execute.  
                    SQLExecute.executeQuery(query);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
