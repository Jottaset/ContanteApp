using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace Contante
{
    public partial class MainPage : ContentPage
    {
        int i = 1;
        int cont = 0;
        public MainPage()
        {

            InitializeComponent();

        }

        void ClicadaDoBotao(object sender, EventArgs e)
        {
            string C = cont + " vezes Clicado";
            if (i % 2 != 0)
            {
                label_status.Text = "VOCE CLICOU";
                button_meClica.Text = "CLICADO";
                label_status1.Text = C;
            }
            if (i % 2 == 0)
            {
                label_status.Text = "VAMOS NESSA";
                button_meClica.Text = "ME CLICA";
                label_status1.Text = C;
            }
            i++;
            cont++;
        }

    }
}
