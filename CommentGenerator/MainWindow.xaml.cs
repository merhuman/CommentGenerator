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
using ProjectLibs;


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
                Generator.CommentType _type = (Generator.CommentType) Enum.Parse(typeof(Generator.CommentType), Cb_Type.Text);
                _outString = ProjectLibs.Generator.GenComment(_textClone, MAX_RANGE_OF_ROW, _type);
            }
            Tb_OutputBox.Text = _outString;
        }

        private void Btn_Copy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(Tb_OutputBox.Text);
        }

        private void Btn_Test_Click(object sender, RoutedEventArgs e)
        {
            string upperA = @" ________     
|\   __  \    
\ \  \|\  \   
 \ \   __  \  
  \ \  \ \  \ 
   \ \__\ \__\
    \|__|\|__|";

            Console.WriteLine(upperA);
        }
    }
}
