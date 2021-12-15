using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestEkzMDK0202;
using Word = Microsoft.Office.Interop.Word;

namespace TestEkzMDK0202
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = Convert.ToInt32(textBox1.Text);
            int kolvo = Convert.ToInt32(textBox2.Text);
            int summ = price * kolvo;
            label1.Text = summ.ToString();
            NewMethod(price, kolvo);


            var wordApp = new Word.Application();
            wordApp.Visible = false;
            try
            {
                var wordDoc = wordApp.Documents.Open(Environment.CurrentDirectory + "\\MyDoc.docx");
                repword("{Number}", price.ToString(), wordDoc);
                repword("{FIOclient}", kolvo.ToString(), wordDoc);
                repword("{Mail}", summ.ToString(), wordDoc);
                wordDoc.SaveAs(Environment.CurrentDirectory + "\\MyDocFinal.docx");
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Не удалось сформировать чек!");
            }
        }
        private void repword(string stupRp, string text, Word.Document wrorddocc)
        {
            var range = wrorddocc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stupRp, ReplaceWith: text);
        }

        public string NewMethod(int price, int kolvo)
        {
            try {
                if (price > 1234567 || kolvo > 1234567)
                {
                    throw new Exception("ERROR");
                }
                else if (price > 0 && kolvo > 0)
                {
                    return "Успешно";
                }
                else
                {
                    throw new Exception("ERROR");
                }
            }
            catch {
                throw new Exception("ERROR");
            }
        }
    }
}
