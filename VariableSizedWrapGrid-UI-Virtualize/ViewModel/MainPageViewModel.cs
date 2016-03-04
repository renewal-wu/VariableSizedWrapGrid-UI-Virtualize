using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VariableSizedWrapGrid_UI_Virtualize.Model;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace VariableSizedWrapGrid_UI_Virtualize.ViewModel
{
    public class MainPageViewModel
    {
        public ObservableCollection<TestData> SourceCollection { get; set; } = new ObservableCollection<TestData>();

        public MainPageViewModel()
        {
            InitialTestCollection();
        }

        private void InitialTestCollection()
        {
            var random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var r = random.Next(0, 255);
                var g = random.Next(0, 255);
                var b = random.Next(0, 255);

                var width = random.Next(0, 200);
                var height = random.Next(0, 100);

                SourceCollection.Add(new TestData()
                {
                    Title = i.ToString(),
                    Background = new SolidColorBrush(Color.FromArgb(0xFF, (byte)r, (byte)g, (byte)b)),
                    Width = width,
                    Height = height
                });
            }
        }
    }
}
