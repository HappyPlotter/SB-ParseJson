This code will parse a json and will return the arguments into the local action

1. Set your json string into an argument called "json"
2. (optional) Set the prefix for the parsed arguments by setting the "parsePrefix" argument. If "parsePrefix" is missing then the default prefix will be "parse"
3. Execute the code

**CODE**

TlM0RR+LCAAAAAAABAB1VtuSokgQfd+I/Qein9cOQGmbiZgHRcXCbrsVucg6D1BVQq3FZbho48T8+xYg7a3HCAPMzDp58mRC+uvvvzjuYY/TjMTRwzdO/Kc2RG6I2a8HLYujdzfN8ENjd2HO4jLm+rf6zXG/mgtzEVQdkHnRfeq5Ykfue/1Oz4P9jvws4o7red5W4KEgSFKDVR/6WeCiShQVlJ6tOHI9iiu8PC3whf0D0gLhSRqHU5LlcVqykK1Ls4uYlnnNmtP0t/lFOj+Ni6TyruKYZhcOlx7cMlsW0T1g6kYoDgd14fdeGEewSFMc5fe+O7GuBPuKLVP7TKoOQDiDKUlOyZu4rC6Ly/KURD7H6HEpzos0yrg8wJyb+kXI+GQcifKYywqv4XEDvMM4GVCyx3e8m6rxFrOqIL6hXzuVb5uNRZgsh2yzeSUwjbN4mz/Ox6vNZpKykg5xunvqbTb73iP/2OW7grzZhBmMU0q8R0TpwyXgj+vMXpljJUa1LMieJ14IfaNLj0g185cdfX878LPWvgrNLlLlAopyiBRpxq5F5R8tkgOytMy1Xv21+BHA7qu/EIZAtyRmkyjz90eL2AfKwIdTk3gq/Q+o2t4TD/7SDui6a/KO7idtDK4xY02x5zwMaeGUw59VLjDi/bWtRbCURp4o8WuLFpDPKdZ94kbzvUdAAkbPTYyQnWwaeqHLvdFdloxLNFN2/hsZEEAG/ZscBxiaoWv7/rs+DGCIji87dj5aBuzcURdNaaZoB4Z9dMxh6VhOgpXrfFCdlFA0FyccYuuS4Qktvs9iWX0Rw47m9JR/rvg7zbXW/kxNjp7Y899XvA9YHQ23rPYrxnyhK9KrJyLNC5094zEzePkNqPQIxubcmCwdQFhdTDdlsdNYfh7ZWgFUJ/CmLNeowdkuTrqe8caOpQlOGdT6zvQTJzKo+1B99UpDuqR4utQda7JzbOAz/MBRzbLqh8dmAowr7pLh2AFvnHwzVaKoHK7QVGOzg9qzcdOTXVJxbXMAZdh1VZo5+iBusV+oRtfWIp7puys+uK3x1E8wGQZIrXtWnnIUhjrhXUXSHXuYra05ZXp5gBxqXStcqH4Ea9GIAeXJi1LNwoV2Le54UjpdM3csiV+Fk5xxk8G07fsgBQooWA/TNn/zHMT+uaa6rsQhlzVV/TApUMYyUCXBUw/JF2eauVyc5mJa6bCkkLBZEnPKeiFB1ShMVT5pC5lGg+BdHxBjqu0hy4Om9G1tCWzGds38LOgn5he9/5z7WTkgLwSw63CxtpcxUDKmGatbAX51f1vHaV4ucVeOvRyyZ0fwLLNASnC+H0uBZxkZONdjra0PwdHP2is2f9Xr+jtlNv9qVuTbGf2c9+myRJbx+a6p5n27+P795l2cpBjGYULoH17GCFO31HM3vV8yF6sXPz31cR9vO3jbZasX8r2Oi7tPnb7Huz2h+wyR/HyT+ICJH1Sg/CN/7cnLpCIjV59rT7tDr1Z27fnD2m4oRgh/VInO1t/t7Y/blalWKerF8+Ny01LqJhlGF97GWQM1kc0fiouj7FgYshXZxv/+H7FB8ezxCAAA

**EXAMPLE**

json : {"name": "brightsky", "version": "1.0.18", "status": "ok"}

Returned Arguments : <br />
parse.name = brightsky <br />
parse.version = 1.0.18 <br />
parse.status = ok <br />

json :```json
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
]```

Returned Arguments :<br />
parse.0.word = day<br />
parse.0.phonetic = /deɪ/<br />
parse.0.phonetics0.text = /deɪ/<br />
parse.0.phonetics0.audio = https://api.dictionaryapi.dev/media/pronunciations/en/day-us.mp3<br />
parse.0.phonetics0.sourceUrl = https://commons.wikimedia.org/w/index.php?curid=711086<br />
parse.0.phonetics0.license.name = BY-SA 3.0<br />
parse.0.phonetics0.license.url = https://creativecommons.org/licenses/by-sa/3.0<br />
parse.0.meanings0.partOfSpeech = noun<br />
parse.0.meanings0.definitions0.definition = Any period of 24 hours.<br />
parse.0.meanings0.definitions0.example = I've been here for two days and a bit.<br />
parse.0.meanings0.definitions1.definition = A period from midnight to the following midnight.<br />
parse.0.meanings0.definitions1.example = The day begins at midnight.<br />
parse.0.meanings0.definitions2.definition = Rotational period of a planet (especially Earth).<br />
parse.0.meanings0.definitions2.example = A day on Mars is slightly over 24 hours.<br />
parse.0.meanings0.definitions3.definition = The part of a day period which one spends at one’s job, school, etc.<br />
parse.0.meanings0.definitions3.example = I worked two days last week.<br />
parse.0.meanings0.definitions4.definition = Part of a day period between sunrise and sunset where one enjoys daylight; daytime.<br />
parse.0.meanings0.definitions4.synonyms0 = daylight<br />
parse.0.meanings0.definitions4.synonyms1 = upsun<br />
parse.0.meanings0.definitions4.antonyms0 = night<br />
parse.0.meanings0.definitions4.example = day and night;  I work at night and sleep during the day.<br />
parse.0.meanings0.definitions5.definition = A specified time or period; time, considered with reference to the existence or prominence of a person or thing; age; time.<br />
parse.0.meanings0.definitions5.synonyms0 = epoch<br />
parse.0.meanings0.definitions5.synonyms1 = era<br />
parse.0.meanings0.definitions5.example = Every dog has its day.<br />
parse.0.meanings0.definitions6.definition = A period of contention of a day or less.<br />
parse.0.meanings0.definitions6.example = The day belonged to the Allies.<br />
parse.0.meanings0.definitions7.definition = A 24-hour period beginning at 6am or sunrise.<br />
parse.0.meanings0.definitions7.example = Your 8am forecast: The high for the day will be 30 and the low, before dawn, will be 10.<br />
parse.0.meanings0.synonyms0 = daylight<br />
parse.0.meanings0.synonyms1 = upsun<br />
parse.0.meanings0.synonyms2 = epoch<br />
parse.0.meanings0.synonyms3 = era<br />
parse.0.meanings0.antonyms0 = night<br />
parse.0.meanings1.partOfSpeech = verb<br />
parse.0.meanings1.definitions0.definition = To spend a day (in a place).<br />
parse.0.license.name = CC BY-SA 3.0<br />
parse.0.license.url = https://creativecommons.org/licenses/by-sa/3.0<br />
parse.0.sourceUrls0 = https://en.wiktionary.org/wiki/day<br />
