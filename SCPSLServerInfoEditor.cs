using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using Microsoft.VisualBasic;
using Octokit;
using SCPSLServerInfoEditor.Properties;

namespace SCPSLServerInfoEditor
{
    public partial class SCPSLServerInfoEditor : Form
    {
        public SCPSLServerInfoEditor()
        {
            InitializeComponent();
            if(Settings.Default.Update) _ = lookForUpdates();

            Check_Updates_toolStripMenuItem.Checked = Settings.Default.Update;
        }

        private async Task lookForUpdates()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("SCP-SL-Serverinfo-Editor"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("Evitonative", "SCP-SL-Serverinfo-Editor");
            
            Version latestGitHubVersion = new Version(releases[0].TagName);
            Version localVersion = new Version(this.ProductVersion);
            
            int versionComparison = localVersion.CompareTo(latestGitHubVersion);
            if (versionComparison < 0)
            {
                //The version on GitHub is more up to date than this local release.
                var result = MessageBox.Show(
                    string.Format(Resources.ask_to_update, localVersion, latestGitHubVersion), 
                    Resources.update_available,
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );
                if (result == DialogResult.Yes)
                    Process.Start("https://github.com/Evitonative/SCP-SL-Serverinfo-Editor/releases/latest");
            }
        }

        private async void newToolStripButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(Resources.ask_to_save, "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await SaveFile();
                textBox.Clear();
            }
            else if (result == DialogResult.No)
            {
                textBox.Clear();
            }
        }

        private async void openToolStripButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                var result = MessageBox.Show(Resources.ask_to_save, Resources.open, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        await SaveFile();
                        textBox.Clear();
                        break;
                    case DialogResult.No:
                        textBox.Clear();
                        break;
                    default:
                        return;
                }
            }

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = Resources.open_file;
            //openFile.Filter = "Text file (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                textBox.Clear();
                using (StreamReader sr = new StreamReader(openFile.FileName))
                {
                    textBox.Text = await sr.ReadToEndAsync();
                    sr.Close();
                }
            }
        }

        private Task SaveFile()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = Resources.save_as;
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
            await SaveFile();
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

        private void linkToolTipButton_Click(object sender, EventArgs e)
        {
            string link = Interaction.InputBox("Enter your link", "Link...", "https://");
            if (link == "") return;
            String selected = textBox.SelectedText;
            if (selected == "") selected = link;
            selected = $"<link={link}>{selected}</link>";
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
                sizeToolStripTextBox.Text = Resources.size;
            }
        }

        private async void SCPSLServerInfoEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textBox.Text == "") return;
            var result = MessageBox.Show(Resources.save_exit, Resources.exit, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if ( result == DialogResult.Yes)
            {
                await SaveFile();
                e.Cancel = false;
            }
            else if (result == DialogResult.No)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }

        private void Check_Updates_toolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            if (Check_Updates_toolStripMenuItem.Checked) Settings.Default.Update = true;
            if (!Check_Updates_toolStripMenuItem.Checked) Settings.Default.Update = false;
            Settings.Default.Save();
        }
    }
}
