# Documents & Components


### Documents

Document is a unique instance of a Template (Specific Item: Hunter's Bow, Gold Bar,...), which has it's own parameter values. Think of it as an **instance** of a **Class** as a programmer.

When you add a new Template (Not Component), a new section in the left navigation appears. If you select any of the Document section, you'll be able to add new Documents in there. Each document can have a unique values for all the parameters of it's Template.  


### Components

Component is a simple Template, which doesn't have it's own Documents and can exists only inside of another Document.

For example Vector3 component template has parameters: x, y, z. If a Document "Hero" has a Parameter "position" of type Vector3, you'll be able to edit x, y, z values of "position" right inside of "Hero" Document.  

#### [Next: Code Generation](/data_editor/code_generation)
