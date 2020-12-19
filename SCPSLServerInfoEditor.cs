using System;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;

namespace SCPSLServerInfoEditor
{
    public partial class SCPSLServerInfoEditor : Form
    {
        public SCPSLServerInfoEditor()
        {
            InitializeComponent();
        }
        
        private async void newToolStripButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to safe?", "New...", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                await saveFile();
                textBox.Clear();
            }
            else if (result == DialogResult.No)
            {
                textBox.Clear();
            }
        }

        private async void openToolStripButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to safe?", "Open...", MessageBoxButtons.YesNoCancel);
            if (result == DialogResult.Yes)
            {
                await saveFile();
                textBox.Clear();
            }
            else if (result == DialogResult.No)
            {
                textBox.Clear();
            }
            else
            {
                return;
            }

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open a file...";
            //openFile.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox.Clear();
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    textBox.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private Task saveFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file as...";
            //saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtOutput = new StreamWriter(saveFile.FileName);
                txtOutput.Write(textBox.Text);
                txtOutput.Close();
            }
            return Task.CompletedTask;
        }
        
        private async void saveToolStripButton_Click(object sender, EventArgs e)
        {
            await saveFile();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Copy();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Cut();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Paste();
        }

        private void undoToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Undo();
        }

        private void redoToolStripButton_Click(object sender, EventArgs e)
        {
            textBox.Redo();
        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {
            String selected = textBox.SelectedText;
            selected = $"<b>{selected}</b>";
            textBox.SelectedText = selected;
        }

        private void italicToolStripButton_Click(object sender, EventArgs e)
        {
            String selected = textBox.SelectedText;
            selected = $"<i>{selected}</i>";
            textBox.SelectedText = selected;
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e)
        {
            String selected = textBox.SelectedText;
            selected = $"<u>{selected}</u>";
            textBox.SelectedText = selected;
        }

        private void changeColor(string color)
        {
            String selected = textBox.SelectedText;
            selected = $"<color={color}>{selected}</color>";
            textBox.SelectedText = selected;
        }
        
        private void aquacyanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("aqua");
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("black");
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("blue");
        }

        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("brown");
        }

        private void darkblueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("darkblue");
        }

        private void fuchsiamagentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("magenta");
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("green");
        }

        private void greyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("grey");
        }

        private void lightblueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("lightblue");
        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("lime");
        }

        private void navyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("navy");
        }

        private void oliveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("olive");
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("orange");
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("purple");
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("red");
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("silver");
        }

        private void tealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("teal");
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("white");
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeColor("yellow");
        }

        private void CustomColorToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string color = CustomColorToolStripTextBox.Text;
                changeColor(color);
            }
        }

        private void sizeToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                String selected = textBox.SelectedText;
                selected = $"<size={sizeToolStripTextBox.Text}>{selected}</size>";
                textBox.SelectedText = selected;
            }
        }
    }
}
