using System;

namespace NetCoreWebApiPoC.Data.Dto
{
    public class TodoDto
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public bool Done { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
