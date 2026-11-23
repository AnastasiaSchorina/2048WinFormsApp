using _2048GameLibrary;

namespace _2048WinFormsApp
{
    public partial class Result2048ShowForm : Form
    {
        public Result2048ShowForm()
        {
            InitializeComponent();
            ShowResult();
        }

        private void ShowResult()
        {
            var users = UserResultStorage.GetAll();
            if (users.Count > 0)
            {
                var userMaxScore = UserResultStorage.GetMaxScore(users);

                for (var i = 0; i < users.Count; i++)
                {
                    if (users[i].Score == userMaxScore.Score)
                    {
                        result2048DataGridView.Rows.Add(users[i].Name, users[i].Score);
                        result2048DataGridView.Rows[i].DefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
                        return;
                    }
                    result2048DataGridView.Rows.Add(users[i].Name, users[i].Score);
                }
            }
            return;
        }              

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
