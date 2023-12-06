namespace KnightsOfTheNewRepublic
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(688, 153);
            label1.Name = "label1";
            label1.Size = new Size(359, 41);
            label1.TabIndex = 0;
            label1.Text = "Bob Robert Son of Bobert";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(688, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1150, 47);
            textBox1.TabIndex = 1;
            textBox1.Text = "'elo mate!";
            // 
            // button1
            // 
            button1.Location = new Point(688, 273);
            button1.Name = "button1";
            button1.Size = new Size(410, 80);
            button1.TabIndex = 2;
            button1.Text = "How dare you! (Attack)";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(688, 383);
            button2.Name = "button2";
            button2.Size = new Size(188, 58);
            button2.TabIndex = 3;
            button2.Text = "Hello there!";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(688, 502);
            button3.Name = "button3";
            button3.Size = new Size(559, 58);
            button3.TabIndex = 4;
            button3.Text = "Hello there! (seductive, charisma)";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2277, 957);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}