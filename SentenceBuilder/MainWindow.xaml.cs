using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SentenceBuilder
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		//Method to enable the verbs
		public void enable_verbs()
		{
			Throw_Verb.IsEnabled = true;
			Kick_Verb.IsEnabled = true;
			Kiss_Verb.IsEnabled = true;
			Eat_Verb.IsEnabled = true;
			Sing_Verb.IsEnabled = true;
			Yell_Verb.IsEnabled = true;
			Marry_Verb.IsEnabled = true;
		}

		//Method to enable the adjectives
		public void enable_adjectives()
		{
			Stinky_Adjective.IsEnabled = true;
			Sexy_Adjective.IsEnabled = true;
			Drunken_Adjective.IsEnabled = true;
			Ugly_Adjective.IsEnabled = true;
			Smart_Adjective.IsEnabled = true;
			Funny_Adjective.IsEnabled = true;
			Messy_Adjective.IsEnabled = true;
		}

		//Method to disable the verbs
		public void disable_verbs()
		{
			Throw_Verb.IsEnabled = false;
			Kick_Verb.IsEnabled = false;
			Kiss_Verb.IsEnabled = false;
			Eat_Verb.IsEnabled = false;
			Sing_Verb.IsEnabled = false;
			Yell_Verb.IsEnabled = false;
			Marry_Verb.IsEnabled = false;
		}

		//Method to disable the adjectives
		public void disable_adjectives()
		{
			Stinky_Adjective.IsEnabled = false;
			Sexy_Adjective.IsEnabled = false;
			Drunken_Adjective.IsEnabled = false;
			Ugly_Adjective.IsEnabled = false;
			Smart_Adjective.IsEnabled = false;
			Funny_Adjective.IsEnabled = false;
			Messy_Adjective.IsEnabled = false;
		}

		//Method to enable the nouns
		public void enable_nouns()
		{
			Pirate_Noun.IsEnabled = true;
			King_Noun.IsEnabled = true;
			Queen_Noun.IsEnabled = true;
			Doctor_Noun.IsEnabled = true;
			Magician_Noun.IsEnabled = true;
			Clown_Noun.IsEnabled = true;
			Zombie_Noun.IsEnabled = true;
		}

		//Method to disable the nouns
		public void disable_nouns()
		{
			Pirate_Noun.IsEnabled = false;
			King_Noun.IsEnabled = false;
			Queen_Noun.IsEnabled = false;
			Doctor_Noun.IsEnabled = false;
			Magician_Noun.IsEnabled = false;
			Clown_Noun.IsEnabled = false;
			Zombie_Noun.IsEnabled = false;
		}

		//This is the clear button. It will clear and reset the text box
		private void Clear_Click(object sender, RoutedEventArgs e)
		{
			Sentence_Box.Text = "";

			//Disable the Clear button
			Clear_Button.IsEnabled = false;

			//Enable the verbs
			enable_verbs();

			//Enable the adjectives
			enable_adjectives();

			//Disable the nouns
			disable_nouns();
		}


		//The code for the verbs is listed here

		//KICK
		private void Kick_Verb_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "Kick the";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Enable the Adjectives
				enable_adjectives();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " will get kicked to the curb.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();
			}
		}

		//KISS
		private void Kiss_Verb_Click(object sender, RoutedEventArgs e)
			{
				if (Clear_Button.IsEnabled == false)
				{
					Sentence_Box.Text = Sentence_Box.Text + "Kiss the";

					//Enable the Clear Button
					Clear_Button.IsEnabled = true;

					//Disable the Verbs
					disable_verbs();

					//Enable the Adjectives
					enable_adjectives();
				}
				else
				{
					Sentence_Box.Text = Sentence_Box.Text + " will be kissed passionately.";

					//Enable the Clear button
					Clear_Button.IsEnabled = true;

					//Disable the Verbs
					disable_verbs();

					//Disable the Adjectives
					disable_adjectives();
				}
			}

		//THROW
		private void Throw_Verb_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "Throw the";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Enable the Adjectives
				enable_adjectives();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " will be thrown off a cliff.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();
			}
		}

		//EAT
		private void Eat_Verb_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "Never eat an";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disble the Verbs
				disable_verbs();

				//Enable the Adjectives
				enable_adjectives();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " will eat anything.";
				
				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();
			}
		}

		//SING
		private void Sing_Verb_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = "Sing a song to the";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Enable the Adjectives
				enable_adjectives();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " won't sing to anyone.";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();
			}
		}

		//YELL
		private void Yell_Verb_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = "Yell at the";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Enable the Adjectives
				enable_adjectives();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " yells all the time.";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();
			}
		}

		//MARRY
		private void Marry_Verb_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = "Marry the";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Enable the Adjectives
				enable_adjectives();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " got married in a barn.";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				enable_adjectives();
			}
		}

		//The code for the adjectives is listed here

		//STINKY
		private void Stinky_Adjective_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "The stinky";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				enable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " stinky";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
		}

		//SEXY
		private void Sexy_Adjective_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "The sexy";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " sexy";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
		}

		//DRUNKEN
		private void Drunken_Adjective_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "The drunken";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " drunken";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
		}

		//UGLY
		private void Ugly_Adjective_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "The ugly";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " ugly";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_verbs();

				//Enable the Nouns
				enable_nouns();
			}
		}

		//SMART
		private void Smart_Adjective_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "The smart";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " smart";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
		}

		//FUNNY
		private void Funny_Adjective_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "The funny";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " funny";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
		}

		//MESSY
		private void Messy_Adjective_Click(object sender, RoutedEventArgs e)
		{
			if (Clear_Button.IsEnabled == false)
			{
				Sentence_Box.Text = Sentence_Box.Text + "The messy";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " messy";

				//Enable the clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Adjectives
				disable_adjectives();

				//Enable the Nouns
				enable_nouns();
			}
		}

		//Below are the Nouns
		//PIRATE
		private void Pirate_Noun_Click(object sender, RoutedEventArgs e)
		{
			if (Sentence_Box.Text.Contains("Kick") || Sentence_Box.Text.Contains("Kiss")
				|| Sentence_Box.Text.Contains("Throw") || Sentence_Box.Text.Contains("eat")
				|| Sentence_Box.Text.Contains("Sing") || Sentence_Box.Text.Contains("Yell")
				|| Sentence_Box.Text.Contains("Marr"))
			{
				Sentence_Box.Text = Sentence_Box.Text + " pirate.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " pirate";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Enable the Verbs
				enable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
		}

		//KING
		private void King_Noun_Click(object sender, RoutedEventArgs e)
		{
			if (Sentence_Box.Text.Contains("Kick") || Sentence_Box.Text.Contains("Kiss")
				|| Sentence_Box.Text.Contains("Throw") || Sentence_Box.Text.Contains("eat")
				|| Sentence_Box.Text.Contains("Sing") || Sentence_Box.Text.Contains("Yell")
				|| Sentence_Box.Text.Contains("Marr"))
			{
				Sentence_Box.Text = Sentence_Box.Text + " king.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " king";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Enable the Verbs
				enable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
		}

		//QUEEN
		private void Queen_Noun_Click(object sender, RoutedEventArgs e)
		{
			if (Sentence_Box.Text.Contains("Kick") || Sentence_Box.Text.Contains("Kiss")
				|| Sentence_Box.Text.Contains("Throw") || Sentence_Box.Text.Contains("eat")
				|| Sentence_Box.Text.Contains("Sing") || Sentence_Box.Text.Contains("Yell")
				|| Sentence_Box.Text.Contains("Marr"))
			{
				Sentence_Box.Text = Sentence_Box.Text + " queen.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " queen";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Enable the Verbs
				enable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
		}

		//DOCTOR
		private void Doctor_Noun_Click(object sender, RoutedEventArgs e)
		{
			if (Sentence_Box.Text.Contains("Kick") || Sentence_Box.Text.Contains("Kiss")
				|| Sentence_Box.Text.Contains("Throw") || Sentence_Box.Text.Contains("eat")
				|| Sentence_Box.Text.Contains("Sing") || Sentence_Box.Text.Contains("Yell")
				|| Sentence_Box.Text.Contains("Marr"))
			{
				Sentence_Box.Text = Sentence_Box.Text + " doctor.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " doctor";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Enable the Verbs
				enable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
		}

		//MAGICIAN
		private void Magician_Noun_Click(object sender, RoutedEventArgs e)
		{
			//deterine if a verb has already been used in the sentence
			if (Sentence_Box.Text.Contains("Kick") || Sentence_Box.Text.Contains("Kiss")
				|| Sentence_Box.Text.Contains("Throw") || Sentence_Box.Text.Contains("eat")
				|| Sentence_Box.Text.Contains("Sing") || Sentence_Box.Text.Contains("Yell")
				|| Sentence_Box.Text.Contains("Marr"))
			{
				Sentence_Box.Text = Sentence_Box.Text + " magician.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " magician";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Enable the Verbs
				enable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
		}

		//CLOWN
		private void Clown_Noun_Click(object sender, RoutedEventArgs e)
		{
			//deterine if a verb has already been used in the sentence
			if (Sentence_Box.Text.Contains("Kick") || Sentence_Box.Text.Contains("Kiss")
				|| Sentence_Box.Text.Contains("Throw") || Sentence_Box.Text.Contains("eat")
				|| Sentence_Box.Text.Contains("Sing") || Sentence_Box.Text.Contains("Yell")
				|| Sentence_Box.Text.Contains("Marr"))
			{
				Sentence_Box.Text = Sentence_Box.Text + " clown.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " clown";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Enable the Verbs
				enable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
		}

		//ZOMBIE
		private void Zombie_Noun_Click(object sender, RoutedEventArgs e)
		{
			//deterine if a verb has already been used in the sentence
			if(Sentence_Box.Text.Contains("Kick") || Sentence_Box.Text.Contains("Kiss")
				|| Sentence_Box.Text.Contains("Throw") || Sentence_Box.Text.Contains("eat")
				|| Sentence_Box.Text.Contains("Sing") || Sentence_Box.Text.Contains("Yell")
				|| Sentence_Box.Text.Contains("Marr"))
			{
				Sentence_Box.Text = Sentence_Box.Text + " zombie.";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Disable the Verbs
				disable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
			else
			{
				Sentence_Box.Text = Sentence_Box.Text + " zombie";

				//Enable the Clear button
				Clear_Button.IsEnabled = true;

				//Enable the Verbs
				enable_verbs();

				//Disable the Nouns
				disable_nouns();
			}
		}
	}
}
