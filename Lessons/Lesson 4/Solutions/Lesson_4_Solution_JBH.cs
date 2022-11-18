using System.Text.Json; //class for writing to json file

string rawData = File.ReadAllText("../../../data.nmea"); //this will open the nmea file if it is in the same directory as your program.cs
List<Data> data = new List<Data>(); //store all the parsed data here in this list

List<List<string>> datalist = new List<List<string>>(); // list declared to sort out data before addition to final list

for (int i = 0; i < rawData.Split('\n').Length; i++)
    {
        datalist.Add(new List<string>(((string[]?)rawData.Split('\n'))[i].Split(',', StringSplitOptions.RemoveEmptyEntries)));
    }

foreach (var (lineValue,lineIndex) in datalist.WithIndex()) 
{
    foreach (var (rowValue,rowIndex) in lineValue.WithIndex())  
    {
        
        if (rowValue == "$GNRMC")
        {
            string time = (datalist[lineIndex][1].Substring(0, 2) + ":" + datalist[lineIndex][1].Substring(2, 2) + ":" + datalist[lineIndex][1].Substring(4, 2) + "Z");
            int latDegree = 0, latMinute = 0, longDegree = 0, longMinute = 0;
            DateTime gnrmcTime;

            if (datalist[lineIndex][3].Length == 9) //latitude conversion to degrees 
            {
                latDegree = Convert.ToInt32(datalist[lineIndex][3].Substring(0, 2));
                latMinute = (Convert.ToInt32(datalist[lineIndex][3].Substring(2, 2) + datalist[lineIndex][3].Substring(5, 4))) / 60;
            }

            if (datalist[lineIndex][5].Length == 10) //longitude conversion to degrees 
            {
                longDegree = Convert.ToInt32(datalist[lineIndex][5].Substring(0, 3));
                longMinute = (Convert.ToInt32(datalist[lineIndex][5].Substring(2, 3) + datalist[lineIndex][5].Substring(6, 4)) / 60);
            }

            if (DateTime.TryParse(time, out gnrmcTime))
                Console.WriteLine(gnrmcTime);

            data.Add(
                new Data()
                {
                    lat = (latDegree.ToString() + "." + latMinute.ToString() + "N"),
                    lon = (longDegree.ToString() + "." + longMinute.ToString() + "W"),
                    time = gnrmcTime.ToString().Substring(11,8),
                    type = datalist[lineIndex][0]
                });
        }

        else if (rowValue == "$GNGGA")
        {
            string time = (datalist[lineIndex][1].Substring(0, 2) + ":" + datalist[lineIndex][1].Substring(2, 2) + ":" + datalist[lineIndex][1].Substring(4, 2) + "Z");
            int latDegree = 0, latMinute = 0, longDegree = 0, longMinute = 0;
            DateTime gnggaTime;

            if (datalist[lineIndex][2].Length == 9) //latitude conversion to degrees 
            {
                latDegree = Convert.ToInt32(datalist[lineIndex][2].Substring(0, 2));
                latMinute = Convert.ToInt32(datalist[lineIndex][2].Substring(2, 2) + datalist[lineIndex][2].Substring(5, 3));
                latMinute = (latMinute / 60);
            }

            if (datalist[lineIndex][4].Length == 10) //longitude conversion to degrees 
            {
                longDegree = Convert.ToInt32(datalist[lineIndex][4].Substring(0, 3));
                longMinute = (Convert.ToInt32(datalist[lineIndex][4].Substring(2, 3) + datalist[lineIndex][4].Substring(6, 4)) / 60);
            }

            if (DateTime.TryParse(time, out gnggaTime))

            data.Add(
                new Data()
                {
                    lat = (latDegree.ToString() + "." + latMinute.ToString() + "N"),
                    lon = (longDegree.ToString() + "." + longMinute.ToString() + "W"),
                    time = gnggaTime.ToString().Substring(11,8),
                    type = datalist[lineIndex][0]
                });
        }
    }
}

var sortedByTime = data.OrderBy(x => x.time); // sorting list by time

string json = JsonSerializer.Serialize(sortedByTime, new JsonSerializerOptions { WriteIndented = true }); 
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

public static class EnumExtension //using to find index inside of foreach loops 
{
    public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self)
       => self.Select((item, index) => (item, index));
}