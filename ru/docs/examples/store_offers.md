# Пример с оферами в магазине

![Screenshot](../../img/example_store_offers2.png) 

### Описание

В этой демке показано, как создать внутриигровой магазин для покупки предметов. Для управления всеми данными используется Balancy. В магазине есть не только обычные оферы, но и оферы с условиями появления/доступности. Такие предложения доступны игрокам только после выполнения определённых условий.

Есть 2 типа условий:

1. Достигнуть определённого уровня.
2. Совершить N покупок.

Вы можете использовать сколько угодно дополнительных условий.

### С чего начать

1. Склонировать [гит репозиторий](https://github.com/pavelbalancy/Example-Store)
2. Открыть проект в Unity
3. Запустить сцену Assets/StoreDemo/Scenes/SampleScene.unity
4. Нажать Play
5. Нажать на "offers" для приобретения товара. Обратите внимание, что как только вы сделаете 5 покупок, появятся новые предложения.

### Заведите свой баланс

1. Откройте [Dashboard](https://balancy.dev/dashboard) в Balancy.
2. Нажмите на кнопку Examples.
3. Найдите демку **Store Offers**.
4. Нажмите Clone и подтвердите.

Вы получите собственную версию демки Store Offers в Balancy.
Следуйте нашей документации и замените GameId в Unity проекте из нашего проекта на свой, из только что созданного проекта.


### Краткое описание настройки Balancy для оферов

1. **Item Model** — шаблон для элементов. В моём примере я определил драгоценные камни и золото как предметы.
2. Все предметы, включая ресурсы записаны в Inventories. Таким образом у нас есть **Inventory Config**. Про Inventory мы поговорим в следующем демо-проекте.
3. **Store Offer** является основным шаблоном для этого проекта.

     ![Screenshot](../../img/example_store_offers.png) 

4. Первый параметр — **Icon**. Это изображение, используемое в игровом магазине. Мы синхронизировали Addressables из Unity с Balancy для удобства. Вы можете узнать, как это работает [здесь](/data_editor/advanced/assets). 
5. **Conditions** являются самой сложной частью и будут объяснены в следующем разделе.
6. **Items** — список товаров, которые вы получите при покупке. Я использую здесь компонент **ItemWithAmount**. Вы можете найти его в списке шаблонов.
7. **Price** — предметы, которые будут списаны при покупке.
8. Есть и другие параметры, которые вы можете проверить самостоятельно.
 
 
### Условия

Условия часто используются для скрытия части контента игры до определённого момента.

**Условием** может быть что угодно:

* уровень игрока;
* поиск определённого предмета;
* убийство определённого числа противников;
* и т. д.

Логику условий вам необходимо реализовать только один раз в Balancy и в своём коде, и после этого вы сможете использовать её везде: туториалы, квесты, диалоги... Я использую их для оферов в магазине.

* Чтобы увидеть оферы с идентификаторами **53** и **56**, игрок должен совершить 5 покупок.
* Для офера с Id **50** игрок должен иметь уровень не ниже 5 и совершить 10 покупок.

Вы можете увидеть эту информацию в моей таблице выше (см. скриншот).
**ConditionChecker.cs** — класс, который работает с этими условиями. Вы должны проверить его реализацию. Если решите добавить какие-либо новые типы условий, вам нужно будет вносить изменения только в нём. 