using System;

namespace Freelancer.Abstract
{
    internal interface ICsvConvertible
    {
        public string GetValuesCSV();
        public void SetValueCSV(string csvLine);
    }
}
