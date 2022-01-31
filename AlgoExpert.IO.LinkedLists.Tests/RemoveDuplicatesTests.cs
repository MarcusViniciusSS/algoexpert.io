using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace AlgoExpert.IO.LinkedLists.Tests;

public class RemoveDuplicatesTests
{
    [Fact]
    public void RemoveDuplicate()
    {
        var input = new LinkedList(1);
        GenerateLinkedList(input, new List<int>
        {
            1, 3, 4, 4, 4, 5, 6, 6
        });
        
        var expectedNodes = new List<int> {
            1, 3, 4, 5, 6
        };
        
        var output = new RemoveDuplicateFromLinkedList().Remove(input);
        
        Assert.True(getNodesInArray(output).SequenceEqual(expectedNodes));
    }

    private LinkedList GenerateLinkedList(LinkedList ll, List<int> values)
    {
        LinkedList current = ll;
        while (current.next != null) {
            current = current.next;
        }
        foreach (var value in values) {
            current.next = new LinkedList(value);
            current = current.next;
        }
        return ll;
    }
    
    private List<int> getNodesInArray(LinkedList ll) {
        List<int> nodes = new List<int>();
        LinkedList current = ll;
        while (current != null) {
            nodes.Add(current.value);
            current = current.next;
        }
        return nodes;
    }
}