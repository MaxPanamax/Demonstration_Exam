using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Information_Security_Conference
{
    public partial class Authentication : Form
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void button1Entrace_Click(object sender, EventArgs e)//обработка события Клик кнопки входа в систему
        {

            // Строка подключения к базе данных
            string connectionString = "Data Source=DESKTOP-4C1TPV0\\SQLEXPRESS;" +
                "Initial Catalog=DB;" +
                "Integrated Security=SSPI";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //присваиваем переменным значения введенные пользователем в textBox
            string email = textBox1Mail.Text;
            string password = textBox2Password.Text;
            //присваиваем переменным строчки запроса в Базу Данных
            string query = "SELECT * FROM Участники WHERE Почта='" + email + "' AND пароль='" + password + "'";
            string query1 = "SELECT * FROM Организаторы WHERE Почта='" + email + "' AND пароль='" + password + "'";
            string query2 = "SELECT * FROM Модераторы WHERE Почта='" + email + "' AND пароль='" + password + "'";
            string query3 = "SELECT * FROM Жюри WHERE Почта='" + email + "' AND пароль='" + password + "'";
            //выполняем запросы
            SqlCommand command = new SqlCommand(query, connection);
            SqlCommand command1 = new SqlCommand(query1, connection);
            SqlCommand command2 = new SqlCommand(query2, connection);
            SqlCommand command3 = new SqlCommand(query3, connection);
            SqlDataReader reader = command.ExecuteReader();
            //проверяем на совподения запрашиваемых данных с данными из Базы данных
            //если совподения найдены то собщаем об этом пользователю разрешаем вход в систему согласно статусу
            if (reader.HasRows)//ищем в таблице участники
            {
                MessageBox.Show("Пользователь найден среди Участников!");
                this.Hide();
                Members formMain = new Members();
                formMain.Closed += (s, args) => this.Close();
                formMain.Show();//закрываем форму Authentication и переходим в форму Members
            }
            else
            {
                reader.Close();
                reader = command1.ExecuteReader();
                if (reader.HasRows)//ищем таблице организаторы
                {
                    MessageBox.Show("Пользователь найден среди Органнизаторов!");
                    this.Hide();
                    Organizers formMain = new Organizers();
                    formMain.Closed += (s, args) => this.Close();
                    formMain.Show();//закрываем форму Authentication и переходим в форму Organizers
                }
                else
                {
                    reader.Close();
                    reader = command2.ExecuteReader();
                    if (reader.HasRows)//ищем в таблице Модераторы
                    {
                        MessageBox.Show("Пользователь найден среди Модераторов!");
                        this.Hide();
                        Moderator formMain = new Moderator();
                        formMain.Closed += (s, args) => this.Close();
                        formMain.Show();//закрываем форму Authentication и переходим в форму  Moderator
                    }
                    else
                    {
                        reader.Close();
                        reader = command3.ExecuteReader();
                        if (reader.HasRows)//ищем в таблице Жюри
                        {
                            MessageBox.Show("Пользователь найден среди Жюри!");
                            this.Hide();
                            Jury formMain = new Jury();
                            formMain.Closed += (s, args) => this.Close();
                            formMain.Show();//закрываем форму Authentication и переходим в форму  Jury
                        }
                        else//если совподений нет то сообщаем пользователю об ошибке
                        {
                            reader.Close();
                            MessageBox.Show("Неправильный email или пароль!");
                        }
                    }

                }

            }
            connection.Close();//закрываем соединение
        }
        //Создаем таблицу в dataGrid и заполняем ее данными из Базы Данных
        private void RequestAndСonclusionDataGridView1(string script)
        {
            dataGridView1Information.DataSource = null;//обнуляем dataGrid
            DataTable table = new DataTable();
            SqlConnection sqlConnection = new SqlConnection();
            //создаем соединение с БД
            sqlConnection.ConnectionString = "Data Source=DESKTOP-4C1TPV0\\SQLEXPRESS;" +
                "Initial Catalog=DB;" +
                "Integrated Security=SSPI";
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(script, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            int line = 0;
            while (reader.Read())//считываем данные
            {
                if (line == 0)
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        table.Columns.Add(reader.GetName(i));
                    }
                }
                DataRow row = table.NewRow();
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    row[i] = reader.GetValue(i);
                }
                table.Rows.Add(row);
                line++;
            }
            //выводим результаты запроса
            dataGridView1Information.DataSource = null;
            dataGridView1Information.DataSource = table;
        }
        private void Authentication_Load(object sender, EventArgs e)//обрабатываем событие клик на форму Authentication
        {
            dataGridView1Information.DataSource = null;//обнуляем dataGrid
        }

        private void button4Registration_Click(object sender, EventArgs e)//обрабатываем событие клик на кнопку "Регистрация"
        {
            this.Hide();
            Registration formMain = new Registration();
            formMain.Closed += (s, args) => this.Close();
            formMain.Show();//закрываем форму Authentication и переходим в форму Registration
        }
       ///при клике создается запрос в бд и выводится из колонки Активность таблице Активности список активности
        private void button3Activ_Click(object sender, EventArgs e)//обрабатываем событие клик на кнопку "Активности"
        {
            string script = $@"SELECT Активность FROM Активности";
            RequestAndСonclusionDataGridView1(script);
        }
        ///при клике создается запрос в бд и выводится из колонкисобытия таблице мероприятия список мероприятий
        private void button2Event_Click(object sender, EventArgs e)//обрабатываем событие клик на кнопку "Мероприятия"
        {
            string script = $@"SELECT Событие FROM Мероприятия";
            RequestAndСonclusionDataGridView1(script);
        }
    }
}
