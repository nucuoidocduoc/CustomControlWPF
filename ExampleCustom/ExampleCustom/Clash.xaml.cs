using System;
using System.Windows;
using System.Windows.Controls;

namespace ExampleCustom
{
    /// <summary>
    /// Interaction logic for Clash.xaml
    /// </summary>
    public partial class Clash : UserControl
    {
        public static readonly DependencyProperty ClashTitleProperty;
        public static readonly DependencyProperty ToleranceProperty;
        public static readonly DependencyProperty ClashNameProperty;
        public static readonly DependencyProperty AssignProperty;
        public static readonly DependencyProperty GridLocationProperty;
        public static readonly DependencyProperty DateFoundProperty;
        public static readonly DependencyProperty StatusProperty;
        public static readonly DependencyProperty LastUpdateProperty;
        public static readonly DependencyProperty UpdateInfoProperty;

        public static readonly DependencyProperty ElementId1Property;
        public static readonly DependencyProperty Layer1Property;
        public static readonly DependencyProperty ItemType1Property;
        public static readonly DependencyProperty ItemName1Property;
        public static readonly DependencyProperty Path1Property;

        public static readonly DependencyProperty ElementId2Property;
        public static readonly DependencyProperty Layer2Property;
        public static readonly DependencyProperty ItemType2Property;
        public static readonly DependencyProperty ItemName2Property;
        public static readonly DependencyProperty Path2Property;

        public static readonly DependencyProperty CommentProperty;

        public static readonly RoutedEvent ZoomEvent;
        public static readonly RoutedEvent Show3DEvent;

        static Clash()
        {
            ClashTitleProperty = DependencyProperty.Register("ClashTitle", typeof(string), typeof(Clash));
            ToleranceProperty = DependencyProperty.Register("Tolerance", typeof(string), typeof(Clash));
            ClashNameProperty = DependencyProperty.Register("ClashName", typeof(string), typeof(Clash));
            AssignProperty = DependencyProperty.Register("Assign", typeof(string), typeof(Clash));
            GridLocationProperty = DependencyProperty.Register("GridLocation", typeof(string), typeof(Clash));
            DateFoundProperty = DependencyProperty.Register("DateFound", typeof(string), typeof(Clash));
            StatusProperty = DependencyProperty.Register("Status", typeof(string), typeof(Clash));
            LastUpdateProperty = DependencyProperty.Register("LastUpdate", typeof(string), typeof(Clash));
            UpdateInfoProperty = DependencyProperty.Register("UpdateInfo", typeof(string), typeof(Clash));
            ElementId1Property = DependencyProperty.Register("ElementId1", typeof(string), typeof(Clash));
            Layer1Property = DependencyProperty.Register("Layer1", typeof(string), typeof(Clash));
            ItemType1Property = DependencyProperty.Register("ItemType1", typeof(string), typeof(Clash));
            ItemName1Property = DependencyProperty.Register("ItemName1", typeof(string), typeof(Clash));
            Path1Property = DependencyProperty.Register("Path1", typeof(string), typeof(Clash));
            ElementId2Property = DependencyProperty.Register("ElementId2", typeof(string), typeof(Clash));
            Layer2Property = DependencyProperty.Register("Layer2", typeof(string), typeof(Clash));
            ItemType2Property = DependencyProperty.Register("ItemType2", typeof(string), typeof(Clash));
            ItemName2Property = DependencyProperty.Register("ItemName2", typeof(string), typeof(Clash));
            Path2Property = DependencyProperty.Register("Path2", typeof(string), typeof(Clash));

            CommentProperty = DependencyProperty.Register("Comment", typeof(string), typeof(Clash));

            ZoomEvent = EventManager.RegisterRoutedEvent("Zoom", RoutingStrategy.Bubble, typeof(EventHandler<RoutedEventArgs>), typeof(Clash));
            Show3DEvent = EventManager.RegisterRoutedEvent("Show3D", RoutingStrategy.Bubble, typeof(EventHandler<RoutedEventArgs>), typeof(Clash));
        }

        public Clash()
        {
            InitializeComponent();
        }

        public string ClashTitle
        {
            get => (string)GetValue(ClashTitleProperty);
            set => SetValue(ClashTitleProperty, value);
        }

        public string Tolerance
        {
            get => (string)GetValue(ToleranceProperty);
            set => SetValue(ToleranceProperty, value);
        }

        public string ClashName
        {
            get => (string)GetValue(ClashNameProperty);
            set => SetValue(ClashNameProperty, value);
        }

        public string Assign
        {
            get => (string)GetValue(AssignProperty);
            set => SetValue(AssignProperty, value);
        }

        public string GridLocation
        {
            get => (string)GetValue(GridLocationProperty);
            set => SetValue(GridLocationProperty, value);
        }

        public string DateFound
        {
            get => (string)GetValue(DateFoundProperty);
            set => SetValue(DateFoundProperty, value);
        }

        public string Status
        {
            get => (string)GetValue(StatusProperty);
            set => SetValue(StatusProperty, value);
        }

        public string LastUpdate
        {
            get => (string)GetValue(LastUpdateProperty);
            set => SetValue(LastUpdateProperty, value);
        }

        public string UpdateInfo
        {
            get => (string)GetValue(UpdateInfoProperty);
            set => SetValue(UpdateInfoProperty, value);
        }

        #region 1

        public string ElementId1
        {
            get => (string)GetValue(ElementId1Property);
            set => SetValue(ElementId1Property, value);
        }

        public string Layer1
        {
            get => (string)GetValue(Layer1Property);
            set => SetValue(Layer1Property, value);
        }

        public string ItemType1
        {
            get => (string)GetValue(ItemType1Property);
            set => SetValue(ItemType1Property, value);
        }

        public string ItemName1
        {
            get => (string)GetValue(ItemName1Property);
            set => SetValue(ItemName1Property, value);
        }

        public string Path1
        {
            get => (string)GetValue(Path1Property);
            set => SetValue(Path1Property, value);
        }

        #endregion 1

        #region 2

        public string ElementId2
        {
            get => (string)GetValue(ElementId2Property);
            set => SetValue(ElementId2Property, value);
        }

        public string Layer2
        {
            get => (string)GetValue(Layer2Property);
            set => SetValue(Layer2Property, value);
        }

        public string ItemType2
        {
            get => (string)GetValue(ItemType2Property);
            set => SetValue(ItemType2Property, value);
        }

        public string ItemName2
        {
            get => (string)GetValue(ItemName2Property);
            set => SetValue(ItemName2Property, value);
        }

        public string Path2
        {
            get => (string)GetValue(Path2Property);
            set => SetValue(Path2Property, value);
        }

        #endregion 2

        public string Comment
        {
            get => (string)GetValue(CommentProperty);
            set => SetValue(CommentProperty, value);
        }

        public event EventHandler<RoutedEventArgs> Zoom
        {
            add { AddHandler(ZoomEvent, value); }
            remove { RemoveHandler(ZoomEvent, value); }
        }

        public event EventHandler<RoutedEventArgs> Show3D
        {
            add { AddHandler(Show3DEvent, value); }
            remove { RemoveHandler(Show3DEvent, value); }
        }

        private void ButtonShow3D_Click(object sender, RoutedEventArgs e)
        {
            var arg = new RoutedEventArgs { RoutedEvent = Show3DEvent };
            RaiseEvent(arg);
        }

        private void ButtonZoom_Click(object sender, RoutedEventArgs e)
        {
            var arg = new RoutedEventArgs { RoutedEvent = ZoomEvent };
            RaiseEvent(arg);
        }

        private void ButtonComment_Click(object sender, RoutedEventArgs e)
        {
            var commentWindow = new Comment();
            commentWindow.txtComment.Text = Comment;
            commentWindow.ShowDialog();
            if (commentWindow.DialogResult == true) {
                Comment = commentWindow.txtComment.Text;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Path1);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Path2);
        }
    }
}