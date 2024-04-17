using System;

Console.CursorVisible = true;
bool gameRunning = true;
bool userTurn = true;

while (gameRunning)
    {
        if (userTurn)
        {
            userTurn();
            if (LookForWin('X'))
            {
                GameEnd("Congratulations! You win!");
                break;
            }
        }
        else {
            AITurn();
            if (LookForWin('O'))
            {
                GameEnd ("You lost :(");
                break;
            }
        }
        userTurn = !userTurn;
        if (LookForFilledGrid())
        {
            GameEnd ("A strange game. The only winning move is not to play.");
            break;
        }
    }





