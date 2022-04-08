using System.Collections.Generic;
using System.Windows;

namespace WpfClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            using (ServiceReference1.Service1Client client = new ServiceReference1.Service1Client())
            {
                List<MusicClass> musicList = new List<MusicClass>();
                var musics = client.GetMusics();
                foreach (var music in musics)
                {
                    musicList.Add(new MusicClass(music.ID, music.AUTHOR, music.NAME, music.ALBOM, music.YEAR));
                }
                dgMusics.ItemsSource = musicList;
            }
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            RefreshDataGrid();
        }
    }
}
