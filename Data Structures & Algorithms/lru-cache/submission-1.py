
class Node:
    def __init__(self, key, val):
        self.key = key
        self.val = val
        self.next = None
        self.prev = None

class LRUCache:

    def __init__(self, capacity: int):
        self.cap = capacity
        self.cache = {}

        # head and tail are dummy nodes and never replaced or modified/moved 
        # directly
        self.head = Node(0,0) # will be the most recently used 
        self.tail = Node(0,0) # will be the least recently used
        
        self.head.next = self.tail
        self.head.prev = None

        self.tail.prev = self.head
        self.tail.next = None


    def insert(self, node: Node):
        # With the head being the most recently used, we insert at the head,
        # remove from the tail

        # temporarily track the current head, which will be moved into "2nd" place
        tmp = self.head.next

        # update the new node to be at the head
        self.head.next = node

        # update the new nodes prev to point to "2nd" nodes prev
        node.prev = tmp.prev
        
        # update the new nodes next to point to the node it pushed down
        node.next = tmp

        # update the "2nd" place node's prev to point back to the new node
        tmp.prev = node


    def remove(self, node: Node):
        # Get the pointers of the Nodes going into and out of the node we are removing
        prev = node.prev
        next = node.next

        # Update those to connect to each other effectively removing the node
        prev.next = next
        next.prev = prev

    def get(self, key: int) -> int:
        if key in self.cache:
            self.remove(self.cache[key])
            self.insert(self.cache[key])
            return self.cache[key].val

        return -1
        

    def put(self, key: int, value: int) -> None:
        if key in self.cache:
            self.remove(self.cache[key])
        
        self.cache[key] = Node(key, value)
        self.insert(self.cache[key])

        if len(self.cache) > self.cap:
            lru = self.tail.prev
            self.remove(lru)
            del self.cache[lru.key]
            




        
