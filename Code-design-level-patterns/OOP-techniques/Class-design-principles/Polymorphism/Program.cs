using Polymorphism.Abstractions;
using Polymorphism.Realisations;

var sequence = new int[] { 1, 2, 3, 4, 5 };

AlgorithmBase<int> algorithm1 = new BubbleSort<int>();
AlgorithmBase<int> algorithm2 = new QuickSort<int>();

algorithm1.Sort(sequence);
algorithm2.Sort(sequence);