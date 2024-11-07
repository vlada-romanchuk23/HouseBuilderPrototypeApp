using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseBuilderPrototypeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateHouse_Click(object sender, EventArgs e)
        {
            
                IHouseBuilder builder = new LuxuryHouseBuilder();
                builder.BuildWalls();
                builder.BuildRoof();
                builder.BuildWindows();
                House house = builder.GetHouse();
                listBoxHouses.Items.Add(house);
            

        }

        private void btnCloneHouse_Click(object sender, EventArgs e)
        {
            
                if (listBoxHouses.SelectedItem is House originalHouse)
                {
                    House clonedHouse = originalHouse.Clone();
                    listBoxHouses.Items.Add(clonedHouse);
                }
            }

        
    }
}
