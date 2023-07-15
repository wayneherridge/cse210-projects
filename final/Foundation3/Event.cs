public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event Type: {GetType().Name}\n" +
               $"Title: {_title} : {_description}\n" +
               $"Date & Time: {_date.ToShortDateString()} @ {_time.ToString()}\n" +
               $"Address: {_address.GetAddressDetails()}\n";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event Type: {GetType().Name}\n" +
               $"Title: {_title}\n" +
               $"Date: {_date.ToShortDateString()}\n";
    }
}
