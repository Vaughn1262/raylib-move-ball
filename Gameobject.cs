using Raylib_cs;
using System.Numerics;
class GameObject {

    public Value value = new Value(0);
    public Vector2 position { get; set; }  = new Vector2(0,0);
    public Vector2 speed { get; set; } = new Vector2(0,1);

    virtual public void Draw() {

    }

    public void Move() {
        Vector2 NewPosition = this.position;
        NewPosition.X += speed.X;
        NewPosition.Y += speed.Y;
        position = NewPosition;

    }

    public Rectangle Rect() {
        return new Rectangle(position.X, position.Y, 20, 20);
    }
    
}