using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


    var DB1 = new DragonBall ( "Goku", "UltraInstinct","Son",32 );
    var DB2 = new DragonBall("Vegeta", "SuperSaiyanGod", "Vegeta", 29);
//DB1.Names();
//DB2.Names();


    DB1.Moves.Add(new Finish("KameHameHa"));
    DB1.Moves.Add(new Attack("InstantHit"));

    DB2.Moves.Add(new Finish("FinalFlash"));
    DB2.Moves.Add(new Attack("FlashBeam"));

List<DragonBall> DBCharacters = [DB1,DB2];
foreach (var DBC in DBCharacters)
{
    Console.WriteLine( $"{DBC}" );
    foreach (var move in DBC.Moves)
    {
        Console.WriteLine($"      {move}"); 
    }
}

    Console.WriteLine(DBCharacters.Count);

    public class DragonBall(string DragonBallname, string Saiyanlevel, string Family, int wins)
    {

        public string DBname { get; } = DragonBallname;

        public string Slevel { get; } = Saiyanlevel;

        public string Family { get; } = Family;

        public int wins { get; } = wins;

        public List<Move> Moves { get;} = new ();

    }

//public void Names()
//{
//    Console.WriteLine(DBname);
//}
public abstract class Move (string name)
    {
        public string Name { get; } = name;
        public abstract string Action();
        public override string ToString()
        {
            return $"The {GetType().Name} of  is {name}";
        }
    }

    public class  Finish (string name) : Move (name)
    {
        public override string Action() => "Kills";

    }

    public class Attack (string name) : Move (name)
    {
        public override string Action() => "Attacks";
    }




