namespace ApplicationDev;

partial class CharacterCreationForm
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
        strength = new Label();
        intelligence = new Label();
        dexterity = new Label();
        constitution = new Label();
        forcePower = new Label();
        charisma = new Label();
        stats = new Label();
        strLvl = new Label();
        intLvl = new Label();
        dexLvl = new Label();
        constLvl = new Label();
        forceLvl = new Label();
        rizLvl = new Label();
        strInput = new TextBox();
        agilityInput = new TextBox();
        intelInput = new TextBox();
        constInput = new TextBox();
        dexInput = new TextBox();
        rizInput = new TextBox();
        btnCreateCharacter = new Button();
        txtName = new TextBox();
        cmbCharacterClass = new ComboBox();
        lblDialogue = new Label();
        SuspendLayout();
        // 
        // strength
        // 
        strength.AutoSize = true;
        strength.Location = new Point(191, 60);
        strength.Name = "strength";
        strength.Size = new Size(78, 25);
        strength.TabIndex = 0;
        strength.Text = "strength";
        // 
        // intelligence
        // 
        intelligence.AutoSize = true;
        intelligence.Location = new Point(191, 95);
        intelligence.Name = "intelligence";
        intelligence.Size = new Size(100, 25);
        intelligence.TabIndex = 1;
        intelligence.Text = "intelligence";
        // 
        // dexterity
        // 
        dexterity.AutoSize = true;
        dexterity.Location = new Point(191, 130);
        dexterity.Name = "dexterity";
        dexterity.Size = new Size(80, 25);
        dexterity.TabIndex = 2;
        dexterity.Text = "dexterity";
        // 
        // constitution
        // 
        constitution.AutoSize = true;
        constitution.Location = new Point(191, 164);
        constitution.Name = "constitution";
        constitution.Size = new Size(106, 25);
        constitution.TabIndex = 3;
        constitution.Text = "constitution";
        // 
        // forcePower
        // 
        forcePower.AutoSize = true;
        forcePower.Location = new Point(191, 200);
        forcePower.Name = "forcePower";
        forcePower.Size = new Size(62, 25);
        forcePower.TabIndex = 4;
        forcePower.Text = "Agility";
        // 
        // charisma
        // 
        charisma.AutoSize = true;
        charisma.Location = new Point(191, 236);
        charisma.Name = "charisma";
        charisma.Size = new Size(82, 25);
        charisma.TabIndex = 5;
        charisma.Text = "charisma";
        // 
        // stats
        // 
        stats.AutoSize = true;
        stats.Location = new Point(253, 21);
        stats.Name = "stats";
        stats.Size = new Size(60, 25);
        stats.TabIndex = 6;
        stats.Text = "STATS";
        // 
        // strLvl
        // 
        strLvl.AutoSize = true;
        strLvl.Location = new Point(332, 60);
        strLvl.Name = "strLvl";
        strLvl.Size = new Size(42, 25);
        strLvl.TabIndex = 7;
        strLvl.Text = "900";
        // 
        // intLvl
        // 
        intLvl.AutoSize = true;
        intLvl.Location = new Point(332, 95);
        intLvl.Name = "intLvl";
        intLvl.Size = new Size(42, 25);
        intLvl.TabIndex = 8;
        intLvl.Text = "900";
        // 
        // dexLvl
        // 
        dexLvl.AutoSize = true;
        dexLvl.Location = new Point(332, 130);
        dexLvl.Name = "dexLvl";
        dexLvl.Size = new Size(42, 25);
        dexLvl.TabIndex = 9;
        dexLvl.Text = "900";
        dexLvl.Click += dexLvl_Click;
        // 
        // constLvl
        // 
        constLvl.AutoSize = true;
        constLvl.Location = new Point(332, 164);
        constLvl.Name = "constLvl";
        constLvl.Size = new Size(42, 25);
        constLvl.TabIndex = 10;
        constLvl.Text = "900";
        // 
        // forceLvl
        // 
        forceLvl.AutoSize = true;
        forceLvl.Location = new Point(332, 200);
        forceLvl.Name = "forceLvl";
        forceLvl.Size = new Size(42, 25);
        forceLvl.TabIndex = 11;
        forceLvl.Text = "900";
        // 
        // rizLvl
        // 
        rizLvl.AutoSize = true;
        rizLvl.Location = new Point(332, 236);
        rizLvl.Name = "rizLvl";
        rizLvl.Size = new Size(42, 25);
        rizLvl.TabIndex = 12;
        rizLvl.Text = "900";
        // 
        // strInput
        // 
        strInput.Location = new Point(35, 55);
        strInput.Name = "strInput";
        strInput.Size = new Size(150, 31);
        strInput.TabIndex = 13;
        // 
        // agilityInput
        // 
        agilityInput.Location = new Point(35, 200);
        agilityInput.Name = "agilityInput";
        agilityInput.Size = new Size(150, 31);
        agilityInput.TabIndex = 14;
        // 
        // intelInput
        // 
        intelInput.Location = new Point(35, 92);
        intelInput.Name = "intelInput";
        intelInput.Size = new Size(150, 31);
        intelInput.TabIndex = 15;
        // 
        // constInput
        // 
        constInput.Location = new Point(35, 161);
        constInput.Name = "constInput";
        constInput.Size = new Size(150, 31);
        constInput.TabIndex = 16;
        // 
        // dexInput
        // 
        dexInput.Location = new Point(35, 127);
        dexInput.Name = "dexInput";
        dexInput.Size = new Size(150, 31);
        dexInput.TabIndex = 17;
        // 
        // rizInput
        // 
        rizInput.Location = new Point(35, 237);
        rizInput.Name = "rizInput";
        rizInput.Size = new Size(150, 31);
        rizInput.TabIndex = 18;
        // 
        // btnCreateCharacter
        // 
        btnCreateCharacter.Location = new Point(100, 339);
        btnCreateCharacter.Name = "btnCreateCharacter";
        btnCreateCharacter.Size = new Size(213, 34);
        btnCreateCharacter.TabIndex = 19;
        btnCreateCharacter.Text = "Create Character";
        btnCreateCharacter.UseVisualStyleBackColor = true;
        btnCreateCharacter.Click += btnCreateCharacter_Click;
        // 
        // txtName
        // 
        txtName.Location = new Point(35, 289);
        txtName.Name = "txtName";
        txtName.Size = new Size(150, 31);
        txtName.TabIndex = 20;
        txtName.Text = "Name";
        txtName.TextChanged += txtName_TextChanged;
        // 
        // cmbCharacterClass
        // 
        cmbCharacterClass.FormattingEnabled = true;
        cmbCharacterClass.Items.AddRange(new object[] { "Wizard", "Sorcerer", "Barbarian", "Warlock", "Rogue", "Ranger", "Druid", "Paladin", "Fighter" });
        cmbCharacterClass.Location = new Point(192, 289);
        cmbCharacterClass.Name = "cmbCharacterClass";
        cmbCharacterClass.Size = new Size(182, 33);
        cmbCharacterClass.TabIndex = 21;
        cmbCharacterClass.Text = "Class";
        // 
        // lblDialogue
        // 
        lblDialogue.AutoSize = true;
        lblDialogue.Location = new Point(331, 658);
        lblDialogue.Name = "lblDialogue";
        lblDialogue.Size = new Size(0, 25);
        lblDialogue.TabIndex = 22;
        // 
        // CharacterCreationForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(447, 395);
        Controls.Add(lblDialogue);
        Controls.Add(cmbCharacterClass);
        Controls.Add(txtName);
        Controls.Add(btnCreateCharacter);
        Controls.Add(rizInput);
        Controls.Add(dexInput);
        Controls.Add(constInput);
        Controls.Add(intelInput);
        Controls.Add(agilityInput);
        Controls.Add(strInput);
        Controls.Add(rizLvl);
        Controls.Add(forceLvl);
        Controls.Add(constLvl);
        Controls.Add(dexLvl);
        Controls.Add(intLvl);
        Controls.Add(strLvl);
        Controls.Add(stats);
        Controls.Add(charisma);
        Controls.Add(forcePower);
        Controls.Add(constitution);
        Controls.Add(dexterity);
        Controls.Add(intelligence);
        Controls.Add(strength);
        Name = "CharacterCreationForm";
        Text = "Character Creation Form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label strength;
    private Label intelligence;
    private Label dexterity;
    private Label constitution;
    private Label forcePower;
    private Label charisma;
    private Label stats;
    private Label strLvl;
    private Label intLvl;
    private Label dexLvl;
    private Label constLvl;
    private Label forceLvl;
    private Label rizLvl;
    private TextBox strInput;
    private TextBox agilityInput;
    private TextBox intelInput;
    private TextBox constInput;
    private TextBox dexInput;
    private TextBox rizInput;
    private Button btnCreateCharacter;
    private TextBox txtName;
    private ComboBox cmbCharacterClass;
    private Label lblDialogue;

}
