using System;

namespace Freelancer.Common
{
    internal class Person<TKey> : EntityBase<TKey>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
