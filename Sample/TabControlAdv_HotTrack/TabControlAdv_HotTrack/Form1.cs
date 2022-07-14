using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.Windows.Forms;
using System.Drawing.Drawing2D;

namespace TabControlAdv_HotTracking
{
    public partial class Form1 : MetroForm
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
            //To enable the HotTrack. It helps to change the appearance of the TabControlAdv on mouse hover.
            this.tabControlAdv1.HotTrack = true;
            //To draw the Tab item
            this.tabControlAdv1.DrawItem += new DrawTabEventHandler(tabControlAdv1_DrawItem);
        }
        #endregion

        #region Events
        void tabControlAdv1_DrawItem(object sender, DrawTabEventArgs drawItemInfo)
        {
            //To check whether the HotTracking is in progress
            if ((drawItemInfo.State & DrawItemState.HotLight) > 0)
            {
                drawItemInfo.ForeColor = Color.Red;
                drawItemInfo.BackColor = Color.Khaki;
                drawItemInfo.Font = new Font("Segoe Marker", 12.0F, FontStyle.Italic);
            }
            //To draw the default background and interior
            drawItemInfo.DrawBackground();
            drawItemInfo.DrawInterior();
        }
        #endregion
    }
}