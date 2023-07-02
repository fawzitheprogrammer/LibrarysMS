using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Settings
{
    public class settings
    {
        public static void createFile(string file, string ds, string db)
        {
            // C:\Users\SOFTWARE\Documents
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file;
            if (!File.Exists(path))
            {

                string s = "Data Source = " + ds + ";Initial Catalog=" + db + ";Integrated Security=true;MultipleActiveResultSets=true";
                //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SOFTWARE\source\repos\health_care_system\health_care_system\health_care_db.mdf;Integrated Security=True
                File.WriteAllText(path, s);
                MessageBox.Show("Settings saved successfully","success");
                
            }
        }
    }
}
