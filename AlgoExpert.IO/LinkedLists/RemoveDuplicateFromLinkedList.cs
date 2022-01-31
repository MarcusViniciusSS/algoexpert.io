namespace AlgoExpert.IO.LinkedLists
{
    public class RemoveDuplicateFromLinkedList
    {
        public LinkedList Remove(LinkedList linkedList)
        {
            var current = linkedList;

            while (current.next != null)
            {
                if (current.next.value != current.value)
                {
                    current = current.next;
                    continue;
                }

                var otherNode = current.next.next;
                current.next = otherNode;
            }
            
            return linkedList;
        }
    }

    public class LinkedList
    {
        public int value;
        public LinkedList next;

        public LinkedList(int value)
        {
            this.value = value;
            this.next = null;
        }
    }
}