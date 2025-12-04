using System.Drawing;
using System.Windows.Forms;

namespace CustomControls.RJControls
{
    internal class MenuColorTable : ProfessionalColorTable
    {
        private bool isMainMenu;
        private Color primaryColor;

        public MenuColorTable(bool isMainMenu, Color primaryColor)
        {
            this.isMainMenu = isMainMenu;
            this.primaryColor = primaryColor;
        }
    }
}