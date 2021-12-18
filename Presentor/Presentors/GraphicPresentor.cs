using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Presentor.Presentors
{
    public class GraphicPresentor
    {
        private Form _currentView;


        public GraphicPresentor(Form view)
        {
            _currentView = view;
        }

       

        public void ShowView()
        {
            _currentView.Visible = true;
        }

        public void CloseView()
        {
            _currentView.Visible = false;
        }

       public void showGraphic(PictureBox pictureBox)
        {
            Graphics graphic = pictureBox.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);

            Point[] points = new Point[1000];
            for (int i = 0; i < points.Length; i++)
            {
                graphic.DrawLine(pen, new Point(i, i + 10),new  Point(i + 30, i + 50));
            }
        }
    }
}
