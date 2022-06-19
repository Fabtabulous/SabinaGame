using System.Numerics;

namespace SabinaGame.Data;

public class SabinaGameState
{
	public DateTime lastOpened { get; set; }

	public long tick { get; set; }

	public BigInteger kunstwerke { get; set; }

    public BigInteger fähigkeit { get; set; }

    public BigInteger assistenten { get; set; }

	public BigInteger assistentenGehalt { get; set; }

	public BigInteger rekrutierer { get; set; }



	
}
