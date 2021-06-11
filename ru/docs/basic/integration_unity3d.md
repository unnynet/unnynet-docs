# Интеграция с Unity3D

Для удобства мы записали [отдельное видео об интеграции](https://youtu.be/91JYYb1KVIY)

1.  Скачайте последнюю версию из [Магазина ассетов](https://assetstore.unity.com/packages/slug/128920).
2.  Импортируйте Balancy плагин.
3.  Подготовьте Game ID и Public Key для использования в коде:

    ![Screenshot](../img/game_id.jpg)

4.  Call initialize method at start:
        
```csharp fct_label="Unity"
Balancy.Main.Init(new Balancy.AppConfig {
    ApiGameId = YOUR_GAME_ID,
    PublicKey = YOUR_PUBLIC_KEY,
    Environment = Balancy.Constants.Environment.Development,
    OnReadyCallback = responseData => { Debug.Log("Balancy Initialized: " + responseData.Success); }
});
```

### Что дальше

Для удобства Balancy разбит из нескольких модулей.

1. [**Auth**](/basic/authorization) — различные способы авторизации.
2. [**Data Editor**](/data_editor/basic) — место для работы Data Editor'ом.
3. [**Storage**](/basic/storage) — обмен игровыми данными игрока с сервером.
4. [**Payments**](/basic/payments) — работа с внутриигровыми покупками.
5. **Localization** — (будет в будущем) возможность настроить локализацию игры.
