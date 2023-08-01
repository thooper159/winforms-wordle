namespace Wordle
{
    public partial class frmMain : Form
    {
        const int MAX_GUESSES = 6;
        int guesses = 0;
        string correctWord;

        public frmMain()
        {
            InitializeComponent();
            Random random = new Random();
            string wordsFileName = @"C:\Users\tyler\source\repos\Wordle\Wordle\words";

            //Load in words from file
            IEnumerable<string> wordFileLines = File.ReadLines(wordsFileName);
            string[] wordsArray = wordFileLines.ToArray();

            //Select a word randomly
            correctWord = wordsArray[random.Next(0, 499)];
            MessageBox.Show(correctWord);
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
            }
            else if (guesses == MAX_GUESSES)
            {
                MessageBox.Show("You lose :(");
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

            for (int i = 0; i < 5; i++)
            {
                //Correct letters are assigned 2
                if (guess[i] == correctWord[i])
                {
                    colors[i] = 2;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] != 2)
                {
                    if (correctWord.Contains(guess[i]) && Array.IndexOf(colors, 2) != i)
                    {
                        colors[i] = 1;
                    }
                }
            }

            return colors;
        }
    }
}