using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender
{
    public class ePatient
    {
        public string Id { get; set; }
        public string PId { get; set; }
        public string FName { get; set; }
        public string Address { get; set; }
        public ePatient(string msbn, string socmnd, string hoten, string diachi)
        {
            this.Id = msbn;
            this.PId = socmnd;
            this.FName = hoten;
            this.Address = diachi;

        }
        public ePatient()
        {

        }
        public override string ToString()
        {
            return FName;


        }
    }
}
