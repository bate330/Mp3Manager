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
    class functions
    {
        public void open_button(string folder, TextBox text, Button add, Button delete, Button open)
        {
            text.Visible = true;
            add.Visible = true;
            delete.Visible = true;
            open.Visible = false;
            System.IO.Directory.CreateDirectory(folder);
        }
        public void update(string a1, string pos, TextBox t1, Button b1)
        {
            if (!File.Exists(a1))
            {
                t1.Text = pos; // uzupelnij textbox linijka z pliku
            }
            else
            {
                using (StreamReader sr = new StreamReader(a1))
                {
                    String line = sr.ReadToEnd();
                    t1.Text = line;
                }
            }
        }
        public void DeleteFile(string a1)
        {
            File.Delete(a1);
        }
        public void SaveFile(string a1)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {

                using (System.IO.StreamWriter ahh =
            new System.IO.StreamWriter(a1, true)) //stwórz plik o nazwie a1
                {
                    string SafeFile = file.SafeFileName; // zapisz do stringa nazwę pliku xxx.ext
                    string Title = Path.GetFileNameWithoutExtension(SafeFile); // usuń rozszerzenie .ext
                    ahh.WriteLine(Title); //zapisz do pliku tekstowego
                }
            }
        }
        public void SaveTreeViewFile(string a1)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter ahh =
            new System.IO.StreamWriter(a1, true)) //stwórz plik o nazwie mypath
                {
                    const string quote = "\"";
                    string TreeViewFile = file.FileName; // stwórz lokalizację pliku
                    ahh.WriteLine("@" + quote + TreeViewFile + quote); //zapisz do pliku tekstowego
                }
            }
        }

        public int StringToInt(string a1)
        {
            int i = 0;
            if (!Int32.TryParse(a1, out i))
            {
                i = -1;
            }

            return i;
        }
        public int LimitInclusive(int value, int min, int max)
        {
            return Math.Min(max, Math.Max(value, min));
        }

        public string LineReaders(string a)
        {
            using (StreamReader sr = new StreamReader(a))
            {
                string LineReader;
                string[] linesReader = File.ReadAllLines(a);
                LineReader = linesReader[0];
                return LineReader;
            }
           
        }
        public void RichTextBox(string a, RichTextBox r1)
        {
            if (!File.Exists(a))
            {
                using (StreamWriter sw = File.CreateText(a))
                {
                    
                }
            }
            string[] lines = File.ReadAllLines(a);
            for (int i = 0; i <= lines.Length - 1; i++)
            {
                string h = (i + 1).ToString();
                r1.AppendText(h + " " + lines[i] + "\n");
            }
        }

        public void RemoveButton(string l, TextBox tx)
        {
            if (string.IsNullOrEmpty(l))
            {
                MessageBox.Show("Input Value");
            }
            var file = new List<string>(System.IO.File.ReadAllLines(l));
            string[] lines = File.ReadAllLines(l);
            int a = StringToInt(tx.Text) - 1;
            if (a <= 0)
            {
                file.RemoveAt(0);
            }
            if (lines.Length > a && a >= 1)
            {
                file.RemoveAt(a);
            }
            else if (lines.Length <= 0)
            {

            }
            else if (lines.Length < a && lines.Length != 0)
            {
                file.RemoveAt(lines.Length - 1);
            }
            File.WriteAllLines(l, file.ToArray());
        }

        public void AddButton(string a, string b, TextBox tx, TextBox add) //OK a - link, tx - textbox pos, add - linijka
        {
            string[] ll = File.ReadAllLines(b);

            bool FileSize;
            if (new FileInfo(a).Length > 0)
            {
                FileSize = true;
            }
            else
                FileSize = false;

            if (!File.Exists(a) || !FileSize)
            {
                using (StreamWriter sw = File.CreateText(a))
                {
                    sw.WriteLine(ll[0]);
                }
            }
            else
            {
                int AddText = StringToInt(add.Text) - 1;
                int AddTextInt;
                string[] lines = File.ReadAllLines(a);
                if (AddText >= 0 && AddText <= lines.Length)
                    AddTextInt = AddText;
                else
                    AddTextInt = 0;
                string[] res = new string[lines.Length - AddTextInt];
                for (int i = 0; i <= res.Length - 1; i++)
                {
                    res[i] = lines[AddTextInt + i];
                }
                lines[AddTextInt] = ll[0];
                
                    int j = LimitInclusive(0, 0, lines.Length);
                    for (int i = AddTextInt + 1; i <= lines.Length - 1; i++, j++)
                    {
                        lines[i] = res[j];
                    }
               
                

                File.WriteAllLines(a, lines);
                using (StreamWriter w = File.AppendText(a))
                {
                    w.WriteLine(res[res.Length - 1]);
                }

            }
        }


    }
}
