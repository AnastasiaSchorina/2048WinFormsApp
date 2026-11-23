namespace _2048WinFormsApp
{
    partial class MainForm
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
            scoreLabel = new Label();
            menuStrip1 = new MenuStrip();
            менюToolStripMenuItem = new ToolStripMenuItem();
            начатьЗановоToolStripMenuItem = new ToolStripMenuItem();
            правилаИгрыToolStripMenuItem = new ToolStripMenuItem();
            просмотрРезультатовToolStripMenuItem = new ToolStripMenuItem();
            выборПоляИгрыToolStripMenuItem = new ToolStripMenuItem();
            x2ToolStripMenuItem = new ToolStripMenuItem();
            x3ToolStripMenuItem = new ToolStripMenuItem();
            x4ToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            maxNumberLabel = new Label();
            maxScoreLabel = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 0;
            label1.Text = "Счет:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            scoreLabel.Location = new Point(75, 28);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(22, 25);
            scoreLabel.TabIndex = 1;
            scoreLabel.Text = "0";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { менюToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(401, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            менюToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { начатьЗановоToolStripMenuItem, правилаИгрыToolStripMenuItem, просмотрРезультатовToolStripMenuItem, выборПоляИгрыToolStripMenuItem, выходToolStripMenuItem });
            менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            менюToolStripMenuItem.Size = new Size(65, 24);
            менюToolStripMenuItem.Text = "Меню";
            // 
            // начатьЗановоToolStripMenuItem
            // 
            начатьЗановоToolStripMenuItem.Name = "начатьЗановоToolStripMenuItem";
            начатьЗановоToolStripMenuItem.Size = new Size(251, 26);
            начатьЗановоToolStripMenuItem.Text = "Начать заново";
            начатьЗановоToolStripMenuItem.Click += начатьЗановоToolStripMenuItem_Click;
            // 
            // правилаИгрыToolStripMenuItem
            // 
            правилаИгрыToolStripMenuItem.Name = "правилаИгрыToolStripMenuItem";
            правилаИгрыToolStripMenuItem.Size = new Size(251, 26);
            правилаИгрыToolStripMenuItem.Text = "Правила игры";
            правилаИгрыToolStripMenuItem.Click += правилаИгрыToolStripMenuItem_Click;
            // 
            // просмотрРезультатовToolStripMenuItem
            // 
            просмотрРезультатовToolStripMenuItem.Name = "просмотрРезультатовToolStripMenuItem";
            просмотрРезультатовToolStripMenuItem.Size = new Size(251, 26);
            просмотрРезультатовToolStripMenuItem.Text = "Просмотр результатов";
            просмотрРезультатовToolStripMenuItem.Click += просмотрРезультатовToolStripMenuItem_Click;
            // 
            // выборПоляИгрыToolStripMenuItem
            // 
            выборПоляИгрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { x2ToolStripMenuItem, x3ToolStripMenuItem, x4ToolStripMenuItem });
            выборПоляИгрыToolStripMenuItem.Name = "выборПоляИгрыToolStripMenuItem";
            выборПоляИгрыToolStripMenuItem.Size = new Size(251, 26);
            выборПоляИгрыToolStripMenuItem.Text = "Выбор поля игры";
            // 
            // x2ToolStripMenuItem
            // 
            x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
            x2ToolStripMenuItem.Size = new Size(224, 26);
            x2ToolStripMenuItem.Text = "3x3";
            x2ToolStripMenuItem.Click += x3ToolStripMenuItem_Click;
            // 
            // x3ToolStripMenuItem
            // 
            x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
            x3ToolStripMenuItem.Size = new Size(224, 26);
            x3ToolStripMenuItem.Text = "4x4";
            x3ToolStripMenuItem.Click += x4ToolStripMenuItem_Click;
            // 
            // x4ToolStripMenuItem
            // 
            x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
            x4ToolStripMenuItem.Size = new Size(224, 26);
            x4ToolStripMenuItem.Text = "5x5";
            x4ToolStripMenuItem.Click += x5ToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(251, 26);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // maxNumberLabel
            // 
            maxNumberLabel.AutoSize = true;
            maxNumberLabel.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            maxNumberLabel.Location = new Point(328, 28);
            maxNumberLabel.Name = "maxNumberLabel";
            maxNumberLabel.Size = new Size(22, 25);
            maxNumberLabel.TabIndex = 4;
            maxNumberLabel.Text = "0";
            // 
            // maxScoreLabel
            // 
            maxScoreLabel.AutoSize = true;
            maxScoreLabel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            maxScoreLabel.Location = new Point(225, 28);
            maxScoreLabel.Name = "maxScoreLabel";
            maxScoreLabel.Size = new Size(97, 25);
            maxScoreLabel.TabIndex = 3;
            maxScoreLabel.Text = "Max cчет:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 366);
            Controls.Add(maxNumberLabel);
            Controls.Add(maxScoreLabel);
            Controls.Add(scoreLabel);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "2048";
            Load += Form1_Load;
            KeyDown += MainForm_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreLabel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem начатьЗановоToolStripMenuItem;
        private ToolStripMenuItem правилаИгрыToolStripMenuItem;
        private ToolStripMenuItem просмотрРезультатовToolStripMenuItem;
        private ToolStripMenuItem выборПоляИгрыToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label maxNumberLabel;
        private Label maxScoreLabel;
        private ToolStripMenuItem x2ToolStripMenuItem;
        private ToolStripMenuItem x3ToolStripMenuItem;
        private ToolStripMenuItem x4ToolStripMenuItem;
    }
}
