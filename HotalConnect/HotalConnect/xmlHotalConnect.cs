using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotalConnect
{

    //Napawan Jindamanee SE5630213002
    class xmlHotalConnect
    {
        String xmlFile = "D:/การเรียน/ปี3เทอม 1/ปี3เทอม 1/Component based/การบ้าน/HotalConnect/HotalConnect/hotal.xml";

       public String getInformation (String hotalId) {

           string newInfor = "Not fond";

           XDocument xmlHotal = XDocument.Load(xmlFile);
           var hotals = from Hotal in xmlHotal.Descendants("Hotal")
                        where Hotal.Attribute("HotalID").Value == hotalId
                        select new
                        {
                            infor = Hotal.Element("Information").Value
                        };


           foreach(var show in hotals)
           {
               newInfor = show.infor.ToString();
           }
             return newInfor;
       }


       public String getRoomType(String hotalId) 
       {
           string newInfor = "Not fond";

           XDocument xmlHotal = XDocument.Load(xmlFile);
           var hotals = from Hotal in xmlHotal.Descendants("Hotal")
                        where Hotal.Attribute("HotalID").Value == hotalId
                        select new
                        {
                            infor = Hotal.Element("RoomType").Attribute("Type").Value
                        };


           foreach (var show in hotals)
           {
               newInfor = show.infor.ToString();
           }
           return newInfor;
       
       }

       public String getPrice(String hotalId)
       {
           string newInfor = "Not fond";

           XDocument xmlHotal = XDocument.Load(xmlFile);
           var hotals = from Hotal in xmlHotal.Descendants("Hotal")
                        where Hotal.Attribute("HotalID").Value == hotalId
                        select new
                        {
                            infor = Hotal.Element("RoomType").Element("Price").Value
                        };


           foreach (var show in hotals)
           {
               newInfor = show.infor.ToString();
           }
           return newInfor;
       }

       public int getAllotment(String hotalId) {

           int newInfor = 0;
           XDocument xmlHotal = XDocument.Load(xmlFile);
           var hotals = from Hotal in xmlHotal.Descendants("Hotal")
                        where Hotal.Attribute("HotalID").Value == hotalId
                        select new
                        {
                            infor = Hotal.Element("RoomType").Element("Allotment").Value
                        };


           foreach (var show in hotals)
           {
               newInfor = Int32.Parse(show.infor);
           }
           return newInfor;
       
       }

       public int getBooking(String hotalId,int book)
       {
           int amount = this.getAllotment(hotalId) - book;
           String newInfor = null;
           //if (num > 0)
          // {
               XDocument xmlHotal = XDocument.Load(xmlFile);
               var hotals = from Hotal in xmlHotal.Descendants("Hotal")
                            where Hotal.Attribute("HotalID").Value == hotalId
                            select Hotal.Element("RoomType");


               foreach (XElement hota in hotals)
               {
                   hota.SetElementValue("Allotment", amount.ToString());
               }
               xmlHotal.Save(xmlFile);
               //newInfor = "Complete";
          // }
          // else 
         //  {
          //     newInfor = "I’m sorry. All rooms are taken.";
          // }
           return amount;
       }

       public String showStatus(String hotalId, int book)
       {

           int amount = this.getAllotment(hotalId) - book;
           String newInfor = null;
           if (amount > 0)
            {
           XDocument xmlHotal = XDocument.Load(xmlFile);
           var hotals = from Hotal in xmlHotal.Descendants("Hotal")
                        where Hotal.Attribute("HotalID").Value == hotalId
                        select Hotal.Element("RoomType");


           foreach (XElement hota in hotals)
           {
               hota.SetElementValue("Allotment", amount.ToString());
           }
           xmlHotal.Save(xmlFile);
          newInfor = "Complete";
           }
           else 
             {
                newInfor = "I’m sorry. All rooms are taken.";
            }
           return newInfor;
       
       }
    }
}
