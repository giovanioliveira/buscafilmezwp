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

namespace BuscaFilmez
{
    public partial class meus_filmes : PhoneApplicationPage
    {
        public meus_filmes()
        {
            InitializeComponent();
            lista_filmes.ItemsSource = Filme.Get();
        }
    }
}