using System;
using Freelancer.Common;

namespace Freelancer.Entities
{
    internal class Review : EntityBase<Guid>
    {
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}