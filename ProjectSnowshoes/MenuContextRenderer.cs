using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSnowshoes
{
    public class MenuContextRenderer : ToolStripProfessionalRenderer
    {
        public MenuContextRenderer() : base(new menuContextColorSet()) {}


        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            // Wow are we seriously still doing this alrighty then
            base.OnRenderItemText(e);
            
            if (e.Item.Selected)
            {
                e.Item.ForeColor = Color.White;
            }
            else
            {
                e.Item.ForeColor = Color.Black;
            }

        }


        /* protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            
            // Currently writes over already existent string...need to find way to show only one and perhaps link back to original text
            
            if(e.Item.Selected)
            {
                Font turn = new Font("Roboto Light", 12);
                
                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(Brushes.DeepSkyBlue, rc);
                e.Graphics.DrawString(e.Item.Text,turn,Brushes.White,PointF.Empty);
            }
            else
            {
                Font turn = new Font("Roboto Light", 12);

                Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
                e.Graphics.FillRectangle(Brushes.WhiteSmoke, rc);
                e.Graphics.DrawString(e.Item.Text, turn, Brushes.Black, PointF.Empty);
            }
        } */
    }

     
    // Turnips. Thanks, person(s): http://stackoverflow.com/questions/9260303/how-to-change-menu-hover-color-winforms
    // (also the same for above code as well)

    
    
    public class menuContextColorSet : ProfessionalColorTable
    {
        // Especially where the thanks comes in. Seriously. Hans Passant, you are one hella person that just helped out this tired doge.
        // Whoops still wrote some alternative code anyway
        
        public override Color MenuItemSelected
        {
            get 
            { 
                return Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]); 
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.FromName(Properties.Settings.Default.custColor[Properties.Settings.Default.whoIsThisCrazyDoge]);
            }
        }
        
        /* Nah
         * public override Color MenuBorder
        {
            get {
                return Color.DeepSkyBlue;
            }
        } */

        


        
    }

}
