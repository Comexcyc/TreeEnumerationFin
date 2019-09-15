//Yingcan Chen Yichao Qin
using System;
using System.Collections;
using System.Collections.Generic;
namespace binarycode
{
    public static class Globals{
        public static List<List<string>> computed=new List<List<string>>();
    }
    class Program
    {
        static void Main(string[] args)
        {
           // List<string> computed= new List<string>();
            List<string>  oneNode= new List<string>();
            oneNode.Add("(.)");
           // oneNode.ForEach(Console.WriteLine);
            Globals.computed.Add(oneNode);
            Globals.computed.ForEach(Console.WriteLine);
            //Console.WriteLine("Hello World!");
            string val;
            Console.WriteLine("Enter number of tree nodes:");
            val=Console.ReadLine();
            int inp=Convert.ToInt32(val);
            Tree(inp);
        }
 
public static void Tree(int n){
    
    Tree_helper(n);
 int length=Globals.computed.Count;
 Globals.computed[length-1].ForEach(Console.WriteLine);
}

public static void Tree_helper(int n){
   if(n==1){
Console.WriteLine("(.)");
}
else{
    int count=1;
    while (count<n){
        List<string> newcomputationlist= new List<string>();
       int lastindex = Globals.computed.Count-1;
        List<string> lastlist= Globals.computed[lastindex];
        for(int i=0; i<=lastlist.Count-1; i++){
            newcomputationlist.Add("("+lastlist[i]+".)");
            newcomputationlist.Add("(."+lastlist[i]+")");
        
        }
        if(count>=2){
            int index=0;
            while (index < count-1){
                //Console.WriteLine("HH");
                List<string> lefttree= Globals.computed[count-2-index];
                List<string> righttree= Globals.computed[index];
                for(int i=0; i<=lefttree.Count-1; i++){
                    for(int j=0; j<=righttree.Count-1; j++){
                    newcomputationlist.Add("("+lefttree[i]+"."+righttree[j]+")");


                    }
                    


                }
                index=index+1;
            }

        }

        Globals.computed.Add(newcomputationlist);
count=count+1;
    }
}
}


    }
}
