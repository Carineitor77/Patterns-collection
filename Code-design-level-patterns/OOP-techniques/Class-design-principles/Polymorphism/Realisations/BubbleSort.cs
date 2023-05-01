using Polymorphism.Abstractions;

namespace Polymorphism.Realisations;

public class BubbleSort<T> : AlgorithmBase<T> 
    where T : IComparable
{
    public override IEnumerable<T> Sort(IEnumerable<T> sequence)
    {
        // use Swap
        // sorting sequence
        
        return sequence;
    }
}