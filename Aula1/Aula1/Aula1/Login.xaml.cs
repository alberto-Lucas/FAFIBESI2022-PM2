using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aula1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Clicked(object sender, EventArgs e)
        {
            if (ValidarLogin(txtUsuario.Text, txtSenha.Text))
            {
                var usuarioLogado = UsuarioLogado.Instancia;
                usuarioLogado.Nome = txtUsuario.Text;
                
                Navigation.PushModalAsync(new MainPage());

            }
            else
            {
                txtUsuario.Text = string.Empty;
                DisplayAlert("Atenção!", "Usuário ou Senha inválidos.", "Ok");
            }
        }

        bool ValidarLogin(string login, string senha)
        {
            return (login == "admin" && senha == "admin");
        }
    }
}