# Templates

**Template** describes the structure and behaviour of your game object (item, monster, construction,...). As a programmer you can think of it as a **Class**. Template has to have a unique name and may contains a set of parameters.

1.  Open **Data Structure** section, you'll land on **Templates** subsection by default. Click on the **Create** Button
![Screenshot](../../img/de_example/de_create_template.jpg)
    
2.  Each Template has several parameters
    
    Name | Description
    -----|------------
    **Name** | This very name is used for Class generation. To keep everything in style we advise you to use [CamelCase](https://simple.wikipedia.org/wiki/CamelCase) naming.<br/><br/> For example: ItemModel, GameConstruction, MonsterData,...
    **Display Name** | The name which will be displayed in the DE. Usually it's the same as name, but words are separated.<br/><br/> For example: Item Model, Game Construction, Monster Data,...
    **Description** | Helps other team members to easily understand what this Template is used for.
    **Base Template** | It's used if your Template inherits from another one.
    **Type** | Can be Document, Component or Singleton:<br/><br/>  *   **Component** Documents of this Template are always embedded into another Documents. For example Vector3 component template has parameters: x, y, z. If a Document "Hero" has a Parameter "position" of type Vector3, you'll be able to edit x, y, z values of "position" right inside of "Hero" Document.<br/><br/> *   **Singleton** Only one of such Documents will be available from the code. It's usually used for settings and configs.  

#### [Next: Parameters](/data_editor/getting_started/parameters)
