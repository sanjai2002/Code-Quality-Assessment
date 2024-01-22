using System.ComponentModel.DataAnnotations;
namespace CreateApi;
public class MovieModel{
    //   Required Properties are :  Movie Id, Movie Name, Movie Type, Movie Language and Movie Durations.
    public int id{get;set;}
    public string? Name{get;set;}

    public string? type{get;set;}

    public string? language{get;set;}

    public string? Durations{get;set;}  

}