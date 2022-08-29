**What is does**
<br/>This code will parse a json and will return the arguments into the local action

**How to do it**
1. Import the code into your Streamer.bot (this is needed only once)
2. Find Refs
3. Compile
4. Save

Create an action and add the following subaction
1. Set your json string into an argument called "json". If using the "Fetch Url" sub-action then set the "Variable Name" to "json" (without quotes)
2. (optional) Set the prefix for the parsed arguments by setting the "parsePrefix" argument. If "parsePrefix" is missing then the default prefix will be "parse"
3. Execute the code

**IMPORT CODE TO Streamer.bot**
```
TlM0RR+LCAAAAAAABAB9VtuSokgQfd+I/Qein9deRLGHidgHwRbBHqcVAXXtB+oi1FhchoK26Yn5960Csb3MrBEEmCfrZObJxPTHn39I0t0rzhlJk7vPkvJXbUiCGPNvd47eeQ5yhm3G0QYKYMFdGUf/Fd8l6Udz4xBB4swOQKjIPbmzewBapw8D2Pmk7AadQIXdbld9GChar+GqD30vcSliJSWlH1acBIBiwVfkJT6zv0FaIjzO03hCWJHmFXfZBZSd+bTJ15lLtvN1dhYuzNMyE+gyTSk7AwJ6CCq2KJNbwjxIUBoP68JvUZgmsMxznBS32I1YF4L9KtuT0CcHhBnMSXYM3vixuiyJFTlJQomnJ+W4KPOESUWEpSAPy5jnwySSFKnEStDkcUW8xzgbUvKKb/JuqsY7zKuC+Cr9GjQ+b7c+4bIc2Hb7hcA8ZemuuJ89Lrfbcc5LOqT5ftDfbl/79/J9T+51te02ZjDNKQH3iNK7c8KXy8igKrCRoloWtJplIIah26PvyPSKpz19/nqQp619GXs9ZGolVLQYGeqU30uBj+bZAfk2C/wv4Vp5i2DvSzjv6pbjq9ymUo4/jOZpaBnDEE48Akz6zTLtV6AcwsUqouueJ2+cMGt9cM2Z2sZqJsOYlptK/y5iWSM5XK/sBFbqCCiqvPZpCeWCYickQTJ7BcTKrNGnxqfLjjYbPdHFq9tbVDyXZGrsS29iZ4DHs0Y8HrFCUYMx5zULO68TTmy6iWn//+JBc1xBxZvD2IuDVUimzvBvi9s2vRmwEj2CyYy6LQ+VS8/Ulkf+lPsOLMM+cO73jdPEr+v1aWwZUVurZhkWmc7r3B5qfE5H7mNYLk0t4drGoAqJQ2fPS6JnsNLHS093fUdowGZGuOf62RRNvAoQPV77bzzWsOFZyRyveU98C9MjyIdpo9m+zanuR309Zu9cA3ezimQ39qKN6VUWr2/tLygkQ80yVYoqvZ4Jz/T6aNxiUblZiZlq9G/PTk3B18+mS54rGZ7iICXKgOmG0xO36mz88Z73LbvIZ9LWeJqR+Xq1SEXP4DHGE9UjZIYlj3kA5vgbnzHiVxardXU470pna39Gp4aNLHIQs3Cm3YlXhzHqAt8r0aMaAd8Nnx39cOx7OK2G5InP0PQUn9XanvI8XoG/Pq/J5/3o8n5EnKtE/hsTfb4+g+u53LdzUQkdNitLzFK+8VUXr3R6NduhtZRDi+oV6OkUJgt1GY8LPmNZMz97+8T5i96f5t5gXIs+EXfXHMuBMcy5ZrzuIbfx55s69sd36IPXVTx5zt8d5HcpSObpx/Pi65rfnwz9o554zJDvfmg/p9pFr+tLF7aLWdnNr2Z0cpp3GSYeFTk1dj7vifzP1W9ylmOYxhmhv/lRRpgGlVME+e2yOVvBigIeAMaDjoYHg05/p/U6QAu6HbUPdrArq/JDv38V+IBJGAlS+V6+RIoqE8lo4nOJtLv0YnXXyG/Wd5NigvCbCPRh/dk+vlyvTlOEqBfQy/nGpTTIGEZnaAPWRI1n88fi7Cg/Fsd8Vbb+P/8DYkNbU/wIAAA=
```

**EXAMPLES**

json : 
```json
{"name": "brightsky", "version": "1.0.18", "status": "ok"}
```

Returned Arguments :
```EditorConfig
parse.name = brightsky
parse.version = 1.0.18
parse.status = ok
```
json :
```json
{"weather": {"source_id": 42212, "timestamp": "2022-08-29T19:00:00+00:00", "cloud_cover": 75, "condition": "dry", "dew_point": 12.28, "precipitation_10": 0.0, "precipitation_30": 0.0, "precipitation_60": 0.0, "pressure_msl": 1019.9, "relative_humidity": 72, "visibility": 52837, "wind_direction_10": 40, "wind_direction_30": 40, "wind_direction_60": 47, "wind_speed_10": 8.3, "wind_speed_30": 7.9, "wind_speed_60": 7.2, "wind_gust_direction_10": 40, "wind_gust_direction_30": 40, "wind_gust_direction_60": 40, "wind_gust_speed_10": 10.8, "wind_gust_speed_30": 10.8, "wind_gust_speed_60": 10.8, "sunshine_30": 0.0, "sunshine_60": 0.0, "temperature": 17.4, "fallback_source_ids": {"cloud_cover": 11689, "condition": 11689, "pressure_msl": 11689, "visibility": 11689, "wind_direction_10": 11689, "wind_direction_30": 11689, "wind_direction_60": 11689, "wind_speed_10": 11689, "wind_speed_30": 11689, "wind_speed_60": 11689, "wind_gust_direction_10": 11689, "wind_gust_direction_30": 11689, "wind_gust_direction_60": 11689, "wind_gust_speed_10": 11689, "wind_gust_speed_30": 11689, "wind_gust_speed_60": 11689, "sunshine_30": 11689, "sunshine_60": 11689}, "icon": "partly-cloudy-night"}, "sources": [{"id": 42212, "dwd_station_id": "13696", "observation_type": "synop", "lat": 51.5966, "lon": 7.40484, "height": 60.0, "station_name": "Waltrop-Abdinghof", "wmo_station_id": "H443", "first_record": "2022-08-28T12:30:00+00:00", "last_record": "2022-08-29T19:00:00+00:00", "distance": 2523.0}, {"id": 11689, "dwd_station_id": "01303", "observation_type": "synop", "lat": 51.4041, "lon": 6.96774, "height": 150.0, "station_name": "Essen-Bredeney", "wmo_station_id": "10410", "first_record": "2022-08-28T12:30:00+00:00", "last_record": "2022-08-29T19:00:00+00:00", "distance": 34639.0}]}
```
Returned Arguments :
```EditorConfig
parse.weather.source_id = 42212
parse.weather.timestamp = 29/8/2022 22:00:00
parse.weather.cloud_cover = 75
parse.weather.condition = dry
parse.weather.dew_point = 12,28
parse.weather.precipitation_10 = 0
parse.weather.precipitation_30 = 0
parse.weather.precipitation_60 = 0
parse.weather.pressure_msl = 1019,9
parse.weather.relative_humidity = 72
parse.weather.visibility = 52837
parse.weather.wind_direction_10 = 40
parse.weather.wind_direction_30 = 40
parse.weather.wind_direction_60 = 47
parse.weather.wind_speed_10 = 8,3
parse.weather.wind_speed_30 = 7,9
parse.weather.wind_speed_60 = 7,2
parse.weather.wind_gust_direction_10 = 40
parse.weather.wind_gust_direction_30 = 40
parse.weather.wind_gust_direction_60 = 40
parse.weather.wind_gust_speed_10 = 10,8
parse.weather.wind_gust_speed_30 = 10,8
parse.weather.wind_gust_speed_60 = 10,8
parse.weather.sunshine_30 = 0
parse.weather.sunshine_60 = 0
parse.weather.temperature = 17,4
parse.weather.fallback_source_ids.cloud_cover = 11689
parse.weather.fallback_source_ids.condition = 11689
parse.weather.fallback_source_ids.pressure_msl = 11689
parse.weather.fallback_source_ids.visibility = 11689
parse.weather.fallback_source_ids.wind_direction_10 = 11689
parse.weather.fallback_source_ids.wind_direction_30 = 11689
parse.weather.fallback_source_ids.wind_direction_60 = 11689
parse.weather.fallback_source_ids.wind_speed_10 = 11689
parse.weather.fallback_source_ids.wind_speed_30 = 11689
parse.weather.fallback_source_ids.wind_speed_60 = 11689
parse.weather.fallback_source_ids.wind_gust_direction_10 = 11689
parse.weather.fallback_source_ids.wind_gust_direction_30 = 11689
parse.weather.fallback_source_ids.wind_gust_direction_60 = 11689
parse.weather.fallback_source_ids.wind_gust_speed_10 = 11689
parse.weather.fallback_source_ids.wind_gust_speed_30 = 11689
parse.weather.fallback_source_ids.wind_gust_speed_60 = 11689
parse.weather.fallback_source_ids.sunshine_30 = 11689
parse.weather.fallback_source_ids.sunshine_60 = 11689
parse.weather.icon = partly-cloudy-night
parse.sources0.id = 42212
parse.sources0.dwd_station_id = 13696
parse.sources0.observation_type = synop
parse.sources0.lat = 51,5966
parse.sources0.lon = 7,40484
parse.sources0.height = 60
parse.sources0.station_name = Waltrop-Abdinghof
parse.sources0.wmo_station_id = H443
parse.sources0.first_record = 28/8/2022 15:30:00
parse.sources0.last_record = 29/8/2022 22:00:00
parse.sources0.distance = 2523
parse.sources1.id = 11689
parse.sources1.dwd_station_id = 01303
parse.sources1.observation_type = synop
parse.sources1.lat = 51,4041
parse.sources1.lon = 6,96774
parse.sources1.height = 150
parse.sources1.station_name = Essen-Bredeney
parse.sources1.wmo_station_id = 10410
parse.sources1.first_record = 28/8/2022 15:30:00
parse.sources1.last_record = 29/8/2022 22:00:00
parse.sources1.distance = 34639
```

json :
```json
[{
        "word": "day",
        "phonetic": "/deɪ/",
        "phonetics": [{
                "text": "/deɪ/",
                "audio": "https://api.dictionaryapi.dev/media/pronunciations/en/day-us.mp3",
                "sourceUrl": "https://commons.wikimedia.org/w/index.php?curid=711086",
                "license": {
                    "name": "BY-SA 3.0",
                    "url": "https://creativecommons.org/licenses/by-sa/3.0"
                }
            }
        ],
        "meanings": [{
                "partOfSpeech": "noun",
                "definitions": [{
                        "definition": "Any period of 24 hours.",
                        "synonyms": [],
                        "antonyms": [],
                        "example": "I've been here for two days and a bit."
                    }, {
                        "definition": "A period from midnight to the following midnight.",
                        "synonyms": [],
                        "antonyms": [],
                        "example": "The day begins at midnight."
                    }, {
                        "definition": "Rotational period of a planet (especially Earth).",
                        "synonyms": [],
                        "antonyms": [],
                        "example": "A day on Mars is slightly over 24 hours."
                    }, {
                        "definition": "The part of a day period which one spends at one’s job, school, etc.",
                        "synonyms": [],
                        "antonyms": [],
                        "example": "I worked two days last week."
                    }, {
                        "definition": "Part of a day period between sunrise and sunset where one enjoys daylight; daytime.",
                        "synonyms": ["daylight", "upsun"],
                        "antonyms": ["night"],
                        "example": "day and night;  I work at night and sleep during the day."
                    }, {
                        "definition": "A specified time or period; time, considered with reference to the existence or prominence of a person or thing; age; time.",
                        "synonyms": ["epoch", "era"],
                        "antonyms": [],
                        "example": "Every dog has its day."
                    }, {
                        "definition": "A period of contention of a day or less.",
                        "synonyms": [],
                        "antonyms": [],
                        "example": "The day belonged to the Allies."
                    }, {
                        "definition": "A 24-hour period beginning at 6am or sunrise.",
                        "synonyms": [],
                        "antonyms": [],
                        "example": "Your 8am forecast: The high for the day will be 30 and the low, before dawn, will be 10."
                    }
                ],
                "synonyms": ["daylight", "upsun", "epoch", "era"],
                "antonyms": ["night"]
            }, {
                "partOfSpeech": "verb",
                "definitions": [{
                        "definition": "To spend a day (in a place).",
                        "synonyms": [],
                        "antonyms": []
                    }
                ],
                "synonyms": [],
                "antonyms": []
            }
        ],
        "license": {
            "name": "CC BY-SA 3.0",
            "url": "https://creativecommons.org/licenses/by-sa/3.0"
        },
        "sourceUrls": ["https://en.wiktionary.org/wiki/day"]
    }
]
```

Returned Arguments :
```EditorConfig
parse.0.word = day
parse.0.phonetic = /deɪ/
parse.0.phonetics0.text = /deɪ/
parse.0.phonetics0.audio = https://api.dictionaryapi.dev/media/pronunciations/en/day-us.mp3
parse.0.phonetics0.sourceUrl = https://commons.wikimedia.org/w/index.php?curid=711086
parse.0.phonetics0.license.name = BY-SA 3.0
parse.0.phonetics0.license.url = https://creativecommons.org/licenses/by-sa/3.0
parse.0.meanings0.partOfSpeech = noun
parse.0.meanings0.definitions0.definition = Any period of 24 hours.
parse.0.meanings0.definitions0.example = I've been here for two days and a bit.
parse.0.meanings0.definitions1.definition = A period from midnight to the following midnight.
parse.0.meanings0.definitions1.example = The day begins at midnight.
parse.0.meanings0.definitions2.definition = Rotational period of a planet (especially Earth).
parse.0.meanings0.definitions2.example = A day on Mars is slightly over 24 hours.
parse.0.meanings0.definitions3.definition = The part of a day period which one spends at one’s job, school, etc.
parse.0.meanings0.definitions3.example = I worked two days last week.
parse.0.meanings0.definitions4.definition = Part of a day period between sunrise and sunset where one enjoys daylight; daytime.
parse.0.meanings0.definitions4.synonyms0 = daylight
parse.0.meanings0.definitions4.synonyms1 = upsun
parse.0.meanings0.definitions4.antonyms0 = night
parse.0.meanings0.definitions4.example = day and night;  I work at night and sleep during the day.
parse.0.meanings0.definitions5.definition = A specified time or period; time, considered with reference to the existence or prominence of a person or thing; age; time.
parse.0.meanings0.definitions5.synonyms0 = epoch
parse.0.meanings0.definitions5.synonyms1 = era
parse.0.meanings0.definitions5.example = Every dog has its day.
parse.0.meanings0.definitions6.definition = A period of contention of a day or less.
parse.0.meanings0.definitions6.example = The day belonged to the Allies.
parse.0.meanings0.definitions7.definition = A 24-hour period beginning at 6am or sunrise.
parse.0.meanings0.definitions7.example = Your 8am forecast: The high for the day will be 30 and the low, before dawn, will be 10.
parse.0.meanings0.synonyms0 = daylight
parse.0.meanings0.synonyms1 = upsun
parse.0.meanings0.synonyms2 = epoch
parse.0.meanings0.synonyms3 = era
parse.0.meanings0.antonyms0 = night
parse.0.meanings1.partOfSpeech = verb
parse.0.meanings1.definitions0.definition = To spend a day (in a place).
parse.0.license.name = CC BY-SA 3.0
parse.0.license.url = https://creativecommons.org/licenses/by-sa/3.0
parse.0.sourceUrls0 = https://en.wiktionary.org/wiki/day
```
