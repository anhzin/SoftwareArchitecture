using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLogic.Entities
{
    public class TransactionResult
    {
        public TransactionResult()
        {

        }
        public TransactionResult(bool success, string error)
        {
            this.Success = success;
            this.Error = error;
        }
        public bool Success { get; set; }
        public string Error { get; set; }
        public long CurrentIdentity { get; set; }
    }
}
