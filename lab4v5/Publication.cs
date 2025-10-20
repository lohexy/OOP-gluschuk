using System;

namespace lab4v5
{
    // Абстрактний клас, який реалізує базову поведінку публікацій (книг і журналів)
    public abstract class Publication : IStorable
    {
        public string Title { get; protected set; }
        public int Pages { get; protected set; }

        public Publication(string title, int pages)
        {
            Title = title;
            Pages = pages;
        }

        // Абстрактний метод — реалізується в дочірніх класах (Book, Magazine)
        public abstract void ShowInfo();
    }
}
