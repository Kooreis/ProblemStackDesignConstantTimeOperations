Here is a Java console application that implements a stack with getMin, getMax, push, and pop operations in constant time.

```java
import java.util.Stack;

public class MinMaxStack {
    private Stack<Integer> stack = new Stack<>();
    private Stack<Integer> minStack = new Stack<>();
    private Stack<Integer> maxStack = new Stack<>();

    public void push(int x) {
        stack.push(x);
        if (minStack.isEmpty() || x <= minStack.peek()) {
            minStack.push(x);
        }
        if (maxStack.isEmpty() || x >= maxStack.peek()) {
            maxStack.push(x);
        }
    }

    public void pop() {
        if (stack.isEmpty()) {
            return;
        }
        int removed = stack.pop();
        if (minStack.peek() == removed) {
            minStack.pop();
        }
        if (maxStack.peek() == removed) {
            maxStack.pop();
        }
    }

    public int top() {
        return stack.peek();
    }

    public int getMin() {
        return minStack.peek();
    }

    public int getMax() {
        return maxStack.peek();
    }

    public static void main(String[] args) {
        MinMaxStack minMaxStack = new MinMaxStack();
        minMaxStack.push(5);
        minMaxStack.push(1);
        minMaxStack.push(10);
        System.out.println(minMaxStack.getMin()); // prints 1
        System.out.println(minMaxStack.getMax()); // prints 10
        minMaxStack.pop();
        System.out.println(minMaxStack.getMin()); // prints 1
        System.out.println(minMaxStack.getMax()); // prints 5
    }
}
```

This program uses three stacks: one for storing the actual elements (`stack`), one for keeping track of the minimum element (`minStack`), and one for keeping track of the maximum element (`maxStack`). The `push` operation pushes the element to `stack` and also updates `minStack` and `maxStack` if necessary. The `pop` operation pops the element from `stack` and also updates `minStack` and `maxStack` if necessary. The `getMin` and `getMax` operations simply return the top element of `minStack` and `maxStack`, respectively.