using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param        : NA
    //summary      : Calculate the value of each node by multiplying holdings with price, and returns the total value
    //return       : total value
    //return type  : decimal
    public decimal Value()
    {
      decimal value = 0.0m;

            // write your implementation here

            //Create a temporary node for use in this method from the "Head" node.
            StockNode currentNode = head;

            //Go through the nodes one by one to calculate the Value of each stock and add it to the previous value. 
            //Do this until you reach the "Null" node (end of the list)
            while (currentNode != null)//Go through the nodes one by one to calculate the Value of each stock and add it to the previous value. 
            {
                value = (currentNode.StockHolding.Holdings * currentNode.StockHolding.CurrentPrice) + value;
                currentNode = currentNode.Next; 
            }
            return value;
    }

    //param  (StockList) listToCompare     : StockList which has to comared for similarity index
    //summary      : finds the similar number of nodes between two lists
    //return       : similarty index
    //return type  : int
    public int Similarity(StockList listToCompare)
    {
      int similarityIndex = 0;

            // write your implementation here
            StockList tempStockList = new StockList();
            //tempStockList = this;
            
            while (tempStockList.head != null && listToCompare.head != null)
            {
                
                if (tempStockList.head.StockHolding.Symbol == listToCompare.head.StockHolding.Symbol)
                {
                   // listToCompare.head = listToCompare.head.Next;
                    similarityIndex++;
                }

                
                


                tempStockList.head = tempStockList.head.Next;
                listToCompare.head = listToCompare.head.Next;
                similarityIndex++;

    
            }
          
            return similarityIndex;
    }

    //param        : NA
    //summary      : Print all the nodes present in the list
    //return       : NA
    //return type  : NA
    public void Print()
    {



            // write your implementation here
            StockNode current = head;
            while (current != null)
            {
                Console.WriteLine(current.StockHolding);
                current = current.Next;
            }

        }

    }

  }
