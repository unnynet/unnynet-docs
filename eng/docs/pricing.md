# Pricing

Balancy is a SaaS with monthly payments. We are tying to keep our pricing as low as possible without any quality loss. Currently we accept PayPal payments, but we can discuss other options if necessary.

We charge per Game Title and each game have it's own payment deadline, depending on it's creation date.

|       | Free            | Plus            | Pro            | Enterprise       |
| :---------- | :-------------- |:-------------- |:-------------- |:-------------- |
| `Montly Payment`       | 0$ | $15 per seat / game / month | $40 per seat / game / month | $XX |
| `Seats`    | 1 | 1-3 | 4-10 | 10+ |
| `Documents*`    | 1000 | 5000 | 20000 | Unlimited |
| `CDN Included`    | 2Gb | 10Gb | 100Gb | 1000Gb |
| `History (soon)`    | - | + | + | + |
| `Branches (soon)`    | - | - | + | + |
| `A/B Testing (soon)`    | - | - | + | + |

*Documents - Components are also included here.

### Pay as you go

Besides of the flat fee we charge additionally for the bandwidth usage.

* $0.2 per additional Gb

All the game balance is split into many json files (one for each Template) and the data is being delivered to your clients when they launch your game. If your make any changes in the balance, only the changed Json files will be delivered. The size of each file multiplied by the time it was downloaded from our servers is the bandwidth we charge for. This fee is not something your should worry about, we just added it to make sure our business is profitable for any kind of games we serve. 


### Smart Offers

$10 per 1 Million API Calls.

What generates API Call:

* GameEvent Starts/Ends
* GameOffer Starts/Ends
* VisualScripting each executed node Enter/Exit

##### What to expect:

* You have a mid-core game with DAU = 30k. 
* Your ARPDAU should be at least $0.05.
* Thus you make around $1.5k/day or $45k/month.
* Your game have 10 unique GameOffers, each of them triggers 30 API Call for one user. 
* This make total of 300 API Calls per user for the perfect game with 100% retention.
* Most of your players will churn and won't see all the offers, so you should expect to have on average 60 API Calls per user.
* Taking into account your DAU your game will generate around 2 Millions API Calls a day.
* You pay us $20/day, but your revenue grows to $3k a day.
