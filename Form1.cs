namespace TimerWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
                        MinutesTime = minutes==0?1:minutes,
                        Description = descriptionTextBox.Text
                    };

                    db.Times.Add(time1);
                    db.SaveChanges();
                    MessageBox.Show($"{time1.MinutesTime} minutes was added to DB!", "Successfully");
                }
                resetAll_Click(sender, e);
            }
            catch (System.FormatException )
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
            if(startTime.Text != "--:--:--")
            {
                endTime.Text = DateTime.Now.ToString("T");
            }
        }

    }
}