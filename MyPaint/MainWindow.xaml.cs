using Microsoft.Win32;
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
using System.IO;
using System.Windows.Ink;

namespace MyPaint
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
        //button-click event handler that presents the user with a File Save dialog box and saves the ink from an InkCanvas out to a file.
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (saveFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(saveFileDialog1.FileName,FileMode.Create);
                inkCanvas.Strokes.Save(fs);
                fs.Close();
            }
        }
        //button-click event handler that presents the user with a File Open dialog box and reads ink from the file into an InkCanvas element.
        private void btnLoad_Click(object sender, RoutedEventArgs e)
        {


           /* OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "isf files (*.isf)|*.isf";

            if (openFileDialog1.ShowDialog() == true)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName,FileMode.Open);
                inkCanvas.Strokes = new StrokeCollection(fs);
                fs.Close();
            }*/
        }
        // button-click event handler that clears InkCanvas element.
        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas.Strokes.Clear();
        }
    }
}
