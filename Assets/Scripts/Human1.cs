﻿// Refrences

// Constructor
// Scope -- Type  -- Name

public class Human1
{
    // Variables
    public int age;
    public float height;
    public float weitht;
    public bool generder;
    public string firstName, familyName;
    public bool hungry;
    public float energy;


    // Constructor
    public Human1(int _age, float _height, float _weight, bool _gender, string _firstName, string _familyName)
    {
        age = _age;
        height = _height;
        generder = _gender;
        firstName = _firstName;
        familyName  = _familyName;
        hungry = true;
        energy = 100;
    }

    // Functions  (Methods)
    public void DayInLife()
    {
        Ageing();
        Eating();
        Sleeping();
    }
    public string GetFirstName()
    {
        return firstName;
    }
    private void Ageing()
    {
        age = age + 1;
        energy = energy - 1;
    }
    public void Eating()
    {
        hungry = false;
        energy = energy - 1;
    }
    private void Sleeping()
    {
        hungry = true;
        energy = energy + 1;
    }

}
