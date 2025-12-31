namespace Greeting_Card
{
    public partial class Form1 : Form
    {

        bool showCover = true;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (showCover)
            {
                DrawCover(g);
                OpenButton.Visible = true;
            }
            if (!showCover)
            {
                DrawInside(g);
            }

        }

        private void DrawCover(Graphics g)
        {
            // White card area with TOO THIN border (mistake #10)
            g.FillRectangle(Brushes.White, 40, 40, 473, 567);
            g.DrawRectangle(new Pen(Color.RoyalBlue, 1), 40, 40, 473, 567); // mistake

            using (Font titleFont = new Font("Segoe UI", 36, FontStyle.Bold))
                g.DrawString("Happy Birthday!", titleFont, Brushes.RoyalBlue, 80, 70);

            g.FillEllipse(Brushes.RoyalBlue, 120, 220, 80, 110);
            g.FillEllipse(Brushes.Gold, 240, 240, 80, 110);
            g.FillEllipse(Brushes.RoyalBlue, 360, 230, 80, 110);

            Pen stringPen = new Pen(Color.Navy, 2);
            g.DrawLine(stringPen, 160, 330, 160, 390);
            g.DrawLine(stringPen, 280, 350, 280, 410);
            g.DrawLine(stringPen, 400, 340, 400, 400);


            /*using (Font smallFont = new Font("Segoe UI", 16, FontStyle.Italic))
                g.DrawString("Click to open your card!", smallFont, Brushes.Navy, 120, 500);*/

        }

        private void Form1_Click(object sender, EventArgs e)
        {
        }

        private void DrawInside(Graphics g)
        {
            using (Font insideFont = new Font("Segoe UI", 24, FontStyle.Bold))
            {
                g.DrawString("Wishing you a day filled with happiness\n" +
                             "and a year filled with joy.\n\n" +
                             "Happy Birthday!", insideFont, Brushes.MediumVioletRed, 60, 100);
            }
            // Randomly place some confetti
            for (int i = 0; i < 50; i++)
            {
                int x = rand.Next(40, 513);
                int y = rand.Next(40, 607);
                g.FillEllipse(Brushes.MediumVioletRed, x, y, 5, 5);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showCover = !showCover;
            OpenButton.Visible = false;
        }
    }
}
