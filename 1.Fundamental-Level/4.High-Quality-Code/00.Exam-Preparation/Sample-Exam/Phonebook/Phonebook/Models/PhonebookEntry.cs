namespace Phonebook.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PhonebookEntry : IComparable<PhonebookEntry>
    {
        public PhonebookEntry(string name)
        {
            this.Name = name;
            this.PhoneNumbers = new SortedSet<string>();
        }

        public string Name { get; }

        public SortedSet<string> PhoneNumbers { get; set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append('[');
            result.Append(this.Name);
            bool flag = true;
            foreach (var phone in this.PhoneNumbers)
            {
                if (flag)
                {
                    result.Append(": ");
                    flag = false;
                }
                else
                {
                    result.Append(", ");
                }

                result.Append(phone);
            }

            result.Append(']');
            return result.ToString();
        }

        public int CompareTo(PhonebookEntry other)
        {
            return this.Name.ToLowerInvariant().CompareTo(other.Name.ToLowerInvariant());
        }
    }
}
