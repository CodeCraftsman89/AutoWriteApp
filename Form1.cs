using System.Diagnostics;
using System.Windows.Forms;

namespace AutoWriteApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Timer timer;
        public string text;
        public bool IsStart;

        public Form()
        {
            InitializeComponent();

            
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 300; 
            timer.Tick += new System.EventHandler(this.timer_Tick);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text = textBox.Text; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            IsStart = true;
            timer.Start(); 
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (IsStart)
            {
                SendKeys.SendWait(text);
                SendKeys.SendWait("{ENTER}");
            }
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("https://github.com/CodeCraftsman89");
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            IsStart = false;
            timer.Stop(); // Stop the timer
        }
    }
}

