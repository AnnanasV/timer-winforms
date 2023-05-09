namespace TimerWinForms
{
    partial class Form1
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
            data = new Label();
            startButton = new Button();
            startTime = new Label();
            endButton = new Button();
            endTime = new Label();
            deleteStart = new Button();
            deleteEnd = new Button();
            resetAll = new Button();
            addTime = new Button();
            visualize = new Button();
            descriptionTextBox = new TextBox();
            descriptionLabel = new Label();
            groupStart = new GroupBox();
            groupEnd = new GroupBox();
            groupDescription = new GroupBox();
            groupAll = new GroupBox();
            createButton = new Button();
            groupStart.SuspendLayout();
            groupEnd.SuspendLayout();
            groupDescription.SuspendLayout();
            groupAll.SuspendLayout();
            SuspendLayout();
            // 
            // data
            // 
            data.Anchor = AnchorStyles.Top;
            data.AutoSize = true;
            data.Font = new Font("Yu Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            data.Location = new Point(310, 9);
            data.Name = "data";
            data.Size = new Size(245, 35);
            data.TabIndex = 0;
            data.Text = "Today: " + DateTime.Now.ToString("d");
            data.TextAlign = ContentAlignment.MiddleCenter;
            data.Click += (s, e) => {  data.Text = "Today: " + DateTime.Now.ToString("d"); };
            // 
            // startButton
            // 
            startButton.Anchor = AnchorStyles.Left;
            startButton.BackColor = Color.LightBlue;
            startButton.Cursor = Cursors.Hand;
            startButton.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startButton.Location = new Point(6, 14);
            startButton.Name = "startButton";
            startButton.Size = new Size(230, 55);
            startButton.TabIndex = 1;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += (s, e) => { startTime.Text = DateTime.Now.ToString("T"); };
            // 
            // startTime
            // 
            startTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            startTime.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            startTime.Location = new Point(259, 12);
            startTime.Name = "startTime";
            startTime.Size = new Size(230, 55);
            startTime.TabIndex = 2;
            startTime.Text = "--:--:--";
            startTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endButton
            // 
            endButton.Anchor = AnchorStyles.Right;
            endButton.BackColor = Color.LightBlue;
            endButton.Cursor = Cursors.Hand;
            endButton.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            endButton.Location = new Point(504, 14);
            endButton.Name = "endButton";
            endButton.Size = new Size(230, 55);
            endButton.TabIndex = 3;
            endButton.Text = "END";
            endButton.UseVisualStyleBackColor = false;
            endButton.Click += endButton_Click;
            // 
            // endTime
            // 
            endTime.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            endTime.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            endTime.Location = new Point(257, 14);
            endTime.Name = "endTime";
            endTime.Size = new Size(232, 55);
            endTime.TabIndex = 4;
            endTime.Text = "--:--:--";
            endTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deleteStart
            // 
            deleteStart.Anchor = AnchorStyles.Right;
            deleteStart.BackColor = Color.Azure;
            deleteStart.Cursor = Cursors.Hand;
            deleteStart.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            deleteStart.Location = new Point(504, 14);
            deleteStart.Name = "deleteStart";
            deleteStart.Size = new Size(230, 55);
            deleteStart.TabIndex = 5;
            deleteStart.Text = "<= RESET";
            deleteStart.Click += (s, e) => { startTime.Text = "--:--:--"; };
            // 
            // deleteEnd
            // 
            deleteEnd.Anchor = AnchorStyles.Left;
            deleteEnd.BackColor = Color.Azure;
            deleteEnd.Cursor = Cursors.Hand;
            deleteEnd.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            deleteEnd.Location = new Point(6, 14);
            deleteEnd.Name = "deleteEnd";
            deleteEnd.Size = new Size(230, 55);
            deleteEnd.TabIndex = 6;
            deleteEnd.Text = "RESET =>";
            deleteEnd.Click += (s, e) => { endTime.Text = "--:--:--"; };
            // 
            // resetAll
            // 
            resetAll.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            resetAll.BackColor = Color.LightSteelBlue;
            resetAll.Cursor = Cursors.Hand;
            resetAll.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            resetAll.Location = new Point(271, 101);
            resetAll.MaximumSize = new Size(500, 100);
            resetAll.MinimumSize = new Size(230, 45);
            resetAll.Name = "resetAll";
            resetAll.Size = new Size(230, 45);
            resetAll.TabIndex = 7;
            resetAll.Text = "RESET ALL";
            resetAll.UseVisualStyleBackColor = false;
            resetAll.Click += resetAll_Click;
            // 
            // addTime
            // 
            addTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addTime.BackColor = Color.LightGreen;
            addTime.Cursor = Cursors.Hand;
            addTime.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            addTime.Location = new Point(535, 420);
            addTime.Name = "addTime";
            addTime.Size = new Size(230, 55);
            addTime.TabIndex = 8;
            addTime.Text = "ADD TIME";
            addTime.UseVisualStyleBackColor = false;
            addTime.Click += addTime_Click;
            addTime.Click += resetAll_Click;
            // 
            // visualize
            // 
            visualize.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            visualize.BackColor = Color.LightGreen;
            visualize.Cursor = Cursors.Hand;
            visualize.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            visualize.Location = new Point(37, 420);
            visualize.Name = "visualize";
            visualize.Size = new Size(230, 55);
            visualize.TabIndex = 9;
            visualize.Text = "VISUALIZE";
            visualize.UseVisualStyleBackColor = false;
            visualize.Click += visualize_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            descriptionTextBox.Location = new Point(257, 61);
            descriptionTextBox.MaximumSize = new Size(400, 100);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(232, 36);
            descriptionTextBox.TabIndex = 10;
            // 
            // descriptionLabel
            // 
            descriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Yu Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            descriptionLabel.Location = new Point(286, 23);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(176, 35);
            descriptionLabel.TabIndex = 11;
            descriptionLabel.Text = "Description:";
            descriptionLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupStart
            // 
            groupStart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupStart.Controls.Add(deleteStart);
            groupStart.Controls.Add(startTime);
            groupStart.Controls.Add(startButton);
            groupStart.Location = new Point(12, 20);
            groupStart.MaximumSize = new Size(1920, 300);
            groupStart.Name = "groupStart";
            groupStart.Size = new Size(740, 75);
            groupStart.TabIndex = 12;
            groupStart.TabStop = false;
            // 
            // groupEnd
            // 
            groupEnd.Anchor = AnchorStyles.Bottom;
            groupEnd.Controls.Add(deleteEnd);
            groupEnd.Controls.Add(endTime);
            groupEnd.Controls.Add(endButton);
            groupEnd.Location = new Point(12, 152);
            groupEnd.Name = "groupEnd";
            groupEnd.Size = new Size(740, 75);
            groupEnd.TabIndex = 13;
            groupEnd.TabStop = false;
            // 
            // groupDescription
            // 
            groupDescription.Controls.Add(descriptionLabel);
            groupDescription.Controls.Add(descriptionTextBox);
            groupDescription.Location = new Point(12, 233);
            groupDescription.Name = "groupDescription";
            groupDescription.Size = new Size(740, 120);
            groupDescription.TabIndex = 14;
            groupDescription.TabStop = false;
            // 
            // groupAll
            // 
            groupAll.Anchor = AnchorStyles.None;
            groupAll.Controls.Add(groupDescription);
            groupAll.Controls.Add(groupEnd);
            groupAll.Controls.Add(groupStart);
            groupAll.Controls.Add(resetAll);
            groupAll.Location = new Point(19, 49);
            groupAll.Name = "groupAll";
            groupAll.Size = new Size(767, 365);
            groupAll.TabIndex = 15;
            groupAll.TabStop = false;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Bottom;
            createButton.BackColor = Color.LightGreen;
            createButton.Cursor = Cursors.Hand;
            createButton.Font = new Font("Yu Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            createButton.Location = new Point(288, 420);
            createButton.Name = "createButton";
            createButton.Size = new Size(230, 55);
            createButton.TabIndex = 16;
            createButton.Text = "CREATE";
            createButton.Click += create_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(822, 503);
            Controls.Add(createButton);
            Controls.Add(groupAll);
            Controls.Add(visualize);
            Controls.Add(addTime);
            Controls.Add(data);
            MinimumSize = new Size(840, 550);
            Name = "Form1";
            Text = "Timer";
            groupStart.ResumeLayout(false);
            groupEnd.ResumeLayout(false);
            groupDescription.ResumeLayout(false);
            groupDescription.PerformLayout();
            groupAll.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label data;
        private Button startButton;
        private Label startTime;
        private Button endButton;
        private Label endTime;
        private Button deleteStart;
        private Button deleteEnd;
        private Button resetAll;
        private Button addTime;
        private Button visualize;
        private TextBox descriptionTextBox;
        private Label descriptionLabel;
        private GroupBox groupStart;
        private GroupBox groupEnd;
        private GroupBox groupDescription;
        private GroupBox groupAll;
        private Button createButton;
    }
}