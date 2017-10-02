Algorithms made to run in the console and can be run on a Mac using Mono.

To run individual files on Mac with Mono (where the file has its own Main method and doesn't reference any other files):
  - In terminal navigate to the folder that contains the file you want to run
  - type 'mcs ****FileName****.cs' to compile into a .exe file
  - type 'mono ****FileName****.exe' to run

To run multiple files in one namespace (i.e. singly linked lists which has a Tester file with the Main entry method to test all SLL namespace methods)
  - type 'mcs -out:SLLTester.exe *.cs' to compile 
  - type 'mono SLLTester.exe' to run it
