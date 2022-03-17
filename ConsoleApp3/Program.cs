using System.Net;
using System.Text;



string myURL = "https://api.tvmaze.com/search/shows?q=Glee";

HttpWebRequest HttpWReq = 
    (HttpWebRequest)WebRequest.Create(myURL);


HttpWebResponse HttpWResp = (HttpWebResponse)HttpWReq.GetResponse();
Stream receiveStream = HttpWResp.GetResponseStream();


Encoding encode = Encoding.GetEncoding("utf-8");



StreamReader readStream = new StreamReader(receiveStream, encode);
Char[] read = new Char[256];

int count = readStream.Read( read, 0, 256);

while (count > 0)
{
    String str = new String(read, 0, count);
    Console.Write(str);
    count = readStream.Read(read, 0, 256);
}

Console.WriteLine("");

readStream.Close();

HttpWResp.Close();



