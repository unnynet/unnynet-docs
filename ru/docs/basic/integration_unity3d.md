# Интеграция с Unity3D

Для удобства мы записали [отдельное видео об интеграции](https://www.youtube.com/watch?v=4efFdjhyePg&list=PLHHFKd2iPYt7x7OGKsd0VLzJ1c0Vi4wmn)

1.  Скачайте последнюю версию из [Магазина ассетов](https://assetstore.unity.com/packages/slug/128920).
2.  Или воспользуйтесь прямой ссылкой на [package](https://dictionaries-unnynet.fra1.cdn.digitaloceanspaces.com/config/Packages/balancy_latest.unitypackage).
3.  Импортируйте Balancy плагин.
4.  Подготовьте Game ID и Public Key для использования в коде:

    ![Screenshot](../img/game_id.jpg)

5.  Call initialize method at start:
        
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

1. [**Data Editor**](/data_editor/basic) — место для работы с игровым балансом
2. [**Auth**](/basic/authorization) — различные способы авторизации.
3. [**Payments**](/basic/payments) — работа с внутриигровыми покупками.
4. **Localization** — (будет в будущем) возможность настроить локализацию игры.
