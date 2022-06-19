
using System.Diagnostics;
using System.Numerics;

namespace SabinaGame.Data;


public class SabinaGameService
{


    public SabinaGameState gameState = new SabinaGameState();

    private SabinaGameBigIntStuff bigIntStuff = new SabinaGameBigIntStuff();



 
    public void setup()
    {

        gameState.kunstwerke = new Kunstwerke();
        gameState.assistenten = new Assistenten();
        gameState.werbung = new Werbung();
        gameState.stuff = new Stuff();

        gameState.kunstwerke.name = "Kunstwerke";
        gameState.assistenten.name = "Assistenten";
        gameState.werbung.name = "Werbung";
        gameState.stuff.name = "Stuff";

        gameState.kunstwerke.automatizer = gameState.assistenten;
        gameState.assistenten.kostenTräger = gameState.kunstwerke;
        gameState.assistenten.automatizer = gameState.werbung;
        gameState.werbung.kostenTräger = gameState.assistenten;
        gameState.werbung.automatizer = gameState.stuff;
        gameState.stuff.kostenTräger = gameState.werbung;
  

        gameState.kunstwerke.timer.Start();
        gameState.assistenten.timer.Start();
        gameState.werbung.timer.Start();
        gameState.stuff.timer.Start();


        



    }

    public void kunstwerke()
    {

        gameState.kunstwerke.tick();


    }

 
    public void assistenten()
    {
       
        gameState.assistenten.tick();

    }

    public void werbung()
    {

        gameState.werbung.tick();

    }

    public void stuff()
    {

        gameState.stuff.tick();

    }







}

