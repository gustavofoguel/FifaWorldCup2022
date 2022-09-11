using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabelaFifaWorldCup2022
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaJogos : ContentPage
    {
        public TelaJogos()
        {
            this.BindingContext = this;
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}