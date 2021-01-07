using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;

namespace TestAppLogIn
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }
        public void LoadFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.DefaultExt = ".doc";
            dlg.Filter = "Word documents (.doc)|*.docx";
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                if (dlg.FileName.Length > 0)
                {
                    richTextBox.Document.Blocks.Clear();
                    //richTextBox.AppendText(dlg.FileName+"\n");
                    Document document = new Document();
                    document.LoadFromFile(dlg.FileName);
                    string text = document.GetText();
                    int i = 1;
                    while (text.Length > 0)
                    {
                        i++;
                        int beginningTest = text.IndexOf("" + i.ToString() + ". ");
                        int endingTest = text.IndexOf("A)");
                        string test = text.Substring(beginningTest, endingTest - beginningTest);
                        int beginningV = text.IndexOf("A)");
                        int endingV = text.IndexOf((i + 1).ToString() + ". ");
                        if (endingV == -1)
                        {
                            endingV = text.Length - 1;
                        }
                        string variants = text.Substring(beginningV, endingV - beginningV);

                        text = text.Substring(endingV, text.Length - endingV - 1);
                        richTextBox.AppendText(test + "\n");
                        richTextBox.AppendText(variants + "\n");

                    }

                }
            }
        }
        public void Shuffle(object sender, RoutedEventArgs e)
        {
        }
        public void Download(object sender, RoutedEventArgs e)
        {
            Document document = new Document();
            Spire.Doc.Section section = document.AddSection();
            Paragraph paragraph = section.AddParagraph();
            TextRange text = paragraph.AppendText("some");

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DOCX (*.docx)|*.docx";

            if (saveFileDialog.ShowDialog() == true)
            {
                document.SaveToFile(saveFileDialog.FileName);
            }
        }
    }
}
