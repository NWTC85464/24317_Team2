using System.Drawing;

namespace MaintenanceTracker.Classes
{
    class colorThemes
    {
        //Classes
        private Color primaryColor = Color.FromArgb(135, 206, 250);
        private Color secondaryColor = Color.FromArgb(255, 255, 255);

        public Color PrimaryColor { get => primaryColor; set => primaryColor = value; }
        public Color SecondaryColor { get => secondaryColor; set => secondaryColor = value; }
    }
}
