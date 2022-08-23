using System.Collections.Generic;

namespace Angular_test.Models
{
    public abstract class BaseResponse
    {
        public List<string> Errors { get; set; }

        public bool HasError { get; set; }

        public bool IsSuccessFull { get; set; }
    }
}
