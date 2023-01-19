// 19.	Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y 
//!(X || Y)==!X && !Y

bool x, y, f1,f2;
x=true;
y=true;
Result(x,y);
x=true;
y=false;
Result(x,y);
x=false;
y=true;
Result(x,y);
x=false;
y=false;
Result(x,y);

void Result(bool x, bool y)
{
    bool f1,f2;
    f1=!(x || y);
    f2=!x && !y;
    System.Console.WriteLine($"при x={x} y={y} результат {f1==f2}");
}