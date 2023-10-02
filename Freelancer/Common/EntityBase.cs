using System;

namespace Freelancer.Common
{
    internal class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }

    }
}