using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpriteSheetNaruto
{
    public partial class NarutoCorriendo : UserControl
    {
        Spritesheet naruto;
        public NarutoCorriendo()
        {
            InitializeComponent();
            this.naruto = new Spritesheet(Properties.Resources.spritesheetNaruto, 63, 67);
            this.pbNaruto.Image = this.naruto.curState;
        }

        public void MoverNaruto()
        {
            naruto.playSprite(6, 6, 1);
            this.pbNaruto.Image = this.naruto.curState;
        }
    }
}
