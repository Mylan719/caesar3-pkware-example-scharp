#Caesar 3 PKWare decompression example port for C#.
Caesar 3 PKWare decompression example

C# is implementation could be used with Unity game engine for example.

This is a C# port of an example program for demonstrating how to decompress parts of the Caesar 3 .sav game file format.
Original example was made in Java by [Avatar Bianca van Schaik](https://github.com/bvschaik).

## Running

`dotnet run`

## Legend

### Natural elements
- `Y` Tree
- `v` Scrub
- `O` Rock
- `/` Elevation
- `\` Access ramp for elevated area
- `~` Water
- `_` Meadow
- `.` Empty land

### Human elements
- `B` Building
- `z` Garden
- `=` Road
- `|` Aqueduct
- `w` Wall
- `W` Gatehouse
- `;` Rubble

## Example output

Map of the first mission:

    YYYYYYYYYYYYYYYYYY..O=..~~~~.YYYYYYYYOOO
    YYYYYYYYYYYYYYYYYY...=...~~~~.YYYYYY.OOO
    YYYYYYYYYYYYYYYYYYY..=..Y.~~~~.YYYY.OOOO
    YYYYYYYYYYYYYYYYYYYY.=.YYY.~~~~~YYY.OOO.
    YYYYYYYYYYYYYYY.YYYYY=YYYYY~~~~~~...OOOO
    YYYYYYYYYYYYYYYY.YYY.=.YYYY..~~~~~~OOOOO
    YYYYYYYYYYYYY.YYYYY..=YYYYYYY~~~~~~~OOOO
    .YYYYYYYYYY....YYYY..=YYYYYYYYY~~~~~~.O.
    YYYYYYYYYY......YYYY.=YYYYYYYY.Y~~~~~...
    YYYYYYYYYY.......YYYY=.YYY...YY..~~~~~~~
    ~YY.YY...YYYY.....YYY=.YY.OOOOO..O.~~~~~
    ~~Y.YYY...YYYY.....Y.=.YYYOOOOOOOOO.~~~~
    ~~~.YYYY...YYYY......=..YYOOOOOOOOO..~~~
    ~~~..YYY....Y.YY.....=.YY.OOO.YY..YY.~~~
    ~~~..YYY....YYYYY....=.Y..OOO.YYYYYYYYY.
    ~~~...YYY...YY.YYY...=....OOOYYYYYYYYYYY
    ~~~~..YYY..YYYYYYY...=...YOOYYYYYYYYYYYY
    .~~~...YYY..Y.YYYYY..=..Y.YOOYYYYYYYYYY.
    .~~~~..YYYYYYYYYYY...=.YYY.YO.YYYYYYYYYY
    .~~~~~..YYYYYYYYYYY..=.YYY.OOO.YYYYYYYYY
    .~~~~~~..YYYYYYYYYYY.=YYYYY.OO.YYYYYYYYY
    ...~~~~~.YYYYY..YYYYY=YYYYY.YOO.YYYYYYY.
    ..Y.~~~~~YYYY...YYYY.=.YYYY..OOOOYYYYYY.
    .YYY.~~~~~YYYY..YYY..=..YYY..YOOOOOYYYYY
    YY.YY~~~~~~YYYYYYYY..=..YYYY...OOOOOYYYY
    YYYYY.~~~~~.YYYYYYYY.=...YYYY...O.OO.YYY
    YYYYYY~~~~~.YYYYYY.YY=..YYYYYY...OOOOYYY
    YYY.YY~~~~~..YYY.YYYY.BBBBBYYYY...OOOOY.
    YYYYYY~~~~~..YYYYYYY.=BBBBBYYYY....OOOOO
    YYY.YY~~~~~~.YYYYYYBB=BBBBBY.YY..OOOOOOO
    YYYY.Y~~~~~~.YYY.Y.BB=BBBBBY.YYY..OOOOOO
    YY.Y...~~~~~~.YYY.BBB=BBBBBY.YYY..OOOO.O
    YYYYYY..~~~~~.YYY..BB=BBBBBYY.YYY..OOOOO
    YYYYYYY...~~~~.Y...BB=BBBBBYYYYYY..O.OO.
    YY.YY.YY.~~~~~.YY..BB======YYYYYY..OOOOO
    YYYYYYYYYY~~~~YYYYBBB=BBBB.YYYYYY..OOOOO
    .YYYYYY.YYY~~~~YYY...=BBBB.YYYYY...OOOOO
    ..YYYYYYYYYY~~~YYYY..=BBY.YYYYYYY..OOOOO
    ...YYYYYYYY~~~~~YY..O=..YYYYYYYYYY.OOOOO
    .......YYYYY~~~~.....=.YYYYYYYYYYYY.OOOO
