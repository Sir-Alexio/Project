using System;
using System.Drawing;
using System.Windows.Forms;
using Presentor.Presentors;

namespace View
{
    public partial class GraphicView : Form
    {
        GraphicPresentor _presentor;
        public GraphicView()
        {
            
            InitializeComponent();

            _presentor = new GraphicPresentor(this);
            Graphics graphic = TemperatureGraphic.CreateGraphics();
            Pen pen = new Pen(Color.Black, 3f);

            Point[] points = new Point[1000];

            for (int i = 0; i < points.Length; i++)
            {
                points[i] = new Point(i,(int)(Math.Sin((double)i / 10) * 100 + 200));
            }
            graphic.DrawLines(pen, points);
        }

        private void GraphicView_Load(object sender, EventArgs e)
        {

        }
    }
}
