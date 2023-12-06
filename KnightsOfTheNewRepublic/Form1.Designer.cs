namespace KnightsOfTheNewRepublic;

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
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        label8 = new Label();
        strengthDisplay = new Label();
        charismaDisplay = new Label();
        forcePowerDisplay = new Label();
        constitutionDisplay = new Label();
        intelligenceDisplay = new Label();
        dexterityDisplay = new Label();
        strengthInput = new NumericUpDown();
        ((System.ComponentModel.ISupportInitialize)strengthInput).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(2062, 24);
        label1.Name = "label1";
        label1.Size = new Size(96, 41);
        label1.TabIndex = 0;
        label1.Text = "STATS";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(2061, 114);
        label2.Name = "label2";
        label2.Size = new Size(131, 41);
        label2.TabIndex = 1;
        label2.Text = "Strength";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(2062, 166);
        label3.Name = "label3";
        label3.Size = new Size(137, 41);
        label3.TabIndex = 2;
        label3.Text = "Dexterity";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(2061, 218);
        label4.Name = "label4";
        label4.Size = new Size(171, 41);
        label4.TabIndex = 3;
        label4.Text = "Intelligence";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(2061, 271);
        label5.Name = "label5";
        label5.Size = new Size(181, 41);
        label5.TabIndex = 4;
        label5.Text = "Constitution";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(2061, 312);
        label6.Name = "label6";
        label6.Size = new Size(181, 41);
        label6.TabIndex = 5;
        label6.Text = "Force Power";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(2062, 353);
        label7.Name = "label7";
        label7.Size = new Size(140, 41);
        label7.TabIndex = 6;
        label7.Text = "Charisma";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(2061, 404);
        label8.Name = "label8";
        label8.Size = new Size(0, 41);
        label8.TabIndex = 7;
        // 
        // strengthDisplay
        // 
        strengthDisplay.AutoSize = true;
        strengthDisplay.Location = new Point(2255, 114);
        strengthDisplay.Name = "strengthDisplay";
        strengthDisplay.Size = new Size(66, 41);
        strengthDisplay.TabIndex = 8;
        strengthDisplay.Text = "900";
        // 
        // charismaDisplay
        // 
        charismaDisplay.AutoSize = true;
        charismaDisplay.Location = new Point(2255, 353);
        charismaDisplay.Name = "charismaDisplay";
        charismaDisplay.Size = new Size(66, 41);
        charismaDisplay.TabIndex = 10;
        charismaDisplay.Text = "900";
        // 
        // forcePowerDisplay
        // 
        forcePowerDisplay.AutoSize = true;
        forcePowerDisplay.Location = new Point(2255, 312);
        forcePowerDisplay.Name = "forcePowerDisplay";
        forcePowerDisplay.Size = new Size(66, 41);
        forcePowerDisplay.TabIndex = 11;
        forcePowerDisplay.Text = "900";
        // 
        // constitutionDisplay
        // 
        constitutionDisplay.AutoSize = true;
        constitutionDisplay.Location = new Point(2255, 271);
        constitutionDisplay.Name = "constitutionDisplay";
        constitutionDisplay.Size = new Size(66, 41);
        constitutionDisplay.TabIndex = 12;
        constitutionDisplay.Text = "900";
        // 
        // intelligenceDisplay
        // 
        intelligenceDisplay.AutoSize = true;
        intelligenceDisplay.Location = new Point(2255, 218);
        intelligenceDisplay.Name = "intelligenceDisplay";
        intelligenceDisplay.Size = new Size(66, 41);
        intelligenceDisplay.TabIndex = 13;
        intelligenceDisplay.Text = "900";
        // 
        // dexterityDisplay
        // 
        dexterityDisplay.AutoSize = true;
        dexterityDisplay.Location = new Point(2255, 166);
        dexterityDisplay.Name = "dexterityDisplay";
        dexterityDisplay.Size = new Size(66, 41);
        dexterityDisplay.TabIndex = 14;
        dexterityDisplay.Text = "900";
        // 
        // strengthInput
        // 
        strengthInput.Location = new Point(1724, 112);
        strengthInput.Name = "strengthInput";
        strengthInput.Size = new Size(300, 47);
        strengthInput.TabIndex = 16;
        strengthInput.ValueChanged += strengthInput_ValueChanged;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(17F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(2352, 1222);
        Controls.Add(strengthInput);
        Controls.Add(dexterityDisplay);
        Controls.Add(intelligenceDisplay);
        Controls.Add(constitutionDisplay);
        Controls.Add(forcePowerDisplay);
        Controls.Add(charismaDisplay);
        Controls.Add(strengthDisplay);
        Controls.Add(label8);
        Controls.Add(label7);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)strengthInput).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label label8;
    private Label strengthDisplay;
    private Label charismaDisplay;
    private Label forcePowerDisplay;
    private Label constitutionDisplay;
    private Label intelligenceDisplay;
    private Label dexterityDisplay;
    private NumericUpDown strengthInput;
}
