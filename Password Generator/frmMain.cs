using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class frmMain : Form
    {
        const int DIGITS = 10;
        const int LETTERS = 26;
        const int ALL_SYMBOLS = 32;
        const char SEPERATOR = '|';

        private struct Argument
        {
            public bool useDigits, useLower, useUpper, useSymbols, noRepeats, noAdjacents, charOnce;
            public decimal numOfChars, minDigits, minLower, minUpper, minSymbols;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Argument arg = new Argument();
            arg.charOnce = chkCharOnce.Checked;
            arg.minDigits = numericUpDownDigits.Value;
            arg.minLower = numericUpDownLower.Value;
            arg.minSymbols = numericUpDownSymbols.Value;
            arg.minUpper = numericUpDownUpper.Value;
            arg.noAdjacents = chkNoAdjacents.Checked;
            arg.noRepeats = chkNoRepeats.Checked;
            arg.numOfChars = numericUpDownChars.Value;
            arg.useDigits = chkDigits.Checked;
            arg.useLower = chkLowerCaseLetters.Checked;
            arg.useSymbols = chkSymbols.Checked;
            arg.useUpper = chkUpperCaseLetters.Checked;

            this.Cursor = Cursors.WaitCursor;
            workerGeneratePassword.RunWorkerAsync(arg);
            foreach (Control item in this.Controls)
            {
                if (!item.Equals(statusMain) && !item.Equals(menuMain))
                    item.Enabled = false;
            }
            settingsToolStripMenuItem.Enabled = false;
            copyToolStripMenuItem.Enabled = false;
        }

        private bool hasEnoughDigits(string s, int min)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (Char.IsDigit(s[i])) min--;
            }
            return (min <= 0);
        }

        private bool hasEnoughLowerCaseLetters(string s, int min)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (Char.IsLower(s[i])) min--;
            }
            return (min <= 0);
        }

        private bool hasEnoughUpperCaseLetters(string s, int min)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (Char.IsUpper(s[i])) min--;
            }
            return (min <= 0);
        }

        private bool hasEnoughSymbols(string s, int min, char[] symbols)
        {
            for (int i = s.Length - 1; i >= 0; i--)
            {
                if (symbols.Contains(s[i])) min--;
            }
            return (min <= 0);
        }

        private string generatePassword(char[] chars, ushort numOfChars, bool noRepeats, bool noAdjacents, bool charsOnceOnly)
        {
            int n = chars.Length - 1, randVal;
            Random rand = new Random();
            char[] password = new char[numOfChars];

            bool[] charUsed = new bool[n + 1]; // default: false

            randVal = rand.Next(n);
            password[0] = chars[randVal];
            charUsed[randVal] = true;
            Keyboard keyboard = new Keyboard(Properties.Settings.Default.KeyboardLayout);

            for (ushort i = 1; i < numOfChars; i++)
            {
                do
                {
                    if (workerGeneratePassword.CancellationPending) return "blahrg";

                    randVal = rand.Next(n);
                    password[i] = chars[randVal];
                }
                while ((charsOnceOnly && charUsed[randVal]) ||
                    (noRepeats && (password[i] == password[i - 1])) ||
                    (noAdjacents && keyboard.areAdjacent(password[i], password[i - 1])));

                charUsed[randVal] = true;
            }
            return toString(password);
        }

        private char[] generateCharArray(bool useDigits, bool useLowerCaseLetters, bool useUpperCaseLetter, bool useSymbols)
        {
            char[] chars = new char[DIGITS + 2 * LETTERS + ALL_SYMBOLS];
            int i = 0;
            char j = '\0';

            if (useDigits)
            {
                for (j = '0'; j <= '9'; j++, i++) chars[i] = j;
            }
            if (useLowerCaseLetters)
            {
                for (j = 'a'; j <= 'z'; j++, i++) chars[i] = j;
            }
            if (useUpperCaseLetter)
            {
                for (j = 'A'; j <= 'Z'; j++, i++) chars[i] = j;
            }
            if (useSymbols)
            {
                string symbols = Properties.Settings.Default.Symbols;

                for (int k = 0; k < symbols.Length; k++, i++)
                {
                    chars[i] = symbols[k];
                }
            }
            Array.Resize(ref chars, i + 1);

            return chars;
        }


        private string toString(char[] array)
        {
            int len = array.Length;
            string s = string.Empty;

            for (int i = 0; i < len; i++)
            {
                s += array[i];
            }
            return s;
        }

        public void chkCharsToUse_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Symbols.Length == 0)
            {
                chkSymbols.Checked = false;
                chkSymbols.Enabled = false;
            }
            else
            {
                chkSymbols.Enabled = true;
            }

            btnGenerate.Enabled = chkDigits.Checked || chkLowerCaseLetters.Checked || chkUpperCaseLetters.Checked || chkSymbols.Checked;
            chkCharOnce_CheckedChanged(null, null);

            numericUpDownDigits.Visible = chkDigits.Checked;
            if (!chkDigits.Checked) numericUpDownDigits.Value = 1;

            numericUpDownLower.Visible = chkLowerCaseLetters.Checked;
            if (!chkLowerCaseLetters.Checked) numericUpDownLower.Value = 1;

            numericUpDownUpper.Visible = chkUpperCaseLetters.Checked;
            if (!chkUpperCaseLetters.Checked) numericUpDownUpper.Value = 1;

            numericUpDownSymbols.Visible = chkSymbols.Checked;
            if (!chkSymbols.Checked) numericUpDownSymbols.Value = 1;

            numericUpDown_ValueChanged(null, null);

        }

        private void updateMaxMin(NumericUpDown n)
        {
            decimal valueBefore = n.Value;
            if (chkCharOnce.Checked)
            {
                n.Maximum = 0;
                if (chkDigits.Checked)
                {
                    n.Maximum += DIGITS;
                }
                if (chkLowerCaseLetters.Checked)
                {
                    n.Maximum += LETTERS;
                }
                if (chkUpperCaseLetters.Checked)
                {
                    n.Maximum += LETTERS;
                }
                if (chkSymbols.Checked)
                {
                    n.Maximum += Properties.Settings.Default.Symbols.Length;
                }
                if (n.Maximum == 0) n.Maximum++;
            }
            else
            {
                n.Maximum = 400;
            }
            n.Value = valueBefore;
        }

        private void chkCharOnce_CheckedChanged(object sender, EventArgs e)
        {
            decimal d;
            if (chkCharOnce.Checked)
            {
                d = numericUpDownDigits.Value;
                numericUpDownDigits.Maximum = DIGITS;
                numericUpDownDigits.Value = (d<DIGITS) ? d:DIGITS;

                d = numericUpDownLower.Value;
                numericUpDownLower.Maximum = LETTERS;
                numericUpDownLower.Value = (d < LETTERS) ? d : LETTERS;

                d = numericUpDownUpper.Value;
                numericUpDownUpper.Maximum = LETTERS;
                numericUpDownUpper.Value = (d < LETTERS) ? d : LETTERS;

                d = numericUpDownSymbols.Value;
                numericUpDownSymbols.Maximum = (Properties.Settings.Default.Symbols.Length == 0 ? 1 : Properties.Settings.Default.Symbols.Length);
                numericUpDownSymbols.Value = (d < Properties.Settings.Default.Symbols.Length) ? d : (Properties.Settings.Default.Symbols.Length == 0 ? 1 : Properties.Settings.Default.Symbols.Length);
            }
            else
            {
                foreach (var item in grpMinimums.Controls)
                {
                    d = ((NumericUpDown)item).Value;
                    ((NumericUpDown)item).Maximum = 100;
                    ((NumericUpDown)item).Value = d;
                }
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "") Clipboard.SetText(txtPassword.Text);
        }

        private void chkNoAdjacents_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoAdjacents.Checked)
            {
                chkNoRepeats.Checked = true;
                chkNoRepeats.Enabled = false;
            }
            else
            {
                chkNoRepeats.Checked = false;
                chkNoRepeats.Enabled = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmSettings().ShowDialog(this);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string charsToUse = string.Empty;
            foreach (Control item in grpCharsToUse.Controls)
            {
                charsToUse += ((CheckBox)item).Checked.ToString() + SEPERATOR;
            }
            charsToUse = charsToUse.Remove(charsToUse.Length - 1);

            string rules = string.Empty;
            foreach (Control item in pnlRules.Controls)
            {
                rules += ((CheckBox)item).Checked.ToString() + SEPERATOR;
            }
            rules = rules.Remove(rules.Length - 1);

            Properties.Settings.Default.CharsToUse = charsToUse;
            Properties.Settings.Default.Rules = rules;
            Properties.Settings.Default.NumberOfChars = numericUpDownChars.Value;
            Properties.Settings.Default.MinDigits = numericUpDownDigits.Value;
            Properties.Settings.Default.MinLower = numericUpDownLower.Value;
            Properties.Settings.Default.MinUpper = numericUpDownUpper.Value;
            Properties.Settings.Default.MinSymbols = numericUpDownSymbols.Value;
            Properties.Settings.Default.Save();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string[] stringArray = Properties.Settings.Default.CharsToUse.Split(SEPERATOR);
            int i = 0;
            foreach (Control item in grpCharsToUse.Controls)
            {
                ((CheckBox)item).Checked = Boolean.Parse(stringArray[i++]);
            }

            stringArray = Properties.Settings.Default.Rules.Split(SEPERATOR);
            i = 0;
            foreach (Control item in pnlRules.Controls)
            {
                ((CheckBox)item).Checked = Boolean.Parse(stringArray[i++]);
            }
            //numericUpDown_ValueChanged(null, null);
            numericUpDownDigits.Value = Properties.Settings.Default.MinDigits;
            numericUpDownLower.Value = Properties.Settings.Default.MinLower;
            numericUpDownUpper.Value = Properties.Settings.Default.MinUpper;
            numericUpDownSymbols.Value = Properties.Settings.Default.MinSymbols;
            numericUpDownChars.Value = Properties.Settings.Default.NumberOfChars == 0 ? 1 : Properties.Settings.Default.NumberOfChars;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (Control c in grpMinimums.Controls)
            {
                if (c.Visible)
                {
                    total += ((NumericUpDown)c).Value;
                }
            }
            numericUpDownChars.Minimum = total;

            total = 0;
            foreach (Control c in grpMinimums.Controls)
            {
                if (c.Visible)
                {
                    total += ((NumericUpDown)c).Maximum;
                }
            }
            numericUpDownChars.Maximum = total;
        }



        private void workerGeneratePassword_DoWork(object sender, DoWorkEventArgs e)
        {
            Argument arg = (Argument)e.Argument;

            char[] chars = generateCharArray(arg.useDigits, arg.useLower, arg.useUpper, arg.useSymbols);
            string password = generatePassword(chars, (ushort)arg.numOfChars, arg.noRepeats, arg.noAdjacents, arg.charOnce);

            char[] symbols = generateCharArray(false, false, false, true);

            while ((arg.useLower && !hasEnoughLowerCaseLetters(password, (int)arg.minLower)) ||
                  (arg.useUpper && !hasEnoughUpperCaseLetters(password, (int)arg.minUpper)) ||
                  (arg.useSymbols && !hasEnoughSymbols(password, (int)arg.minSymbols, symbols))||
                  (arg.useDigits && !hasEnoughDigits(password, (int)arg.minDigits)))
            {
                if (workerGeneratePassword.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                password = generatePassword(chars, (ushort)arg.numOfChars, arg.noRepeats, arg.noAdjacents, arg.charOnce);
            }
            e.Result = password;
        }

        private void workerGeneratePassword_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                txtPassword.Text = e.Result.ToString();
            }
            this.Cursor = Cursors.Default;
            foreach (Control item in this.Controls)
            {
                item.Enabled = true;
            }
            settingsToolStripMenuItem.Enabled = true;
            copyToolStripMenuItem.Enabled = true;
        }

        private void frmMain_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Escape && workerGeneratePassword.IsBusy)
            {
                workerGeneratePassword.CancelAsync();
            }
        }

        private void btnGenerate_EnabledChanged(object sender, EventArgs e)
        {
            if (workerGeneratePassword.IsBusy)
            {
                toolStripStatusLabel.Text = " Generating...  press Esc to stop";
                toolStripProgressBar.Visible = true;
            }
            else
            {
                toolStripProgressBar.Visible = false;
                if (((Control)sender).Enabled)
                    toolStripStatusLabel.Text = " Ready";
                else
                    toolStripStatusLabel.Text = " Select characters to use";
            }
        }
    }

    sealed class Keyboard
    {
        private char[,] mChars;
        private char[,] mAltChars;
        private Index2d mSize = new Index2d();

        struct Index2d
        {
            public short Row;
            public short Column;
        }

        public Keyboard(string layout)
        {
            switch (layout)
            {
                case "QWERTY":
                    mSize.Row = 4;
                    mSize.Column = 13;

                    mChars = new char[,] 
                    {
                        {'`','1','2','3','4','5','6','7','8','9','0','-','=', '\0'},
                        {'\0','q','w','e','r','t','y','u','i','o','p','[',']','\\'},
                        {'\0','a','s','d','f','g','h','j','k','l',';','\'','\0','\0'},
                        {'\0','z','x','c','v','b','n','m',',','.','/','\0','\0','\0'}
                    };
                    mAltChars = new char[,] 
                    {
                        {'~','!','@','#','$','%','^','&','*','(',')','_','+', '\0'},
                        {'\0','Q','W','E','R','T','Y','U','I','O','P','{','}','|'},
                        {'\0','A','S','D','F','G','H','J','K','L',':','"','\0','\0'},
                        {'\0','Z','X','C','V','B','N','M','<','>','?','\0','\0','\0'}
                    };
                    break;
            }
        }

        public bool areAdjacent(char c1, char c2)
        {
            Index2d index1 = indexOf(c1, mChars), index2 = indexOf(c2, mChars);
            if (index1.Column == -1 || index1.Row == -1)
            {
                index1 = indexOf(c1, mAltChars);
            }
            if (index2.Column == -1 || index2.Row == -1)
            {
                index2 = indexOf(c2, mAltChars);
            }

            // We will assume that both characters were found at this point

            bool sameKey = (index1.Column == index2.Column) && (index1.Row == index2.Row);
            short diffCol = abs(index1.Column, index2.Column);
            short diffRow = abs(index1.Row, index2.Row);

            return (diffCol <= 1 && diffRow <= 1);
        }

        private Index2d indexOf(char c, char[,] array)
        {
            Index2d index = new Index2d();
            index.Column = index.Row = -1;

            for (short i = 0; i < mSize.Row; i++)
                for (short j = 0; j < mSize.Column; j++)
                {
                    if (array[i, j] == c)
                    {
                        index.Row = i;
                        index.Column = j;
                        return index;
                    }
                }

            return index;
        }

        private short abs(short a, short b)
        {
            return (short)(a > b ? (a - b) : (b - a));
        }
    }
}
