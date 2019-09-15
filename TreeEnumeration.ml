
let rec tree n lefttree righttree middle=
	if (n == 1 && (String.length middle ==0)) then print_endline (lefttree^"(.)"^righttree^middle)
	else if (n == 1 && (String.length middle !=0)) then print_string (lefttree^"(.)"^righttree^middle)
	else for i = 0 to (n-1) do
			if (i >=1 && (n-1-i) >= 1) then
			for j = 1 to (n-2) do
			tree j (lefttree^"(") "" ".";
			tree (n-1-j) "" (")"^righttree) "";
			done
			else if (i > 0 && (n-1-i) == 0) then tree i (lefttree^"(") (".)"^righttree) middle
			else if (i == 0 && (n-1-i) > 0) then tree (n-1-i) (lefttree^"(.") (")"^righttree) middle
						done;;

let main () =
	print_string "\n";
	tree (int_of_string Sys.argv.(1)) "" "" "";;

main ();;
