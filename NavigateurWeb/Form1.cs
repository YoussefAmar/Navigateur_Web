using System;
using System.Windows.Forms;

namespace NavigateurWeb
{
    public partial class Form : System.Windows.Forms.Form
    {

        string hel = "https://www.hel.be/";

        public Form()
        {          
            InitializeComponent();
            Explorer.ScriptErrorsSuppressed = true;
            Explorer.Url = new Uri(hel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnprecedent_Click(object sender, EventArgs e)
        {
            if(Explorer.CanGoBack)

            Explorer.GoBack();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if(Explorer.CanGoForward)

            Explorer.GoForward();
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            string page = tbRecherche.Text.Trim();

            if (!page.StartsWith("http://") && !page.StartsWith("https://"))
            {
                page = "http://" + page;
            }

            Explorer.Navigate(page);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Explorer.Navigate(hel);
        }
    }
}
