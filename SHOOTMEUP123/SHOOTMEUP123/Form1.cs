using System;
using System.Drawing;
using System.Windows.Forms;

namespace SHOOTMEUP123
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = pictureBox1.Location.X;

            int Y = pictureBox1.Location.Y;

            // Move the ship
            if (e.KeyCode == Keys.A && e.KeyCode == Keys.S)
            {
                Y -= 3;
                x += 3;
            }
            if (e.KeyCode == Keys.D)
            {
                x += 10;
            }
            if (e.KeyCode == Keys.A)
            {
                x -= 10;
            }
            if (e.KeyCode == Keys.W)
            {
                Y -= 10;
            }

            if (e.KeyCode == Keys.S)
            {
                Y += 10;
            }
            
            // Update ship location
            pictureBox1.Location = new Point(x, Y);

            // Fire bullet on spacebar press
            if (e.KeyCode == Keys.Space)
            {
                FireBullet(x);
            }
        }

        private void FireBullet(int x)
        {
            int bulletSpeed = 10;
            int bulletDamage = 1;
            int bulletY = pictureBox1.Location.Y; // Start the bullet from the ship's Y position

            // Create and fire bullet
            Bullet bullet = new Bullet(bulletSpeed, bulletDamage, bulletY, x);

            // Implement bullet behavior (e.g., moving the bullet upwards)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    // Define Bullet class (this part is missing in the original code)
    public class Bullet
    {
        public int Speed { get; set; }
        public int Damage { get; set; }
        public int Y { get; set; }
        public int X { get; set; }

        public Bullet(int speed, int damage, int y, int x)
        {
            Speed = speed;
            Damage = damage;
            Y = y;
            X = x;
        }

        // Add behavior for bullet movement and collision detection here
    }
}
