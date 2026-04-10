public class LinkedList {
    private class Node{
        public int value;
        public Node next;

        public Node(int value) {
            this.value = value;
            this.next = null;
        }

    }

    private Node head;
    

    public LinkedList() {
        this.head = null;
    }



    public int Get(int index) {        
        Node current = head;
        int count = index;
        while (current != null && count > 0) {
            // move pointer up a node
            current = current.next;
            count--;
            }
        if (current == null) {
            return -1;
            }
        return current.value;
    }

    public void InsertHead(int val) {
        Node nodeNew = new Node(val); // create new node with val value
        Node current = head; // create current node with head variable
        nodeNew.next = current; 
        head = nodeNew;
        
    }

    public void InsertTail(int val) {
        Node nodeNew = new Node(val);
        Node current = head;
        // if the current node is null (list empty) assign to nodeNew
        if (current == null) { 
            head = nodeNew; // update the head if we have an empty list
            return; // return out of the if statement
        }
        
        while (current.next != null) {
            current = current.next;
        }
        current.next = nodeNew;
    }

    public bool Remove(int index) {
        Node previous = null;
        Node current = head;
        
        for (int i = 0; i < index; i++) {
            if (current == null) {
                return false;
            }

            previous = current;
            current = current.next;
        }

        if (current == null) {
            return false; 
        }

        if (previous == null) {
            // Removing the head
            head = current.next;
        } else {
            // Removing any other node
            previous.next = current.next;
        }

        return true;

    }

    public List<int> GetValues() {
        List<int> values = new List<int>();
        Node current = head;
       
        while (current != null) {
            values.Add(current.value);
            current = current.next;
        }

        return values;
    }
}