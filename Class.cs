using System;
using System.Collections.Generic;

namespace ExceptionHandlingTask_DanDavison
{
    public class Class
    {
        public string roomNo;
        public string firstName;
        public string lastName;
        public DateTime entry;
        public DateTime exit;
        public double duration;
        public Class()
        {
            this.roomNo = "";
            this.firstName = "";
            this.lastName = "";
            this.entry = new DateTime();
            this.exit = new DateTime();
            this.duration = 0;
        }
    }
}