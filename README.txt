To compile and run use command:
Python: python3 TreeEnumerationDp.py N  where N is an integer stands for number of nodes
Ocaml: ocaml TreeEnumeration.ml N where N is an integer stands for number of nodes
C#: csc Program.cs then Program

For swift,Java, and C# we use iteration because we find it easier for us. These languages work almost the same so after we finished Python version, the rest two only need switch some keywords. C# has no global variable so we use a class to store all computed layouts. The computed layout is a set of set of strings and is part of our design of dynamic programming. After computing layout the T(n) tree we store it so next time when we need it we do not need to redo all the works. The other languages  do not have a good iteration function. So we are forced to write recursive functions. 

For Ocaml version T(1) to T(3) works perfectly. From T(4) we had some issue with formatting. A sample output is
(.(.(.(.))))
(.(.((.).)))
(.((.).(.)))
(.((.(.)).))
(.(((.).).))
((.).(.(.)))
((.).))
((.(.)).(((.).).(.))
((.).(.(.)))
((.).))
((.(.)).(((.).).(.))
((.(.(.))).)
((.((.).)).)
(((.).(.)).)
(((.(.)).).)
((((.).).).)

These includes all correct layouts of binary tree, but for cases like the root node has both left and right childrens, it only prints left tree once. If there are many layouts for right trees, it only prints those right tree layouts not full trees. 
((.).(.(.))) and ((.).((.).))) share same left tree but after printing ((.).(.(.))) the next case it prints only have ((.).)).
Same thing happens to ((.(.)).(((.).).(.)) . We noticed what in our algroithum caused this but after trying 10 hours we still could not get it perfectly. The output also has some dupulicate layouts but it only hanppens to root node has both left and right childrens. We realized that a function in Ocaml could only have one returned expression. In our case, it is unit. So it is hard to do assigning left tree to left and right tree to right. We took the approch that each time the node is about to make leftchild, it must have a layout: left + ( and .) +right. If it is about to make right child then  left + (. and ) +right
