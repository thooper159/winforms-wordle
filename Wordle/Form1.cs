using System;

namespace Wordle
{
    public partial class frmMain : Form
    {
        const int MAX_GUESSES = 6;
        const string savePath = @"C:\Users\tyler\source\repos\Wordle\Wordle\save";
        const string wordsFileName = @"C:\Users\tyler\source\repos\Wordle\Wordle\words";
        Random random = new Random();
        int guesses;
        string correctWord;
        string[] wordsArray;
        int wins = 0;
        int losses = 0;

        public frmMain()
        {
            InitializeComponent();
            //Load in words from file
            IEnumerable<string> wordFileLines = File.ReadLines(wordsFileName);
            wordsArray = wordFileLines.ToArray();
            setupGame();
            loadOutcome();
        }

        private void setupGame()
        {
            //Reset the textboxes
            RichTextBox[] richTextBoxes = { richTextBox1, richTextBox2, richTextBox3, richTextBox4, richTextBox5, richTextBox6 };
            foreach (RichTextBox richTextBox in richTextBoxes)
            {
                richTextBox.Text = "";
                richTextBox.ReadOnly = false;
            }

            //Reset the used letters
            rtbUsedLetters.SelectionBackColor = Color.LightGray;
            for (int i = 0; i < rtbUsedLetters.TextLength; i++)
            {
                //if current char is a letter, make light gray
                if (rtbUsedLetters.Text[i] != ' ')
                {
                    rtbUsedLetters.SelectionStart = i;
                    rtbUsedLetters.SelectionLength = 1;
                    rtbUsedLetters.SelectionBackColor = Color.LightGray;
                }
                //else, do not change anything
            }

            //Reset the guesses
            guesses = 0;
            loadOutcome();
            //Choose a new target word
            correctWord = wordsArray[random.Next(0, 499)];
            richTextBox1.Focus();
            return;
        }
        private void onGuess(Object sender, KeyPressEventArgs e)
        {
            //only allow Alphabet or Backspace
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);

            if (e.KeyChar != (char)Keys.Enter)
            {
                return;
            }

            string guess;

            if (sender is RichTextBox textBox)
            {
                guess = textBox.Text;
            }
            else
            {
                return;
            }

            if (guess.Length < 5)
            {
                return;
            }

            //increment guesses
            guesses++;

            int[] colors = getColors(guess);

            //recolor letters
            for (int i = 0;
                i < colors.Length; i++)
            {
                textBox.SelectionStart = i;
                textBox.SelectionLength = 1;
                switch (colors[i])
                {
                    case 0:
                        break;
                    case 1:
                        textBox.SelectionBackColor = Color.Yellow;
                        break;
                    case 2:
                        textBox.SelectionBackColor = Color.Green;
                        break;
                }
            }

            //make current textbox readonly 
            textBox.ReadOnly = true;

            if (guess == correctWord)
            {
                MessageBox.Show("You Win!");
                saveOutcome(1);
                setupGame();
            }
            else if (guesses == MAX_GUESSES)
            {
                MessageBox.Show("You lose!\nThe word was " + correctWord);
                saveOutcome(0);
                setupGame();
            }
            else
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private int[] getColors(string guess)
        {
            /*
                0 is incorrect letter
                1 is incorrect placement
                2 is correct letter

            */
            int[] colors = new int[5];
            Dictionary<char, int> charsToUpdate = new Dictionary<char, int>();

            for (int i = 0; i < 5; i++)
            {
                //Correct letters are assigned 2
                if (guess[i] == correctWord[i])
                {
                    colors[i] = 2;
                    charsToUpdate[guess[i]] = 2;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] != 2 && correctWord.Contains(guess[i]) && !charsToUpdate.ContainsKey(guess[i]))
                {
                    colors[i] = 1;
                    charsToUpdate[guess[i]] = 1;
                }
            }

            foreach (char letter in guess)
            {
                if (!charsToUpdate.ContainsKey(letter))
                {
                    charsToUpdate[letter] = 0;
                }
            }
            foreach (var kvp in charsToUpdate)
            {
                char letter = kvp.Key;
                int colorValue = kvp.Value;
                rtbUsedLetters.SelectionStart = rtbUsedLetters.Find(letter.ToString());
                rtbUsedLetters.SelectionLength = 1;
                switch (colorValue)
                {
                    case 0:
                        rtbUsedLetters.SelectionBackColor = Color.DarkSlateGray;
                        break;
                    case 1:
                        rtbUsedLetters.SelectionBackColor = Color.Yellow;
                        break;
                    case 2:
                        rtbUsedLetters.SelectionBackColor = Color.Green;
                        break;
                }

            }
            return colors;
        }
        private void saveOutcome(int outcome)
        {
            using (FileStream saveFileStream = File.Open(savePath, FileMode.Append))
            using (StreamWriter writer = new StreamWriter(saveFileStream))
            {
                writer.Write(outcome);
            }    
        }

        private void loadOutcome() {
            try
            {
                string content = File.ReadAllText(savePath);
                int wins = content.Count(c => c == '1');
                int losses = content.Count(c => c == '0');

                lblWins.Text = wins.ToString();
                lblLosses.Text = losses.ToString();
            }
            catch (IOException e)
            {
                lblWins.Text = "0";
                lblLosses.Text = "0";
            }
        }
    }
}