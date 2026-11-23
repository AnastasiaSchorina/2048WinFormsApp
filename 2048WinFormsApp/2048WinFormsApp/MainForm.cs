using _2048GameLibrary;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        public List<User> users = new List<User>();
        public User user;
        private int mapSize = 4;
        private Label[,] labelsMap;
        private static Random random = new Random();
        private int score = 0;
        private int xLeft = 10;
        private int yDown = 70;
        private int labelSize = 70;
        private int toNextPointDistance = 76;
        private int mainFormWidth = 390;
        private int mainFormHeight = 430;
        public MainForm()
        {
            InitializeComponent();
            this.Size = new Size(mainFormWidth, mainFormHeight);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitMap(mapSize);
            GetUserName();
            GenerateNumber();
            ShowScore();
            ShowMaxScore();
        }

        private void ShowMaxScore()
        {
            var userMaxScore = UserResultStorage.GetMaxScore(users);
            maxNumberLabel.Text = userMaxScore.Score.ToString();
        }

        private void GetUserName()
        {
            var userNameForm = new UserNameForm();
            userNameForm.ShowDialog();
            user = new User(userNameForm.userNameTextBox.Text);
            users = UserResultStorage.GetAll();
            users.Add(user);
        }

        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }


        private void GenerateNumber()
        {

            while (true)
            {
                var randomLabelNumber = random.Next(mapSize * mapSize);
                var indexRow = randomLabelNumber / mapSize;
                var indexColumn = randomLabelNumber % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    GetNumber(indexRow, indexColumn);
                    break;
                }
            }
            if (!HasEmptyLabel())
            {
                if (IsEndGame())
                {
                    EndGame();
                }
            }
        }

        private void EndGame()
        {
            user.Score = score;
            UserResultStorage.Save(user);
            if (IsYesOrNo("Âñå ÿ÷åéêè çàïîëíåíû. Íà÷àòü çàíîâî?"))
                Application.Restart();
            Application.Exit();
            return;
        }

        private bool HasEmptyLabel()
        {
            foreach (var item in labelsMap)
            {
                if (item.Text == string.Empty)
                    return true;
            }
            return false;
        }

        private void GetNumber(int indexRow, int indexColumn)
        {
            var randomIndex = random.Next(4);
            if (randomIndex == 3)
            {
                labelsMap[indexRow, indexColumn].Text = "4";
                return;
            }
            labelsMap[indexRow, indexColumn].Text = "2";
        }

        private bool IsEndGame()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize - 1; j++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i, j + 1].Text)
                        return false;
                }
            }
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize - 1; i++)
                {
                    if (labelsMap[i, j].Text == labelsMap[i + 1, j].Text)
                        return false;
                }
            }
            MessageBox.Show("Èãðà îêîí÷åíà.");
            return true;
        }

        private bool IsYesOrNo(string str)
        {
            DialogResult dialogResult = MessageBox.Show(str, "", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void InitMap(int mapSize)
        {
            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();

            label.BackColor = SystemColors.ActiveCaption;
            label.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.Size = new Size(labelSize, labelSize);
            label.TextAlign = ContentAlignment.MiddleCenter;
            int x = xLeft + indexColumn * toNextPointDistance;
            int y = yDown + indexRow * toNextPointDistance;
            label.Location = new Point(x, y);
            return label;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
                MoveToDown();
            if (e.KeyCode == Keys.Right)
                MoveToRight();
            if (e.KeyCode == Keys.Left)
                MoveToLeft();
            if (e.KeyCode == Keys.Up)
                MoveToUp();

            if (HasEmptyLabel())
            {
                GenerateNumber();
                ShowScore();
                return;
            }

            if (IsEndGame())
            {
                EndGame();
            }
        }

        private void MoveToDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j] = ChangeLabelDisplay((number * 2).ToString(), labelsMap[i, j]);
                                    labelsMap[k, j] = ChangeLabelDisplay(string.Empty, labelsMap[k, j]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j] = ChangeLabelDisplay(labelsMap[k, j].Text, labelsMap[i, j]);
                                labelsMap[k, j] = ChangeLabelDisplay(string.Empty, labelsMap[k, j]);
                                break;
                            }
                        }
                    }
                }
            }

        }

        private Label ChangeLabelDisplay(string value, Label label)
        {
            label.Text = value;
            label.BackColor = ColorsStorage.AssignColor(value.ToString());
            return label;
        }

        private void MoveToUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;

                                    labelsMap[i, j] = ChangeLabelDisplay((number * 2).ToString(), labelsMap[i, j]);
                                    labelsMap[k, j] = ChangeLabelDisplay(string.Empty, labelsMap[k, j]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j] = ChangeLabelDisplay(labelsMap[k, j].Text, labelsMap[i, j]);
                                labelsMap[k, j] = ChangeLabelDisplay(string.Empty, labelsMap[k, j]);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveToLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;

                                    labelsMap[i, j] = ChangeLabelDisplay((number * 2).ToString(), labelsMap[i, j]);
                                    labelsMap[i, k] = ChangeLabelDisplay(string.Empty, labelsMap[i, k]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j] = ChangeLabelDisplay(labelsMap[i, k].Text, labelsMap[i, j]);
                                labelsMap[i, k] = ChangeLabelDisplay(string.Empty, labelsMap[i, k]);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveToRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j] = ChangeLabelDisplay((number * 2).ToString(), labelsMap[i, j]);
                                    labelsMap[i, k] = ChangeLabelDisplay(string.Empty, labelsMap[i, k]);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j] = ChangeLabelDisplay(labelsMap[i, k].Text, labelsMap[i, j]);
                                labelsMap[i, k] = ChangeLabelDisplay(string.Empty, labelsMap[i, k]);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void íà÷àòüÇàíîâîToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void ïðàâèëàÈãðûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rule2048Form = new Rule2048Form();
            rule2048Form.ShowDialog();
        }

        private void ïðîñìîòðÐåçóëüòàòîâToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result2048ShowForm = new Result2048ShowForm();
            result2048ShowForm.ShowDialog();
        }

        private void x3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteControl(mapSize);
            mapSize = 3;
            OpenNewMap(390, 350, mapSize);
        }

        private void DeleteControl(int mapSize)
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    Controls.Remove(labelsMap[i, j]);
                }
            }
        }

        private void x4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteControl(mapSize);
            mapSize = 4;
            OpenNewMap(390, 430, mapSize);
        }

        private void x5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteControl(mapSize);
            mapSize = 5;
            OpenNewMap(450, 510, mapSize);
        }

        private void OpenNewMap(int mainFormWidth, int mainFormHeight, int mapSize)
        {
            InitMap(mapSize);
            this.Size = new Size(mainFormWidth, mainFormHeight);
            score = 0;
            scoreLabel.Text = 0.ToString();
            GenerateNumber();
        }
    }
}
