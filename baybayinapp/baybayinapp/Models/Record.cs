using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace baybayinapp.Models
{
    public class Record
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string RecordName { get; set; }
        public string RecordType { get; set; }
        public int RecordScore { get; set; }
        public string RecordDate { get; set; }
    }
}
