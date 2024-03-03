using System;

namespace EFramework
{
    public class APIDescriptionENAttribute : Attribute
    {
        public string Description { get; private set; }

        public APIDescriptionENAttribute(string description)
        {
            Description = description;
        }
        
    }
}