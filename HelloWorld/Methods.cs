using System.Diagnostics.CodeAnalysis;

class Methods{
    //say hello method
    public void SayHello()=>
        Console.WriteLine("say hello");

        // pass greeting as a arguments and overloading method
        public void SayHello(String greeting)=>
        Console.WriteLine("greeting");

        //captilize greeting msg and return to caller
        public string SayHello(string greeting,string details)=>
        $"{greeting.ToUpper()}\n{details}" ;

       // Get average of all numbers provided (Using variable number of arguments) 
  public float GetAverage(params int[] numbers)
    {
        int sum = 0;
        
        foreach(var num in numbers)
        {
            sum += num;
        }

        var a = (float)sum / numbers.Length;
        return a;
    }

   // Modify above method to return sum and average (Using tuples)
    public (int,float) GetResults(params int[] numbers)
    {
        int sum=0;
         foreach(var num in numbers)
        {
            sum += num;
        }

        var a = (float)sum / numbers.Length;
        return (sum,a);
    }

}