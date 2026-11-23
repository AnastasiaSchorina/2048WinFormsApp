namespace _2048WinFormsApp
{
    partial class Rule2048Form
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
            targetGameLabel = new Label();
            targetTextLabel = new Label();
            moveTextLabel = new Label();
            moveTileLabel = new Label();
            endTextLabel = new Label();
            endGameLabel = new Label();
            closeFormButton = new Button();
            SuspendLayout();
            // 
            // targetGameLabel
            // 
            targetGameLabel.AutoSize = true;
            targetGameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            targetGameLabel.Location = new Point(14, 24);
            targetGameLabel.Name = "targetGameLabel";
            targetGameLabel.Size = new Size(122, 28);
            targetGameLabel.TabIndex = 0;
            targetGameLabel.Text = "Цель игры:";
            // 
            // targetTextLabel
            // 
            targetTextLabel.AutoSize = true;
            targetTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            targetTextLabel.Location = new Point(140, 24);
            targetTextLabel.Name = "targetTextLabel";
            targetTextLabel.Size = new Size(304, 28);
            targetTextLabel.TabIndex = 1;
            targetTextLabel.Text = "собрать плитку с цифрой 2048. ";
            // 
            // moveTextLabel
            // 
            moveTextLabel.AutoSize = true;
            moveTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            moveTextLabel.Location = new Point(218, 103);
            moveTextLabel.Name = "moveTextLabel";
            moveTextLabel.Size = new Size(388, 168);
            moveTextLabel.TabIndex = 3;
            moveTextLabel.Text = "плитки можно двигать в стороны, чтобы\r\nобъединять одинаковые числа.\r\n\r\n\r\n\r\n\r\n";
            // 
            // moveTileLabel
            // 
            moveTileLabel.AutoSize = true;
            moveTileLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            moveTileLabel.Location = new Point(14, 103);
            moveTileLabel.Name = "moveTileLabel";
            moveTileLabel.Size = new Size(198, 28);
            moveTileLabel.TabIndex = 2;
            moveTileLabel.Text = "Движение плиток:";
            // 
            // endTextLabel
            // 
            endTextLabel.AutoSize = true;
            endTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            endTextLabel.Location = new Point(151, 196);
            endTextLabel.Name = "endTextLabel";
            endTextLabel.Size = new Size(348, 84);
            endTextLabel.TabIndex = 5;
            endTextLabel.Text = "игра заканчивается, если все клетки \r\nзаполнены и нет доступных ходов.\r\n\r\n";
            // 
            // endGameLabel
            // 
            endGameLabel.AutoSize = true;
            endGameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            endGameLabel.Location = new Point(12, 196);
            endGameLabel.Name = "endGameLabel";
            endGameLabel.Size = new Size(133, 28);
            endGameLabel.TabIndex = 4;
            endGameLabel.Text = "Конец игры:";
            // 
            // closeFormButton
            // 
            closeFormButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            closeFormButton.Location = new Point(218, 274);
            closeFormButton.Name = "closeFormButton";
            closeFormButton.Size = new Size(172, 38);
            closeFormButton.TabIndex = 6;
            closeFormButton.Text = "Выход";
            closeFormButton.UseVisualStyleBackColor = true;
            closeFormButton.Click += CloseFormButton_Click;
            // 
            // Rule2048Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 332);
            Controls.Add(closeFormButton);
            Controls.Add(endTextLabel);
            Controls.Add(endGameLabel);
            Controls.Add(moveTextLabel);
            Controls.Add(moveTileLabel);
            Controls.Add(targetTextLabel);
            Controls.Add(targetGameLabel);
            Name = "Rule2048Form";
            Text = "Правила игры";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label targetGameLabel;
        private Label targetTextLabel;
        private Label moveTextLabel;
        private Label moveTileLabel;
        private Label endTextLabel;
        private Label endGameLabel;
        private Button closeFormButton;
    }
}