class Value{
    public int value{get; set;}

    public Value(int v){
        value = v;
    }
    public int Add(Value value1){
       return  this.value += value1.value;
    }
}