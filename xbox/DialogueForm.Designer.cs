namespace ApplicationDev;

partial class DialogueForm
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
        btnOption1 = new Button();
        btnOption2 = new Button();
        lblDialogue = new Label();
        lblRiz = new Label();
        lblConst = new Label();
        lblDex = new Label();
        lblIntel = new Label();
        lblAgility = new Label();
        lblStrength = new Label();
        lblNameRiz = new Label();
        lblNameConst = new Label();
        lblNameDex = new Label();
        lblNameIntel = new Label();
        lblNameAgility = new Label();
        lblNameStrength = new Label();
        label1 = new Label();
        SuspendLayout();
        // 
        // btnOption1
        // 
        btnOption1.Location = new Point(25, 38);
        btnOption1.Name = "btnOption1";
        btnOption1.Size = new Size(292, 34);
        btnOption1.TabIndex = 0;
        btnOption1.Text = "Hi!";
        btnOption1.UseVisualStyleBackColor = true;
        btnOption1.Click += btnOption1_Click;
        // 
        // btnOption2
        // 
        btnOption2.Location = new Point(478, 38);
        btnOption2.Name = "btnOption2";
        btnOption2.Size = new Size(287, 34);
        btnOption2.TabIndex = 1;
        btnOption2.Text = "Go Away";
        btnOption2.UseVisualStyleBackColor = true;
        btnOption2.Click += btnOption2_Click;
        // 
        // lblDialogue
        // 
        lblDialogue.AutoSize = true;
        lblDialogue.Location = new Point(36, 129);
        lblDialogue.Name = "lblDialogue";
        lblDialogue.Size = new Size(154, 25);
        lblDialogue.TabIndex = 2;
        lblDialogue.Text = "Welcome Traveler!";
        // 
        // lblRiz
        // 
        lblRiz.AutoSize = true;
        lblRiz.Location = new Point(1022, 240);
        lblRiz.Name = "lblRiz";
        lblRiz.Size = new Size(22, 25);
        lblRiz.TabIndex = 27;
        lblRiz.Text = "0";
        // 
        // lblConst
        // 
        lblConst.AutoSize = true;
        lblConst.Location = new Point(1022, 215);
        lblConst.Name = "lblConst";
        lblConst.Size = new Size(22, 25);
        lblConst.TabIndex = 26;
        lblConst.Text = "0";
        // 
        // lblDex
        // 
        lblDex.AutoSize = true;
        lblDex.Location = new Point(1022, 190);
        lblDex.Name = "lblDex";
        lblDex.Size = new Size(22, 25);
        lblDex.TabIndex = 25;
        lblDex.Text = "0";
        // 
        // lblIntel
        // 
        lblIntel.AutoSize = true;
        lblIntel.Location = new Point(1022, 165);
        lblIntel.Name = "lblIntel";
        lblIntel.Size = new Size(22, 25);
        lblIntel.TabIndex = 24;
        lblIntel.Text = "0";
        // 
        // lblAgility
        // 
        lblAgility.AutoSize = true;
        lblAgility.Location = new Point(1022, 140);
        lblAgility.Name = "lblAgility";
        lblAgility.Size = new Size(22, 25);
        lblAgility.TabIndex = 23;
        lblAgility.Text = "0";
        // 
        // lblStrength
        // 
        lblStrength.AutoSize = true;
        lblStrength.Location = new Point(1022, 115);
        lblStrength.Name = "lblStrength";
        lblStrength.Size = new Size(22, 25);
        lblStrength.TabIndex = 22;
        lblStrength.Text = "0";
        // 
        // lblNameRiz
        // 
        lblNameRiz.AutoSize = true;
        lblNameRiz.Location = new Point(902, 240);
        lblNameRiz.Name = "lblNameRiz";
        lblNameRiz.Size = new Size(85, 25);
        lblNameRiz.TabIndex = 21;
        lblNameRiz.Text = "Charisma";
        // 
        // lblNameConst
        // 
        lblNameConst.AutoSize = true;
        lblNameConst.Location = new Point(902, 215);
        lblNameConst.Name = "lblNameConst";
        lblNameConst.Size = new Size(109, 25);
        lblNameConst.TabIndex = 20;
        lblNameConst.Text = "Constitution";
        // 
        // lblNameDex
        // 
        lblNameDex.AutoSize = true;
        lblNameDex.Location = new Point(902, 190);
        lblNameDex.Name = "lblNameDex";
        lblNameDex.Size = new Size(82, 25);
        lblNameDex.TabIndex = 19;
        lblNameDex.Text = "Dexterity";
        // 
        // lblNameIntel
        // 
        lblNameIntel.AutoSize = true;
        lblNameIntel.Location = new Point(900, 165);
        lblNameIntel.Name = "lblNameIntel";
        lblNameIntel.Size = new Size(101, 25);
        lblNameIntel.TabIndex = 18;
        lblNameIntel.Text = "Intelligence";
        // 
        // lblNameAgility
        // 
        lblNameAgility.AutoSize = true;
        lblNameAgility.Location = new Point(900, 140);
        lblNameAgility.Name = "lblNameAgility";
        lblNameAgility.Size = new Size(62, 25);
        lblNameAgility.TabIndex = 17;
        lblNameAgility.Text = "Agility";
        // 
        // lblNameStrength
        // 
        lblNameStrength.AutoSize = true;
        lblNameStrength.Location = new Point(902, 115);
        lblNameStrength.Name = "lblNameStrength";
        lblNameStrength.Size = new Size(79, 25);
        lblNameStrength.TabIndex = 16;
        lblNameStrength.Text = "Strength";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(900, 86);
        label1.Name = "label1";
        label1.Size = new Size(72, 25);
        label1.TabIndex = 15;
        label1.Text = "STATUS";
        // 
        // DialogueForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1073, 314);
        Controls.Add(lblRiz);
        Controls.Add(lblConst);
        Controls.Add(lblDex);
        Controls.Add(lblIntel);
        Controls.Add(lblAgility);
        Controls.Add(lblStrength);
        Controls.Add(lblNameRiz);
        Controls.Add(lblNameConst);
        Controls.Add(lblNameDex);
        Controls.Add(lblNameIntel);
        Controls.Add(lblNameAgility);
        Controls.Add(lblNameStrength);
        Controls.Add(label1);
        Controls.Add(lblDialogue);
        Controls.Add(btnOption2);
        Controls.Add(btnOption1);
        Name = "DialogueForm";
        Text = "Dialogue Form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion


    private Button btnOption1;
    private Button btnOption2;
    private Label lblDialogue;
    private Label lblRiz;
    private Label lblConst;
    private Label lblDex;
    private Label lblIntel;
    private Label lblAgility;
    private Label lblStrength;
    private Label lblNameRiz;
    private Label lblNameConst;
    private Label lblNameDex;
    private Label lblNameIntel;
    private Label lblNameAgility;
    private Label lblNameStrength;
    private Label label1;
}
