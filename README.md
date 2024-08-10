# Question: How do you design a stack that supports getMin, getMax, push, and pop in constant time? C# Summary

The C# program implements a stack data structure that supports the operations push, pop, getMin, and getMax in constant time. It achieves this by maintaining three separate stacks: a main stack for storing the actual elements, and two auxiliary stacks for tracking the minimum and maximum elements in the main stack. When a new element is pushed onto the main stack, it is also pushed onto the minStack or maxStack if it is smaller or larger than the current minimum or maximum, respectively. When an element is popped from the main stack, it is also popped from the minStack or maxStack if it is equal to the current minimum or maximum. This ensures that the minimum and maximum elements can always be retrieved in constant time by simply peeking at the top of the minStack or maxStack. If any operation is attempted on an empty stack, an exception is thrown. The main method demonstrates the usage of the stack and its operations.

---

# Python Differences

The Python version of the solution uses the same logic as the C# version. Both versions use three stacks: a main stack to store the elements, and two auxiliary stacks to keep track of the minimum and maximum elements. The minimum and maximum elements are updated in constant time whenever an element is pushed or popped from the stack.

However, there are some differences in the language features and methods used in the two versions:

1. In Python, lists are used to implement the stacks, while in C#, the Stack class from the System.Collections.Generic namespace is used.

2. The push operation in Python is implemented using the append method of the list, while in C#, the Push method of the Stack class is used.

3. The pop operation in Python is implemented using the pop method of the list, while in C#, the Pop method of the Stack class is used.

4. To get the top element of the stack (without removing it), Python uses list indexing with -1, while C# uses the Peek method of the Stack class.

5. Python uses the built-in len function to check if the stack is empty, while C# uses the Count property of the Stack class.

6. The Python version includes a user interface that allows the user to interact with the stack, while the C# version does not.

7. Error handling is done differently in the two versions. In the C# version, an exception is thrown when trying to pop from or get the minimum/maximum of an empty stack. In the Python version, None is returned in these cases.

---

# Java Differences

The Java version of the solution is very similar to the C# version. Both versions use three stacks to keep track of the main elements, the minimum elements, and the maximum elements. The push, pop, getMin, and getMax operations are implemented in the same way in both versions.

There are a few differences between the two versions due to the differences between the Java and C# languages:

1. In the C# version, the `Count` property is used to check if a stack is empty, while in the Java version, the `isEmpty` method is used.

2. In the C# version, an `InvalidOperationException` is thrown when trying to pop an element from an empty stack or get the minimum/maximum element from an empty stack. In the Java version, the `pop` method simply returns without doing anything when the stack is empty, and the `getMin` and `getMax` methods will throw an `EmptyStackException` if the stack is empty.

3. The C# version includes a `Main` method in a `Program` class that tests the `StackWithMinMax` class, while the Java version includes a `main` method in the `MinMaxStack` class itself that tests the class.

4. The C# version uses `Console.WriteLine` to print the results, while the Java version uses `System.out.println`.

5. The C# version uses the `int` keyword for integer data type while the Java version uses `Integer` class. This is because in Java, `Stack` is a generic class and does not accept primitive types like `int`. 

Overall, the differences between the two versions are minor and mostly due to the differences between the Java and C# languages. The core logic of the solution is the same in both versions.

---
