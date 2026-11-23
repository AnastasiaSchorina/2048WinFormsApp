namespace _2048WinFormsApp
{
    partial class Result2048ShowForm
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
            result2048DataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            CloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)result2048DataGridView).BeginInit();
            SuspendLayout();
            // 
            // result2048DataGridView
            // 
            result2048DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            result2048DataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            result2048DataGridView.Location = new Point(23, 27);
            result2048DataGridView.Name = "result2048DataGridView";
            result2048DataGridView.RowHeadersWidth = 51;
            result2048DataGridView.Size = new Size(403, 188);
            result2048DataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Имя Игрока";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 220;
            // 
            // Column2
            // 
            Column2.HeaderText = "Кол-во баллов";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 130;
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CloseButton.Location = new Point(133, 238);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(172, 43);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Закрыть";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseFormButton_Click;
            // 
            // Result2048ShowForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 293);
            Controls.Add(CloseButton);
            Controls.Add(result2048DataGridView);
            Name = "Result2048ShowForm";
            Text = "Результаты игры";
            ((System.ComponentModel.ISupportInitialize)result2048DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView result2048DataGridView;
        private Button CloseButton;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
    }
}