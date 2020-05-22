using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentlib
{
    public class Interface
    {
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Меню");
            Console.WriteLine("Для выполнения действий нажмите следующую цифру:");
            Console.WriteLine("1. Показать Информацию о студентах. \n2. Добавить студента. \n3. Удалить студента. \n4. Изменить студента.\n5. Поиск студентов. \n6. Выход.");
        }

        public static void StudentInfoMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Показать Информацию о студентах.");
            Console.WriteLine("Для выполнения действий нажмите следующую цифру:");
            Console.WriteLine("1. Вся информация о студентах. \n2. Список студентов с инициалами. \n3. Список студентов старше 18. \n4. Список студентов младше 18. \n5.Назад в главное меню.");
        }

        public static void StudentSearchMenu()
        {
            Console.Clear();
            Console.WriteLine("5. Поиск студентов.");
            Console.WriteLine("Для выполнения действий нажмите следующую цифру:");
            Console.WriteLine("1. Поиск по фамилии. \n2. Поиск по начальным символам. \n3.Назад в главное меню.");
        }

    }
}
