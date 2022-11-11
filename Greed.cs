using Raylib_cs;
using System.Numerics;
class Greed{
    public void Play(){
        Screen screen = new Screen(480, 800);
        {var PlayerPosition = new Vector2(screen.ScreenHeight / 2, screen.ScreenWidth / 2);
        var Objects = new List<GameObject>();
        var Random = new Random();
        player Player1 = new player(Color.BLUE, 25);
        var Score = new Value(0);

        Raylib.InitWindow(screen.ScreenHeight, screen.ScreenWidth, "Greed");
        Raylib.SetTargetFPS(60);

        while (!Raylib.WindowShouldClose())
        {

            var whichType = Random.Next(50);

            var Position = new Vector2(Random.Next(screen.ScreenWidth), 0);

            switch (whichType){
                case 0: 
                    var gem = new Gem(Color.GREEN, 20, 15);
                    gem.position = Position;
                    gem.value = new Value(10);
                    gem.speed = new Vector2(0, 1);
                    Objects.Add(gem);
                    break;
                case 1:
                    var rock = new Rock(Color.RED, 20, -5);
                    rock.position = Position;
                    rock.value = new Value(-5);
                    rock.speed = new Vector2(0, 1);
                    Objects.Add(rock);
                    break;
                default:
                    break;
            }
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);
            Raylib.DrawFPS(380,10);
            Raylib.DrawText($"Score: {Score.value}", 80, 10, 20, Color.BLUE); 
            
            foreach (var obj in Objects){
                obj.Draw(); 
            }



            

            
            Player1.playermove(ref PlayerPosition);
            for (int i = 0; i < Objects.Count(); i++)
                if (Raylib.CheckCollisionRecs(Objects[i].Rect(), Player1.Rect(ref PlayerPosition))){
                    Score.Add(Objects[i].value);
                    Objects.Remove(Objects[i]);
                }

            Raylib.EndDrawing();

            foreach (var obj in Objects){
                obj.Move();
            }
        }

        Raylib.CloseWindow();
    }
}
}