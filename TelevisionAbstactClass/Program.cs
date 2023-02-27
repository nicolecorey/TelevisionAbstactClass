abstract class Show
{
    // Property
    public abstract string Name { get; set; }
    public abstract string Genre { get; set; }
    // Methods
    public abstract string Display();
}
class Program
{
    class Comedy : Show
    {
        public override string Name { get; set; }
        public override string Genre { get; set; }
        public int Year { get; set; }
        public string Theme { get; set; }

        public Comedy()
        {
            Name = string.Empty;
            Year = 0;
            Theme = string.Empty;
            Genre = string.Empty;
        }
        public Comedy(string name, int year, string theme, string genre)
        {
            Name = name;
            Year = year;
            Theme = theme;
            Genre = genre;
        }

        public override string Display()
        {
            return "The genre of this show is " + Genre + "." + "\nThe name of this show is " + Name + "." + "\nThis show came out in " + Year + "." + "\nThe theme song of the show is " + Theme + ".";
        }

    }
    static void Main(string[] args)
    {

        Comedy friends = new Comedy();
        friends.Name = "Friends";
        friends.Year = 1994;
        friends.Theme = "I'll Be There For You";
        friends.Genre = "Sitcom";
        Console.WriteLine(friends.Display());

        Comedy seinfeld = new Comedy("Frasier", 1993, "Tossed Salad and Scrambled Eggs", "Sitcom");
        Console.WriteLine();
        Console.WriteLine(seinfeld.Display());
    }
}