namespace SelfInfo
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            textBoxFIO = new TextBox();
            textBoxDOB = new TextBox();
            buttonShowTime = new Button();
            buttonShowFIO = new Button();
            buttonShowDOB = new Button();
            buttonShowInfo = new Button();
            SuspendLayout();

            textBoxFIO.Location = new Point(22, 25);
            textBoxFIO.Margin = new Padding(3, 4, 3, 4);
            textBoxFIO.Name = "textBoxFIO";
            textBoxFIO.PlaceholderText = "Введите ваше ФИО";
            textBoxFIO.Size = new Size(333, 31);
            textBoxFIO.TabIndex = 0;

            textBoxDOB.Location = new Point(22, 88);
            textBoxDOB.Margin = new Padding(3, 4, 3, 4);
            textBoxDOB.Name = "textBoxDateOfBirth";
            textBoxDOB.PlaceholderText = "Введите дату рождения";
            textBoxDOB.Size = new Size(333, 31);

            buttonShowTime.Location = new Point(389, 25);
            buttonShowTime.Margin = new Padding(3, 4, 3, 4);
            buttonShowTime.Name = "buttonTime";
            buttonShowTime.Size = new Size(167, 38);
            buttonShowTime.TabIndex = 2;
            buttonShowTime.Text = "Текущее время";
            buttonShowTime.Click += ButtonTime_Click;

            buttonShowFIO.Location = new Point(389, 88);
            buttonShowFIO.Margin = new Padding(3, 4, 3, 4);
            buttonShowFIO.Name = "buttonFIO";
            buttonShowFIO.Size = new Size(167, 38);
            buttonShowFIO.TabIndex = 3;
            buttonShowFIO.Text = "Вывод ФИО";
            buttonShowFIO.Click += ButtonFIO_Click;

            buttonShowDOB.Location = new Point(578, 25);
            buttonShowDOB.Margin = new Padding(3, 4, 3, 4);
            buttonShowDOB.Name = "buttonDateOfBirth";
            buttonShowDOB.Size = new Size(167, 38);
            buttonShowDOB.TabIndex = 4;
            buttonShowDOB.Text = "Вывод даты рождения";
            buttonShowDOB.Click += ButtonDateOfBirth_Click;
            
            buttonShowInfo.Location = new Point(578, 88);
            buttonShowInfo.Margin = new Padding(3, 4, 3, 4);
            buttonShowInfo.Name = "buttonInfo";
            buttonShowInfo.Size = new Size(167, 38);
            buttonShowInfo.TabIndex = 5;
            buttonShowInfo.Text = "Вывод информации";
            buttonShowInfo.Click += ButtonInfo_Click;
            
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 142);
            Controls.Add(textBoxFIO);
            Controls.Add(textBoxDOB);
            Controls.Add(buttonShowTime);
            Controls.Add(buttonShowFIO);
            Controls.Add(buttonShowDOB);
            Controls.Add(buttonShowInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Self Information";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}