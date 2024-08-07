Here is a Python console application that implements a stack with constant time operations for getMin, getMax, push, and pop.

```python
class Stack:
    def __init__(self):
        self.stack = []
        self.min_stack = []
        self.max_stack = []

    def push(self, x):
        self.stack.append(x)
        if not self.min_stack or x <= self.min_stack[-1]:
            self.min_stack.append(x)
        if not self.max_stack or x >= self.max_stack[-1]:
            self.max_stack.append(x)

    def pop(self):
        if self.stack:
            x = self.stack.pop()
            if x == self.min_stack[-1]:
                self.min_stack.pop()
            if x == self.max_stack[-1]:
                self.max_stack.pop()
            return x
        else:
            return None

    def getMin(self):
        return self.min_stack[-1] if self.min_stack else None

    def getMax(self):
        return self.max_stack[-1] if self.max_stack else None


if __name__ == "__main__":
    stack = Stack()
    while True:
        print("\n1. Push")
        print("2. Pop")
        print("3. Get Minimum")
        print("4. Get Maximum")
        print("5. Quit")
        choice = int(input("Enter your choice: "))
        if choice == 1:
            x = int(input("Enter the value to be pushed: "))
            stack.push(x)
        elif choice == 2:
            x = stack.pop()
            if x is None:
                print("Stack is empty.")
            else:
                print("Popped value: ", x)
        elif choice == 3:
            x = stack.getMin()
            if x is None:
                print("Stack is empty.")
            else:
                print("Minimum value: ", x)
        elif choice == 4:
            x = stack.getMax()
            if x is None:
                print("Stack is empty.")
            else:
                print("Maximum value: ", x)
        elif choice == 5:
            break
```

This console application provides a menu to the user to perform operations on the stack. The user can push an element to the stack, pop an element from the stack, get the minimum element from the stack, get the maximum element from the stack, or quit the application. The operations push, pop, getMin, and getMax are all performed in constant time.