using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using BuscaFilmes.Classes;
using Microsoft.Phone.Tasks;

namespace BuscaFilmez
{
    public partial class meus_filmes : PhoneApplicationPage
    {
        public meus_filmes()
        {
            InitializeComponent();
            lista_filmes.ItemsSource = Filme.Get();
        }

        private void btn_imdb_Click(object sender, RoutedEventArgs e)
        {
            if (lista_filmes.SelectedItem != null)
            {
                WebBrowserTask webBrowserTask = new WebBrowserTask();
                Filme selecionado = (Filme)lista_filmes.SelectedItem;
                webBrowserTask.Uri = new Uri("http://www.imdb.com/title/" + selecionado.imdbID, UriKind.Absolute);

                webBrowserTask.Show();
            }
        }

        

        private void btn_deletar_Click(object sender, RoutedEventArgs e)
        {
            if (lista_filmes.SelectedItem != null)
            {
                Filme.Delete((Filme)lista_filmes.SelectedItem);
                lista_filmes.ItemsSource = Filme.Get();
            }
            else
            {
                MessageBox.Show("Selecione um filme antes..");
            }
        }
    }
}