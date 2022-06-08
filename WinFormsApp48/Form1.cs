namespace WinFormsApp48
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            float ang = -90;
            float swep = (float)(360 / numericUpDown1.Value);
            Pen pen = new Pen(Color.Black, 2.0f);
            if (numericUpDown1.Value == 1)
            {
                e.Graphics.DrawEllipse(pen, new Rectangle(100, 100, 500, 500));
            }
            else
            {
                for (int i = 0; i < numericUpDown1.Value; i++)
                {
                    e.Graphics.DrawPie(pen, new Rectangle(100, 100, 500, 500), ang, swep);
                    ang += swep;
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}