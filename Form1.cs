using Microsoft.VisualBasic.ApplicationServices;

namespace TimerWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int UserId;

        #region Register methods

        private void registerButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            if (LengthIsOK(registerNameTextBox, registerPassTextBox))
            {
                using (TimerDbContext db = new TimerDbContext())
                {
                    if (db.Users.Any(u => u.UserName == registerNameTextBox.Text))
                    {
                        errorLabel.Text = "\nUser with this name is already registered!";
                        return;
                    }
                    else
                    {
                        User user = new User
                        {
                            UserName = registerNameTextBox.Text,
                            Password = registerPassTextBox.Text
                        };

                        UserId = user.Id;
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                } //dispose

                DeleteRegisterObjects();
                AddTimerObjects();
                Text = "Timer";
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            if (LengthIsOK(logInNameTextBox, logInPassTextBox))
            {
                using (TimerDbContext db = new TimerDbContext())
                {
                    var users = db.Users.Where(u => u.UserName == logInNameTextBox.Text && u.Password == logInPassTextBox.Text).ToList();
                    if (users.Count == 0)
                    {
                        errorLabel.Text = "\nUser with this name is not registered!";
                        return;
                    }
                    UserId = users[0].Id;
                }
                DeleteRegisterObjects();
                AddTimerObjects();
                Text = "Timer";
            }
        }

        private void DeleteRegisterObjects()
        {
            Controls.Remove(errorLabel);
            Controls.Remove(logInNameTextBox);
            Controls.Remove(logInPassTextBox);
            Controls.Remove(registerNameTextBox);
            Controls.Remove(registerPassTextBox);
            Controls.Remove(registerButton);
            Controls.Remove(logInButton);
            Controls.Remove(registrationLabel);
            Controls.Remove(nameLabel);
            Controls.Remove(passLabel);
        }
        private void AddTimerObjects()
        {
            Controls.Add(createButton);
            Controls.Add(groupAll);
            Controls.Add(visualize);
            Controls.Add(addTime);
            Controls.Add(data);
        }

        private bool LengthIsOK(TextBox name, TextBox pass)
        {
            if (pass.Text.Length < 6 || name.Text.Length < 3)
            {
                if (errorLabel.Text.Length < 10)
                    errorLabel.Text = "Password must be longer than 6 characters!\nUsername must be longer than 3 characters!";
                return false;
            }
            return true;
        }

        private void registerPassTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerButton_Click(sender, e);
            }
        }

        private void registerNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                registerButton_Click(sender, e);
            }
        }

        private void logInNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logInButton_Click(sender, e);
            }
        }

        private void logInPassTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logInButton_Click(sender, e);
            }
        }

        #endregion

        private void addTime_Click(object sender, EventArgs e)
        {
            try
            {
                TimeSpan span = Convert.ToDateTime(endTime.Text) - Convert.ToDateTime(startTime.Text);
                int minutes = (int)span.TotalMinutes;
                using (TimerDbContext db = new TimerDbContext())
                {
                    var time1 = new Time
                    {
                        DateTimeEnd = Convert.ToDateTime(endTime.Text),
                        MinutesTime = minutes == 0 ? 1 : minutes,
                        Description = descriptionTextBox.Text
                    };

                    db.Times.Add(time1);
                    db.SaveChanges();
                    MessageBox.Show($"{time1.MinutesTime} minutes was added to DB!", "Successfully");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Please, track your time or use button 'CREATE'", "ERROR");
            }
        }

        private void resetAll_Click(object sender, EventArgs e)
        {
            endTime.Text = "--:--:--";
            startTime.Text = "--:--:--";
            descriptionTextBox.Text = "";
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            if (startTime.Text != "--:--:--")
            {
                endTime.Text = DateTime.Now.ToString("T");
            }
        }

        private void visualize_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void create_Click(object sender, EventArgs e)
        {
            FormCreate frmCreate = new FormCreate();
            frmCreate.Show();
        }

    }
}