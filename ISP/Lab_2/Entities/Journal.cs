using Lab_2.Collections;

namespace Lab_2.Entities;

public class Journal
{
    private struct EventLogger {

        public MyCustomeCollection<string> Changes;
        public string Characteristick;
        public string EntitiName;

    };

    private MyCustomeCollection<EventLogger> eventLoggers = new MyCustomeCollection<EventLogger>();

    public void ServicesAdd(MyCustomeCollection<Services> services) {

        EventLogger eventLogger;
        eventLogger.EntitiName = "Services";
        eventLogger.Characteristick = "get bigger";

        eventLogger.Changes = new MyCustomeCollection<string>();

        foreach(var service in services) {

            eventLogger.Changes.Add(service.ServiceTarif.Name + " " + service.ServicesAmount.ToString());

        }

        LogEvent(eventLogger);

    }

    public void ServicesRemove(MyCustomeCollection<Services> services) {

        EventLogger eventLogger;
        eventLogger.EntitiName = "Services";
        eventLogger.Characteristick = "get less";

        eventLogger.Changes = new MyCustomeCollection<string>();

        foreach(var service in services) {

            eventLogger.Changes.Add(service.ServiceTarif.Name + " " + service.ServicesAmount.ToString());

        }

        LogEvent(eventLogger);

    }

    public void TenatsAdd(MyCustomeCollection<Tenat> tenats) {

        EventLogger eventLogger;
        eventLogger.EntitiName = "Tenats";
        eventLogger.Characteristick = "get bigger";

        eventLogger.Changes = new MyCustomeCollection<string>();

        foreach(var tenat in tenats) {

            eventLogger.Changes.Add(tenat.TenatName + " " + tenat.TenatSurname);

        }

        LogEvent(eventLogger);

    }

    public void TenatsRemove(MyCustomeCollection<Tenat> tenats) {

        EventLogger eventLogger;
        eventLogger.EntitiName = "Tenats";
        eventLogger.Characteristick = "get less";

        eventLogger.Changes = new MyCustomeCollection<string>();

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
