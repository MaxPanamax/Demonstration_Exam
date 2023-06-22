using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Information_Security_Conference
{
    public partial class Jury : Form
    {
        public Jury()
        {
            InitializeComponent();
        }

        private void button1Return_Click(object sender, EventArgs e)//обрабатываем событие клик на кнопку "Вернутся"
        {
            this.Hide();
            Authentication formMain = new Authentication();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();//закрываем форму Jury и переходим в форму  Authentication
        }
    }
}
