using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ArrayControl
{
    public partial class IntegerArrayUserControl : UserControl
    {
        private int[] _array = new int[8];
        private BufferedGraphicsContext context;
        private BufferedGraphics grafx;

        public int this[int i]
        {
            get
            {
                return _array[i];
            }

            set
            {
                _array[i] = value;

                //pArray.Invalidate();
            }
        }

        public int Length
        {
            get
            {
                return _array.Length;
            }
        }

        public IndexItem[] Indexes { get; set; }

        public void Swap(int i, int j)
        {
            if (i < 0 || i >= _array.Length)
                throw new IndexOutOfRangeException("i");
            if (j < 0 || j >= _array.Length)
                throw new IndexOutOfRangeException("j");

            if (i != j)
            {
                int t = _array[i];
                _array[i] = _array[j];
                _array[j] = t;
            }
        }

        public IntegerArrayUserControl()
        {
            InitializeComponent();
        }

        private void pArray_Paint(object sender, PaintEventArgs e)
        {
            ArrayPainter painter = new ArrayPainter(_array, grafx.Graphics, new Rectangle(0, 0, pArray.Width, pArray.Height), Indexes);
            painter.Paint();

            Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);
            Brush brush = new SolidBrush(Color.Blue);
            grafx.Graphics.DrawString(Text, font, brush, new RectangleF(0, this.Bottom - 40, this.Width, 30));

            grafx.Render(e.Graphics);
        }

        private void IntegerArrayUserControl_Load(object sender, EventArgs e)
        {
            if (pArray != null)
            {
                context = BufferedGraphicsManager.Current;
                context.MaximumBuffer = new Size(pArray.Width + 1, pArray.Height + 1);
                grafx = context.Allocate(pArray.CreateGraphics(), new Rectangle(0, 0, pArray.Width, pArray.Height));
            }
        }

        private void IntegerArrayUserControl_Resize(object sender, EventArgs e)
        {
            if (context != null)
            {
                context.MaximumBuffer = new Size(pArray.Width + 1, pArray.Height + 1);
                if (grafx != null)
                {
                    grafx.Dispose();
                    grafx = null;
                }
                grafx = context.Allocate(pArray.CreateGraphics(), new Rectangle(0, 0, pArray.Width, pArray.Height));

                Invalidate();
            }
        }


        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            pArray.Invalidate();
        }
    }
}
