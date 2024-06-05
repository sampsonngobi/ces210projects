    using System;

    public class Event
    {
        private string _title; 
        private string _description;
        private string _date;
        private string _time;
        private Address _address;
     


        public Event(string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date; 
            _time = time;
            _address = address;
           
        }

        public string GetTitle()
        {
            return _title;
        }

         public string GetDescription()
        {
            return _description;
        }

         public string GetDate()
        {
            return _date;
        }

         public string GetTime()
        {
            return _time;
        }

        public Address GetAddress()
        {
            return _address;
        }

        public virtual void GetStandardDetails()
        {
            Console.WriteLine("STANDARD DETAILS");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Descrition: {_description}");
            Console.WriteLine($"Date: {_date}  Time: {_time}");
            Console.WriteLine($"Address: {_address.GetAddress()}");
        }

        public virtual void GetFullDetails()
        {
            Console.WriteLine("FULL DETAILS");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Descrition: {_description}");
            Console.WriteLine($"Date: {_date}  Time: {_time}");
             Console.WriteLine($"Address: {_address.GetAddress()}");
            
        }

        public virtual void GetShortDescription()
        {
            Console.WriteLine("Event Type: ");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Date: {_date}");
        }
    }