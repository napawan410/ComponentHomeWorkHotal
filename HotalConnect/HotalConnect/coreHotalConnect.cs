using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalConnect
{
    public class coreHotalConnect
    {

         xmlHotalConnect infor = new xmlHotalConnect();

        public String getInformation(String hotalId) {
             return infor.getInformation(hotalId);
        }

        public String getRoomType(String hotalId) {
            
            return infor.getRoomType(hotalId);
        }
        public String getPrice(String hotalId) {
             return infor.getPrice(hotalId);
        }

        public int getAllotment(String hotalId) {
            return infor.getAllotment(hotalId);
        }

        public int getBooking(String hotalId  ,int book) {
            return infor.getBooking(hotalId, book);
        }

        public String showStatus(String hotalId, int book) {
            return infor.showStatus(hotalId,book);
        }
    }

}
