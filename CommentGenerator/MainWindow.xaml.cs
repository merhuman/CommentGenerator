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

namespace CommentGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(Tb_InputBox.Text))
            {
                Tb_InputBox.Clear();
            }
            if(!string.IsNullOrEmpty(Tb_OutputBox.Text))
            {
                Tb_OutputBox.Clear();
            }
        }

        private void Btn_Preview_Click(object sender, RoutedEventArgs e)
        {
            string _outString = string.Empty;
            const int MAX_RANGE_OF_ROW = 50;

            if(!string.IsNullOrEmpty(Tb_InputBox.Text))
            {
                string _textClone = Tb_InputBox.Text;
                
                // Careful with this split, it depends on the order of \r and \n chars.
                List<string> _stringList = _textClone.Split(new [] { "\r\n" }, StringSplitOptions.None).ToList();

                _outString = "+" + string.Join(string.Empty, Enumerable.Repeat("-", MAX_RANGE_OF_ROW - 2)) + "+\n";
                _outString += string.Join("\n", _stringList.Select(str => "|"
                + str
                + string.Join(string.Empty, Enumerable.Repeat(" ", MAX_RANGE_OF_ROW - str.Length - 2))
                + "|")) + "\n";
                _outString += "+" + string.Join(string.Empty, Enumerable.Repeat("-", MAX_RANGE_OF_ROW - 2)) + "+\n";
            }

            Tb_OutputBox.Text = _outString;
        }

        private void Btn_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Tb_OutputBox.Text);
        }
    }
}
