# adofai-angle-calculator

This repository is related to a game called **"[A Dance of Fire and Ice](https://store.steampowered.com/app/977950/A_Dance_of_Fire_and_Ice/)"** developed by **"[7th Beat Games](http://7thbe.at/)"**.

Made for easy angle calculation and shown formula on screen.
Special tiles such as `5, 6, 7, 8` tiles' full calculation formula are not shown on screen, but you can always see source code.
If my source code is too messed up, you can read and use those following formula.

## Used formula

Special tiles' angle offset:
```cs
decimal angle = ((72 * stack5) + (288 * stack6) + (900 / 7 * stack7) + (1620 / 7 * stack8)) % 360;
```

Getting relative angle via absolute angle class:
```cs
decimal angle = (NextTile - ThisTile + 540) % 360;
if (Twirled) angle = 360 - angle;
if (angle == 0) angle = 360;
```

Getting ms between via angle and bpm:
```cs
decimal millisecondsBetween = Math.Round((1000 * angle) / (3 * bpm));
```

## Usage

###### ThisTile textbox
You need to input tile types like `R, D, F, 5`. They follow pathData syntax.

###### NextTile textbox
You need to input the same with the above.

###### BPM textbox
You need to put BPM of the specific part where the tile is. Required only if you need to get milliseconds between these tiles.

###### Twirled checkbox
Planet rotates counterclockwise if you check this checkbox.
