using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ArrayControl
{
        class ArrayPainter
        {
            private int[] _array;
            private Graphics _g;
            private Rectangle _bounds;
            private ArrayControl.IndexItem[] _indexes;

            public ArrayPainter(int[] array, Graphics g, Rectangle bounds, ArrayControl.IndexItem[] indexes)
            {
                this._array = array;
                this._g = g;
                this._bounds = bounds;
                this._indexes = indexes;
            }

            public void Paint()
            {
                int cellWidth = _bounds.Width / _array.Length;
                int maxValue = int.MinValue;
                int noOfIndexes = _indexes == null ? 0 : _indexes.Length;

                foreach (var n in _array)
                {
                    if (maxValue < n)
                        maxValue = n;
                }

                Pen linePen = Pens.Black;
                Brush barBrush = new SolidBrush (Color.Green);

                _g.Clear(Color.White);

                if (_array != null && _array.Length > 0)
                {
                    for (int column = _array.Length - 1; column >= 0; column--)
                    {
                        int height = maxValue != 0 ? ((_bounds.Height - 20 - noOfIndexes * 20) * _array[column] / maxValue) : 0;

                        if (height > 0)
                        {
                            _g.FillRectangle(barBrush, column * cellWidth + 4, _bounds.Height - height + 4 - (noOfIndexes * 20) - 20, cellWidth - 8, height - 8);
                            _g.DrawRectangle(linePen, column * cellWidth + 3, _bounds.Height - height + 3 - (noOfIndexes * 20) - 20, cellWidth - 7, height - 7);
                        }
                    }

                    Font font = new Font("Arial", 14, FontStyle.Regular, GraphicsUnit.Pixel);
                    Brush brush = new SolidBrush(Color.Blue);
                    StringFormat stringFormat = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Far };

                    for (int column = _array.Length - 1; column >= 0; --column)
                    {
                        _g.DrawString(_array[column].ToString(), font, brush, new RectangleF(column * cellWidth, _bounds.Bottom - 60 - noOfIndexes * 20, cellWidth, 30), stringFormat);
                    }

                    if (_indexes != null)
                    {
                        for (int i = 0; i < _indexes.Length; i++)
                        {
                            _g.FillRectangle(new SolidBrush(Color.LightGray), new Rectangle(_indexes[i].Value * cellWidth + 5, _bounds.Bottom - i * 20 - 40, cellWidth - 10, 20));
                            _g.DrawString(string.Format("{0}={1}", _indexes[i].Name, _indexes[i].Value), font, brush, new Rectangle(_indexes[i].Value * cellWidth + 5, _bounds.Bottom - i * 20 - 40, cellWidth - 10, 20), stringFormat);
                        }
                    }
                
                }
            }
        }
}
