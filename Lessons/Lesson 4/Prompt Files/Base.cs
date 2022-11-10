using System.Text.Json; //class for writing to json file

string rawData = File.ReadAllText("../../../data.nmea"); //this will open the nmea file if it is in the same directory as your program.cs
List<Data> data = new List<Data>(); //store all the parsed data here in this list


//this is how you make a new Data and store it in the data list. Please remove this frop your final code
data.Add(
    new Data()
    {
        lat = "0",
        lon = "0",
        time = "00:00:00",
        type = "GNRMC or GNGGA"
    });
//EXAMPLE HOW TO USE DATA CLASS AND STORE IT ^^


/*
 * you code here
 * 
 * 
 * 
 * 
 * 
 * 
 */



string json = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
File.WriteAllText("../../../Data.json", json);


public class Data : IComparable<Data> //data is what you will write to the JSON file
{
    public string lat { init; get; }
    public string lon { init; get; }
    public string time { init; get; }
    public string type { init; get; }

    public Data() { }

    public int CompareTo(Data? other)
    {
        return DateTime.Compare(DateTime.Parse(String.Format("03/01/2009 {0} -5:00", time)), DateTime.Parse(string.Format("03/01/2009 {0} -5:00", other.time)));
    }
}//ignore this clas, you use it to store data