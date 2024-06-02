namespace AutoWriteApp
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            textBox = new TextBox();
            buttonEnter = new Button();
            Stop = new Button();
            Exit = new Button();
            GitHub = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top;
            textBox.Font = new Font("Arial Rounded MT Bold", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox.Location = new Point(12, 11);
            textBox.Name = "textBox";
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(402, 50);
            textBox.TabIndex = 0;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // buttonEnter
            // 
            buttonEnter.Anchor = AnchorStyles.Top;
            buttonEnter.BackgroundImage = (Image)resources.GetObject("buttonEnter.BackgroundImage");
            buttonEnter.Cursor = Cursors.Hand;
            buttonEnter.Location = new Point(233, 67);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(179, 76);
            buttonEnter.TabIndex = 1;
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // Stop
            // 
            Stop.Anchor = AnchorStyles.Top;
            Stop.BackgroundImage = (Image)resources.GetObject("Stop.BackgroundImage");
            Stop.Cursor = Cursors.Hand;
            Stop.Location = new Point(233, 149);
            Stop.Name = "Stop";
            Stop.Size = new Size(179, 77);
            Stop.TabIndex = 2;
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Exit
            // 
            Exit.Anchor = AnchorStyles.Top;
            Exit.BackgroundImage = (Image)resources.GetObject("Exit.BackgroundImage");
            Exit.Cursor = Cursors.Hand;
            Exit.Location = new Point(12, 146);
            Exit.Name = "Exit";
            Exit.Size = new Size(179, 77);
            Exit.TabIndex = 3;
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // GitHub
            // 
            GitHub.Anchor = AnchorStyles.Top;
            GitHub.BackgroundImage = (Image)resources.GetObject("GitHub.BackgroundImage");
            GitHub.Cursor = Cursors.Help;
            GitHub.Location = new Point(12, 66);
            GitHub.Name = "GitHub";
            GitHub.Size = new Size(179, 77);
            GitHub.TabIndex = 4;
            GitHub.UseVisualStyleBackColor = true;
            GitHub.Click += GitHub_Click;
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(424, 235);
            Controls.Add(GitHub);
            Controls.Add(Exit);
            Controls.Add(Stop);
            Controls.Add(buttonEnter);
            Controls.Add(textBox);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Auto Write";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button buttonEnter;
        private Button Stop;
        private Button Exit;
        private Label labelContacts;
        private Button GitHub;
    }
}
