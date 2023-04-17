using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.BasicOperations
{
    public class BasicArrayOperations
    {
        public void AddToZeroIndex(int[] arr, int element)
        {
            // Shift all elements to the right by 1
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }

            // Insert element at the 0th index
            arr[0] = element;

            PrintArray(arr);


        }

        public void RemoveFirstElement(int[] arr)
        {
            // Shift all elements to the left by 1
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            // Set the last element to 0
            arr[arr.Length - 1] = 0;

            PrintArray(arr);
        }

        public void AddToLastPlace(int[] arr, int element)
        {
            // Set the last element to the new element
            arr[arr.Length - 1] = element;

            PrintArray(arr);
        }

        public void DeleteLastElement(int[] arr)
        {
            int n = arr.Length;

            // Create a new array of size n-1
            int[] newArr = new int[n - 1];

            // Copy elements from the original array to the new array
            for (int i = 0; i < n - 1; i++)
            {
                newArr[i] = arr[i];
            }

            // Set the original array to the new array
            arr = newArr;

            // Print the updated array
            Console.WriteLine("Array after deleting last element:");
            PrintArray(arr);
        }

        public void AddElementAtIndex(int[] arr, int index, int value)
        {
            int n = arr.Length;

            // Create a new array of size n+1
            int[] newArr = new int[n + 1];

            // Copy elements before the index to the new array
            for (int i = 0; i < index; i++)
            {
                newArr[i] = arr[i];
            }

            // Insert the new value at the index
            newArr[index] = value;

            // Copy elements after the index to the new array
            for (int i = index + 1; i < n + 1; i++)
            {
                newArr[i] = arr[i - 1];
            }

            // Set the original array to the new array
            arr = newArr;

            // Print the updated array
            Console.WriteLine("Array after adding element at index " + index + ":");
            PrintArray(arr);
        }

        public void DeleteElementAtIndex(int[] arr, int index)
        {
            // First, check if the index is valid
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Error: Invalid index.");
                return;
            }

            // Shift all elements to the left of the deleted element
            for (int i = index; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
            }

            // Set the last element to 0 or null
            arr[arr.Length - 1] = 0;
            // Or, for reference types:
            // arr[arr.Length - 1] = null;

            Console.WriteLine("Element at index {0} deleted successfully.", index);

            PrintArray(arr);
        }

        public void PrintArray(int[] arr)
        {
            // Print the input array
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(",");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
