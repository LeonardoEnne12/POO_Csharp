using System.Collections.Generic;
using Conceitos_POO.ContentContext.Enums;
using Conceitos_POO.ShareContext;

namespace Conceitos_POO.ContentContext
{
    public class Lecture : Base
    {
        public int Order { get; set; }

        public string Title { get; set; }

        public int DurationInMinutes { get; set; }

        public EContentLevel Level { get; set; }

    }
}