using System.Windows.Forms;

namespace CrackSafeWindNet;

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
        btnStart = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        btnExit = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        pictureBoxCorrect = new PictureBox();
        pictureBoxFail = new PictureBox();
        pictureBoxClose = new PictureBox();
        txtGuess = new TextBox();
        txtGuess1 = new TextBox();
        txtGuess2 = new TextBox();
        txtGuess3 = new TextBox();
        btnGuess = new Button();
        btnCheat = new Button();
        label4 = new Label();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBoxCorrect).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFail).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBoxClose).BeginInit();
        SuspendLayout();
        // 
        // btnStart
        // 
        btnStart.Location = new Point(12, 390);
        btnStart.Margin = new Padding(4, 5, 4, 5);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(312, 42);
        btnStart.TabIndex = 4;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.3756943F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.6243114F));
        tableLayoutPanel1.Controls.Add(btnExit, 0, 0);
        tableLayoutPanel1.Controls.Add(label1, 1, 0);
        tableLayoutPanel1.Controls.Add(label2, 1, 1);
        tableLayoutPanel1.Controls.Add(label3, 1, 2);
        tableLayoutPanel1.Location = new Point(684, 0);
        tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 3;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
        tableLayoutPanel1.Size = new Size(469, 367);
        tableLayoutPanel1.TabIndex = 5;
        Controls.Add(tableLayoutPanel1);
        // 
        // btnExit
        // 
        btnExit.Location = new Point(4, 5);
        btnExit.Margin = new Padding(4, 5, 4, 5);
        btnExit.Name = "btnExit";
        btnExit.Size = new Size(200, 43);
        btnExit.TabIndex = 15;
        btnExit.Text = "Exit";
        btnExit.UseVisualStyleBackColor = true;
        btnExit.Click += btnExit_Click;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.Location = new Point(362, 42);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(84, 38);
        label1.TabIndex = 6;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.None;
        label2.Location = new Point(362, 164);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(84, 38);
        label2.TabIndex = 7;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.None;
        label3.Location = new Point(362, 289);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(84, 33);
        label3.TabIndex = 8;
        label3.Text = "label3";
        // 
        // pictureBoxCorrect
        // 
        pictureBoxCorrect.Location = new Point(368, 14);
        pictureBoxCorrect.Margin = new Padding(4, 5, 4, 5);
        pictureBoxCorrect.Name = "pictureBoxCorrect";
        pictureBoxCorrect.Size = new Size(232, 146);
        pictureBoxCorrect.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxCorrect.TabIndex = 11;
        pictureBoxCorrect.TabStop = false;
        // 
        // pictureBoxFail
        // 
        pictureBoxFail.Location = new Point(368, 14);
        pictureBoxFail.Margin = new Padding(4, 5, 4, 5);
        pictureBoxFail.Name = "pictureBoxFail";
        pictureBoxFail.Size = new Size(232, 146);
        pictureBoxFail.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxFail.TabIndex = 13;
        pictureBoxFail.TabStop = false;
        // 
        // pictureBoxClose
        // 
        pictureBoxClose.Location = new Point(368, 14);
        pictureBoxClose.Margin = new Padding(4, 5, 4, 5);
        pictureBoxClose.Name = "pictureBoxClose";
        pictureBoxClose.Size = new Size(232, 146);
        pictureBoxClose.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBoxClose.TabIndex = 12;
        pictureBoxClose.TabStop = false;
        // 
        // txtGuess
        // 
        txtGuess.Anchor = AnchorStyles.Right;
        txtGuess.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
        txtGuess.Location = new Point(267, 198);
        txtGuess.Margin = new Padding(4, 5, 4, 5);
        txtGuess.Name = "txtGuess";
        txtGuess.Size = new Size(141, 135);
        txtGuess.TabIndex = 6;
        txtGuess.Text = "00";
        txtGuess.TextAlign = HorizontalAlignment.Center;
        // 
        // txtGuess1
        // 
        txtGuess1.Anchor = AnchorStyles.Right;
        txtGuess1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
        txtGuess1.Location = new Point(39, 170);
        txtGuess1.Margin = new Padding(4, 5, 4, 5);
        txtGuess1.Name = "txtGuess1";
        txtGuess1.Size = new Size(177, 135);
        txtGuess1.TabIndex = 6;
        txtGuess1.Text = "00";
        txtGuess1.TextAlign = HorizontalAlignment.Center;
        // 
        // txtGuess2
        // 
        txtGuess2.Anchor = AnchorStyles.Right;
        txtGuess2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
        txtGuess2.Location = new Point(249, 170);
        txtGuess2.Margin = new Padding(4, 5, 4, 5);
        txtGuess2.Name = "txtGuess2";
        txtGuess2.Size = new Size(177, 135);
        txtGuess2.TabIndex = 7;
        txtGuess2.Text = "00";
        txtGuess2.TextAlign = HorizontalAlignment.Center;
        // 
        // txtGuess3
        // 
        txtGuess3.Anchor = AnchorStyles.Right;
        txtGuess3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
        txtGuess3.Location = new Point(479, 170);
        txtGuess3.Margin = new Padding(4, 5, 4, 5);
        txtGuess3.Name = "txtGuess3";
        txtGuess3.Size = new Size(177, 135);
        txtGuess3.TabIndex = 8;
        txtGuess3.Text = "00";
        txtGuess3.TextAlign = HorizontalAlignment.Center;
        // 
        // btnGuess
        // 
        btnGuess.Location = new Point(332, 390);
        btnGuess.Margin = new Padding(4, 5, 4, 5);
        btnGuess.Name = "btnGuess";
        btnGuess.Size = new Size(312, 42);
        btnGuess.TabIndex = 9;
        btnGuess.Text = "Guess";
        btnGuess.UseVisualStyleBackColor = true;
        btnGuess.Click += btnGuess_Click;
        btnGuess.KeyPress += txtGuess_KeyPress;
        // 
        // btnCheat
        // 
        btnCheat.Location = new Point(652, 390);
        btnCheat.Margin = new Padding(4, 5, 4, 5);
        btnCheat.Name = "btnCheat";
        btnCheat.Size = new Size(312, 42);
        btnCheat.TabIndex = 10;
        btnCheat.Text = "Cheat";
        btnCheat.UseVisualStyleBackColor = true;
        btnCheat.Click += btnCheat_Click;
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.None;
        label4.Location = new Point(13, 67);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(347, 39);
        label4.TabIndex = 14;
        label4.Text = "label4";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Info;
        ClientSize = new Size(1153, 449);
        Controls.Add(label4);
        Controls.Add(btnCheat);
        Controls.Add(pictureBoxFail);
        Controls.Add(pictureBoxCorrect);
        Controls.Add(pictureBoxClose);
        Controls.Add(btnGuess);
        Controls.Add(txtGuess3);
        Controls.Add(txtGuess2);
        Controls.Add(txtGuess1);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(btnStart);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBoxCorrect).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBoxFail).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBoxClose).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Button btnStart;
    private TableLayoutPanel tableLayoutPanel1;
    private PictureBox pictureBoxFail;
    private PictureBox pictureBoxClose;
    private PictureBox pictureBoxCorrect;
    private TextBox txtGuess;
    private TextBox txtGuess1;
    private TextBox txtGuess2;
    private TextBox txtGuess3;
    private Button btnGuess;
    private Button btnCheat;
    private Label label4;
    private Button btnExit;
    private Label label1;
    private Label label2;
    private Label label3;
}
