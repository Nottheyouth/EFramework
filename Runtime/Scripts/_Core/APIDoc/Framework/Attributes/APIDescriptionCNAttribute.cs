using System;

namespace EFramework
{
    public class APIDescriptionCNAttribute : Attribute
    {
        public string Description { get; private set; }

        public APIDescriptionCNAttribute(string description)
        {
            Description = description;
        }
    }
}