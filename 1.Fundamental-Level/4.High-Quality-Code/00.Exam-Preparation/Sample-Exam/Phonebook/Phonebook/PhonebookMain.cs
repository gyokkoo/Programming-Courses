namespace Phonebook
{
    using Phonebook.Core;
    using Phonebook.Data;

    public class PhonebookMain
    {
        public static void Main()
        {
            var database = new PhonebookRepository();
            var engine = new Engine(database);

            engine.Run();
        }
    }
}