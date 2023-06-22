using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Information_Security_Conference
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label10ClickReturn_Click(object sender, EventArgs e)//обрабатываем событие клик на label "вернутся на главную"
        {
            this.Hide();
            Authentication formMain = new Authentication();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();//закрываем форму  Registration и переходим в форму Authentication
        }

        private void button4Registration_Click(object sender, EventArgs e)//обработка события клик на кнопку "Регистрация"
        {
            // Получаем данные из текстовых полей
            string email = textBox1Mail.Text;
            string password = textBox2Password.Text;
            string fio = textBox3FIO.Text;
            string dataR = textBox4Date.Text;
            string country = textBox5CodeCountry.Text;
            string tel = textBox6NamberTel.Text;
            string foto = textBox7Sex.Text;
            string sex = textBox8Foto.Text;
            // Проверка на наличие введенных данных
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля");
                return;
            }
            // Строка подключения к базе данных
            string connectionString = "Data Source=DESKTOP-4C1TPV0\\SQLEXPRESS;" +
                "Initial Catalog=DB;" +
                "Integrated Security=SSPI";
            // SQL запрос для добавления новой записи
            string commandText = "INSERT INTO Участники(ФИО,Почта, пароль, дата_рождения, страна, телефон, фото, пол) VALUES(@ФИО, @Email, @Password,@дата_рождения, @страна, @телефон, @фото, @пол)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Создаем новый SQL запрос и параметры для него
                SqlCommand command = new SqlCommand(commandText, connection);
                command.Parameters.AddWithValue("@ФИО", fio);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@дата_рождения", dataR);
                command.Parameters.AddWithValue("@страна", country);
                command.Parameters.AddWithValue("@телефон", tel);
                command.Parameters.AddWithValue("@фото", foto);
                command.Parameters.AddWithValue("@пол", sex);

                try
                {
                    // Открываем подключение к базе данных
                    connection.Open();

                    // Выполняем SQL запрос для добавления новой записи
                    command.ExecuteNonQuery();

                    // Сообщаем пользователю об успешной регистрации
                    MessageBox.Show("Вы успешно зарегистрировались");
                    this.Hide();
                    Authentication formMain = new Authentication();
                    formMain.Closed += (s, args) => this.Close();
                    formMain.Show();
                }
                catch (Exception ex)
                {
                    // Выводим сообщение об ошибке при неудачной попытке регистрации
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }
    }
}
