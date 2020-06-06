# Content Management System

How Does it Work?

1. After [adding your game](/basic/basic) to the platform, you get an access to the CMS. 
2. Inside of CMS you can add all types of objects your game has: weapon, item, construction, monster, hero, location, etc...
3. For each type of object you can add as many documents as possible. Each document represents a unique weapon, item, construction, etc...
4. Open Unity with your project and start code generation request. UnnyNet will automatically generate code based on the data you provided.
5. Once the game is launched, all the game data is delivered to the game and already mapped to the generated code.
6. Your programmer has a direct access to all the items, weapons and other objects your game has. He doesn't have to write any code for downloading or parsing.
7. Whenever you change the game data in CSM, it'll be automatically synchronized with the game after the restart. 





For example Vector3 template, has parameters: x, y, z. If a Document "Hero" has a Parameter "position" of Vector3, you'll be able to edit x, y, z values of "position" right inside of "Hero" Document. 
