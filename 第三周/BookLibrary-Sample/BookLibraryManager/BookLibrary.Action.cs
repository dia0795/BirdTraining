using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibraryManager
{
    public partial class BookLibrary
    {
        public BookItem CreateBookItem(string masterId, decimal? price, string currentState = "可借用")
        {
            BookMaster bookMaster = this.BookMasters.Where(p => p.MasterId == masterId).FirstOrDefault();
            if (bookMaster == null || price < 0)
            {
                return null;
            }
            return CreateBookItem(bookMaster, price, currentState);
        }
        public BookItem CreateBookItem(BookMaster master, decimal? price, string currentState = "可借用")
        {
            BookItem bookItem = new BookItem();
            bookItem.BookMaster = master;
            bookItem.Price = price;
            bookItem.CurrentState = currentState;
            bookItem.BuyDate = DateTime.Now;
            bookItem.BookId = new Guid().ToString();
            this.BookList.Add(bookItem);
            return bookItem;
        }
        /// <summary>
        /// 一次性创建多本内容相同的书
        /// </summary>
        /// <param name="master">BookMaster,书的定义</param>
        /// <param name="bookPrice">书的价格</param>
        /// <param name="buyBookCount">买入书的数量</param>
        /// <param name="currentState">书当前的状态</param>
        /// <returns>创建出来的书</returns>
        public List<BookItem> CreateBookItems(BookMaster master, decimal? bookPrice, int buyBookCount, string currentState = "可借用")
        {
            List<BookItem> result = new List<BookItem>();
            for (int i = 0; i < buyBookCount; i++)
            {
                var item = CreateBookItem(master, bookPrice, currentState);
                result.Add(item);
            }
            return result;
        }

        public List<BookMaster> QueryBookMaster(string bookName)
        {
            return this.BookMasters.Where(p => p.Name.Contains(bookName)).ToList();
        }

        public List<BookMaster> GetAllBookMaster()
        {
            return BookMasters;
        }

        public List<BookItem> GetCurrentBookByUserId(string userId)
        {
            return this.BorrowLogList
                .Where(p => p.Borrower.UserId == userId)
                .Select(p => p.BookItem)
                .Distinct()
                .OrderByDescending(p => p.Price)
                .ToList();
        }
    }
}
