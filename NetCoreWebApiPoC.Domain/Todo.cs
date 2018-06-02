using System;

namespace NetCoreWebApiPoC.Domain
{
    public class Todo
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool Done { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
