using LB.Repositoty;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using taskLibrary;
using Syncfusion.Windows.Shared;
using System.Globalization;

namespace LB
{
    /// <summary>
    /// Логика взаимодействия для NewTask.xaml
    /// </summary>
    public partial class NewTask : Window
    {
        public NewTask()
        {
            InitializeComponent();


        }
        public ClassTask NewTaskes { get; private set; }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ////sfTimePicker
            //string pickedTimeString = sfTimePicker.Value.ToString();

            //// Парсим строку во время
            //TimeSpan pickedTime;
            //if (!TimeSpan.TryParse(pickedTimeString, out pickedTime))
            //{
            //    MessageBox.Show("Некорректное время. Попробуйте снова.");
            //    return;
            //}

            //// Создаём объект DateTime, объединяя текущую дату и выбранное время
            //DateTime fullDateTime = DateTime.Now.Date.Add(pickedTime);

            NewTaskes = new ClassTask
            {
                Name = Name_textbox.Text,
                Category = Category_textbox.Text,
                Date = Date_PickerBox.SelectedDate ?? DateTime.Now,
                DateAndTime = DateTime.Now,
                Description = Description_textbox.Text,
                IsCompleted = false
            };
            this.DialogResult = true;
            var userRepo1 = new TaskRepository();

            bool registr = userRepo1.AddTask(Name_textbox.Text, Description_textbox.Text, Category_textbox.Text);

            if (registr)
            {
                MessageBox.Show("Задача добавлена");
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
