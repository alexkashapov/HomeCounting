using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCounting.Model
{
    class Operation
    {
        private String type;
        private Double value;
        private String from;
        private String to;
        private String category;
        private String description;

        public Operation()
        {

        }

        public Operation(string type, double value, string from, string to, string category)
        {
            this.type = type;
            this.value = value;
            this.from = from;
            this.to = to;
            this.category = category;
        }

        public Operation(string type, double value, string from, string to, string category, string description)
        {
            this.type = type;
            this.value = value;
            this.from = from;
            this.to = to;
            this.category = category;
            this.description = description;
        }

        public string Type { get => type; set => type = value; }
        public double Value { get => value; set => this.value = value; }
        public string From { get => from; set => from = value; }
        public string To { get => to; set => to = value; }
        public string Category { get => category; set => category = value; }
        public string Description { get => description; set => description = value; }
    }
}
