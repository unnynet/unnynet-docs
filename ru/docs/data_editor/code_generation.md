# Генерация кода

## Зачем?
Хороший вопрос, ведь многие разработчики часто переписывают такие вещи в каждом проекте снова и снова.

Вот несколько причин вам на подумать:

1. Зачем тратить своё драгоценное время на такую монотонную работу? Подобные вещи лучше автоматизировать.
2. Исключены человеческие ошибки. Геймдизайнер или программист могут неправильно написал слово, как следствие, парсер отработает не так как ожидается. На обнаружение такой проблемы может уйти уйма времени.
3. Каждый раз, когда разработчик игры изменяет параметр или шаблон, всё это сразу же отражается в коде после генерации. Программист не забудет применить эти изменения.
4. Генерация кода тесно связана с другими полезными функциями Balancy, такими как: [Локализация](/data_editor/advanced/localization/). Их совместное использование даёт вашей команде огромный импульс.
5. Вы можете забыть про JSON'ы и о том, как с ними работать. Balancy сделает это за вас, чтобы вы могли работать только с удобными классами.
6. Когда документ ссылается на другой документ, разработчики обычно используют какой-то идентификатор для создания этих ссылок. Balancy сделает это за вас, автоматически обработает все ссылки и предоставит прямой доступ к необходимым документам.

## Как сгенерировать код
1. В Unity выберите Tools->Balancy, введите свои GameId/PublicKey и запустите генерацию кода.
2. Это может занять некоторое время в зависимости от вашего подключения и количества имеющихся у вас шаблонов.
3. Сгенерированные классы будут помещены в Assets/Balancy/AutoGeneratedCode.
4. **Ничего не меняйте в этой папке**, потому что ваши изменения будут перезаписаны при следующей генерации.


## Как это работает под капотом?
Сервер Balancy генерирует JSON файлы на основе ваших документов и помещает их в CDN. Плагин Balancy автоматически проверяет наличие обновлений этих файлов и загружает только обновлённые. После этого он мапит данные из JSON'ов на сгенерированные классы и находит все зависимости. Программисту не нужно скачивать, анализировать или понимать какой-либо из JSON'ов. Также нет необходимости искать какие-либо ссылки, если какой-либо из документов ссылается на другой — ссылка будет автоматически подставлена, и вы получите прямой доступ к ожидаемым документам.

## Как получить доступ к документам
1. Допустим, у вас есть шаблон **ItemModel** и несколько документов этого шаблона. Используйте **Balancy.DataEditor.ItemModels** для доступа к списку этих документов.
2. Если у вас есть шаблон **RecipeModel**, у которого есть элемент параметров типа **ItemModel**, то как только вы получите экземпляр этого RecipeModel в переменную, скажем, **recipeModel**, вы сможете получить доступ к его Item как **recipeModel.Item**. Всё очень просто!
3. Если ваш шаблон **GameConfig** является синглтоном, вы можете получить к нему доступ, написав **Balancy.DataEditor.GameConfig**.

## Как работать со сгенерированным кодом

У каждого разработчика свой стиль, и вам решать, как работать с игровыми данными. Ниже мы просто приведём несколько примеров:

### 1. [Метод расширения](https://ru.wikipedia.org/wiki/%D0%9C%D0%B5%D1%82%D0%BE%D0%B4_%D1%80%D0%B0%D1%81%D1%88%D0%B8%D1%80%D0%B5%D0%BD%D0%B8%D1%8F)

Допустим, у вас есть сгенерированный код для предметов:

```csharp fct_label="Unity"
public class ItemModel : BaseModel
{
    public string Name;
    public string Description;
    public string IconName;
    public string AssetName;
    public int MaxStack;
}
```

Если вы хотите добавить проверку, допустимо ли складывать предмет в инвентарь, можно записать в отдельный файл:

```csharp fct_label="Unity"
public static class ItemModelExtension
{
    public static bool CanStack(this ItemModel item)
    {
        return item.MaxStack > 1;
    }
}
```

Позже, если у вас есть экземпляр **ItemModel** в переменной, скажем, **item**, вы можете просто вызвать новый метод:

```csharp fct_label="Unity"
item.CanStack();
```

### 2. [Шаблон фасад](https://ru.wikipedia.org/wiki/%D0%A4%D0%B0%D1%81%D0%B0%D0%B4_(%D1%88%D0%B0%D0%B1%D0%BB%D0%BE%D0%BD_%D0%BF%D1%80%D0%BE%D0%B5%D0%BA%D1%82%D0%B8%D1%80%D0%BE%D0%B2%D0%B0%D0%BD%D0%B8%D1%8F))

Допустим, у вас есть сгенерированный код для инвентаря:

```csharp fct_label="Unity"
public class Inventory : BaseData
{
    public SmartList<ItemSlot> ItemSlots;
}
```

Сначала вы создаёте новый класс с именем InventoryController, в котором есть свойство Inventory. Вместо того, чтобы работать напрямую с Inventory, ваша игра имеет доступ только к InventoryController.
Для проверки на то, есть ли пустые слоты, можно написать проверку:

```csharp fct_label="Unity"
public class InventoryController
{
    public Inventory Inventory;
    
    public bool HasEmptySlot() {
        foreach (var slot in Inventory.ItemSlots)
        {
            if (slot.IsEmpty())
                return true;
        }
        return false;
    }
}
```

Это всего лишь простой пример. Сама эта логика может быть легко переписана с использованием первого подхода (методом расширения), который был бы рекомендован ранее.

### 3. [Разделяемые классы](https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods)

###### Эта функция временно отключена.

Если вы активируете чекбокс для вашего шаблона в DE, сгенерированный класс будет отмечен как разделяемый. Это означает, что вы сможете добавить столько методов и свойств для этого класса в отдельном файл, сколько захотите.

###### Рекомендации:
Первый подход намного лучше. Он определённо подходит для всех простых шаблонов (которые не имеют ссылок в качестве параметров).
Для более сложных шаблонов следует использовать комбинации первого и второго подходов.
Последний подход с использованием разделяемых классов может выглядеть привлекательно, но его не рекомендуется использовать. Многим разработчикам эта функция не нравится по многим причинам. То же самое можно реализовать, используя первый или второй подход.

Конечно, есть много других способов реализовать такую логику. Мы были бы рады услышать о ваших подходах, если они отличаются от приведённых выше.

#### [Далее: пример](/data_editor/example)
