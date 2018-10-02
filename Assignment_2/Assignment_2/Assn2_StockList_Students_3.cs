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
            //Stock stock = new Stock();
            StockNode currentNode = head;

            while (currentNode != null)
            {
                value = (currentNode.StockHolding.Holdings * currentNode.StockHolding.CurrentPrice) + value;
                currentNode = currentNode.Next;
                //return value;
                
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
            StockList stocklist = new StockList();

            while (stocklist.head != null && listToCompare.head != null && stocklist.head.StockHolding == listToCompare.head.StockHolding)
            {
                stocklist.head = stocklist.head.Next;
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
