using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexChecker
{
    public partial class ExpressionMatchesForm : Form
    {
        public ExpressionMatchesForm() {
            InitializeComponent();
        }

        public void updateList(List<string> ex) {
            expressionsList.Items.Clear();
            expressionsList.Items.AddRange(ex.ToArray());
        }

        private void removeExpressionBtn_Click(object sender, EventArgs e) {
            RegexCheckerForm parent = Application.OpenForms["RegexCheckerForm"] as RegexCheckerForm;
            if (parent != null) {
                if (expressionsList.SelectedIndex != -1) {
                    // remove selection in original list
                    parent.expressions.RemoveAt(expressionsList.SelectedIndex);
                    updateList(parent.expressions);
                }
            }
        }

        private void loadExpressionBtn_Click(object sender, EventArgs e) {
            RegexCheckerForm parent = Application.OpenForms["RegexCheckerForm"] as RegexCheckerForm;
            if (parent != null) {
                if (expressionsList.SelectedIndex != -1) {
                    // remove selection in original list
                    parent.regexBox.Text = expressionsList.SelectedItem.ToString();
                }
            }
        }

        private void clearListBtn_Click(object sender, EventArgs e) {
            // clear listbox
            expressionsList.Items.Clear();
            RegexCheckerForm parent = Application.OpenForms["RegexCheckerForm"] as RegexCheckerForm;
            if (parent != null) {
                // remove selection in original list
                parent.expressions.Clear();
            }
        }

        private void ExpressionMatchesForm_FormClosing(object sender, FormClosingEventArgs e) {
            e.Cancel = true;
            this.Hide();
        }
    }
}
