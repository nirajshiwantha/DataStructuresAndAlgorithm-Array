using System;
using System.Collections.Generic;
namespace Arrays.DataCompressionAlgorithms
{
    public class HuffmanCodingAlgo
    {
        public class Node : IComparable<Node>
        {
            public char Character { get; set; }
            public int Frequency { get; set; }
            public Node Left { get; set; }
            public Node Right { get; set; }

            public Node(char character, int frequency)
            {
                Character = character;
                Frequency = frequency;
                Left = null;
                Right = null;
            }

            public Node(char character, int frequency, Node left, Node right)
            {
                Character = character;
                Frequency = frequency;
                Left = left;
                Right = right;
            }

            public int CompareTo(Node other)
            {
                return Frequency.CompareTo(other.Frequency);
            }

            public bool IsLeaf()
            {
                return Left == null && Right == null;
            }
        }

        public Node BuildHuffmanTreeFromMessage(string message)
        {
            // Step 1: Count the frequency of each character
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach (char c in message)
            {
                if (!frequency.ContainsKey(c))
                {
                    frequency.Add(c, 0);
                }
                frequency[c]++;
            }

            // Step 2: Create a list of nodes for each character and its frequency
            List<Node> nodes = new List<Node>();
            foreach (char c in frequency.Keys)
            {
                nodes.Add(new Node(c, frequency[c]));
            }

            // Step 3: Build the Huffman Tree
            while (nodes.Count > 1)
            {
                // Sort the nodes by frequency
                nodes.Sort();

                // Take the two nodes with the smallest frequency
                Node left = nodes[0];
                Node right = nodes[1];

                // Combine the two nodes into a new node with their sum as frequency
                Node parent = new Node('\0', left.Frequency + right.Frequency, left, right);

                // Remove the two nodes and add the parent node
                nodes.Remove(left);
                nodes.Remove(right);
                nodes.Add(parent);
            }

            // Return the root node of the Huffman Tree
            return nodes[0];
        }

        public string Encode(string message)
        {
            // Step 1: Count the frequency of each character
            Dictionary<char, int> frequency = new Dictionary<char, int>();
            foreach (char c in message)
            {
                if (!frequency.ContainsKey(c))
                {
                    frequency.Add(c, 0);
                }
                frequency[c]++;
            }

            // Step 2: Create a list of nodes for each character and its frequency
            List<Node> nodes = new List<Node>();
            foreach (char c in frequency.Keys)
            {
                nodes.Add(new Node(c, frequency[c]));
            }

            // Step 3: Build the Huffman Tree
            while (nodes.Count > 1)
            {
                // Sort the nodes by frequency
                nodes.Sort();

                // Take the two nodes with the smallest frequency
                Node left = nodes[0];
                Node right = nodes[1];

                // Combine the two nodes into a new node with their sum as frequency
                Node parent = new Node('\0', left.Frequency + right.Frequency, left, right);

                // Remove the two nodes and add the parent node
                nodes.Remove(left);
                nodes.Remove(right);
                nodes.Add(parent);
            }

            // Step 4: Generate the Huffman Codes
            Dictionary<char, string> codes = new Dictionary<char, string>();
            GenerateCodes(nodes[0], "", codes);

            // Step 5: Encode the message using the Huffman Codes
            string encodedMessage = "";
            foreach (char c in message)
            {
                encodedMessage += codes[c];
            }
            return encodedMessage;
        }

        public string Decode(string encodedMessage, Node huffmanTree)
        {
            // Step 6: Decode the message using the Huffman Tree
            string decodedMessage = "";
            Node current = huffmanTree;
            foreach (char c in encodedMessage)
            {
                if (c == '0')
                {
                    current = current.Left;
                }
                else if (c == '1')
                {
                    current = current.Right;
                }

                if (current.IsLeaf())
                {
                    decodedMessage += current.Character;
                    current = huffmanTree;
                }
            }
            return decodedMessage;
        }

        static void GenerateCodes(Node node, string code, Dictionary<char, string> codes)
        {
            if (node.IsLeaf())
            {
                codes.Add(node.Character, code);
            }
            else
            {
                GenerateCodes(node.Left, code + "0", codes);
                GenerateCodes(node.Right, code + "1", codes);
            }
        }
    }
}