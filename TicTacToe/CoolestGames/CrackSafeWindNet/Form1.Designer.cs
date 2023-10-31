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
        checkBox1 = new CheckBox();
        groupBox1 = new GroupBox();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        btnStart = new Button();
        tableLayoutPanel1 = new TableLayoutPanel();
        pictureBox5 = new PictureBox();
        pictureBox4 = new PictureBox();
        pictureBox3 = new PictureBox();
        pictureBox2 = new PictureBox();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        pictureBox1 = new PictureBox();
        txtGuess = new TextBox();
        label6 = new Label();
        groupBox1.SuspendLayout();
        tableLayoutPanel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // checkBox1
        // 
        checkBox1.AutoSize = true;
        checkBox1.Location = new Point(23, 21);
        checkBox1.Margin = new Padding(2);
        checkBox1.Name = "checkBox1";
        checkBox1.Size = new Size(49, 19);
        checkBox1.TabIndex = 0;
        checkBox1.Text = "cool";
        checkBox1.UseVisualStyleBackColor = true;
        checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(radioButton1);
        groupBox1.Controls.Add(radioButton2);
        groupBox1.Controls.Add(radioButton3);
        groupBox1.Location = new Point(23, 45);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(119, 100);
        groupBox1.TabIndex = 3;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(6, 24);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(48, 19);
        radioButton1.TabIndex = 4;
        radioButton1.TabStop = true;
        radioButton1.Text = "Easy";
        radioButton1.UseVisualStyleBackColor = true;
        radioButton1.CheckedChanged += radioButton1_CheckedChanged;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(5, 49);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(70, 19);
        radioButton2.TabIndex = 5;
        radioButton2.TabStop = true;
        radioButton2.Text = "Medium";
        radioButton2.UseVisualStyleBackColor = true;
        radioButton2.CheckedChanged += radioButton2_CheckedChanged;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(5, 74);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(51, 19);
        radioButton3.TabIndex = 0;
        radioButton3.TabStop = true;
        radioButton3.Text = "Hard";
        radioButton3.UseVisualStyleBackColor = true;
        radioButton3.CheckedChanged += radioButton3_CheckedChanged;
        // 
        // btnStart
        // 
        btnStart.Location = new Point(12, 225);
        btnStart.Name = "btnStart";
        btnStart.Size = new Size(444, 25);
        btnStart.TabIndex = 4;
        btnStart.Text = "Start";
        btnStart.UseVisualStyleBackColor = true;
        btnStart.Click += btnStart_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 2;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
        tableLayoutPanel1.Controls.Add(pictureBox5, 0, 4);
        tableLayoutPanel1.Controls.Add(pictureBox4, 0, 3);
        tableLayoutPanel1.Controls.Add(pictureBox3, 0, 2);
        tableLayoutPanel1.Controls.Add(pictureBox2, 0, 1);
        tableLayoutPanel1.Controls.Add(label1, 1, 0);
        tableLayoutPanel1.Controls.Add(label2, 1, 1);
        tableLayoutPanel1.Controls.Add(label3, 1, 2);
        tableLayoutPanel1.Controls.Add(label4, 1, 3);
        tableLayoutPanel1.Controls.Add(label5, 1, 4);
        tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
        tableLayoutPanel1.Location = new Point(372, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 5;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
        tableLayoutPanel1.Size = new Size(98, 109);
        tableLayoutPanel1.TabIndex = 5;
        // 
        // pictureBox5
        // 
        pictureBox5.Location = new Point(3, 91);
        pictureBox5.Name = "pictureBox5";
        pictureBox5.Size = new Size(18, 15);
        pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox5.TabIndex = 15;
        pictureBox5.TabStop = false;
        // 
        // pictureBox4
        // 
        pictureBox4.Location = new Point(3, 71);
        pictureBox4.Name = "pictureBox4";
        pictureBox4.Size = new Size(18, 14);
        pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox4.TabIndex = 14;
        pictureBox4.TabStop = false;
        // 
        // pictureBox3
        // 
        pictureBox3.Location = new Point(3, 51);
        pictureBox3.Name = "pictureBox3";
        pictureBox3.Size = new Size(18, 14);
        pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox3.TabIndex = 13;
        pictureBox3.TabStop = false;
        // 
        // pictureBox2
        // 
        pictureBox2.Location = new Point(3, 27);
        pictureBox2.Name = "pictureBox2";
        pictureBox2.Size = new Size(18, 18);
        pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox2.TabIndex = 12;
        pictureBox2.TabStop = false;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.None;
        label1.Location = new Point(27, 0);
        label1.Name = "label1";
        label1.Size = new Size(68, 23);
        label1.TabIndex = 6;
        label1.Text = "label1";
        // 
        // label2
        // 
        label2.Anchor = AnchorStyles.None;
        label2.Location = new Point(27, 24);
        label2.Name = "label2";
        label2.Size = new Size(68, 23);
        label2.TabIndex = 7;
        label2.Text = "label2";
        // 
        // label3
        // 
        label3.Anchor = AnchorStyles.None;
        label3.Location = new Point(27, 48);
        label3.Name = "label3";
        label3.Size = new Size(68, 20);
        label3.TabIndex = 8;
        label3.Text = "label3";
        // 
        // label4
        // 
        label4.Anchor = AnchorStyles.None;
        label4.Location = new Point(27, 68);
        label4.Name = "label4";
        label4.Size = new Size(68, 20);
        label4.TabIndex = 9;
        label4.Text = "label4";
        // 
        // label5
        // 
        label5.Anchor = AnchorStyles.None;
        label5.Location = new Point(27, 88);
        label5.Name = "label5";
        label5.Size = new Size(68, 21);
        label5.TabIndex = 10;
        label5.Text = "label5";
        // 
        // pictureBox1
        // 
        pictureBox1.Location = new Point(3, 3);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(18, 18);
        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        pictureBox1.TabIndex = 11;
        pictureBox1.TabStop = false;
        // 
        // txtGuess
        // 
        txtGuess.Anchor = AnchorStyles.Right;
        txtGuess.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
        txtGuess.Location = new Point(187, 119);
        txtGuess.Name = "txtGuess";
        txtGuess.Size = new Size(100, 93);
        txtGuess.TabIndex = 6;
        txtGuess.Text = "00";
        txtGuess.TextAlign = HorizontalAlignment.Center;
        // 
        // label6
        // 
        label6.Anchor = AnchorStyles.None;
        label6.Location = new Point(205, 85);
        label6.Name = "label6";
        label6.Size = new Size(68, 21);
        label6.TabIndex = 11;
        label6.Text = "label6";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Info;
        ClientSize = new Size(468, 262);
        Controls.Add(label6);
        Controls.Add(txtGuess);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(btnStart);
        Controls.Add(groupBox1);
        Controls.Add(checkBox1);
        Margin = new Padding(2);
        Name = "Form1";
        Text = "Form1";
        Load += Form1_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        tableLayoutPanel1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CheckBox checkBox1;
    private Label label1;
    private GroupBox groupBox1;
    private RadioButton radioButton1;
    private RadioButton radioButton2;
    private RadioButton radioButton3;
    private Button btnStart;
    private TableLayoutPanel tableLayoutPanel1;
    private Label label2;
    private PictureBox pictureBox5;
    private PictureBox pictureBox4;
    private PictureBox pictureBox3;
    private PictureBox pictureBox2;
    private Label label3;
    private Label label4;
    private Label label5;
    private PictureBox pictureBox1;
    private TextBox txtGuess;
    private Label label6;
}
