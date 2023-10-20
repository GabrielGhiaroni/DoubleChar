public class Kata
{
  public static string DoubleChar(string s)
  {
    string novaString =  string.Empty;
    int repeticoes = 2;
    
    foreach (char caractere in s) {
      for(int i = 0; i < repeticoes; i++) {
        novaString += caractere;
      }
    }
    
    return novaString;
  }
}
