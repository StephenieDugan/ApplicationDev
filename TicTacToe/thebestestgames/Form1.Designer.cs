namespace thebestestgames;

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
        PlayerStart = new PictureBox();
        PlayerImage2 = new PictureBox();
        PlayerImage3 = new PictureBox();
        PlayerImage4 = new PictureBox();
        PlayerImage5 = new PictureBox();
        ((System.ComponentModel.ISupportInitialize)PlayerStart).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PlayerImage2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PlayerImage3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PlayerImage4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)PlayerImage5).BeginInit();
        SuspendLayout();
        // 
        // PlayerStart
        // 
        PlayerStart.Image = Properties.Resources.llama;
        PlayerStart.Location = new Point(1586, 294);
        PlayerStart.Name = "PlayerStart";
        PlayerStart.Size = new Size(159, 148);
        PlayerStart.SizeMode = PictureBoxSizeMode.StretchImage;
        PlayerStart.TabIndex = 0;
        PlayerStart.TabStop = false;
        // 
        // PlayerImage2
        // 
        PlayerImage2.Image = Properties.Resources.llama;
        PlayerImage2.Location = new Point(1390, 294);
        PlayerImage2.Name = "PlayerImage2";
        PlayerImage2.Size = new Size(159, 148);
        PlayerImage2.SizeMode = PictureBoxSizeMode.StretchImage;
        PlayerImage2.TabIndex = 1;
        PlayerImage2.TabStop = false;
        // 
        // PlayerImage3
        // 
        PlayerImage3.Image = Properties.Resources.llama;
        PlayerImage3.Location = new Point(1197, 294);
        PlayerImage3.Name = "PlayerImage3";
        PlayerImage3.Size = new Size(159, 148);
        PlayerImage3.SizeMode = PictureBoxSizeMode.StretchImage;
        PlayerImage3.TabIndex = 2;
        PlayerImage3.TabStop = false;
        // 
        // PlayerImage4
        // 
        PlayerImage4.Image = Properties.Resources.llama;
        PlayerImage4.Location = new Point(1004, 294);
        PlayerImage4.Name = "PlayerImage4";
        PlayerImage4.Size = new Size(159, 148);
        PlayerImage4.SizeMode = PictureBoxSizeMode.StretchImage;
        PlayerImage4.TabIndex = 3;
        PlayerImage4.TabStop = false;
        // 
        // PlayerImage5
        // 
        PlayerImage5.Image = Properties.Resources.llama;
        PlayerImage5.Location = new Point(813, 294);
        PlayerImage5.Name = "PlayerImage5";
        PlayerImage5.Size = new Size(159, 148);
        PlayerImage5.SizeMode = PictureBoxSizeMode.StretchImage;
        PlayerImage5.TabIndex = 4;
        PlayerImage5.TabStop = false;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1757, 454);
        Controls.Add(PlayerImage5);
        Controls.Add(PlayerImage4);
        Controls.Add(PlayerImage3);
        Controls.Add(PlayerImage2);
        Controls.Add(PlayerStart);
        Name = "Form1";
        Text = "Form1";
        KeyPress += Form1_KeyPress;
        ((System.ComponentModel.ISupportInitialize)PlayerStart).EndInit();
        ((System.ComponentModel.ISupportInitialize)PlayerImage2).EndInit();
        ((System.ComponentModel.ISupportInitialize)PlayerImage3).EndInit();
        ((System.ComponentModel.ISupportInitialize)PlayerImage4).EndInit();
        ((System.ComponentModel.ISupportInitialize)PlayerImage5).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private PictureBox PlayerStart;
    private PictureBox PlayerImage2;
    private PictureBox PlayerImage3;
    private PictureBox PlayerImage4;
    private PictureBox PlayerImage5;
}
