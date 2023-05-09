using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TimerWinForms
{
    internal class FormCreate : Form
    {
        public FormCreate()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            dateLabel = new Label();
            timeStartLabel = new Label();
            timeStartPicker = new DateTimePicker();
            datePicker = new DateTimePicker();
            timeEndPicker = new DateTimePicker();
            timeEndLabel = new Label();
            buttonAddTime = new Button();
            timeGroupBox = new GroupBox();
            descriptionLabel = new Label();
            descriptionTextBox = new TextBox();
            timeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.Anchor = AnchorStyles.Top;
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Yu Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(185, 63);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(113, 39);
            dateLabel.TabIndex = 1;
            dateLabel.Text = "DATE :";
            // 
            // timeStartLabel
            // 
            timeStartLabel.AutoSize = true;
            timeStartLabel.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            timeStartLabel.Location = new Point(16, 30);
            timeStartLabel.Name = "timeStartLabel";
            timeStartLabel.Size = new Size(170, 31);
            timeStartLabel.TabIndex = 3;
            timeStartLabel.Text = "TIME START :";
            // 
            // timeStartPicker
            // 
            timeStartPicker.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            timeStartPicker.Format = DateTimePickerFormat.Time;
            timeStartPicker.Location = new Point(16, 75);
            timeStartPicker.Name = "timeStartPicker";
            timeStartPicker.ShowUpDown = true;
            timeStartPicker.Size = new Size(315, 45);
            timeStartPicker.TabIndex = 4;
            timeStartPicker.Value = new DateTime(2023, 5, 9, 18, 23, 17, 433);
            // 
            // datePicker
            // 
            datePicker.Anchor = AnchorStyles.Top;
            datePicker.Font = new Font("Yu Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(316, 63);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(315, 44);
            datePicker.TabIndex = 5;
            datePicker.Value = new DateTime(2023, 5, 9, 18, 23, 17, 433);
            // 
            // timeEndPicker
            // 
            timeEndPicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeEndPicker.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            timeEndPicker.Format = DateTimePickerFormat.Time;
            timeEndPicker.Location = new Point(370, 75);
            timeEndPicker.Name = "timeEndPicker";
            timeEndPicker.ShowUpDown = true;
            timeEndPicker.Size = new Size(315, 45);
            timeEndPicker.TabIndex = 7;
            timeEndPicker.Value = new DateTime(2023, 5, 9, 18, 23, 17, 433);
            // 
            // timeEndLabel
            // 
            timeEndLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            timeEndLabel.AutoSize = true;
            timeEndLabel.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            timeEndLabel.Location = new Point(370, 30);
            timeEndLabel.Name = "timeEndLabel";
            timeEndLabel.Size = new Size(145, 31);
            timeEndLabel.TabIndex = 6;
            timeEndLabel.Text = "TIME END :";
            // 
            // buttonAddTime
            // 
            buttonAddTime.Anchor = AnchorStyles.Bottom;
            buttonAddTime.BackColor = Color.MediumAquamarine;
            buttonAddTime.Location = new Point(276, 450);
            buttonAddTime.Name = "buttonAddTime";
            buttonAddTime.Size = new Size(315, 55);
            buttonAddTime.TabIndex = 8;
            buttonAddTime.Text = "ADD TIME";
            buttonAddTime.Click += addTime_Click;
            // 
            // timeGroupBox
            // 
            timeGroupBox.Anchor = AnchorStyles.None;
            timeGroupBox.Controls.Add(timeEndPicker);
            timeGroupBox.Controls.Add(timeEndLabel);
            timeGroupBox.Controls.Add(timeStartPicker);
            timeGroupBox.Controls.Add(timeStartLabel);
            timeGroupBox.Location = new Point(76, 151);
            timeGroupBox.Name = "timeGroupBox";
            timeGroupBox.Size = new Size(700, 160);
            timeGroupBox.TabIndex = 9;
            timeGroupBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.None;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Yu Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(330, 330);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(207, 35);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "DESCRIPTION";
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.None;
            descriptionTextBox.Location = new Point(276, 372);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(315, 49);
            descriptionTextBox.TabIndex = 11;
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(840, 550);
            Controls.Add(descriptionTextBox);
            Controls.Add(descriptionLabel);
            Controls.Add(timeGroupBox);
            Controls.Add(buttonAddTime);
            Controls.Add(datePicker);
            Controls.Add(dateLabel);
            MinimumSize = new Size(840, 550);
            Name = "FormCreate";
            Text = "Create time";
            timeGroupBox.ResumeLayout(false);
            timeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void addTime_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timeStartPicker.Value.Hour, timeStartPicker.Value.Minute, timeStartPicker.Value.Second);
            DateTime end = new DateTime(datePicker.Value.Year, datePicker.Value.Month, datePicker.Value.Day, timeEndPicker.Value.Hour, timeEndPicker.Value.Minute, timeEndPicker.Value.Second);

            TimeSpan span = end - start;
            var minutes = (int)span.TotalMinutes;

            using (TimerDbContext db = new TimerDbContext())
            {
                var time1 = new Time
                {
                    DateTimeEnd = DateTime.Now <= end ? end : DateTime.Now,
                    MinutesTime = minutes == 0 ? 1 : minutes,
                    Description = descriptionTextBox.Text
                };

                db.Times.Add(time1);
                db.SaveChanges();
                MessageBox.Show($"{time1.MinutesTime} minutes was added to DB!", "Successfully");
                descriptionTextBox.Text = "";
            }
        }

        private Label timeStartLabel;
        private DateTimePicker timeStartPicker;
        private DateTimePicker datePicker;
        private DateTimePicker timeEndPicker;
        private Label timeEndLabel;
        private Button buttonAddTime;
        private GroupBox timeGroupBox;
        private Label descriptionLabel;
        private TextBox descriptionTextBox;
        private Label dateLabel;
    }
}
