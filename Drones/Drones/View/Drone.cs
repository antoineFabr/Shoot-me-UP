using Drones.Helpers;

namespace Drones
{
    // Cette partie de la classe Drone définit comment on peut voir un drone

    public partial class Drone
    {
        private Pen droneBrush = new Pen(new SolidBrush(Color.Purple), 3);

        // De manière graphique
        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawEllipse(droneBrush, new Rectangle(X - 4, Y - 2, 8, 8));
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, X + 5, Y - 5);
        }

        // De manière textuelle
        public override string ToString()
        {
            return $"{Name} ({((int)((double)_charge / FULLCHARGE * 100)).ToString()}%)";
        }

    }
}
