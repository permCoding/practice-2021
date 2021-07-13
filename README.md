# practice-2021

Проектно-технологическая практика 2021  
05.07-18.07.2021  

[Запись занятия №1 в BBB 05.07. - длительность 03:10](https://bbb5.psaa.ru/playback/presentation/2.0/playback.html?meetingId=68138b70736d3d205e0052a8d69da7021b4ccea0-1625463940205)  

[Запись занятия №2 в BBB 07.07. - длительность 02:33](https://bbb5.psaa.ru/playback/presentation/2.0/playback.html?meetingId=68138b70736d3d205e0052a8d69da7021b4ccea0-1625665753715)  

Полезные ссылки:  
[Из wfa в документ Word - видео на youtube](https://youtu.be/vQ7uW6g0z-U)  
[Передать значения между формами - видео на youtube](https://youtu.be/29q1Lz8ErMc)  
[Курсовик C# + MySQL - pdf-документ](https://pcoding.ru/pdf/CourseProject.pdf)  
[Приложение github desktop](https://desktop.github.com/)  
[Как расшарить приватный репозиторий на GitHub](https://pcoding.ru/pdf/shareGit.pdf)  

---  

Что нужно сделать на практике:  
- разработать Приложение с сетевой БД для автоматизации процесса учёта тем ВКР;  
- написать Отчёт о практике.

Подробности об этом можно узнать в папке [docs](/docs/)  
Проложение сохраняете в приватном репозитории и его расшариваете для преподавателя (в файле readme.md напишите свою Фамилию).  

---  

Первая встреча 05.07.2021 в 11:00. Длительность 2-3 пары.  

Вот ссылка для входа: https://bbb5.psaa.ru/b/and-vzd-etf  

Там будем заниматься проектно-технологической практикой дистанционно.  
Корретно работает в Google Chrome или Mozilla FireFox (нужно иметь микрофон для общения со мной).  
Сначала обсудим что именно нужно делать на этой практике и как сдавать её.  
Потом обсудим проект, который нужно сделать и привлекаемые технологии.  
Потом я выдам аккаунты от сетевых баз данных и вместе со мной начнём выполнять реализацию.  
Обсудим день промежуточной встречи для контроля.  
Заключительная встреча будет очная 16 июля в ауд. 501 - там нужно будет принести бумажную версию Отчёта по практике.  

---
  
Параметры работы с БД:  

```txt
База данных MySQL версии 8.0.19  

Общие для всех настройки:  
Хост: pgsha.ru  
Порт: 35006  
Use SSL: No  

Можно заходить как через WorkBench, 
так и через phpMyAdmin - http://pgsha.ru:35080/phpmyadmin

Индивидуальные:
Username: ********
Password: ********
```

Создание соединения с БД:  

```C#
MySqlConnectionStringBuilder db = new MySqlConnectionStringBuilder();

db.Server = "*********"; // хостинг БД
db.Database = "**********"; // Имя БД
db.UserID = "**********"; // Имя пользователя БД
db.Password = "*********"; // Пароль пользователя БД
db.Port = ****; // Порт
db.CharacterSet = "utf8"; // Кодировка Базы Данных

MySqlConnection conn = new MySqlConnection(db.ConnectionString);
```

Получить хеш строки:  

```C#
public static string CalculateMD5Hash(string input)
{
    using (var md5 = System.Security.Cryptography.MD5.Create())
    {
        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = md5.ComputeHash(inputBytes);
        var sb = new StringBuilder(16 * 2);
        for (int i = 0; i < hash.Length; i++)
        {
            sb.Append(hash[i].ToString("X2"));
        }
        return sb.ToString();
    }
}
```

Способы как организовать асинхронный старт главной формы приложения и проверки соединения с БД.  

Способ 1:  
```C#  
private async void FormStart_Shown(object sender, EventArgs e)
{
    await Task.Run(() => CheckConnection());
}

private void CheckConnection()
{
    MySqlConnection conn = DbHelper.GetConn();

    try
    {
        conn.Open();
        this.status1.Text = "Подключение к БД установлено";
    }
    catch (Exception ex)
    {
        this.status1.Text = "Нет соединения с БД";
        MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
    }
    finally
    {
        conn.Close();
    }
}
```

Способ 2:  
```C#  
private void FormStart_Shown(object sender, EventArgs e)
{
    Task.Delay(100).ContinueWith(CheckConnection);
}

private void CheckConnection(Task obj)
{
    MySqlConnection conn = DbHelper.GetConn();

    try
    {
        conn.Open();
        this.status1.Text = "Подключение к БД установлено";
    }
    catch (Exception ex)
    {
        this.status1.Text = "Нет соединения с БД";
        MessageBox.Show("Проблемы с подключением к БД \n\r" + ex.ToString());
    }
    finally
    {
        conn.Close();
    }
}
```

---  

```

```
