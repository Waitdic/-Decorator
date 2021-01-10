namespace Laba_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.ValueOfBrightness = new System.Windows.Forms.Label();
            this.buttonReduce = new System.Windows.Forms.Button();
            this.buttonEnlarge = new System.Windows.Forms.Button();
            this.buttonReflectVertical = new System.Windows.Forms.Button();
            this.buttonReflectHorizontal = new System.Windows.Forms.Button();
            this.buttonRotatorRight = new System.Windows.Forms.Button();
            this.buttonRotatorLeft = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.relief = new System.Windows.Forms.Button();
            this.outline = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openPictureToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openPictureToolStripMenuItem
            // 
            this.openPictureToolStripMenuItem.Name = "openPictureToolStripMenuItem";
            this.openPictureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openPictureToolStripMenuItem.Text = "Open picture";
            this.openPictureToolStripMenuItem.Click += new System.EventHandler(this.openPictureToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(34, 260);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = -100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(170, 45);
            this.trackBar1.TabIndex = 9;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 237);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Яркость";
            // 
            // ValueOfBrightness
            // 
            this.ValueOfBrightness.AutoSize = true;
            this.ValueOfBrightness.Location = new System.Drawing.Point(216, 260);
            this.ValueOfBrightness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ValueOfBrightness.Name = "ValueOfBrightness";
            this.ValueOfBrightness.Size = new System.Drawing.Size(13, 13);
            this.ValueOfBrightness.TabIndex = 11;
            this.ValueOfBrightness.Text = "0";
            // 
            // buttonReduce
            // 
            this.buttonReduce.BackgroundImage = global::Lava3_V2.Properties.Resources.zoom_out_option;
            this.buttonReduce.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReduce.Location = new System.Drawing.Point(129, 162);
            this.buttonReduce.Name = "buttonReduce";
            this.buttonReduce.Size = new System.Drawing.Size(74, 53);
            this.buttonReduce.TabIndex = 7;
            this.buttonReduce.UseVisualStyleBackColor = true;
            this.buttonReduce.Click += new System.EventHandler(this.buttonReduce_Click);
            // 
            // buttonEnlarge
            // 
            this.buttonEnlarge.BackgroundImage = global::Lava3_V2.Properties.Resources.zoom_in;
            this.buttonEnlarge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonEnlarge.Location = new System.Drawing.Point(34, 162);
            this.buttonEnlarge.Name = "buttonEnlarge";
            this.buttonEnlarge.Size = new System.Drawing.Size(74, 53);
            this.buttonEnlarge.TabIndex = 6;
            this.buttonEnlarge.UseVisualStyleBackColor = true;
            this.buttonEnlarge.Click += new System.EventHandler(this.buttonEnlarge_Click);
            // 
            // buttonReflectVertical
            // 
            this.buttonReflectVertical.BackgroundImage = global::Lava3_V2.Properties.Resources.reflect;
            this.buttonReflectVertical.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReflectVertical.Location = new System.Drawing.Point(129, 102);
            this.buttonReflectVertical.Name = "buttonReflectVertical";
            this.buttonReflectVertical.Size = new System.Drawing.Size(74, 54);
            this.buttonReflectVertical.TabIndex = 5;
            this.buttonReflectVertical.UseVisualStyleBackColor = true;
            this.buttonReflectVertical.Click += new System.EventHandler(this.buttonReflectVertical_Click);
            // 
            // buttonReflectHorizontal
            // 
            this.buttonReflectHorizontal.BackgroundImage = global::Lava3_V2.Properties.Resources.reflect__1_;
            this.buttonReflectHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonReflectHorizontal.Location = new System.Drawing.Point(34, 102);
            this.buttonReflectHorizontal.Name = "buttonReflectHorizontal";
            this.buttonReflectHorizontal.Size = new System.Drawing.Size(74, 54);
            this.buttonReflectHorizontal.TabIndex = 4;
            this.buttonReflectHorizontal.UseVisualStyleBackColor = true;
            this.buttonReflectHorizontal.Click += new System.EventHandler(this.buttonReflectHorizontal_Click);
            // 
            // buttonRotatorRight
            // 
            this.buttonRotatorRight.BackgroundImage = global::Lava3_V2.Properties.Resources.rotating_arrow_to_the_right;
            this.buttonRotatorRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotatorRight.Location = new System.Drawing.Point(129, 45);
            this.buttonRotatorRight.Name = "buttonRotatorRight";
            this.buttonRotatorRight.Size = new System.Drawing.Size(74, 49);
            this.buttonRotatorRight.TabIndex = 3;
            this.buttonRotatorRight.UseVisualStyleBackColor = true;
            this.buttonRotatorRight.Click += new System.EventHandler(this.buttonRotatorRight_Click);
            // 
            // buttonRotatorLeft
            // 
            this.buttonRotatorLeft.BackgroundImage = global::Lava3_V2.Properties.Resources.rotate_left_circular_arrow_interface_symbol;
            this.buttonRotatorLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRotatorLeft.Location = new System.Drawing.Point(34, 45);
            this.buttonRotatorLeft.Name = "buttonRotatorLeft";
            this.buttonRotatorLeft.Size = new System.Drawing.Size(74, 51);
            this.buttonRotatorLeft.TabIndex = 2;
            this.buttonRotatorLeft.UseVisualStyleBackColor = true;
            this.buttonRotatorLeft.Click += new System.EventHandler(this.buttonRotatorLeft_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(388, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 393);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // relief
            // 
            this.relief.Location = new System.Drawing.Point(43, 316);
            this.relief.Name = "relief";
            this.relief.Size = new System.Drawing.Size(75, 23);
            this.relief.TabIndex = 12;
            this.relief.Text = "Рельеф";
            this.relief.UseVisualStyleBackColor = true;
            this.relief.Click += new System.EventHandler(this.relief_Click);
            // 
            // outline
            // 
            this.outline.Location = new System.Drawing.Point(129, 316);
            this.outline.Name = "outline";
            this.outline.Size = new System.Drawing.Size(75, 23);
            this.outline.TabIndex = 13;
            this.outline.Text = "Контур";
            this.outline.UseVisualStyleBackColor = true;
            this.outline.Click += new System.EventHandler(this.outline_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(43, 356);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(160, 22);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Сброс";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.outline);
            this.Controls.Add(this.relief);
            this.Controls.Add(this.ValueOfBrightness);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.buttonReduce);
            this.Controls.Add(this.buttonEnlarge);
            this.Controls.Add(this.buttonReflectVertical);
            this.Controls.Add(this.buttonReflectHorizontal);
            this.Controls.Add(this.buttonRotatorRight);
            this.Controls.Add(this.buttonRotatorLeft);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Mixer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonRotatorLeft;
        private System.Windows.Forms.Button buttonRotatorRight;
        private System.Windows.Forms.Button buttonReflectHorizontal;
        private System.Windows.Forms.Button buttonReflectVertical;
        private System.Windows.Forms.Button buttonEnlarge;
        private System.Windows.Forms.Button buttonReduce;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ValueOfBrightness;
        private System.Windows.Forms.Button relief;
        private System.Windows.Forms.Button outline;
        private System.Windows.Forms.Button Clear;
    }
}

