using System;
using System.Collections.Generic;
using System.Linq;

namespace PhoneDevice
{
    public class Gsm
    {
        public String Model { get; set; }
        public String Manufacturer { get; set; }
        public String Owner { get; set; }
        public double? Price { get; set; }

        private Battery newBattery = null;
        private Display newDisplay = null;
        private List<Call> CallHistory = new List<Call>();

        public static readonly object IPhone4S = new Gsm("Iphone4S","Apple",899.99,"Unknown",new Battery("unknown",800,300,2),new Display("800/480","16m")); //initializing a static member - Iphone4S

        public Gsm(string model, string manufacturer)
        {
            Model = model;
            Manufacturer = manufacturer;
        }

        public Gsm(string model, string manufacturer, double price) : this(model, manufacturer)
        {
            //better than throwing an exception, just nulling the value
            if (Check(Price))
                Price = price;
            else
                Price = 0;
        }

        public Gsm(string model, string manufacturer, double price, string owner) : this(model, manufacturer, price)
        {
            Owner = owner;
        }

        public Gsm(string model, string manufacturer, double price, string owner, Battery temporaryBattery, Display temporaryDisplay)
        {
            Model = model;
            Manufacturer = manufacturer;
            Price = price;
            Owner = owner;
            newBattery = temporaryBattery;
            newDisplay = temporaryDisplay;
        }

        public override string ToString() //printing info for Gsm and battery(via NewBattery.Info() from the class Battery(Battery.cs in the PhoneDevice)
        {
            String info = "PhoneDevice Info :\n\tModel - " + Model + "\n\tManufacturer - " + Manufacturer + "\n\tPrice - " + Price + "\n\tOwner - " + Owner;
            if (newBattery == null && newDisplay == null)
            {
                return info;
            }
            else if (newDisplay == null && newBattery != null)
                return (info + newBattery.Info());
            else if (newDisplay != null && newBattery != null)
                return (info + newBattery.Info() + newDisplay.Info());
            else
                return (info + newDisplay.Info());
        }

        private bool Check(double? price)
        {
            if (price >= 0 || price == null)
                return true;
            else
                return false;
        }

        public void AddCall(Call givenCall)
        {
            CallHistory.Add(givenCall);
        }

        public void RemoveCallByIndex(int index)
        {
            try
            {
                if (index >= 0 && index < this.CallHistory.Count())
                    this.CallHistory.RemoveAt(index);
                else
                    throw new IndexOutOfRangeException();
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of boundaries");
            }
        }

        public void RemoveCallByCall(Call givenCall)
        {
            this.CallHistory.Remove(givenCall);
        }

        public void GetCallHistory()
        {
            foreach (var i in this.CallHistory)
                Console.WriteLine("Date - {0}\nCalled number - {1}\nTime Duration in seconds - {2}\n", i.Date, i.DialedNumber, i.Duration);
        }

        public void ClearAllCalls()
        {
            this.CallHistory.Clear();
        }

        public decimal? TotalPrice(decimal cost)
        {
            decimal temp = 0;
            foreach (var i in this.CallHistory)
            {
                temp += (decimal)i.Duration;
            }
            return ((temp / 60) * cost);
        }
    }
}