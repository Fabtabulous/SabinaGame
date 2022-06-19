using System.Numerics;


namespace SabinaGame.Data;

public class SabinaGameState
{
	public DateTime lastOpened { get; set; }

	public Kunstwerke kunstwerke { get; set; }

	public KunstwerkeVerkauft kunstwerkeVerkauft { get; set; }

	public Assistenten assistenten { get; set; }

    public Werbung werbung { get; set; }
    public Stuff stuff { get; set; }
    public MoreStuff moreStuff { get; set; }

	public EvenMoreStuff evenMoreStuff { get; set; }

	public EvenMoreEvenMoreStuff evenMoreEvenMoreStuff { get; set; }

	public List<Iterable> properties = new List<Iterable>();

	public SabinaGameState()
	{
		kunstwerke = new Kunstwerke();
		properties.Add(kunstwerke);
		kunstwerke.timer.Start();

		kunstwerkeVerkauft = new KunstwerkeVerkauft();
		properties.Add(kunstwerkeVerkauft);
		kunstwerkeVerkauft.timer.Start();

		assistenten = new Assistenten();
		properties.Add(assistenten);
		assistenten.timer.Start();

		werbung = new Werbung();
		properties.Add(werbung);
		werbung.timer.Start();

        stuff = new Stuff();
        properties.Add(stuff);
        stuff.timer.Start();

		moreStuff = new MoreStuff();
		properties.Add(moreStuff);
		moreStuff.timer.Start();

		evenMoreStuff = new EvenMoreStuff();
		properties.Add(evenMoreStuff);
		evenMoreStuff.timer.Start();

		evenMoreEvenMoreStuff = new EvenMoreEvenMoreStuff();
		properties.Add(evenMoreEvenMoreStuff);
		evenMoreEvenMoreStuff.timer.Start();

		int counter = 0;


        foreach (Iterable iterable in properties)
        {

            if (counter == 0)
            {
                iterable.automatizer = properties[counter + 1];
            }

            else if (counter == properties.Count - 1)
            {
                iterable.KostenTräger = properties[counter - 1];
            }

            else
            {
                iterable.KostenTräger = properties[counter - 1];
                iterable.automatizer = properties[counter + 1];
            }

            counter++;

        }

        



    }
}
