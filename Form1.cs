using System;
using System.Windows.Forms;

namespace SelfInfo
{
    public partial class Form1 : Form
    {
        private Button buttonShowTime;
        private Button buttonShowFIO;
        private Button buttonShowDOB;
        private Button buttonShowInfo;
        private TextBox textBoxFIO;
        private TextBox textBoxDOB;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                components?.Dispose();
            }
            base.Dispose(disposing);
        }

        private void ButtonTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�������� �����: " + DateTime.Now.ToString("T"));
        }

        private void ButtonFIO_Click(object sender, EventArgs e)
        {
            string fio = textBoxFIO.Text;
            MessageBox.Show("���� ���: " + fio);
        }

        private void ButtonDateOfBirth_Click(object sender, EventArgs e)
        {
            string dob = textBoxDOB.Text;
            MessageBox.Show("���� ���� ��������: " + dob);
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            string fio = textBoxFIO.Text;
            string dob = textBoxDOB.Text;
            string currentTime = DateTime.Now.ToString("T");
            MessageBox.Show($"������� �����: {currentTime}\n���� ���: {fio}\n���� ���� ��������: {dob}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}