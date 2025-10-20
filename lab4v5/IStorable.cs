namespace lab4v5
{
    // Базовий інтерфейс для зберігаємих об’єктів (книг, журналів)
    public interface IStorable
    {
        string Title { get; }
        int Pages { get; }

        void ShowInfo();
    }
}
