namespace PokemonTypeCombos
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        //all pokemon types
        public enum PokemonTypes
        {
            Normal, Fighting, Flying, Poison,
            Ground, Rock, Bug, Ghost,
            Steel, Fire, Water, Grass,
            Electric, Psychic, Ice, Dragon,
            Dark, Fairy
        }
        //arrays to store each types attributes
        public float[] ArrOutput1 = new float[18];
        public float[] ArrOutput2 = new float[18];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbx2.Items.Add("None");
            //ease of use for users who want to type themselves
            cmbx1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbx2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            //adds all the types into the dropdown lists
            foreach (var item in Enum.GetNames<PokemonTypes>())
            {
                cmbx1.Items.Add(item);
                cmbx2.Items.Add(item);
             
            }
       
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //fills array values with defaut value of 1
            /*
             * number values in the array have meaning.
             * value 1 = normally effetive
             * value 2 = super effective
             * value 4 = 4x effective 
             * value 0.5 = not very effective
             * value 0.25 = extremely resistant
             */

            for (int i = 0; i < ArrOutput1.Length; i++)
            {
                ArrOutput1[i] = 1;
                ArrOutput2[i] = 1;
            }
            if (CatchErrors())
            {
                return;
            } 

            FindStrengthsAndWeaknesses(ArrOutput1, cmbx1.Text);
            FindStrengthsAndWeaknesses(ArrOutput2 , cmbx2.Text);
            DisplayInfo(); 
        }

        private void DisplayInfo()
        {
            string immune = "This typing is immune to: ";
            string resistant = "This typing is resistant against: ";
            string weak = "This typing is weak against: ";
            string neutral = "This typing is damaged normally by: ";
            int immunecount = 0;
            int resistantcount = 0;

            for (int i = 0; i < ArrOutput1.Length; i++)
            {
                ArrOutput1[i] = ArrOutput1[i] * ArrOutput2[i];

                switch (ArrOutput1[i])
                {
                    case 4:
                        weak += $" {(PokemonTypes)i}(Quad weakness), " ;
                        break;
                    case 2:
                        weak += $" {(PokemonTypes)i}, ";
                        break;
                    case 0.5f:
                        resistant += $" {(PokemonTypes)i}, ";
                        resistantcount++;
                        break;
                    case 0.25f:
                        resistant += $" {(PokemonTypes)i}, ";
                        resistantcount++;
                        break;
                    case 0f:
                        immune += $" {(PokemonTypes)i}, ";
                        immunecount++;
                        break;
                    case 1f:
                        neutral += $" {(PokemonTypes)i}, ";
                        break;
                    default:

                        break;
                }
            }//for 

            if (immunecount == 0)
            {
                immune += " None";
            }
            if (resistantcount == 0)
            {
                resistant += " None";
            }

            richtxtbx.Text = $"{immune}\n{resistant}\n{weak}\n{neutral}";
        }



        private Boolean CatchErrors()
        {   
            //catches errors made in the combobox which are mandatory for data processing
            if (cmbx1.SelectedIndex <= -1) 
            {
                MessageBox.Show("incorrect info in box1");
                return true;
            }

            if (cmbx2.SelectedIndex <= -1)
            {
                MessageBox.Show("incorrect info in box2");
                return true;
            }

            if (cmbx1.Text == cmbx2.Text)
            {
                MessageBox.Show("Cannot have same type twice");
                return true;
            }

            return false;
        }

        private void FindStrengthsAndWeaknesses(float[] ArrData, string textboxdata)
        {
            //each type has special attributes, this function assigns the properties according to the type the user has selected
            foreach (var item in Enum.GetValues<PokemonTypes>())
            {
                if (item.ToString() == textboxdata)
                {
                    switch (item)
                    {
                        case PokemonTypes.Normal:
                            ArrData[(int)PokemonTypes.Fighting] = 2f;
                            ArrData[(int)PokemonTypes.Ghost] = 0f;
                            break;
                        case PokemonTypes.Fighting:
                            ArrData[(int)PokemonTypes.Psychic] = 2f;
                            ArrData[(int)PokemonTypes.Flying] = 2f;
                            ArrData[(int)PokemonTypes.Fairy] = 2f;
                            ArrData[(int)PokemonTypes.Bug] = 0.5f;
                            ArrData[(int)PokemonTypes.Rock] = 0.5f;
                            ArrData[(int)PokemonTypes.Dark] = 0.5f;
                            break;
                        case PokemonTypes.Flying:
                            ArrData[(int)PokemonTypes.Electric] = 2f;
                            ArrData[(int)PokemonTypes.Ice] = 2f;
                            ArrData[(int)PokemonTypes.Rock] = 2f;
                            ArrData[(int)PokemonTypes.Grass] = 0.5f;
                            ArrData[(int)PokemonTypes.Fighting] = 0.5f;
                            ArrData[(int)PokemonTypes.Bug] = 0.5f;
                            ArrData[(int)PokemonTypes.Ground] = 0f;
                            break;
                        case PokemonTypes.Poison:
                            ArrData[(int)PokemonTypes.Ground] = 2f;
                            ArrData[(int)PokemonTypes.Psychic] = 2f;
                            ArrData[(int)PokemonTypes.Grass] = 0.5f;
                            ArrData[(int)PokemonTypes.Fighting] = 0.5f;
                            ArrData[(int)PokemonTypes.Poison] = 0.5f;
                            ArrData[(int)PokemonTypes.Bug] = 0.5f;
                            ArrData[(int)PokemonTypes.Fairy] = 0.5f;
                            break;
                        case PokemonTypes.Ground:
                            ArrData[(int)PokemonTypes.Water] = 2f;
                            ArrData[(int)PokemonTypes.Grass] = 2f;
                            ArrData[(int)PokemonTypes.Ice] = 2f;
                            ArrData[(int)PokemonTypes.Poison] = 0.5f;
                            ArrData[(int)PokemonTypes.Rock] = 0.5f;
                            ArrData[(int)PokemonTypes.Electric] = 0f;
                            break;
                        case PokemonTypes.Rock:
                            ArrData[(int)PokemonTypes.Water] = 2f;
                            ArrData[(int)PokemonTypes.Grass] = 2f;
                            ArrData[(int)PokemonTypes.Fighting] = 2f;
                            ArrData[(int)PokemonTypes.Ground] = 2f;
                            ArrData[(int)PokemonTypes.Steel] = 2f;
                            ArrData[(int)PokemonTypes.Normal] = 0.5f;
                            ArrData[(int)PokemonTypes.Fire] = 0.5f;
                            ArrData[(int)PokemonTypes.Poison] = 0.5f;
                            ArrData[(int)PokemonTypes.Flying] = 0.5f;
                            break;
                        case PokemonTypes.Bug:
                            ArrData[(int)PokemonTypes.Fire] = 2f;
                            ArrData[(int)PokemonTypes.Flying] = 2f;
                            ArrData[(int)PokemonTypes.Rock] = 2f;
                            ArrData[(int)PokemonTypes.Grass] = 0.5f;
                            ArrData[(int)PokemonTypes.Fighting] = 0.5f;
                            ArrData[(int)PokemonTypes.Ground] = 0.5f;
                            break;
                        case PokemonTypes.Ghost:
                            ArrData[(int)PokemonTypes.Dark] = 2f;
                            ArrData[(int)PokemonTypes.Ghost] = 2f;
                            ArrData[(int)PokemonTypes.Poison] = 0.5f;
                            ArrData[(int)PokemonTypes.Bug] = 0.5f;
                            ArrData[(int)PokemonTypes.Fighting] = 0f;
                            ArrData[(int)PokemonTypes.Normal] = 0f;
                            break;
                        case PokemonTypes.Steel:
                            ArrData[(int)PokemonTypes.Fire] = 2f;
                            ArrData[(int)PokemonTypes.Fighting] = 2f;
                            ArrData[(int)PokemonTypes.Ground] = 2f;
                            ArrData[(int)PokemonTypes.Normal] = 0.5f;
                            ArrData[(int)PokemonTypes.Grass] = 0.5f;
                            ArrData[(int)PokemonTypes.Ice] = 0.5f;
                            ArrData[(int)PokemonTypes.Flying] = 0.5f;
                            ArrData[(int)PokemonTypes.Psychic] = 0.5f;
                            ArrData[(int)PokemonTypes.Bug] = 0.5f;
                            ArrData[(int)PokemonTypes.Rock] = 0.5f;
                            ArrData[(int)PokemonTypes.Dragon] = 0.5f;
                            ArrData[(int)PokemonTypes.Steel] = 0.5f;
                            ArrData[(int)PokemonTypes.Fairy] = 0.5f;
                            ArrData[(int)PokemonTypes.Poison] = 0f;
                            break;
                        case PokemonTypes.Fire:
                            ArrData[(int)PokemonTypes.Water] = 2f;
                            ArrData[(int)PokemonTypes.Ground] = 2f;
                            ArrData[(int)PokemonTypes.Rock] = 2f;
                            ArrData[(int)PokemonTypes.Bug] = 0.5f;
                            ArrData[(int)PokemonTypes.Grass] = 0.5f;
                            ArrData[(int)PokemonTypes.Fire] = 0.5f;
                            ArrData[(int)PokemonTypes.Ice] = 0.5f;

                            break;
                        case PokemonTypes.Water:
                            ArrData[(int)PokemonTypes.Electric] = 2f;
                            ArrData[(int)PokemonTypes.Grass] = 2f;
                            ArrData[(int)PokemonTypes.Fire] = 0.5f;
                            ArrData[(int)PokemonTypes.Water] = 0.5f;
                            ArrData[(int)PokemonTypes.Ice] = 0.5f;
                            ArrData[(int)PokemonTypes.Steel] = 0.5f;
                            break;
                        case PokemonTypes.Grass:
                            ArrData[(int)PokemonTypes.Fire] = 2f;
                            ArrData[(int)PokemonTypes.Ice] = 2f;
                            ArrData[(int)PokemonTypes.Poison] = 2f;
                            ArrData[(int)PokemonTypes.Flying] = 2f;
                            ArrData[(int)PokemonTypes.Bug] = 2f;
                            ArrData[(int)PokemonTypes.Water] = 0.5f;
                            ArrData[(int)PokemonTypes.Electric] = 0.5f;
                            ArrData[(int)PokemonTypes.Grass] = 0.5f;
                            ArrData[(int)PokemonTypes.Ground] = 0.5f;
                            break;
                        case PokemonTypes.Electric:
                            ArrData[(int)PokemonTypes.Ground] = 2f;
                            ArrData[(int)PokemonTypes.Flying] = 0.5f;
                            ArrData[(int)PokemonTypes.Steel] = 0.5f;
                            ArrData[(int)PokemonTypes.Electric] = 0.5f;
                            break;
                        case PokemonTypes.Psychic:
                            ArrData[(int)PokemonTypes.Bug] = 2f;
                            ArrData[(int)PokemonTypes.Ghost] = 2f;
                            ArrData[(int)PokemonTypes.Dark] = 2f;
                            ArrData[(int)PokemonTypes.Psychic] = 0.5f;
                            ArrData[(int)PokemonTypes.Fighting] = 0.5f;
                            break;
                        case PokemonTypes.Ice:
                            ArrData[(int)PokemonTypes.Steel] = 2f;
                            ArrData[(int)PokemonTypes.Rock] = 2f;
                            ArrData[(int)PokemonTypes.Fire] = 2f;
                            ArrData[(int)PokemonTypes.Fighting] = 2f;
                            ArrData[(int)PokemonTypes.Ice] = 0.5f;
                            break;
                        case PokemonTypes.Dragon:
                            ArrData[(int)PokemonTypes.Dragon] = 2f;
                            ArrData[(int)PokemonTypes.Fairy] = 2f;
                            ArrData[(int)PokemonTypes.Ice] = 2f;
                            ArrData[(int)PokemonTypes.Fire] = 0.5f;
                            ArrData[(int)PokemonTypes.Water] = 0.5f;
                            ArrData[(int)PokemonTypes.Grass] = 0.5f;
                            ArrData[(int)PokemonTypes.Electric] = 0.5f;
                            break;
                        case PokemonTypes.Dark:
                            ArrData[(int)PokemonTypes.Fighting] = 2f;
                            ArrData[(int)PokemonTypes.Fairy] = 2f;
                            ArrData[(int)PokemonTypes.Bug] = 2f;
                            ArrData[(int)PokemonTypes.Ghost] = 0.5f;
                            ArrData[(int)PokemonTypes.Dark] = 0.5f;
                            ArrData[(int)PokemonTypes.Psychic] = 0f;
                            break;
                        case PokemonTypes.Fairy:
                            ArrData[(int)PokemonTypes.Poison] = 2f;
                            ArrData[(int)PokemonTypes.Steel] = 2f;
                            ArrData[(int)PokemonTypes.Fighting] = 0.5f;
                            ArrData[(int)PokemonTypes.Bug] = 0.5f;
                            ArrData[(int)PokemonTypes.Dark] = 0.5f;
                            ArrData[(int)PokemonTypes.Dragon] = 0f;
                            break;
                        default:
                            MessageBox.Show("not working");
                            break;
                    }//end of case statement
                }//end of if statement
            }
        }
    }
}

     