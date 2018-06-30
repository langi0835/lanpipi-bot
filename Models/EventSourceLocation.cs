using Microsoft.WindowsAzure.Storage.Table;

namespace lanpipibot.Models
{
    public class EventSourceLocation : EventSourceState
    {
        public string Location { get; set; }

        public EventSourceLocation() { }
    }
}