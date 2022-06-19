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
		Kunstwerke kunstwerke = new Kunstwerke();
		properties.Add(kunstwerke);
		Assistenten assistenten = new Assistenten();
		properties.Add(assistenten);
		Stuff stuff = new Stuff();
		properties.Add(stuff);
		Werbung werbung = new Werbung();
		properties.Add(werbung);


	}
}
