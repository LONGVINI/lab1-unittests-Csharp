// TodoList.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace Impl
{
    public class TodoList
    {
        // Зберігає завдання як список рядків
        private List<string> tasks;

        public TodoList()
        {
            tasks = new List<string>();
        }

        /// <summary>
        /// Додає завдання до списку.
        /// </summary>
        /// <param name="task">Назва завдання</param>
        public void AddTask(string task)
        {
            if (task == null)  // Перевірка на тип завдання
            {
                throw new ArgumentException("Task must be a string");
            }
            tasks.Add(task);
        }

        /// <summary>
        /// Видаляє завдання зі списку.
        /// </summary>
        /// <param name="task">Назва завдання для видалення</param>
        public void RemoveTask(string task)
        {
            // Помилка: якщо завдання не знайдено, метод нічого не робить
            tasks.Remove(task);
        }

        /// <summary>
        /// Повертає список усіх завдань.
        /// </summary>
        /// <returns>Список завдань</returns>
        public List<string> GetTasks()
        {
            return tasks;  // Помилка: немає копіювання, можливі побічні ефекти
        }

        /// <summary>
        /// Пошук завдань, які містять заданий текст.
        /// </summary>
        /// <param name="taskName">Текст для пошуку</param>
        /// <returns>Список завдань, що містять taskName</returns>
        public List<string> SearchTask(string taskName)
        {
            // Помилка: шукає тільки точний збіг
            return tasks.Where(task => task == taskName).ToList();
        }
    }
}