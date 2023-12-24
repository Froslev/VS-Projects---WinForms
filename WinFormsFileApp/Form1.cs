using System.IO;
using System.Reflection.Metadata;

namespace WinFormsFileApp
{
    public partial class FilhanteringsApp : Form
    {
        //private string filnamn = "anvandarinfo.txt";

        public FilhanteringsApp()
        {
            InitializeComponent();


        }


        private void label2_Click(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        string path = Environment.CurrentDirectory + "/" + "fil.txt";

        private void SkapaBtn_Click(object sender, EventArgs e)
        {
            //string path = Environment.CurrentDirectory + "/" + "filen.txt";

            if (!File.Exists(path)) // Kollar om filen redan finns
            {
                //Om filen ej finns så skapas en textfil & det skrivs ut att en fil har skapats i textBox rutan
                File.CreateText(path);
                textBox2.Text = "Filen är skapad!";
            }
        }

        // KOLLA VARFÖR DET EJ GÅR ATT FYLLA FILEN!!!!!

        private void FyllBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(first_name.Text);
                sw.WriteLine(last_name.Text);
                //sw.Close();
            }

            textBox2.Text = "Texten har lagts till i filen!..";  

        }


        private void LäsFilBtn_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(path)) 
            {

                //string text = sr.ReadLine();
                file_content.Text = sr.ReadToEnd(); 
                sr.Close();
            }


        }

        /*
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Ta bort filerna
            if (File.Exists(filnamn))
            {
                File.Delete(filnamn);
                textBox2.Text = "Filerna har tagits bort..";
            }

        }
        */

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}