using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace HelloWorld
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            this.btn1.Clicked += Btn1_Clicked;
        }

        private void Btn1_Clicked(object sender, EventArgs e)
        {
            this.text1.Text = "Clicked.";
        }
    }
}
