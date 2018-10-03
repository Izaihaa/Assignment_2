﻿using System;
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
      StockList resultList = new StockList();

      // write your implementation here

      return resultList;
    }

    //param        : NA
    //summary      : finds the stock with most number of holdings
    //return       : stock with most shares
    //return type  : Stock
    public Stock MostShares()
    {
      //Stock mostShareStock = null;

            // write your implementation here

            /*
            StockNode current = this.head;
            StockNode previous = this.head;
            Stock currentStock = current.StockHolding;
            mostShareStock = currentStock;
            while (current != null)
            {
                if (currentStock.Holdings > mostShareStock.Holdings)
                {
                    mostShareStock = currentStock;
                }
                previous = current;
                current = current.Next;
            }
            */

            StockNode current = head;
            //StockNode previous = this.head;
            //Stock currentStock = current.StockHolding;
            //mostShareStock = currentStock;
            while (current.Next != null)
            {
                if (current.StockHolding.Holdings < current.Next.StockHolding.Holdings)
                {
                    current = current.Next;
    
                }
 
            }

            return current.StockHolding;
            //return mostShareStock;
    }

    //param        : NA
    //summary      : finds the number of nodes present in the list
    //return       : length of list
    //return type  : int
    public int Length()
    {
      int length = 0;

      // write your implementation here

      return length;
    }
  }
}