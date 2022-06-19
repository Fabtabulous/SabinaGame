
using System.Diagnostics;
using System.Numerics;

namespace SabinaGame.Data;


public class SabinaGameService
{


    private SabinaGameState gameState = new SabinaGameState();


    private SabinaGameBigIntStuff bigIntStuff = new SabinaGameBigIntStuff();

    private Stopwatch kunstwerkTimer = new Stopwatch();

    private long kunstwerkTick = 5000000;

    private long assistentenTick = 5000000;

    public Boolean showAssistenten = false;


    private Stopwatch assistentenTimer = new Stopwatch();



 
    public void setup()
    {

        gameState.kunstwerke = BigInteger.Zero;
        gameState.fähigkeit = 1;
        gameState.assistentenGehalt = 500;
        checkAssistenten();
        kunstwerkTimer.Start();
       

    }

    public String assistenten()
    {

        incrementAssistenten();

        return gameState.assistenten.ToString();

    }

    public void incrementAssistenten()
    {

        if (assistentenTimer.ElapsedTicks > assistentenTick && gameState.rekrutierer > 0)

        {

            gameState.assistenten++;
            assistentenTimer.Restart();

        }

    }

    public void incrementAssistentenManually()
    {

        if (gameState.kunstwerke >= gameState.assistentenGehalt)
        {

            gameState.kunstwerke -= gameState.assistentenGehalt;
            gameState.assistenten += 1;

        }
        
    }

    public void checkAssistenten()
    {

        if (gameState.kunstwerke >= 200)
        {
            showAssistenten = true;
        }

    }







}

