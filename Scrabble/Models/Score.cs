using System;

namespace Score.Models
{
  public class Program
  {

  }
  public class Points
  {
    private string _word;

    public Points(string word)
    {
      _word = word;

    }

    public string CollectWord()
    {
      return _word;
    }

    public string LowerCase()
    {
      return _word.ToLower();
    }

    public char[] ConvertString(string word)
    {
      char[] result = word.ToCharArray();
      return result;
    }

  }
}
