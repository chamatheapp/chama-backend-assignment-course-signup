using System;

namespace Chama.Domain.DomainExceptions
{
    [Serializable]
    public class NotFoundException : Exception
    {
        public string SearchedKey { get; private set; }

        public NotFoundException(string description, string key) : base(description)
        {
            SearchedKey = key;
        }
    }
}