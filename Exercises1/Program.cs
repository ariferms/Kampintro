using System;

namespace Exercises1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.playTeam = "Galatasayar";
            player1.name = "Arda Turan";
            player1.position = "Orta Saha, Kanat";
            player1.skills = "Liderlik, Çalım, Adam Eksiltme";
            player1.playerPuan = 87;


            Player player2 = new Player();
            player2.playTeam = "Milan";
            player2.name = "Hakan Çalhanoğlu";
            player2.position = "Kanat, Orta Saha";
            player2.skills = "Şut, Frikik, Bitiricilik, Koner";
            player2.playerPuan = 86;


            Player player3 = new Player();
            player3.playTeam = "Lechester City";
            player3.name = "Cengiz Ünder";
            player3.position = "Kanat";
            player3.skills = "Şut, Patlama Gücü, Frikik, Korner, Bitiricilik";
            player3.playerPuan = 85;


            Player player4 = new Player();
            player4.playTeam = "Juventus";
            player4.name = "Merih Demiral";
            player4.position = "Defans";
            player4.skills = "Sert, İkili Mücadele, Topa Basma, Hava Topları";
            player4.playerPuan = 81;



            Player[] players = new Player[] 
            {
                player1, player2, player3, player4
            };


            int i = 1;
            foreach (Player ply in players)
            {
                    Console.WriteLine(i + ") " + ply.playTeam);
                    Console.WriteLine("Player Name: " + ply.name);
                    Console.WriteLine("Player Puan: " + ply.playerPuan);
                    Console.WriteLine("Position: " + ply.position);
                    Console.WriteLine("Skils: " + ply.skills);
                    Console.WriteLine();
                i++;
            }


            //Console.WriteLine(player1.name + ": " + player1.playerPuan);
            //Console.WriteLine(player1.position);
            //Console.WriteLine(player1.skills);
            Console.WriteLine("Son Hali...");
        }
    }

    class Player
    {
        public string playTeam { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string skills { get; set; }
        public int playerPuan { get; set; }
    }

}
