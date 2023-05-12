using System;
using System.Data.Entity;
using System.Linq;

namespace TimerWinForms
{
    public class Form2 : Form
    {
        private int _userId;
        public Form2(int userId)
        {
            _userId = userId;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateTimeEndDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minutesTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AutoGenerateColumns = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Lavender;
            dataGridViewCellStyle1.Font = new Font("Tahoma", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dateTimeEndDataGridViewTextBoxColumn, minutesTimeDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, userIdDataGridViewTextBoxColumn, userDataGridViewTextBoxColumn });
            dataGridView.DataSource = timeBindingSource;
            dataGridView.Location = new Point(140, 60);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(520, 370);
            dataGridView.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateTimeEndDataGridViewTextBoxColumn
            // 
            dateTimeEndDataGridViewTextBoxColumn.DataPropertyName = "DateTimeEnd";
            dateTimeEndDataGridViewTextBoxColumn.HeaderText = "DateTimeEnd";
            dateTimeEndDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateTimeEndDataGridViewTextBoxColumn.Name = "dateTimeEndDataGridViewTextBoxColumn";
            dateTimeEndDataGridViewTextBoxColumn.ReadOnly = true;
            dateTimeEndDataGridViewTextBoxColumn.Width = 140;
            // 
            // minutesTimeDataGridViewTextBoxColumn
            // 
            minutesTimeDataGridViewTextBoxColumn.DataPropertyName = "MinutesTime";
            minutesTimeDataGridViewTextBoxColumn.HeaderText = "MinutesTime";
            minutesTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            minutesTimeDataGridViewTextBoxColumn.Name = "minutesTimeDataGridViewTextBoxColumn";
            minutesTimeDataGridViewTextBoxColumn.ReadOnly = true;
            minutesTimeDataGridViewTextBoxColumn.Width = 134;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            descriptionDataGridViewTextBoxColumn.Width = 200;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            userIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            userIdDataGridViewTextBoxColumn.ReadOnly = true;
            userIdDataGridViewTextBoxColumn.Visible = false;
            userIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // userDataGridViewTextBoxColumn
            // 
            userDataGridViewTextBoxColumn.DataPropertyName = "User";
            userDataGridViewTextBoxColumn.HeaderText = "User";
            userDataGridViewTextBoxColumn.MinimumWidth = 6;
            userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            userDataGridViewTextBoxColumn.ReadOnly = true;
            userDataGridViewTextBoxColumn.Visible = false;
            userDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeBindingSource
            // 
            Visualize();
            timeBindingSource.DataSource = typeof(Time);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(840, 550);
            Controls.Add(dataGridView);
            MinimumSize = new Size(840, 550);
            Name = "Form2";
            Text = "Visualization";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeBindingSource).EndInit();
            ResumeLayout(false);
        }

        private void Visualize()
        {
            using (TimerDbContext db = new TimerDbContext())
            {
                var time2 = db.Times.Where(t => t.UserId == _userId).ToList();
                dataGridView.DataSource = time2;
            }
        }

        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateTimeEndDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minutesTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private BindingSource timeBindingSource;
        private System.ComponentModel.IContainer components;
        private DataGridView dataGridView;
    }
}
