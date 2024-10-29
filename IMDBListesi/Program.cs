List<Movies> movies = new List<Movies>();//Creating movies list
string check;

do
{
    Console.WriteLine("Lutfen film ismi giriniz:");
    string name = Console.ReadLine();

    Console.WriteLine("Filmin Imdb puanini giriniz:");
    double points;
    while (!double.TryParse(Console.ReadLine(), out points) || points < 0 || points > 10)//Checking the points between 0-10
    {
        Console.WriteLine("Lütfen geçerli bir IMDB puanı girin (0-10 arası):");
    }
    movies.Add(new Movies(name, points));//Adding the points and name the list

    Console.Write("Başka bir film eklemek ister misiniz? (Evet/Hayır): ");
    check = Console.ReadLine().ToLower();

} while (check == "evet");

Console.WriteLine("Eklediginiz butun Filmler:");
foreach (var item in movies)
{
    Console.WriteLine($"Film: {item.Name}, IMDB Puanı: {item.Imdb}");

}
Console.WriteLine("IMDB Puanı 4 ile 9 arasında olan Filmler:");
foreach (var film in movies)
{
    if (film.Imdb >= 4 && film.Imdb <= 9)
    {
        Console.WriteLine($"Film: {film.Name}, IMDB Puanı: {film.Imdb}");
    }
}

Console.WriteLine("İsmi 'A' ile başlayan Filmler:");
foreach (var film in movies)
{
    if (film.Name.IndexOf('A', StringComparison.OrdinalIgnoreCase) == 0)//Using the index of func the checking the A
    {
        Console.WriteLine($"Film: {film.Name}, IMDB Puanı: {film.Imdb}");
    }
}

Console.ReadKey();
class Movies
{
    public double Imdb { get; set; }
    public string Name { get; set; }
    public Movies(string name,double imdb)
    {
        Name = name;
        Imdb = imdb;
        
    }


}
