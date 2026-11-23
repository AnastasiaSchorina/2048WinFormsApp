namespace _2048WinFormsApp
{
    partial class UserNameForm
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
            userNameTextBox = new TextBox();
            OkButton = new Button();
            CancelButton = new Button();
            textLabel = new Label();
            SuspendLayout();
            // 
            // userNameTextBox
            // 
            userNameTextBox.Location = new Point(27, 53);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(213, 27);
            userNameTextBox.TabIndex = 0;
            // 
            // OkButton
            // 
            OkButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OkButton.Location = new Point(27, 100);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(96, 41);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ок";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += SaveUserNameButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CancelButton.Location = new Point(144, 100);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(96, 41);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CloseFormButton_Click;
            // 
            // textLabel
            // 
            textLabel.AutoSize = true;
            textLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textLabel.Location = new Point(58, 9);
            textLabel.Name = "textLabel";
            textLabel.Size = new Size(156, 28);
            textLabel.TabIndex = 3;
            textLabel.Text = "Как Вас зовут?";
            // 
            // UserNameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 156);
            Controls.Add(textLabel);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Controls.Add(userNameTextBox);
            Name = "UserNameForm";
            Text = "Введите свое имя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox userNameTextBox;
        private Button OkButton;
        private Button CancelButton;
        private Label textLabel;
    }
}