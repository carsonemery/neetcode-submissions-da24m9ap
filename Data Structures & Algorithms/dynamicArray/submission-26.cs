public class DynamicArray {
    private int capacity;
    private int[] array;
    private int count = 0;


    public DynamicArray(int capacity) {
        if (capacity > 0) {
            array = new int[capacity];
            this.capacity = capacity;
        }
    }

    public int Get(int i) {
        int Element = array[i];
        return Element;
    }

    public void Set(int i, int n) {
        array[i] = n;
    }

    public void PushBack(int n) {
        // if no space 
        if (count == capacity) {
            // call resize
            Resize();
        }
        // place the element n at the end of the capacity using GetSize+1 index?
        array[count] = n;
        count++;
    }

    public int PopBack() {
        
        int lastElement = array[count - 1];
        this.count--;
        return lastElement;
        
    }

    private void Resize() {
        int[] ArrayCopy = new int[this.capacity * 2];
        
        for (int i = 0; i < count; i++) {
            ArrayCopy[i] = array[i];
        }

        this.array = ArrayCopy;
        this.capacity = this.capacity * 2;
    }

    public int GetSize() {
        return this.count;
    }

    public int GetCapacity() {
        return this.capacity;
    }
}
