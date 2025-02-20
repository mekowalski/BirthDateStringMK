namespace BirthDateStringMK
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
            dayOfTheWeekPromptLabel = new Label();
            monthPromptLabel = new Label();
            dayOfMonthPromptLabel = new Label();
            yearPromptLabel = new Label();
            dayOfWeekTextBox = new TextBox();
            monthTextBox = new TextBox();
            dayOfMonthTextBox = new TextBox();
            yearTextBox = new TextBox();
            dateOutputLabel = new Label();
            showDateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // dayOfTheWeekPromptLabel
            // 
            dayOfTheWeekPromptLabel.AutoSize = true;
            dayOfTheWeekPromptLabel.Location = new Point(144, 77);
            dayOfTheWeekPromptLabel.Name = "dayOfTheWeekPromptLabel";
            dayOfTheWeekPromptLabel.Size = new Size(184, 20);
            dayOfTheWeekPromptLabel.TabIndex = 0;
            dayOfTheWeekPromptLabel.Text = "Enter the day of the week: ";
            // 
            // monthPromptLabel
            // 
            monthPromptLabel.AutoSize = true;
            monthPromptLabel.Location = new Point(122, 143);
            monthPromptLabel.Name = "monthPromptLabel";
            monthPromptLabel.Size = new Size(206, 20);
            monthPromptLabel.TabIndex = 1;
            monthPromptLabel.Text = "Enter the name of the month: ";
            // 
            // dayOfMonthPromptLabel
            // 
            dayOfMonthPromptLabel.AutoSize = true;
            dayOfMonthPromptLabel.Location = new Point(78, 207);
            dayOfMonthPromptLabel.Name = "dayOfMonthPromptLabel";
            dayOfMonthPromptLabel.Size = new Size(250, 20);
            dayOfMonthPromptLabel.TabIndex = 2;
            dayOfMonthPromptLabel.Text = "Enter the numeric day of the month: ";
            // 
            // yearPromptLabel
            // 
            yearPromptLabel.AutoSize = true;
            yearPromptLabel.Location = new Point(221, 270);
            yearPromptLabel.Name = "yearPromptLabel";
            yearPromptLabel.Size = new Size(107, 20);
            yearPromptLabel.TabIndex = 3;
            yearPromptLabel.Text = "Enter the year: ";
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Location = new Point(492, 70);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(125, 27);
            dayOfWeekTextBox.TabIndex = 4;
            // 
            // monthTextBox
            // 
            monthTextBox.Location = new Point(492, 136);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(125, 27);
            monthTextBox.TabIndex = 5;
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.Location = new Point(492, 200);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(125, 27);
            dayOfMonthTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(492, 263);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(125, 27);
            yearTextBox.TabIndex = 7;
            // 
            // dateOutputLabel
            // 
            dateOutputLabel.AutoSize = true;
            dateOutputLabel.BorderStyle = BorderStyle.FixedSingle;
            dateOutputLabel.Location = new Point(186, 315);
            dateOutputLabel.MinimumSize = new Size(400, 0);
            dateOutputLabel.Name = "dateOutputLabel";
            dateOutputLabel.Size = new Size(400, 22);
            dateOutputLabel.TabIndex = 8;
            dateOutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            dateOutputLabel.Click += dateOutputLabel_Click;
            // 
            // showDateButton
            // 
            showDateButton.Location = new Point(132, 370);
            showDateButton.Name = "showDateButton";
            showDateButton.Size = new Size(94, 29);
            showDateButton.TabIndex = 9;
            showDateButton.Text = "Show Date";
            showDateButton.UseVisualStyleBackColor = true;
            showDateButton.Click += ShowDateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(345, 370);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 10;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(571, 370);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(94, 29);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(showDateButton);
            Controls.Add(dateOutputLabel);
            Controls.Add(yearTextBox);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(yearPromptLabel);
            Controls.Add(dayOfMonthPromptLabel);
            Controls.Add(monthPromptLabel);
            Controls.Add(dayOfTheWeekPromptLabel);
            Name = "Form1";
            Text = "Birth Date String";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label dayOfTheWeekPromptLabel;
        private Label monthPromptLabel;
        private Label dayOfMonthPromptLabel;
        private Label yearPromptLabel;
        private TextBox dayOfWeekTextBox;
        private TextBox monthTextBox;
        private TextBox dayOfMonthTextBox;
        private TextBox yearTextBox;
        private Label dateOutputLabel;
        private Button showDateButton;
        private Button clearButton;
        private Button exitButton;
    }
}
