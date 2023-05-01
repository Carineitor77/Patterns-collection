namespace Polymorphism.Abstractions;

public abstract class AlgorithmBase<T> where T : IComparable
{
    protected void Swap(ref T a, ref T b) => (a, b) = (b, a);

    public abstract IEnumerable<T> Sort(IEnumerable<T> sequence);
}