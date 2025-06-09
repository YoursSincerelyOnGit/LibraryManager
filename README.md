

**Design Choices**: I chose a `List<LibraryItem>` as the collection, inspired by the course material’s emphasis on generic `List<T>` for type safety and performance over `ArrayList`. The base class `LibraryItem` holds common properties—ID, Title, and YearPublished—while derived classes Book, Magazine, and DVD add specific attributes like Author, IssueNumber, and Director. This inheritance structure promotes code reuse and extensibility. Properties use standard types: `int` for IDs and years, `string` for titles and names, ensuring simplicity.

**Process**: I started by defining the class hierarchy, then implemented a console menu for user interaction—add, remove, search, and display items. The `List<T>` methods like `Add`, `RemoveAll`, and LINQ’s `FirstOrDefault` enabled efficient operations, as demonstrated in the course examples. I validated inputs using `int.TryParse` and checked for unique IDs to prevent duplicates.

**Error Handling**: Robust error handling was critical. I used `try-catch` blocks to catch exceptions, `ArgumentException` for invalid inputs like negative IDs or empty titles, and provided clear user feedback. For example, attempting to remove a non-existent item displays “Item not found.” This ensures the program is user-friendly and resilient.

**Conclusion**: The solution is modular, scalable, and aligns with C# best practices. The use of generics and LINQ streamlined operations, and thorough error handling enhanced reliability. Thank you!
