using System;
using System.Windows.Forms;

namespace Information_Security_Conference
{
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
        }

        private void button1Return_Click(object sender, EventArgs e)//обрабатываем событие клик на кнопку "Вернутся"
        {
            this.Hide();
            Authentication formMain = new Authentication();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();//закрываем форму Members и переходим в форму  Authentication
        }
    }
}
