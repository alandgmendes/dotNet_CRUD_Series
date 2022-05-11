namespace Series;
using System;
public class Serie:BaseEntity  {
    private Gender Gender {get; set;}
    private string Title {get; set;}
    private string Description {get; set;}
    private int Year {get; set;}

    public Series(int id, Gender gender, string title, string description, int year){
        this.Id = id;
        this.Gender = gender;
        this.Title = title;
        this.Description = description;
        this.Year = year;
    }

    public override ToString(){
        string ret = "";

        ret += "Gender: " + this.Gender + Environment.NewLine;
        ret += "Title: " + this.Title + Environment.NewLine;
        ret += "Description: " + this.Description + Environment.NewLine;
        ret += "Year: " + this.Year + Environment.NewLine;

        return ret;
    }
    public string getName(){
        return this.Title;
    }
    public int getId(){
        return this.Id;
    }
    public string getDescription(){
        return this.Description;
    }
}
