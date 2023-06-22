using System;
using System.Windows.Forms;

namespace Information_Security_Conference
{
    public partial class Organizers : Form
    {
        public Organizers()
        {
            InitializeComponent();
        }


        private void button1Return_Click(object sender, EventArgs e)//обрабатываем событие клик на кнопку "Вернутся"
        {
            this.Hide();
            Authentication formMain = new Authentication();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();//закрываем форму Organizers и переходим в форму  Authentication
        }
    }
}
