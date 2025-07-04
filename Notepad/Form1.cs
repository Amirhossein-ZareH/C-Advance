using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;

namespace Notepad
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            if (change == true)
            {
                dr = MessageBox.Show("Do you want to save this progress?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                    richTextBox1.Text = "";
                    change = false;
                }
                else if (dr == DialogResult.No)
                {
                    richTextBox1.Text = "";
                    change = false;
                }
            }
            else
            {
                richTextBox1.Text = "";
                change = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult dr;

            if (change == true)
            {
                dr = MessageBox.Show("Do you want to save this progress?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    saveAsToolStripMenuItem_Click(null, null);
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName != "")
                    {
                        richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                        oldFile = openFileDialog1.FileName;
                        change = false;
                    }
                }

                else if (dr == DialogResult.No)
                {
                    openFileDialog1.ShowDialog();
                    if (openFileDialog1.FileName != "")
                    {
                        richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                        oldFile = openFileDialog1.FileName;
                        change = false;
                    }
                }
                else
                {
                    openFileDialog1.ShowDialog();
                    richTextBox1.Text = System.IO.File.ReadAllText(openFileDialog1.FileName);
                    oldFile = openFileDialog1.FileName;
                }
            }

        }

        bool change = false;
        string oldFile = "";

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (oldFile == "")
                saveAsToolStripMenuItem_Click(null, null);
            else
                System.IO.File.WriteAllText(oldFile, richTextBox1.Text);
            change = false;
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
                oldFile = saveFileDialog1.FileName;
                change = false;
            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about1 = new AboutBox1();
            about1.Show();
            // new AboutBox1.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            change = true;
            this.Text = "notepad.New";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            if (change == true)
            {
                dr = MessageBox.Show("Do you want to save this progress?", "Alert", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(null, null);
                }
                else if (dr == DialogResult.No)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Find(richTextBox1.Text,0);
        }
    }
}
