// See https://aka.ms/new-console-template for more information
using ICC;
Team teamIndia=new Team();
Player thePlayer=teamIndia[0];
//thePlayer.Name="Manish";
teamIndia[1]=new Player{Name="VVS Laxman",Score=89890};
//Player thePlayer1=teamIndia[1];
Console.WriteLine(thePlayer);