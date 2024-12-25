namespace BikiAndKorovi
{
    partial class Form3
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
            wordDesc = new Label();
            label2 = new Label();
            label3 = new Label();
            countOfAttempts = new Label();
            charInputBox = new TextBox();
            InputButton = new Button();
            wordLabel = new Label();
            resultAnswerLabel = new Label();
            label1 = new Label();
            userWord = new Label();
            clearButton = new Button();
            checkButton = new Button();
            SuspendLayout();
            // 
            // wordDesc
            // 
            wordDesc.AutoSize = true;
            wordDesc.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            wordDesc.Location = new Point(265, 20);
            wordDesc.Name = "wordDesc";
            wordDesc.Size = new Size(83, 32);
            wordDesc.TabIndex = 0;
            wordDesc.Text = "Слово";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(73, 101);
            label2.Name = "label2";
            label2.Size = new Size(116, 21);
            label2.TabIndex = 1;
            label2.Text = "Введите букву:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.WindowFrame;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(81, 151);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 2;
            // 
            // countOfAttempts
            // 
            countOfAttempts.AutoSize = true;
            countOfAttempts.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            countOfAttempts.Location = new Point(492, 263);
            countOfAttempts.Name = "countOfAttempts";
            countOfAttempts.Size = new Size(146, 17);
            countOfAttempts.TabIndex = 3;
            countOfAttempts.Text = "Количество попыток: 0";
            // 
            // charInputBox
            // 
            charInputBox.Location = new Point(81, 131);
            charInputBox.Name = "charInputBox";
            charInputBox.Size = new Size(32, 23);
            charInputBox.TabIndex = 4;
            // 
            // InputButton
            // 
            InputButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            InputButton.Location = new Point(119, 129);
            InputButton.Name = "InputButton";
            InputButton.Size = new Size(71, 26);
            InputButton.TabIndex = 5;
            InputButton.Text = "Ввести";
            InputButton.UseVisualStyleBackColor = true;
            InputButton.Click += InputButton_Click;
            // 
            // wordLabel
            // 
            wordLabel.AutoSize = true;
            wordLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            wordLabel.Location = new Point(420, 128);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(0, 30);
            wordLabel.TabIndex = 6;
            // 
            // resultAnswerLabel
            // 
            resultAnswerLabel.AutoSize = true;
            resultAnswerLabel.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            resultAnswerLabel.Location = new Point(81, 234);
            resultAnswerLabel.Name = "resultAnswerLabel";
            resultAnswerLabel.Size = new Size(0, 21);
            resultAnswerLabel.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(85, 190);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 8;
            // 
            // userWord
            // 
            userWord.AutoSize = true;
            userWord.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            userWord.Location = new Point(451, 136);
            userWord.Name = "userWord";
            userWord.Size = new Size(0, 20);
            userWord.TabIndex = 9;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearButton.Location = new Point(289, 127);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(71, 30);
            clearButton.TabIndex = 10;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // checkButton
            // 
            checkButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkButton.Location = new Point(196, 127);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(86, 28);
            checkButton.TabIndex = 11;
            checkButton.Text = "Проверить";
            checkButton.TextAlign = ContentAlignment.TopRight;
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 309);
            Controls.Add(checkButton);
            Controls.Add(clearButton);
            Controls.Add(userWord);
            Controls.Add(label1);
            Controls.Add(resultAnswerLabel);
            Controls.Add(wordLabel);
            Controls.Add(InputButton);
            Controls.Add(charInputBox);
            Controls.Add(countOfAttempts);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(wordDesc);
            Name = "Form3";
            Text = "Быки и Коровы";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label wordDesc;
        private Label label2;
        private Label label3;
        private Label countOfAttempts;
        private TextBox charInputBox;
        private Button InputButton;
        private Label wordLabel;
        private Label resultAnswerLabel;
        private Label label1;
        private Label userWord;
        private Button clearButton;
        private Button checkButton;
    }
}