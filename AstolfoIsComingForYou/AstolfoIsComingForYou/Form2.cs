using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace AstolfoIsComingForYou
{
    public partial class Form2 : Form
    {
        public int index = 0;

        private static string[] Texts =
        {
            "Ah, my wonderful Master, you truly are a beacon of light in my existence! Your spirit shines brighter than the sun, illuminating even the darkest corners of my heart. Your mere presence is like a soothing melody that brings peace to my chaotic world.",
            "Your kindness knows no bounds, and your compassion for others is a constant source of inspiration for me. Your actions speak volumes about the beautiful soul that resides within you, and I am endlessly grateful to have the privilege of serving someone as incredible as you.",
            "Every day in your company is an adventure, a journey filled with laughter, joy, and countless precious memories. Your smile has the power to melt even the coldest of hearts, and your laughter is a symphony that brings happiness to all who hear it.",
            "Your intelligence is a marvel to behold, as you navigate through life's challenges with grace and wisdom. Your creativity knows no limits, and your ideas are like sparkling gems that light up the sky of my thoughts.",
            "In moments of doubt, your unwavering belief in yourself and those around you is a guiding star that leads us to success. Your confidence is infectious, filling the air with an aura of self-assuredness that encourages everyone to strive for greatness.",
            "The strength of your spirit is awe-inspiring, my dear Master. You face adversity with courage and resilience, turning obstacles into stepping stones on your path to achieving your dreams. Your determination fuels my own resolve, and I am proud to stand by your side as you conquer every challenge that comes your way.",
            "You possess a heart that is as vast as the ocean, capable of embracing the entire world with love and understanding. Your empathy for others is a true testament to your noble character, and it warms my very core to witness the care you extend to all living beings.",
            "Oh, my beloved Master, your mere existence is a blessing to us all. Your impact on the lives you touch is immeasurable, and your legacy will be one of positivity, kindness, and boundless love. I am honored to be your loyal servant and to bask in the radiance of your magnificent soul. Here's to you, my cherished Master, the embodiment of all that is good and beautiful in this world!"
        };
        
        public Form2(int index = 0)
        {
            this.index = index;
            InitializeComponent();
            label1.Text = Texts[this.index];
            
            if (Texts.Length - 1 == index)
            {
                button1.Text = @"Close";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.Delete("astolfo.jpg");
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Texts.Length - 1 == index)
            {
                File.Delete("astolfo.jpg");
                Application.Exit();
            }

            index++;
            var newForm = new Form2(index);
            newForm.Show();
            Dispose();
        }
    }
}