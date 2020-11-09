using System;
using System.Windows;
using System.Windows.Controls;

namespace Ejercicio_13_Tema_3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = Grid;

            Button boton1 = new Button()
            {
                Tag = 1,
                Content = 1,
                 
                Style = (Style)this.Resources["botones"]
            };
            //Viewbox view = ((boton1.Content as ViewBox).Child as Label).Content = 1; En principio asi se meteria 
            Grid.Children.Add(boton1);
            Grid.SetRow(boton1, 2);
            Grid.SetColumn(boton1, 0);

            Button boton4 = new Button()
            {
                Tag= 4,
                Content = 4,
                Style = (Style)this.Resources["botones"]
            };
            Grid.Children.Add(boton4);
            Grid.SetRow(boton4, 3);
            Grid.SetColumn(boton4, 0);

            Button boton7 = new Button()
            {
                Tag = 7,
                Content = 7,
                Style = (Style)this.Resources["botones"]
            };
            Grid.Children.Add(boton7);
            Grid.SetRow(boton7, 4);
            Grid.SetColumn(boton7, 0);

            Button boton2 = new Button()
            {
                Tag = 2,
                Content = 2,
                Style = (Style)this.Resources["botones"]
            };
            Grid.Children.Add(boton2);
            Grid.SetRow(boton2, 2);
            Grid.SetColumn(boton2, 1);

            Button boton5 = new Button()
            {
                Tag = 5,
                Content = 5,
                Style = (Style)this.Resources["botones"]
            };
            Grid.Children.Add(boton5);
            Grid.SetRow(boton5, 3);
            Grid.SetColumn(boton5, 1);

            Button boton8 = new Button()
            {
                Tag = 8,
                Content = 8,
                Style = (Style)this.Resources["botones"]
            };
            Grid.Children.Add(boton8);
            Grid.SetRow(boton8, 4);
            Grid.SetColumn(boton8, 1);

            Button boton3 = new Button()
            {
                Tag = 3,
                Content = 3,
                Style = (Style)this.Resources["botones"]
            };
            Grid.Children.Add(boton3);
            Grid.SetRow(boton3, 2);
            Grid.SetColumn(boton3, 3);

            Button boton6 = new Button()
            {
                Tag = 6,
                Content = 6,
                Style = (Style)this.Resources["botones"]
            };
            Grid.Children.Add(boton6);
            Grid.SetRow(boton6, 3);
            Grid.SetColumn(boton6, 3);

            Button boton9 = new Button()
            {
                Tag = 9,
                Content = 9,
                Style = (Style)this.Resources["botones"]
            };
            Grid.Children.Add(boton9);
            Grid.SetRow(boton9, 4);
            Grid.SetColumn(boton9, 3);


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            EscribirTextBlock.Text = EscribirTextBlock.Text + Convert.ToString(boton.Tag);
        }

    }
}
