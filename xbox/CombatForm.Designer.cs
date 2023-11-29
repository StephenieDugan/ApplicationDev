namespace ApplicationDev;

partial class CombatForm
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
        lblPlayerHealth = new Label();
        lblEnemyHealth = new Label();
        label1 = new Label();
        lblNameStrength = new Label();
        lblNameAgility = new Label();
        lblNameIntel = new Label();
        lblNameDex = new Label();
        lblNameConst = new Label();
        lblNameRiz = new Label();
        lblStrength = new Label();
        lblAgility = new Label();
        lblIntel = new Label();
        lblDex = new Label();
        lblConst = new Label();
        lblRiz = new Label();
        AttackEnemy = new Button();
        DefendPlayer = new Button();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        label6 = new Label();
        label7 = new Label();
        lblName = new Label();
        lblEnemyName = new Label();
        lblClass = new Label();
        lblEnemyClass = new Label();
        lblWinLose = new Label();
        btnCastSpell = new Button();
        label8 = new Label();
        lblhasSword = new Label();
        lblhasShield = new Label();
        lblNarrate = new Label();
        SuspendLayout();
        // 
        // lblPlayerHealth
        // 
        lblPlayerHealth.AutoSize = true;
        lblPlayerHealth.Location = new Point(134, 13);
        lblPlayerHealth.Name = "lblPlayerHealth";
        lblPlayerHealth.Size = new Size(22, 25);
        lblPlayerHealth.TabIndex = 0;
        lblPlayerHealth.Text = "0";
        // 
        // lblEnemyHealth
        // 
        lblEnemyHealth.AutoSize = true;
        lblEnemyHealth.Location = new Point(732, 13);
        lblEnemyHealth.Name = "lblEnemyHealth";
        lblEnemyHealth.Size = new Size(22, 25);
        lblEnemyHealth.TabIndex = 1;
        lblEnemyHealth.Text = "0";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 100);
        label1.Name = "label1";
        label1.Size = new Size(72, 25);
        label1.TabIndex = 2;
        label1.Text = "STATUS";
        // 
        // lblNameStrength
        // 
        lblNameStrength.AutoSize = true;
        lblNameStrength.Location = new Point(14, 129);
        lblNameStrength.Name = "lblNameStrength";
        lblNameStrength.Size = new Size(79, 25);
        lblNameStrength.TabIndex = 3;
        lblNameStrength.Text = "Strength";
        // 
        // lblNameAgility
        // 
        lblNameAgility.AutoSize = true;
        lblNameAgility.Location = new Point(12, 154);
        lblNameAgility.Name = "lblNameAgility";
        lblNameAgility.Size = new Size(62, 25);
        lblNameAgility.TabIndex = 4;
        lblNameAgility.Text = "Agility";
        // 
        // lblNameIntel
        // 
        lblNameIntel.AutoSize = true;
        lblNameIntel.Location = new Point(12, 179);
        lblNameIntel.Name = "lblNameIntel";
        lblNameIntel.Size = new Size(101, 25);
        lblNameIntel.TabIndex = 5;
        lblNameIntel.Text = "Intelligence";
        // 
        // lblNameDex
        // 
        lblNameDex.AutoSize = true;
        lblNameDex.Location = new Point(14, 204);
        lblNameDex.Name = "lblNameDex";
        lblNameDex.Size = new Size(82, 25);
        lblNameDex.TabIndex = 6;
        lblNameDex.Text = "Dexterity";
        // 
        // lblNameConst
        // 
        lblNameConst.AutoSize = true;
        lblNameConst.Location = new Point(14, 229);
        lblNameConst.Name = "lblNameConst";
        lblNameConst.Size = new Size(109, 25);
        lblNameConst.TabIndex = 7;
        lblNameConst.Text = "Constitution";
        // 
        // lblNameRiz
        // 
        lblNameRiz.AutoSize = true;
        lblNameRiz.Location = new Point(14, 254);
        lblNameRiz.Name = "lblNameRiz";
        lblNameRiz.Size = new Size(85, 25);
        lblNameRiz.TabIndex = 8;
        lblNameRiz.Text = "Charisma";
        // 
        // lblStrength
        // 
        lblStrength.AutoSize = true;
        lblStrength.Location = new Point(134, 129);
        lblStrength.Name = "lblStrength";
        lblStrength.Size = new Size(22, 25);
        lblStrength.TabIndex = 9;
        lblStrength.Text = "0";
        // 
        // lblAgility
        // 
        lblAgility.AutoSize = true;
        lblAgility.Location = new Point(134, 154);
        lblAgility.Name = "lblAgility";
        lblAgility.Size = new Size(22, 25);
        lblAgility.TabIndex = 10;
        lblAgility.Text = "0";
        // 
        // lblIntel
        // 
        lblIntel.AutoSize = true;
        lblIntel.Location = new Point(134, 179);
        lblIntel.Name = "lblIntel";
        lblIntel.Size = new Size(22, 25);
        lblIntel.TabIndex = 11;
        lblIntel.Text = "0";
        // 
        // lblDex
        // 
        lblDex.AutoSize = true;
        lblDex.Location = new Point(134, 204);
        lblDex.Name = "lblDex";
        lblDex.Size = new Size(22, 25);
        lblDex.TabIndex = 12;
        lblDex.Text = "0";
        // 
        // lblConst
        // 
        lblConst.AutoSize = true;
        lblConst.Location = new Point(134, 229);
        lblConst.Name = "lblConst";
        lblConst.Size = new Size(22, 25);
        lblConst.TabIndex = 13;
        lblConst.Text = "0";
        // 
        // lblRiz
        // 
        lblRiz.AutoSize = true;
        lblRiz.Location = new Point(134, 254);
        lblRiz.Name = "lblRiz";
        lblRiz.Size = new Size(22, 25);
        lblRiz.TabIndex = 14;
        lblRiz.Text = "0";
        // 
        // AttackEnemy
        // 
        AttackEnemy.Location = new Point(600, 265);
        AttackEnemy.Name = "AttackEnemy";
        AttackEnemy.Size = new Size(176, 34);
        AttackEnemy.TabIndex = 15;
        AttackEnemy.Text = "Attack Enemy";
        AttackEnemy.UseVisualStyleBackColor = true;
        AttackEnemy.Click += AttackEnemy_Click;
        // 
        // DefendPlayer
        // 
        DefendPlayer.Location = new Point(600, 204);
        DefendPlayer.Name = "DefendPlayer";
        DefendPlayer.Size = new Size(176, 34);
        DefendPlayer.TabIndex = 16;
        DefendPlayer.Text = "Defend Yourself";
        DefendPlayer.UseVisualStyleBackColor = true;
        DefendPlayer.Click += DefendPlayer_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 13);
        label2.Name = "label2";
        label2.Size = new Size(119, 25);
        label2.TabIndex = 17;
        label2.Text = "Player Health:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(589, 13);
        label3.Name = "label3";
        label3.Size = new Size(125, 25);
        label3.TabIndex = 18;
        label3.Text = "Enemy Health:";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(16, 40);
        label4.Name = "label4";
        label4.Size = new Size(63, 25);
        label4.TabIndex = 19;
        label4.Text = "Name:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(14, 65);
        label5.Name = "label5";
        label5.Size = new Size(56, 25);
        label5.TabIndex = 20;
        label5.Text = "Class:";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(587, 65);
        label6.Name = "label6";
        label6.Size = new Size(56, 25);
        label6.TabIndex = 22;
        label6.Text = "Class:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Location = new Point(589, 40);
        label7.Name = "label7";
        label7.Size = new Size(63, 25);
        label7.TabIndex = 21;
        label7.Text = "Name:";
        // 
        // lblName
        // 
        lblName.AutoSize = true;
        lblName.Location = new Point(80, 42);
        lblName.Name = "lblName";
        lblName.Size = new Size(0, 25);
        lblName.TabIndex = 23;
        // 
        // lblEnemyName
        // 
        lblEnemyName.AutoSize = true;
        lblEnemyName.Location = new Point(649, 41);
        lblEnemyName.Name = "lblEnemyName";
        lblEnemyName.Size = new Size(0, 25);
        lblEnemyName.TabIndex = 24;
        // 
        // lblClass
        // 
        lblClass.AutoSize = true;
        lblClass.Location = new Point(74, 65);
        lblClass.Name = "lblClass";
        lblClass.Size = new Size(0, 25);
        lblClass.TabIndex = 25;
        // 
        // lblEnemyClass
        // 
        lblEnemyClass.AutoSize = true;
        lblEnemyClass.Location = new Point(637, 67);
        lblEnemyClass.Name = "lblEnemyClass";
        lblEnemyClass.Size = new Size(0, 25);
        lblEnemyClass.TabIndex = 26;
        // 
        // lblWinLose
        // 
        lblWinLose.AutoSize = true;
        lblWinLose.Location = new Point(338, 460);
        lblWinLose.Name = "lblWinLose";
        lblWinLose.Size = new Size(0, 25);
        lblWinLose.TabIndex = 27;
        lblWinLose.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // btnCastSpell
        // 
        btnCastSpell.Location = new Point(600, 326);
        btnCastSpell.Name = "btnCastSpell";
        btnCastSpell.Size = new Size(176, 34);
        btnCastSpell.TabIndex = 28;
        btnCastSpell.Text = "Cast Spell";
        btnCastSpell.UseVisualStyleBackColor = true;
        btnCastSpell.Visible = false;
        btnCastSpell.Click += button1_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(11, 296);
        label8.Name = "label8";
        label8.Size = new Size(106, 25);
        label8.TabIndex = 29;
        label8.Text = "INVENTORY";
        // 
        // lblhasSword
        // 
        lblhasSword.AutoSize = true;
        lblhasSword.Location = new Point(17, 330);
        lblhasSword.Name = "lblhasSword";
        lblhasSword.Size = new Size(63, 25);
        lblhasSword.TabIndex = 30;
        lblhasSword.Text = "empty";
        // 
        // lblhasShield
        // 
        lblhasShield.AutoSize = true;
        lblhasShield.Location = new Point(17, 364);
        lblhasShield.Name = "lblhasShield";
        lblhasShield.Size = new Size(63, 25);
        lblhasShield.TabIndex = 31;
        lblhasShield.Text = "empty";
        // 
        // lblNarrate
        // 
        lblNarrate.AutoSize = true;
        lblNarrate.Location = new Point(341, 411);
        lblNarrate.Name = "lblNarrate";
        lblNarrate.Size = new Size(0, 25);
        lblNarrate.TabIndex = 32;
        // 
        // CombatForm
        // 
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(833, 603);
        Controls.Add(lblNarrate);
        Controls.Add(lblhasShield);
        Controls.Add(lblhasSword);
        Controls.Add(label8);
        Controls.Add(btnCastSpell);
        Controls.Add(lblWinLose);
        Controls.Add(lblEnemyClass);
        Controls.Add(lblClass);
        Controls.Add(lblEnemyName);
        Controls.Add(lblName);
        Controls.Add(label6);
        Controls.Add(label7);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(DefendPlayer);
        Controls.Add(AttackEnemy);
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
        Controls.Add(lblEnemyHealth);
        Controls.Add(lblPlayerHealth);
        Name = "CombatForm";
        Text = "Combat Form";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion


    private Label lblPlayerHealth;
    private Label lblEnemyHealth;
    private Label label1;
    private Label lblNameStrength;
    private Label lblNameAgility;
    private Label lblNameIntel;
    private Label lblNameDex;
    private Label lblNameConst;
    private Label lblNameRiz;
    private Label lblStrength;
    private Label lblAgility;
    private Label lblIntel;
    private Label lblDex;
    private Label lblConst;
    private Label lblRiz;
    private Button AttackEnemy;
    private Button DefendPlayer;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Label label6;
    private Label label7;
    private Label lblName;
    private Label lblEnemyName;
    private Label lblClass;
    private Label lblEnemyClass;
    private Label lblWinLose;
    private Button btnCastSpell;
    private Label label8;
    private Label lblhasSword;
    private Label lblhasShield;
    private Label lblNarrate;
}
