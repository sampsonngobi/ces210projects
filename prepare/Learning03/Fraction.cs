using System;

public class Fraction
{
   private int _topNumber;
   private int _bottomNumber;

   public Fraction()
   {
    _topNumber = 1;
    _bottomNumber = 1;
   }


   public Fraction(int number)
   {
    _topNumber = number;
    _bottomNumber = 1;

   }

   public Fraction(int top, int bottom)
   {
    _topNumber = top;
    _bottomNumber = bottom;
   }

   public double getDecimalValue()
    {
        
        return (double)_topNumber / (double)_bottomNumber;
    }

    public string getFractionString()
    {
        string text = $"{_topNumber} / {_bottomNumber}";
        return text;
    }

//    public Fraction()
//    {
    
//     Console.WriteLine($"{_topNumber}/{_bottomNumber}");

//    }

//     public Fraction(int number)
//     {
//         _topNumber = number;
      
//         Console.WriteLine($"{_topNumber}/{_bottomNumber}");
//     }

//     public Fraction(int top, int bottom)
//     {
//         _topNumber = top;
//         _bottomNumber = bottom;
//         Console.WriteLine($"{_topNumber}/{_bottomNumber}");
//     }

    // public int getUpperNumber()
    // {
    //     return _topNumber;
    // }

    //  public void setUpperNumber(int topnumber)
    //  {
    //     _topNumber = topnumber;
    //  }

    // public int getLowerNumber()
    // {

    //     return _bottomNumber;
    // }

    //  public void setBottomNumber(int bottomnumber)
    //  {
    //     _bottomNumber = bottomnumber;
    //  }

    
   
}