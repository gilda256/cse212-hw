public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
{
    // 1. Create an array with enough space for all multiples.
    var multiples = new double[length];

    // 2. Repeat for each multiple.
    for (var i = 0; i < length; i++)
    {
        // 3. Calculate the next multiple and store it in the array.
        multiples[i] = number * (i + 1);
    }

    // 4. Return the completed array.
    return multiples;
}

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
{
    // Plan:
    // 1. Find the index where the list should be split.
    //    The last 'amount' items must move to the beginning.
    // 2. Save the last 'amount' items in a temporary list.
    // 3. Save the first part of the list in another temporary list.
    // 4. Clear the original list.
    // 5. Add the last part first.
    // 6. Add the first part after it.
    // The original data list is now rotated to the right.

    // Step 1: Find the split index.
    var splitIndex = data.Count - amount;

    // Step 2: Save the last 'amount' items.
    var lastPart = data.GetRange(splitIndex, amount);

    // Step 3: Save the first part of the list.
    var firstPart = data.GetRange(0, splitIndex);

    // Step 4: Clear the original list.
    data.Clear();

    // Step 5: Add the last part to the beginning.
    data.AddRange(lastPart);

    // Step 6: Add the first part after it.
    data.AddRange(firstPart);
}
}