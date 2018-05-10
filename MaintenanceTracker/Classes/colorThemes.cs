using System.Drawing;

namespace MaintenanceTracker.Classes
{
    class colorThemes
    {
        //Classes
        private Color primaryColor = Color.FromArgb(0, 188, 212);
        private Color secondaryColor = Color.FromArgb(149, 117, 205);

        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }
        public Color SecondaryColor { get => secondaryColor; set => secondaryColor = value; }
    }
}
