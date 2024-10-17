namespace Lab_3.Entities;

public class Journal
{
    private struct EventLogger {

        public List<string> Changes;
        public string Characteristick;

        public string EntitiName;

    };

    private List<EventLogger> eventLoggers = new List<EventLogger>();

    public void ServicesAdd(Dictionary<string, Services> services) {

        EventLogger eventLogger;
        eventLogger.EntitiName = "Services";
        eventLogger.Characteristick = "get bigger";

        eventLogger.Changes = new List<string>();

        foreach(var service in services) {

            eventLogger.Changes.Add(service.Value.ServiceTarif.Name + " " + service.Value.ServicesAmount.ToString());

        }

        LogEvent(eventLogger);

    }

    public void ServicesRemove(Dictionary<string, Services> services) {

        EventLogger eventLogger;
        eventLogger.EntitiName = "Services";
        eventLogger.Characteristick = "get less";

        eventLogger.Changes = new List<string>();

        foreach(var service in services) {

            eventLogger.Changes.Add(service.Value.ServiceTarif.Name + " " + service.Value.ServicesAmount.ToString());

        }

        LogEvent(eventLogger);

    }

    public void TenatsAdd(List<Tenat> tenats) {

        EventLogger eventLogger;
        eventLogger.EntitiName = "Tenats";
        eventLogger.Characteristick = "get bigger";

        eventLogger.Changes = new List<string>();

        foreach(var tenat in tenats) {

            eventLogger.Changes.Add(tenat.TenatName + " " + tenat.TenatSurname);

        }

        LogEvent(eventLogger);

    }

    public void TenatsRemove(List<Tenat> tenats) {

        EventLogger eventLogger;
        eventLogger.EntitiName = "Tenats";
        eventLogger.Characteristick = "get less";

        eventLogger.Changes = new List<string>();

        foreach(var tenat in tenats) {

            eventLogger.Changes.Add(tenat.TenatName + " " + tenat.TenatSurname);

        }

        LogEvent(eventLogger);

    }

    private void LogEvent(EventLogger eventLogger) {

        eventLoggers.Add(eventLogger);

    }

    public void InputEvents() {

        foreach(var eventLogger in eventLoggers) {

            Console.WriteLine(eventLogger.EntitiName + " " + eventLogger.Characteristick);
            foreach (var change in eventLogger.Changes) {
                
                Console.WriteLine(change);

            }

        }

    }

}
