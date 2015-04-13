using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace COMP100_Assignment5_AhmedBenbrahim
{
    class Program
    {
        static void Main(string[] args)
        {
            BasketBallGame();
        }


        // UTILITY METHODS
        private static void WaitForKey()
        {
            Console.WriteLine();
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.WriteLine("+ Start Over.....................>");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            Console.ReadKey();
            Console.Clear();
        }

        // Main menu Utility Method
        private static void BasketBallGame()
        {
            int selection = 0; // default selection
            string introText = "===============WELCOME TO THE BASKET BALL SHOOTING WORLD CUP,===============\n";                                                                                                                            
                   introText = " oooooooooo.                     oooo                      .   oooooooooo.           oooo  oooo  oooooo   oooooo     oooo                 oooo        .o8     .oooooo.                          \n";
                   introText += "`888'   `Y8b                    `888                    .o8   `888'   `Y8b           `888  `888   `888.    `888.     .8'                  `888       '888    d8P'  `Y8b                         \n";
                   introText += " 888     888  .oooo.    .oooo.o  888  oooo   .ooooo.  .o888oo  888     888  .oooo.    888   888    `888.   .8888.   .8' .ooooo.  oooo d8b  888   .oooo888   888          oooo  oooo  oo.ooooo.  \n";
                   introText += " 888oooo888' `P  )88b  d88(  '8  888 .8P'   d88' `88b   888    888oooo888' `P  )88b   888   888     `888  .8'`888. .8' d88' `88b `888''8P  888  d88' `888   888          `888  `888   888' `88b \n";
                   introText += " 888    `88b .oP' 888  `'Y88b.   888888.    888ooo888   888    888    `88b  .oP'888   888   888      `888.8'  `888.8'  888   888  888      888  888   888   888           888   888   888   888 \n";
                   introText += " 888    .88P d8(  888  o.  )88b  888 `88b.  888    .o   888 .  888    .88P d8(  888   888   888       `888'    `888'   888   888  888      888  888   888   `88b    ooo   888   888   888   888 \n";
                   introText += "o888bood8P'  `Y888''8o 8''888P' o888o o888o `Y8bod8P'   '888' o888bood8P'  `Y888''8o o888o o888o       `8'      `8'    `Y8bod8P' d888b    o888o `Y8bod88P'   `Y8bood8P'   `V88V'V8P'  888bod8P' \n";
                   introText += "                                                                                                                                                                                      888       \n";
                   introText += "                                                                                                                                                                                     o888o      \n";

                   introText += "=====IN THIS GAME YOU HAVE TO PICK THE CORRECT BASKET IN ORDER TO WIN=====\n";
                                                                                                                                             
                   introText += "=====================PICK A BASKET IN ORDER TO WIN======================= \n\n";
                   introText += "ROUND 1";
            string bodyText = "";

            // 1st Decision Level Basket 1
 
            while (selection != 3)
            {
                Console.ResetColor();
                Console.WriteLine(introText);
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                         +");
                Console.WriteLine("+  WHICH BASKET DO YOU WANT TO SHOOT AT?  +");
                Console.WriteLine("+                                         +");
                Console.WriteLine("+  1. Basket 1                            +");
                Console.WriteLine("+  2. Basket 2                            +");
                Console.WriteLine("+  3. Give Up :(                          +");
                Console.WriteLine("+                                         +");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Please choose your basket: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Basket 1 - Player proceeds to Round 2
                        Basket1();
                        break;
                    case 2: // Basket 2 - Player proceeds to Round 2
                        Basket2();
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There is no such a basket - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }
        }
    
            // 2nd Decision Level Basket 1
        private static void Basket1()
        {
            string introText = "";
            int selection = 0;

            Console.Clear();
            introText = "You shoot the ball,";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball flys in slow motion.\n";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball hit the back board!\n";
            introText += "The ball goes in.\n";
            introText += "People cheering.\n\n";
            introText += "YOU ARE GOING TO ROUND 2.\n\n";
            Console.ResetColor();

                        while (selection != 3)
            {
                Console.WriteLine(introText);

                Console.WriteLine("ROUND 2");
                Console.WriteLine();
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  WHICH BASKET DO YOU WANT TO SHOOT AT?   +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  1. Basket 3                             +");
                Console.WriteLine("+  2. Basket 4                             +");
                Console.WriteLine("+  3. Give Up :(                           +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Please choose your basket: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Player takes Basket 3 - PROCEEDS TO ROUND 3
                        Basket3();
                        selection = 3;
                        break;
                    case 2: // Player takes Basket 4 - PROCEEDS TO ROUND 3
                        Basket4();
                        selection = 3;
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There is no such a basket - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }

        }


        // 2nd Decision Level Basket 2
        private static void Basket2()
        {
            string introText = "";
            int selection = 0;

            Console.Clear();
            introText = "You shoot the ball,";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball flys in slow motion.\n";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball hit the back board!\n";
            introText += "The ball goes in.\n";
            introText += "People cheering.\n\n";
            introText += "YOU ARE GOING TO ROUND 3.\n\n";


            Console.ResetColor();

                        while (selection != 3)
            {
                Console.ResetColor();
                Console.WriteLine(introText);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  WHICH BASKET DO YOU WANT TO SHOOT AT?   +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  1. Basket 5                             +");
                Console.WriteLine("+  2. Basket 6                             +");
                Console.WriteLine("+  3. Give Up :(                           +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Please choose your basket: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Player takes Basket 5 - PROCEEDS TO ROUND 3
                        Basket5();
                        selection = 3;
                        break;
                    case 2: // Player takes Basket 6 - PROCEEDS TO ROUND 3
                        Basket6();
                        selection = 3;
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There is no such a basket - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }

        }

        // 3rd Decision Level Basket 3
        private static void Basket3()
        {
            string introText = "";
            int selection = 0;

            Console.Clear();
            introText = "You shoot the ball,";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball flys in slow motion.\n";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball hit the back board!\n";
            introText += "The ball goes in.\n";
            introText += "People cheering.\n\n";
            introText += "YOU ARE AMOST THERE!\n";
            Console.Clear();

            introText += "IN ORDER FOR YOU TO WIN, YOU HAVE CHOOSE ONE OF THE SPECIALTY WINS OR BALLS";

            Console.ResetColor();

            while (selection != 3)
            {
                Console.ResetColor();
                Console.WriteLine(introText);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                              +");
                Console.WriteLine("+  CHOOSE ONE OF THE SPECIALTY WINS OR BALLS   +");
                Console.WriteLine("+                                              +");
                Console.WriteLine("+  1. Fire Ball                                +");
                Console.WriteLine("+  2. Slam Dunk                                +");
                Console.WriteLine("+  3. Give Up :(                               +");
                Console.WriteLine("+                                              +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Please choose your Specialty Ball: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Player takes Fire Ball - Loss Outcome
                        FireBall();
                        selection = 3;
                        break;
                    case 2: // Player takes Slam Dunk - Win Outcome
                        SlamDunk();
                        selection = 3;
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There is no such a ball - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }

        }

        // 3rd Decision Level Basket 4
        private static void Basket4()
        {
            string introText = "";
            int selection = 0;

            Console.Clear();
            introText = "You shoot the ball,";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball flys in slow motion.\n";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball hit the back board!\n";
            introText += "The ball goes in.\n";
            introText += "People cheering.\n\n";
            introText += "YOU ARE AMOST THERE!\n";
            Console.Clear();

            introText += "IN ORDER FOR YOU TO WIN, YOU HAVE CHOOSE ONE OF THE SPECIALTY WINS OR BALLS";
            Console.ResetColor();

            while (selection != 3)
            {
                Console.ResetColor();
                Console.WriteLine(introText);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  WHICH BASKET DO YOU WANT TO SHOOT AT?   +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  1. Power Ball                           +");
                Console.WriteLine("+  2. Water Ball                           +");
                Console.WriteLine("+  3. Give Up :(                           +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Please choose your Specialty Ball: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Player takes Power Ball - Loss Outcome
                        PowerBall();
                        selection = 3;
                        break;
                    case 2: // Player takes Water Ball - Loss Outcome
                        WaterBall();
                        selection = 3;
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There is no such a ball - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }

        }

        // 3rd Decision Level Basket 5
        private static void Basket5()
        {
            string introText = "";
            int selection = 0;

            Console.Clear();
            introText = "You shoot the ball,";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball flys in slow motion.\n";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball hit the back board!\n";
            introText += "The ball goes in.\n";
            introText += "People cheering.\n\n";
            introText += "YOU ARE AMOST THERE!\n";
            Console.Clear();

            introText += "IN ORDER FOR YOU TO WIN, YOU HAVE CHOOSE ONE OF THE SPECIALTY WINS OR BALLS";
            Console.ResetColor();

            while (selection != 3)
            {
                Console.ResetColor();
                Console.WriteLine(introText);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  WHICH BASKET DO YOU WANT TO SHOOT AT?   +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  1. Lightning Ball                       +");
                Console.WriteLine("+  2. Electric Ball                        +");
                Console.WriteLine("+  3. Give Up :(                           +");
                Console.WriteLine("+  4. Bonus (You can switch to Basket 3)   +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Please choose your Specialty Ball: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Player takes Lighnting Ball - Loss Outcome
                        LightningBall();
                        selection = 3;
                        break;
                    case 2: // Player takes Electric Ball - Loss Outcome
                        ElectricBall();
                        selection = 3;
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        break;
                    case 4: // Player can switch to basket 3
                        Basket3();
                        selection = 3;
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There is no such a ball - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }

        }

        // 3rd Decision Level Basket 6
        private static void Basket6()
        {
            string introText = "";
            int selection = 0;

            Console.Clear();
            introText = "You shoot the ball,";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball flys in slow motion.\n";
            Console.Write(introText);
            Thread.Sleep(1500);
            introText = "The ball hit the back board!\n";
            introText += "The ball goes in.\n";
            introText += "People cheering.\n\n";
            introText += "YOU ARE AMOST THERE!\n";
            Console.Clear();

            introText += "IN ORDER FOR YOU TO WIN, YOU HAVE CHOOSE ONE OF THE SPECIALTY WINS OR BALLS";
            Console.ResetColor();

            while (selection != 3)
            {
                Console.ResetColor();
                Console.WriteLine(introText);
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  WHICH BASKET DO YOU WANT TO SHOOT AT?   +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("+  1. Sun Ball                             +");
                Console.WriteLine("+  2. Moon Ball                            +");
                Console.WriteLine("+  3. Give Up :(                           +");
                Console.WriteLine("+                                          +");
                Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
                Console.Write("Please choose your Specialty Ball: ");

                try
                {
                    selection = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception error)
                {
                    selection = 0;
                }

                switch (selection)
                {
                    case 1: // Player takes Sun Ball - Loss Outcome
                        SunBall();
                        selection = 3;
                        break;
                    case 2: // Player takes Moon Ball - Loss Outcome
                        MoonBall();
                        selection = 3;
                        break;
                    case 3:
                        Console.WriteLine(); // Exit
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine("There is no such a ball - Please try again");
                        Console.WriteLine();
                        WaitForKey();
                        break;
                }

                Console.Clear(); // Clears the screen
            }

        }

        // Outcome 1 - Player WINS
        private static void SlamDunk()
        {
            string bodyText = "";
            Console.Clear();
            bodyText = "YOU GOT IT.\n";
            bodyText += "YOU WON THE WORLDCUP\n\n";
            Console.ResetColor();
            Console.WriteLine(bodyText);
            Thread.Sleep(2000);

            bodyText = "                      .'';,;'#`           \n";
            bodyText += "                   .+. ``````:#           \n";
            bodyText += "                  +'````````.`.+          \n";
            bodyText += "                 ++````````.```.+         \n";
            bodyText += "                ,+.```````.`````:+        \n";
            bodyText += "                +,..``````````...:+       \n";
            bodyText += "               ;'......``.```.....+       \n";
            bodyText += "               #........,.....,,,,,+      \n";
            bodyText += "            `,.;...``......`....,.,#`     \n";
            bodyText += "           ``.,......```:;;.`...,,:```    \n";
            bodyText += "          ......`....``:;;.`.,..,.`...    \n";
            bodyText += "           .`.,```,,,::::::,,..```.,,.,   \n";
            bodyText += "           `.,.+':,::;;':,,,,:::''+`;..   \n";
            bodyText += "           .`..+,:+;:;,++##+';;',;'`;.`   \n";
            bodyText += "          ``,.`''+::',++##++;;:;:,.;..    \n";
            bodyText += "           ``,` :;'';;:#####;;':;:'.:..   \n";
            bodyText += "           ``,`  :;'++#######';;'':.:..   \n";
            bodyText += "           ``,`   :;'####++##+';' :.,,.   \n";
            bodyText += "           ``,`    `'''#+##+'+'`  :..,,   \n";
            bodyText += "           `.:`      #+;+#''#`    ,.`.,   \n";
            bodyText += "           `.:`      ####+###     `.`.`   \n";
            bodyText += "            .:`      :##+++##.     :`.`   \n";
            bodyText += "            ,,`     `#+#+;'++.    `;.`   \n";
            bodyText += "            ,..`     #+++:+##.    `;..   \n";
            bodyText += "            ...,     #+#++'+;:    `;,.   \n";
            bodyText += "            ...:     #+#+#++;:    .:,,   \n";
            bodyText += "            ..,,     #+#+++;:,   .,.,.   \n";
            bodyText += "            `.,.     #'.:..,:.   .,..`   \n";
            bodyText += "             ,:`     #'''',.,`   ..;.    \n";
            bodyText += "             ::,     #''';,.,    ,,',    \n";
            bodyText += "             :,:     #''';:.,    ;,:.    \n";
            bodyText += "             ;:;     #';';:.,    +:,`    \n";
            bodyText += "             ,::`    #;'';:,`    ;:;     \n";
            bodyText += "             .;,.    #::';:,`   `,'+     \n";
            bodyText += "             `::,    +:`';;;,   .,;;     \n";
            bodyText += "              :;;    +:.+;;;;   ::,`     \n";
            bodyText += "              ;''    ':..:;+'   +:,      \n";
            bodyText += "              ,';.   ::...:''   ;+'      \n";
            bodyText += "              `;::   .:...:;:  `:';      \n";
            bodyText += "               :;:   .:`..,+.  :::`      \n";
            bodyText += "               ;''   `:```.+`  +;;       \n";
            bodyText += "               ,''`   :.```+   '''       \n";
            bodyText += "               `;;,   :,```+  .;;,       \n";
            bodyText += "                ;':   ::```;  :';        \n";
            bodyText += "                ;++   ;;```;  +'+        \n";
            bodyText += "                `+#:  ;;```;  ##;        \n";
            bodyText += "                 ##;  ';```; .++`        \n";
            bodyText += "                 :+;  ':```: '##         \n";
            bodyText += "                  ##: +:```, ##+         \n";
            bodyText += "                  +#; +,```` ##          \n";
            bodyText += "                  `#; +,`` `,##          \n";
            bodyText += "                   ##'+.``` ##`          \n";
            bodyText += "                   `#:'.````##           \n";
            bodyText += "                    #+#.` ,'#.           \n";
            bodyText += "                    ,;'. `:';            \n";
            bodyText += "                    ;:,.:,,,,            \n";
            bodyText += "                    ,:::;:::;            \n";
            bodyText += "                   ;:,..:,,,:,           \n";
            bodyText += "                  ::..`,;+'...,:`         \n";
            bodyText += "                 +;';.`.;+'.`.:;;`        \n";
            bodyText += "                ##';:,.,;;;;,,,,:'        \n";
            bodyText += "               @###'+';'++++'++####       \n";
            bodyText += "              +#:#```+`` ';  ,# `:;#      \n";
            bodyText += "             ++:,..` .` ``  ``'```;;;     \n";
            bodyText += "            ,#:;+```;.```:,``.;,..,;;     \n";
            bodyText += "            ######+#+#,`;++:`:##',###@    \n";
            bodyText += "           `######+#+##+++++##########'   \n";
            bodyText += "           ` .::,,,.`..:;'+',,''';:,,`    \n";
            Console.ForegroundColor = System.ConsoleColor.Green;
            Console.WriteLine(bodyText);
            WaitForKey();
        }

        // Outcome 2 - Player Loses
        private static void SunBall()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "YOU CHOSE THE SUN BALL.\n";
            introText += "SUN BALL HAS THE POWER OF THE SUN, IT MELTS THE WHOLE STADIUM AND EVERYBODY DIES\n";
            introText += "YOU LOST\n\n";
            introText += "TRY AGAIN LATER\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(2000);


            bodyText = "....... .............  ... ........... ....... .................................\n";
            bodyText += "  8O8O8O? .......$OMMNNMD7:. ....:ZOMMMDMN$$ .. .OOMOZNO888?..I$DOOOM$ZD8$+.. ..\n";
            bodyText += "..DMMMMM8...  .?DMMMMMMMMMM8,...IMMMMMMMMMMMN~...8MMMMMMMMMO..$MMMMMMMMMMMMO?...\n";
            bodyText += "..DMMMMM8.....$DMMMMOIONMMMM8..,MMMMMD+OMMMMM$...NMMMMMMMMMN..+DMMMMMNNMMMMM8...\n";
            bodyText += "..OMMMMM8... .8MMMMN?.~NMMMMD~,+MMMMN7..8MMMMO...NNMMMMD,~.,..7DMMMMD..ZMMMMN ..\n";
            bodyText += "..DNMMMMO.....NMMMMM=.:NMMMMN= =MMMMM$..ONNMNI,..NMMMMM?. . ..$NMMMMD..OMMMMM=. \n";
            bodyText += "..NNMMMMZ ... 8MMMMN:.:8MMMMM~.=NMMMMN?.,........DMMMMMI... . 7NMMMMM .$MMMMD,..\n";
            bodyText += "..NMMMMM8... .NMMMMMZ.:NMMMMD~.,NMMMMMNNI....   .MMMMMM7~,=:..IDMMMMN,IOMMMM8...\n";
            bodyText += "..MMMMMNO,....8MMMNM$..8MMMMNI,.,MMMMMMMMMD+.. ..DMMMMMMMMM7..7DMMMMMMNMMMMO:...\n";
            bodyText += "..OMMMMMO...  NMMMMM7.:DMMMMD~. ..?8MMMMMMMMD....DMMMMMMMMMI .?NMMMMMMMMMM$Z. ..\n";
            bodyText += "  MNMMMMD.....ZNMMMM=,,DMMMMD: .....~ONMMMMMMD...DMMMMNNZZI7. +NMMMMD,.ZMMMMD...\n";
            bodyText += "..ONMMMMZ.....8MMMMN7,:MMMMMN~........,7MMMMMN=..DMMMMM7.  . .7NMMMMN,.$MMMMD:  \n";
            bodyText += "..MMMMMM8.....DMMMMM?.,ZMMMMN~.:MNMMMO ,$MMMMM$ .DMMMMM?.  ...$OMMMM8,.ZMMMMN:..\n";
            bodyText += ". NNMMMM8, ., 8MMMMN?.~$MMMMD~.:NMMMMO..+MMMMN7..NMMMMMI......7DMMMMD. $MMMMM:..\n";
            bodyText += "..NMMMMMNDZ$$.NNMMMMZ INMMMMD...MMMMMN. $MMMMNI..NMMMMMZZ8$$= INMMMMD,.?MMMMM:..\n";
            bodyText += "..DMMMMMMMMM8 7NMMMMDZMMMMMMZ...DNMMMNOMMMMMMD:. DMMMMMMMMMN+.$DMMMM8, ?MMMMD.. \n";
            bodyText += "..8MMMMMMMMM$. :NMMMMMMMMMMZ ... $MMMMMMMMMMN+...8MMMMMMMMMD=.7NMMMMD, OMMMMN=. \n";
            bodyText += "..$ZZ7$I$OI77....=$DNMDN87,.... ..,=NDDNDDOI.....$+OIZ8$7$OZ+,+IOO$I$..+77IO7,. \n";
            bodyText += "..... ... ... ......,....... .. ....,.....,..........  . ........... .... ..... \n";
            bodyText += "..  .............. ..    ..  ....  ...   ...     ......... ... ...    ...   ....\n";
            bodyText += ".......................................... . ........,,+ZZZ$~, . ...............\n";
            bodyText += ".............................          ....:,:,,...+MNI?=,,+$ZMNN...............\n";
            bodyText += ".......................................:8MND7?ZNMDNN=:.:7DMNOI:,ZM:.. ..........\n";
            bodyText += "............................. .. .,.,8MMO~:::::,=MN8DOO7~::,,:::~DM.............\n";
            bodyText += "........................ ...:8MMMNO8MN~:~::~:::~M$:~~::::~~::~:~~~NN. ..........\n";
            bodyText += "................... .....+MMNI~=~~~~~~~~~~~~~~~=N~~~~~~~~~~~~~~~~~?M, ..........\n";
            bodyText += ".................... ..,MD?===~==~~~============D~~===~======~=====O= ..........\n";
            bodyText += "..............,..+NMMMMM$=+====================NM=================~8I...........\n";
            bodyText += ".......... ...NMM8?+++++++++++++++++==+++++++++DN++=+++++++++++==~$M~...........\n";
            bodyText += ".......... ..DD?++++++++++++++++++NMO+++++++++?7MM~+?++++++++=:=DMN:. ..........\n";
            bodyText += "............NM?????????++?????????MD+?+???????+IM$MMNIIIDNMNMNND7M..............\n";
            bodyText += "............MI?????????=M????????IDM????????????N??$88ND8$7??I???M:.............\n";
            bodyText += "............MIIIIIIIIIMM7IIIIIIIIIZM+?IIIIIIIII?DZIIIIIII?OD+IN8I8M.............\n";
            bodyText += "............MIIIIIIIIIIZDIIIIIIIIIIN8IIIIIIIIIII8DII7IIII?MMMD$I?$M . ..........\n";
            bodyText += "............ZI777777777$D7I77777777OM77777777777$M7Z$NMM8DMII77777M+............\n";
            bodyText += "........... :N$7777777$7M7777777$$$7M$7777777$7IDM8$7$77$8DNMM$=7?M8............\n";
            bodyText += "........... :MI$$$$$$$$$M?$$$$$$$$$ZM$$$$$$$$7~MNZ$=~$7$$$$$$$8NMMMM,.  ........\n";
            bodyText += "........... .87$ZZ$$$$$ZNZ$$$$$$$$$ZM$$$$$$$$DMDZ$OMNM=I$$$$$$$$OMMM=...........\n";
            bodyText += "..............M?ZZZZZZZZ88ZZZZZZZZZZNZZZZZ$Z=MZZIMNOZOMMN+$ZZZZZZ8MM$ ..........\n";
            bodyText += "..............M?ZOZZZOZO8M+OOOOOOZOON?ZZZZ?~MDZ7NNOZZZZONMDZZZZZZZNM= ..........\n";
            bodyText += "..............IMIOOOOOZOON87$OOOZOZ=MMMMMMD8MZ~NNOOOOOOOOOMOOOOOO87N. ..........\n";
            bodyText += "...............I8O88OO8$+OMM=++?OMNZ. ,:?Z?=8IDNM788888O8OMO88O8O+MZ. ..........\n";
            bodyText += "..............  OM7??8MNI.. .  ..?=I,=..,... NOINNIZD888=MD88888?N... ..........\n";
            bodyText += "..................... .........:.,............=M+8NMZ==OMD8DD8Z$D,..............\n";
            bodyText += "..........  ....................................?M8=NMNNNDD8D~MO ...............\n";
            bodyText += "............................................ .. . .OM7+77?+$MZ... ..............\n";
            bodyText += "................................................. ... ++++..... ................\n";
            bodyText += "..............   ...............................................................\n";

            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }

        // Outcome 3 - Player Loses
        private static void MoonBall()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "YOU CHOSE THE MOON BALL.\n";
            introText += "MOON BALL ATTRACTS WOLVES THAT CAME AND ATE EVERYBODY\n";
            introText += "YOU LOST\n\n";
            introText += "TRY AGAIN LATER\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(2000);

            bodyText = "....... .............  ... ........... ....... .................................\n";
            bodyText += "  8O8O8O? .......$OMMNNMD7:. ....:ZOMMMDMN$$ .. .OOMOZNO888?..I$DOOOM$ZD8$+.. ..\n";
            bodyText += "..DMMMMM8...  .?DMMMMMMMMMM8,...IMMMMMMMMMMMN~...8MMMMMMMMMO..$MMMMMMMMMMMMO?...\n";
            bodyText += "..DMMMMM8.....$DMMMMOIONMMMM8..,MMMMMD+OMMMMM$...NMMMMMMMMMN..+DMMMMMNNMMMMM8...\n";
            bodyText += "..OMMMMM8... .8MMMMN?.~NMMMMD~,+MMMMN7..8MMMMO...NNMMMMD,~.,..7DMMMMD..ZMMMMN ..\n";
            bodyText += "..DNMMMMO.....NMMMMM=.:NMMMMN= =MMMMM$..ONNMNI,..NMMMMM?. . ..$NMMMMD..OMMMMM=. \n";
            bodyText += "..NNMMMMZ ... 8MMMMN:.:8MMMMM~.=NMMMMN?.,........DMMMMMI... . 7NMMMMM .$MMMMD,..\n";
            bodyText += "..NMMMMM8... .NMMMMMZ.:NMMMMD~.,NMMMMMNNI....   .MMMMMM7~,=:..IDMMMMN,IOMMMM8...\n";
            bodyText += "..MMMMMNO,....8MMMNM$..8MMMMNI,.,MMMMMMMMMD+.. ..DMMMMMMMMM7..7DMMMMMMNMMMMO:...\n";
            bodyText += "..OMMMMMO...  NMMMMM7.:DMMMMD~. ..?8MMMMMMMMD....DMMMMMMMMMI .?NMMMMMMMMMM$Z. ..\n";
            bodyText += "  MNMMMMD.....ZNMMMM=,,DMMMMD: .....~ONMMMMMMD...DMMMMNNZZI7. +NMMMMD,.ZMMMMD...\n";
            bodyText += "..ONMMMMZ.....8MMMMN7,:MMMMMN~........,7MMMMMN=..DMMMMM7.  . .7NMMMMN,.$MMMMD:  \n";
            bodyText += "..MMMMMM8.....DMMMMM?.,ZMMMMN~.:MNMMMO ,$MMMMM$ .DMMMMM?.  ...$OMMMM8,.ZMMMMN:..\n";
            bodyText += ". NNMMMM8, ., 8MMMMN?.~$MMMMD~.:NMMMMO..+MMMMN7..NMMMMMI......7DMMMMD. $MMMMM:..\n";
            bodyText += "..NMMMMMNDZ$$.NNMMMMZ INMMMMD...MMMMMN. $MMMMNI..NMMMMMZZ8$$= INMMMMD,.?MMMMM:..\n";
            bodyText += "..DMMMMMMMMM8 7NMMMMDZMMMMMMZ...DNMMMNOMMMMMMD:. DMMMMMMMMMN+.$DMMMM8, ?MMMMD.. \n";
            bodyText += "..8MMMMMMMMM$. :NMMMMMMMMMMZ ... $MMMMMMMMMMN+...8MMMMMMMMMD=.7NMMMMD, OMMMMN=. \n";
            bodyText += "..$ZZ7$I$OI77....=$DNMDN87,.... ..,=NDDNDDOI.....$+OIZ8$7$OZ+,+IOO$I$..+77IO7,. \n";
            bodyText += "..... ... ... ......,....... .. ....,.....,..........  . ........... .... ..... \n";
            bodyText += "..  .............. ..    ..  ....  ...   ...     ......... ... ...    ...   ....\n";
            bodyText += ".......................................... . ........,,+ZZZ$~, . ...............\n";
            bodyText += ".............................          ....:,:,,...+MNI?=,,+$ZMNN...............\n";
            bodyText += ".......................................:8MND7?ZNMDNN=:.:7DMNOI:,ZM:.. ..........\n";
            bodyText += "............................. .. .,.,8MMO~:::::,=MN8DOO7~::,,:::~DM.............\n";
            bodyText += "........................ ...:8MMMNO8MN~:~::~:::~M$:~~::::~~::~:~~~NN. ..........\n";
            bodyText += "................... .....+MMNI~=~~~~~~~~~~~~~~~=N~~~~~~~~~~~~~~~~~?M, ..........\n";
            bodyText += ".................... ..,MD?===~==~~~============D~~===~======~=====O= ..........\n";
            bodyText += "..............,..+NMMMMM$=+====================NM=================~8I...........\n";
            bodyText += ".......... ...NMM8?+++++++++++++++++==+++++++++DN++=+++++++++++==~$M~...........\n";
            bodyText += ".......... ..DD?++++++++++++++++++NMO+++++++++?7MM~+?++++++++=:=DMN:. ..........\n";
            bodyText += "............NM?????????++?????????MD+?+???????+IM$MMNIIIDNMNMNND7M..............\n";
            bodyText += "............MI?????????=M????????IDM????????????N??$88ND8$7??I???M:.............\n";
            bodyText += "............MIIIIIIIIIMM7IIIIIIIIIZM+?IIIIIIIII?DZIIIIIII?OD+IN8I8M.............\n";
            bodyText += "............MIIIIIIIIIIZDIIIIIIIIIIN8IIIIIIIIIII8DII7IIII?MMMD$I?$M . ..........\n";
            bodyText += "............ZI777777777$D7I77777777OM77777777777$M7Z$NMM8DMII77777M+............\n";
            bodyText += "........... :N$7777777$7M7777777$$$7M$7777777$7IDM8$7$77$8DNMM$=7?M8............\n";
            bodyText += "........... :MI$$$$$$$$$M?$$$$$$$$$ZM$$$$$$$$7~MNZ$=~$7$$$$$$$8NMMMM,.  ........\n";
            bodyText += "........... .87$ZZ$$$$$ZNZ$$$$$$$$$ZM$$$$$$$$DMDZ$OMNM=I$$$$$$$$OMMM=...........\n";
            bodyText += "..............M?ZZZZZZZZ88ZZZZZZZZZZNZZZZZ$Z=MZZIMNOZOMMN+$ZZZZZZ8MM$ ..........\n";
            bodyText += "..............M?ZOZZZOZO8M+OOOOOOZOON?ZZZZ?~MDZ7NNOZZZZONMDZZZZZZZNM= ..........\n";
            bodyText += "..............IMIOOOOOZOON87$OOOZOZ=MMMMMMD8MZ~NNOOOOOOOOOMOOOOOO87N. ..........\n";
            bodyText += "...............I8O88OO8$+OMM=++?OMNZ. ,:?Z?=8IDNM788888O8OMO88O8O+MZ. ..........\n";
            bodyText += "..............  OM7??8MNI.. .  ..?=I,=..,... NOINNIZD888=MD88888?N... ..........\n";
            bodyText += "..................... .........:.,............=M+8NMZ==OMD8DD8Z$D,..............\n";
            bodyText += "..........  ....................................?M8=NMNNNDD8D~MO ...............\n";
            bodyText += "............................................ .. . .OM7+77?+$MZ... ..............\n";
            bodyText += "................................................. ... ++++..... ................\n";
            bodyText += "..............   ...............................................................\n";
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }


        // Outcome 4 - Player Loses
        private static void FireBall()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "YOU CHOSE THE FIRE BALL.\n";
            introText += "FIRE BALL BURNED DOWN THE WHOLE STADIUM\n";
            introText += "YOU LOST\n\n";
            introText += "TRY AGAIN LATER\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(2000);

            bodyText = "....... .............  ... ........... ....... .................................\n";
            bodyText += "  8O8O8O? .......$OMMNNMD7:. ....:ZOMMMDMN$$ .. .OOMOZNO888?..I$DOOOM$ZD8$+.. ..\n";
            bodyText += "..DMMMMM8...  .?DMMMMMMMMMM8,...IMMMMMMMMMMMN~...8MMMMMMMMMO..$MMMMMMMMMMMMO?...\n";
            bodyText += "..DMMMMM8.....$DMMMMOIONMMMM8..,MMMMMD+OMMMMM$...NMMMMMMMMMN..+DMMMMMNNMMMMM8...\n";
            bodyText += "..OMMMMM8... .8MMMMN?.~NMMMMD~,+MMMMN7..8MMMMO...NNMMMMD,~.,..7DMMMMD..ZMMMMN ..\n";
            bodyText += "..DNMMMMO.....NMMMMM=.:NMMMMN= =MMMMM$..ONNMNI,..NMMMMM?. . ..$NMMMMD..OMMMMM=. \n";
            bodyText += "..NNMMMMZ ... 8MMMMN:.:8MMMMM~.=NMMMMN?.,........DMMMMMI... . 7NMMMMM .$MMMMD,..\n";
            bodyText += "..NMMMMM8... .NMMMMMZ.:NMMMMD~.,NMMMMMNNI....   .MMMMMM7~,=:..IDMMMMN,IOMMMM8...\n";
            bodyText += "..MMMMMNO,....8MMMNM$..8MMMMNI,.,MMMMMMMMMD+.. ..DMMMMMMMMM7..7DMMMMMMNMMMMO:...\n";
            bodyText += "..OMMMMMO...  NMMMMM7.:DMMMMD~. ..?8MMMMMMMMD....DMMMMMMMMMI .?NMMMMMMMMMM$Z. ..\n";
            bodyText += "  MNMMMMD.....ZNMMMM=,,DMMMMD: .....~ONMMMMMMD...DMMMMNNZZI7. +NMMMMD,.ZMMMMD...\n";
            bodyText += "..ONMMMMZ.....8MMMMN7,:MMMMMN~........,7MMMMMN=..DMMMMM7.  . .7NMMMMN,.$MMMMD:  \n";
            bodyText += "..MMMMMM8.....DMMMMM?.,ZMMMMN~.:MNMMMO ,$MMMMM$ .DMMMMM?.  ...$OMMMM8,.ZMMMMN:..\n";
            bodyText += ". NNMMMM8, ., 8MMMMN?.~$MMMMD~.:NMMMMO..+MMMMN7..NMMMMMI......7DMMMMD. $MMMMM:..\n";
            bodyText += "..NMMMMMNDZ$$.NNMMMMZ INMMMMD...MMMMMN. $MMMMNI..NMMMMMZZ8$$= INMMMMD,.?MMMMM:..\n";
            bodyText += "..DMMMMMMMMM8 7NMMMMDZMMMMMMZ...DNMMMNOMMMMMMD:. DMMMMMMMMMN+.$DMMMM8, ?MMMMD.. \n";
            bodyText += "..8MMMMMMMMM$. :NMMMMMMMMMMZ ... $MMMMMMMMMMN+...8MMMMMMMMMD=.7NMMMMD, OMMMMN=. \n";
            bodyText += "..$ZZ7$I$OI77....=$DNMDN87,.... ..,=NDDNDDOI.....$+OIZ8$7$OZ+,+IOO$I$..+77IO7,. \n";
            bodyText += "..... ... ... ......,....... .. ....,.....,..........  . ........... .... ..... \n";
            bodyText += "..  .............. ..    ..  ....  ...   ...     ......... ... ...    ...   ....\n";
            bodyText += ".......................................... . ........,,+ZZZ$~, . ...............\n";
            bodyText += ".............................          ....:,:,,...+MNI?=,,+$ZMNN...............\n";
            bodyText += ".......................................:8MND7?ZNMDNN=:.:7DMNOI:,ZM:.. ..........\n";
            bodyText += "............................. .. .,.,8MMO~:::::,=MN8DOO7~::,,:::~DM.............\n";
            bodyText += "........................ ...:8MMMNO8MN~:~::~:::~M$:~~::::~~::~:~~~NN. ..........\n";
            bodyText += "................... .....+MMNI~=~~~~~~~~~~~~~~~=N~~~~~~~~~~~~~~~~~?M, ..........\n";
            bodyText += ".................... ..,MD?===~==~~~============D~~===~======~=====O= ..........\n";
            bodyText += "..............,..+NMMMMM$=+====================NM=================~8I...........\n";
            bodyText += ".......... ...NMM8?+++++++++++++++++==+++++++++DN++=+++++++++++==~$M~...........\n";
            bodyText += ".......... ..DD?++++++++++++++++++NMO+++++++++?7MM~+?++++++++=:=DMN:. ..........\n";
            bodyText += "............NM?????????++?????????MD+?+???????+IM$MMNIIIDNMNMNND7M..............\n";
            bodyText += "............MI?????????=M????????IDM????????????N??$88ND8$7??I???M:.............\n";
            bodyText += "............MIIIIIIIIIMM7IIIIIIIIIZM+?IIIIIIIII?DZIIIIIII?OD+IN8I8M.............\n";
            bodyText += "............MIIIIIIIIIIZDIIIIIIIIIIN8IIIIIIIIIII8DII7IIII?MMMD$I?$M . ..........\n";
            bodyText += "............ZI777777777$D7I77777777OM77777777777$M7Z$NMM8DMII77777M+............\n";
            bodyText += "........... :N$7777777$7M7777777$$$7M$7777777$7IDM8$7$77$8DNMM$=7?M8............\n";
            bodyText += "........... :MI$$$$$$$$$M?$$$$$$$$$ZM$$$$$$$$7~MNZ$=~$7$$$$$$$8NMMMM,.  ........\n";
            bodyText += "........... .87$ZZ$$$$$ZNZ$$$$$$$$$ZM$$$$$$$$DMDZ$OMNM=I$$$$$$$$OMMM=...........\n";
            bodyText += "..............M?ZZZZZZZZ88ZZZZZZZZZZNZZZZZ$Z=MZZIMNOZOMMN+$ZZZZZZ8MM$ ..........\n";
            bodyText += "..............M?ZOZZZOZO8M+OOOOOOZOON?ZZZZ?~MDZ7NNOZZZZONMDZZZZZZZNM= ..........\n";
            bodyText += "..............IMIOOOOOZOON87$OOOZOZ=MMMMMMD8MZ~NNOOOOOOOOOMOOOOOO87N. ..........\n";
            bodyText += "...............I8O88OO8$+OMM=++?OMNZ. ,:?Z?=8IDNM788888O8OMO88O8O+MZ. ..........\n";
            bodyText += "..............  OM7??8MNI.. .  ..?=I,=..,... NOINNIZD888=MD88888?N... ..........\n";
            bodyText += "..................... .........:.,............=M+8NMZ==OMD8DD8Z$D,..............\n";
            bodyText += "..........  ....................................?M8=NMNNNDD8D~MO ...............\n";
            bodyText += "............................................ .. . .OM7+77?+$MZ... ..............\n";
            bodyText += "................................................. ... ++++..... ................\n";
            bodyText += "..............   ...............................................................\n";
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }

        // Outcome 5 - Player Loses
        private static void LightningBall()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "YOU CHOSE THE LIGHTNING BALL.\n";
            introText += "LIGHTNING BALL STRUCK EVERYONE IN THE STADIUM WITH A LIGHTNING";
            introText += "YOU LOST\n\n";
            introText += "TRY AGAIN LATER\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(2000);

            bodyText = "....... .............  ... ........... ....... .................................\n";
            bodyText += "  8O8O8O? .......$OMMNNMD7:. ....:ZOMMMDMN$$ .. .OOMOZNO888?..I$DOOOM$ZD8$+.. ..\n";
            bodyText += "..DMMMMM8...  .?DMMMMMMMMMM8,...IMMMMMMMMMMMN~...8MMMMMMMMMO..$MMMMMMMMMMMMO?...\n";
            bodyText += "..DMMMMM8.....$DMMMMOIONMMMM8..,MMMMMD+OMMMMM$...NMMMMMMMMMN..+DMMMMMNNMMMMM8...\n";
            bodyText += "..OMMMMM8... .8MMMMN?.~NMMMMD~,+MMMMN7..8MMMMO...NNMMMMD,~.,..7DMMMMD..ZMMMMN ..\n";
            bodyText += "..DNMMMMO.....NMMMMM=.:NMMMMN= =MMMMM$..ONNMNI,..NMMMMM?. . ..$NMMMMD..OMMMMM=. \n";
            bodyText += "..NNMMMMZ ... 8MMMMN:.:8MMMMM~.=NMMMMN?.,........DMMMMMI... . 7NMMMMM .$MMMMD,..\n";
            bodyText += "..NMMMMM8... .NMMMMMZ.:NMMMMD~.,NMMMMMNNI....   .MMMMMM7~,=:..IDMMMMN,IOMMMM8...\n";
            bodyText += "..MMMMMNO,....8MMMNM$..8MMMMNI,.,MMMMMMMMMD+.. ..DMMMMMMMMM7..7DMMMMMMNMMMMO:...\n";
            bodyText += "..OMMMMMO...  NMMMMM7.:DMMMMD~. ..?8MMMMMMMMD....DMMMMMMMMMI .?NMMMMMMMMMM$Z. ..\n";
            bodyText += "  MNMMMMD.....ZNMMMM=,,DMMMMD: .....~ONMMMMMMD...DMMMMNNZZI7. +NMMMMD,.ZMMMMD...\n";
            bodyText += "..ONMMMMZ.....8MMMMN7,:MMMMMN~........,7MMMMMN=..DMMMMM7.  . .7NMMMMN,.$MMMMD:  \n";
            bodyText += "..MMMMMM8.....DMMMMM?.,ZMMMMN~.:MNMMMO ,$MMMMM$ .DMMMMM?.  ...$OMMMM8,.ZMMMMN:..\n";
            bodyText += ". NNMMMM8, ., 8MMMMN?.~$MMMMD~.:NMMMMO..+MMMMN7..NMMMMMI......7DMMMMD. $MMMMM:..\n";
            bodyText += "..NMMMMMNDZ$$.NNMMMMZ INMMMMD...MMMMMN. $MMMMNI..NMMMMMZZ8$$= INMMMMD,.?MMMMM:..\n";
            bodyText += "..DMMMMMMMMM8 7NMMMMDZMMMMMMZ...DNMMMNOMMMMMMD:. DMMMMMMMMMN+.$DMMMM8, ?MMMMD.. \n";
            bodyText += "..8MMMMMMMMM$. :NMMMMMMMMMMZ ... $MMMMMMMMMMN+...8MMMMMMMMMD=.7NMMMMD, OMMMMN=. \n";
            bodyText += "..$ZZ7$I$OI77....=$DNMDN87,.... ..,=NDDNDDOI.....$+OIZ8$7$OZ+,+IOO$I$..+77IO7,. \n";
            bodyText += "..... ... ... ......,....... .. ....,.....,..........  . ........... .... ..... \n";
            bodyText += "..  .............. ..    ..  ....  ...   ...     ......... ... ...    ...   ....\n";
            bodyText += ".......................................... . ........,,+ZZZ$~, . ...............\n";
            bodyText += ".............................          ....:,:,,...+MNI?=,,+$ZMNN...............\n";
            bodyText += ".......................................:8MND7?ZNMDNN=:.:7DMNOI:,ZM:.. ..........\n";
            bodyText += "............................. .. .,.,8MMO~:::::,=MN8DOO7~::,,:::~DM.............\n";
            bodyText += "........................ ...:8MMMNO8MN~:~::~:::~M$:~~::::~~::~:~~~NN. ..........\n";
            bodyText += "................... .....+MMNI~=~~~~~~~~~~~~~~~=N~~~~~~~~~~~~~~~~~?M, ..........\n";
            bodyText += ".................... ..,MD?===~==~~~============D~~===~======~=====O= ..........\n";
            bodyText += "..............,..+NMMMMM$=+====================NM=================~8I...........\n";
            bodyText += ".......... ...NMM8?+++++++++++++++++==+++++++++DN++=+++++++++++==~$M~...........\n";
            bodyText += ".......... ..DD?++++++++++++++++++NMO+++++++++?7MM~+?++++++++=:=DMN:. ..........\n";
            bodyText += "............NM?????????++?????????MD+?+???????+IM$MMNIIIDNMNMNND7M..............\n";
            bodyText += "............MI?????????=M????????IDM????????????N??$88ND8$7??I???M:.............\n";
            bodyText += "............MIIIIIIIIIMM7IIIIIIIIIZM+?IIIIIIIII?DZIIIIIII?OD+IN8I8M.............\n";
            bodyText += "............MIIIIIIIIIIZDIIIIIIIIIIN8IIIIIIIIIII8DII7IIII?MMMD$I?$M . ..........\n";
            bodyText += "............ZI777777777$D7I77777777OM77777777777$M7Z$NMM8DMII77777M+............\n";
            bodyText += "........... :N$7777777$7M7777777$$$7M$7777777$7IDM8$7$77$8DNMM$=7?M8............\n";
            bodyText += "........... :MI$$$$$$$$$M?$$$$$$$$$ZM$$$$$$$$7~MNZ$=~$7$$$$$$$8NMMMM,.  ........\n";
            bodyText += "........... .87$ZZ$$$$$ZNZ$$$$$$$$$ZM$$$$$$$$DMDZ$OMNM=I$$$$$$$$OMMM=...........\n";
            bodyText += "..............M?ZZZZZZZZ88ZZZZZZZZZZNZZZZZ$Z=MZZIMNOZOMMN+$ZZZZZZ8MM$ ..........\n";
            bodyText += "..............M?ZOZZZOZO8M+OOOOOOZOON?ZZZZ?~MDZ7NNOZZZZONMDZZZZZZZNM= ..........\n";
            bodyText += "..............IMIOOOOOZOON87$OOOZOZ=MMMMMMD8MZ~NNOOOOOOOOOMOOOOOO87N. ..........\n";
            bodyText += "...............I8O88OO8$+OMM=++?OMNZ. ,:?Z?=8IDNM788888O8OMO88O8O+MZ. ..........\n";
            bodyText += "..............  OM7??8MNI.. .  ..?=I,=..,... NOINNIZD888=MD88888?N... ..........\n";
            bodyText += "..................... .........:.,............=M+8NMZ==OMD8DD8Z$D,..............\n";
            bodyText += "..........  ....................................?M8=NMNNNDD8D~MO ...............\n";
            bodyText += "............................................ .. . .OM7+77?+$MZ... ..............\n";
            bodyText += "................................................. ... ++++..... ................\n";
            bodyText += "..............   ...............................................................\n";
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }

        // Outcome 6 - Player Loses
        private static void ElectricBall()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "YOU CHOSE THE ELECTRIC BALL.\n";
            introText += "ELECTRIC BALL SHOCKED EVERYBODY IN THE STADIUM";
            introText += "YOU LOST\n\n";
            introText += "TRY AGAIN LATER\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(2000);

            bodyText = "....... .............  ... ........... ....... .................................\n";
            bodyText += "  8O8O8O? .......$OMMNNMD7:. ....:ZOMMMDMN$$ .. .OOMOZNO888?..I$DOOOM$ZD8$+.. ..\n";
            bodyText += "..DMMMMM8...  .?DMMMMMMMMMM8,...IMMMMMMMMMMMN~...8MMMMMMMMMO..$MMMMMMMMMMMMO?...\n";
            bodyText += "..DMMMMM8.....$DMMMMOIONMMMM8..,MMMMMD+OMMMMM$...NMMMMMMMMMN..+DMMMMMNNMMMMM8...\n";
            bodyText += "..OMMMMM8... .8MMMMN?.~NMMMMD~,+MMMMN7..8MMMMO...NNMMMMD,~.,..7DMMMMD..ZMMMMN ..\n";
            bodyText += "..DNMMMMO.....NMMMMM=.:NMMMMN= =MMMMM$..ONNMNI,..NMMMMM?. . ..$NMMMMD..OMMMMM=. \n";
            bodyText += "..NNMMMMZ ... 8MMMMN:.:8MMMMM~.=NMMMMN?.,........DMMMMMI... . 7NMMMMM .$MMMMD,..\n";
            bodyText += "..NMMMMM8... .NMMMMMZ.:NMMMMD~.,NMMMMMNNI....   .MMMMMM7~,=:..IDMMMMN,IOMMMM8...\n";
            bodyText += "..MMMMMNO,....8MMMNM$..8MMMMNI,.,MMMMMMMMMD+.. ..DMMMMMMMMM7..7DMMMMMMNMMMMO:...\n";
            bodyText += "..OMMMMMO...  NMMMMM7.:DMMMMD~. ..?8MMMMMMMMD....DMMMMMMMMMI .?NMMMMMMMMMM$Z. ..\n";
            bodyText += "  MNMMMMD.....ZNMMMM=,,DMMMMD: .....~ONMMMMMMD...DMMMMNNZZI7. +NMMMMD,.ZMMMMD...\n";
            bodyText += "..ONMMMMZ.....8MMMMN7,:MMMMMN~........,7MMMMMN=..DMMMMM7.  . .7NMMMMN,.$MMMMD:  \n";
            bodyText += "..MMMMMM8.....DMMMMM?.,ZMMMMN~.:MNMMMO ,$MMMMM$ .DMMMMM?.  ...$OMMMM8,.ZMMMMN:..\n";
            bodyText += ". NNMMMM8, ., 8MMMMN?.~$MMMMD~.:NMMMMO..+MMMMN7..NMMMMMI......7DMMMMD. $MMMMM:..\n";
            bodyText += "..NMMMMMNDZ$$.NNMMMMZ INMMMMD...MMMMMN. $MMMMNI..NMMMMMZZ8$$= INMMMMD,.?MMMMM:..\n";
            bodyText += "..DMMMMMMMMM8 7NMMMMDZMMMMMMZ...DNMMMNOMMMMMMD:. DMMMMMMMMMN+.$DMMMM8, ?MMMMD.. \n";
            bodyText += "..8MMMMMMMMM$. :NMMMMMMMMMMZ ... $MMMMMMMMMMN+...8MMMMMMMMMD=.7NMMMMD, OMMMMN=. \n";
            bodyText += "..$ZZ7$I$OI77....=$DNMDN87,.... ..,=NDDNDDOI.....$+OIZ8$7$OZ+,+IOO$I$..+77IO7,. \n";
            bodyText += "..... ... ... ......,....... .. ....,.....,..........  . ........... .... ..... \n";
            bodyText += "..  .............. ..    ..  ....  ...   ...     ......... ... ...    ...   ....\n";
            bodyText += ".......................................... . ........,,+ZZZ$~, . ...............\n";
            bodyText += ".............................          ....:,:,,...+MNI?=,,+$ZMNN...............\n";
            bodyText += ".......................................:8MND7?ZNMDNN=:.:7DMNOI:,ZM:.. ..........\n";
            bodyText += "............................. .. .,.,8MMO~:::::,=MN8DOO7~::,,:::~DM.............\n";
            bodyText += "........................ ...:8MMMNO8MN~:~::~:::~M$:~~::::~~::~:~~~NN. ..........\n";
            bodyText += "................... .....+MMNI~=~~~~~~~~~~~~~~~=N~~~~~~~~~~~~~~~~~?M, ..........\n";
            bodyText += ".................... ..,MD?===~==~~~============D~~===~======~=====O= ..........\n";
            bodyText += "..............,..+NMMMMM$=+====================NM=================~8I...........\n";
            bodyText += ".......... ...NMM8?+++++++++++++++++==+++++++++DN++=+++++++++++==~$M~...........\n";
            bodyText += ".......... ..DD?++++++++++++++++++NMO+++++++++?7MM~+?++++++++=:=DMN:. ..........\n";
            bodyText += "............NM?????????++?????????MD+?+???????+IM$MMNIIIDNMNMNND7M..............\n";
            bodyText += "............MI?????????=M????????IDM????????????N??$88ND8$7??I???M:.............\n";
            bodyText += "............MIIIIIIIIIMM7IIIIIIIIIZM+?IIIIIIIII?DZIIIIIII?OD+IN8I8M.............\n";
            bodyText += "............MIIIIIIIIIIZDIIIIIIIIIIN8IIIIIIIIIII8DII7IIII?MMMD$I?$M . ..........\n";
            bodyText += "............ZI777777777$D7I77777777OM77777777777$M7Z$NMM8DMII77777M+............\n";
            bodyText += "........... :N$7777777$7M7777777$$$7M$7777777$7IDM8$7$77$8DNMM$=7?M8............\n";
            bodyText += "........... :MI$$$$$$$$$M?$$$$$$$$$ZM$$$$$$$$7~MNZ$=~$7$$$$$$$8NMMMM,.  ........\n";
            bodyText += "........... .87$ZZ$$$$$ZNZ$$$$$$$$$ZM$$$$$$$$DMDZ$OMNM=I$$$$$$$$OMMM=...........\n";
            bodyText += "..............M?ZZZZZZZZ88ZZZZZZZZZZNZZZZZ$Z=MZZIMNOZOMMN+$ZZZZZZ8MM$ ..........\n";
            bodyText += "..............M?ZOZZZOZO8M+OOOOOOZOON?ZZZZ?~MDZ7NNOZZZZONMDZZZZZZZNM= ..........\n";
            bodyText += "..............IMIOOOOOZOON87$OOOZOZ=MMMMMMD8MZ~NNOOOOOOOOOMOOOOOO87N. ..........\n";
            bodyText += "...............I8O88OO8$+OMM=++?OMNZ. ,:?Z?=8IDNM788888O8OMO88O8O+MZ. ..........\n";
            bodyText += "..............  OM7??8MNI.. .  ..?=I,=..,... NOINNIZD888=MD88888?N... ..........\n";
            bodyText += "..................... .........:.,............=M+8NMZ==OMD8DD8Z$D,..............\n";
            bodyText += "..........  ....................................?M8=NMNNNDD8D~MO ...............\n";
            bodyText += "............................................ .. . .OM7+77?+$MZ... ..............\n";
            bodyText += "................................................. ... ++++..... ................\n";
            bodyText += "..............   ...............................................................\n";
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }

        // Outcome 7 - Player Loses
        private static void WaterBall()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "YOU CHOSE THE WATER BALL.\n";
            introText += "WATER BALL FLOODED THE WHOLE STADIUM, EVERYBODY DROWNED\n";
            introText += "YOU LOST\n\n";
            introText += "TRY AGAIN LATER\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(2000);

            bodyText = "....... .............  ... ........... ....... .................................\n";
            bodyText += "  8O8O8O? .......$OMMNNMD7:. ....:ZOMMMDMN$$ .. .OOMOZNO888?..I$DOOOM$ZD8$+.. ..\n";
            bodyText += "..DMMMMM8...  .?DMMMMMMMMMM8,...IMMMMMMMMMMMN~...8MMMMMMMMMO..$MMMMMMMMMMMMO?...\n";
            bodyText += "..DMMMMM8.....$DMMMMOIONMMMM8..,MMMMMD+OMMMMM$...NMMMMMMMMMN..+DMMMMMNNMMMMM8...\n";
            bodyText += "..OMMMMM8... .8MMMMN?.~NMMMMD~,+MMMMN7..8MMMMO...NNMMMMD,~.,..7DMMMMD..ZMMMMN ..\n";
            bodyText += "..DNMMMMO.....NMMMMM=.:NMMMMN= =MMMMM$..ONNMNI,..NMMMMM?. . ..$NMMMMD..OMMMMM=. \n";
            bodyText += "..NNMMMMZ ... 8MMMMN:.:8MMMMM~.=NMMMMN?.,........DMMMMMI... . 7NMMMMM .$MMMMD,..\n";
            bodyText += "..NMMMMM8... .NMMMMMZ.:NMMMMD~.,NMMMMMNNI....   .MMMMMM7~,=:..IDMMMMN,IOMMMM8...\n";
            bodyText += "..MMMMMNO,....8MMMNM$..8MMMMNI,.,MMMMMMMMMD+.. ..DMMMMMMMMM7..7DMMMMMMNMMMMO:...\n";
            bodyText += "..OMMMMMO...  NMMMMM7.:DMMMMD~. ..?8MMMMMMMMD....DMMMMMMMMMI .?NMMMMMMMMMM$Z. ..\n";
            bodyText += "  MNMMMMD.....ZNMMMM=,,DMMMMD: .....~ONMMMMMMD...DMMMMNNZZI7. +NMMMMD,.ZMMMMD...\n";
            bodyText += "..ONMMMMZ.....8MMMMN7,:MMMMMN~........,7MMMMMN=..DMMMMM7.  . .7NMMMMN,.$MMMMD:  \n";
            bodyText += "..MMMMMM8.....DMMMMM?.,ZMMMMN~.:MNMMMO ,$MMMMM$ .DMMMMM?.  ...$OMMMM8,.ZMMMMN:..\n";
            bodyText += ". NNMMMM8, ., 8MMMMN?.~$MMMMD~.:NMMMMO..+MMMMN7..NMMMMMI......7DMMMMD. $MMMMM:..\n";
            bodyText += "..NMMMMMNDZ$$.NNMMMMZ INMMMMD...MMMMMN. $MMMMNI..NMMMMMZZ8$$= INMMMMD,.?MMMMM:..\n";
            bodyText += "..DMMMMMMMMM8 7NMMMMDZMMMMMMZ...DNMMMNOMMMMMMD:. DMMMMMMMMMN+.$DMMMM8, ?MMMMD.. \n";
            bodyText += "..8MMMMMMMMM$. :NMMMMMMMMMMZ ... $MMMMMMMMMMN+...8MMMMMMMMMD=.7NMMMMD, OMMMMN=. \n";
            bodyText += "..$ZZ7$I$OI77....=$DNMDN87,.... ..,=NDDNDDOI.....$+OIZ8$7$OZ+,+IOO$I$..+77IO7,. \n";
            bodyText += "..... ... ... ......,....... .. ....,.....,..........  . ........... .... ..... \n";
            bodyText += "..  .............. ..    ..  ....  ...   ...     ......... ... ...    ...   ....\n";
            bodyText += ".......................................... . ........,,+ZZZ$~, . ...............\n";
            bodyText += ".............................          ....:,:,,...+MNI?=,,+$ZMNN...............\n";
            bodyText += ".......................................:8MND7?ZNMDNN=:.:7DMNOI:,ZM:.. ..........\n";
            bodyText += "............................. .. .,.,8MMO~:::::,=MN8DOO7~::,,:::~DM.............\n";
            bodyText += "........................ ...:8MMMNO8MN~:~::~:::~M$:~~::::~~::~:~~~NN. ..........\n";
            bodyText += "................... .....+MMNI~=~~~~~~~~~~~~~~~=N~~~~~~~~~~~~~~~~~?M, ..........\n";
            bodyText += ".................... ..,MD?===~==~~~============D~~===~======~=====O= ..........\n";
            bodyText += "..............,..+NMMMMM$=+====================NM=================~8I...........\n";
            bodyText += ".......... ...NMM8?+++++++++++++++++==+++++++++DN++=+++++++++++==~$M~...........\n";
            bodyText += ".......... ..DD?++++++++++++++++++NMO+++++++++?7MM~+?++++++++=:=DMN:. ..........\n";
            bodyText += "............NM?????????++?????????MD+?+???????+IM$MMNIIIDNMNMNND7M..............\n";
            bodyText += "............MI?????????=M????????IDM????????????N??$88ND8$7??I???M:.............\n";
            bodyText += "............MIIIIIIIIIMM7IIIIIIIIIZM+?IIIIIIIII?DZIIIIIII?OD+IN8I8M.............\n";
            bodyText += "............MIIIIIIIIIIZDIIIIIIIIIIN8IIIIIIIIIII8DII7IIII?MMMD$I?$M . ..........\n";
            bodyText += "............ZI777777777$D7I77777777OM77777777777$M7Z$NMM8DMII77777M+............\n";
            bodyText += "........... :N$7777777$7M7777777$$$7M$7777777$7IDM8$7$77$8DNMM$=7?M8............\n";
            bodyText += "........... :MI$$$$$$$$$M?$$$$$$$$$ZM$$$$$$$$7~MNZ$=~$7$$$$$$$8NMMMM,.  ........\n";
            bodyText += "........... .87$ZZ$$$$$ZNZ$$$$$$$$$ZM$$$$$$$$DMDZ$OMNM=I$$$$$$$$OMMM=...........\n";
            bodyText += "..............M?ZZZZZZZZ88ZZZZZZZZZZNZZZZZ$Z=MZZIMNOZOMMN+$ZZZZZZ8MM$ ..........\n";
            bodyText += "..............M?ZOZZZOZO8M+OOOOOOZOON?ZZZZ?~MDZ7NNOZZZZONMDZZZZZZZNM= ..........\n";
            bodyText += "..............IMIOOOOOZOON87$OOOZOZ=MMMMMMD8MZ~NNOOOOOOOOOMOOOOOO87N. ..........\n";
            bodyText += "...............I8O88OO8$+OMM=++?OMNZ. ,:?Z?=8IDNM788888O8OMO88O8O+MZ. ..........\n";
            bodyText += "..............  OM7??8MNI.. .  ..?=I,=..,... NOINNIZD888=MD88888?N... ..........\n";
            bodyText += "..................... .........:.,............=M+8NMZ==OMD8DD8Z$D,..............\n";
            bodyText += "..........  ....................................?M8=NMNNNDD8D~MO ...............\n";
            bodyText += "............................................ .. . .OM7+77?+$MZ... ..............\n";
            bodyText += "................................................. ... ++++..... ................\n";
            bodyText += "..............   ...............................................................\n";
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }

        // Outcome 8 - Player Loses
        private static void PowerBall()
        {
            string bodyText = "";
            string introText = "";
            Console.Clear();
            introText = "YOU CHOSE THE POWER BALL.\n";
            introText += "POWER BALL HAS TOO MUCH POWER THAT BROKE DOWN THE ENTIRE STADIUM";
            introText += "YOU LOST\n\n";
            introText += "TRY AGAIN LATER\n";
            Console.ResetColor();
            Console.WriteLine(introText);
            Thread.Sleep(2000);

            bodyText = "....... .............  ... ........... ....... .................................\n";
            bodyText += "  8O8O8O? .......$OMMNNMD7:. ....:ZOMMMDMN$$ .. .OOMOZNO888?..I$DOOOM$ZD8$+.. ..\n";
            bodyText += "..DMMMMM8...  .?DMMMMMMMMMM8,...IMMMMMMMMMMMN~...8MMMMMMMMMO..$MMMMMMMMMMMMO?...\n";
            bodyText += "..DMMMMM8.....$DMMMMOIONMMMM8..,MMMMMD+OMMMMM$...NMMMMMMMMMN..+DMMMMMNNMMMMM8...\n";
            bodyText += "..OMMMMM8... .8MMMMN?.~NMMMMD~,+MMMMN7..8MMMMO...NNMMMMD,~.,..7DMMMMD..ZMMMMN ..\n";
            bodyText += "..DNMMMMO.....NMMMMM=.:NMMMMN= =MMMMM$..ONNMNI,..NMMMMM?. . ..$NMMMMD..OMMMMM=. \n";
            bodyText += "..NNMMMMZ ... 8MMMMN:.:8MMMMM~.=NMMMMN?.,........DMMMMMI... . 7NMMMMM .$MMMMD,..\n";
            bodyText += "..NMMMMM8... .NMMMMMZ.:NMMMMD~.,NMMMMMNNI....   .MMMMMM7~,=:..IDMMMMN,IOMMMM8...\n";
            bodyText += "..MMMMMNO,....8MMMNM$..8MMMMNI,.,MMMMMMMMMD+.. ..DMMMMMMMMM7..7DMMMMMMNMMMMO:...\n";
            bodyText += "..OMMMMMO...  NMMMMM7.:DMMMMD~. ..?8MMMMMMMMD....DMMMMMMMMMI .?NMMMMMMMMMM$Z. ..\n";
            bodyText += "  MNMMMMD.....ZNMMMM=,,DMMMMD: .....~ONMMMMMMD...DMMMMNNZZI7. +NMMMMD,.ZMMMMD...\n";
            bodyText += "..ONMMMMZ.....8MMMMN7,:MMMMMN~........,7MMMMMN=..DMMMMM7.  . .7NMMMMN,.$MMMMD:  \n";
            bodyText += "..MMMMMM8.....DMMMMM?.,ZMMMMN~.:MNMMMO ,$MMMMM$ .DMMMMM?.  ...$OMMMM8,.ZMMMMN:..\n";
            bodyText += ". NNMMMM8, ., 8MMMMN?.~$MMMMD~.:NMMMMO..+MMMMN7..NMMMMMI......7DMMMMD. $MMMMM:..\n";
            bodyText += "..NMMMMMNDZ$$.NNMMMMZ INMMMMD...MMMMMN. $MMMMNI..NMMMMMZZ8$$= INMMMMD,.?MMMMM:..\n";
            bodyText += "..DMMMMMMMMM8 7NMMMMDZMMMMMMZ...DNMMMNOMMMMMMD:. DMMMMMMMMMN+.$DMMMM8, ?MMMMD.. \n";
            bodyText += "..8MMMMMMMMM$. :NMMMMMMMMMMZ ... $MMMMMMMMMMN+...8MMMMMMMMMD=.7NMMMMD, OMMMMN=. \n";
            bodyText += "..$ZZ7$I$OI77....=$DNMDN87,.... ..,=NDDNDDOI.....$+OIZ8$7$OZ+,+IOO$I$..+77IO7,. \n";
            bodyText += "..... ... ... ......,....... .. ....,.....,..........  . ........... .... ..... \n";
            bodyText += "..  .............. ..    ..  ....  ...   ...     ......... ... ...    ...   ....\n";
            bodyText += ".......................................... . ........,,+ZZZ$~, . ...............\n";
            bodyText += ".............................          ....:,:,,...+MNI?=,,+$ZMNN...............\n";
            bodyText += ".......................................:8MND7?ZNMDNN=:.:7DMNOI:,ZM:.. ..........\n";
            bodyText += "............................. .. .,.,8MMO~:::::,=MN8DOO7~::,,:::~DM.............\n";
            bodyText += "........................ ...:8MMMNO8MN~:~::~:::~M$:~~::::~~::~:~~~NN. ..........\n";
            bodyText += "................... .....+MMNI~=~~~~~~~~~~~~~~~=N~~~~~~~~~~~~~~~~~?M, ..........\n";
            bodyText += ".................... ..,MD?===~==~~~============D~~===~======~=====O= ..........\n";
            bodyText += "..............,..+NMMMMM$=+====================NM=================~8I...........\n";
            bodyText += ".......... ...NMM8?+++++++++++++++++==+++++++++DN++=+++++++++++==~$M~...........\n";
            bodyText += ".......... ..DD?++++++++++++++++++NMO+++++++++?7MM~+?++++++++=:=DMN:. ..........\n";
            bodyText += "............NM?????????++?????????MD+?+???????+IM$MMNIIIDNMNMNND7M..............\n";
            bodyText += "............MI?????????=M????????IDM????????????N??$88ND8$7??I???M:.............\n";
            bodyText += "............MIIIIIIIIIMM7IIIIIIIIIZM+?IIIIIIIII?DZIIIIIII?OD+IN8I8M.............\n";
            bodyText += "............MIIIIIIIIIIZDIIIIIIIIIIN8IIIIIIIIIII8DII7IIII?MMMD$I?$M . ..........\n";
            bodyText += "............ZI777777777$D7I77777777OM77777777777$M7Z$NMM8DMII77777M+............\n";
            bodyText += "........... :N$7777777$7M7777777$$$7M$7777777$7IDM8$7$77$8DNMM$=7?M8............\n";
            bodyText += "........... :MI$$$$$$$$$M?$$$$$$$$$ZM$$$$$$$$7~MNZ$=~$7$$$$$$$8NMMMM,.  ........\n";
            bodyText += "........... .87$ZZ$$$$$ZNZ$$$$$$$$$ZM$$$$$$$$DMDZ$OMNM=I$$$$$$$$OMMM=...........\n";
            bodyText += "..............M?ZZZZZZZZ88ZZZZZZZZZZNZZZZZ$Z=MZZIMNOZOMMN+$ZZZZZZ8MM$ ..........\n";
            bodyText += "..............M?ZOZZZOZO8M+OOOOOOZOON?ZZZZ?~MDZ7NNOZZZZONMDZZZZZZZNM= ..........\n";
            bodyText += "..............IMIOOOOOZOON87$OOOZOZ=MMMMMMD8MZ~NNOOOOOOOOOMOOOOOO87N. ..........\n";
            bodyText += "...............I8O88OO8$+OMM=++?OMNZ. ,:?Z?=8IDNM788888O8OMO88O8O+MZ. ..........\n";
            bodyText += "..............  OM7??8MNI.. .  ..?=I,=..,... NOINNIZD888=MD88888?N... ..........\n";
            bodyText += "..................... .........:.,............=M+8NMZ==OMD8DD8Z$D,..............\n";
            bodyText += "..........  ....................................?M8=NMNNNDD8D~MO ...............\n";
            bodyText += "............................................ .. . .OM7+77?+$MZ... ..............\n";
            bodyText += "................................................. ... ++++..... ................\n";
            bodyText += "..............   ...............................................................\n";
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine(bodyText);
            WaitForKey();
        }

    }
}
    
    
    
    
    
    
   
