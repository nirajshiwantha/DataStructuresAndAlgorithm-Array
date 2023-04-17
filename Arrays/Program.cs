using Arrays.BasicOperations;
using Arrays.DataCompressionAlgorithms;
using Arrays.DynamicProgrammingAlgorithms;
using Arrays.SearchAlgorithms;
using Arrays.SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Arrays.DataCompressionAlgorithms.HuffmanCodingAlgo;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // You can uncomment appropriate lines and run to see the output //

            ////////////////////// Basic Ops Start Here //////////////////////
            BasicArrayOperations basicOps = new BasicArrayOperations();
            //int[] arr = { 1, 2, 3, 4, 5 };
            //basicOps.AddToZeroIndex(arr, 0);
            //basicOps.RemoveFirstElement(arr);
            //basicOps.AddToLastPlace(arr, 9);
            //basicOps.DeleteLastElement(arr);
            //basicOps.AddElementAtIndex(arr, 2, 13);
            //basicOps.DeleteElementAtIndex(arr,3);
            ////////////////////// Basic Ops End Here //////////////////////
            

            /////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////


            ////////////////////// Bubble Sort Start Here //////////////////////
            //int[] arr = { 1, 6, 3, 19, 5 };
            BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.BubbleSortAlgo(arr);
            ////////////////////// Bubble Sort End Here //////////////////////

            ////////////////////// Selection Sort Start Here //////////////////////
            //int[] arr = { 2, 7, 3, 12, 5};
            SelectionSort selectionSort = new SelectionSort();
            //selectionSort.SelectionSortAlgo(arr);
            ////////////////////// Selection Sort End Here //////////////////////

            ////////////////////// Insertion Sort Start Here //////////////////////
            //int[] arr = { 19, 16, 11, 18, 9 };
            InsertionSort insertionSort = new InsertionSort();
            //insertionSort.InsertionSortAlgo(arr);
            ////////////////////// Insertion Sort End Here //////////////////////

            ////////////////////// Merge Sort Start Here //////////////////////
            //int[] arr = { 19, 16, 11, 18, 9 };
            MergeSort mergeSort = new MergeSort();
            //mergeSort.MergeSortAlgo(arr,1,3);
            ////////////////////// Merge Sort End Here //////////////////////

            ////////////////////// Quick Sort Start Here //////////////////////
            //int[] arr = { 19, 16, 11, 18, 9 };
            QuickSort quickSort = new QuickSort();
            //quickSort.QuickSortAlgo(arr,0,3);
            ////////////////////// Quick Sort End Here //////////////////////

            ////////////////////// Heap Sort Start Here //////////////////////
            //int[] arr = { 19, 16, 11, 18, 9 };
            HeapSort heapSort = new HeapSort();
            //heapSort.HeapSortAlgo(arr);
            ////////////////////// Heap Sort End Here //////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////////////////////////////

            ////////////////////// Linear Search Start Here //////////////////////
            //int[] arr = { 19, 16, 11, 18, 9 };
            LinearSearch linearSearch = new LinearSearch();
            //int result = linearSearch.LinearSearchAlgo(arr, 18);
            //Console.WriteLine(result);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            ////////////////////// Linear Search End Here //////////////////////

            ////////////////////// Binary Search Start Here //////////////////////
            //int[] arr = {1, 16, 19, 28, 34};
            BinarySearch binarySearch = new BinarySearch();
            //int result = binarySearch.BinarySearchAlgo(arr, 180);
            //Console.WriteLine(result);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            ////////////////////// Binary Search End Here //////////////////////

            ////////////////////// Interpolation Search Start Here //////////////////////
            //int[] arr = {1, 16, 19, 28, 34};
            InterpolationSearch interpolationSearch = new InterpolationSearch();
            //int result = interpolationSearch.InterpolationSearchAlgo(arr, 19);
            //Console.WriteLine(result);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            ////////////////////// Interpolation Search End Here //////////////////////

            ////////////////////// Jump Search Start Here //////////////////////
            //int[] arr = {1, 16, 19, 28, 34};
            JumpSearch jumpSearch = new JumpSearch();
            //int result = jumpSearch.JumpSearchAlgo(arr, 19);
            //Console.WriteLine(result);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            ////////////////////// Jumo Search End Here //////////////////////

            ////////////////////// Jump Search Start Here //////////////////////
            //int[] arr = { 100, 16, 129, 28, 34 };
            ExponentialSearch ExponentialSearch = new ExponentialSearch();
            //int result = ExponentialSearch.ExponentialSearchAlgo(arr, 34);
            //Console.WriteLine(result);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            ////////////////////// Jumo Search End Here //////////////////////

            ////////////////////// LCS algorithm Start Here //////////////////////
            // define two strings to find the longest common subsequence
            //string s1 = "ABCDF";
            //string s2 = "AEDF";

            // call the lcs function to calculate the length of the longest common subsequence
            LCS lcs = new LCS();

            //int result = lcs.LcsAlgo(s1, s2);
            //Console.WriteLine("The longest common subsequence is " + result);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            ////////////////////// LCS algorithm End Here //////////////////////

            ////////////////////// Knapsack algorithm Start Here //////////////////////
            //int[] val = new int[] { 50, 60, 70, 30, 20 }; 
            //int[] wt = new int[] { 3, 4, 6, 2, 1 };
            //int W = 10;
            //int n = val.Length;

            // Call the knapsack function to solve the problem and get the maximum value
            Knapsack knapsack = new Knapsack();
            //int result = knapsack.KnapsackAlgo(W, wt, val, n);
            // Output the result
            //Console.WriteLine("The maximum value that can be obtained is " + result);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            ////////////////////// Knapsack algorithm End Here //////////////////////

            ////////////////////// Huffman Coding algorithm Start Here //////////////////////
            HuffmanCodingAlgo huffmanCoding = new HuffmanCodingAlgo();
            //string message = "abbcccddddeeeee";
            //Console.WriteLine("Original Message: " + message);

            // Encode the message using Huffman Coding
            //string encodedMessage = huffmanCoding.Encode(message);
            //Console.WriteLine("Encoded Message: " + encodedMessage);

            // Decode the message using Huffman Coding
            //HuffmanCodingAlgo.Node huffmanTree = huffmanCoding.BuildHuffmanTreeFromMessage(message);
            //string decodedMessage = huffmanCoding.Decode(encodedMessage, huffmanTree);
            //Console.WriteLine("Decoded Message: " + decodedMessage);
            //Console.WriteLine("Press any key to exit...");
            //Console.ReadKey();
            ////////////////////// Huffman Coding algorithm End Here //////////////////////

            ////////////////////// LZW Compression algorithm Start Here //////////////////////
            //string inputText = "abbcccddddeeeee";
            LZWCompression LZWCompression = new LZWCompression();
            //List<int> compressedOutput = LZWCompression.Compress(inputText);
            //Console.WriteLine($"Compressed Output: {string.Join(",", compressedOutput)}");

            //string decompressedOutput = LZWCompression.Decompress(compressedOutput);
            //Console.WriteLine($"Decompressed Output: {decompressedOutput}");
            //Console.ReadLine();
            ///////////////////////// LZW Compression algorithm End Here //////////////////////

            ////////////////////// RLE Compression algorithm Start Here //////////////////////
            string inputText = "AAAABBBCCD";
            RunLengthEncoding runLengthEncoding = new RunLengthEncoding();
            string compressedOutput = runLengthEncoding.Compress(inputText);
            Console.WriteLine($"Compressed Output: {compressedOutput}");

            string decompressedOutput = runLengthEncoding.Decompress(compressedOutput);
            Console.WriteLine($"Decompressed Output: {decompressedOutput}");
            Console.ReadLine();
            ///////////////////////// RLE Compression algorithm End Here //////////////////////
        }
    }
}
