public class Movie
{
    public string Title{get;set;}
    [Display(Name="Release Date")]
    [DataType(DataType.Date)]
    public DateTime ReleaseData{get;set;}

}