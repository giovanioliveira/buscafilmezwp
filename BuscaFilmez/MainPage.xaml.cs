using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BuscaFilmez.Resources;
using BuscaFilmes.Classes;
using Newtonsoft.Json.Linq;

namespace BuscaFilmez
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }



        public void BuscarFilme()
        {
            WebClient filmeClient = new WebClient();

            filmeClient.DownloadStringCompleted += filmeClient_DownloadStringCompleted;

            filmeClient.DownloadStringCompleted += new DownloadStringCompletedEventHandler(filmeClient_DownloadStringCompleted);
            filmeClient.DownloadStringAsync(new Uri(@"http://www.omdbapi.com/?s=" + txt_filme.Text));

        }

        void filmeClient_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            try
            {
                botar_json(e.Result);
            }
            catch (Exception f)
            {
                
            }
          
        }

        public void botar_json(String json)
        {
            List<Filme> filmes = new List<Filme>();
            if (json != null)
            {

                JObject jobject = JObject.Parse(json);
                

                if (jobject.First.First.ToString() == "False")
                {
                    status.Text = "Não encontrou nenhum filme.";
                }
                else
                {
                    foreach (JObject item in jobject.First.First)
                    {
                        Filme fm = new Filme();
                        
                        fm.nome = ""+item["Title"];
                        fm.poster = "" + item["Poster"];
                        fm.ano = (int)item["Year"];
                        fm.imdbID = "" + item["imdbID"];
                        filmes.Add(fm);
                    }
                    status.Text = "Foram encontrados " + filmes.Count + " filme(s)";
                }
            }
            else
            {
                status.Text = "Erro ao procurar Filmes";
            }
            lista_filmes.ItemsSource = filmes;
   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BuscarFilme();
        }

        private void btn_salvar_Click(object sender, RoutedEventArgs e)
        {
            if (lista_filmes.SelectedItem != null)
            {
                Filme novo_filme = (Filme)lista_filmes.SelectedItem;
                Filme.Create(novo_filme);
                MessageBox.Show("filme foi salvo com sucesso");
            }
            else
            {
                MessageBox.Show("Por favor selecione um item");
            }
        }

        private void btn_meus_filmes_Click(object sender, RoutedEventArgs e)
        {
            navegar("/meus_filmes.xaml");
        }

        private void navegar(string pPage)
        {
            NavigationService.Navigate(new Uri(pPage, UriKind.Relative));
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}