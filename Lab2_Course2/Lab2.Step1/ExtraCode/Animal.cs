using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
abstract class Animal
{
    public string Name { get; set; }
    public int ChipId { get; set; }
    public string Breed { get; set; }
    public string Owner { get; set; }
    public string Phone { get; set; }
    public DateTime VaccinationDate { get; set; }
    public Animal(string name, int chipId, string breed, string owner, string phone,DateTime vaccinationDate)
    {
        Name = name;
        ChipId = chipId;
        Breed = breed;
        Owner = owner;
        Phone = phone;
        VaccinationDate = vaccinationDate;
    }
    public Animal(string data)
    {
        SetData(data);
    }
    public virtual void SetData(string line)
    {
        string[] values = line.Split(',');
        Name = values[1];
        ChipId = int.Parse(values[2]);
        Breed = values[3];
        Owner = values[4];
        Phone = values[5];
        VaccinationDate = DateTime.Parse(values[6]);
    }
    abstract public bool isVaccinationExpired();
    public override bool Equals(object obj)
    {
        return this.Equals(obj as Animal);
    }
    public bool Equals(Animal animal)
    {
        if (Object.ReferenceEquals(animal, null))
        {
            return false;
        }
        if (this.GetType() != animal.GetType())
        {
            return false;
        }
        return (ChipId == animal.ChipId) && (Name == animal.Name);
    }
    public override int GetHashCode()
    {
        return ChipId.GetHashCode() ^ Name.GetHashCode();
    }
    public virtual int CompareTo(object a1)
    {
        if (ChipId == (a1 as Animal).ChipId)
            return 0;
        else if (ChipId < (a1 as Animal).ChipId)
            return -1;
        else
            return 1;
    }
}