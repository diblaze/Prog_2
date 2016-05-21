using System.Diagnostics;
using System.IO;
using System.Text;

namespace winHotelManagement
{
    public static class Receipt
    {
        /// <summary>
        /// Creates a very light and easy receipt in HTML.
        /// </summary>
        /// <param name="suiteNumber">The suite number.</param>
        /// <param name="checkInDate">The check in date.</param>
        /// <param name="fullName">The full name.</param>
        public static void CreateReceipt(int suiteNumber, string checkInDate, string fullName)
        {
            string receiptBody;
            //template to follow
            string template = Directory.GetCurrentDirectory() + "\\receipttemplate.html";

            using (var reader = new StreamReader(template))
            {
                //replace the remplate with real data.
                receiptBody = reader.ReadToEnd();
                receiptBody = receiptBody.Replace("<%Suite%>", suiteNumber.ToString());
                receiptBody = receiptBody.Replace("<%CheckInDate%>", checkInDate);
                receiptBody = receiptBody.Replace("<%FullName%>", fullName);
            }

            //write to file
            FileStream fs = File.OpenWrite(Directory.GetCurrentDirectory() + $"\\{fullName}-receipt.html");
            var writer = new StreamWriter(fs, Encoding.UTF8);
            writer.Write(receiptBody);
            writer.Close();

            //open file.
            Process.Start(Directory.GetCurrentDirectory() + $"\\{fullName}-receipt.html");
        }
    }
}