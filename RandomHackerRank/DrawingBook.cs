using System.Diagnostics;

namespace RandomHackerRank
{
    public class DrawingBook
    {
        public int BookSize { get; set; }
        public int PageNumber { get; set; }
        int currentPageNumber = 0;
        int startPoint = 0;
        
        public int PageTurningPoint(int bookSize, int pagenumber)
        {
            BookSize = bookSize;
            PageNumber = pagenumber;

           return ((bookSize / 2) >= pagenumber) ? StartFromBeginning() : StartFromEnd();
        }

        public int StartFromBeginning()
        {
            currentPageNumber = 1;
            while (startPoint < BookSize)
            {
                if (currentPageNumber >= PageNumber)
                {
                    break;
                }
                currentPageNumber = currentPageNumber + 2;
                startPoint++;
            }
            return startPoint;
        }
        public int StartFromEnd()
        {
            currentPageNumber = BookSize;
            while (startPoint < BookSize)
            {
                if ((PageNumber % 2 == 0 && currentPageNumber - 1 <= PageNumber)
                    || currentPageNumber <= PageNumber)
                {
                    break;
                }
                currentPageNumber = currentPageNumber - 2;
                startPoint++;
            }
            return startPoint;
        }
        
        
    }
}
