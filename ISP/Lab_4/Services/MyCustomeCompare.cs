using Lab_4.Entities.Passanger;

namespace Lab_4.Services.MyCustomeCompaer;

public class MyCustomeCompare : IComparer<Passanger>
{
    public int Compare(Passanger? first, Passanger? second)
    {

        if (first == null) throw new ArgumentNullException(nameof(first));
        
        if(second == null) throw new ArgumentNullException(nameof(second));

        int comparison = String.Compare(first.Name, second.Name, comparisonType: StringComparison.OrdinalIgnoreCase);

        return comparison;

    }
}