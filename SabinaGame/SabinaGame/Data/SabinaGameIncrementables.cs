using System.Diagnostics;
using System.Numerics;

namespace SabinaGame.Data;


public class Iterable
{
    public String name;

    public SabinaGameBigIntStuff bigIntStuff = new SabinaGameBigIntStuff();

    public Stopwatch timer = new Stopwatch();

    public long tickCount = 10000000;

    public BigInteger anzahl = 0;

    public BigInteger f�higkeit = 1;

    public BigInteger kosten = 500;

    public Boolean show = false;

    public Iterable kostenTr�ger;

    public Iterable automatizer;

    public BigInteger showAutomatizerWhen = 200;


    public Stopwatch Timer { get => timer; set => timer = value; }
    public long TickCount { get => tickCount; set => tickCount = value; }
    public BigInteger Anzahl { get => anzahl; set => anzahl = value; }
    public BigInteger F�higkeit { get => f�higkeit; set => f�higkeit = value; }
    public bool Show { get => show; set => show = value; }
    public Iterable Automatizer { get => automatizer; set => automatizer = value; }

    public BigInteger Kosten { get => kosten; set => kosten = value; }
    public string Name { get => name; set => name = value; }
    public BigInteger ShowAutomatizerWhen { get => showAutomatizerWhen; set => showAutomatizerWhen = value; }
    public Iterable KostenTr�ger { get => kostenTr�ger; set => kostenTr�ger = value; }

    public override string ToString()
    {

        return anzahl.ToString();

    }

    public virtual string kostenString()
    {

        return kosten.ToString();

    }


    public virtual void tick()
    {

        increment();


    }

    public virtual void increment()
    {
        long tickDecrementable = timer.ElapsedTicks;

        if (tickDecrementable > tickCount)
        {
            while (automatizer != null && Automatizer.anzahl > 0 && tickDecrementable > tickCount)

            {

                anzahl += Automatizer.anzahl;
                tickDecrementable -= tickCount;


            }
            checkShowAutomatizer();
            timer.Restart();
        }

    }


    public virtual void incrementManually()
    {

        if (KostenTr�ger != null && KostenTr�ger.anzahl >= kosten)
        {

            KostenTr�ger.anzahl -= kosten;
            anzahl += 1;

        }

        checkShowAutomatizer();

    }

    public virtual void checkShowAutomatizer()
    {

        if (anzahl > showAutomatizerWhen)
        {

            if (automatizer != null)
            {
                automatizer.show = true;
            }

        }

    }



}

public class Kunstwerke : Iterable
{

    public Kunstwerke()
    {
        name = "Kunstwerke";
    }

    public string toComma(BigInteger bigInt)
    {

        return bigIntStuff.bigIntegerWithComma(bigInt);

    }

    public override string ToString()
    {
        return toComma(anzahl);
    }


    public override void incrementManually()
    {
        anzahl += F�higkeit;
        checkShowAutomatizer();


    }

}

public class KunstwerkeVerkauft : Iterable
{

    public KunstwerkeVerkauft()
    {
        name = "Kunstwerke verkauft";
    }
    public override string kostenString()
    {


        return "5";
    }

}

public class Assistenten : Iterable
{

    public Assistenten()
    {
        name = "Assistenten";
    }

}

public class Werbung : Iterable
{

    public Werbung()
    {

        name = "Werbung";

    }

}

public class Stuff : Iterable
{

    public Stuff()
    {
        name = "Stuff";
    }

}

public class MoreStuff : Iterable
{

    public MoreStuff()
    {
        name = "More stuff";
    }

}

public class EvenMoreStuff : Iterable
{

    public EvenMoreStuff()
    {
        name = "Even more stuff";
    }

}

public class EvenMoreEvenMoreStuff : Iterable
{

    public EvenMoreEvenMoreStuff()
    {
        name = "Even more even more stuff";
    }

}