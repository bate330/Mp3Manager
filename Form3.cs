using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mp3_player
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string link = @"D:/month/PlayerSets.txt";
            func.RichTextBox(link, richTextBox1);
        }
        bool tr = true;
        bool fa = false;
        static public string m1;
        static public string January1 = "D:\\month\\1\\1.txt";
        static public string January2 = "D:\\month\\1\\2.txt";
        static public string January3 = "D:\\month\\1\\3.txt";
        static public string February1 = "D:\\month\\2\\1.txt";
        static public string February2 = "D:\\month\\2\\2.txt";
        static public string February3 = "D:\\month\\2\\3.txt";
        static public string March1 = "D:\\month\\3\\1.txt";
        static public string March2 = "D:\\month\\3\\2.txt";
        static public string March3 = "D:\\month\\3\\3.txt";
        static public string April1 = "D:\\month\\4\\1.txt";
        static public string April2 = "D:\\month\\4\\2.txt";
        static public string April3 = "D:\\month\\4\\3.txt";
        static public string May1 = "D:\\month\\5\\1.txt";
        static public string May2 = "D:\\month\\5\\2.txt";
        static public string May3 = "D:\\month\\5\\3.txt";
        static public string June1 = "D:\\month\\6\\1.txt";
        static public string June2 = "D:\\month\\6\\2.txt";
        static public string June3 = "D:\\month\\6\\3.txt";
        static public string July1 = "D:\\month\\7\\1.txt";
        static public string July2 = "D:\\month\\7\\2.txt";
        static public string July3 = "D:\\month\\7\\3.txt";
        static public string August1 = "D:\\month\\8\\1.txt";
        static public string August2 = "D:\\month\\8\\2.txt";
        static public string August3 = "D:\\month\\8\\3.txt";
        static public string September1 = "D:\\month\\9\\1.txt";
        static public string September2 = "D:\\month\\9\\2.txt";
        static public string September3 = "D:\\month\\9\\3.txt";
        static public string October1 = "D:\\month\\10\\1.txt";
        static public string October2 = "D:\\month\\10\\2.txt";
        static public string October3 = "D:\\month\\10\\3.txt";
        static public string November1 = "D:\\month\\11\\1.txt";
        static public string November2 = "D:\\month\\11\\2.txt";
        static public string November3 = "D:\\month\\11\\3.txt";
        static public string December1 = "D:\\month\\12\\1.txt";
        static public string December2 = "D:\\month\\12\\2.txt";
        static public string December3 = "D:\\month\\12\\3.txt";
        static public string Pos1 = "1. position";
        static public string Pos2 = "2. position";
        static public string Pos3 = "3. position";
        static public string JanuaryFolder = "D:\\month\\1";
        static public string FebruaryFolder = "D:\\month\\2";
        static public string MarchFolder = "D:\\month\\3";
        static public string AprilFolder = "D:\\month\\4";
        static public string MayFolder = "D:\\month\\5";
        static public string JuneFolder = "D:\\month\\6";
        static public string JulyFolder = "D:\\month\\7";
        static public string AugustFolder = "D:\\month\\8";
        static public string SeptemberFolder = "D:\\month\\9";
        static public string OctoberFolder = "D:\\month\\10";
        static public string NovemberFolder = "D:\\month\\11";
        static public string DecemberFolder = "D:\\month\\12";
        functions func = new functions();

        public void Align4(Label b0, TextBox b1, TextBox b2, TextBox b3, bool b4)
        {
            b0.Visible = b4;
            b1.Visible = b4;
            b2.Visible = b4;
            b3.Visible = b4;
        }
        public void Align3(Label b0, Label b1, Label b2, bool b3)
        {
            b0.Visible = b3;
            b1.Visible = b3;
            b2.Visible = b3;
            plus1.Visible = b3;
            plus2.Visible = b3;
            plus3.Visible = b3;
            minus1.Visible = b3;
            minus2.Visible = b3;
            minus3.Visible = b3;
            add1.Visible = b3;
            add2.Visible = b3;
            add3.Visible = b3;
        }

        public void OpenMonth(Label l0, TextBox b1, TextBox b2, TextBox b3, Label l1, Label l2, Label l3,
            TextBox bb1, TextBox bb2, TextBox bb3, Label bl0,
            TextBox cb1, TextBox cb2, TextBox cb3, Label cl0,
            TextBox db1, TextBox db2, TextBox db3, Label dl0,
            TextBox eb1, TextBox eb2, TextBox eb3, Label el0,
            TextBox fb1, TextBox fb2, TextBox fb3, Label fl0,
            TextBox gb1, TextBox gb2, TextBox gb3, Label gl0,
            TextBox hb1, TextBox hb2, TextBox hb3, Label hl0,
            TextBox ib1, TextBox ib2, TextBox ib3, Label il0,
            TextBox jb1, TextBox jb2, TextBox jb3, Label jl0,
            TextBox kb1, TextBox kb2, TextBox kb3, Label kl0,
            TextBox lb1, TextBox lb2, TextBox lb3, Label ll0)
        {
            if (l0.Visible == true)
            {
                Align4(l0, b1, b2, b3, fa);
                Align3(l1, l2, l3, fa);
            }
            else
            {
                Align4(l0, b1, b2, b3, tr);
                Align3(l1, l2, l3, tr);
            }
            Align4(bl0, bb1, bb2, bb3, fa);
            Align4(cl0, cb1, cb2, cb3, fa);
            Align4(dl0, db1, db2, db3, fa);
            Align4(el0, eb1, eb2, eb3, fa);
            Align4(fl0, fb1, fb2, fb3, fa);
            Align4(gl0, gb1, gb2, gb3, fa);
            Align4(hl0, hb1, hb2, hb3, fa);
            Align4(il0, ib1, ib2, ib3, fa);
            Align4(jl0, jb1, jb2, jb3, fa);
            Align4(kl0, kb1, kb2, kb3, fa);
            Align4(ll0, lb1, lb2, lb3, fa);
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            OpenMonth(january, january1, january2, january3, l1, l2, l3,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
                System.IO.Directory.CreateDirectory(JanuaryFolder);
                func.update(January1, Pos1, january1, plus1);
                func.update(January2, Pos2, january2, plus2);
                func.update(January3, Pos3, january3, plus3);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            OpenMonth(february, february1, february2, february3, l1, l2, l3,
                january1, january2, january3, january,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
                System.IO.Directory.CreateDirectory(FebruaryFolder);
            func.update(February1, Pos1, february1, plus1);
            func.update(February2, Pos2, february2, plus2);
            func.update(February3, Pos3, february3, plus3);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            OpenMonth(march, march1, march2, march3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(MarchFolder);
            func.update(March1, Pos1, march1, plus1);
            func.update(March2, Pos2, march2, plus2);
            func.update(March3, Pos3, march3, plus3);

        }
        private void Button11_Click(object sender, EventArgs e)
        {
            OpenMonth(august, august1, august2, august3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(AugustFolder);
            func.update(August1, Pos1, august1, plus1);
            func.update(August2, Pos2, august2, plus2);
            func.update(August3, Pos3, august3, plus3);
        }
        private void Button4_Click(object sender, EventArgs e)
        {
            OpenMonth(april, april1, april2, april3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(AprilFolder);
            func.update(April1, Pos1, april1, plus1);
            func.update(April2, Pos2, april2, plus2);
            func.update(April3, Pos3, april3, plus3);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            OpenMonth(may, may1, may2, may3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(MayFolder);
            func.update(May1, Pos1, may1, plus1);
            func.update(May2, Pos2, may2, plus2);
            func.update(May3, Pos3, may3, plus3);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            OpenMonth(june, june1, june2, june3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(JuneFolder);
            func.update(June1, Pos1, june1, plus1);
            func.update(June2, Pos2, june2, plus2);
            func.update(June3, Pos3, june3, plus3);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            OpenMonth(july, july1, july2, july3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(JulyFolder);
            func.update(July1, Pos1, july1, plus1);
            func.update(July2, Pos2, july2, plus2);
            func.update(July3, Pos3, july3, plus3);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            OpenMonth(september, september1, september2, september3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                october1, october2, october3, october,
                november1, november2, november3, november,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(SeptemberFolder);
            func.update(September1, Pos1, september1, plus1);
            func.update(September2, Pos2, september2, plus2);
            func.update(September3, Pos3, september3, plus3);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            OpenMonth(october, october1, october2, october3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                november1, november2, november3, november,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(OctoberFolder);
            func.update(October1, Pos1, october1, plus1);
            func.update(October2, Pos2, october2, plus2);
            func.update(October3, Pos3, october3, plus3);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            OpenMonth(november, november1, november2, november3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                december1, december2, december3, december);
            System.IO.Directory.CreateDirectory(NovemberFolder);
            func.update(November1, Pos1, november1, plus1);
            func.update(November2, Pos2, november2, plus2);
            func.update(November3, Pos3, november3, plus3);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            OpenMonth(december, december1, december2, december3, l1, l2, l3,
                january1, january2, january3, january,
                february1, february2, february3, february,
                march1, march2, march3, march,
                april1, april2, april3, april,
                may1, may2, may3, may,
                june1, june2, june3, june,
                july1, july2, july3, july,
                august1, august2, august3, august,
                september1, september2, september3, september,
                october1, october2, october3, october,
                november1, november2, november3, november);
            System.IO.Directory.CreateDirectory(DecemberFolder);
            func.update(December1, Pos1, december1, plus1);
            func.update(December2, Pos2, december2, plus2);
            func.update(December3, Pos3, december3, plus3);
        }

        public void AddPlusClick(string A, Label l, TextBox a)
        {
            if (l.Visible == true)
            {
                func.DeleteFile(A);
                func.update(A, Pos1, a, plus1);
                func.SaveFile(A);
                func.update(A, Pos1, a, plus1);
            }
        }
        public void RemoveMinusClick(string A, Label l, TextBox a)
        {
            if (l.Visible == true)
            {
                func.DeleteFile(A);
                func.update(A, Pos1, a, plus1);
            }
        }
        private void Plus1_Click(object sender, EventArgs e)
        {
            AddPlusClick(January1, january, january1);
            AddPlusClick(February1, february, february1);
            AddPlusClick(March1, march, march1);
            AddPlusClick(April1, april, april1);
            AddPlusClick(May1, may, may1);
            AddPlusClick(June1, june, june1);
            AddPlusClick(July1, july, july1);
            AddPlusClick(August1, august, august1);
            AddPlusClick(September1, september, september1);
            AddPlusClick(October1, october, october1);
            AddPlusClick(November1, november, november1);
            AddPlusClick(December1, december, december1);
        }

        private void Minus1_Click(object sender, EventArgs e)
        {
            RemoveMinusClick(January1, january, january1);
            RemoveMinusClick(February1, february, february1);
            RemoveMinusClick(March1, march, march1);
            RemoveMinusClick(April1, april, april1);
            RemoveMinusClick(May1, may, may1);
            RemoveMinusClick(June1, june, june1);
            RemoveMinusClick(July1, july, july1);
            RemoveMinusClick(August1, august, august1);
            RemoveMinusClick(September1, september, september1);
            RemoveMinusClick(October1, october, october1);
            RemoveMinusClick(November1, november, november1);
            RemoveMinusClick(December1, december, december1);
        }

        private void Plus2_Click(object sender, EventArgs e)
        {
            AddPlusClick(January2, january, january2);
            AddPlusClick(February2, february, february2);
            AddPlusClick(March2, march, march2);
            AddPlusClick(April2, april, april2);
            AddPlusClick(May2, may, may2);
            AddPlusClick(June2, june, june2);
            AddPlusClick(July2, july, july2);
            AddPlusClick(August2, august, august2);
            AddPlusClick(September2, september, september2);
            AddPlusClick(October2, october, october2);
            AddPlusClick(November2, november, november2);
            AddPlusClick(December2, december, december2);
        }

        private void Minus2_Click(object sender, EventArgs e)
        {
            RemoveMinusClick(January2, january, january2);
            RemoveMinusClick(February2, february, february2);
            RemoveMinusClick(March2, march, march2);
            RemoveMinusClick(April2, april, april2);
            RemoveMinusClick(May2, may, may2);
            RemoveMinusClick(June2, june, june2);
            RemoveMinusClick(July2, july, july2);
            RemoveMinusClick(August2, august, august2);
            RemoveMinusClick(September2, september, september2);
            RemoveMinusClick(October2, october, october2);
            RemoveMinusClick(November2, november, november2);
            RemoveMinusClick(December2, december, december2);
        }

        private void Plus3_Click(object sender, EventArgs e)
        {
            AddPlusClick(January3, january, january3);
            AddPlusClick(February3, february, february3);
            AddPlusClick(March3, march, march3);
            AddPlusClick(April3, april, april3);
            AddPlusClick(May3, may, may3);
            AddPlusClick(June3, june, june3);
            AddPlusClick(July3, july, july3);
            AddPlusClick(August3, august, august3);
            AddPlusClick(September3, september, september3);
            AddPlusClick(October3, october, october3);
            AddPlusClick(November3, november, november3);
            AddPlusClick(December3, december, december3);
        }
        private void Minus3_Click(object sender, EventArgs e)
        {
            RemoveMinusClick(January3, january, january3);
            RemoveMinusClick(February3, february, february3);
            RemoveMinusClick(March3, march, march3);
            RemoveMinusClick(April3, april, april3);
            RemoveMinusClick(May3, may, may3);
            RemoveMinusClick(June3, june, june3);
            RemoveMinusClick(July3, july, july3);
            RemoveMinusClick(August3, august, august3);
            RemoveMinusClick(September3, september, september3);
            RemoveMinusClick(October3, october, october3);
            RemoveMinusClick(November3, november, november3);
            RemoveMinusClick(December3, december, december3);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            LabelAdd.Visible = true;
            add.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            plus1.Visible = false;
            plus2.Visible = false;
            plus3.Visible = false;
            minus1.Visible = false;
            minus2.Visible = false;
            minus3.Visible = false;
            add1.Visible = false;
            add2.Visible = false;
            add3.Visible = false;
        }

        private void Button13_Click(object sender, EventArgs e) // OK
        {

            string LineReader = func.LineReaders(January1); // wczytaj tekst z linii tekstu
            string a = @"D:/month/PlayerSets.txt";
            func.AddButton(a, January1, january1, add);
            richTextBox1.Clear();
            func.RichTextBox(a, richTextBox1);


            LabelAdd.Visible = false;
                add.Visible = false;
                button13.Visible = false;
                button14.Visible = false;
                Align3(l1, l2, l3, tr);
            
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            LabelAdd.Visible = false;
            add.Visible = false;
            button13.Visible = false;
            button14.Visible = false;
            Align3(l1, l2, l3, tr);
        }

        private void Button15_Click_1(object sender, EventArgs e)
        {
            string a = @"D:/month/PlayerSets.txt";
            func.RemoveButton(a, textBox2);
            richTextBox1.Clear();
            func.RichTextBox(a, richTextBox1);
        }
    }
    }



