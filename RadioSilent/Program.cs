/*
Grace Anders
11/11/2020
Radio Silent (Adventure Game)

Keyboard controlled Menu: https://www.youtube.com/watch?v=qAWhGEPMlS8&feature=emb_title
How to tell if a list is empty: https://stackoverflow.com/questions/18867180/check-if-list-is-empty-in-c-sharp
Had my roomates play test
 */

using System;
using static System.Console;

namespace RadioSilent
{
    class Program
    {
        static void Main(string[] args)
        {
            WindowHeight = LargestWindowHeight;
            WindowWidth = LargestWindowWidth;

            Title = "Radio Silent By: Grace";
            string TitleText = "";
            TitleText = @"
 +---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
 |       +---------+            +        +----------+    +-------------+    +-------+            +---------+   +-------------+ +----+          +-------------+ +-----+  +----+ +-------------+       |
 |       |          ++         + +       |           +   |             |   +         +          +           +  |             | |    |          |             | |     |  |    | |             |       |
 |       ++  +----+   +       +   +      ++  +----+   +  +----+   +----+  +   +■■■+   +        +   +-----+   + +----+   +----+ ++  ++          ++  +------+  | ++   ++  ++  ++ +----+   +----+       |
 |        |  |     ++  +     +  +  +      |  |     +   +      |   |      +   +■■■■■+   +       |  +       +--+      |   |       |  |            |  |      +--+  |    +   |  |       |   |            |
 |        |  |     ++  +    +  + +  +     |  |      +  |      |   |      |  +■■■■■■■+  |       +   +----+           |   |       |  |    /\      |  |            |  +  +  |  |       |   |            |
 |        |  +----+   +    +  +   +  +    |  |      |  |      |   |      |  |■■■■■■■|  |        +        ++         |   |       |  |   <  >     |  +----+       |  ++  + |  |       |   |      /\    |
 |   /\   |         ++     +  +---+  +    |  |      |  |      |   |      |  |■■■■■■■|  |         +-----+   ++       |   |       |  |    \/      |       |       |  | +  ++  |       |   |     /  \   |
 |  <  >  |  +---+  +     +           +   |  |      +  |      |   |      |  +■■■■■■■+  |                ++   +      |   |       |  |            |  +----+       |  |  +  +  |       |   |   <      > |
 |   \/   |  |    +  +    |  +-----+  |   |  |     +   +      |   |      +   +■■■■■+   +       +--+       +  |      |   |       |  |      +--+  |  |      +--+  |  |   +    |       |   |     \  /   |
 |        +  +     +  +   +  +     +  +  ++  +----+   +  +----+   +----+  +   +■■■+   +        +   +-----+   + +----+   +----+ ++  +------+  | ++  +------+  | ++  ++  ++   ++      |   |      \/    |
 |       +    +   +    + +    +   +    + |           +   |             |   +         +          +           +  |             | |             | |             | |    |  |     |      |   |            |
 |       +----+   +----+ +----+   +----+ +----------+    +-------------+    +-------+            +---------+   +-------------+ +-------------+ +-------------+ +----+  +-----+      +---+            |
 |                                                                                                                                                                                          /\       |
 |                   /\                                                /\                                                                                         ..,;::::::::;,'...       <  >      |
 |                  <  >                                              <  >                                  /\                                                .,:ldxkkkkxxxxxdddoooc;,..    \/       |
 |                   \/                                                \/                                  /  \                                             .;oxkOkkkkkkkkkkkxxddddddool:,.          |
 |                              ````````                /\                                                /____\      /\                                  cxOO00K00OOOkO0Okxxxxxxxxxxdoolc;'         |
 | ```````                `..+-+:::::+-+...`           /  \                                               +   _+     <  >                              .:dkkOKKXXKKK0OO0K00OOkOOOOkkxxdoolc:,.       |
 | `.+..+----+....     `.+::////////////:::+.``      <      >                                             |  (_|      \/                              ,odk00KKXNNXXKK0KKK0000000OOOOkxddolcc:;'.     |
 |   `..+---+.``````  `.+::///+----------+///::+.      \  /                                              /|    |\                                   .;ddxO00KKXNNNXXKKKK0000KKK000OOkxddoolc:::'.    |
 |      ``..++.``    `.+:/+-+ooooooooooooo+--+//:.      \/                                              / |    | \                                 .;oddxO00KXNNNNXKKKKK00000KK000Okkxxddocc::;;'    |
 |          ``.....```.+/+osssyyyyyyssssoooo+-+//:.                                                    /__+____+__\                                'llloxOO0KXXXXXK0000000000000OOkxxxxdoolc::;,,.   |
 |               ``.....++/+oyyhddmmmdhyysssoo++/:+`                                                      /____\                                  .;cllodxkOKKK00K0OOOOOOOOOOOkkkkxddddooollc::;,'.  |
 |    /\             .+::::++:/+syhdmNmdhhhysso++/:..                                                     / ++ \                          /\      .,:looooxkO0OOOOOOkxxkOOkkkkkxdddooollloollccc;,.  |
 |   /  \            `+:/+oooo+/::::/+osyyyyysoo+/+``....                                                /  ++  \                        <  >     .';cllooodxddkkkkkxdxxkkOOOO0Okxollccllloodlcc:;.  |
 | <      >           .+:/+ossyhhhyso+/::::::::::+.   ```.++..                                                                            \/      .'':llllclcclodddooodxxkO000000Okdolcloddodoc::,.  |
 |   \  /              .+:/++oossyyyhhhyso++/:++...```````.+---+..                                                                                 ..,ccol:::;:cc::clooxO0000000OOOOkdodxxdodoc:;,.  |
 |    \/       /\       `.+:/++oooosssssoooo+/:+````......+----+..+.                                                                                ..,;:::cc:::;,;:coxO000000OOOOOOkkkkkxddol:;;.   |
 |            <  >         `.+://+-------+//:.`           ```````````                                                                               ....''';;:c:,,::cxOOOOO00OOOOOOOOkkkxxdool:;'.   |
 |             \/             ```..+----+.``                                         /\                                                              .......',::;;:codxxkOOOOOOOOOOOkkkxdoooc:;'.    |
 |                                              /\                                  /  \                                                              +-----+.''.'';c;,lxkOOOOkkkkkxxxxdolcc:;'.     |
 |                  ,,:+;'.                    <  >                               <      >                                                     /\      +XXXX+---+.....,coddxkkkxxxddddoolc:;'.       |
 |                 ,:cxOO)x;                    \/                                  \  /                                                      /  \      ++XXXXX|-+...   .;lcclloddddoollc;;,.        |
 |                ,:cxOO00)x;                                                  /\    \/                                                     <      >     ++XXXX++.        ..,cll:cllllcc;..     /\   |
 |       /\       ..',cOO0)d`.      /\                                        <  >                                                            \  /         +---+...      ...;:ccc:::::;'..     <  >  |
 |      <  >      :cxOO00)))x      <  >                                        \/        /\                                                    \/             +......  ''',;;;:;;,,,,'.         \/   |
 |       \/        ,:cxO))x;        \/                                                  <  >                                                                     .....       .....                   |
 |                   ,,:+;'                                                              \/                                                                          '''''''                         |
 +---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------+
            ";
            Write(String.Format("{0," + ((WindowWidth / 2) + (TitleText.Length / 2)) + "}", TitleText));
            ForegroundColor = ConsoleColor.DarkGray;
            string textToEnter = "Press any key to start the game";
            Write(String.Format("\n{0," + ((WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            ResetColor();
            ReadKey(true);
            Game game = new Game();
        }
    }
}
