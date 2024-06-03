# GraphQL API with Hot Chocolate

This repository contains a GraphQL API built with Hot Chocolate in .NET.

## Setup 

### Cloning the Repository
```bash
git clone https://github.com/kooogi/GraphQL.git
```

### Using Codespaces
1. Open the repository in a Codespace.
2. Once the Codespace is ready, open the terminal.
3. Build the project.
```bash
dotnet build
```
4. Run the project:
```bash
dotnet run --project "GraphQL/GraphQL.csproj"
```

You can access the GraphiQL interface in your browser by navigating to `http://localhost:5048/graphql/`.

## Task 1: Implement a Query to Retrieve All Authors

**Description:**
Implement a function named `getAllAuthors` in the `Query` class (`Query.cs`) that retrieves all authors from the repository (`IRepository`). Write a GraphQL query that will retrieve this information.

**Steps:**
1. Open the `Query.cs` file in your project.
2. Implement a method named `getAllAuthors` that fetches all authors from the repository.
3. Write a GraphQL query that calls the `getAllAuthors` function to retrieve all authors.
4. Test the implemented function and query in the GraphiQL interface.

## Task 2: Implement a Query to Retrieve a Book by ID

**Description:**
Implement a function named `getBookById` in the `Query` class (`Query.cs`) that retrieves a book from the repository (`IRepository`) by its ID. Write a GraphQL query that will retrieve a book using this function.

**Steps:**
1. Open the `Query.cs` file in your project.
2. Implement a method named `getBookById` that fetches a book from the repository based on the provided ID.
3. Write a GraphQL query that calls the `getBookById` function with a specific book ID to retrieve the book.
4. Test the implemented function and query in the GraphiQL interface.

## Task 3: Implement a Mutation to Add a New Author

**Description:**
Implement a mutation named `addAuthor` in the `Mutation` class (`Mutation.cs`) that adds a new author to the repository (`IRepository`). The mutation should accept inputs for the author's name and bio. Write a GraphQL mutation to execute this operation.

**Steps:**
1. Uncomment the `//.AddMutationType<Mutation>()` line in the `Program.cs` file.
2. Open the `Mutation.cs` file in your project.
3. Create a DTO (Data Transfer Object) class named `AddAuthorInput` to represent the input for adding a new author. This class should contain properties for the author's name and bio.
4. Implement a method named `addAuthor` that adds a new author to the repository with the provided name and bio. Use the `AddAuthorInput` class as the argument type for this method.
5. Write a GraphQL mutation that calls the `addAuthor` function with inputs for the new author's name and bio.
6. Test the implemented mutation in the GraphiQL interface.
