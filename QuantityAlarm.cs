using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipApp
{
    class QuantityAlarm
    {

        private int alarmQuantity;
        private string alarmName;

        public QuantityAlarm()
        {

        }

        public QuantityAlarm(int alarmQuantity, string alarmName)
        {
            this.alarmQuantity = alarmQuantity;
            this.alarmName = alarmName; 
        }

        public int AlarmQuantity { get => alarmQuantity; set => alarmQuantity = value; }
        public string AlarmName { get => alarmName; set => alarmName = value; }
    }
}
