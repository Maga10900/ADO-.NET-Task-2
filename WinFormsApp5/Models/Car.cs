namespace WinFormsApp5.Models;

public class Car
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }


    public Car(int id,string marka, string model)
    {
        Id = id;
        Marka = marka;
        Model = model;
    }
    public Car()
    {

    }

    public override string ToString()
    {
        return $"{Id}\t\t{Marka}\t\t{Model}";
    }
}
