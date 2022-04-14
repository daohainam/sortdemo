namespace SortDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdGenerate = new System.Windows.Forms.ToolStripButton();
            this.cmdSort = new System.Windows.Forms.ToolStripDropDownButton();
            this.bubbleSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectionSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quickSortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iArray = new ArrayControl.IntegerArrayUserControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdGenerate,
            this.cmdSort});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(740, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdGenerate
            // 
            this.cmdGenerate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdGenerate.Image = ((System.Drawing.Image)(resources.GetObject("cmdGenerate.Image")));
            this.cmdGenerate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdGenerate.Name = "cmdGenerate";
            this.cmdGenerate.Size = new System.Drawing.Size(58, 22);
            this.cmdGenerate.Text = "Generate";
            this.cmdGenerate.Click += new System.EventHandler(this.cmdGenerate_Click);
            // 
            // cmdSort
            // 
            this.cmdSort.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cmdSort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bubbleSortToolStripMenuItem,
            this.insertionSortToolStripMenuItem,
            this.selectionSortToolStripMenuItem,
            this.quickSortToolStripMenuItem});
            this.cmdSort.Image = ((System.Drawing.Image)(resources.GetObject("cmdSort.Image")));
            this.cmdSort.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSort.Name = "cmdSort";
            this.cmdSort.Size = new System.Drawing.Size(41, 22);
            this.cmdSort.Text = "Sort";
            // 
            // bubbleSortToolStripMenuItem
            // 
            this.bubbleSortToolStripMenuItem.Name = "bubbleSortToolStripMenuItem";
            this.bubbleSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bubbleSortToolStripMenuItem.Text = "Bubble sort";
            this.bubbleSortToolStripMenuItem.Click += new System.EventHandler(this.bubbleSortToolStripMenuItem_Click);
            // 
            // insertionSortToolStripMenuItem
            // 
            this.insertionSortToolStripMenuItem.Name = "insertionSortToolStripMenuItem";
            this.insertionSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertionSortToolStripMenuItem.Text = "Insertion sort";
            this.insertionSortToolStripMenuItem.Click += new System.EventHandler(this.insertionSortToolStripMenuItem_Click);
            // 
            // selectionSortToolStripMenuItem
            // 
            this.selectionSortToolStripMenuItem.Name = "selectionSortToolStripMenuItem";
            this.selectionSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectionSortToolStripMenuItem.Text = "Selection sort";
            this.selectionSortToolStripMenuItem.Click += new System.EventHandler(this.selectionSortToolStripMenuItem_Click);
            // 
            // quickSortToolStripMenuItem
            // 
            this.quickSortToolStripMenuItem.Name = "quickSortToolStripMenuItem";
            this.quickSortToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quickSortToolStripMenuItem.Text = "Quick sort";
            this.quickSortToolStripMenuItem.Click += new System.EventHandler(this.quickSortToolStripMenuItem_Click);
            // 
            // iArray
            // 
            this.iArray.BackColor = System.Drawing.Color.White;
            this.iArray.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iArray.Location = new System.Drawing.Point(0, 25);
            this.iArray.Name = "iArray";
            this.iArray.Size = new System.Drawing.Size(740, 450);
            this.iArray.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 475);
            this.Controls.Add(this.iArray);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Sorting demostration";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ArrayControl.IntegerArrayUserControl iArray;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdGenerate;
        private System.Windows.Forms.ToolStripDropDownButton cmdSort;
        private System.Windows.Forms.ToolStripMenuItem bubbleSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectionSortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quickSortToolStripMenuItem;
    }
}

