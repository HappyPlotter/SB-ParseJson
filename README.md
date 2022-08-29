This code will parse a json and will return the arguments into the local action

1. Set your json string into an argument called "json"
2. (optional) Set the prefix for the parsed arguments by setting the "parsePrefix" argument. If "parsePrefix" is missing then the default prefix will be "parse"
3. Execute the code

**CODE**
```
TlM0RR+LCAAAAAAABAB1VtuSokgQfd+I/Qein9cOQGmbiZgHRcXCbrsVucg6D1BVQq3FZbho48T8+xYg7a3HCAPMzDp58mRC+uvvvzjuYY/TjMTRwzdO/Kc2RG6I2a8HLYujdzfN8ENjd2HO4jLm+rf6zXG/mgtzEVQdkHnRfeq5Ykfue/1Oz4P9jvws4o7red5W4KEgSFKDVR/6WeCiShQVlJ6tOHI9iiu8PC3whf0D0gLhSRqHU5LlcVqykK1Ls4uYlnnNmtP0t/lFOj+Ni6TyruKYZhcOlx7cMlsW0T1g6kYoDgd14fdeGEewSFMc5fe+O7GuBPuKLVP7TKoOQDiDKUlOyZu4rC6Ly/KURD7H6HEpzos0yrg8wJyb+kXI+GQcifKYywqv4XEDvMM4GVCyx3e8m6rxFrOqIL6hXzuVb5uNRZgsh2yzeSUwjbN4mz/Ox6vNZpKykg5xunvqbTb73iP/2OW7grzZhBmMU0q8R0TpwyXgj+vMXpljJUa1LMieJ14IfaNLj0g185cdfX878LPWvgrNLlLlAopyiBRpxq5F5R8tkgOytMy1Xv21+BHA7qu/EIZAtyRmkyjz90eL2AfKwIdTk3gq/Q+o2t4TD/7SDui6a/KO7idtDK4xY02x5zwMaeGUw59VLjDi/bWtRbCURp4o8WuLFpDPKdZ94kbzvUdAAkbPTYyQnWwaeqHLvdFdloxLNFN2/hsZEEAG/ZscBxiaoWv7/rs+DGCIji87dj5aBuzcURdNaaZoB4Z9dMxh6VhOgpXrfFCdlFA0FyccYuuS4Qktvs9iWX0Rw47m9JR/rvg7zbXW/kxNjp7Y899XvA9YHQ23rPYrxnyhK9KrJyLNC5094zEzePkNqPQIxubcmCwdQFhdTDdlsdNYfh7ZWgFUJ/CmLNeowdkuTrqe8caOpQlOGdT6zvQTJzKo+1B99UpDuqR4utQda7JzbOAz/MBRzbLqh8dmAowr7pLh2AFvnHwzVaKoHK7QVGOzg9qzcdOTXVJxbXMAZdh1VZo5+iBusV+oRtfWIp7puys+uK3x1E8wGQZIrXtWnnIUhjrhXUXSHXuYra05ZXp5gBxqXStcqH4Ea9GIAeXJi1LNwoV2Le54UjpdM3csiV+Fk5xxk8G07fsgBQooWA/TNn/zHMT+uaa6rsQhlzVV/TApUMYyUCXBUw/JF2eauVyc5mJa6bCkkLBZEnPKeiFB1ShMVT5pC5lGg+BdHxBjqu0hy4Om9G1tCWzGds38LOgn5he9/5z7WTkgLwSw63CxtpcxUDKmGatbAX51f1vHaV4ucVeOvRyyZ0fwLLNASnC+H0uBZxkZONdjra0PwdHP2is2f9Xr+jtlNv9qVuTbGf2c9+myRJbx+a6p5n27+P795l2cpBjGYULoH17GCFO31HM3vV8yF6sXPz31cR9vO3jbZasX8r2Oi7tPnb7Huz2h+wyR/HyT+ICJH1Sg/CN/7cnLpCIjV59rT7tDr1Z27fnD2m4oRgh/VInO1t/t7Y/blalWKerF8+Ny01LqJhlGF97GWQM1kc0fiouj7FgYshXZxv/+H7FB8ezxCAAA
```

**EXAMPLE**

json : 
```json
{"name": "brightsky", "version": "1.0.18", "status": "ok"}
```

Returned Arguments :
```
parse.name = brightsky
parse.version = 1.0.18
parse.status = ok
```
json :
```json
{"weather": {"source_id": 42212, "timestamp": "2022-08-29T19:00:00+00:00", "cloud_cover": 75, "condition": "dry", "dew_point": 12.28, "precipitation_10": 0.0, "precipitation_30": 0.0, "precipitation_60": 0.0, "pressure_msl": 1019.9, "relative_humidity": 72, "visibility": 52837, "wind_direction_10": 40, "wind_direction_30": 40, "wind_direction_60": 47, "wind_speed_10": 8.3, "wind_speed_30": 7.9, "wind_speed_60": 7.2, "wind_gust_direction_10": 40, "wind_gust_direction_30": 40, "wind_gust_direction_60": 40, "wind_gust_speed_10": 10.8, "wind_gust_speed_30": 10.8, "wind_gust_speed_60": 10.8, "sunshine_30": 0.0, "sunshine_60": 0.0, "temperature": 17.4, "fallback_source_ids": {"cloud_cover": 11689, "condition": 11689, "pressure_msl": 11689, "visibility": 11689, "wind_direction_10": 11689, "wind_direction_30": 11689, "wind_direction_60": 11689, "wind_speed_10": 11689, "wind_speed_30": 11689, "wind_speed_60": 11689, "wind_gust_direction_10": 11689, "wind_gust_direction_30": 11689, "wind_gust_direction_60": 11689, "wind_gust_speed_10": 11689, "wind_gust_speed_30": 11689, "wind_gust_speed_60": 11689, "sunshine_30": 11689, "sunshine_60": 11689}, "icon": "partly-cloudy-night"}, "sources": [{"id": 42212, "dwd_station_id": "13696", "observation_type": "synop", "lat": 51.5966, "lon": 7.40484, "height": 60.0, "station_name": "Waltrop-Abdinghof", "wmo_station_id": "H443", "first_record": "2022-08-28T12:30:00+00:00", "last_record": "2022-08-29T19:00:00+00:00", "distance": 2523.0}, {"id": 11689, "dwd_station_id": "01303", "observation_type": "synop", "lat": 51.4041, "lon": 6.96774, "height": 150.0, "station_name": "Essen-Bredeney", "wmo_station_id": "10410", "first_record": "2022-08-28T12:30:00+00:00", "last_record": "2022-08-29T19:00:00+00:00", "distance": 34639.0}]}
```

Returned Arguments :
```
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
```
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
