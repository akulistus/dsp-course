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
        plot3 = new Panel();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        radioButton4 = new RadioButton();
        radioButton5 = new RadioButton();
        dataGridView1 = new DataGridView();
        Stats = new DataGridViewTextBoxColumn();
        Ch1 = new DataGridViewTextBoxColumn();
        Ch2 = new DataGridViewTextBoxColumn();
        Ch3 = new DataGridViewTextBoxColumn();
        menuStrip1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // plot1
        // 
        plot1.BackColor = SystemColors.ControlDark;
        plot1.Location = new Point(488, 31);
        plot1.Name = "plot1";
        plot1.Size = new Size(620, 239);
        plot1.TabIndex = 0;
        // 
        // plot2
        // 
        plot2.BackColor = SystemColors.ControlDark;
        plot2.Location = new Point(488, 276);
        plot2.Name = "plot2";
        plot2.Size = new Size(620, 244);
        plot2.TabIndex = 1;
        // 
        // menuStrip1
        // 
        menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
        menuStrip1.Location = new Point(0, 0);
        menuStrip1.Name = "menuStrip1";
        menuStrip1.Size = new Size(1120, 24);
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
        открытьToolStripMenuItem.Size = new Size(121, 22);
        открытьToolStripMenuItem.Text = "Открыть";
        открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // plot3
        // 
        plot3.BackColor = SystemColors.ControlDark;
        plot3.Location = new Point(488, 526);
        plot3.Name = "plot3";
        plot3.Size = new Size(620, 244);
        plot3.TabIndex = 3;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(12, 70);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(49, 19);
        radioButton1.TabIndex = 4;
        radioButton1.TabStop = true;
        radioButton1.Text = "50hz";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(12, 95);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(99, 19);
        radioButton2.TabIndex = 5;
        radioButton2.TabStop = true;
        radioButton2.Text = "50hz+lowpass";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(12, 120);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(135, 19);
        radioButton3.TabIndex = 6;
        radioButton3.TabStop = true;
        radioButton3.Text = "50hz+lowpass+trend";
        radioButton3.UseVisualStyleBackColor = true;
        radioButton3.CheckedChanged += radioButton3_CheckedChanged;
        // 
        // radioButton4
        // 
        radioButton4.AutoSize = true;
        radioButton4.Location = new Point(12, 145);
        radioButton4.Name = "radioButton4";
        radioButton4.Size = new Size(32, 19);
        radioButton4.TabIndex = 7;
        radioButton4.TabStop = true;
        radioButton4.Text = "θ";
        radioButton4.UseVisualStyleBackColor = true;
        radioButton4.CheckedChanged += radioButton4_CheckedChanged;
        // 
        // radioButton5
        // 
        radioButton5.AutoSize = true;
        radioButton5.Location = new Point(12, 45);
        radioButton5.Name = "radioButton5";
        radioButton5.Size = new Size(47, 19);
        radioButton5.TabIndex = 8;
        radioButton5.TabStop = true;
        radioButton5.Text = "Raw";
        radioButton5.UseVisualStyleBackColor = true;
        radioButton5.CheckedChanged += radioButton5_CheckedChanged;
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Stats, Ch1, Ch2, Ch3 });
        dataGridView1.Location = new Point(12, 203);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(443, 150);
        dataGridView1.TabIndex = 9;
        // 
        // Stats
        // 
        Stats.HeaderText = "Stats";
        Stats.Name = "Stats";
        // 
        // Ch1
        // 
        Ch1.HeaderText = "Channel1";
        Ch1.Name = "Ch1";
        Ch1.ReadOnly = true;
        // 
        // Ch2
        // 
        Ch2.HeaderText = "Channel2";
        Ch2.Name = "Ch2";
        Ch2.ReadOnly = true;
        // 
        // Ch3
        // 
        Ch3.HeaderText = "Channel3";
        Ch3.Name = "Ch3";
        Ch3.ReadOnly = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1120, 800);
        Controls.Add(dataGridView1);
        Controls.Add(radioButton5);
        Controls.Add(radioButton4);
        Controls.Add(radioButton3);
        Controls.Add(radioButton2);
        Controls.Add(radioButton1);
        Controls.Add(plot3);
        Controls.Add(plot2);
        Controls.Add(plot1);
        Controls.Add(menuStrip1);
        Name = "Form1";
        Text = "Form1";
        menuStrip1.ResumeLayout(false);
        menuStrip1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
    private Panel plot3;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private RadioButton radioButton4;
    private RadioButton radioButton5;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn Stats;
    private DataGridViewTextBoxColumn Ch1;
    private DataGridViewTextBoxColumn Ch2;
    private DataGridViewTextBoxColumn Ch3;
}
