using System.Diagnostics;

namespace RandomHackerRank
{
    public class DrawingBook
    {
        int bookSize = 5;
        int pagenumber = 4;
        int currentPageNumber = 0;
        public void GetInputs()
        {
           var data = ((bookSize / 2) >= pagenumber) ? StartFromBeginning(0) : StartFromEnd(0);
        }

        public int StartFromBeginning(int startPoint)
        {
            currentPageNumber = 1;
            while (startPoint < bookSize)
            {
                if (currentPageNumber >= pagenumber)
                {
                    Debug.WriteLine(startPoint);
                    break;
                }
                currentPageNumber = currentPageNumber + 2;
                startPoint++;
            }
            return startPoint;
        }
        public int StartFromEnd(int startPoint)
        {
            currentPageNumber = bookSize;
            while (startPoint < bookSize)
            {
                if (currentPageNumber % 2 == 0 && currentPageNumber == bookSize)
                {
                    currentPageNumber--;
                }
                if (currentPageNumber <= pagenumber)
                {
                    Debug.WriteLine(startPoint);
                    break;
                }
                currentPageNumber = currentPageNumber - 2;
                startPoint++;
            }
            return startPoint;
        }
        
        
    }
}
