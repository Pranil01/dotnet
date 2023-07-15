namespace ICC;


public class Team {

private List<Player>_Players=new List<Player> ();

public Team(){


this._Players.Add(new Player{ Name="Sumedh", Score=60000});
this._Players.Add(new Player{ Name="Sujit", Score=70000});
this._Players.Add(new Player{ Name="Pranil", Score=65000});




}

//Indexer

public Player this [int index]{

    get{return this._Players[index];}
    set{this._Players[index]=value;}
}




}