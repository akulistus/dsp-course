namespace dsp_course;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        plot1 = new Panel();
        plot2 = new Panel();
        menuStrip1 = new MenuStrip();
        файлToolStripMenuItem = new ToolStripMenuItem();
        открытьToolStripMenuItem = new ToolStripMenuItem();
        openFileDialog1 = new OpenFileDialog();
        menuStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // plot1
        // 
        plot1.BackColor = SystemColors.ControlDark;
        plot1.Location = new Point(423, 31);
        plot1.Name = "plot1";
        plot1.Size = new Size(321, 140);
        plot1.TabIndex = 0;
        // 
        // plot2
        // 
        plot2.BackColor = SystemColors.ControlDark;
        plot2.Location = new Point(423, 177);
        plot2.Name = "plot2";
        plot2.Size = new Size(321, 140);
        plot2.TabIndex = 1;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(800, 24);
        menuStrip1.TabIndex = 2;
        menuStrip1.Text = "menuStrip1";
        // 
        // файлToolStripMenuItem
        // 
        файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem });
        файлToolStripMenuItem.Name = "файлToolStripMenuItem";
        файлToolStripMenuItem.Size = new Size(48, 20);
        файлToolStripMenuItem.Text = "Файл";
        // 
        // открытьToolStripMenuItem
        // 
        открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
        открытьToolStripMenuItem.Size = new Size(180, 22);
        открытьToolStripMenuItem.Text = "Открыть";
        открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(plot2);
        Controls.Add(plot1);
        Controls.Add(menuStrip1);
        Name = "Form1";
        Text = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel plot1;
    private Panel plot2;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem файлToolStripMenuItem;
    private ToolStripMenuItem открытьToolStripMenuItem;
    private OpenFileDialog openFileDialog1;
}
