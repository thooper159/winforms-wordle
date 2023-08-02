using System;

namespace Wordle
{
    public partial class frmMain : Form
    {
        const int MAX_GUESSES = 6;
        int guesses;
        string correctWord;
        string[] wordsArray;
        Random random = new Random();


        public frmMain()
        {
            InitializeComponent();
            string wordsFileName = @"C:\Users\tyler\source\repos\Wordle\Wordle\words";

            //Load in words from file
            IEnumerable<string> wordFileLines = File.ReadLines(wordsFileName);
            wordsArray = wordFileLines.ToArray();
            setupGame();
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
            //Choose a new target word
            correctWord = wordsArray[random.Next(0, 499)];
            richTextBox1.Focus();
            return;
        }
        private void onGuess(Object sender, KeyPressEventArgs e)
        {

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
                MessageBox.Show("You Win!!");
                setupGame();
            }
            else if (guesses == MAX_GUESSES)
            {
                MessageBox.Show("You lose! The word was " + correctWord);
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
            int[] colors = { 0, 0, 0, 0, 0 };
            Dictionary<char, int> charsToUpdate = new Dictionary<char, int>();

            for (int i = 0; i < 5; i++)
            {
                //Correct letters are assigned 2
                if (guess[i] == correctWord[i])
                {
                    colors[i] = 2;
                    charsToUpdate.Add(guess[i], 2);
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] != 2)
                {
                    if (correctWord.Contains(guess[i]) && Array.IndexOf(colors, 2) != i)
                    {
                        colors[i] = 1;
                        charsToUpdate.Add(guess[i], 1);
                    }
                    else
                    {
                        charsToUpdate.Add(guess[i], 0);
                    }
                }
            }
            foreach (var kvp in charsToUpdate)
            {
                string letter = kvp.Key.ToString();
                int colorValue = kvp.Value;
                rtbUsedLetters.SelectionStart = rtbUsedLetters.Find(letter);
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
    }
}