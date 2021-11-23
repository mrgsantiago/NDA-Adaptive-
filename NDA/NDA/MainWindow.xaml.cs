using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NDA
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        SolidColorBrush MainColor = new SolidColorBrush(Color.FromRgb(105, 149, 194));
        FontFamily MicrosoftSansSerif = new FontFamily("Microsoft Sans Serif");


        SolidColorBrush GrayColor = Brushes.Gray;

        private void MainGrid_Loaded(object sender, RoutedEventArgs e)
        {
            AddHeader();
            AddMainPart();
        }

        private void AddHeader()
        {
            DockPanel dockPanel = new DockPanel();
            StackPanel headPanel = new StackPanel();

            Border border = new Border
            {
                BorderBrush = MainColor,
                BorderThickness = new Thickness(0.5),
                Margin = new Thickness(Top = 4)
            };


            Button BtnBack = new Button
            {
                Width = 60,
                Height = 30,
                Content = "Back",
                Margin = new Thickness(0, 0, 20, 0),
                VerticalAlignment = VerticalAlignment.Center,
                BorderBrush = Brushes.DarkGray,
                BorderThickness = new Thickness(0.5),
                IsEnabled = false
            };

            Image lgImg = new Image
            {
                Source = new BitmapImage(new Uri("Resources/logo.jpg", UriKind.Relative)),
                Width = 50,
                Height = 50,
                VerticalAlignment = VerticalAlignment.Center
            };

            TextBlock MinHeader = new TextBlock
            {
                Text = "NBA Management System",
                FontFamily = new FontFamily("Calibri"),
                FontSize = 14,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = GrayColor
            };

            TextBlock Header = new TextBlock
            {
                Text = "Admin Login",
                FontFamily = new FontFamily("Calibri"),
                FontSize = 16,
                TextAlignment = TextAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                Margin = new Thickness(10, 0, 115, 0),
                Foreground = GrayColor
            };

            DockPanel.SetDock(lgImg, Dock.Left);
            DockPanel.SetDock(MinHeader, Dock.Left);
            DockPanel.SetDock(BtnBack, Dock.Right);
            DockPanel.SetDock(border, Dock.Bottom);
            dockPanel.Children.Add(lgImg);
            dockPanel.Children.Add(MinHeader);
            dockPanel.Children.Add(BtnBack);
            dockPanel.Children.Add(Header);
            DockPanel.SetDock(headPanel, Dock.Top);
            headPanel.Children.Add(dockPanel);
            headPanel.Children.Add(border);
            MainGrid.Children.Add(headPanel);
        }

        private void AddMainPart()
        {
            DockPanel PanelForInfotext = new DockPanel { Margin = new Thickness(0,70,0,0)};
            TextBlock InfoText = new TextBlock
            {
                FontFamily = MicrosoftSansSerif,
                FontSize = 16,
                Foreground = GrayColor,
                Text = "Users can login into the system using their jobnumber and password",
                TextAlignment = TextAlignment.Center
            };
            PanelForInfotext.Children.Add(InfoText);

            DockPanel PanelForFirstTextBox = new DockPanel { Margin = new Thickness(0, 40, 0, 0) };
            TextBlock JobNumberLab = new TextBlock
            {
                Text = "JobNumber:",
                FontFamily = MicrosoftSansSerif,
                FontSize = 14,
                Margin = new Thickness(0, 0, 10, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = GrayColor,
                HorizontalAlignment = HorizontalAlignment.Right,
                TextAlignment = TextAlignment.Right,

            };
            TextBox TxtJobNumber = new TextBox
            {
                Height = 27,
                FontSize = 14,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = GrayColor,
            };
            DockPanel ContainerFirst = new DockPanel {  MaxWidth = 350, MinWidth = 100 };
            ContainerFirst.Children.Add(JobNumberLab);
            ContainerFirst.Children.Add(TxtJobNumber);
            PanelForFirstTextBox.Children.Add(ContainerFirst);

            DockPanel PanelForSecondTextBox = new DockPanel { Margin = new Thickness(0, 20, 0, 0) };
            TextBlock Password = new TextBlock
            {
                Text = "Password:",
                FontFamily = MicrosoftSansSerif,
                FontSize = 14,
                Margin = new Thickness(0, 0, 20, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = GrayColor,
                HorizontalAlignment = HorizontalAlignment.Right,
                TextAlignment = TextAlignment.Right,

            };
            TextBox TxtPassword = new TextBox
            {
                Height = 27,
                FontSize = 14,
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = GrayColor,
            };
            DockPanel ContainerSecond = new DockPanel { MaxWidth = 350, MinWidth = 100 };
            ContainerSecond.Children.Add(Password);
            ContainerSecond.Children.Add(TxtPassword);
            PanelForSecondTextBox.Children.Add(ContainerSecond);

            DockPanel PanelforCheckBox = new DockPanel { Margin = new Thickness(0, 20, 0, 0) };
            DockPanel ContainerThird = new DockPanel { MaxWidth = 150, Margin = new Thickness(0, 0, 30, 0) };

            CheckBox checkBox = new CheckBox();
            TextBlock TxtForCheckBox = new TextBlock 
            {
                Text = "Remember me",
                FontFamily = MicrosoftSansSerif,
                FontSize = 14,
                Margin = new Thickness(5, 0, 0, 0),
                VerticalAlignment = VerticalAlignment.Center,
                Foreground = GrayColor,
                HorizontalAlignment = HorizontalAlignment.Left,
                TextAlignment = TextAlignment.Left,

            };
            ContainerThird.Children.Add(checkBox);
            ContainerThird.Children.Add(TxtForCheckBox);
            PanelforCheckBox.Children.Add(ContainerThird);

            DockPanel PanelforButtons = new DockPanel { Margin = new Thickness(0, 20, 0, 0) };
            Grid ContainerFourth = new Grid { MaxWidth = 300, Margin = new Thickness(80, 0, 0, 0)};
            
            Button BtnLogin = new Button
            {
                Content = "Login",
                Height = 30,
                Margin = new Thickness(0, 0, 0, 0),

            };

            Button BtnCancel = new Button
            {
                Content = "Cancel",
                Height = 30,
            };
            ContainerFourth.ColumnDefinitions.Add(new ColumnDefinition());
            ContainerFourth.ColumnDefinitions.Add(new ColumnDefinition());
            ContainerFourth.ColumnDefinitions.Add(new ColumnDefinition());
            ContainerFourth.RowDefinitions.Add(new RowDefinition());

            ContainerFourth.ColumnDefinitions[1].Width = new GridLength(30);

            Grid.SetColumn(BtnLogin, 0);
            Grid.SetRow(BtnLogin, 0);
            Grid.SetColumn(BtnCancel, 2);
            Grid.SetRow(BtnCancel, 0);
            ContainerFourth.Children.Add(BtnLogin);
            ContainerFourth.Children.Add(BtnCancel);
            PanelforButtons.Children.Add(ContainerFourth);

            StackPanel stkPanel = new StackPanel();

            stkPanel.Children.Add(PanelForInfotext);
            stkPanel.Children.Add(PanelForFirstTextBox);
            stkPanel.Children.Add(PanelForSecondTextBox);
            stkPanel.Children.Add(PanelforCheckBox);
            stkPanel.Children.Add(PanelforButtons);
            AddFooter();
            MainGrid.Children.Add(stkPanel);
        }

        private void AddFooter()
        {
            DockPanel dockPanel = new DockPanel { Background = MainColor, MinHeight = 20, MinWidth = 300 };
            DockPanel.SetDock(dockPanel, Dock.Bottom);
            TextBlock fterTxt = new TextBlock
            {
                Text = "The current season is 2016-2017, and the NBA already has a history of 71 years",
                TextAlignment = TextAlignment.Center,
                Foreground = Brushes.White
            };
            dockPanel.Children.Add(fterTxt);
            MainGrid.Children.Add(dockPanel);
        }
    }
}
