using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using ArrayControl;

namespace SortDemo
{
    public partial class MainForm : Form
    {
        Random r = new Random();
        private bool stopRequested = false;
        Thread t = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < iArray.Length; i++)
            {
                iArray[i] = r.Next(100);
            }

            iArray.Text = "Ready";
            iArray.Invalidate();
        }

        private void MainForm_Closed(object sender, EventArgs e)
        {
            stopRequested = true;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //iArray.Invalidate();
            //Invalidate();
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            stopRequested = true;
            if (t != null && t.IsAlive)
            {
                iArray.Text = "Stoping...";
                iArray.Invalidate();
                t.Join();
            }

            for (int i = 0; i < iArray.Length; i++)
            {
                iArray[i] = r.Next(100);
            }

            iArray.Indexes = null;
            iArray.Text = "Ready";
            iArray.Invalidate();
        }

        private void bubbleSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopRequested = false;
            if (t != null && t.IsAlive)
                t.Join();

            t = new Thread(bubbleSort);
            t.Start();
        }

        private void bubbleSort()
        {
            for (int i = 0; i < iArray.Length - 1; i++)
            {
                for (int j = iArray.Length - 1; j >= i; j--)
                {
                if (stopRequested)
                    return;
                    if (iArray[i] > iArray[j])
                    {
                        iArray.Swap(i, j);
                        SetiArrayText(string.Format("Tráo đổi 2 phần tử thứ {0} và {1}", i, j));
                    }

                    iArray.Indexes = new ArrayControl.IndexItem[] { new ArrayControl.IndexItem() { Name = "j", Value = j }, new ArrayControl.IndexItem() { Name = "i", Value = i } };
                
                    iArray.Invalidate();
                    Thread.Sleep(800);
                }

                if (stopRequested)
                    return;
            }
        }

        private void insertionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopRequested = false;
            if (t != null && t.IsAlive)
            {
                iArray.Text = "Stoping...";
                iArray.Invalidate();
                t.Join();
            }

            t = new Thread(insertionSort);
            t.Start();
        }

        private void insertionSort()
        {
            for (int i = 1; i < iArray.Length; i++)
            {
                int j = i; 
                while (j > 0 && iArray[j] < iArray[j - 1])
                {
                    if (stopRequested)
                        return;

                    iArray.Swap(j - 1, j);
                    SetiArrayText(string.Format("Tráo đổi 2 phần tử thứ {0} và {1}", i, j));

                    j--;

                    iArray.Indexes = new ArrayControl.IndexItem[] { new ArrayControl.IndexItem() { Name = "j", Value = j }, new ArrayControl.IndexItem() { Name = "i", Value = i } };
                    iArray.Invalidate();
                    Thread.Sleep(800);

                }

                if (stopRequested)
                    return;
            }
        }

        private void selectionSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopRequested = false;
            if (t != null && t.IsAlive)
            {
                iArray.Text = "Stoping...";
                iArray.Invalidate();
                t.Join();
            }

            t = new Thread(selectionSort);
            t.Start();
        }

        private void selectionSort()
        {
            for (int i = 0; i < iArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < iArray.Length; j++)
                {
                    if (stopRequested)
                        return;

                    if (iArray[min] > iArray[j])
                        min = j;

                    iArray.Indexes = new ArrayControl.IndexItem[] { new ArrayControl.IndexItem() { Name = "j", Value = j }, new ArrayControl.IndexItem() { Name = "i", Value = i } };
                    iArray.Invalidate();
                    Thread.Sleep(800);
                }

                if (min != i)
                {
                    iArray.Swap(min, i);
                    SetiArrayText(string.Format("Tráo đổi 2 phần tử thứ {0} và {1}", i, min));

                    iArray.Invalidate();
                    Thread.Sleep(800);
                }

                if (stopRequested)
                    return;
            }
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopRequested = false;
            if (t != null && t.IsAlive)
            {
                iArray.Text = "Stoping...";
                iArray.Invalidate();
                t.Join();
            }

            t = new Thread(quickSort);
            t.Start();
        }

        private void quickSort()
        {
            quickSort(0, iArray.Length - 1);

            iArray.Invalidate();
        }

        private void quickSort(int l, int r)
        {
            int i = l;
            int j = r;

            int p = (i + j) / 2;

            while (i <= j)
            {
                while (iArray[i] < iArray[p])
                {
                    if (stopRequested)
                        return;

                    iArray.Indexes = new ArrayControl.IndexItem[] { new ArrayControl.IndexItem() { Name = "j", Value = j }, new ArrayControl.IndexItem() { Name = "i", Value = i } };
                    iArray.Invalidate();
                    Thread.Sleep(800);
                    i++;
                }

                while (iArray[j] > iArray[p])
                {
                    if (stopRequested)
                        return;
                    
                    iArray.Indexes = new ArrayControl.IndexItem[] { new ArrayControl.IndexItem() { Name = "j", Value = j }, new ArrayControl.IndexItem() { Name = "i", Value = i } };
                    iArray.Invalidate();
                    Thread.Sleep(800);
                    j--;
                }

                iArray.Indexes = new ArrayControl.IndexItem[] { new ArrayControl.IndexItem() { Name = "j", Value = j }, new ArrayControl.IndexItem() { Name = "i", Value = i } };
                iArray.Invalidate();
                Thread.Sleep(800);

                if (i <= j)
                {
                    iArray.Swap(i, j);
                    SetiArrayText(string.Format("Tráo đổi 2 phần tử thứ {0} và {1}", i, j));
                    i++;
                    j--;

                    iArray.Indexes = new ArrayControl.IndexItem[] { new ArrayControl.IndexItem() { Name = "j", Value = j }, new ArrayControl.IndexItem() { Name = "i", Value = i } };
                    iArray.Invalidate();
                    Thread.Sleep(800);
                }

                if (stopRequested)
                    return;
            }

            if (l < j)
                quickSort(l, j);
            if (i < r)
                quickSort(i, r);
        }

        delegate void SetTextCallback(string text);
        private void SetiArrayText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.iArray.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetiArrayText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.iArray.Text = text;
            }
        }
    }
}
