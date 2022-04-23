# Smart Search

Current version of search works only for the simple type parameters. Type a string in the search field and press **Enter** to start the search. Clear the search field to reset the search results.
If your string contains any special symbols or starts with a number, you need to use quotes, like this **'22 is special string'**.

### Available operators

1.  For numeric columns you can use operators **>, >=, <, <=, ==, !=**. For example **MaxStack >= 10** - it'll select only document, which parameter **MaxStack** value is greater or equal **10**.
2.  **\<string\> contains \<substring\>** or **\<string\> includes \<substring\> or **\<substring\> in \<string\>** can be used to check if the \<string\> contains the \<substring\>. You can use here any string parameters or constant values.
3.  **&&** - And operator. For example **Level >= 10 && Level <= 20**.
4.  **||** - Or operator. For example **Level < 10 || Level > 20**.
5.  **!** - Not operator. For example **!(level>=10)**. *!* can also be used to find all documents, which don't have the string value in a specific parameter. Lets say you have a parameter **Description**, this is how you can find all documents, which are missing the description - **!Description**. If you want to filter only document, which have description, type this - **!!Description**.
6.  **\<string\> startsWith \<prefix\>** - checks if the \<string\> starts with \<prefix\>.
7.  **\<string\> endsWith \<suffix\>** - checks if the \<string\> ends with \<suffix\>.
7.  You can use brackets to make complex search filter. For example: **Level >= 10 && (Name contains Weapon || Name contains Tool)**
