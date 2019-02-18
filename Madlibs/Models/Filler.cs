using Madlibs.Controllers;

namespace Madlibs.Models
{
  public class Filler
  {
    private string Adj1;
    private string Adj2;
    private string Noun1;
    private string Noun2;
    private string Verb1;
    private string Verb2;
    private string Adverb;

    public Filler(string adj1, string adj2, string noun1, string noun2, string verb1, string verb2, string adverb)
    {
      Adj1 = adj1;
      Adj2 = adj2;
      Noun1 = noun1;
      Noun2 = noun2;
      Verb1 = verb1;
      Verb2 = verb2;
      Adverb = adverb;
    }

    public string GetAdj1()
    {
      return Adj1;
    }

    public string GetAdj2()
    {
      return Adj2;
    }

    public string GetNoun1()
    {
      return Noun1;
    }

    public string GetNoun2()
    {
      return Noun2;
    }

    public string GetVerb1()
    {
      return Verb1;
    }

    public string GetVerb2()
    {
      return Verb2;
    }

    public string GetAdverb()
    {
      return Adverb;
    }
  }
}
