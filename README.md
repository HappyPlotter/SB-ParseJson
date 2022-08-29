This code will parse a json and will return the arguments into the local action

1. Set your json string into an argument called "json"
2. (optional) Set the prefix for the parsed arguments by setting the "parsePrefix" argument. If "parsePrefix" is missing then the default prefix will be "parse"
3. Execute the code

EXAMPLE

json : {"name": "brightsky", "version": "1.0.18", "status": "ok"}

Returned Arguments :
parse.name : brightsky
parse.version : 1.0.18
parse.status : ok

