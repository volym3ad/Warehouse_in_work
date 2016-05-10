using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kursachForAxl
{
    class Date
    {
        protected uint day;
        protected uint month;
        protected uint year;

        protected void SetDate (uint _day, uint _month, uint _year)
        {
            this.day = _day;
            this.month = _month;
            this.year = _year;
        }
    }
}
