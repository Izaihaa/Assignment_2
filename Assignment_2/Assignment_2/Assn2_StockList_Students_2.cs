using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_2
{
  public partial class StockList
  {
    //param   (StockList)listToMerge : second list to be merged 
    //summary      : merge two different list into a single result list
    //return       : merged list
    //return type  : StockList
    public StockList MergeList(StockList listToMerge)
    {
      //Already a part of the method
      StockList resultList = new StockList();
            resultList = this;
            

            // write your implementation here
            
            StockNode  currentNode = head;
            //StockNode secondNodeofList1 = head.Next;

            while (currentNode != null & listToMerge.head != null)
            {
                resultList.AddStock(listToMerge.head.StockHolding);
                listToMerge.head = listToMerge.head.Next; 
                currentNode = currentNode.Next;
            }
            


            /*
            StockNode current = this.head;
            StockNode previous = this.head;
            while (current != null)
            {
                Stock currentStock = current.StockHolding;
                resultList.AddStock(currentStock);
                previous = current;
                current = current.Next;
            }
            */



      //Already a part of the method  
      return resultList;
    }

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
            Stock mostShareStock = null;

            // write your implementation here

            //Set local variable "currentNode" Equal to FirstNode in the Stock List
            StockNode currentNode = head;

            //Set local variable "mostShareStock" equal to the current node as a starting value
            mostShareStock = currentNode.StockHolding;

           //Traverse the nodes in the list until we reach the end
            while (currentNode.Next != null)
            {
                //Check if holdings of mostShareStock is less than the next node in the list
                if (mostShareStock.Holdings < currentNode.Next.StockHolding.Holdings)
                {
                    //If it is less than the next node, the mostShareStock now becomes the next stock
                    currentNode = currentNode.Next;
                    mostShareStock = currentNode.StockHolding;
                }

                //Continue to advance down the list
                else currentNode = currentNode.Next;
 
            }

            return mostShareStock;
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
      int length = 0;

            // write your implementation here

            var current = this.head;
            while (current != null)
            {
                length++;
                current = current.Next;
            }


            return length;
    }
  }
}