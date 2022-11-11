using Raylib_cs;
class Gem: ColorObject {
    public int Size { get; set; }

    public Gem(Color Color1, int size, int value): base(Color1){
        Size = size;
    }
    public override void Draw()
    {
        Raylib.DrawRectangle((int)position.X, (int)position.Y, Size, Size, Color);
    }
}