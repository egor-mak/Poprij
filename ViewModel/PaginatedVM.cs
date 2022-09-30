using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poprij.ViewModel
{
    internal class PaginatedVM
    {
        public int PageNumber { get; set; }
        public int StartIndex { get; set; }
        public int RangeCountItem { get { return 20; } } 
        public int CountItem { get; set; }

        public PaginatedVM(int pageNum, int startIndex)
        {
            PageNumber = pageNum;
            StartIndex = startIndex;
        }

        public int GetTotalPage()
        {
            return (int)Math.Ceiling((decimal)CountItem / RangeCountItem);
        }

        public bool LessCountRangeItems
        {
            get
            {
                return (CountItem < RangeCountItem);
            }
        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageNumber <= GetTotalPage());
            }
        }

        public void GetIndex()
        {
            StartIndex = 0;

            if (HasPreviousPage && HasNextPage)
            {
                for (int i = 1; i < PageNumber; i++)
                {
                    StartIndex += RangeCountItem;
                }
            }
        }
    }
}
