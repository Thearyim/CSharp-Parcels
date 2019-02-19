using System.Collections.Generic;

namespace Parcels.Models
{
  public class Parcel
  {
    private string _description;
    private int _length;
    private int _width;
    private int _weight;
    private int _height;
    private static List<Parcel> _instances = new List<Parcel> {};

    public Parcel (string description, int length, int width, int weight, int height)
    {
      _description = description;
      _length = length;
      _width = width;
      _weight = weight;
      _height = height;
      _instances.Add(this);
    }

    public string GetDescription()
    {
      return _description;
    }

    public void SetDescription(string newDescription)
    {
      _description = newDescription;
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public static List<Parcel> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public int GetVolume(int newLength, int newWidth, int newHeight)
    {
      return newLength * newWidth * newHeight;
    }

    public int GetCostToShip(int newWeight)
    {
      return newWeight * 2;
    }

  }
}
