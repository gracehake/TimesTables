using System;
using System.Drawing;
using System.IO;
using System.Security.Principal;
using System.Windows.Forms;

namespace times_tables
{
    public partial class MainForm : Form
    {
        private string _path;
        private Equation _equation;
        private readonly LogFile _log;
        
        public MainForm()
        {
            try
            {
                _log = new LogFile(Path.Combine($"C:\\Users\\{WindowsIdentity.GetCurrent().Name.Split('\\')[1]}\\AppData\\Local\\Dad", "results.log"));
                _log.WriteLog("\n\nTime \tEquation \tResult \tAttempts \tAttemptsDetail");
            }
            catch
            {
                // Just suppress errors for now
            }
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            _equation = new Equation();
            equationTextBox.Text = _equation.Text;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (checkButton.Text.Equals("New"))
            {
                this.Controls.Clear();
                this.InitializeComponent();
                _equation = new Equation();
                equationTextBox.Text = _equation.Text;
                answerTextBox.Focus();
            }
            else
            {
                var parsed = int.TryParse(answerTextBox.Text, out var answer);

                if (parsed)
                {
                    _equation.MakeAttempt(answer);

                    if (_equation.IsCorrect)
                    {
                        answerTextBox.BackColor = Color.Chartreuse;
                        checkButton.Text = "New";
                        _log?.WriteLog(_equation.Statistics());
                    }
                    else
                    {
                        answerTextBox.BackColor = Color.Crimson;
                        answerTextBox.Text = string.Empty;
                    }
                }
                else
                {
                    MessageBox.Show($"What number is {answerTextBox.Text}?", "Huh?", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
            }
        }
    }
}
