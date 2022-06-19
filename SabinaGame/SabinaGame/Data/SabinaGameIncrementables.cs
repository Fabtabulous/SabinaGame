using System.Diagnostics;
using System.Numerics;

namespace SabinaGame.Data;


public class Iterable
{

    private Stopwatch timer = new Stopwatch();

    private long tickCount = 5000000;

    private BigInteger anzahl = 0;

    public Stopwatch Timer { get => timer; set => timer = value; }
    public long TickCount { get => tickCount; set => tickCount = value; }
    public BigInteger Anzahl { get => anzahl; set => anzahl = value; }

    public override string ToString()
    {

        return anzahl.ToString();

    }

    public string tick()
    {

        increment();

        return this.ToString();
    }

    public void increment()
    {

        if (timer.ElapsedTicks > timer.ElapsedTicks && gameState.assistenten > 0)

        {

            gameState.kunstwerke += gameState.assistenten;
            kunstwerkTimer.Restart();


        }

    }



}

private string toComma(BigInteger bigInt)
{

    return bigIntStuff.bigIntegerWithComma(bigInt);

}
public String kunstwerke()
{
    incrementKunstwerke();

    return toComma(gameState.kunstwerke);

}



public void incrementKunstwerke()
{

    if (kunstwerkTimer.ElapsedTicks > kunstwerkTick && gameState.assistenten > 0)

    {

        gameState.kunstwerke += gameState.assistenten;
        kunstwerkTimer.Restart();


    }

}


public void incrementKunstwerkeManually()
{
    gameState.kunstwerke += gameState.fähigkeit;
    checkAssistenten();


}

public class iterable
{
	public DateTime lastOpened { get; set; }

	public long tick { get; set; }

	public BigInteger kunstwerke { get; set; }

    public BigInteger fähigkeit { get; set; }

    public BigInteger assistenten { get; set; }

	public BigInteger assistentenGehalt { get; set; }

	public BigInteger rekrutierer { get; set; }



	
}
