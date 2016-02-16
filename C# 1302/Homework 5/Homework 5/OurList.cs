using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Homework #5: Michael Banks
 * Adds a Find Method to the Linked List Class. The method returns Ture if the value is on the linked list.
 * 
 */ 

namespace Homework_5
{
        class Program
        {
            static void Main(string[] args)
            {
                OurList myList = new OurList();
                for (int i = 0; i < 10; i++)
                    myList.PushBack(i);
                    myList.Display();
      
                Console.WriteLine("The 5th value on the list is {0}", myList.GetNthValue(5));
                myList.Clear();
                for (int i = 0; i < 10; i++)
                   myList.PushBack(i);

               myList.Display();
               Console.WriteLine("The 6th value on the list is {0}", myList.GetNthValue(6));
               myList.Clear();
               for (int i = 0; i < 10; i++)
                   myList.PushBack(i);

                myList.Display();
                Console.WriteLine("The 12th value on the list is {0}", myList.GetNthValue(12));

                Console.WriteLine();
                Console.WriteLine("Press any key to continue ...");
                Console.ReadKey();
            }
        }

        public class OurList
        {
            private class OurListNode
            {
                public double mData { get; set; }
                public OurListNode mNext { get; set; }
                public OurListNode(double d = 0, OurListNode ln = null)
                {
                    mData = d;
                    mNext = ln;
                }
            }

            public bool GetNthValue(double number)
            {
                while (mFirst != null)
                {
                    if (mFirst.mData == number)
                    {
                        return true;
                    }
                    mFirst = mFirst.mNext;
                }
                                
                return false;
                
            }

            
            private OurListNode mFirst;

            public OurList()     // shown in class notes
            {
                mFirst = null;
            }

            public void Clear()     // shown in class notes
            {
                mFirst = null;
            }

            public void PushFront(double number)     // shown in class notes
            {
                mFirst = new OurListNode(number, mFirst);
            }

            public void PopFront()     // shown in class notes
            {
                if (mFirst != null)
                    mFirst = mFirst.mNext;
            }

            public void PushBack(double number)     // shown in class notes
            {
                if (mFirst == null)
                    PushFront(number);
                else
                {
                    OurListNode mTmp = mFirst;
                    while (mTmp.mNext != null)
                        mTmp = mTmp.mNext;

                    mTmp.mNext = new OurListNode(number, null);
                }
            }

            public void PopBack()     // shown in class notes
            {
                if (mFirst == null)
                    return;
                else if (mFirst.mNext == null)
                    PopFront();
                else
                {
                    OurListNode pTmp = mFirst;
                    while (pTmp.mNext != null && pTmp.mNext.mNext != null)
                        pTmp = pTmp.mNext;

                    pTmp.mNext = null;
                }
            }

            public void Display()     // shown in class notes
            {
                OurListNode pTmp = mFirst;
                while (pTmp != null)
                {
                    Console.Write("{0}, ", pTmp.mData);
                    pTmp = pTmp.mNext;
                }
                Console.WriteLine();
            }

            public bool isEmpty()     // shown in class notes
            {
                if (mFirst == null)
                    return true;
                else
                    return false;
            }
            public OurList(OurList aList)   // a Deep copy
            {
                mFirst = null;
                OurListNode pCopy = aList.mFirst;

                while (pCopy != null)
                {
                    PushBack(pCopy.mData);
                    pCopy = pCopy.mNext;
                }
            }
        }
    }

