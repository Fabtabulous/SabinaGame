using System.Numerics;

namespace SabinaGame.Data;

public class SabinaGameBigIntStuff
{
	
	public  String bigIntegerWithComma(BigInteger value)
    {
        String bigIntWithComma = "";
        String stringNum = value.ToString();

        if (value > 99)
        {
            bigIntWithComma = stringNum.Insert(stringNum.Length - 2, ",");
        }

		else if (value > 9)
        {
            bigIntWithComma = "0," + stringNum;
        }


        else
        {
            bigIntWithComma = "0,0" + stringNum;
        }

        return bigIntWithComma;

	}


}
