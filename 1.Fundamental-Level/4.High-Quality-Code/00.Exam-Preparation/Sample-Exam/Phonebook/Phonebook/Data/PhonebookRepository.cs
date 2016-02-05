namespace Phonebook.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Phonebook.Contracts;
    using Phonebook.Models;

    using Wintellect.PowerCollections;

    // Using the faster phonebook repository class
    public class PhonebookRepository : IPhonebookRepository
    {
        private readonly OrderedSet<PhonebookEntry> entriesSorted = new OrderedSet<PhonebookEntry>();
        private readonly Dictionary<string, PhonebookEntry> entriesByName = new Dictionary<string, PhonebookEntry>();
        private readonly MultiDictionary<string, PhonebookEntry> entriesByPhone = new MultiDictionary<string, PhonebookEntry>(false);

        public bool AddPhone(string name, IEnumerable<string> phoneNumbers)
        {
            string lowerName = name.ToLowerInvariant();
            PhonebookEntry phonebook;

            bool isNewEntry = !this.entriesByName.TryGetValue(lowerName, out phonebook);
            if (isNewEntry)
            {
                phonebook = new PhonebookEntry(name);
                this.entriesByName.Add(lowerName, phonebook);
                this.entriesSorted.Add(phonebook);
            }

            foreach (var number in phoneNumbers)
            {
                this.entriesByPhone.Add(number, phonebook);
            }

            phonebook.PhoneNumbers.UnionWith(phoneNumbers);

            return isNewEntry;
        }

        public int ChangePhone(string oldPhoneNumber, string newPhoneNumber)
        {
            var matched = this.entriesByPhone[oldPhoneNumber].ToList();
            foreach (var entry in matched)
            {
                entry.PhoneNumbers.Remove(oldPhoneNumber);
                this.entriesByPhone.Remove(oldPhoneNumber, entry);
                entry.PhoneNumbers.Add(newPhoneNumber);
                this.entriesByPhone.Add(newPhoneNumber, entry);
            }

            return matched.Count;
        }

        public PhonebookEntry[] ListEntries(int first, int num)
        {
            if (first < 0 || first + num > this.entriesByName.Count)
            {
                throw new ArgumentException("Invalid range");
            }

            PhonebookEntry[] list = new PhonebookEntry[num];

            for (int i = first; i <= first + num - 1; i++)
            {
                PhonebookEntry entry = this.entriesSorted[i];
                list[i - first] = entry;
            }

            return list;
        }
    }
}