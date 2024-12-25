namespace BikiAndKorovi
{
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            playButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // playButton
            // 
            playButton.BackgroundImage = (Image)resources.GetObject("playButton.BackgroundImage");
            playButton.Font = new Font("Century", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            playButton.Location = new Point(238, 148);
            playButton.Name = "playButton";
            playButton.Size = new Size(224, 113);
            playButton.TabIndex = 0;
            playButton.Text = "ИГРАТЬ";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(2, 25);
            label1.Name = "label1";
            label1.Size = new Size(699, 50);
            label1.TabIndex = 1;
            label1.Text = "Быки и коровы на осетинском языке";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(699, 450);
            Controls.Add(label1);
            Controls.Add(playButton);
            KeyPreview = true;
            Name = "Form1";
            Text = "Быки и Коровы";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button playButton;
        private Label label1;
    }
}
