namespace newWorkspace
{
    internal class Program
    {
public string FizzDivisible(int i)
{
string word="";

if(i%3==0)
{
    word="fizz";
}
if(i%5==0)
{
    word="buzz";
}
return word;
}
    }
}