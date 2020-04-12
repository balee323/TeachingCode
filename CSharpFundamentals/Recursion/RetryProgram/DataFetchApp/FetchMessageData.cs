using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DataFetchApp
{
    public class FetchMessageData
    {


        public static Data FetchData()
        {
            var data = new Data();

            var status = GetConnectionStatus();

            if (status != 1)
            {
                return null;
            }
            else
                return data;

        }



        private static int GetConnectionStatus()
        {
            try
            {
                var random = new Random(DateTime.Now.Millisecond);
                var num = random.Next(1, 50);

                return num;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            return 0;
   
        }






    }
}
