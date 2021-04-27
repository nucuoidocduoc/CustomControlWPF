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

namespace ExampleCustom
{
    /// <summary>
    /// Interaction logic for ColorPicker.xaml
    /// </summary>
    public partial class ColorPicker : UserControl
    {
        public static DependencyProperty ColorProperty;
        public static DependencyProperty RedProperty;
        public static DependencyProperty GreenProperty;
        public static DependencyProperty BlueProperty;

        static ColorPicker()
        {
            ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(ColorPicker), new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChanged)));
            RedProperty = DependencyProperty.Register(
                                                        "Red", typeof(byte), typeof(ColorPicker),
                                                        new FrameworkPropertyMetadata(
                                                        new PropertyChangedCallback(OnColorRGBChanged)));
            GreenProperty = DependencyProperty.Register(
                                                        "Green", typeof(byte), typeof(ColorPicker),
                                                        new FrameworkPropertyMetadata(
                                                        new PropertyChangedCallback(OnColorRGBChanged)));
            BlueProperty = DependencyProperty.Register(
                                                        "Blue", typeof(byte), typeof(ColorPicker),
                                                        new FrameworkPropertyMetadata(
                                                        new PropertyChangedCallback(OnColorRGBChanged)));
        }

        public ColorPicker()
        {
            InitializeComponent();
        }

        public Color Color
        {
            get => (Color)GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }

        public byte Red
        {
            get { return (byte)GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }

        public byte Green
        {
            get { return (byte)GetValue(GreenProperty); }
            set { SetValue(GreenProperty, value); }
        }

        public byte Blue
        {
            get { return (byte)GetValue(BlueProperty); }
            set { SetValue(BlueProperty, value); }
        }

        private static void OnColorRGBChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var colorPicker = (ColorPicker)sender;
            var color = colorPicker.Color;
            if (e.Property == RedProperty) {
                color.R = (byte)e.NewValue;
            }
            else if (e.Property == GreenProperty) {
                color.G = (byte)e.NewValue;
            }
            else if (e.Property == BlueProperty) {
                color.B = (byte)e.NewValue;
            }
            colorPicker.Color = color;
        }

        private static void OnColorChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            var newColor = (Color)e.NewValue;
            var oldColor = (Color)e.OldValue;

            var colorPicker = (ColorPicker)sender;
            colorPicker.Red = newColor.R;
            colorPicker.Green = newColor.G;
            colorPicker.Blue = newColor.B;
        }
    }
}