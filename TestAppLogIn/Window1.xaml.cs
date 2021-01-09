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
        public List<Test> testList = new List<Test>();
        private int _numValue = 0;
        public Window1()
        {
            InitializeComponent();
            txtNum.Text = _numValue.ToString();
        }
        public int NumValue
        {
            get { return _numValue; }
            set
            {
                _numValue = value;
                txtNum.Text = value.ToString();
            }
        }
        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        private void txtNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum == null)
            {
                return;
            }

            if (!int.TryParse(txtNum.Text, out _numValue))
                txtNum.Text = _numValue.ToString();
        }
        public class Test
        {
            public int TestId { get; set; }
            public string TestText { get; set; }
            public List<Variant> Variants { get; set; }
        };
        public class Variant
        {
            public int VariantId { get; set; }
            public string VariantText { get; set; }
        };
        private void ButtonLogout_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
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
                    int i = 0;
                    while (text.Length > 0)
                    {
                        i++;
                        int beginningTest = text.IndexOf("" + i.ToString() + ". ");
                        if(beginningTest!=-1)
                        {
                            int endingTest = text.IndexOf("A)");
                            string test = text.Substring(beginningTest, endingTest - beginningTest);

                            bool space = true;
                            while (space)
                            {
                                char last = test[test.Length - 1];
                                if (last.ToString() == " " || last.ToString() == "\n" || last.ToString() == "\r")
                                {
                                    test = test.Remove(test.Length - 1);
                                }
                                else { space = false; }
                            }

                            int beginningVariantA = text.IndexOf("A)");
                            int endingVariantA = text.IndexOf("B)");
                            string variantA = text.Substring(beginningVariantA, endingVariantA - beginningVariantA);

                            int beginningVariantB = text.IndexOf("B)");
                            int endingVariantB = text.IndexOf("C)");
                            string variantB = text.Substring(beginningVariantB, endingVariantB - beginningVariantB);

                            int beginningVariantC = text.IndexOf("C)");
                            int endingVariantC = text.IndexOf("D)");
                            string variantC = text.Substring(beginningVariantC, endingVariantC - beginningVariantC);

                            int beginningVariantD = text.IndexOf("D)");
                            int endingVariantD = text.IndexOf((i + 1).ToString() + ". ");
                            
                            if (endingVariantD == -1)
                            {
                                endingVariantD = text.Length - 1;
                            }
                            string variantD = text.Substring(beginningVariantD, endingVariantD - beginningVariantD);

                            bool hasSpace = true;
                            while(hasSpace)
                            {
                                char last = variantD[variantD.Length - 1];
                                if (last.ToString() == " " || last.ToString() == "\n" || last.ToString() == "\r")
                                {
                                    variantD = variantD.Remove(variantD.Length - 1);
                                }
                                else { hasSpace = false; }
                            }
                            variantD = variantD + "     ";

                            List<Variant> listVariants = new List<Variant>();
                            Variant a = new Variant() { VariantId = 1, VariantText = variantA };
                            Variant b = new Variant() { VariantId = 2, VariantText = variantB };
                            Variant c = new Variant() { VariantId = 3, VariantText = variantC };
                            Variant d = new Variant() { VariantId = 4, VariantText = variantD };
                            listVariants.Add(a);
                            listVariants.Add(b);
                            listVariants.Add(c);
                            listVariants.Add(d);
                            Test newTest = new Test()
                            {
                                TestId = i,
                                TestText = test,
                                Variants = listVariants
                            };

                            testList.Add(newTest);

                            text = text.Substring(endingVariantD, text.Length - endingVariantD - 1);
                            richTextBox.AppendText(test+'\n');
                            richTextBox.AppendText(variantA);
                            richTextBox.AppendText(variantB);
                            richTextBox.AppendText(variantC);
                            richTextBox.AppendText(variantD+'\n');
                        }
                    }

                }
            }
        }
       
        public void Shuffle(object sender, RoutedEventArgs e)
        {

            pbStatus.Visibility = Visibility.Visible;
            richTextBox.Document.Blocks.Clear();
            int numberOfVariants = 0;
            for(numberOfVariants=0; numberOfVariants<_numValue; numberOfVariants++)
            {
                richTextBox.AppendText("Variant " + (numberOfVariants+1).ToString()+"\n\n");
                int a = 0;
                a = testList.Count();
                var rnd = new Random();
                var newList = testList.OrderBy(item => rnd.Next());
                int testNumber = 0;
                foreach (var item in newList)
                {
                    testNumber++;
                    string text = item.TestText.Substring(item.TestText.IndexOf(". "), item.TestText.Length - item.TestText.IndexOf(". "));
                    richTextBox.AppendText(testNumber.ToString() + text + "\n");
                    var newVariants = item.Variants.OrderBy(variant => rnd.Next());
                    int variantOrder = 0;
                    foreach (var variant in newVariants)
                    {
                        variantOrder++;
                        string variantText = variant.VariantText.Substring(2, variant.VariantText.Length - 2);
                        switch (variantOrder)
                        {
                            case 1:
                                variantText = "A)" + variantText;
                                break;
                            case 2:
                                variantText = "B)" + variantText;
                                break;
                            case 3:
                                variantText = "C)" + variantText;
                                break;
                            case 4:
                                variantText = "D)" + variantText;
                                break;
                            default:
                                variantText = "E)" + variantText;
                                break;
                        }
                        richTextBox.AppendText(variantText);
                    }
                    richTextBox.AppendText("\n\n");
                }
            }
            pbStatus.IsIndeterminate = false;
        }
        public void Download(object sender, RoutedEventArgs e)
        {
            Document document = new Document();

            string fullString = new System.Windows.Documents.TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd).Text;
            for(int i = 0; i<_numValue; i++)
            {
                int beginning = fullString.IndexOf("Variant " + (i + 1).ToString());
                int ending = fullString.IndexOf("Variant " + (i + 2).ToString());
                if(ending==-1)
                {
                    ending = fullString.Length;
                }
                string variant = fullString.Substring(beginning, ending - beginning);
                Section section = document.AddSection();

                Paragraph paragraph = section.AddParagraph();
                TextRange text = paragraph.AppendText(variant);
            }

            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DOCX (*.docx)|*.docx";

            if (saveFileDialog.ShowDialog() == true)
            {
                document.SaveToFile(saveFileDialog.FileName);
            }
        }
    }
}
