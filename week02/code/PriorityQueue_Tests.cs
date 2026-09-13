using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add several items to the queue.
    // Expected Result: Items are added to the back of the queue in FIFO order.
    // Defect(s) Found: None. 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add items with different priorities and remove an item.
    // Expected Result: The item with the highest priority is removed first.
    // Defect(s) Found: The original code did not remove the item from the queue
    // after returning its value. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual(
            "[A (Pri:1), C (Pri:3)]",
            priorityQueue.ToString());
        
        
    }

    // Add more test cases as needed below.

    [TestMethod]
    // Scenario: Add multiple items with the same highest priority.
    // Expected Result: The item closest to the front is removed first.
    // Defect(s) Found: The original code used >=, causing the later item
    // with the same priority to be selected instead of following FIFO.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Try to remove an item from an empty queue.
    // Expected Result: An InvalidOperationException is thrown with the
    // message "The queue is empty."
    // Defect(s) Found: None.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(
            () => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }


    
}