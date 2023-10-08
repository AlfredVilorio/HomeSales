using System;

class Program {
  public static void Main (string[] args) {
  // Initialize variables : d, e, f, and Total
  int d = 0;
  int e = 0;
  int f = 0;
  int Total = 0;
  
  //Gives initial to the highest salesperson
  string HighestTotalSalesPerson = " ";
  
 

  //Loop infinitely
    while(true)
    {
  // Displays input for a salespersons initial specifically d, e, f, z 
      
  Console.WriteLine("Please enter salespersons initial : ");
    string Initial = Console.ReadLine();
      
  //When Initial or input is z, it displays sales total of d, e, f, grandTotal, initial of the salesperson with highest total and exits loop
     if (Initial == "z")
      {
        
  //num1, num2, num3 for calculations for grandTotal
  int num1 = d;
  int num2 = e;
  int num3 = f;
  int grandTotal = d + e + f;
      
      Console.WriteLine("Sales total for Danielle : $" + d);
      Console.WriteLine("Sales total for Edward : $" + e);
      Console.WriteLine("Sales total for Francis : $" + f);
      Console.WriteLine("Grand Total:  $" + $"{grandTotal}");
      Console.WriteLine("The Salesperson with the highest total is:  " + HighestTotalSalesPerson);
        break;

        
     }
    //If input or Initial is not d, e, or f display error
      {if (Initial != "d" && Initial != "e" && Initial != "f")
           Console.WriteLine("Invalid Initial");
        
        //if input or Initial is correct enter sales amount for the Initial
         else {
              Console.WriteLine($"Enter sales amount for {Initial}: ");
           
           // Conversion of int from string
               if (int.TryParse(Console.ReadLine(), out int Saleamount)){
      
   //If Initial is d, e, or f increase value by Saleamount
     
              if (Initial == "d")
                 {
                   
                d += Saleamount;
                   
            } else if (Initial == "e") 
                 
                 {
                   
                e += Saleamount;
                   
            } else 
                 {
                   
                f += Saleamount;
                   
            }
           // if the Saleamount is greater or equal to Total and its not z 
      if (Saleamount >= Total && Initial != "z")
            
                 
        //make int Total equal Saleamount with High Total = d, e, f, and not z    
                 {
        Total = Saleamount;
        HighestTotalSalesPerson = Initial;}
                 
                  }

           }
       // Determines the salesperson with the Highest Total
         if(d > e && d > f){
          Total = d;
          HighestTotalSalesPerson = "d";
          }
        
        if(e > d && e> f){
          Total = e;
          HighestTotalSalesPerson = "e";
          }
        if(f > d && f > e){
          Total = f;
          HighestTotalSalesPerson = "f";
         
          }
         }               
      }  
     }
  }
  
    


  
  


     
   

       

      
      
    
  

    
  

    
  

    

        
          
          
      
      
          
    
      
  
    
  
      
      
  
      
   
     
  
  
