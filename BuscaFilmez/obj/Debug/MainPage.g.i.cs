﻿#pragma checksum "C:\Users\Giovani-wp\documents\visual studio 2013\Projects\BuscaFilmez\BuscaFilmez\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "3D9A80F5802A61C77CCBAD18F567768C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace BuscaFilmez {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBox txt_filme;
        
        internal System.Windows.Controls.Button Button;
        
        internal System.Windows.Controls.TextBlock status;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.ListBox lista_filmes;
        
        internal System.Windows.Controls.Button btn_salvar;
        
        internal System.Windows.Controls.Button btn_meus_filmes;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/BuscaFilmez;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.txt_filme = ((System.Windows.Controls.TextBox)(this.FindName("txt_filme")));
            this.Button = ((System.Windows.Controls.Button)(this.FindName("Button")));
            this.status = ((System.Windows.Controls.TextBlock)(this.FindName("status")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.lista_filmes = ((System.Windows.Controls.ListBox)(this.FindName("lista_filmes")));
            this.btn_salvar = ((System.Windows.Controls.Button)(this.FindName("btn_salvar")));
            this.btn_meus_filmes = ((System.Windows.Controls.Button)(this.FindName("btn_meus_filmes")));
        }
    }
}

