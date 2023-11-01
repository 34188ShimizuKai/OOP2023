using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ColorChecker {
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            DataContext = GetColorList();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
        }
        private void setColor() {
            Color color = Color.FromRgb((byte)redSlider.Value, (byte)greenSlider.Value, (byte)blueSlider.Value);
            SolidColorBrush brush = new SolidColorBrush(color);
            colorArea.Background = brush;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            setColor();
        }

        private MyColor[] GetColorList() {
            return typeof(Colors).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(i => new MyColor() { Color = (Color)i.GetValue(null), Name = i.Name }).ToArray();
        }

        private void colorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            var selectedColor = (MyColor)((ComboBox)sender).SelectedItem;
            var color = selectedColor.Color;
            var name = selectedColor.Name;
            colorArea.Background = new SolidColorBrush(color);

            redSlider.Value = (double)color.R;
            greenSlider.Value = (double)color.G;
            blueSlider.Value = (double)color.B;
        }
        private void stockButton_Click(object sender, RoutedEventArgs e) {
            string colorList = string.Format("R={0} G={1} B={2}",redSlider.Value,greenSlider.Value,blueSlider.Value);
            stockList.Items.Add(colorList);
        }

        private void stockList_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string[] split = stockList.SelectedItem.ToString().Split(' ', '=');
            redValue.Text = split[1];
            greenValue.Text = split[3];
            blueValue.Text = split[5];
        }
    }
    public class MyColor {
        public Color Color { get; set; }
        public string Name { get; set; }
    }
}