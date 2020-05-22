using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using studentlib;

    namespace zadanie5
        {
        class Program
            {
            static void Main(string[] args)
                {

            Student Andrey = new Student();
            Andrey.AddStudent(1, "Иванов Андрей Владимирович", "19-11-2", "25.12.2001");
            Student Eva = new Student();
            Eva.AddStudent(2, "Коновалова Ева Ивановна", "18-11-3", "16.06.2000");
            Student Anna = new Student();
            Anna.AddStudent(3, "Огурцова Анна Николаевна", "18-11-1", "07.01.2000");
            Student Oleg = new Student();
            Oleg.AddStudent(4, "Иванов Олег Сергеевич", "21-11-1", "07.12.2003");
            Student Sasha = new Student();
            Sasha.AddStudent(5, "Иранов Александр Сергеевич", "21-11-1", "08.10.2003");

            string read;
            start:
            Interface.MainMenu();
            read = Console.ReadLine();
            switch (read)
                {
                case "1":
                    {
                        Interface.StudentInfoMenu();
                        read = Console.ReadLine();
                        switch (read)
                        {
                            case "1": { Console.Clear(); Student.WriteAllInfo(); Console.ReadLine(); goto start; }
                            case "2": { Console.Clear(); Student.WriteAllFioShort(); Console.ReadLine(); goto start; }
                            case "3": { Console.Clear(); List<Student> less18 = Student.Around18('s');
                                    Student.WriteAll(less18); Console.ReadLine(); goto start; }
                            case "4": { Console.Clear(); List<Student> more18 = Student.Around18('a');
                                    Student.WriteAll(more18); Console.ReadLine(); goto start; }
                            case "5":
                                {
                                    goto start;
                                }
                        }
                        break;
                    }
                case "2":
                    {
                        Student newst = new Student();
                        Console.Clear();
                        Console.WriteLine("Введите ID студента: ");
                        string id = Console.ReadLine();

                        Console.WriteLine("Введите ФИО студента: ");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Введите группу студента: ");
                        string gr = Console.ReadLine();
                        Console.WriteLine("Введите ДР студента: ");
                        string dt = Console.ReadLine();
                        try { 
                        newst.AddStudent(int.Parse(id), fio, gr, dt);
                    }
                        catch
                        {
                            Console.WriteLine("неверные данные!");
                        }
                        Console.WriteLine("Завершено!");
                        Console.ReadLine(); goto start;
                    }
                case "3":
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ID студента: ");
                        string id = Console.ReadLine();
                        try
                        {
                            Student.RemoveStudent(int.Parse(id));
                        }
                        catch
                        {
                            Console.WriteLine("неверные данные!");
                        }
                        Console.WriteLine("Завершено!");
                        Console.ReadLine(); goto start;
                    }
                case "4":
                    {
                        Console.Clear();
                        Console.WriteLine("Введите ID студента: ");
                        string id = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Студент:");
                        try
                        {
                            Student.WriteAllId(int.Parse(id));
                        }
                        catch
                        {
                            Console.WriteLine("неверные данные!");
                            Console.ReadLine();
                            goto start;
                        }
                        Console.WriteLine("Введите новое ФИО студента: ");
                        string fio = Console.ReadLine();
                        Console.WriteLine("Введите новую группу студента: ");
                        string gr = Console.ReadLine();
                        Console.WriteLine("Введите новую ДР студента: ");
                        string dt = Console.ReadLine();
                        try
                        {
                            Student.ChangeStudent(int.Parse(id), fio, gr, dt);
                        }
                        catch
                        {
                            Console.WriteLine("неверные данные!");
                        }
                        Console.WriteLine("Завершено!");
                        Console.ReadLine(); goto start;
                    }
                case "5":
                    {
                        Console.Clear();
                        Interface.StudentSearchMenu();
                        read = Console.ReadLine();
                        switch (read)
                        {
                            case "1": { Console.Clear(); Console.WriteLine("Введите Фамилию студента: ");
                                    string f = Console.ReadLine(); Console.WriteLine("Результаты поиска:"); try { Student.WriteAll(Student.FamSearch(f)); }
                                    catch
                                    {
                                        Console.WriteLine("неверные данные!");
                                    }
                                    Console.ReadLine(); goto start; }
                            case "2": {
                                    Console.Clear(); Console.WriteLine("Введите символ(ы): ");
                                    string f = Console.ReadLine(); Console.WriteLine("Результаты поиска:"); try { Student.WriteAll(Student.FamStartSearch(f)); }
                                    catch
                                    {
                                        Console.WriteLine("неверные данные!");
                                    }
                                    Console.ReadLine(); goto start;
                                }
                            case "3":
                                {
                                    goto start;
                                }
                        }
                        break;
                    }
                case "6": { break; }
            }
        }
        }
        }

