using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabelaFifaWorldCup2022
{
    public partial class MainPage : ContentPage
    {
        TelaJogos telaJogos;

        public MainPage()
        {
            this.BindingContext = this;
            InitializeComponent();
            telaJogos = new TelaJogos();
        }

        public bool TelaJogosConficao { get; set; }



        private async void BtnEntrarMenu(object sender, EventArgs e)
        {
            TelaJogosConficao = true;
            await Task.Delay(300);
            TelaJogosConficao = false;

            await Navigation.PushAsync(telaJogos);
        }
    }
}
