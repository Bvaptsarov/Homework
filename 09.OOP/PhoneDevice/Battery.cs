using System;
using System.Linq;

namespace PhoneDevice
{
    public class Battery
    {
        public enum BatteryType
        {
            Unknown = 0,
            LiIon = 1,
            NiMH = 2,
            NiCd = 3
        };
        public String BatteryModel { get; set; }

        private double? hoursIdle;
        private double? hoursTalk;

        public BatteryType? Type = null;

        public Battery()
        {
            BatteryModel = null;
            HoursIdle = null;
            HoursTalk = null;
            Type = BatteryType.Unknown;
        }

        public Battery(string model, double idle, double talk, int type)
        {
            BatteryModel = model;
            //idle positive value checker, return 0 if false
            if (idle >= 0)
                HoursIdle = idle;
            else
                HoursIdle = 0;
            //talk positive value checker, return 0 if false
            if (talk >= 0)
                HoursTalk = talk;
            else
                hoursTalk = 0;
            //type range checker from 0..3 
            if (type > 4 || type < 0) Type = (BatteryType)0;
            else Type = (BatteryType)type;
        }

        public double? HoursIdle // nulling the value if negative
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value >= 0)
                    hoursIdle = value;
                else
                {
                    hoursIdle = 0;
                }
            }
        }

        public double? HoursTalk //nulling the value of negative
        {
            get
            {
                return hoursTalk;
            }
            set
            {
                if (value >= 0)
                    hoursTalk = value;
                else
                {
                    hoursTalk = 0;
                }
            }
        }

        internal string Info()
        {
            return String.Format("\nBattery Info :\n\tBattery model - {0}\n\tHoursIdle - {1}\n\tHoursTalk - {2}\n\tBattery type - {3} ", BatteryModel, HoursIdle, HoursTalk, Type);
        }
    }
}