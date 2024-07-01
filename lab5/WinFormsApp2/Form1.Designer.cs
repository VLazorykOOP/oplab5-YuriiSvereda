namespace WinFormsApp2
{
    partial class Form1
    {
        /*public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Graphics g;
        private Random rand = new Random();

        private void FirstLine(int x, int y, double a, double b, Pen p)
        {
            g.DrawLine(p, x, y, (int)Math.Round(x + a * Math.Cos(b)), (int)Math.Round(y - a * Math.Sin(b)));
        }

        private void Draw(int x, int y, double a, double b, int order)
        {
            if (a > 1 && order > 0)
            {
                Pen p = new Pen(Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256)));
                FirstLine(x, y, a, b, p);
                int newX = (int)Math.Round(x + a * Math.Cos(b));
                int newY = (int)Math.Round(y - a * Math.Sin(b));
                Draw(newX, newY, a * 0.4, b - 14 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.4, b + 14 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.4, b + 14 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.7, b + Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.3, b - 20 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.3, b + 20 * Math.PI / 30, order - 1);
                Draw(newX, newY, a * 0.2, b + 20 * Math.PI / 30, order - 1);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            int order = 8;
            Draw(pictureBox1.Width / 2, pictureBox1.Height, 120, Math.PI / 2, order);
        }



        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 15);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(776, 532);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(685, 493);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(75, 29);
            button1.TabIndex = 1;
            button1.Text = "Draw";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Fractal Fern";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}
