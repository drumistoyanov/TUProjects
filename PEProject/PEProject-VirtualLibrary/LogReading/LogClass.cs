using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using CsvHelper.Configuration.Attributes;

namespace SearchSystem_ZartAlgorithm.LogReading
{
    public class LogClass
    {
        [Index(0)]
        public string Time { get; set; }
        [Index(1)]
        public string EventContext { get; set; }
        [Index(2)]
        public string Component { get; set; }
        [Index(3)]
        public string EventName { get; set; }
        [Index(4)]
        public string Description { get; set; }
        [Index(5)]
        public string Origin { get; set; }
        [Index(6)]
        public string IP { get; set; }

        public override string ToString()
        {
            return $"{this.Time}|{this.EventContext}|{ this.Component}|{this.EventName}|{this.Description}|{this.Origin}|{this.IP}";
        }
    }
}