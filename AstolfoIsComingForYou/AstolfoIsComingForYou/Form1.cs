using System;
using System.Windows.Forms;

namespace AstolfoIsComingForYou
{
    public partial class Form1 : Form
    {
        private int _count = 100;
        
        public Form1()
        {
            InitializeComponent();
            
            var t1 = new Timer();
            t1.Interval = 50;
            t1.Tick += T1OnTick;
            t1.Start();
        }

        private void T1OnTick(object sender, EventArgs e)
        {
            if (_count < 0) return;
            if (_count == 0)
            {
                Hide();
                var form2 = new Form2();
                form2.Show();
                _count = -1;
                return;
            }
            _count--;
            label1.Text = $@"{_count:N0}km";
        }
    }
}