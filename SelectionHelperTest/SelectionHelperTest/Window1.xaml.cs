using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace SelectionHelperTest
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            for (int i = 1; i <= 10000; i++)
                listView.Items.Add(i);
            listView.View = (ViewBase)(listView.TryFindResource("GridView"));
            this.AddHandler(RadioButton.CheckedEvent, (RoutedEventHandler)delegate(object sender, RoutedEventArgs args)
            {
                string view = (((RadioButton)args.OriginalSource).Content as string);
                listView.View = (ViewBase)(listView.TryFindResource(view));
            });
        }
    }
}
