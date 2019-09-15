import java.io.*; 
import java.util.*; 
import java.util.Scanner;

//Yingcan Chen, Yichao Qin
public class Program {
	 public static ArrayList<ArrayList<String>> computed= new ArrayList<ArrayList<String>>();
	public static void main(String[] args) {
		// TODO Auto-generated method stub
     ArrayList<String> oneNode = new ArrayList<String>();
     oneNode.add("(.)");
   
     computed.add(oneNode);
     
     Scanner inp= new Scanner(System.in);
     System.out.println("Please enter the number of nodes");
     int userinput=inp.nextInt();
     Tree(userinput);
	}
public static void Tree(int n) {
	Tree_helper(n);
	int length= computed.size();
	computed.get(length-1).forEach((a) ->System.out.println(a));
	
}


public static void Tree_helper(int n) {
	if(n==1) {
		System.out.println("(.)");
	}
	else {
		int count=1;
		while (count<n) {
			ArrayList<String> newcomputationlist= new ArrayList<String>();
			int lastindex=computed.size()-1;
			ArrayList<String> lastlist= computed.get(lastindex);
			for(int i=0; i<=lastlist.size()-1; i++) {
				newcomputationlist.add("("+lastlist.get(i)+".)");
				newcomputationlist.add("(."+lastlist.get(i)+")");
			}
			if(count>=2) {
				int index=0;
				while(index<count-1) {
					System.out.println("hh");
					ArrayList<String> lefttree=computed.get(count-2-index);
					ArrayList<String> righttree=computed.get(index);
					for(int i=0; i<=lefttree.size()-1;i++) {
						for (int j=0; j<=righttree.size()-1;j++) {
							newcomputationlist.add("("+lefttree.get(i)+"."+righttree.get(j)+")");
							
						}
					}index=index+1;
				} 
			}
			computed.add(newcomputationlist);
			count=count+1;
		}
	}
}
}
