using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegexChecker
{
    public partial class RegexCheckerForm : Form
    {
        public List<Item> matches = new List<Item>();
        public List<string> expressions = new List<string>();
        ExpressionMatchesForm viewMatches = new ExpressionMatchesForm();

        public RegexCheckerForm() {
            InitializeComponent();
        }

        private void clearSelection() {
            // clear match
            contentBox.SelectionStart = 0;
            contentBox.SelectionLength = contentBox.Text.Length;
            contentBox.SelectionBackColor = Color.Transparent;
        }

        private void updateMatchesList() {
            foreach (Item match in matches) {
                matchesList.Items.Add(match.index + ": " + match.ToString());
            }
        }

        private MatchCollection getMatches(string content, string pattern, bool ignoreCase) {
            MatchCollection regexMatches;
            if (!ignoreCase) {
                regexMatches = Regex.Matches(content, regexBox.Text.ToString(), RegexOptions.Compiled);
            } else {
                regexMatches = Regex.Matches(content, regexBox.Text.ToString(), RegexOptions.Compiled | RegexOptions.IgnoreCase);
            }
            return regexMatches;
        }

        private void findMatches() {
            // clear and set values
            matchesList.Items.Clear();
            matches.Clear();
            string content = contentBox.Text.ToString();
            string pattern = regexBox.Text.ToString();
            MatchCollection regexMatches = getMatches(content, pattern, ignoreCaseCheckbox.Checked);

            foreach (Match match in regexMatches) {
                matches.Add(new Item(match.Value, match.Index));
            }

            // higlight those
            for (int i = 0; i < matches.Count; i++) {
                contentBox.SelectionStart = matches[i].index;
                contentBox.SelectionLength = matches[i].value.Length;
                if (i % 2 == 0) {
                    contentBox.SelectionBackColor = Color.Yellow;
                } else {
                    contentBox.SelectionBackColor = Color.SkyBlue;
                }
            }

            // update box
            updateMatchesList();
        }

        private void loadMatches(bool append = false) {
            // clear if true
            if (!append) {
                expressions.Clear();
            }

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Text files|*.txt";
            openFile.Title = "Open Expression from Text File";
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK) {
                string line;
                System.IO.StreamReader file = new System.IO.StreamReader(openFile.FileName);
                while ((line = file.ReadLine()) != null) {
                    expressions.Add(line);
                }
                file.Close();
                viewMatches.updateList(expressions);
            }
        }

        private void matchesList_SelectedIndexChanged(object sender, EventArgs e) {
            // matchesList.SelectedIndex;
            if (matchesList.SelectedIndex != -1) {
                // clear selection
                clearSelection();

                // highlight match
                contentBox.SelectionStart = matches[matchesList.SelectedIndex].index;
                contentBox.SelectionLength = matches[matchesList.SelectedIndex].value.Length;
                contentBox.SelectionBackColor = Color.Yellow;
            }
        }

        private void findMatchesBtn_Click(object sender, EventArgs e) {
            clearSelection();
            findMatches();
        }

        private void loadExpressionToolStripMenu_Click(object sender, EventArgs e) {
            loadMatches();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            if (expressions.Count > 0) {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text file|*.txt";
                saveFile.Title = "Save Expression to File";
                DialogResult result = saveFile.ShowDialog();
                if (result == DialogResult.OK) {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFile.FileName)) {
                        foreach (string ex in expressions) {
                            file.WriteLine(ex);
                        }
                    }
                }
            } else {
                MessageBox.Show("No expressions; nothing to save!");
            }
        }

        private void saveExpressionBtn_Click(object sender, EventArgs e) {
            if (regexBox.Text.Length != 0) {
                expressions.Add(regexBox.Text.ToString());
                viewMatches.updateList(expressions);
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void viewMatchesToolStripMenuItem_Click(object sender, EventArgs e) {
            if (!viewMatches.Visible) {
                viewMatches.updateList(expressions);
                viewMatches.Show();
            } else {
                viewMatches.updateList(expressions);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            loadMatches(true);
        }


    }

    public class Item
    {
        public string value;
        public int index;

        public Item(string value, int index) {
            this.value = value;
            this.index = index;
        }

        public override string ToString() {
            return value.ToString();
        }
    }
}
