namespace BikiAndKorovi
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
            themeComboBox = new ComboBox();
            label1 = new Label();
            choiceButton = new Button();
            errorLabel = new Label();
            SuspendLayout();
            // 
            // themeComboBox
            // 
            themeComboBox.FormattingEnabled = true;
            themeComboBox.Items.AddRange(new object[] { "Природа", "Животные", "Еда", "Одежда", "Человек" });
            themeComboBox.Location = new Point(49, 81);
            themeComboBox.Name = "themeComboBox";
            themeComboBox.Size = new Size(121, 23);
            themeComboBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(140, 9);
            label1.Name = "label1";
            label1.Size = new Size(212, 32);
            label1.TabIndex = 1;
            label1.Text = "Выбор темы игры";
            // 
            // choiceButton
            // 
            choiceButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            choiceButton.Location = new Point(275, 74);
            choiceButton.Name = "choiceButton";
            choiceButton.Size = new Size(97, 32);
            choiceButton.TabIndex = 2;
            choiceButton.Text = "Выбрать";
            choiceButton.UseVisualStyleBackColor = true;
            choiceButton.Click += choiceButton_Click;
            // 
            // errorLabel
            // 
            errorLabel.AutoSize = true;
            errorLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            errorLabel.Location = new Point(50, 142);
            errorLabel.Name = "errorLabel";
            errorLabel.Size = new Size(0, 17);
            errorLabel.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(480, 186);
            Controls.Add(errorLabel);
            Controls.Add(choiceButton);
            Controls.Add(label1);
            Controls.Add(themeComboBox);
            Name = "Form2";
            Text = "Выбор темы";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox themeComboBox;
        private Label label1;
        private Button choiceButton;
        private Label errorLabel;
    }
}