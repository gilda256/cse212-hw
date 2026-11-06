using Microsoft.VisualStudio.TestTools.UnitTesting;


// TODO Problem 2 - Write and run test cases and fix the code to match requirements.


[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue items with different priorities, then dequeue them
    // Expected Result: Items come out in order of highest priority; ties follow FIFO
    // Defect(s) Found:1. The loop skipped the last element because it used index < Count - 1.
    // 2. Using >= broke FIFO tie-breaking, so the later item with the same priority was chosen.
   // 3. Dequeue returned the value but did not remove the item from the queue.
   // After fixing all three issues, the test passed.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        // Arrange
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);
        priorityQueue.Enqueue("D", 3);

        // Act & Assert
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("D", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
        Assert.AreEqual("A", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty queue
    // Expected Result: InvalidOperationException with message "The queue is empty."
    // Defect(s) Found: No defect found. 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        // Act & Assert
        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", exception.Message);
    }

    // Add more test cases as needed below.
}