namespace AnimalMatchingGame
{
    public partial class MainPage : ContentPage
    {
/*        int count = 0;    */

        public MainPage()
        {
            InitializeComponent();
        }

        private void PlayAgainButton_Clicked(object sender, EventArgs e)
        {
            
            AnimalButtons.IsVisible = true;
            PlayAgainButton.IsVisible = false;
            List<string> animalEmoji = [
                "🐙", "🐙",
                "🐡", "🐡",
                "🦔", "🦔",
                "🐘", "🐘",
                "🐳", "🐳",
                "🐪", "🐪",
                "🦕", "🦕",
                "🦘", "🦘"
            ];
            int counter = 1;
            foreach (var button in AnimalButtons.Children.OfType<Button>())
            {
                int index = Random.Shared.Next(animalEmoji.Count);
                
                string nextEmoji = animalEmoji[index];
                button.Text = nextEmoji;
                animalEmoji.RemoveAt(index);
                counter++;
                if (index==0 && counter<16)
                {
                    index += 1;
                }
                else if (counter>16)
                {
                    break;
                }

            }
 
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }


        /*        private void OnCounterClicked(object sender, EventArgs e)
                {
                    count++;

                    if (count == 1)
                        CounterBtn.Text = $"Clicked {count} time";
                    else
                        CounterBtn.Text = $"Clicked {count} times";

                    SemanticScreenReader.Announce(CounterBtn.Text);
                }
        */

    }

}
