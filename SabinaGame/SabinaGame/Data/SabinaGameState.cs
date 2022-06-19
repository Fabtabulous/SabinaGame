using System.Numerics;


namespace SabinaGame.Data;

public class SabinaGameState
{
	public DateTime lastOpened { get; set; }

	public Kunstwerke kunstwerke { get; set; }

	public Assistenten assistenten { get; set; }

	public Stuff stuff { get; set; }

	public Werbung werbung { get; set; }

	public List<Iterable> properties = new List<Iterable>();

	public SabinaGameState()
	{
		kunstwerke = new Kunstwerke();
		properties.Add(kunstwerke);
		kunstwerke.timer.Start();

		assistenten = new Assistenten();
		properties.Add(assistenten);
		assistenten.timer.Start();

		stuff = new Stuff();
		properties.Add(stuff);
		stuff.timer.Start();

		werbung = new Werbung();
		properties.Add(werbung);
		werbung.timer.Start();

		kunstwerke.automatizer = assistenten;
		assistenten.kostenTräger = kunstwerke;
		assistenten.automatizer = werbung;
		werbung.kostenTräger = assistenten;
		werbung.automatizer = stuff;
		stuff.kostenTräger = werbung;


    }
}
